using LibraryDesign_frontEndUI.Library;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LibraryDesign_frontEndUI.Forms
{
    public partial class frmeditCustomerDetails : Form
    {
        frmCustomerSearch _parentref = null;
        string strCustomerID = string.Empty;
        string _strCustImageOldPath = string.Empty;
        float _fltMaxLimit = -1;
        BLSSchema.ctCustomerRow _row = null;

        public frmeditCustomerDetails(BLSSchema.ctCustomerRow row, frmCustomerSearch refPar)
        {
            InitializeComponent();
            strCustomerID = row.CustomerID;
            _fltMaxLimit = float.Parse(row.MaxLimit);
            txtFirstName.Text = row.CustName;
            txtFatherName.Text = row.Father_Name;
            txtParenPhone.Text = row.Parent_Phone;
            txtParentMobile.Text = row.Parent_Mobile;
            txStudenttMobile.Text = row.Student_Mobile;
            txtEmail.Text = row.EmailID;
            txtAddress.Text = row.Address;
            txtCollegeName.Text = row.CollegeName;
            txtCourse.Text = row.Course;
            txtCourseDuration.Text = row.CourseDuration;
            if (string.IsNullOrWhiteSpace(row.MembershipType))
            {
                txtMembershipType.SelectedIndex = -1;
            }
            else if (row.MembershipType == "R")
            {
                txtMembershipType.SelectedIndex = 0;
            }
            else if (row.MembershipType == "N")
            {
                txtMembershipType.SelectedIndex = 1;
            }
            else
            {
                txtMembershipType.SelectedIndex = 2;
            }

            DisplayAppropriateFields();

            txtMemberShipPeriod.Text = row.MembershipPeriod;
            txtDepositAmount.Text = row.DepositAmount;
            txtAdvanceAmount.Text = row.AdvanceAmount;
            txtBalanceamount.Text = row.BalanceAmount;
            txtReciptNo.Text = row.RecieptNumber.ToString();
            dtpDob.Text = row.DOB;
            dtpDOR.Text = row.MembershipDate;
            _strCustImageOldPath = txtCustImagePath.Text = row.ImagePath;
            _parentref = refPar;
            _row = row;


        }

        private bool ValidateAllFields()
        {
            try
            {
                //here validate all the fields one by one
                //If any field is empty then display appropriate message
                //Refer Add stock form
                if (string.IsNullOrWhiteSpace(txtFirstName.Text))
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
                    MessageBox.Show("Mobile field is empty", "Error");
                    lblMobile.ForeColor = System.Drawing.Color.Red;
                    return false;
                }
                else if (txStudenttMobile.Text.Length < 10)
                {
                    MessageBox.Show("Invalid mobile number", "Error");
                    lblMobile.ForeColor = System.Drawing.Color.Red;
                    return false;
                }

                lblMobile.ForeColor = System.Drawing.Color.Lime;

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
                    else
                    {
                        //if (_row.MembershipType == "N")Non-Rental
                        if (txtMembershipType.Text == "Non-Rental")
                        {
                            float fltTempMaxLimit = Program.MainObj.GetMaxLimit(txtMembershipType.Text, float.Parse(txtDepositAmount.Text));
                            if (float.Parse(_row.UsedLimit) > fltTempMaxLimit)
                            {
                                MessageBox.Show("Customer's used limit crosses the 90% of the entered deposit amount.\n" +
                                "Please make sure that deposit amount is higher than maximum used limit\n" +
                                "Current Maximum used Limit : " + _row.UsedLimit + "\n"
                                + "Entered deposit amount : " + txtDepositAmount.Text, "Deposit amount error");
                                lblDepositAmount.ForeColor = System.Drawing.Color.Red;
                                return false;
                            }
                            else
                            {
                                _fltMaxLimit = fltTempMaxLimit;
                            }
                        }
                    }

                }
                else if (string.IsNullOrWhiteSpace(txtDepositAmount.Text) && txtMembershipType.Text == "Non-Rental")
                {
                    MessageBox.Show("Deposit amount field is empty", "Error");
                    lblDepositAmount.ForeColor = System.Drawing.Color.Red;
                    return false;
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


                if (string.IsNullOrWhiteSpace(txtReciptNo.Text) && (txtMembershipType.Text == "Non-Rental"))
                {
                    MessageBox.Show("Receipt Number field is empty", "Error");
                    //lblMembType.ForeColor = System.Drawing.Color.Red;
                    return false;
                }


                return true;
            }
            catch (Exception ex)
            {
                //log exception
                Utility.WriteToFile(ex);

                throw new ApplicationException(ex.ToString());
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

        private void txtMembershipType_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplayAppropriateFields();
        }

        private void DisplayAppropriateFields()
        {
            //txtAdvanceAmount.Text = "0";
            //txtBalanceamount.Text = "0";
            //txtReciptNo.Text = "";
            //txtMemberShipPeriod.Text = "0";

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

        #region [Events]

        private void txtFirstName_Enter(object sender, EventArgs e)
        {
            Program.MainObj.ActivateOrDeAcivateTextBox(sender, true);
        }

        private void txtFirstName_Leave(object sender, EventArgs e)
        {
            Program.MainObj.ActivateOrDeAcivateTextBox(sender, false);
        }

        private void txtFatherName_Enter(object sender, EventArgs e)
        {
            Program.MainObj.ActivateOrDeAcivateTextBox(sender, true);
        }

        private void txtFatherName_Leave(object sender, EventArgs e)
        {
            Program.MainObj.ActivateOrDeAcivateTextBox(sender, false);
        }

        private void txtParenPhone_Enter(object sender, EventArgs e)
        {
            Program.MainObj.ActivateOrDeAcivateTextBox(sender, true);
        }

        private void txtParenPhone_Leave(object sender, EventArgs e)
        {
            Program.MainObj.ActivateOrDeAcivateTextBox(sender, false);
        }

        private void txtParentMobile_Enter(object sender, EventArgs e)
        {
            Program.MainObj.ActivateOrDeAcivateTextBox(sender, true);
        }

        private void txtParentMobile_Leave(object sender, EventArgs e)
        {
            Program.MainObj.ActivateOrDeAcivateTextBox(sender, false);
        }

        private void txStudenttMobile_Enter(object sender, EventArgs e)
        {
            Program.MainObj.ActivateOrDeAcivateTextBox(sender, true);
        }

        private void txStudenttMobile_Leave(object sender, EventArgs e)
        {
            Program.MainObj.ActivateOrDeAcivateTextBox(sender, false);
        }

        private void txtEmail_Enter(object sender, EventArgs e)
        {
            Program.MainObj.ActivateOrDeAcivateTextBox(sender, true);
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            Program.MainObj.ActivateOrDeAcivateTextBox(sender, false);
        }

        private void txtAddress_Enter(object sender, EventArgs e)
        {
            Program.MainObj.ActivateOrDeAcivateTextBox(sender, true);
        }

        private void txtAddress_Leave(object sender, EventArgs e)
        {
            Program.MainObj.ActivateOrDeAcivateTextBox(sender, false);
        }

        private void txtCollegeName_Enter(object sender, EventArgs e)
        {
            Program.MainObj.ActivateOrDeAcivateTextBox(sender, true);
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

        private void txtFirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.MainObj.Name_Validation(sender, e);
        }

        private void txtFatherName_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.MainObj.Name_Validation(sender, e);
        }

        private void txtParenPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.MainObj.Number_Validation(sender, e);
        }

        private void txtParentMobile_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.MainObj.Number_Validation(sender, e);
        }

        private void txStudenttMobile_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.MainObj.Number_Validation(sender, e);
        }

        private void txtCollegeName_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.MainObj.Name_Validation(sender, e);
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

        #endregion

        private void btnOK_Click(object sender, EventArgs e)
        {
            BusinessLogic BL = new BusinessLogic();
            string strDestinationPath = string.Empty;

            try
            {
                if (ValidateAllFields())
                {
                    if (string.IsNullOrWhiteSpace(txtCustImagePath.Text) != true)
                    {
                        if (_strCustImageOldPath == txtCustImagePath.Text)
                        {
                            strDestinationPath = _strCustImageOldPath;
                        }
                        else
                        {
                            //Delete previous files
                            Program.MainObj.DeletePreviousImageFile(_strCustImageOldPath);

                            //Copy customer image to destination folder
                            strDestinationPath = Program.MainObj.CopyCustomerImage(txtCustImagePath.Text, Path.GetExtension(txtCustImagePath.Text.Trim()), strCustomerID);
                        }
                    }
                 

                    BLSSchema.ctCustomerDataTable dtCustomer = new BLSSchema.ctCustomerDataTable();

                    BLSSchema.ctCustomerRow row = dtCustomer.NewctCustomerRow();
                    row.CustomerID = strCustomerID;
                    row.CustName = txtFirstName.Text;
                    row.Father_Name = txtFatherName.Text;
                    row.DOB = dtpDob.Value.ToString("yyyy-MM-dd").Substring(0, 10);
                    row.MembershipDate = dtpDOR.Value.ToString("yyyy-MM-dd").Substring(0, 10);
                    row.Parent_Phone = txtParenPhone.Text;
                    row.Parent_Mobile = txtParentMobile.Text;
                    row.Student_Mobile = txStudenttMobile.Text;
                    row.Address = txtAddress.Text;
                    row.CollegeName = txtCollegeName.Text;
                    row.Course = txtCourse.Text;
                    row.CourseDuration = txtCourseDuration.Text;
                    row.EmailID = txtEmail.Text;
                    row.MembershipType = Program.MainObj.GetCustomerType(txtMembershipType.Text);
                    row.MembershipPeriod = txtMemberShipPeriod.Text;
                    row.Activation = _row.Activation;
                    row.BookCount = _row.BookCount;
                    row.DepositAmount = txtDepositAmount.Text;
                    row.AdvanceAmount = txtAdvanceAmount.Text;
                    row.BalanceAmount = txtBalanceamount.Text;
                    row.RefundAmount = (string.IsNullOrEmpty(row.RefundAmount)) ? "0" : row.RefundAmount;
                    row.RecieptNumber = txtReciptNo.Text;
                    row.MaxLimit = (txtMembershipType.Text == "Non-Rental") ? _fltMaxLimit.ToString() : _row.MaxLimit;
                    row.UsedLimit = _row.UsedLimit;
                    row.EarlyActivation = (_row.EarlyActivation.ToString() == "True") ? "1" : "0";
                    row.ImagePath = (string.IsNullOrWhiteSpace(txtCustImagePath.Text)) ? "N/A" : strDestinationPath;

                    dtCustomer.Rows.Add(row);

                    DataTable dtNewCustomer = GetRawDataTable(dtCustomer);

                    if (BL.UpdateCustomerDetails(strCustomerID.ToString(), dtNewCustomer))
                    {
                        //frmStudentRegister2 frmAddBooks = new frmStudentRegister2(row.FirstName, row.LastName, row.Student_Mobile, row.CustomerID, row.AdvanceAmount, row.BalanceAmount, strMemberShipType, row.MembershipPeriod);
                        //frmAddBooks.ShowDialog();                        
                        MessageBox.Show("Record updated successfully", "Done");
                        _parentref.Search(_parentref._strLastQuery);
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Customer details are not updated", "Error");
                    }
                }
            }
            catch (Exception ex)
            {
                //log exception
                Utility.WriteToFile(ex, "Error occured while updating user");

                MessageBox.Show("Error occured while updating user : " + ex.ToString(), "Error");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Cancelling may cause the form to close.\n Data entered may be lost..Are you sure?", "Cancel Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
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




    }
}
