using LibraryDesign_frontEndUI.Forms;
using LibraryDesign_frontEndUI.Library;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LibraryDesign_frontEndUI
{
    public partial class frmCustomerSearch : Form
    {
        int _intRowIndex = -1;
        int _intColumnIndex = -1;

        internal string _strLastQuery = string.Empty;

        frmIssueBooks _frmParentReference = null;

        BLSSchema _Bschema = new BLSSchema();
        
        public frmCustomerSearch()
        {
            InitializeComponent();
            _frmParentReference = null;           

        }

        public frmCustomerSearch(frmIssueBooks frmParentRef)
        {
            InitializeComponent();
            _frmParentReference = frmParentRef;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchButtonClick();
        }

        private void SearchButtonClick()
        {
            dgvCustDetails.DataSource = null;
            if (!string.IsNullOrWhiteSpace(txtMemberNumber.Text) || !string.IsNullOrWhiteSpace(txtCustName.Text)
                   || !string.IsNullOrWhiteSpace(txtCustCollege.Text))
            {
                string s = ConstructCustQuery();
                Search(s);
            }
            else
            {
                PopulateDefaultGrid();
            }
        }


        internal void Search(string strCustomerQuery)
        {
            try
            {
                if (strCustomerQuery != "")
                {
                    _Bschema.ctCustomer.Clear();
                    BusinessLogic BLgc = new BusinessLogic();                    
                    BLgc.GetCustomer(_Bschema, strCustomerQuery);
                    if (_Bschema.ctCustomer.Rows.Count > 0)
                    {
                        dgvCustDetails.DataSource = null;
                        dgvCustDetails.DataSource = _Bschema.ctCustomer;
                        _intRowIndex = 0;
                    }
                    else
                    {
                        MessageBox.Show("No data found", "No data");
                        _intRowIndex = -1;
                    }
                }
                else
                {
                    if (chkAllowZeroCount.Checked)
                    {
                        if (string.IsNullOrWhiteSpace(txtCount.Text) == true)
                        {
                            Search("SELECT TOP (20) [CustomerID],[Name] AS CustName,[Father Name],[DOB],[Parent Phone],[Parent Mobile],[Student Mobile],[Address],[CollegeName],[Course],[CourseDuration]" +
                            ",[EmailID],[MembershipDate],[MembershipType],[MembershipPeriod],[Activation],[BookCount],[DepositAmount],[AdvanceAmount],[BalanceAmount],[RefundAmount],[RecieptNumber] ,[MaxLimit],[UsedLimit] FROM TblCustomer"
                            + " WHERE [Activation] = 1 ORDER BY CreatedDatetime DESC");
                        }
                        else
                        {
                            Search("SELECT TOP (" + txtCount.Text + ") [CustomerID],[Name] AS CustName,[Father Name],[DOB],[Parent Phone],[Parent Mobile],[Student Mobile],[Address],[CollegeName],[Course],[CourseDuration]" +
                            ",[EmailID],[MembershipDate],[MembershipType],[MembershipPeriod],[Activation],[BookCount],[DepositAmount],[AdvanceAmount],[BalanceAmount],[RefundAmount],[RecieptNumber] ,[MaxLimit],[UsedLimit] FROM TblCustomer"
                            + " WHERE [Activation] = 1 ORDER BY CreatedDatetime DESC");
                        }

                    }
                    else
                    {
                        if (string.IsNullOrWhiteSpace(txtCount.Text) == true)
                        {
                            Search("SELECT TOP(20) [CustomerID],[Name] AS CustName,[Father Name],[DOB],[Parent Phone],[Parent Mobile],[Student Mobile],[Address],[CollegeName],[Course],[CourseDuration]" +
                                 ",[EmailID],[MembershipDate],[MembershipType],[MembershipPeriod],[Activation],[BookCount],[DepositAmount],[AdvanceAmount],[BalanceAmount],[RefundAmount],[RecieptNumber] ,[MaxLimit],[UsedLimit] FROM TblCustomer WHERE BookCount > 0 "
                                 + " AND [Activation] = 1 ORDER BY CreatedDatetime DESC");
                        }
                        else
                        {
                            Search("SELECT TOP(" + txtCount.Text + ") [CustomerID],[Name] AS CustName,[Father Name],[DOB],[Parent Phone],[Parent Mobile],[Student Mobile],[Address],[CollegeName],[Course],[CourseDuration]" +
                            ",[EmailID],[MembershipDate],[MembershipType],[MembershipPeriod],[Activation],[BookCount],[DepositAmount],[AdvanceAmount],[BalanceAmount],[RefundAmount],[RecieptNumber] ,[MaxLimit],[UsedLimit] FROM TblCustomer WHERE BookCount > 0 "
                            + " AND [Activation] = 1 ORDER BY CreatedDatetime DESC");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                //log exception
                Utility.WriteToFile(ex, "Error occured while retrieving customer records.");

                MessageBox.Show("Error occured while retrieving record : " + ex.ToString(), "Error");
            }
        }

        internal string ConstructCustQuery()
        {
            try
            {
                string strCustomerQuery = string.Empty;
                bool blnConditionAdded = false;

                if (string.IsNullOrWhiteSpace(txtCount.Text) != true)
                {
                    strCustomerQuery = "SELECT TOP(" + txtCount.Text + ") [CustomerID],[Name] AS CustName,[Father Name],[DOB],[Parent Phone],[Parent Mobile],[Student Mobile],[Address],[CollegeName],[Course],[CourseDuration]" +
                        ",[EmailID],[MembershipDate],[MembershipType],[MembershipPeriod],[Activation],[BookCount],[DepositAmount],[AdvanceAmount],[BalanceAmount],[RefundAmount],[RecieptNumber] ,[MaxLimit],[UsedLimit],[EarlyActivation],[CreatedDatetime],[ImagePath] FROM TblCustomer WHERE ";
                }
                else
                {
                    strCustomerQuery = "SELECT TOP(10) [CustomerID],[Name] AS CustName,[Father Name],[DOB],[Parent Phone],[Parent Mobile],[Student Mobile],[Address],[CollegeName],[Course],[CourseDuration]" +
                        ",[EmailID],[MembershipDate],[MembershipType],[MembershipPeriod],[Activation],[BookCount],[DepositAmount],[AdvanceAmount],[BalanceAmount],[RefundAmount],[RecieptNumber] ,[MaxLimit],[UsedLimit],[EarlyActivation],[CreatedDatetime],[ImagePath] FROM TblCustomer WHERE ";
                }                 
               
                if (!string.IsNullOrWhiteSpace(txtMemberNumber.Text))
                {
                    strCustomerQuery += "[CustomerID] LIKE '" + txtMemberNumber.Text + "%'";
                    blnConditionAdded = true;
                }
               
                if (!string.IsNullOrWhiteSpace(txtCustName.Text))
                {
                    if (blnConditionAdded) strCustomerQuery += " AND ";

                    strCustomerQuery += "Name LIKE '" + txtCustName.Text + "%'";
                    blnConditionAdded = true;
                }
               
                if (!string.IsNullOrWhiteSpace(txtCustCollege.Text))
                {
                    if (blnConditionAdded) strCustomerQuery += " AND ";

                    strCustomerQuery += " CollegeName LIKE '" + txtCustCollege.Text + "%'";
                }

                if (blnConditionAdded)
                {
                    strCustomerQuery = (chkAllowZeroCount.Checked) ? strCustomerQuery : strCustomerQuery + " AND [Activation] = 1 AND BookCount > 0";
                }

                strCustomerQuery = strCustomerQuery + " ORDER BY CreatedDatetime DESC";

                _strLastQuery = strCustomerQuery;                

                return strCustomerQuery;

            }
            catch (Exception ex)
            {
                //log exception
                Utility.WriteToFile(ex);

                throw new ApplicationException(ex.ToString());
            }
        }
        

        private void dgvCustDetails_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
             if (e.RowIndex != -1)
            {
                _intRowIndex = e.RowIndex;
                _intColumnIndex = e.ColumnIndex;
                if (e.ColumnIndex == dgvCustDetails.ColumnCount - 1)
                {
                    string strCustomerID = dgvCustDetails.Rows[_intRowIndex].Cells[0].Value.ToString();
                    BLSSchema.ctCustomerRow foundRow = (BLSSchema.ctCustomerRow)_Bschema.ctCustomer.Rows.Find(strCustomerID);
                    fmrViewCustomerForm fmrViewDetails = new fmrViewCustomerForm(foundRow);
                    fmrViewDetails.ShowDialog();
                }
                
            }
            
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }         
        

        private void dgvCustDetails_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using (SolidBrush b = new SolidBrush(dgvCustDetails.RowHeadersDefaultCellStyle.ForeColor))
            {
                e.Graphics.DrawString((e.RowIndex + 1).ToString(System.Globalization.CultureInfo.CurrentUICulture), e.InheritedRowStyle.Font, b, e.RowBounds.Location.X + 7, e.RowBounds.Location.Y + 4);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (_intRowIndex != -1)
                {
                    string strCustomerID = dgvCustDetails.Rows[_intRowIndex].Cells[0].Value.ToString();
                    BLSSchema.ctCustomerRow foundRow = (BLSSchema.ctCustomerRow)_Bschema.ctCustomer.Rows.Find(strCustomerID);

                    if (foundRow != null)
                    {
                        if (_frmParentReference != null)
                        {
                            _frmParentReference.txtID.Text = foundRow.CustomerID.ToString();
                            _frmParentReference.txtFirstName.Text = foundRow.CustName;
                            _frmParentReference.txtDOB.Text = foundRow.DOB;
                            _frmParentReference.txtMobileNumber.Text = foundRow.Student_Mobile;
                            _frmParentReference.txtEmail.Text = foundRow.EmailID;
                            _frmParentReference.txtCollegeName.Text = foundRow.CollegeName;
                        }
                        else
                        {
                            string[] strCustElements = new string[13];
                            strCustElements[0] = foundRow.CustomerID.ToString();
                            strCustElements[1] = foundRow.CustName;
                            strCustElements[2] = foundRow.DOB;
                            strCustElements[3] = foundRow.Student_Mobile;
                            strCustElements[4] = foundRow.EmailID;
                            strCustElements[5] = foundRow.CollegeName;
                            strCustElements[6] = foundRow.AdvanceAmount;
                            strCustElements[7] = foundRow.BalanceAmount;
                            strCustElements[8] = foundRow.MembershipType;
                            strCustElements[9] = foundRow.MembershipPeriod;

                            if (foundRow.MembershipType == "N")
                            {
                                strCustElements[10] = foundRow.MaxLimit;
                                strCustElements[11] = foundRow.UsedLimit;
                            }
                            strCustElements[12] = foundRow.ImagePath;
                            frmMultiIssue frmIssueBook = new frmMultiIssue(strCustElements, this);
                            frmIssueBook.MdiParent = this.MdiParent;
                            frmIssueBook.Show();
                        }
                    }                   
                    else
                    {
                        MessageBox.Show("Some internal error occured.", "Error");
                    }
                }
                else
                {
                    MessageBox.Show("No record selected to perform this action.", "No record");
                }
            }
            catch (Exception ex)
            {
                //log exception
                Utility.WriteToFile(ex, "Error occured while retrieving record");

                MessageBox.Show("Error occured while retrieving record : " + ex.ToString(), "Error");
            }
        }

        //private void button2_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        if (_intRowIndex != -1)
        //        {
        //            string strCustomerID = dgvCustDetails.Rows[_intRowIndex].Cells[0].Value.ToString();
        //            BLSSchema.ctCustomerRow foundRow = (BLSSchema.ctCustomerRow)_Bschema.ctCustomer.Rows.Find(strCustomerID);
        //            if (int.Parse(foundRow.BookCount) > 0)
        //            {
        //                string[] strCustElements = new string[8];
        //                strCustElements[0] = foundRow.CustomerID.ToString();
        //                strCustElements[1] = foundRow.Student_Mobile;
        //                strCustElements[2] = foundRow.AdvanceAmount;
        //                strCustElements[3] = foundRow.BalanceAmount;
        //                strCustElements[4] = foundRow.MembershipType;
        //                strCustElements[5] = foundRow.CustName;// +" " + foundRow.LastName;
        //                strCustElements[6] = foundRow.AdvanceAmount;
        //                strCustElements[7] = foundRow.BalanceAmount;
                        
        //                frmReturn frmReturnBook = new frmReturn(strCustElements, this);
        //                frmReturnBook.MdiParent = this.MdiParent;
        //                frmReturnBook.Show();
        //                Search(_strLastQuery);
        //            }
        //            else
        //            {
        //                MessageBox.Show("There are no books to return", "No Books");
        //            }
        //        }
        //        else
        //        {
        //            MessageBox.Show("No records selected to perform this action", "No record");
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        //log exception
        //        Utility.WriteToFile(ex, "Error occured while retrieving record");

        //        MessageBox.Show("Error occured while retrieving record : " + ex.ToString(), "Error");
        //    }
        //}

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure.you want to close this form?", "Close Confirmation?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Close();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (_intRowIndex != -1)
                {
                    string strCustomerID = dgvCustDetails.Rows[_intRowIndex].Cells["CustomerID"].Value.ToString();
                    BLSSchema.ctCustomerRow foundRow = (BLSSchema.ctCustomerRow)_Bschema.ctCustomer.Rows.Find(strCustomerID);
                    frmeditCustomerDetails frmeditCust = new frmeditCustomerDetails(foundRow, this);
                    frmeditCust.MdiParent = this.MdiParent;
                    frmeditCust.Show();
                }
                else
                {
                    MessageBox.Show("No records to perform this action", "No record");
                }
            }
            catch (Exception ex)
            {
                //log exception
                Utility.WriteToFile(ex, "Error occured while editing customer record");

                MessageBox.Show("Error occured while editing customer record : " + ex.ToString(), "Error");              
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (_intRowIndex != -1)
                {
                    string strCustomerID = dgvCustDetails.Rows[_intRowIndex].Cells["CustomerID"].Value.ToString();
                    if (MessageBox.Show("Are you sure.you want to delete " + dgvCustDetails.Rows[_intRowIndex].Cells["CustName"].Value.ToString() + "'s record?", "Close Confirmation?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        BusinessLogic BL = new BusinessLogic();                    
                        if (BL.DeleteCustomer(dgvCustDetails.Rows[_intRowIndex].Cells["CustomerID"].Value.ToString()))
                        {
                            //Delete customer image file
                            if (!string.IsNullOrWhiteSpace(strCustomerID))
                            {
                                Program.MainObj.DeleteImageFile(strCustomerID);
                            }

                            MessageBox.Show("Record deleted successfully.", "Completed.");
                            Search(_strLastQuery);
                        }
                        else
                        {
                            MessageBox.Show("Error while deleting record", "Not Completed");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("No records to delete", "No Records");
                }
            }
            catch (Exception ex)
            {
                //log exception
                Utility.WriteToFile(ex, "Error occured while deleting customer record");

                MessageBox.Show("Error occured while deleting customer record : " + ex.ToString(), "Error");
            }
        }
       

        //private void btnBooksBorrowed_Click(object sender, EventArgs e)
        //{
            
        //    //string strFirstName = dgvCustDetails.Rows[_intRowIndex].Cells["FirstName"].Value.ToString();           
        //    //int intCustID = int.Parse(dgvCustDetails.Rows[_intRowIndex].Cells["CustomerID"].Value.ToString());
        //    //string strMembershipType = dgvCustDetails.Rows[_intRowIndex].Cells["FirstName"].Value.ToString(),
        //    //   // dgvCustDetails.Rows[_intRowIndex].Cells["StudentMobile"].Value.ToString(), int.Parse(dgvCustDetails.Rows[_intRowIndex].Cells["CustomerID"].Value.ToString())
        //    //frmEditBooksBorrowed frmEdtBooksBorrowed = new frmEditBooksBorrowed(intCustID);
        //    //frmEdtBooksBorrowed.MdiParent = this.MdiParent;
        //    //frmEdtBooksBorrowed.Show();
        //}

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dgvCustDetails.DataSource = null;
            if (string.IsNullOrWhiteSpace(txtMemberNumber.Text) == false || string.IsNullOrWhiteSpace(txtCustName.Text) == false
                  || string.IsNullOrWhiteSpace(txtCustCollege.Text) == false)
            {
                string s = ConstructCustQuery();
                Search(s);
            }
            else
            {
                MessageBox.Show("Please enter atleast one field to search", "Field empty");
            }
        }

        private void btnEarlyIssue_Click(object sender, EventArgs e)
        {
            try
            {
                if (_intRowIndex != -1)
                {                                      
                    frmEditBooksBorrowed frmEdtBooksBorrowed = new frmEditBooksBorrowed(this);
                    frmEdtBooksBorrowed._intCustomerID = int.Parse(dgvCustDetails.Rows[_intRowIndex].Cells["CustomerID"].Value.ToString());
                    frmEdtBooksBorrowed._intMemberShipPeriod = int.Parse(dgvCustDetails.Rows[_intRowIndex].Cells["MembershipPeriod"].Value.ToString());
                    frmEdtBooksBorrowed._strAdvance = dgvCustDetails.Rows[_intRowIndex].Cells["AdvanceAmount"].Value.ToString();
                    frmEdtBooksBorrowed._strBalance = dgvCustDetails.Rows[_intRowIndex].Cells["BalanceAmount"].Value.ToString();
                    frmEdtBooksBorrowed._strMemberShipType = dgvCustDetails.Rows[_intRowIndex].Cells["MembershipType"].Value.ToString();
                    frmEdtBooksBorrowed.MdiParent = this.MdiParent;
                    frmEdtBooksBorrowed.Show();
                }
                else
                {
                    MessageBox.Show("No records to perform this action", "No record");
                }
            }
            catch (Exception ex)
            {
                //log exception
                Utility.WriteToFile(ex, "Error occured while retrieving Early Issue details");

                MessageBox.Show("Error occured while retrieving Early Issue details : " + ex.ToString() + "Error");
            }
        }

        private void frmCustomerSearch_Load(object sender, EventArgs e)
        {
            
        }

        private void frmCustomerSearch_Activated(object sender, EventArgs e)
        {
            PopulateDefaultGrid();
        }

        private void PopulateDefaultGrid()
        {
            if (chkAllowZeroCount.Checked)
            {
                if (string.IsNullOrWhiteSpace(txtCount.Text) == false)
                {
                    Search("SELECT TOP(" + txtCount.Text + ") [CustomerID],[Name] AS CustName,[Father Name],[DOB],[Parent Phone],[Parent Mobile],[Student Mobile],[Address],[CollegeName],[Course],[CourseDuration]" +
                        ",[EmailID],[MembershipDate],[MembershipType],[MembershipPeriod],[Activation],[BookCount],[DepositAmount],[AdvanceAmount],[BalanceAmount],[RefundAmount],[RecieptNumber] ,[MaxLimit],[UsedLimit],[EarlyActivation],[CreatedDatetime],[ImagePath] FROM TblCustomer ORDER BY CreatedDatetime DESC");
                }
                else
                {
                    Search("SELECT TOP(10) [CustomerID],[Name] AS CustName,[Father Name],[DOB],[Parent Phone],[Parent Mobile],[Student Mobile],[Address],[CollegeName],[Course],[CourseDuration]" +
                        ",[EmailID],[MembershipDate],[MembershipType],[MembershipPeriod],[Activation],[BookCount],[DepositAmount],[AdvanceAmount],[BalanceAmount],[RefundAmount],[RecieptNumber] ,[MaxLimit],[UsedLimit],[EarlyActivation],[CreatedDatetime],[ImagePath] FROM TblCustomer ORDER BY CreatedDatetime DESC");
                }
            }
            else
            {
                if (string.IsNullOrWhiteSpace(txtCount.Text) == false)
                {
                    Search("SELECT TOP(" + txtCount.Text + ") [CustomerID],[Name] AS CustName,[Father Name],[DOB],[Parent Phone],[Parent Mobile],[Student Mobile],[Address],[CollegeName],[Course],[CourseDuration]" +
                        ",[EmailID],[MembershipDate],[MembershipType],[MembershipPeriod],[Activation],[BookCount],[DepositAmount],[AdvanceAmount],[BalanceAmount],[RefundAmount],[RecieptNumber] ,[MaxLimit],[UsedLimit],[EarlyActivation],[CreatedDatetime],[ImagePath] FROM TblCustomer where BookCount > 0 ORDER BY CreatedDatetime DESC");
                }
                else
                {
                    Search("SELECT TOP(10) [CustomerID],[Name] AS CustName,[Father Name],[DOB],[Parent Phone],[Parent Mobile],[Student Mobile],[Address],[CollegeName],[Course],[CourseDuration]" +
                        ",[EmailID],[MembershipDate],[MembershipType],[MembershipPeriod],[Activation],[BookCount],[DepositAmount],[AdvanceAmount],[BalanceAmount],[RefundAmount],[RecieptNumber] ,[MaxLimit],[UsedLimit],[EarlyActivation],[CreatedDatetime],[ImagePath] FROM TblCustomer where BookCount > 0 ORDER BY CreatedDatetime DESC");
                }

            }
        }

        private void frmCustomerSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char pressedKey = e.KeyChar;
            if (pressedKey == '\r')
            {
                SearchButtonClick();
            }
        }

        private void txtReceiptNumber_TextChanged(object sender, EventArgs e)
        {
            SearchButtonClick();
        }

        private void txtCustCollege_TextChanged(object sender, EventArgs e)
        {
            SearchButtonClick();
        }

        private void txtCustName_TextChanged(object sender, EventArgs e)
        {
            SearchButtonClick();
        }

        private void chkAllowZeroCount_CheckedChanged(object sender, EventArgs e)
        {
            SearchButtonClick();
        }       

        private void Number_Validation(object sender, KeyPressEventArgs e)
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
                MessageBox.Show("Only numbers are allowed here.", "Only Numbers");
            }
        }

        private void dgvCustDetails_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // If the column is the Artist column, check the 
            // value. 
            if (this.dgvCustDetails.Columns[e.ColumnIndex].Name == "DOB" || 
                this.dgvCustDetails.Columns[e.ColumnIndex].Name == "MembershipDate")
            {
                if (e.Value != null)
                {
                    // Check for the string "pink" in the cell.
                    string stringValue = (string)e.Value;
                    e.Value = stringValue.Substring(0, 10);

                }
            }
            else if (this.dgvCustDetails.Columns[e.ColumnIndex].Name == "MembershipType")
            {
                if (e.Value != null)
                {
                    // Check for the string "pink" in the cell.
                    string stringValue = (string)e.Value;
                    if (stringValue == "R")
                    {
                        e.Value = "Rental";
                    }
                    else if (stringValue == "N")
                    {
                        e.Value = "Non-Rental";
                    }
                    else
                    {
                        e.Value = "Other";
                    }
                   

                }
            }
        }

        private void frmReturn_Click(object sender, EventArgs e)
        {
            try
            {
                if (_intRowIndex != -1)
                {
                    string strCustomerID = dgvCustDetails.Rows[_intRowIndex].Cells[0].Value.ToString();
                    BLSSchema.ctCustomerRow foundRow = (BLSSchema.ctCustomerRow)_Bschema.ctCustomer.Rows.Find(strCustomerID);
                    if (int.Parse(foundRow.BookCount) > 0)
                    {
                        string[] strCustElements = new string[11];
                        strCustElements[0] = foundRow.CustomerID.ToString();
                        strCustElements[1] = foundRow.Student_Mobile;
                        strCustElements[2] = foundRow.AdvanceAmount;
                        strCustElements[3] = foundRow.BalanceAmount;
                        strCustElements[4] = foundRow.MembershipType;
                        strCustElements[5] = foundRow.CustName;// +" " + foundRow.LastName;
                        strCustElements[6] = foundRow.AdvanceAmount;
                        strCustElements[7] = foundRow.BalanceAmount;
                        strCustElements[8] = foundRow.ImagePath;
                        strCustElements[9] = foundRow.MaxLimit;
                        strCustElements[10] = foundRow.UsedLimit;

                        frmReturn frmReturnBook = new frmReturn(strCustElements, this);
                        frmReturnBook.MdiParent = this.MdiParent;
                        frmReturnBook.Show();
                        Search(_strLastQuery);
                    }
                    else
                    {
                        MessageBox.Show("There are no books to return", "No Books");
                    }
                }
                else
                {
                    MessageBox.Show("No records selected to perform this action", "No record");
                }
            }
            catch (Exception ex)
            {
                //log exception
                Utility.WriteToFile(ex, "Error occured while retrieving record");

                MessageBox.Show("Error occured while retrieving record : " + ex.ToString(), "Error");
            }
        }

        
    }
}
