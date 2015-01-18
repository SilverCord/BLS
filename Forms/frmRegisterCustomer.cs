using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Configuration;
using System.Net.Mail;
using SmsClient;
using ASPSnippets.SmsAPI;


using LibraryDesign_frontEndUI.Forms;
using LibraryDesign_frontEndUI.Library;
using System.IO;

namespace LibraryDesign_frontEndUI
{
    public partial class frmRegisterCustomer : Form
    {
        LibMain _frmMainRef = null;
        int _intDOBCounter = 1;
        int _intDORCounter = 1;

        public delegate void delSendSMS(string strMessage, string strMobileNumber);
        public delegate void delSendEmail(string strToEmailAddress, string strMembershipNo, string strRecieptNo, string strAmountPaid, string strRegistrationDate, string strMembershipFee, Utility.CustomerType type);

        public frmRegisterCustomer(LibMain frmMainRef)
        {
            InitializeComponent();
            _frmMainRef = frmMainRef;
            lblDOR.Visible = false;
            dtpDOR.Visible = false;
            dtpDob.Text = dtpDOR.Text = DateTime.UtcNow.ToString("dd/MM/yyyy");
            chkExisting.Checked = true;
            //txtCourse.SelectedIndex = 0;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Cancelling may cause the form to close.\n Data entered may be lost. Are you sure?", "Cancel Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                _frmMainRef.btnCustomer.Enabled = true;
                this.Close();
            }



        }

        /**********************************************************************************
        * Modified By : Shankar
        * Changed int CustomerID to string CustomerID
        **********************************************************************************/
        private void button2_Click(object sender, EventArgs e)
        {
            BusinessLogic BL = new BusinessLogic();
            string strDestinationPath = string.Empty;

            try
            {
                if (ValidateAllFields())
                {
                    string strCustomerID = "";

                    if (chkExisting.Checked)
                    {
                        if (!BL.IsCustomerExist(txtNumber.Text))
                        {
                            strCustomerID = txtNumber.Text;
                        }
                        else
                        {
                            MessageBox.Show("This customer record already added.\n Please goto Search->Edit and then edit customer details.", "Customer exist");
                            return;
                        }
                    }
                    else
                    {
                        strCustomerID = GetFreshCustomerID();
                    }

                    BLSSchema.ctCustomerDataTable dtCustomer = new BLSSchema.ctCustomerDataTable();

                    BLSSchema.ctCustomerRow row = dtCustomer.NewctCustomerRow();

                    string strMemberShipType = _frmMainRef.GetCustomerType(txtMembershipType.Text);

                    #region [Calculate Max Limit]

                    float maxLimit = Program.MainObj.GetMaxLimit(strMemberShipType, float.Parse(txtDepositAmount.Text));


                    #endregion

                    #region [Calculate MemberShipNumber]
                    string strReceiptNumber = string.Empty;

                    #endregion

                    if (string.IsNullOrWhiteSpace(txtCustImagePath.Text) != true)
                    {
                        //Copy customer image to destination folder
                        strDestinationPath = Program.MainObj.CopyCustomerImage(txtCustImagePath.Text, Path.GetExtension(txtCustImagePath.Text.Trim()), strCustomerID);
                    }

                    #region [Construct Customer Table]
                    row.CustomerID = strCustomerID;
                    row.CustName = txtName.Text;
                    row.Father_Name = txtFatherName.Text;
                    row.DOB = dtpDob.Value.ToString("yyyy-MM-dd").Substring(0, 10);
                    row.Parent_Phone = txtParenPhone.Text;
                    row.Parent_Mobile = txtParentMobile.Text;
                    row.Student_Mobile = txStudenttMobile.Text;
                    row.Address = txtAddress.Text;
                    row.CollegeName = txtCollegeName.Text;
                    row.Course = txtCourse.Text;
                    row.CourseDuration = txtCourseDuration.Text;
                    row.EmailID = txtEmail.Text;
                    row.MembershipDate = (chkExisting.Checked) ? dtpDOR.Value.ToString("yyyy-MM-dd").Substring(0, 10) : DateTime.UtcNow.ToString("yyyy-MM-dd").Substring(0, 10);
                    row.MembershipType = strMemberShipType;
                    row.MembershipPeriod = txtMemberShipPeriod.Text;
                    if (strMemberShipType == "N")
                    {
                        row.MembershipPeriod = txtCourseDuration.Text;
                    }
                    else
                    {
                        row.MembershipPeriod = "-1";
                    }
                    row.Activation = "1";
                    row.EarlyActivation = (chkExisting.Checked) ? "1" : "0";
                    row.BookCount = "0";
                    row.DepositAmount = txtDepositAmount.Text;
                    row.AdvanceAmount = txtAdvanceAmount.Text;
                    row.BalanceAmount = txtBalanceamount.Text;
                    row.RefundAmount = "0";
                    if (string.IsNullOrWhiteSpace(txtReciptNo.Text))
                    {
                        if (!chkExisting.Checked)
                        {
                            row.RecieptNumber = strReceiptNumber = GetReceiptNumber();
                        }
                        else
                        {
                            row.RecieptNumber = strReceiptNumber = "";
                        }
                    }
                    else
                    {
                        row.RecieptNumber = strReceiptNumber = txtReciptNo.Text;
                    }
                    row.MaxLimit = maxLimit.ToString();
                    if (strMemberShipType == "N")
                    {
                        row.UsedLimit = "0";
                    }
                    else
                    {
                        row.UsedLimit = "-1";
                    }
                    row.ImagePath = (string.IsNullOrWhiteSpace(txtCustImagePath.Text)) ? "N/A" : strDestinationPath;
                    dtCustomer.Rows.Add(row);

                    DataTable dtNewCustomer = GetRawDataTable(dtCustomer);
                    #endregion

                    if (BL.AddCustomer(dtNewCustomer, row.Student_Mobile, row.CustName))
                    {
                        if (string.IsNullOrWhiteSpace(txtReciptNo.Text))
                        {
                            //BL.InsertReceipt(row.RecieptNumber, "");
                        }

                        //if (chkExisting.Checked)
                        //{
                        //frmStudentRegister2 frmAddBooks = new frmStudentRegister2(row.CustName, row.Student_Mobile, row.AdvanceAmount, row.BalanceAmount);
                        //frmAddBooks._intCustomerId = row.CustomerID;
                        //frmAddBooks._strMemberShipType = row.MembershipType;
                        //frmAddBooks._intMemberShipPeriod = int.Parse(row.MembershipPeriod);
                        //frmAddBooks.ShowDialog();
                        //Close();
                        //}
                        //else
                        //{
                        if (!chkExisting.Checked)
                        {
                            MessageBox.Show(" Registration process completed.\n Membership Number : " + strCustomerID + ".\n Receipt Number : " + strReceiptNumber, "Done");
                            //Send Message to customer.
                            if (chkSendSMS.Checked && chkSendSMS.Visible == true)
                            {
                                delSendSMS SendSMS = new delSendSMS(Utility.SendSMS);
                                //Thank you for registering with Treasure Island
                                SendSMS.BeginInvoke(string.Format("Registration successfull.\nMemberShip No : {0}\nReceipt Number : {1}\nReg. date :{2}\n", strCustomerID,
                                      strReceiptNumber, DateTime.Now.ToShortDateString()), txStudenttMobile.Text, null, null);
                            }
                            if (chkSendEmail.Checked && chkSendEmail.Visible == true)
                            {
                                if (string.IsNullOrWhiteSpace(txtEmail.Text) != true)
                                {
                                    Utility.CustomerType ct;
                                    Enum.TryParse<Utility.CustomerType>(txtMembershipType.Text, out ct);

                                    delSendEmail delEmail = new delSendEmail(Utility.RegistrationSuccessEmail);
                                    delEmail.BeginInvoke(txtEmail.Text.Trim(), strCustomerID.ToString(), strReceiptNumber, txtDepositAmount.Text,
                                        DateTime.Now.ToShortDateString(), txtDepositAmount.Text, ct, null, null);
                                }
                            }
                        }
                        else
                        {
                            string strMessage = "Registration process completed.\n Membership Number : " + strCustomerID;
                            if (strReceiptNumber != "")
                            {
                                strMessage += ".\n Receipt Number : " + strReceiptNumber;
                            }
                            Program.MainObj.SpeakText("Registration process completed.");
                            MessageBox.Show(strMessage, "Done");
                            txtNumber.Focus();
                        }

                        // Program.MainObj._DbBack.TakeDifferentialBackUp();

                        //Close();
                        ResetAllFields();
                    }
                    else
                    {
                        MessageBox.Show("User already exist", "Error");
                    }
                }
            }
            catch (Exception ex)
            {
                //log exception
                Utility.WriteToFile(ex, "Error occured while adding new user");

                MessageBox.Show("Error occured while adding new user : " + ex.ToString(), "Error");
            }
        }


        internal DataTable GetRawDataTable(DataTable dtTable)
        {
            DataTable dtRawDataTable = new DataTable();

            foreach (DataColumn cloumn in dtTable.Columns)
            {
                dtRawDataTable.Columns.Add(cloumn.ColumnName, cloumn.DataType);
            }

            foreach (DataRow dr in dtTable.Rows)
            {
                dtRawDataTable.ImportRow(dr);
            }

            return dtRawDataTable;

        }

        private bool ValidateAllFields()
        {
            try
            {
                //here validate all the fields one by one
                //If any field is empty then display appropriate message
                //Refer Add stock form
                if (string.IsNullOrWhiteSpace(txtNumber.Text) && chkExisting.Checked)
                {
                    MessageBox.Show("Membership Number field is empty", "Error");
                    lblNumber.ForeColor = System.Drawing.Color.Red;
                    return false;
                }

                lblNumber.ForeColor = System.Drawing.Color.Lime;


                if (string.IsNullOrWhiteSpace(txtName.Text))
                {
                    MessageBox.Show("First name field is empty", "Error");
                    lblfirstName.ForeColor = System.Drawing.Color.Red;
                    return false;
                }

                lblfirstName.ForeColor = System.Drawing.Color.Lime;


                if (string.IsNullOrWhiteSpace(txtFatherName.Text))
                {
                    MessageBox.Show("Father's name field is empty", "Error");
                    lblFatherName.ForeColor = System.Drawing.Color.Red;
                    return false;
                }

                lblFatherName.ForeColor = System.Drawing.Color.Lime;

                DateTime dtDOB = DateTime.Parse(dtpDob.Value.ToString());


                if (dtDOB >= DateTime.Today)
                {
                    MessageBox.Show("Incorrect birth date", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    lblDOB.ForeColor = System.Drawing.Color.Red;
                    return false;
                }

                lblDOB.ForeColor = System.Drawing.Color.Lime;

                if (string.IsNullOrWhiteSpace(txStudenttMobile.Text))
                {
                    if (!chkExisting.Checked)
                    {
                        MessageBox.Show("Mobile field is empty", "Error");
                        lblMobile.ForeColor = System.Drawing.Color.Red;
                        return false;
                    }
                    else
                    {
                        txStudenttMobile.Text = "0000000000";
                    }
                }
                else if (txStudenttMobile.Text.Length < 10)
                {
                    MessageBox.Show("Invalid mobile number", "Error");
                    lblMobile.ForeColor = System.Drawing.Color.Red;
                    return false;
                }

                lblMobile.ForeColor = System.Drawing.Color.Lime;

                if (!string.IsNullOrWhiteSpace(txtEmail.Text))
                {
                    //Fixed Email ID validation problem
                    //System.Text.RegularExpressions.Regex rEMail = new System.Text.RegularExpressions.Regex(@"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$");                   
                    System.Text.RegularExpressions.Regex rEMail = new System.Text.RegularExpressions.Regex(@"^[_a-z0-9-]+(\.[_a-z0-9-]+)*@[a-z0-9-]+(\.[a-z0-9-]+)*(\.[a-z]{2,4})$");
            
                    if (txtEmail.Text.Length > 0)
                    {
                        if (!rEMail.IsMatch(txtEmail.Text))
                        {
                            MessageBox.Show("Incorrect E-Mail", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            //lblEmailID.ForeColor = System.Drawing.Color.Red;
                            return false;
                        }
                    }
                }

                if (string.IsNullOrWhiteSpace(txtCollegeName.Text))
                {
                    MessageBox.Show("College name field is empty", "Error");
                    lblCollegeName.ForeColor = System.Drawing.Color.Red;
                    return false;
                }

                lblCollegeName.ForeColor = System.Drawing.Color.Lime;

                if (string.IsNullOrWhiteSpace(txtCourse.Text))
                {
                    MessageBox.Show("Course field is empty", "Error");
                    lblCourse.ForeColor = System.Drawing.Color.Red;
                    return false;
                }

                lblCourse.ForeColor = System.Drawing.Color.Lime;

                if (string.IsNullOrWhiteSpace(txtCourseDuration.Text))
                {
                    MessageBox.Show("Course duration field is empty", "Error");
                    lblDuration.ForeColor = System.Drawing.Color.Red;
                    return false;
                }

                lblDuration.ForeColor = System.Drawing.Color.Lime;

                if (string.IsNullOrWhiteSpace(txtMembershipType.Text) && (txtMembershipType.Text == "Rental"))
                {
                    MessageBox.Show("Membership type field is empty", "Error");
                    lblMembType.ForeColor = System.Drawing.Color.Red;
                    return false;
                }
                else if (string.IsNullOrWhiteSpace(txtMembershipType.Text) && (txtMembershipType.Text != "Rental"))
                {
                    txtMemberShipPeriod.Text = "-1";
                }

                lblMembType.ForeColor = System.Drawing.Color.Lime;

                if (string.IsNullOrWhiteSpace(txtMemberShipPeriod.Text) && ((txtMembershipType.Text != "Non-Rental") && (txtMembershipType.Text != "Other")))
                {
                    MessageBox.Show("Membership period field is empty", "Error");
                    lblMembPeriod.ForeColor = System.Drawing.Color.Red;
                    return false;
                }

                lblMembPeriod.ForeColor = System.Drawing.Color.Lime;

                if (!string.IsNullOrWhiteSpace(txtDepositAmount.Text))
                {
                    decimal value;
                    if (!Decimal.TryParse(txtDepositAmount.Text, out value))
                    {
                        MessageBox.Show("Please enter valid deposit amount", "Error");
                        lblDepositAmount.ForeColor = System.Drawing.Color.Red;
                        return false;
                    }

                }
                else if (string.IsNullOrWhiteSpace(txtDepositAmount.Text) && txtMembershipType.Text == "Non-Rental")
                {
                    if (!chkExisting.Checked)
                    {
                        MessageBox.Show("Deposit amount field is empty", "Error");
                        lblDepositAmount.ForeColor = System.Drawing.Color.Red;
                        return false;
                    }
                    else
                    {
                        txtDepositAmount.Text = "0";
                    }
                }
                else if (string.IsNullOrWhiteSpace(txtDepositAmount.Text) && (txtMembershipType.Text == "Rental" || txtMembershipType.Text == "Other"))
                {
                    txtDepositAmount.Text = "0";
                }

                lblDepositAmount.ForeColor = System.Drawing.Color.Lime;

                if (!string.IsNullOrWhiteSpace(txtAdvanceAmount.Text))
                {
                    decimal value;
                    if (!Decimal.TryParse(txtAdvanceAmount.Text, out value))
                    {
                        MessageBox.Show("Please enter valid advance amount", "Error");

                        return false;
                    }
                    //if(txtAdvanceAmount.Text
                }
                else
                {
                    txtAdvanceAmount.Text = "0";
                }

                if (!string.IsNullOrWhiteSpace(txtBalanceamount.Text))
                {
                    decimal value;
                    if (!Decimal.TryParse(txtBalanceamount.Text, out value))
                    {
                        MessageBox.Show("Please enter valid balance amount", "Error");
                        return false;
                    }

                }
                else
                {
                    txtBalanceamount.Text = "0";
                }


                //if (string.IsNullOrWhiteSpace(txtReciptNo.Text) && (txtMembershipType.Text == "Non-Rental"))
                //{
                //    MessageBox.Show("Receipt Number field is empty", "Error");
                //    //lblMembType.ForeColor = System.Drawing.Color.Red;
                //    return false;
                //}


                return true;
            }
            catch (Exception ex)
            {
                //log exception
                Utility.WriteToFile(ex);

                throw new ApplicationException(ex.ToString());
            }
        }

        private void GetValidAmount(decimal value)
        {
            string sValue = value.ToString();
            string Result;
            if (sValue.Contains('.') == false)
            {//if not . in amt
                Result = value + ".00";
            }
            //else if (sValue.StartsWith(".") == true)
            //{//if starts with .
            //    //Result="0."
            //}
            else
            {
                if (sValue.Length > sValue.IndexOf('.') + 2)
                    Result = sValue.Substring(sValue.IndexOf('.') + 2);
                Result = sValue.Substring(sValue.IndexOf('.') + 2);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you really want to clear all data?", "Clear Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                ResetAllFields();
            }


        }

        private void ResetAllFields()
        {
            txtNumber.Text = "";
            txtName.Text = "";
            txtFatherName.Text = "";
            txtParenPhone.Text = "";
            txtParentMobile.Text = "";
            txStudenttMobile.Text = "";
            txtEmail.Text = "";
            txtAddress.Text = "";
            txtCollegeName.Text = "";
            txtCourse.Text = "";
            txtCourseDuration.Text = "";
            txtMembershipType.SelectedIndex = -1;
            txtMemberShipPeriod.Text = "";
            txtDepositAmount.Text = "";
            txtAdvanceAmount.Text = "";
            txtBalanceamount.Text = "";
            txtReciptNo.Text = "";
            if (!chkExisting.Checked)
            {
                chkSendEmail.Checked = true;
                chkSendSMS.Checked = true;
            }
            dtpDob.ResetText();
            txtMembershipType.SelectedIndex = 0;
            txtCustImagePath.Text = "";
        }

        private void frmRegisterCustomer_Load(object sender, EventArgs e)
        {
            this.BringToFront();
            this.Focus();
            this.KeyPreview = true;

            txtMembershipType.SelectedIndex = 0;
            //txtNumber.ReadOnly = true;
        }

        /**********************************************************************************
        * Modified By : Shankar
        * Changed int CustomerID to string CustomerID
        **********************************************************************************/
        /// <summary>
        /// Returns fresh customerid for new customer.
        /// Generate the fresh customer id like - 2013140002
        /// Here 201314 is taken from the academic year
        /// If current month is between June to May use the format 201415
        /// otherwise use 201314
        /// </summary>
        /// <returns></returns>
        internal string GetFreshCustomerID()
        {
            string strFreshCustID = string.Empty;
            int intMonth = 0;
            int intAcademicYear = 0;

            BusinessLogic bl = new BusinessLogic();
            int intCustomerID = bl.GetCustomerID(_frmMainRef._intStartMembershipNumber);

            DateTime dt = DateTime.Now;
            intMonth = dt.Month;

            intAcademicYear = int.Parse(dt.ToString("dd-MM-yyyy").Substring(6, 4));

            //previous academic year
            if (intMonth < 6)
            {
                strFreshCustID = (intAcademicYear - 1).ToString() + intAcademicYear.ToString().Substring(2, 2) + intCustomerID.ToString().PadLeft(4, '0');
            }
            else //current academic year
            {
                strFreshCustID = intAcademicYear + (intAcademicYear + 1).ToString().Substring(2, 2) + intCustomerID.ToString().PadLeft(4, '0');
            }

            return strFreshCustID;
        }

        internal string GetReceiptNumber()
        {
            BusinessLogic bl = new BusinessLogic();

            string strLatestReceiptNumber = bl.GetReceiptNumber();

            return strLatestReceiptNumber;

        }

        private void frmRegisterCustomer_FormClosing(object sender, FormClosingEventArgs e)
        {
            _frmMainRef.btnCustomer.Enabled = true;
        }

        private void txtMembershipType_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtAdvanceAmount.Text = "0";
            txtBalanceamount.Text = "0";
            txtReciptNo.Text = "";
            txtMemberShipPeriod.Text = "0";

            if (txtMembershipType.Text == "Rental")
            {
                txtAdvanceAmount.Visible = true;
                txtBalanceamount.Visible = true;
                txtReciptNo.Visible = true;
                txtMemberShipPeriod.Visible = true;
                lblAdvanceAmount.Visible = true;
                lblBalanceAmount.Visible = true;
                lblRciptNo.Visible = true;
                lblMemberShipPeriod.Visible = true;
                lblMonth.Visible = true;
                lblMembPeriod.Visible = true;
                label6.Visible = false;
                txtDepositAmount.Visible = false;
                lblDepositAmount.Visible = false;
            }
            else if (txtMembershipType.Text == "Non-Rental")
            {
                txtAdvanceAmount.Visible = false;
                txtBalanceamount.Visible = false;
                txtReciptNo.Visible = false;
                txtMemberShipPeriod.Visible = false;
                lblAdvanceAmount.Visible = false;
                lblBalanceAmount.Visible = false;
                lblRciptNo.Visible = false;
                lblMemberShipPeriod.Visible = false;
                lblMonth.Visible = false;
                lblMembPeriod.Visible = false;
                label6.Visible = true;
                txtDepositAmount.Visible = true;
                lblDepositAmount.Visible = true;
            }
            else
            {
                txtAdvanceAmount.Visible = false;
                txtBalanceamount.Visible = false;
                txtReciptNo.Visible = false;
                txtMemberShipPeriod.Visible = false;
                lblAdvanceAmount.Visible = false;
                lblBalanceAmount.Visible = false;
                lblRciptNo.Visible = false;
                lblMemberShipPeriod.Visible = false;
                lblMonth.Visible = false;
                lblMembPeriod.Visible = false;
                label6.Visible = false;
                txtDepositAmount.Visible = false;
                lblDepositAmount.Visible = false;
            }
        }

        //private void Course_Validation(object sender, KeyPressEventArgs e)
        //{
        //    Char pressedKey = e.KeyChar;
        //    if (Char.IsLetter(pressedKey) || (int)pressedKey == 45 || (int)pressedKey == 47 || (int)pressedKey == 8)
        //    {
        //        // Allow input.
        //        e.Handled = false;
        //    }
        //    else
        //        // Stop the character from being entered into the control since not a letter, nor punctuation, nor a space.
        //        e.Handled = true;
        //}

        private void chkExisting_CheckedChanged(object sender, EventArgs e)
        {
            if (chkExisting.Checked)
            {
                if (txtNumber.ReadOnly)
                {
                    txtNumber.ReadOnly = false;
                }
                txtNumber.BackColor = System.Drawing.Color.White;
                dtpDOR.Visible = true;
                lblDOR.Visible = true;
                chkSendEmail.Visible = false;
                chkSendEmail.Checked = false;
                chkSendSMS.Visible = false;
                chkSendSMS.Checked = false;
                txtNumber.BackColor = System.Drawing.Color.Khaki;
            }
            else
            {
                txtNumber.Text = "";
                txtNumber.ReadOnly = true;
                txtNumber.BackColor = System.Drawing.Color.Silver;
                dtpDOR.Visible = false;
                lblDOR.Visible = false;
                chkSendEmail.Visible = true;
                chkSendEmail.Checked = true;
                chkSendSMS.Visible = true;
                chkSendSMS.Checked = true;
            }
        }

        private void txtCourseDuration_TextChanged(object sender, EventArgs e)
        {
            txtMemberShipPeriod.Text = "";
            txtMemberShipPeriod.Text = txtCourseDuration.Text;
        }

        private void M_Number_Validation(object sender, KeyPressEventArgs e)
        {
            if (chkExisting.Checked)
            {
                Char pressedKey = e.KeyChar;
                if (Char.IsNumber(pressedKey) || (int)pressedKey == 8)
                {
                    // Allow input.
                    e.Handled = false;
                }
                else
                {
                    // Stop the character from being entered into the control since not a letter, nor punctuation, nor a space.
                    e.Handled = true;
                    MessageBox.Show("Only Numbers are allowed here.", "Only numbers.!");
                }
            }
        }


        #region [Events]

        private void txtName_Enter(object sender, EventArgs e)
        {
            if (chkExisting.Checked && txtNumber.BackColor == System.Drawing.Color.Khaki)
            {
                txtNumber.BackColor = System.Drawing.Color.White;
            }

            Program.MainObj.ActivateOrDeAcivateTextBox(sender, true);
            Program.MainObj.SpeakText("Customer name");
        }

        private void txtName_Leave(object sender, EventArgs e)
        {
            Program.MainObj.ActivateOrDeAcivateTextBox(sender, false);
        }

        private void txtAddress_Enter(object sender, EventArgs e)
        {
            Program.MainObj.ActivateOrDeAcivateTextBox(sender, true);
            Program.MainObj.SpeakText("Address");
        }

        private void txtAddress_Leave(object sender, EventArgs e)
        {
            Program.MainObj.ActivateOrDeAcivateTextBox(sender, false);
        }

        private void txStudenttMobile_Enter(object sender, EventArgs e)
        {
            Program.MainObj.ActivateOrDeAcivateTextBox(sender, true);
            Program.MainObj.SpeakText("Customer mobile number");
        }

        private void txStudenttMobile_Leave(object sender, EventArgs e)
        {
            Program.MainObj.ActivateOrDeAcivateTextBox(sender, false);
        }

        private void txtFatherName_Enter(object sender, EventArgs e)
        {
            Program.MainObj.ActivateOrDeAcivateTextBox(sender, true);
            Program.MainObj.SpeakText("Parent Name");
        }

        private void txtFatherName_Leave(object sender, EventArgs e)
        {
            Program.MainObj.ActivateOrDeAcivateTextBox(sender, false);
        }

        private void txtParenPhone_Enter(object sender, EventArgs e)
        {
            Program.MainObj.ActivateOrDeAcivateTextBox(sender, true);
            Program.MainObj.SpeakText("Land line number");
        }

        private void txtParenPhone_Leave(object sender, EventArgs e)
        {
            Program.MainObj.ActivateOrDeAcivateTextBox(sender, false);
        }

        private void txtParentMobile_Enter(object sender, EventArgs e)
        {
            Program.MainObj.ActivateOrDeAcivateTextBox(sender, true);
            Program.MainObj.SpeakText("Parent mobile number");
        }

        private void txtParentMobile_Leave(object sender, EventArgs e)
        {
            Program.MainObj.ActivateOrDeAcivateTextBox(sender, false);
        }

        private void txtEmail_Enter(object sender, EventArgs e)
        {
            Program.MainObj.ActivateOrDeAcivateTextBox(sender, true);
            Program.MainObj.SpeakText("Email ID");
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            Program.MainObj.ActivateOrDeAcivateTextBox(sender, false);
        }

        private void txtCollegeName_Enter(object sender, EventArgs e)
        {
            Program.MainObj.ActivateOrDeAcivateTextBox(sender, true);
            Program.MainObj.SpeakText("College name");
        }

        private void txtCollegeName_Leave(object sender, EventArgs e)
        {
            Program.MainObj.ActivateOrDeAcivateTextBox(sender, false);
        }

        private void txtCourse_Enter(object sender, EventArgs e)
        {
            Program.MainObj.ActivateOrDeAcivateTextBox(sender, true);
        }

        private void txtCourse_Leave(object sender, EventArgs e)
        {
            Program.MainObj.ActivateOrDeAcivateTextBox(sender, false);
        }

        private void txtCourseDuration_Enter(object sender, EventArgs e)
        {
            Program.MainObj.ActivateOrDeAcivateTextBox(sender, true);
            Program.MainObj.SpeakText("Course duration");
        }

        private void txtCourseDuration_Leave(object sender, EventArgs e)
        {
            Program.MainObj.ActivateOrDeAcivateTextBox(sender, false);
        }

        private void txtDepositAmount_Enter(object sender, EventArgs e)
        {
            Program.MainObj.ActivateOrDeAcivateTextBox(sender, true);
        }

        private void txtDepositAmount_Leave(object sender, EventArgs e)
        {
            Program.MainObj.ActivateOrDeAcivateTextBox(sender, false);
        }

        private void txtReciptNo_Enter(object sender, EventArgs e)
        {
            Program.MainObj.ActivateOrDeAcivateTextBox(sender, true);
        }

        private void txtReciptNo_Leave(object sender, EventArgs e)
        {
            Program.MainObj.ActivateOrDeAcivateTextBox(sender, false);
        }

        private void txtMemberShipPeriod_Enter(object sender, EventArgs e)
        {
            Program.MainObj.ActivateOrDeAcivateTextBox(sender, true);
        }

        private void txtMemberShipPeriod_Leave(object sender, EventArgs e)
        {
            Program.MainObj.ActivateOrDeAcivateTextBox(sender, false);
        }

        private void txtAdvanceAmount_Enter(object sender, EventArgs e)
        {
            Program.MainObj.ActivateOrDeAcivateTextBox(sender, true);
        }

        private void txtAdvanceAmount_Leave(object sender, EventArgs e)
        {
            Program.MainObj.ActivateOrDeAcivateTextBox(sender, false);
        }

        private void txtBalanceamount_Enter(object sender, EventArgs e)
        {
            Program.MainObj.ActivateOrDeAcivateTextBox(sender, true);
        }

        private void txtBalanceamount_Leave(object sender, EventArgs e)
        {
            Program.MainObj.ActivateOrDeAcivateTextBox(sender, false);
        }

        private void txtNumber_Enter(object sender, EventArgs e)
        {
            if (chkExisting.Checked)
            {
                Program.MainObj.ActivateOrDeAcivateTextBox(sender, true);
            }
            Program.MainObj.SpeakText("Membership ID");

        }

        private void txtNumber_Leave(object sender, EventArgs e)
        {
            if (chkExisting.Checked)
            {
                Program.MainObj.ActivateOrDeAcivateTextBox(sender, false);
            }

        }

        #endregion

        private void txStudenttMobile_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.MainObj.Number_Validation(sender, e);
        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char pressedKey = e.KeyChar;
            Program.MainObj.Name_Validation(sender, e);
            if ((int)pressedKey == 27)//Keypressed is Escape.
            {
                txtName.Focus();
                lbxNameContainer.Visible = false;
            }
            else if ((int)pressedKey == 50)
            {
                if (lbxNameContainer.Visible && lbxNameContainer.SelectedIndex + 1 < lbxNameContainer.Items.Count)
                {
                    lbxNameContainer.SelectedIndex = lbxNameContainer.SelectedIndex + 1;
                }
            }
            else if ((int)pressedKey == 56)
            {
                if (lbxNameContainer.Visible && lbxNameContainer.SelectedIndex - 1 != -1)
                {
                    lbxNameContainer.SelectedIndex = lbxNameContainer.SelectedIndex - 1;
                }
            }
            else if ((int)pressedKey == 13)
            {
                if (lbxNameContainer.Visible && lbxNameContainer.SelectedIndex != -1)
                {
                    txtName.Text = lbxNameContainer.Text;
                    lbxNameContainer.Visible = false;
                    txtName.Focus();
                }
            }
        }

        private void txtFatherName_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char pressedKey = e.KeyChar;
            Program.MainObj.Name_Validation(sender, e);
            if ((int)pressedKey == 27)//Keypressed is Escape.
            {
                txtFatherName.Focus();
                lbxFatherNameContainer.Visible = false;
            }
            else if ((int)pressedKey == 50)
            {
                if (lbxFatherNameContainer.Visible && lbxFatherNameContainer.SelectedIndex + 1 < lbxFatherNameContainer.Items.Count)
                {
                    lbxFatherNameContainer.SelectedIndex = lbxFatherNameContainer.SelectedIndex + 1;
                }
            }
            else if ((int)pressedKey == 56)
            {
                if (lbxFatherNameContainer.Visible && lbxFatherNameContainer.SelectedIndex - 1 != -1)
                {
                    lbxFatherNameContainer.SelectedIndex = lbxFatherNameContainer.SelectedIndex - 1;
                }
            }
            else if ((int)pressedKey == 13)
            {
                if (lbxFatherNameContainer.Visible && lbxFatherNameContainer.SelectedIndex != -1)
                {
                    txtFatherName.Text = lbxFatherNameContainer.Text;
                    lbxFatherNameContainer.Visible = false;
                    txtFatherName.Focus();
                }
            }
        }

        private void txtParenPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.MainObj.Number_Validation(sender, e);
        }

        private void txtParentMobile_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.MainObj.Number_Validation(sender, e);
        }

        private void txtCollegeName_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char pressedKey = e.KeyChar;
            Program.MainObj.Name_Validation(sender, e);
            if ((int)pressedKey == 27)//Keypressed is Escape.
            {
                txtCollegeName.Focus();
                lbxCollegeContainer.Visible = false;
            }
            else if ((int)pressedKey == 50)
            {
                if (lbxCollegeContainer.Visible && lbxCollegeContainer.SelectedIndex + 1 < lbxCollegeContainer.Items.Count)
                {
                    lbxCollegeContainer.SelectedIndex = lbxCollegeContainer.SelectedIndex + 1;
                }
            }
            else if ((int)pressedKey == 56)
            {
                if (lbxCollegeContainer.Visible && lbxCollegeContainer.SelectedIndex - 1 != -1)
                {
                    lbxCollegeContainer.SelectedIndex = lbxCollegeContainer.SelectedIndex - 1;
                }
            }
            else if ((int)pressedKey == 13)
            {
                if (lbxCollegeContainer.Visible && lbxCollegeContainer.SelectedIndex != -1)
                {
                    txtCollegeName.Text = lbxCollegeContainer.Text;
                    lbxCollegeContainer.Visible = false;
                    txtCollegeName.Focus();
                }
            }
        }

        private void txtCourse_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.MainObj.Name_Validation(sender, e);

        }

        private void txtCourseDuration_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.MainObj.Number_Validation(sender, e);
        }

        private void txtDepositAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.MainObj.Amount_Validation(sender, e);
        }

        private void txtReciptNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.MainObj.Receipt_Validation(sender, e);
        }

        private void txtMemberShipPeriod_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.MainObj.Number_Validation(sender, e);
        }

        private void txtAdvanceAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.MainObj.Amount_Validation(sender, e);
        }

        private void txtBalanceamount_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.MainObj.Amount_Validation(sender, e);
        }

        private void txtImagePath_Click(object sender, EventArgs e)
        {
            //OpenFileDialog openFileDialog1 = new OpenFileDialog();
            //openFileDialog1.ShowDialog();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openImageDialog = new OpenFileDialog();

            openImageDialog.InitialDirectory = @"C:\";
            openImageDialog.Title = "Browse Text Files";

            openImageDialog.CheckFileExists = true;
            openImageDialog.CheckPathExists = true;

            openImageDialog.DefaultExt = "jpg";
            openImageDialog.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            openImageDialog.FilterIndex = 2;
            openImageDialog.RestoreDirectory = true;

            openImageDialog.ReadOnlyChecked = true;
            openImageDialog.ShowReadOnly = true;

            if (openImageDialog.ShowDialog() == DialogResult.OK)
            {
                txtCustImagePath.Text = openImageDialog.FileName;
            }
        }

        #region Texbox Autocomplete Events

        private void txtCollegeName_KeyUp(object sender, KeyEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCollegeName.Text)) return;
            if (e.KeyValue != 27 && e.KeyValue != 13 && e.KeyValue != 98 && e.KeyValue != 104)
            {
                GetAutoCompletionList(lbxCollegeContainer, "CollegeName", txtCollegeName.Text.Trim());
            }
        }

        private void lbxCollegeContainer_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtCollegeName.Text))
            {
                txtCollegeName.Text = lbxCollegeContainer.Text;
                lbxCollegeContainer.Visible = false;
            }
            else
            {
                lbxCollegeContainer.Visible = false;
            }
        }

        private void txtName_KeyUp(object sender, KeyEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text)) return;

            if (e.KeyValue != 27 && e.KeyValue != 13 && e.KeyValue != 98 && e.KeyValue != 104)
            {
                GetAutoCompletionList(lbxNameContainer, "Name", txtName.Text.Trim());
            }

        }

        private void lbxNameContainer_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtName.Text))
            {
                txtName.Text = lbxNameContainer.Text;
                lbxNameContainer.Visible = false;
            }
            else
            {
                lbxNameContainer.Visible = false;
            }
        }


        private void txtFatherName_KeyUp(object sender, KeyEventArgs e)
        {
            //if (string.IsNullOrWhiteSpace(txtFatherName.Text)) return;

            //GetAutoCompletionList(lbxFatherNameContainer,"[Father Name]", txtFatherName.Text.Trim());
        }

        private void lbxFatherNameContainer_Click(object sender, EventArgs e)
        {
            //if (!string.IsNullOrWhiteSpace(txtFatherName.Text))
            //{
            //    txtFatherName.Text = lbxCollegeContainer.Text;
            //    lbxFatherNameContainer.Visible = false;
            //}
            //else
            //{
            //    lbxFatherNameContainer.Visible = false;
            //}
        }

        private void txtAddress_KeyUp(object sender, KeyEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAddress.Text)) return;

            //GetAutoCompletionList(lbxAddressContainer, "Address", txtAddress.Text.Trim());
        }

        private void lbxAddressContainer_Click(object sender, EventArgs e)
        {

        }

        private void GetAutoCompletionList(ListBox lbx, string strFilterName, string strFilterValue)
        {
            try
            {
                BusinessLogic BLgc = new BusinessLogic();

                BLSSchema.ctCustomerForAutoCompleteDataTable ctCust = BLgc.SearchCustomerDetail(strFilterName, strFilterValue);
                if (ctCust.Count > 0)
                {
                    lbx.DataSource = ctCust;
                    lbx.DisplayMember = strFilterName;
                    lbx.ValueMember = strFilterName;
                    lbx.Visible = true;
                }
                else
                {
                    lbx.Visible = false;
                }
            }
            catch (Exception ex)
            {
                //log exception
                Utility.WriteToFile(ex, "Error occured while retrieving customer records.");
            }
        }


        #endregion

        private void txtCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            int Duration = Program.MainObj.dictCourseDuration[txtCourse.Text];
            txtMemberShipPeriod.Text = txtCourseDuration.Text = Duration.ToString();

        }

        private void label11_Enter(object sender, EventArgs e)
        {
            Program.MainObj.SpeakText("Parent name");
        }

        private void txtCourse_Enter_1(object sender, EventArgs e)
        {
            Program.MainObj.SpeakText("Course");
        }

        private void txtMembershipType_Enter(object sender, EventArgs e)
        {
            Program.MainObj.SpeakText("Membership type");
        }

        private void btnrOK_Enter(object sender, EventArgs e)
        {
            Program.MainObj.SpeakText("Press enter to save the details.");
        }

        private void dtpDob_Enter(object sender, EventArgs e)
        {
            Program.MainObj.SpeakText("Birth date");
            if (_intDOBCounter > 1)
            {
                int intPOS = _intDOBCounter - 1;
                string strCommand = "{LEFT " + intPOS + "}";
                SendKeys.Send(strCommand);
            }
        }

        private void dtpDob_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                if (_intDOBCounter < 3)
                {
                    _intDOBCounter++;
                }
            }
            else if (e.KeyCode == Keys.Left)
            {
                if (_intDOBCounter > 1)
                {
                    _intDOBCounter--;
                }

            }

        }

        private void dtpDOR_Enter(object sender, EventArgs e)
        {
            Program.MainObj.SpeakText("Registration date");
            if (_intDORCounter > 1)
            {
                int intPOS = _intDORCounter - 1;
                string strCommand = "{LEFT " + intPOS + "}";
                SendKeys.Send(strCommand);
            }
        }

        private void dtpDOR_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                if (_intDORCounter < 3)
                {
                    _intDORCounter++;
                }
            }
            else if (e.KeyCode == Keys.Left)
            {
                if (_intDORCounter > 1)
                {
                    _intDORCounter--;
                }

            }
        }

    }
}

