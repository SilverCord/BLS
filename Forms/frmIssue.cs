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
    public partial class frmIssueBooks : Form
    {

        internal string _strBalance = string.Empty;

        internal bool _blnCheckForMaxLimit = false;

        internal bool _blnCancelledFromPreview = false;

        internal int _intMemberShipPeriod = 0;

        internal int _intMaxAvailableCount = 0;

        frmCustomerSearch _refToParent = null;

        public frmIssueBooks()
        {
            InitializeComponent();
        }

        public frmIssueBooks(string[] strElements, string strType, Form refToParent)
        {
            InitializeComponent();
            if (strType == "Customer")
            {
                txtID.Text = strElements[0];
                txtFirstName.Text = strElements[1];
                txtDOB.Text = strElements[2];
                txtMobileNumber.Text = strElements[3];
                txtEmail.Text = strElements[4];
                txtCollegeName.Text = strElements[5];
                txtAdvance.Text = strElements[6];
                txtBalance.Text = strElements[7];
                txtMemberShipType.Text = Program.MainObj.GetDetailedCustomerType(strElements[8]);
                _intMemberShipPeriod = int.Parse(strElements[9]);

                if (strElements[8] == "R" || strElements[8] == "O")
                {
                    btnCheck.Visible = false;
                    btnIssue.Enabled = true;
                    btnCheck.Visible = false;
                }
                else
                {
                    //txtAdvance.Text = "0";
                    //txtBalance.Text = "0";
                    btnCheck.Visible = true;
                    btnIssue.Enabled = false;

                    txtBookCount.Text = "1";
                    txtBookCount.ReadOnly = true;

                }

                _refToParent = (frmCustomerSearch)refToParent;
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            try
            {
                BusinessLogic BL = new BusinessLogic();

                if (string.IsNullOrWhiteSpace(txtSelectedTitle.Text) || string.IsNullOrWhiteSpace(txtSelectedAuthor.Text) ||
                    string.IsNullOrWhiteSpace(txtSelectedEdition.Text) || string.IsNullOrWhiteSpace(txtBookPrice.Text) ||
                    string.IsNullOrWhiteSpace(txtSelectedPublisher.Text))
                {
                    MessageBox.Show("Please select the book details first.", "Error");
                }
                else
                {
                    if (BL.CheckDuplicateIssue(int.Parse(txtID.Text), txtSelectedTitle.Text, txtSelectedAuthor.Text, txtSelectedEdition.Text,
                                   txtSelectedPublisher.Text, float.Parse(txtBookPrice.Text)) == false)
                    {
                        if (string.IsNullOrWhiteSpace(txtBookPrice.Text))
                        {
                            MessageBox.Show("Please enter book price to check", "Error");
                            return;
                        }
                        if (string.IsNullOrWhiteSpace(txtBookCount.Text) || int.Parse(txtBookCount.Text) <= 0)
                        {
                            MessageBox.Show("Please enter valid book Count", "Error");
                            return;
                        }

                        float[] fl = BL.GetLimit(txtID.Text);

                        float fltMaxLimit = fl[0];
                        float fltLimitUsed = fl[1];
                        float CurrentAmount = float.Parse(txtBookPrice.Text) * int.Parse(txtBookCount.Text);

                        if ((fltLimitUsed + CurrentAmount) > fltMaxLimit)
                        {
                            MessageBox.Show("Cannot Issue the Book.It exceeds customer's deposit limit.\n MaxLimit : Rs "
                                + fltMaxLimit + "\nLimit Used : Rs " + fltLimitUsed + "\n Limit After Issuing Books : Rs" + (fltLimitUsed + CurrentAmount), "Limit Exceeded");
                        }
                        else
                        {
                            MessageBox.Show("Issue is allowed", "Success");
                            btnIssue.Enabled = true;
                            btnCheck.Enabled = false;
                            txtBookCount.ReadOnly = true;
                            txtBookPrice.ReadOnly = true;

                            _blnCheckForMaxLimit = true;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Cannot Issue the Book.Customer already have same book issued.", "Error");

                    }
                }
            }
            catch (Exception ex)
            {
                //log exception
                Utility.WriteToFile(ex, "Error occured while checking whether book issue is allowed or not.");

                MessageBox.Show("Error occured while checking whether book issue is allowed or not : " + ex.ToString(),"Error");
            }

        }
        private void ClearFormItems()
        {
            
            txtSelectedTitle.Text = "";
            txtSelectedAuthor.Text = "";
            txtSelectedEdition.Text = "";
            txtSelectedYear.Text = "";
            txtSelectedPublisher.Text = "";

            txtMobileNumber.Text = "";
            txtCollegeName.Text = "";
            txtID.Text = "";
            txtFirstName.Text = "";
            txtDOB.Text = "";
            txtEmail.Text = "";
            //cmbIssueType.SelectedIndex = 0;
            txtBookPrice.Text = "";
            txtBookCount.Text = "";
            btnReset.Enabled = true;
            btnCheck.Enabled = true;
            btnIssue.Enabled = false;
            btnCancel.Enabled = true;
            
            txtSelectedTitle.ReadOnly = false;
            txtSelectedAuthor.ReadOnly = false;
            txtSelectedEdition.ReadOnly = false;
            txtSelectedYear.ReadOnly = false;
            txtSelectedPublisher.ReadOnly = false;

            txtMobileNumber.ReadOnly = false;
            txtCollegeName.ReadOnly = false;
            txtID.ReadOnly = false;
            txtFirstName.ReadOnly = false;
            txtDOB.ReadOnly = false;
            txtEmail.ReadOnly = false;

            txtBookPrice.ReadOnly = false;
            txtBookCount.ReadOnly = false;

        }

        private void SetControlsAfterCheck()
        {            
            txtSelectedTitle.ReadOnly = true;
            txtSelectedAuthor.ReadOnly = true;
            txtSelectedEdition.ReadOnly = true;
            txtSelectedYear.ReadOnly = true;
            txtSelectedPublisher.ReadOnly = true;

            txtMobileNumber.ReadOnly = true;
            txtCollegeName.ReadOnly = true;
            txtID.ReadOnly = true;
            txtFirstName.ReadOnly = true;
            txtDOB.ReadOnly = true;
            txtEmail.ReadOnly = true;

            txtBookPrice.ReadOnly = true;
            txtBookCount.ReadOnly = true;

            btnReset.Enabled = true;
            btnCheck.Enabled = false;
            btnIssue.Enabled = true;
            btnCancel.Enabled = true;
        }

        private void btnIssue_Click(object sender, EventArgs e)
        {
            BusinessLogic BL = new BusinessLogic();

            Guid id = Guid.NewGuid();
            float fltTotalAmount = 0;

            try
            {
                if (ValidateAllFields())
                {
                    #region [Issue book for Rental customer]
                    if (txtMemberShipType.Text == "Rental")
                    {
                        #region [Display Payment Preview form]
                        Dictionary<string, string> dtElementsCollection = new Dictionary<string, string>();
                        dtElementsCollection.Add("CustomerName", txtFirstName.Text);
                        dtElementsCollection.Add("BookTitle", txtSelectedTitle.Text);
                        dtElementsCollection.Add("IssueType", Program.MainObj.GetCustomerType(txtMemberShipType.Text));
                        dtElementsCollection.Add("Advance", txtAdvance.Text);
                        dtElementsCollection.Add("Balance", txtBalance.Text);
                        dtElementsCollection.Add("BookPrice", txtBookPrice.Text);

                        frmIssuePreview frmIssuePrv = new frmIssuePreview(dtElementsCollection, this);

                        frmIssuePrv.ShowDialog();
                        #endregion

                        if (!_blnCancelledFromPreview)
                        {
                            #region [Construct History Table]

                            BLSSchema.ctTransactionHistoryDataTable dtTransactionHistory = new BLSSchema.ctTransactionHistoryDataTable();

                            BLSSchema.ctTransactionHistoryRow row = dtTransactionHistory.NewctTransactionHistoryRow();

                            row.HistoryUID = id.ToString();

                            row.HistoryDate = row.IssueDate = DateTime.Now.ToString("yyyy-MM-dd").Substring(0, 10);

                            row.ReturnDate = DateTime.Now.AddMonths(_intMemberShipPeriod).ToString("yyyy-MM-dd").Substring(0, 10);

                            row.Type = "ISU";                           

                            row.CheckNumber = "";                            

                            row.CustomerID = txtID.Text;

                            fltTotalAmount = int.Parse(txtBookCount.Text) * float.Parse(txtBookPrice.Text);

                            row.Title = txtSelectedTitle.Text;

                            row.Author = txtSelectedAuthor.Text;

                            row.Edition = txtSelectedEdition.Text;

                            row.PurchasePrice = float.Parse(txtPurchasedPrice.Text);

                            row.AmountIn = fltTotalAmount.ToString();

                            row.AmountOut = "0";

                            row.RecieptNumber = "";

                            dtTransactionHistory.Rows.Add(row);

                            DataTable dtNewTransHistry = GetRawDataTable(dtTransactionHistory);

                            #endregion

                            #region [Construct Issue Table]

                            BLSSchema.ctIssueDataTable dtIssue = new BLSSchema.ctIssueDataTable();

                            BLSSchema.ctIssueRow IssueRow = dtIssue.NewctIssueRow();

                            IssueRow.CustomerID = txtID.Text;

                            IssueRow.Title = txtSelectedTitle.Text;

                            IssueRow.Author = txtSelectedAuthor.Text;

                            IssueRow.Edition = txtSelectedEdition.Text;

                            IssueRow.IssueDate = DateTime.Now.ToString("yyyy-MM-dd").Substring(0, 10);

                            IssueRow.BookCount = txtBookCount.Text;

                            IssueRow.BookPrice = txtBookPrice.Text;

                            IssueRow.RecieptNumber = "";

                            IssueRow.Publisher = txtSelectedPublisher.Text;

                            IssueRow.HistoryUID = id.ToString();

                            IssueRow.IssueType = Program.MainObj.GetCustomerType(txtMemberShipType.Text);

                            IssueRow.Returndate = DateTime.Now.AddMonths(_intMemberShipPeriod).ToString("yyyy-MM-dd").Substring(0, 10);

                            IssueRow.EarlyIssue = false;

                            dtIssue.Rows.Add(IssueRow);

                            DataTable dtNewIssue = GetRawDataTable(dtIssue);

                            #endregion

                            /**********************************************************************************
                             * Modified By : Shankar
                             * Changed int CustomerID to string CustomerID
                            **********************************************************************************/
                         //   BL.PerformRegularIssueProcess(id.ToString(), txtID.Text, txtSelectedTitle.Text, txtSelectedAuthor.Text, txtSelectedEdition.Text,
                         //    float.Parse(txtBookPrice.Text), int.Parse(txtBookCount.Text), DateTime.Now,
                         //    float.Parse(txtAdvance.Text), float.Parse(txtBalance.Text), -1, dtNewTransHistry, dtNewIssue);

                            MessageBox.Show("Book(s) Issued", "Done.");

                            _blnCheckForMaxLimit = false;

                            _refToParent.Search(_refToParent._strLastQuery);

                            Close();


                        }
                    }
                    #endregion

                    #region [Issue book for OTHER type customer]
                    else if (txtMemberShipType.Text == "Other")//Its Other(Special category)
                    {
                        #region [Show Preview form]
                        Dictionary<string, string> dtElementsCollection = new Dictionary<string, string>();
                        dtElementsCollection.Add("CustomerName", txtFirstName.Text);
                        dtElementsCollection.Add("BookTitle", txtSelectedTitle.Text);
                        dtElementsCollection.Add("IssueType", Program.MainObj.GetCustomerType(txtMemberShipType.Text));
                        dtElementsCollection.Add("Advance", txtAdvance.Text);
                        dtElementsCollection.Add("Balance", txtBalance.Text);
                        dtElementsCollection.Add("BookPrice", txtBookPrice.Text);

                        frmIssuePreview frmIssuePrv = new frmIssuePreview(dtElementsCollection, this);
                        frmIssuePrv.ShowDialog();
                        #endregion

                        if (!_blnCancelledFromPreview)
                        {
                            #region [Construct History table]

                            BLSSchema.ctTransactionHistoryDataTable dtTransactionHistory = new BLSSchema.ctTransactionHistoryDataTable();

                            BLSSchema.ctTransactionHistoryRow row = dtTransactionHistory.NewctTransactionHistoryRow();

                            row.HistoryUID = id.ToString();

                            row.HistoryDate = row.IssueDate = DateTime.Now.ToString("yyyy-MM-dd").Substring(0, 10);

                            row.ReturnDate = DateTime.Now.AddMonths(_intMemberShipPeriod).ToString("yyyy-MM-dd").Substring(0, 10);

                            row.Type = "ISU";
                            
                            row.CheckNumber = "";
                            
                            row.CustomerID = txtID.Text;

                            fltTotalAmount = int.Parse(txtBookCount.Text) * float.Parse(txtBookPrice.Text);

                            row.Title = txtSelectedTitle.Text;

                            row.Author = txtSelectedAuthor.Text;

                            row.Edition = txtSelectedEdition.Text;

                            row.PurchasePrice = float.Parse(txtPurchasedPrice.Text);

                            row.AmountIn = fltTotalAmount.ToString();

                            row.AmountOut = "0";

                            row.RecieptNumber = "";

                            dtTransactionHistory.Rows.Add(row);

                            DataTable dtNewTransHistry = GetRawDataTable(dtTransactionHistory);
                            #endregion

                            #region [Construct Issue Table]

                            BLSSchema.ctIssueDataTable dtIssue = new BLSSchema.ctIssueDataTable();

                            BLSSchema.ctIssueRow IssueRow = dtIssue.NewctIssueRow();

                            IssueRow.CustomerID = txtID.Text;

                            IssueRow.Title = txtSelectedTitle.Text;

                            IssueRow.Author = txtSelectedAuthor.Text;

                            IssueRow.Edition = txtSelectedEdition.Text;

                            IssueRow.IssueDate = DateTime.Now.ToString("yyyy-MM-dd").Substring(0, 10);

                            IssueRow.BookCount = txtBookCount.Text;

                            IssueRow.BookPrice = txtBookPrice.Text;

                            IssueRow.RecieptNumber = "";

                            IssueRow.HistoryUID = id.ToString();

                            IssueRow.IssueType = Program.MainObj.GetCustomerType(txtMemberShipType.Text);

                            IssueRow.Returndate = DateTime.Now.AddMonths(_intMemberShipPeriod).ToString("yyyy-MM-dd").Substring(0, 10);

                            IssueRow.EarlyIssue = false;

                            dtIssue.Rows.Add(IssueRow);

                            DataTable dtNewIssue = GetRawDataTable(dtIssue);

                            #endregion

                            /**********************************************************************************
                             * Modified By : Shankar
                             * Changed int CustomerID to string CustomerID
                            **********************************************************************************/
                            //BL.PerformRegularIssueProcess(id.ToString(), txtID.Text, txtSelectedTitle.Text, txtSelectedAuthor.Text, txtSelectedEdition.Text,
                            //     float.Parse(txtBookPrice.Text), int.Parse(txtBookCount.Text), DateTime.Now,
                            //     float.Parse(txtAdvance.Text), float.Parse(txtBalance.Text), -1, dtNewTransHistry, dtNewIssue);

                            MessageBox.Show("Book(s) Issued", "Done.");

                            _blnCheckForMaxLimit = false;

                            _refToParent.Search(_refToParent._strLastQuery);

                             Close();

                        }
                    }
                    #endregion

                    #region [Issue book for Non-Rental customer]
                    else//Its non rental
                    {

                        //if (BL.CheckDuplicateIssue(int.Parse(txtID.Text), txtSelectedTitle.Text, txtSelectedAuthor.Text, txtSelectedEdition.Text,
                        //         float.Parse(txtBookPrice.Text)) == false)
                        //{
                            if (_blnCheckForMaxLimit)
                            {

                                #region [Construct History table]
                                BLSSchema.ctTransactionHistoryDataTable dtTransactionHistory = new BLSSchema.ctTransactionHistoryDataTable();

                                BLSSchema.ctTransactionHistoryRow row = dtTransactionHistory.NewctTransactionHistoryRow();

                                row.HistoryUID = id.ToString();

                                row.HistoryDate = row.IssueDate = DateTime.Now.ToString("yyyy-MM-dd").Substring(0, 10);

                                row.ReturnDate = DateTime.Now.AddMonths(_intMemberShipPeriod).ToString("yyyy-MM-dd").Substring(0, 10);

                                row.Type = "ISU";                              

                                row.CheckNumber = "";                               

                                row.CustomerID = txtID.Text;

                                fltTotalAmount = int.Parse(txtBookCount.Text) * float.Parse(txtBookPrice.Text);

                                row.Title = txtSelectedTitle.Text;

                                row.Author = txtSelectedAuthor.Text;

                                row.Edition = txtSelectedEdition.Text;

                                row.PurchasePrice = float.Parse(txtPurchasedPrice.Text);

                                row.AmountIn = fltTotalAmount.ToString();

                                row.AmountOut = "0";

                                row.RecieptNumber = "";

                                dtTransactionHistory.Rows.Add(row);

                                DataTable dtNewTransHistry = GetRawDataTable(dtTransactionHistory);

                                #endregion

                                #region [Construct Issue table]

                                //Add record to the Issue Table.

                                BLSSchema.ctIssueDataTable dtIssue = new BLSSchema.ctIssueDataTable();

                                BLSSchema.ctIssueRow IssueRow = dtIssue.NewctIssueRow();

                                IssueRow.CustomerID = txtID.Text;

                                IssueRow.Title = txtSelectedTitle.Text;

                                IssueRow.Author = txtSelectedAuthor.Text;

                                IssueRow.Edition = txtSelectedEdition.Text;

                                IssueRow.IssueDate = DateTime.Now.ToString("yyyy-MM-dd").Substring(0, 10); ;

                                IssueRow.BookCount = txtBookCount.Text;

                                IssueRow.BookPrice = txtBookPrice.Text;

                                IssueRow.RecieptNumber = "";

                                IssueRow.HistoryUID = id.ToString();

                                IssueRow.IssueType = Program.MainObj.GetCustomerType(txtMemberShipType.Text);

                                IssueRow.Returndate = DateTime.Now.AddMonths(_intMemberShipPeriod).ToString("yyyy-MM-dd").Substring(0, 10); ;

                                IssueRow.EarlyIssue = false;

                                dtIssue.Rows.Add(IssueRow);

                                DataTable dtNewIssue = GetRawDataTable(dtIssue);

                                #endregion

                                #region [Issue the Book]
                                //Update the Customer Table.
                                float CurrentAmount = float.Parse(txtBookPrice.Text) * int.Parse(txtBookCount.Text);

                                /**********************************************************************************
                                * Modified By : Shankar
                                * Changed int CustomerID to string CustomerID
                                **********************************************************************************/
                                //BL.PerformRegularIssueProcess(id.ToString(), txtID.Text, txtSelectedTitle.Text, txtSelectedAuthor.Text, txtSelectedEdition.Text,
                               // float.Parse(txtBookPrice.Text), int.Parse(txtBookCount.Text), DateTime.Now,
                             //   float.Parse(txtAdvance.Text), float.Parse(txtBalance.Text), CurrentAmount, dtNewTransHistry, dtNewIssue);

                                MessageBox.Show("Book(s) Issued", "Done.");

                                btnIssue.Enabled = false;
                                _blnCheckForMaxLimit = false;

                                _refToParent.Search(_refToParent._strLastQuery);

                                Close();
                                #endregion


                            }
                        //}
                        //else
                        //{
                        //    MessageBox.Show("Same book cannot be issued multiple times for Non-Rental type of customers", "Error");
                        //    return;
                        //}

                    }
                    #endregion
                }
            }
            catch (Exception ex)
            {
                //log exception
                Utility.WriteToFile(ex, "Error occured while issuing book");
                
                MessageBox.Show("Error occured while issuing book : " + ex.ToString(), "Error");
            }

        }

        private DataTable GetRawDataTable(BLSSchema.ctTransactionHistoryDataTable dtTransactionHistory)
        {
            DataTable dtRawDataTable = new DataTable();

            foreach (DataColumn cloumn in dtTransactionHistory.Columns)
            {
                dtRawDataTable.Columns.Add(cloumn.ColumnName, cloumn.DataType);
            }

            foreach (DataRow dr in dtTransactionHistory.Rows)
            {
                dtRawDataTable.ImportRow(dr);
            }

            return dtRawDataTable;
        }

        private DataTable GetRawDataTable(BLSSchema.ctIssueDataTable dtIssue)
        {
            DataTable dtRawDataTable = new DataTable();

            foreach (DataColumn cloumn in dtIssue.Columns)
            {
                dtRawDataTable.Columns.Add(cloumn.ColumnName, cloumn.DataType);
            }

            foreach (DataRow dr in dtIssue.Rows)
            {
                dtRawDataTable.ImportRow(dr);
            }

            return dtRawDataTable;
        }

        private bool ValidateAllFields()
        {
            if (string.IsNullOrWhiteSpace(txtBookPrice.Text))
            {
                MessageBox.Show("Please select a book to issue", "Error");
                return false;
            }
            
            if (string.IsNullOrWhiteSpace(txtAdvance.Text) == true)
            {
                txtAdvance.Text = "0";
            }
            if (string.IsNullOrWhiteSpace(txtBalance.Text) == true)
            {
                txtBalance.Text = "0";
            }
            if (string.IsNullOrWhiteSpace(txtBookCount.Text))
            {
                txtBookCount.Text = "1";
            }
            else if(int.Parse(txtBookCount.Text) > _intMaxAvailableCount)
            {
                MessageBox.Show("Book count should not exceed maximum stock available.\n Maximum stock available is : " + _intMaxAvailableCount.ToString(), "Error");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtBookPrice.Text))
            {
                MessageBox.Show("Please enter book price", "Error");
                return false;
            }

            return true;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            _intMaxAvailableCount = 0;
            frmCustomerSearch1 frmStcksrch = new frmCustomerSearch1(this);
            frmStcksrch.ShowDialog();
        }

        private void btnChooseCustomer_Click(object sender, EventArgs e)
        {
            frmCustomerSearch frmCustSearch = new frmCustomerSearch(this);
            frmCustSearch.ShowDialog();
        }

        private void frmIssue_Load(object sender, EventArgs e)
        {
            _blnCheckForMaxLimit = false;

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            _blnCheckForMaxLimit = false;
        }

        private void txtBookCount_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}
