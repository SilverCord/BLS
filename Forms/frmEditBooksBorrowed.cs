using LibraryDesign_frontEndUI.Library;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LibraryDesign_frontEndUI.Forms
{
    public partial class frmEditBooksBorrowed : Form
    {
        internal int _intCustomerID = -1;
        internal string _strMemberShipType = string.Empty;
        internal int _intMemberShipPeriod = 0;
        internal string _strAdvance = string.Empty;
        internal string _strBalance = string.Empty;
        internal BLSSchema.ctIssueDataTable _dtIssue = new BLSSchema.ctIssueDataTable();
        BLSSchema.ctStockDataTable _dtNewIssue = new BLSSchema.ctStockDataTable();
        frmCustomerSearch _frmParentref = null;
        internal float _fltCurrentBookAmount = 0;
        BusinessLogic BL = new BusinessLogic();

        public frmEditBooksBorrowed(frmCustomerSearch frmParentref)
        {
            InitializeComponent();                      
            _frmParentref = frmParentref;
            cmbMonth.SelectedIndex = 0;

        }

        private void SearchBooksBorrowed()
        {
            try
            {
                if (_intCustomerID != -1)
                {
                    _dtIssue.Clear();
                    BL.SearchBooksBorrowed(ref _dtIssue, _intCustomerID);
                    dgvStudentIssuedBooks.DataSource = _dtIssue;
                }
            }
            catch (Exception ex)
            {
                //log exception
                Utility.WriteToFile(ex, "Error while retrieving borrowed book list");

                MessageBox.Show("Error while retrieving borrowed book list : " + ex, "Error");
            }
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            frmAddStock frmStock = new frmAddStock(this,"BB", false, ref _dtNewIssue, _intCustomerID, _strMemberShipType, _fltCurrentBookAmount);
            frmStock.ShowDialog();
            dgvStudentBooks.DataSource = _dtNewIssue;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (_dtNewIssue.Rows.Count > 0)
                {
                    if (cmbMonth.SelectedItem == "--SELECT--")
                    {
                        MessageBox.Show("Please select the return month and proceed", "Return Month");
                        return;
                    }
                    #region [Calculate Total Book Count]
                    int intTotalBookCount = 0;
                    //Get total number of books borowed by the customers.                   
                    object SumObject = _dtNewIssue.Compute("Sum(OutCount)", "");
                    intTotalBookCount = int.Parse(SumObject.ToString());

                    #endregion
                    
                    foreach (BLSSchema.ctStockRow row in _dtNewIssue)
                    {

                        BusinessLogic BL = new BusinessLogic();

                        string stUniqueID = Guid.NewGuid().ToString();

                        #region [Construct Stock Table]

                        BLSSchema.ctStockDataTable dtStock = new BLSSchema.ctStockDataTable();

                        dtStock.ImportRow(row);

                        DataTable dtNewStock = Program.MainObj.GetRawDataTable(dtStock);
                        
                        #endregion

                        #region [Construct Issue Table]

                        BLSSchema.ctIssueDataTable dtCustIssues = new BLSSchema.ctIssueDataTable();

                        BLSSchema.ctIssueRow CustIssuerow = dtCustIssues.NewctIssueRow();

                        CustIssuerow.CustomerID = _intCustomerID.ToString();

                        CustIssuerow.Title = row["Title"].ToString();

                        CustIssuerow.Author = row["Author"].ToString();

                        CustIssuerow.Edition = row["Edition"].ToString();

                        CustIssuerow.Publisher = row["Publisher"].ToString();

                        CustIssuerow.IssueDate = DateTime.Now.ToString("yyyy-MM-dd").Substring(0, 10);

                        CustIssuerow.BookCount = row["OutCount"].ToString();

                        CustIssuerow.BookPrice = row["OriginalPrice"].ToString();

                        CustIssuerow.RecieptNumber = "";

                        CustIssuerow.HistoryUID = stUniqueID;

                        CustIssuerow.IssueType = _strMemberShipType;

                        CustIssuerow.Returndate = (Program.MainObj.GetReturnDate(cmbMonth.SelectedIndex)).ToString("yyyy-MM-dd").Substring(0, 10); ;

                        CustIssuerow.EarlyIssue = true;

                        dtCustIssues.Rows.Add(CustIssuerow);

                        DataTable dtCustIssuedBooks = Program.MainObj.GetRawDataTable(dtCustIssues);
                       
                        #endregion

                        #region [Update Customer details]

                        //BL.UpdateCustomer("Issue", _strMemberShipType, _strCustomerId.ToString(), int.Parse(row["OutCount"].ToString()), float.Parse(txtAdvance.Text),
                        //   float.Parse(txtBalanceAmount.Text), (float.Parse(row["OriginalPrice"].ToString()) * float.Parse(row["OutCount"].ToString())));

                        //This is done in next statement

                        #endregion

                        #region [Perform Transaction]

                        /**********************************************************************************
                        * Modified By : Shankar
                        * Changed int CustomerID to string CustomerID
                        **********************************************************************************/
                        BL.PerformEarlyIssueProcess(_intCustomerID.ToString(), int.Parse(row["OutCount"].ToString()), DateTime.Now,
                           float.Parse(_strAdvance), float.Parse(_strBalance),
                           (_strMemberShipType == "N") ? (float.Parse(row["OriginalPrice"].ToString()) * float.Parse(row["OutCount"].ToString())) : -1,
                           dtNewStock, dtCustIssuedBooks);
                        #endregion

                    }

                    MessageBox.Show("Records added successfully", "Done");
                    _frmParentref.Search(_frmParentref._strLastQuery);
                    Close();

                    //Add Count of books borrrowed to the TblCustomer table.

                }
                else
                {
                    MessageBox.Show("No records to update.", "Done");
                    return;
                }
            }
            catch (Exception ex)
            {
                //log exception
                Utility.WriteToFile(ex, "Error occured while adding book details");

                MessageBox.Show("Error occured while adding book details.Error : " + ex.ToString(), "Error");
            }
        }     

        private void frmEditBooksBorrowed_Activated(object sender, EventArgs e)
        {
            txtMemberShipID.Text = _intCustomerID.ToString();
            SearchBooksBorrowed();
        }

        private void dgvStudentIssuedBooks_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.dgvStudentIssuedBooks.Columns[e.ColumnIndex].Name == "IssueType")
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
            else if (this.dgvStudentIssuedBooks.Columns[e.ColumnIndex].Name == "IssueDate" ||
                this.dgvStudentIssuedBooks.Columns[e.ColumnIndex].Name == "Returndate")
            {
                if (e.Value != null)
                {
                    // Check for the string "pink" in the cell.
                    string stringValue = (string)e.Value;
                    e.Value = stringValue.Substring(0, 10);

                }
            }
        }

        private void dgvStudentIssuedBooks_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1 && dgvStudentIssuedBooks.Columns[e.ColumnIndex].HeaderText.ToString() == "Remove")
            {
                if (MessageBox.Show("Are you sure.you want to delete this record?", "Delete Confirmation?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {

                    #region[Save grid values to variables]

                    string strTitle = dgvStudentIssuedBooks.Rows[e.RowIndex].Cells["ITitle"].Value.ToString();

                    string strAuthor = dgvStudentIssuedBooks.Rows[e.RowIndex].Cells["IAuthor"].Value.ToString();

                    string strEdition = dgvStudentIssuedBooks.Rows[e.RowIndex].Cells["IEdition"].Value.ToString();

                    string strPublisher = dgvStudentIssuedBooks.Rows[e.RowIndex].Cells["IPublisher"].Value.ToString();

                    float fltPrice = float.Parse(dgvStudentIssuedBooks.Rows[e.RowIndex].Cells["BookPrice"].Value.ToString());

                    string strUID = dgvStudentIssuedBooks.Rows[e.RowIndex].Cells["HistoryUID"].Value.ToString();

                    int intBookCount = int.Parse(dgvStudentIssuedBooks.Rows[e.RowIndex].Cells["BookCount"].Value.ToString());

                    #endregion

                    if (_strMemberShipType == "N")
                    {
                        /**********************************************************************************
                        * Modified By : Shankar
                        * Changed int CustomerID to string CustomerID
                        **********************************************************************************/
                        if (BL.DeleteIssuedBookEntries_NonRental(_intCustomerID.ToString(), strTitle, strAuthor, strEdition,
                            strPublisher, fltPrice, strUID, intBookCount, true))
                        {
                            SearchBooksBorrowed();

                            _frmParentref.Search(_frmParentref._strLastQuery);

                            MessageBox.Show("Book entry has been removed", "Success");

                        }
                        else
                        {
                            MessageBox.Show("Some error occured while removing book entry.\n Please try after some time.", "Error");
                        }
                    }
                    else
                    {
                        /**********************************************************************************
                        * Modified By : Shankar
                        * Changed int CustomerID to string CustomerID
                        **********************************************************************************/
                        if (BL.DeleteIssuedBookEntries_Rental(_intCustomerID.ToString(), strTitle, strAuthor, strEdition, strPublisher,
                            fltPrice, strUID, intBookCount, true))
                        {
                            SearchBooksBorrowed();

                            _frmParentref.Search(_frmParentref._strLastQuery);

                            MessageBox.Show("Book entry has been removed", "Success");

                        }
                        else
                        {
                            MessageBox.Show("Some error occured while removing book entry.\n Please try after some time.", "Error");
                        }

                    }
                }

            }
        }
        
    }
}
