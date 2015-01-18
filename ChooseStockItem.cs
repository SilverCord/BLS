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
    public partial class frmChooseStockItem : Form
    {
        #region [Variables]
        int _intRowIndex = 0;
        int _intColumnIndex = 0;
        bool _blnPurposeEarlyIssue = false;
        frmMultiIssue _frmParentRef = null;
        internal string _strType = string.Empty;
        bool _blnRemoveFlag = false;

        string _strEdition = string.Empty;
        string _strTitle = string.Empty;
        string _strPublisher = string.Empty;
        string _strAuthor = string.Empty;
        string _strYear = string.Empty;

        internal float _MaxLimit = 0;
        internal float _UsedLimit = 0;
        internal float _CurrentLimit = 0;
        float _CurrentBookAmount = 0;

        internal BLSSchema _BSchema = new BLSSchema();
        BLSSchema.ctStockSearchDataTable _ctSelectedStockItems = new BLSSchema.ctStockSearchDataTable();

        string _strColumns = "[ISBN],[Title],[Author],[Year],[Edition],[Publisher],[Count],[OriginalPrice],[Discount],[PurchasePrice],[PriceChangable],[OutCount]";

        #endregion

        public frmChooseStockItem(frmMultiIssue frmRef)
        {
            InitializeComponent();
            _frmParentRef = frmRef;
            _BSchema.ctStockSearch.Clear();
            //_BSchema.ctStockSearch.TableNewRow += ValidateRows();
            _BSchema.ctStockSearch.RowChanged += new DataRowChangeEventHandler(DataTable_RowChanged);
            SearchButtonClick();
        }

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
            }
            catch (Exception ex)
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


            if (string.IsNullOrEmpty(strCondition) == false)
            {
                strQuery = (_blnPurposeEarlyIssue) ? strBaseQuery + " WHERE " + strCondition : strBaseQuery + " AND " + strCondition;
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

        private void dgvStockSearchResult_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                _intRowIndex = e.RowIndex;
                _intColumnIndex = e.ColumnIndex;

                try
                {
                    if (dgvStockSearchResult.Columns[e.ColumnIndex].HeaderText == "Select" && _frmParentRef != null)
                    {
                        BLSSchema.ctStockSearchDataTable ctStockSearch = ((BLSSchema.ctStockSearchDataTable)(dgvStockSearchResult.DataSource));
                        BLSSchema.ctStockSearchRow stockSearchRow = _frmParentRef._dtSelectedStock.NewctStockSearchRow();
                        BLSSchema.ctStockSearchDataTable ctTemp = (BLSSchema.ctStockSearchDataTable)ctStockSearch.Copy();
                        stockSearchRow = ctTemp[e.RowIndex];
                        bool blnAlreadySelected = false;
                        //this code is for some sort of calculations
                        blnAlreadySelected = CheckForDuplicate(ctStockSearch[e.RowIndex]);
                        if (_strType == "R")
                        {
                            stockSearchRow.Count = 1;
                            _frmParentRef._dtSelectedStock.ImportRow(stockSearchRow);
                            _CurrentBookAmount += float.Parse(ctStockSearch[e.RowIndex].OriginalPrice.ToString());
                            if (int.Parse(ctStockSearch[e.RowIndex].Count.ToString()) > 1)
                            {
                                //decrement the count
                                _BSchema.ctStockSearch[e.RowIndex].Count = int.Parse(ctStockSearch[e.RowIndex].Count.ToString()) - 1;
                                _BSchema.ctStockSearch.AcceptChanges();
                                dgvStockSearchResult.DataSource = _BSchema.ctStockSearch;
                                dgvStockSearchResult.Refresh();
                            }
                            else
                            {
                                //Delete the row
                                _BSchema.ctStockSearch.Rows.RemoveAt(e.RowIndex);                               
                                dgvStockSearchResult.DataSource = _BSchema.ctStockSearch;
                                dgvStockSearchResult.Refresh();
                            }
                            dgvSelectedBooks.DataSource = _frmParentRef._dtSelectedStock;
                        }
                        else if (_strType == "N")
                        {
                            if (CheckForDuplicate(ctStockSearch[e.RowIndex]))
                            {
                                MessageBox.Show("This book is not allowed for current type", "Duplicate selection");
                                return;
                            }
                            if (CheckLimits(float.Parse(ctStockSearch[e.RowIndex].OriginalPrice)))
                            {
                                return;
                            }
                            //everything OK then add;  
                            stockSearchRow.Count = 1;
                            _frmParentRef._dtSelectedStock.ImportRow(stockSearchRow);
                            _BSchema.ctStockSearch.RemovectStockSearchRow(ctStockSearch[e.RowIndex]);
                            _CurrentLimit = _CurrentLimit + float.Parse(stockSearchRow.OriginalPrice);
                            dgvSelectedBooks.DataSource = _frmParentRef._dtSelectedStock;
                            dgvStockSearchResult.DataSource = _BSchema.ctStockSearch;
                            dgvStockSearchResult.Refresh();
                        }
                    }
                }
                catch (Exception ex)
                {
                    //log exception
                    Utility.WriteToFile(ex, "Error occured while retrieving record");

                    MessageBox.Show("Could not  retrieve records.Please try after some time", "Error");
                }
            }
        }

        private bool CheckLimits(float fltBookPrice)
        {
            float fltEstimatedLimit = 0;
            fltEstimatedLimit = _UsedLimit + _CurrentLimit + fltBookPrice;
            if (fltEstimatedLimit > _MaxLimit)
            {
                MessageBox.Show("Cannot issue this book.It exceeds customers Max Limit\n" + "MaxLimit :" + _MaxLimit.ToString()
                    + "\nLimit after adding this book :" + fltEstimatedLimit.ToString(), "Error");
                return true;

            }
            return false;
        }


        private bool CheckForDuplicate(BLSSchema.ctStockSearchRow stockSearchRow)
        {
            foreach (DataRow dr in _ctSelectedStockItems.Rows)
            {
                var array1 = stockSearchRow.ItemArray;
                var array2 = dr.ItemArray;

                if (array1.SequenceEqual(array2))
                {
                    return true;
                }
            }
            string strFilterCondition = "Title = '" + stockSearchRow.Title
                + "' AND Author ='" + stockSearchRow.Author + "' AND Edition ='" + stockSearchRow.Edition
                + "' AND Publisher ='" + stockSearchRow.Publisher + "' AND BookPrice ='"
                + stockSearchRow.OriginalPrice + "'";
            DataRow[] dr1 = _frmParentRef._dtAlreadyIssuedBooks.Select(strFilterCondition);
            if (dr1 != null && dr1.Length > 0)
            {
                return true;
            }

            return false;
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

        private void btnSelectionDone_Click(object sender, EventArgs e)
        {
            _frmParentRef.RefreshGrid();
            if (_strType == "N")
            {
                float TotUsedLimit = _UsedLimit + _CurrentLimit;
                _frmParentRef.lblRecieptNumber.Text = TotUsedLimit.ToString();
            }
            Close();
        }

        private void btnSelectionDone_Click_1(object sender, EventArgs e)
        {
            _frmParentRef.RefreshGrid();
            if (_strType == "N")
            {
                float TotUsedLimit = _UsedLimit + _CurrentLimit;
                _frmParentRef.lblRecieptNumber.Text = TotUsedLimit.ToString();
            }
            else if (_strType == "R")
            {
                _frmParentRef._fltCurrentBookAmount = _CurrentBookAmount;
            }
            Close();
        }


        private void dgvStockSearchResult_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {

        }
        
        private void dgvStockSearchResult_RowPostPaint_1(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using (SolidBrush b = new SolidBrush(dgvStockSearchResult.RowHeadersDefaultCellStyle.ForeColor))
            {
                e.Graphics.DrawString((e.RowIndex + 1).ToString(System.Globalization.CultureInfo.CurrentUICulture), e.InheritedRowStyle.Font, b, e.RowBounds.Location.X + 7, e.RowBounds.Location.Y + 4);
            }
            // If the column is the Artist column, check the 
            // value.            
        }

        private void dgvStockSearchResult_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {

        }

        private void Table_NewRow(object sender, DataTableNewRowEventArgs e)
        {
            if (true)
            {
                string strTitle = e.Row["Title"].ToString();

                //string strTitle = _BSchema.ctStockSearch.Rows[e.RowIndex].Cells["Title"].Value.ToString();

                //string strAuthor = dgvStockSearchResult.Rows[e.RowIndex].Cells["Author"].Value.ToString();

                //string strEdition = dgvStockSearchResult.Rows[e.RowIndex].Cells["Edition"].Value.ToString();

                //string strPublisher = dgvStockSearchResult.Rows[e.RowIndex].Cells["Publisher"].Value.ToString();

                //float fltPrice = float.Parse(dgvStockSearchResult.Rows[e.RowIndex].Cells["OriginalPrice"].Value.ToString());

                //int intBookCount = int.Parse(dgvStockSearchResult.Rows[e.RowIndex].Cells["Count"].Value.ToString());


                //string strFilterCondition = "Title = '" + strTitle
                //+ "' AND Author ='" + strAuthor + "' AND Edition ='" + strEdition
                //+ "' AND Publisher ='" + strPublisher + "' AND OriginalPrice ='"
                //+ fltPrice.ToString() + "'";
                //DataRow[] dr1 = _frmParentRef._dtSelectedStock.Select(strFilterCondition);
                ////DataRow[] dr2 = _frmParentRef._dtAlreadyIssuedBooks.Select(strFilterCondition);
                //if (dr1 != null && dr1.Length > 0)
                //{
                //    //here we should handle multiple already added problem
                //    if (_strType == "R")
                //    {
                //        if (intBookCount > 1)
                //        {
                //            dgvStockSearchResult.Rows[e.RowIndex].Cells["Count"].Value = intBookCount - 1;
                //        }
                //        else if (intBookCount == 1)
                //        {
                //            BLSSchema.ctStockSearchRow stockSearchRow = _BSchema.ctStockSearch.NewctStockSearchRow();
                //            _BSchema.ctStockSearch.RemovectStockSearchRow(stockSearchRow);
                //        }
                //    }

                //}
            }
        }

        protected void DataTable_RowChanged(object sender, DataRowChangeEventArgs e)
        {
            if (e.Action == DataRowAction.Add && !_blnRemoveFlag)
            {
                string strTitle = e.Row["Title"].ToString();

                //string strTitle = _BSchema.ctStockSearch.Rows[e.RowIndex].Cells["Title"].Value.ToString();

                string strAuthor = e.Row["Author"].ToString();

                string strEdition = e.Row["Edition"].ToString();

                string strPublisher = e.Row["Publisher"].ToString();

                float fltPrice = float.Parse(e.Row["OriginalPrice"].ToString());

                int intBookCount = int.Parse(e.Row["Count"].ToString());


                string strFilterCondition = "Title = '" + strTitle
                + "' AND Author ='" + strAuthor + "' AND Edition ='" + strEdition
                + "' AND Publisher ='" + strPublisher + "' AND OriginalPrice ='"
                + fltPrice.ToString() + "'";
                DataRow[] dr1 = _frmParentRef._dtSelectedStock.Select(strFilterCondition);
                //DataRow[] dr2 = _frmParentRef._dtAlreadyIssuedBooks.Select(strFilterCondition);
                if (dr1 != null && dr1.Length > 0)
                {
                    //here we should handle multiple already added problem
                    if (_strType == "R")
                    {
                        if (intBookCount > 1)
                        {
                            e.Row["Count"] = intBookCount - 1;
                        }
                        else if (intBookCount == 1)
                        {
                            BLSSchema.ctStockSearchRow stockSearchRow = _BSchema.ctStockSearch.NewctStockSearchRow();
                            stockSearchRow = (BLSSchema.ctStockSearchRow)e.Row;
                            _BSchema.ctStockSearch.RemovectStockSearchRow(stockSearchRow);
                        }
                    }

                }
            }
        }

        private void ValidateRows(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void dgvSelectedBooks_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                try
                {
                    if (dgvSelectedBooks.Columns[e.ColumnIndex].HeaderText == "Remove")
                    {
                        _blnRemoveFlag = true;

                        BLSSchema.ctStockSearchDataTable ctSelectedBooks = new BLSSchema.ctStockSearchDataTable();

                        string strTitle = dgvSelectedBooks.Rows[e.RowIndex].Cells["SelectedTitle"].Value.ToString();

                        string strAuthor = dgvSelectedBooks.Rows[e.RowIndex].Cells["SelectedAuthor"].Value.ToString();

                        string strEdition = dgvSelectedBooks.Rows[e.RowIndex].Cells["SelectedEdition"].Value.ToString();

                        string strPublisher = dgvSelectedBooks.Rows[e.RowIndex].Cells["SelectedPublisher"].Value.ToString();

                        float fltPrice = float.Parse(dgvSelectedBooks.Rows[e.RowIndex].Cells["SelectedOriginalPrice"].Value.ToString());

                        int intBookCount = int.Parse(dgvSelectedBooks.Rows[e.RowIndex].Cells["SelectedCount"].Value.ToString());


                        string strFilterCondition = "Title = '" + strTitle
                        + "' AND Author ='" + strAuthor + "' AND Edition ='" + strEdition
                        + "' AND Publisher ='" + strPublisher + "' AND OriginalPrice ='"
                        + fltPrice.ToString() + "'";

                        DataRow[] dr1 = _BSchema.ctStockSearch.Select(strFilterCondition);
                        if (dr1 != null && dr1.Length > 0)
                        {
                            int intIndex = _BSchema.ctStockSearch.Rows.IndexOf(dr1[0]);
                                _BSchema.ctStockSearch[intIndex].Count = int.Parse(_BSchema.ctStockSearch[intIndex].Count.ToString()) + 1;
                                _BSchema.ctStockSearch.AcceptChanges();
                                dgvSelectedBooks.Rows.RemoveAt(e.RowIndex);
                                _BSchema.ctStockSearch.AcceptChanges();
                                dgvStockSearchResult.DataSource = _BSchema.ctStockSearch;
                                dgvStockSearchResult.Refresh();
                                dgvSelectedBooks.Refresh();
                        }
                        else
                        {
                            //Add this row                           
                            ctSelectedBooks.Clear();                    
                            ctSelectedBooks = ((BLSSchema.ctStockSearchDataTable)(dgvSelectedBooks.DataSource));
                            _BSchema.ctStockSearch.ImportRow(ctSelectedBooks.Rows[e.RowIndex]);
                            dgvSelectedBooks.Rows.RemoveAt(e.RowIndex);
                            ctSelectedBooks.AcceptChanges();
                            dgvSelectedBooks.Refresh();
                            
                        }
                    }
                    _blnRemoveFlag = false;
                }
                catch (Exception ex)
                {
                    _blnRemoveFlag = false;
                }
            }

        }
    }
}
