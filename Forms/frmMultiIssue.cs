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
    public partial class frmMultiIssue : Form
    {
        internal string _strMemberShipType = string.Empty;
        internal float _fltCurrentBookAmount = 0;
        internal bool _blnCancelledFromPreview = false;
        frmCustomerSearch _refToParent = null;
        string _strReceiptNumber = string.Empty;

        BLSSchema _Bschema = new BLSSchema();
        internal BLSSchema.ctIssueBookListDataTable _dtAlreadyIssuedBooks = new BLSSchema.ctIssueBookListDataTable();
        internal BLSSchema.ctStockSearchDataTable _dtSelectedStock = new BLSSchema.ctStockSearchDataTable();

        public frmMultiIssue(string[] strElements,Form refToParent)
        {
            InitializeComponent();
            cmbMonth.SelectedIndex = 0;
            _dtSelectedStock.Clear();
            lblCustID.Text = strElements[0];
            lblCustomerName.Text = strElements[1];
            _strMemberShipType = strElements[8];
            lblCustomerType.Text = Program.MainObj.GetDetailedCustomerType(strElements[8]);
            pbCustImage.ImageLocation = strElements[12];
            if (strElements[8] == "R" || strElements[8] == "Rental")
            {
                lblAdvance.Text = "Advance :";
                lblAdvanceAmount.Text = strElements[6];
                lblBalance.Text = "Balance :";
                lblBalanceAmount.Text = strElements[7];
                lblRecieptNumber.Visible = false;
                lblRcptNum.Visible = false;
                          
            }
            else if (strElements[8] == "N" || strElements[8] == "Non-Rental")
            {
                lblAdvance.Text = "Max Limit :";
                lblAdvanceAmount.Text = strElements[10];
                lblBalance.Text = "Used Limit :";
                lblBalanceAmount.Text = strElements[11];
                lblRecieptNumber.Text = strElements[11];
                lblRcptNum.Text = "Current Used Limit :";
                
            }
            _refToParent = (frmCustomerSearch)refToParent;
            Search();
            
        }

        public void Search()
        {
            try
            {
               _dtAlreadyIssuedBooks.Clear();
                BusinessLogic BLgc = new BusinessLogic();
                BLgc.GetIssueDetails(_dtAlreadyIssuedBooks, lblCustID.Text);
                if (_dtAlreadyIssuedBooks.Rows.Count > 0)
                {
                    dgvStudentIssuedBooks.DataSource =_dtAlreadyIssuedBooks;
                    if (lblCustomerType.Text == "Rental")
                    {
                        lblRecieptNumber.Text = _dtAlreadyIssuedBooks[0]["RecieptNumber"].ToString();
                    }
                }
                else
                {
                    // lblCustomerStatus.Text = "No Data found.";
                }
            }
            catch (Exception ex)
            {
                //log exception
                Utility.WriteToFile(ex, "Error occured while retrieving record");

                MessageBox.Show("Error occured while retrieving record : " + ex.ToString(), "Error");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            float Limit = 0;
            if (_strMemberShipType == "N")
            {
                Limit = float.Parse(lblRecieptNumber.Text);
            }
            _dtSelectedStock.Clear();
            frmChooseStockItem frmChooseItem = new frmChooseStockItem(this);
            frmChooseItem._MaxLimit = float.Parse(lblAdvanceAmount.Text);
            frmChooseItem._UsedLimit = float.Parse(lblBalanceAmount.Text);
            frmChooseItem._strType =_strMemberShipType;
            frmChooseItem.ShowDialog();
        }

        private void dgvStudentBooks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            if (dgvStudentBooks.Columns[e.ColumnIndex].HeaderText == "Remove")
            {
                BLSSchema.ctStockSearchDataTable ctSelectedStockItems = ((BLSSchema.ctStockSearchDataTable)(dgvStudentBooks.DataSource));

                ctSelectedStockItems.Rows.RemoveAt(e.RowIndex);
                dgvStudentBooks.DataSource = ctSelectedStockItems;
            }
            else
            {
                return;
            }
        }

        private void btnIssue_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbMonth.SelectedItem.ToString() == "--SELECT--")
                {
                    MessageBox.Show("Please select the return month and proceed", "Return Month");
                    return;
                }
                if (dgvStudentBooks.RowCount == 0)
                {
                    MessageBox.Show("Please select the book(s) to issue.", "Error");
                }
                else
                {
                    if (MessageBox.Show("Are you sure.you want to issue this book(s)?",
                        "Return Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        #region [Issue book for Rental customer]
                        if (_strMemberShipType == "R")
                        {
                            #region [Display Payment Preview form]
                            Dictionary<string, string> dtElementsCollection = new Dictionary<string, string>();
                            dtElementsCollection.Add("CustomerName", lblCustomerName.Text);
                            dtElementsCollection.Add("IssueType", _strMemberShipType);
                            dtElementsCollection.Add("Advance", lblAdvanceAmount.Text);
                            dtElementsCollection.Add("Balance", lblBalanceAmount.Text);
                            dtElementsCollection.Add("BookPrice", _fltCurrentBookAmount.ToString());
                            frmIssuePreview frmIssuePrv = new frmIssuePreview(dtElementsCollection, this);

                            frmIssuePrv.ShowDialog();
                            #endregion

                            if (!_blnCancelledFromPreview)
                            {
                                IssueRentalBooks();                               
                            }
                        }
                        #endregion
                        #region [Issue book for Non-rental customer]
                        else if (_strMemberShipType == "N")//Its Non rental
                        {
                            IssueNonRentalBooks();
                        }

                        #endregion
                    }
                       


                    



                    #region [Issue book for OTHER type customer]
                    else if (_strMemberShipType == "Other")//Its Other(Special category)
                    {
                        #region [Show Preview form]
                        //Dictionary<string, string> dtElementsCollection = new Dictionary<string, string>();
                        //dtElementsCollection.Add("CustomerName", txtFirstName.Text);
                        //dtElementsCollection.Add("BookTitle", txtSelectedTitle.Text);
                        //dtElementsCollection.Add("IssueType", Program.MainObj.GetCustomerType(txtMemberShipType.Text));
                        //dtElementsCollection.Add("Advance", txtAdvance.Text);
                        //dtElementsCollection.Add("Balance", txtBalance.Text);
                        //dtElementsCollection.Add("BookPrice", txtBookPrice.Text);

                        //frmIssuePreview frmIssuePrv = new frmIssuePreview(dtElementsCollection, this);
                        //frmIssuePrv.ShowDialog();
                        #endregion

                        //    if (!_blnCancelledFromPreview)
                        //    {
                        //  #region [Construct History table]

                        //        BLSSchema.ctTransactionHistoryDataTable dtTransactionHistory = new BLSSchema.ctTransactionHistoryDataTable();

                        //        BLSSchema.ctTransactionHistoryRow row = dtTransactionHistory.NewctTransactionHistoryRow();

                        //        row.HistoryUID = id.ToString();

                        //        row.HistoryDate = row.IssueDate = DateTime.Now.ToString("yyyy-MM-dd").Substring(0, 10);

                        //        row.ReturnDate = DateTime.Now.AddMonths(_intMemberShipPeriod).ToString("yyyy-MM-dd").Substring(0, 10);

                        //        row.Type = "ISU";

                        //        row.CheckNumber = "";

                        //        row.CustomerID = txtID.Text;

                        //        fltTotalAmount = int.Parse(txtBookCount.Text) * float.Parse(txtBookPrice.Text);

                        //        row.Title = txtSelectedTitle.Text;

                        //        row.Author = txtSelectedAuthor.Text;

                        //        row.Edition = txtSelectedEdition.Text;

                        //        row.PurchasePrice = float.Parse(txtPurchasedPrice.Text);

                        //        row.AmountIn = fltTotalAmount.ToString();

                        //        row.AmountOut = "0";

                        //        row.RecieptNumber = "";

                        //        dtTransactionHistory.Rows.Add(row);

                        //        DataTable dtNewTransHistry = GetRawDataTable(dtTransactionHistory);
                        //        #endregion

                        //        #region [Construct Issue Table]

                        //        BLSSchema.ctIssueDataTable dtIssue = new BLSSchema.ctIssueDataTable();

                        //        BLSSchema.ctIssueRow IssueRow = dtIssue.NewctIssueRow();

                        //        IssueRow.CustomerID = txtID.Text;

                        //        IssueRow.Title = txtSelectedTitle.Text;

                        //        IssueRow.Author = txtSelectedAuthor.Text;

                        //        IssueRow.Edition = txtSelectedEdition.Text;

                        //        IssueRow.IssueDate = DateTime.Now.ToString("yyyy-MM-dd").Substring(0, 10);

                        //        IssueRow.BookCount = txtBookCount.Text;

                        //        IssueRow.BookPrice = txtBookPrice.Text;

                        //        IssueRow.RecieptNumber = "";

                        //        IssueRow.HistoryUID = id.ToString();

                        //        IssueRow.IssueType = Program.MainObj.GetCustomerType(txtMemberShipType.Text);

                        //        IssueRow.Returndate = DateTime.Now.AddMonths(_intMemberShipPeriod).ToString("yyyy-MM-dd").Substring(0, 10);

                        //        IssueRow.EarlyIssue = false;

                        //        dtIssue.Rows.Add(IssueRow);

                        //        DataTable dtNewIssue = GetRawDataTable(dtIssue);

                        //        #endregion

                        //        /**********************************************************************************
                        //         * Modified By : Shankar
                        //         * Changed int CustomerID to string CustomerID
                        //        **********************************************************************************/
                        //        BL.PerformRegularIssueProcess(id.ToString(), txtID.Text, txtSelectedTitle.Text, txtSelectedAuthor.Text, txtSelectedEdition.Text,
                        //             float.Parse(txtBookPrice.Text), int.Parse(txtBookCount.Text), DateTime.Now,
                        //             float.Parse(txtAdvance.Text), float.Parse(txtBalance.Text), -1, dtNewTransHistry, dtNewIssue);

                        //        MessageBox.Show("Book(s) Issued", "Done.");

                        //        _blnCheckForMaxLimit = false;

                        //        _refToParent.Search(_refToParent._strLastQuery);

                        //         Close();

                        //    }
                    }
                    #endregion

                    #region [Issue book for Non-Rental customer]
                    else//Its non rental
                    {

                        //if (BL.CheckDuplicateIssue(int.Parse(txtID.Text), txtSelectedTitle.Text, txtSelectedAuthor.Text, txtSelectedEdition.Text,
                        //         float.Parse(txtBookPrice.Text)) == false)
                        //{
                        //if (_blnCheckForMaxLimit)
                        //{

                        //    #region [Construct History table]
                        //    BLSSchema.ctTransactionHistoryDataTable dtTransactionHistory = new BLSSchema.ctTransactionHistoryDataTable();

                        //    BLSSchema.ctTransactionHistoryRow row = dtTransactionHistory.NewctTransactionHistoryRow();

                        //    row.HistoryUID = id.ToString();

                        //    row.HistoryDate = row.IssueDate = DateTime.Now.ToString("yyyy-MM-dd").Substring(0, 10);

                        //    row.ReturnDate = DateTime.Now.AddMonths(_intMemberShipPeriod).ToString("yyyy-MM-dd").Substring(0, 10);

                        //    row.Type = "ISU";                              

                        //    row.CheckNumber = "";                               

                        //    row.CustomerID = txtID.Text;

                        //    fltTotalAmount = int.Parse(txtBookCount.Text) * float.Parse(txtBookPrice.Text);

                        //    row.Title = txtSelectedTitle.Text;

                        //    row.Author = txtSelectedAuthor.Text;

                        //    row.Edition = txtSelectedEdition.Text;

                        //    row.PurchasePrice = float.Parse(txtPurchasedPrice.Text);

                        //    row.AmountIn = fltTotalAmount.ToString();

                        //    row.AmountOut = "0";

                        //    row.RecieptNumber = "";

                        //    dtTransactionHistory.Rows.Add(row);

                        //    DataTable dtNewTransHistry = GetRawDataTable(dtTransactionHistory);

                        //    #endregion

                        //    #region [Construct Issue table]

                        //    //Add record to the Issue Table.

                        //    BLSSchema.ctIssueDataTable dtIssue = new BLSSchema.ctIssueDataTable();

                        //    BLSSchema.ctIssueRow IssueRow = dtIssue.NewctIssueRow();

                        //    IssueRow.CustomerID = txtID.Text;

                        //    IssueRow.Title = txtSelectedTitle.Text;

                        //    IssueRow.Author = txtSelectedAuthor.Text;

                        //    IssueRow.Edition = txtSelectedEdition.Text;

                        //    IssueRow.IssueDate = DateTime.Now.ToString("yyyy-MM-dd").Substring(0, 10); ;

                        //    IssueRow.BookCount = txtBookCount.Text;

                        //    IssueRow.BookPrice = txtBookPrice.Text;

                        //    IssueRow.RecieptNumber = "";

                        //    IssueRow.HistoryUID = id.ToString();

                        //    IssueRow.IssueType = Program.MainObj.GetCustomerType(txtMemberShipType.Text);

                        //    IssueRow.Returndate = DateTime.Now.AddMonths(_intMemberShipPeriod).ToString("yyyy-MM-dd").Substring(0, 10); ;

                        //    IssueRow.EarlyIssue = false;

                        //    dtIssue.Rows.Add(IssueRow);

                        //    DataTable dtNewIssue = GetRawDataTable(dtIssue);

                        //    #endregion

                        //    #region [Issue the Book]
                        //    //Update the Customer Table.
                        //    float CurrentAmount = float.Parse(txtBookPrice.Text) * int.Parse(txtBookCount.Text);

                        //    /**********************************************************************************
                        //    * Modified By : Shankar
                        //    * Changed int CustomerID to string CustomerID
                        //    **********************************************************************************/
                        //    BL.PerformRegularIssueProcess(id.ToString(), txtID.Text, txtSelectedTitle.Text, txtSelectedAuthor.Text, txtSelectedEdition.Text,
                        //    float.Parse(txtBookPrice.Text), int.Parse(txtBookCount.Text), DateTime.Now,
                        //    float.Parse(txtAdvance.Text), float.Parse(txtBalance.Text), CurrentAmount, dtNewTransHistry, dtNewIssue);

                        //    MessageBox.Show("Book(s) Issued", "Done.");

                        //    btnIssue.Enabled = false;
                        //    _blnCheckForMaxLimit = false;

                        //    _refToParent.Search(_refToParent._strLastQuery);

                        //    Close();
                        //    #endregion


                        //}
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

        private void IssueRentalBooks()
        {
            try
            {
                BusinessLogic BL = new BusinessLogic();
                string strReturnDate = (Program.MainObj.GetReturnDate(cmbMonth.SelectedIndex)).ToString("yyyy-MM-dd").Substring(0, 10);
                float fltadvance = 0;
                float fltBalance = 0;
                float fltPrice = 0;
                string strUID = string.Empty;
                bool blnIssuestatus = false;
                int intRowCount = _dtSelectedStock.Rows.Count;
                if (_dtAlreadyIssuedBooks.Rows.Count > 0)
                {
                    _strReceiptNumber = _dtAlreadyIssuedBooks[0]["RecieptNumber"].ToString();
                }
                else
                {
                    _strReceiptNumber = BL.GetReceiptNumber();
                }


                for (int intI = 0; intI < intRowCount; intI++)
                {
                    if (intI == intRowCount - 1)
                    {
                        fltadvance = float.Parse(lblAdvanceAmount.Text);
                        fltBalance = float.Parse(lblBalanceAmount.Text);
                    }

                    fltPrice = float.Parse(_dtSelectedStock[intI]["OriginalPrice"].ToString());
                    strUID = System.Guid.NewGuid().ToString();

                    #region [Construct History Table]

                    BLSSchema.ctTransactionHistoryDataTable dtTransactionHistory = new BLSSchema.ctTransactionHistoryDataTable();

                    BLSSchema.ctTransactionHistoryRow row = dtTransactionHistory.NewctTransactionHistoryRow();

                    row.HistoryUID = strUID;

                    row.HistoryDate = row.IssueDate = DateTime.Now.ToString("yyyy-MM-dd").Substring(0, 10);

                    //row.ReturnDate = DateTime.Now.AddMonths(_intMemberShipPeriod).ToString("yyyy-MM-dd").Substring(0, 10);


                    row.ReturnDate = strReturnDate;

                    row.Type = _strMemberShipType;

                    row.CheckNumber = "";

                    row.CustomerID = lblCustID.Text;

                    row.Title = _dtSelectedStock[intI]["Title"].ToString();

                    row.Author = _dtSelectedStock[intI]["Author"].ToString();

                    row.Edition = _dtSelectedStock[intI]["Edition"].ToString();

                    row.Publisher = _dtSelectedStock[intI]["Publisher"].ToString();

                    row.PurchasePrice = fltPrice;

                    row.AmountIn = fltPrice.ToString();

                    row.AmountOut = "0";

                    row.RecieptNumber = _strReceiptNumber;

                    dtTransactionHistory.Rows.Add(row);

                    DataTable dtNewTransHistry = Program.MainObj.GetRawDataTable(dtTransactionHistory);

                    #endregion

                    #region [Construct Issue Table]

                    BLSSchema.ctIssueDataTable dtIssue = new BLSSchema.ctIssueDataTable();

                    BLSSchema.ctIssueRow IssueRow = dtIssue.NewctIssueRow();

                    IssueRow.CustomerID = lblCustID.Text;

                    IssueRow.Title = _dtSelectedStock[intI]["Title"].ToString();

                    IssueRow.Author = _dtSelectedStock[intI]["Author"].ToString();

                    IssueRow.Edition = _dtSelectedStock[intI]["Edition"].ToString();

                    IssueRow.Publisher = _dtSelectedStock[intI]["Publisher"].ToString();

                    IssueRow.IssueDate = DateTime.Now.ToString("yyyy-MM-dd").Substring(0, 10);

                    IssueRow.BookCount = "1";

                    IssueRow.BookPrice = fltPrice.ToString();

                    IssueRow.RecieptNumber = _strReceiptNumber;

                    IssueRow.HistoryUID = strUID;

                    IssueRow.IssueType = _strMemberShipType;

                    IssueRow.Returndate = strReturnDate;

                    IssueRow.EarlyIssue = false;

                    dtIssue.Rows.Add(IssueRow);

                    DataTable dtNewIssue = Program.MainObj.GetRawDataTable(dtIssue);

                    #endregion

                    if (BL.PerformRegularIssueProcess(fltadvance, fltBalance,
                       -1, dtNewTransHistry, dtNewIssue))
                    {
                        blnIssuestatus = true;
                    }
                    else
                    {
                        blnIssuestatus = false;
                    }

                }

                if (blnIssuestatus)
                {
                    _dtSelectedStock.Rows.Clear();

                    Search();

                    _refToParent.Search(_refToParent._strLastQuery);

                    MessageBox.Show("Issue Process Completed", "Success");
                }
                else
                {
                    MessageBox.Show("Error while issuing one or more books.\nPlease repeat the return process", "Error");
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException(ex.ToString());

            }
        }

        private void IssueNonRentalBooks()
        {
            try
            {
                BusinessLogic BL = new BusinessLogic();
                string strReturnDate = (Program.MainObj.GetReturnDate(cmbMonth.SelectedIndex)).ToString("yyyy-MM-dd").Substring(0, 10);                
                float fltPrice = 0;
                string strUID = string.Empty;
                bool blnIssuestatus = false;
                int intRowCount = _dtSelectedStock.Rows.Count;
                if (_dtAlreadyIssuedBooks.Rows.Count > 0)
                {
                    _strReceiptNumber = _dtAlreadyIssuedBooks[0]["RecieptNumber"].ToString();
                }
                else
                {
                    _strReceiptNumber = BL.GetReceiptNumber();
                }


                for (int intI = 0; intI < intRowCount; intI++)
                {
                    
                    fltPrice = float.Parse(_dtSelectedStock[intI]["OriginalPrice"].ToString());
                    strUID = System.Guid.NewGuid().ToString();

                    #region [Construct History Table]

                    BLSSchema.ctTransactionHistoryDataTable dtTransactionHistory = new BLSSchema.ctTransactionHistoryDataTable();

                    BLSSchema.ctTransactionHistoryRow row = dtTransactionHistory.NewctTransactionHistoryRow();

                    row.HistoryUID = strUID;

                    row.HistoryDate = row.IssueDate = DateTime.Now.ToString("yyyy-MM-dd").Substring(0, 10);

                    //row.ReturnDate = DateTime.Now.AddMonths(_intMemberShipPeriod).ToString("yyyy-MM-dd").Substring(0, 10);


                    row.ReturnDate = strReturnDate;

                    row.Type = _strMemberShipType;

                    row.CheckNumber = "";

                    row.CustomerID = lblCustID.Text;

                    row.Title = _dtSelectedStock[intI]["Title"].ToString();

                    row.Author = _dtSelectedStock[intI]["Author"].ToString();

                    row.Edition = _dtSelectedStock[intI]["Edition"].ToString();

                    row.Publisher = _dtSelectedStock[intI]["Publisher"].ToString();

                    row.PurchasePrice = fltPrice;

                    row.AmountIn = fltPrice.ToString();

                    row.AmountOut = "0";

                    row.RecieptNumber = _strReceiptNumber;

                    dtTransactionHistory.Rows.Add(row);

                    DataTable dtNewTransHistry = Program.MainObj.GetRawDataTable(dtTransactionHistory);

                    #endregion

                    #region [Construct Issue Table]

                    BLSSchema.ctIssueDataTable dtIssue = new BLSSchema.ctIssueDataTable();

                    BLSSchema.ctIssueRow IssueRow = dtIssue.NewctIssueRow();

                    IssueRow.CustomerID = lblCustID.Text;

                    IssueRow.Title = _dtSelectedStock[intI]["Title"].ToString();

                    IssueRow.Author = _dtSelectedStock[intI]["Author"].ToString();

                    IssueRow.Edition = _dtSelectedStock[intI]["Edition"].ToString();

                    IssueRow.Publisher = _dtSelectedStock[intI]["Publisher"].ToString();

                    IssueRow.IssueDate = DateTime.Now.ToString("yyyy-MM-dd").Substring(0, 10);

                    IssueRow.BookCount = "1";

                    IssueRow.BookPrice = fltPrice.ToString();

                    IssueRow.RecieptNumber = _strReceiptNumber;

                    IssueRow.HistoryUID = strUID;

                    IssueRow.IssueType = _strMemberShipType;

                    IssueRow.Returndate = strReturnDate;

                    IssueRow.EarlyIssue = false;

                    dtIssue.Rows.Add(IssueRow);

                    DataTable dtNewIssue = Program.MainObj.GetRawDataTable(dtIssue);

                    #endregion

                    if (BL.PerformRegularIssueNonRentalProcess(dtNewTransHistry, dtNewIssue))
                    {                        
                        blnIssuestatus = true;
                    }
                    else
                    {
                        blnIssuestatus = false;
                    }

                }

                if (blnIssuestatus)
                {

                    BL.UpdateCustomerForNonRentalIssue(lblCustID.Text, intRowCount, float.Parse(lblRecieptNumber.Text));
                    lblBalanceAmount.Text = lblRecieptNumber.Text;

                    _dtSelectedStock.Rows.Clear();

                    Search();

                    _refToParent.Search(_refToParent._strLastQuery);

                    

                    MessageBox.Show("Issue Process Completed", "Success");
                }
                else
                {
                    MessageBox.Show("Error while issuing one or more books.\nPlease repeat the return process", "Error");
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException(ex.ToString());

            }
        }
        

        private void btnAddIssueItem_Click(object sender, EventArgs e)
        {

        }

        private void dgvStudentIssuedBooks_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // If the column is the Artist column, check the 
            // value. 
            if (dgvStudentIssuedBooks.Columns[e.ColumnIndex].Name == "IssueDate" ||
                dgvStudentIssuedBooks.Columns[e.ColumnIndex].Name == "Returndate")
            {
                if (e.Value != null)
                {
                    // Check for the string "pink" in the cell.
                    string stringValue = (string)e.Value;
                    e.Value = stringValue.Substring(0, 10);

                }
            }
        }

        private void dgvStudentBooks_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // If the column is the Artist column, check the 
            // value. 
            if (dgvStudentBooks.Columns[e.ColumnIndex].Name == "IssueDate" ||
                dgvStudentBooks.Columns[e.ColumnIndex].Name == "Returndate")
            {
                if (e.Value != null)
                {
                    // Check for the string "pink" in the cell.
                    string stringValue = (string)e.Value;
                    e.Value = stringValue.Substring(0, 10);

                }
            }
        }

        internal void RefreshGrid()
        {
            dgvStudentBooks.DataSource = _dtSelectedStock;
            dgvStudentBooks.Refresh();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
           
        }

     
    }
}
