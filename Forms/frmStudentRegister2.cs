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
    public partial class frmStudentRegister2 : Form
    {
        internal int _intCustomerId;
        internal string _strMemberShipType = string.Empty;
        internal int _intMemberShipPeriod = 0;
        BLSSchema.ctStockDataTable _dtStock = new BLSSchema.ctStockDataTable();
        internal float _fltCurrentBookAmount = 0;
        
        public frmStudentRegister2( string strFirstName,string strMobile,string strAdvanceAmount,string strBalanceAmount)
        {
            InitializeComponent();
            txtFirstName.Text = strFirstName;            
            txtMobile.Text = strMobile;
            txtAdvance.Text = strAdvanceAmount;
            txtBalanceAmount.Text = strBalanceAmount;
            cmbMonth.SelectedIndex = 0;
        }

        internal void GetBooksBorrowed(int intCustomerID)
        {
            BLSSchema.ctStockDataTable dtTempStock = new BLSSchema.ctStockDataTable();
            BusinessLogic BL = new BusinessLogic();
            BL.GetEarlyIssueDetails(dtTempStock, intCustomerID);
            dgvStudentBooks.DataSource = dtTempStock;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //The arguement false indicate that it is not called directly from Main MDI
            //The flag is used to determine on click of OK what should be done.
            frmAddStock frmStock = new frmAddStock(this,"RG" ,false, ref _dtStock, _intCustomerId, _strMemberShipType,_fltCurrentBookAmount);
            frmStock.ShowDialog();
            dgvStudentBooks.DataSource = _dtStock;
        }


        private void dgvStudentBooks_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using (SolidBrush b = new SolidBrush(dgvStudentBooks.RowHeadersDefaultCellStyle.ForeColor))
            {
                e.Graphics.DrawString((e.RowIndex + 1).ToString(System.Globalization.CultureInfo.CurrentUICulture), e.InheritedRowStyle.Font, b, e.RowBounds.Location.X + 7, e.RowBounds.Location.Y + 4);
            }
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbMonth.SelectedItem == "--SELECT--")
                {
                    MessageBox.Show("Please select the return month and proceed", "Return Month");
                    return;
                }

                if (_dtStock.Rows.Count > 0)
                {
                    #region [Calculate Total Book Count]
                    int intTotalBookCount = 0;
                    //Get total number of books borowed by the customers.              
                    object SumObject = _dtStock.Compute("Sum(OutCount)", "");
                    intTotalBookCount = int.Parse(SumObject.ToString());
                    

                    #endregion


                    foreach (BLSSchema.ctStockRow row in _dtStock)
                    {

                        BusinessLogic BL = new BusinessLogic();

                        string stUniqueID = Guid.NewGuid().ToString();

                        #region [Construct Stock Table]

                        BLSSchema.ctStockDataTable dtStock = new BLSSchema.ctStockDataTable();                    

                        dtStock.ImportRow(row);

                        DataTable dtNewStock = GetRawDataTable(dtStock);

                        //BL.AddOutStock(dtNewStock, row["Title"].ToString(), row["Author"].ToString(), row["Edition"].ToString(), float.Parse(row["PurchasePrice"].ToString()), int.Parse(row["OutCount"].ToString()));

                        #endregion

                        #region [Construct Issue Table]

                        BLSSchema.ctIssueDataTable dtCustIssues = new BLSSchema.ctIssueDataTable();                        

                        BLSSchema.ctIssueRow CustIssuerow = dtCustIssues.NewctIssueRow();                        

                        CustIssuerow.CustomerID = _intCustomerId.ToString();

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

                        CustIssuerow.Returndate = (Program.MainObj.GetReturnDate(cmbMonth.SelectedIndex)).ToString("yyyy-MM-dd").Substring(0, 10);

                        CustIssuerow.EarlyIssue = true;

                        dtCustIssues.Rows.Add(CustIssuerow);

                        DataTable dtCustIssuedBooks = GetRawDataTable(dtCustIssues);                       

                       //BL.AddIssue(dtCustIssuedBooks, _strCustomerId.ToString(), row["Title"].ToString(), row["Author"].ToString(), row["Edition"].ToString(),
                         // float.Parse(row["OriginalPrice"].ToString()), DateTime.Now);

                        #endregion                       

                        #region [Update Customer details and Perform Transaction]

                        /**********************************************************************************
                        * Modified By : Shankar
                        * Changed int CustomerID to string CustomerID
                        **********************************************************************************/

                        BL.PerformEarlyIssueProcess(_intCustomerId.ToString(), int.Parse(row["OutCount"].ToString()), DateTime.Now,
                           float.Parse(txtAdvance.Text), float.Parse(txtBalanceAmount.Text),
                           (_strMemberShipType == "N")?(float.Parse(row["OriginalPrice"].ToString()) * float.Parse(row["OutCount"].ToString())): -1, 
                             dtNewStock, dtCustIssuedBooks);
                        #endregion

                    }

                    MessageBox.Show("Records added successfully", "Done");

                    Close();                   

                }
                else
                {
                    MessageBox.Show("Registration Complete. No book(s) records added.", "Done");
                    Close();
                }
            }
            catch (Exception ex)
            {
                //log exception
                Utility.WriteToFile(ex, "Error occured while adding book details");

                MessageBox.Show("Error occured while adding book details.Error : " + ex.ToString(),"Error");
            }
        }

        private bool GetCurrentAmount(string strCustomerID)
        {
            BusinessLogic BL = new BusinessLogic();
            float fltTotalAmount = 0;
            foreach (BLSSchema.ctStockRow row in _dtStock)
            {
                float CurrentRowBookCount = float.Parse(row["OutCount"].ToString());
                fltTotalAmount += (CurrentRowBookCount * float.Parse(row["OriginalPrice"].ToString()));
                
            }
            _fltCurrentBookAmount = fltTotalAmount;

            float[] fl = BL.GetLimit(strCustomerID);
            float fltMaxLimit = fl[0];
            float fltLimitUsed = fl[1];

            if ((fltLimitUsed + fltTotalAmount) > fltMaxLimit)
            {
                MessageBox.Show("Cannot Issue the Book.It exceeds customer's deposit limit.\nMaxLimit : Rs "
                    + fltMaxLimit + "\nLimit Used : Rs " + fltLimitUsed + "\nLimit After Issuing Books : Rs" + (fltLimitUsed + fltTotalAmount), "Limit Exceeded");
                return false;
            }
            else
            {
                return true;
            }

        }

        /// <summary>
        /// Constructs raw data table from a typed or untyped table
        /// </summary>
        /// <param name="dtTable"></param>
        /// <returns></returns>
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

        private void dgvStudentBooks_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex == dgvStudentBooks.ColumnCount - 1)
            {
                _dtStock.Rows[e.RowIndex].Delete();               
                
            }
        }

        private void frmStudentRegister2_Activated(object sender, EventArgs e)
        {
            this.Text = "Edit Books Borrowed[ M-Number : " + _intCustomerId + " ]";

        }
        
    }
}
