using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LibraryDesign_frontEndUI.Forms;
using LibraryDesign_frontEndUI.Library;

namespace LibraryDesign_frontEndUI
{
    public partial class frmCustomerSearch1 : Form
    {
        #region [Variables]
        int _intRowIndex = 0;
        int _intColumnIndex = 0;
        bool _blnPurposeEarlyIssue = false;
        frmIssueBooks _frmParentRef = null;
        frmAddStock _frmAddStockRef = null;
        frmPlaceOrder _frmPlaceOrderRef = null;      

        string _strEdition = string.Empty;
        string _strTitle = string.Empty;
        string _strPublisher = string.Empty;
        string _strAuthor = string.Empty;
        string _strYear = string.Empty;
        internal BLSSchema _BSchema = new BLSSchema();
        string _strColumns = "[ISBN],[Title],[Author],[Year],[Edition],[Publisher],[Count],[OriginalPrice],[Discount],[PurchasePrice],[PriceChangable],[OutCount]";
        
        #endregion

        #region [Constructors]
        public frmCustomerSearch1()
        {
            InitializeComponent();
            _frmParentRef = null;
            btnEditStock.Visible = true;
            btnDeleteStock.Visible = true;
        }

        public frmCustomerSearch1(frmIssueBooks frmRef)
        {
            InitializeComponent();          
            _frmParentRef = frmRef;            
        }

        public frmCustomerSearch1(frmPlaceOrder frmRef)
        {
            InitializeComponent();
            _frmPlaceOrderRef = frmRef;
        }

        public frmCustomerSearch1(frmAddStock frmAddStockref,bool EarlyIssue)
        {
            InitializeComponent();
            _frmAddStockRef = frmAddStockref;
            _blnPurposeEarlyIssue = EarlyIssue;
        }
        #endregion


        private void btnSearch_Click(object sender, EventArgs e)
        {
            _BSchema.ctStockSearch.Clear();
            SearchButtonClick();
        }
        
        internal void SearchButtonClick(string strQuery = null)
        {
            try
            {                
                BusinessLogic BLgc = new BusinessLogic();

                if (strQuery == null)
                {
                    if (CheckForEmpty() == false)
                    {
                        strQuery = ConstructQuery(true);

                    }
                    else
                    {
                        strQuery = DefaultQuery();
                    }
                }

                dgvStockSearchResult.DataSource = null;
                _BSchema.ctStockSearch.Clear();
                BLgc.GetStock(_BSchema, strQuery);
                dgvStockSearchResult.DataSource = _BSchema.ctStockSearch;
                if (_BSchema.ctStockSearch.Count > 0)
                {
                    btnEditStock.Enabled = true;
                    btnDeleteStock.Enabled = true;
                }
                else
                {
                    btnEditStock.Enabled = false;
                    btnDeleteStock.Enabled = false;
                }
                if (_frmParentRef == null && _frmPlaceOrderRef == null && _frmAddStockRef == null)
                {
                    dgvStockSearchResult.Columns[dgvStockSearchResult.ColumnCount - 1].Visible = false;
                }
                else
                {
                    dgvStockSearchResult.Columns[dgvStockSearchResult.ColumnCount - 1].Visible = true;
                }
            }
            catch(Exception ex)
            {
                //log exception
                Utility.WriteToFile(ex, "Error occured while retrieving record");
                
                MessageBox.Show("Error occured while retrieving records.Please try after some time", "Error");
            }
        }

        private string DefaultQuery()
        {
            if (string.IsNullOrWhiteSpace(txtRecordCount.Text) != true)
            {
                string strQ = "SELECT TOP(" + txtRecordCount.Text + ") " + _strColumns + " FROM TblStock ";
                return (_blnPurposeEarlyIssue) ? strQ : strQ + "WHERE[Count] > 0";
            }
            else
            {
                string strQ = "SELECT TOP(30) " + _strColumns + " FROM TblStock ";
                return (_blnPurposeEarlyIssue) ? strQ : strQ + "WHERE[Count] > 0";
            }
        }

        private string ConstructQuery(bool blnIsEmpty)
        {
            string strQuery = string.Empty;
            string strBaseQuery = string.Empty;
            string strCondition = string.Empty;
            bool blnConditionAdded = false;

            strBaseQuery = DefaultQuery();                     

            if (_strEdition != string.Empty && chkMatchExact.Checked)
            {
                strCondition += " Edition  =  '" + _strEdition + "'";
                 blnConditionAdded = true;               
            }
            else if (_strEdition != string.Empty && !chkMatchExact.Checked)
            {
                if (blnConditionAdded)
                {
                    strCondition += " AND Edition  LIKE  '" + _strEdition + "%'";
                }
                else
                {
                    strCondition += "Edition  LIKE  '" + _strEdition + "%'";
                    blnConditionAdded = true;
                }
                
            }            

            if (_strTitle != string.Empty && chkMatchExact.Checked)
            {
                if (blnConditionAdded)
                {
                    strCondition += " AND Title  =  '" + _strTitle + "'";
                }
                else
                {
                    strCondition += "Title  =  '" + _strTitle + "'";
                    blnConditionAdded = true;
                }
            }
            else if (_strTitle != string.Empty && !chkMatchExact.Checked)
            {
                if (blnConditionAdded)
                {
                    strCondition += " AND Title  LIKE  '" + _strTitle + "%'";
                }
                else
                {
                    strCondition += "Title  LIKE  '" + _strTitle + "%'";
                    blnConditionAdded = true;
                }
            }

            if (_strPublisher != string.Empty && chkMatchExact.Checked)
            {
                if (blnConditionAdded)
                {
                    strCondition += " AND Publisher  =  '" + _strPublisher + "'";
                }
                else
                {
                    strCondition += "Publisher  =  '" + _strPublisher + "'";
                    blnConditionAdded = true;
                }
            }
            else if (_strPublisher != string.Empty && !chkMatchExact.Checked)
            {
                if (blnConditionAdded)
                {
                    strCondition += " AND Publisher  LIKE  '" + _strPublisher + "%'";
                }
                else
                {
                    strCondition += "Publisher  LIKE  '" + _strPublisher + "%'";
                    blnConditionAdded = true;
                }
            }
                      
            if (_strAuthor != string.Empty && chkMatchExact.Checked)
            {
                if (blnConditionAdded)
                {
                    strCondition += " AND Author  =  '" + _strAuthor + "'";
                }
                else
                {
                    strCondition += "Author  =  '" + _strAuthor + "'";
                    blnConditionAdded = true;
                }

            }
            else if (_strAuthor != string.Empty && !chkMatchExact.Checked)
            {
                if (blnConditionAdded)
                {
                    strCondition += " AND [Author]  LIKE  '" + _strAuthor + "%'";
                }
                else
                {
                    strCondition += "[Author]  LIKE  '" + _strAuthor + "%'";
                    blnConditionAdded = true;
                }
            }           

           
            if (string.IsNullOrEmpty(strCondition)== false)
            {
                strQuery = (_blnPurposeEarlyIssue)?strBaseQuery + " WHERE " + strCondition :strBaseQuery + " AND " + strCondition;
             }

            return strQuery;


        }

        public bool CheckForEmpty()
        {
            bool blnEmpty = true;            

            _strEdition = string.Empty;
            if (!string.IsNullOrWhiteSpace(txtEdition.Text))
            {
                _strEdition = txtEdition.Text;
                blnEmpty = false;
            }

            _strTitle = string.Empty;
            if (!string.IsNullOrWhiteSpace(txtTitle.Text))
            {
                _strTitle = txtTitle.Text;
                blnEmpty = false;
            }

            _strPublisher = string.Empty;
            if (!string.IsNullOrWhiteSpace(txtPublisher.Text))
            {
                _strPublisher = txtPublisher.Text;
                blnEmpty = false;
            }

            _strAuthor = string.Empty;
            if (!string.IsNullOrWhiteSpace(txtAuthor.Text))
            {
                _strAuthor = txtAuthor.Text;
                blnEmpty = false;
            }
            
            return blnEmpty;

        }

        private void dgvStockSearchResult_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using (SolidBrush b = new SolidBrush(dgvStockSearchResult.RowHeadersDefaultCellStyle.ForeColor))
            {
                e.Graphics.DrawString((e.RowIndex + 1).ToString(System.Globalization.CultureInfo.CurrentUICulture), e.InheritedRowStyle.Font, b, e.RowBounds.Location.X + 7, e.RowBounds.Location.Y + 4);
            }
        }

        private void dgvStockSearchResult_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {          
            if (e.RowIndex != -1)
            {
                _intRowIndex = e.RowIndex;
                _intColumnIndex = e.ColumnIndex;

                try
                {
                    if (e.ColumnIndex == dgvStockSearchResult.ColumnCount - 1 && _frmParentRef != null)
                    {
                        //_frmParentRef.txtSelectedISBN.Text = dgvStockSearchResult.Rows[e.RowIndex].Cells["ISBN"].Value.ToString();                        
                        _frmParentRef.txtSelectedTitle.Text = dgvStockSearchResult.Rows[e.RowIndex].Cells["Title"].Value.ToString();
                        _frmParentRef.txtSelectedPublisher.Text = dgvStockSearchResult.Rows[e.RowIndex].Cells["Publisher"].Value.ToString();
                        _frmParentRef.txtSelectedAuthor.Text = dgvStockSearchResult.Rows[e.RowIndex].Cells["Author"].Value.ToString();
                        _frmParentRef.txtSelectedEdition.Text = dgvStockSearchResult.Rows[e.RowIndex].Cells["Edition"].Value.ToString();
                        _frmParentRef.txtSelectedYear.Text = dgvStockSearchResult.Rows[e.RowIndex].Cells["Year"].Value.ToString();
                        _frmParentRef.txtBookPrice.Text = dgvStockSearchResult.Rows[e.RowIndex].Cells["OriginalPrice"].Value.ToString();
                        _frmParentRef.txtPurchasedPrice.Text = dgvStockSearchResult.Rows[e.RowIndex].Cells["PurchasePrice"].Value.ToString();
                        _frmParentRef._intMaxAvailableCount = int.Parse(dgvStockSearchResult.Rows[e.RowIndex].Cells["Count"].Value.ToString());
                        
                        Close();
                       
                    }
                    else if(e.ColumnIndex == dgvStockSearchResult.ColumnCount - 1 && _frmAddStockRef!= null)
                    {
                        //_frmAddStockRef.txtISBN.Text = dgvStockSearchResult.Rows[e.RowIndex].Cells["ISBN"].Value.ToString();
                        _frmAddStockRef.txtTitle.Text = dgvStockSearchResult.Rows[e.RowIndex].Cells["Title"].Value.ToString();
                        _frmAddStockRef.txtPublisher.Text = dgvStockSearchResult.Rows[e.RowIndex].Cells["Publisher"].Value.ToString();
                        _frmAddStockRef.txtAuthor.Text = dgvStockSearchResult.Rows[e.RowIndex].Cells["Author"].Value.ToString();
                        _frmAddStockRef.txtEdition.Text = dgvStockSearchResult.Rows[e.RowIndex].Cells["Edition"].Value.ToString();
                        _frmAddStockRef.cmbYear.Text = dgvStockSearchResult.Rows[e.RowIndex].Cells["Year"].Value.ToString();
                        _frmAddStockRef.txtPrice.Text = dgvStockSearchResult.Rows[e.RowIndex].Cells["OriginalPrice"].Value.ToString();
                        _frmAddStockRef.txtDiscount.Text = dgvStockSearchResult.Rows[e.RowIndex].Cells["Discount"].Value.ToString();
                        Close();
                    }
                    else if (e.ColumnIndex == dgvStockSearchResult.ColumnCount - 1 && _frmPlaceOrderRef != null)
                    {
                        _frmPlaceOrderRef.txtISBN.Text = dgvStockSearchResult.Rows[e.RowIndex].Cells["ISBN"].Value.ToString();                        
                        Close();

                    }
                   
                }
                catch (Exception ex)
                {
                    //log exception
                    Utility.WriteToFile(ex, "Error occured while retrieving record");

                    MessageBox.Show("Could not able to retrieve records.Please try after some time", "Error");
                }


            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
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
                // Stop the character from being entered into the control since not a letter, nor punctuation, nor a space.
                e.Handled = true;
        }

        private void frmCustomerSearch1_Activated(object sender, EventArgs e)
        {
            //if (_blnPurposeEarlyIssue)
            //{
            //    _BSchema.ctStockSearch.Clear();
            //    SearchButtonClick("SELECT TOP(20) " + _strColumns + " FROM TblStock ");
            //}
            //else
            //{
            //    _BSchema.ctStockSearch.Clear();
            //    SearchButtonClick("SELECT TOP(20) " + _strColumns + " FROM TblStock WHERE [Count] > 0 ");
            //}
            SearchButtonClick();
        }

        private void frmCustomerSearch1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char pressedKey = e.KeyChar;
            if (pressedKey == '\r')
            {
                _BSchema.ctStockSearch.Clear();
                SearchButtonClick();
            }
        }

        private void btnEditStock_Click(object sender, EventArgs e)
        {
            try
            {
                string[] strStockElements = new string[12];
                strStockElements[0] = dgvStockSearchResult.Rows[_intRowIndex].Cells["ISBN"].Value.ToString();
                strStockElements[1] = dgvStockSearchResult.Rows[_intRowIndex].Cells["Title"].Value.ToString();
                strStockElements[2] = dgvStockSearchResult.Rows[_intRowIndex].Cells["Author"].Value.ToString();
                strStockElements[3] = dgvStockSearchResult.Rows[_intRowIndex].Cells["Edition"].Value.ToString();
                strStockElements[4] = dgvStockSearchResult.Rows[_intRowIndex].Cells["Publisher"].Value.ToString();
                strStockElements[5] = dgvStockSearchResult.Rows[_intRowIndex].Cells["Year"].Value.ToString();
                strStockElements[6] = dgvStockSearchResult.Rows[_intRowIndex].Cells["Count"].Value.ToString();
                strStockElements[7] = dgvStockSearchResult.Rows[_intRowIndex].Cells["OriginalPrice"].Value.ToString();
                strStockElements[8] = dgvStockSearchResult.Rows[_intRowIndex].Cells["Discount"].Value.ToString();
                strStockElements[9] = dgvStockSearchResult.Rows[_intRowIndex].Cells["PurchasePrice"].Value.ToString();
                strStockElements[10] = dgvStockSearchResult.Rows[_intRowIndex].Cells["PriceChangable"].Value.ToString();
                strStockElements[11] = dgvStockSearchResult.Rows[_intRowIndex].Cells["OutCount"].Value.ToString();

                frmEditStock frmEdtStock = new frmEditStock(strStockElements, this);
                frmEdtStock.Show();
            }
            catch (Exception ex)
            {
                //log exception
                Utility.WriteToFile(ex, "Error occured while retrieving stock record");

                MessageBox.Show("Error occured while retrieving stock record : " + ex.ToString() , "Error");
            }
        }

        private void btnDeleteStock_Click(object sender, EventArgs e)
        {
            try
            {
                if (_intRowIndex != -1)
                {
                    BusinessLogic BL = new BusinessLogic();

                    if (MessageBox.Show("The stock record " + dgvStockSearchResult.Rows[_intRowIndex].Cells["Title"].Value.ToString() + " will be deleted permanantely.\n Are you sure to delete this record?",
                        "Cancel Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        if (BL.Deletestock(dgvStockSearchResult.Rows[_intRowIndex].Cells["Title"].Value.ToString(), dgvStockSearchResult.Rows[_intRowIndex].Cells["Author"].Value.ToString(),
                            dgvStockSearchResult.Rows[_intRowIndex].Cells["Edition"].Value.ToString(), float.Parse(dgvStockSearchResult.Rows[_intRowIndex].Cells["PurchasePrice"].Value.ToString())))
                        {
                            MessageBox.Show("Record " + dgvStockSearchResult.Rows[_intRowIndex].Cells["Title"].Value.ToString() + " deleted successfully", "Done");
                           _BSchema.ctStockSearch.Clear();
                            SearchButtonClick();
                            _intRowIndex = _intRowIndex - 1;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                //log exception
                Utility.WriteToFile(ex, "Error occured while deleting stock record");

                MessageBox.Show("Error occured while deleting stock record : " + ex.ToString() , "Error");
            }
        }

        private void txtTitle_TextChanged(object sender, EventArgs e)
        {
            _BSchema.ctStockSearch.Clear();
            SearchButtonClick();
        }

        private void txtPublisher_TextChanged(object sender, EventArgs e)
        {
            _BSchema.ctStockSearch.Clear();
            SearchButtonClick();
        }

        private void txtEdition_TextChanged(object sender, EventArgs e)
        {
           _BSchema.ctStockSearch.Clear();
            SearchButtonClick();
        }

        private void txtAuthor_TextChanged(object sender, EventArgs e)
        {
            _BSchema.ctStockSearch.Clear();
            SearchButtonClick();
        }

        private void chkMatchExact_CheckedChanged(object sender, EventArgs e)
        {
            SearchButtonClick();
        }
        
    }
}