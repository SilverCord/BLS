using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using LibraryDesign_frontEndUI.Library;

namespace LibraryDesign_frontEndUI
{
    public partial class frmBuy : Form
    {
        LibMain _parentReference = null;

        public frmBuy()
        {
            InitializeComponent();
        }

        public frmBuy(LibMain RefParent)
        {
            InitializeComponent();

            _parentReference = RefParent;
        }

        private void btnSearchStock_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtKeyWord.Text) != true)
            {
                try
                {
                    frmSellStockSearch frmSellSrch = new frmSellStockSearch(txtKeyWord.Text, this);
                    //If Grid is empty disply 'NOthing to disply' and close. this form..- Done inside frmSellStockSearch
                    //frmSellSrch.ShowDialog();
                }
                catch(Exception ex)
                {
                    //log exception
                    Utility.WriteToFile(ex, "Error while retrieving stock records from DataBase.");

                    MessageBox.Show("Error while retrieving records from DataBase.", "Error");
                }
            }
            else
            {
                MessageBox.Show("Please enter the keyword to search", "Error");
            }
        }

        private void frmBuy_Load(object sender, EventArgs e)
        {
            // btnBuy.Enabled = false;
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            BusinessLogic BL = new BusinessLogic();

            try
            {
                //if (ValidateFields())
                //{

                //    Guid id = Guid.NewGuid();

                //    float flttotalAmount = 0;

                //    float fltDiscountPrice = (float.Parse(txtPrice.Text) * int.Parse(txtDiscount.Text)) / 100;

                //    fltDiscountPrice = float.Parse(txtPrice.Text) - fltDiscountPrice;

                //    BLSSchema.ctTransactionHistoryDataTable dtTransactionHistory = new BLSSchema.ctTransactionHistoryDataTable();

                //    BLSSchema.ctTransactionHistoryRow row = dtTransactionHistory.NewctTransactionHistoryRow();

                //    row.HistoryUID = id.ToString();

                //    row.Date = DateTime.Now.ToString();

                //    row.CustomerID = null;
                    
                //    flttotalAmount = int.Parse(txtCount.Text) * fltDiscountPrice;

                //    row.AmountIn = "0";

                //    row.AmountOut = flttotalAmount.ToString();

                //    row.RecieptNumber = _parentReference.GetReceiptNumber();

                //    dtTransactionHistory.Rows.Add(row);

                //    DataTable dtNewTransHistry = GetRawDataTable(dtTransactionHistory);

                //    if (BL.AddHistory(dtNewTransHistry, id))//If transactionhistory is successfully updated.
                //    {
                //        try
                //        {
                //            BLSSchema.ctStockDataTable dtStock = new BLSSchema.ctStockDataTable();

                //            BLSSchema.ctStockRow row1 = dtStock.NewctStockRow();

                //            row1.ISBN = txtISBN.Text;
                //            row1.Title = txtTitle.Text;
                //            row1.Author = txtAuthor.Text;
                //            row1.Edition = txtEdition.Text;
                //            row1.Publisher = txtPublisher.Text;
                //            row1.Year = cmbYear.SelectedItem.ToString();
                //            row1.Count = int.Parse(txtCount.Text);
                //            row1.OriginalPrice = txtPrice.Text;
                //            row1.Discount = txtDiscount.Text;
                //            row1.PurchasePrice = fltDiscountPrice.ToString();
                //            row1.LastUpdated = DateTime.UtcNow.ToString();
                //            if (cmbPriceChangable.SelectedIndex == 0)
                //            {
                //                row1.PriceChangable = "1";
                //            }
                //            else
                //            {
                //                row1.PriceChangable = "0";
                //            }

                //            dtStock.Rows.Add(row1);

                //            DataTable dtNewStock = GetRawDataTable(dtStock);

                //            BL.AddStock(dtNewStock, row1.Title,row1.Author,row1.Edition,fltDiscountPrice, int.Parse(txtCount.Text));

                //        }
                //        catch (Exception)
                //        {
                //            //Write it to file.So that there is no mismatch in existing stock and DB stock.
                //            throw;
                //        }
                //        BL.InsertReceipt(row.RecieptNumber, "");
                //        MessageBox.Show("Buying process completed.", "Done");

                //    }
                //}
            }
            catch (Exception ex)
            {
                //log exception
                Utility.WriteToFile(ex, "Error occured in buying process.");

                MessageBox.Show(ex.ToString(), "Error occured while buying process.");
            }
        }

        private bool ValidateFields()
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtISBN.Text))
                {
                    MessageBox.Show("ISBN is Empty", "Error");
                    lblISBN.ForeColor = System.Drawing.Color.Red;
                    return false;
                }
                lblISBN.ForeColor = System.Drawing.Color.Lime;


                if (string.IsNullOrWhiteSpace(txtTitle.Text))
                {
                    MessageBox.Show("Book Title is Empty", "Error");
                    lblTitle.ForeColor = System.Drawing.Color.Red;
                    return false;
                }
                lblTitle.ForeColor = System.Drawing.Color.Lime;

                if (string.IsNullOrWhiteSpace(txtAuthor.Text))
                {
                    MessageBox.Show("Author field is Empty", "Error");
                    lblAuthor.ForeColor = System.Drawing.Color.Red;
                    return false;
                }
                lblAuthor.ForeColor = System.Drawing.Color.Lime;

                if (string.IsNullOrWhiteSpace(txtEdition.Text))
                {
                    MessageBox.Show("Edition field is Empty", "Error");
                    lblEdition.ForeColor = System.Drawing.Color.Red;
                    return false;
                }
                lblEdition.ForeColor = System.Drawing.Color.Lime;

                if (string.IsNullOrWhiteSpace(txtPublisher.Text))
                {
                    MessageBox.Show("Publisher field is Empty", "Error");
                    lblPublisher.ForeColor = System.Drawing.Color.Red;
                    return false;
                }
                lblPublisher.ForeColor = System.Drawing.Color.Lime;

                if (cmbYear.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select year of publication", "Error");
                    return false;
                }


                if (string.IsNullOrWhiteSpace(txtCount.Text))
                {
                    txtCount.Text = "1";
                }


                if (string.IsNullOrWhiteSpace(txtPrice.Text))
                {
                    MessageBox.Show("Price field is Empty", "Error");
                    lblPrice.ForeColor = System.Drawing.Color.Red;
                    return false;
                }
                lblPrice.ForeColor = System.Drawing.Color.Lime;


                if (string.IsNullOrWhiteSpace(txtDiscount.Text))
                {
                    txtDiscount.Text = "0";
                }

                if (string.IsNullOrWhiteSpace(txtAdvance.Text))
                {
                    txtAdvance.Text = "0";
                }
                if (string.IsNullOrWhiteSpace(txtBalance.Text))
                {
                    txtBalance.Text = "0";
                }
                if (cmbPriceChangable.SelectedIndex == -1)
                {
                    cmbPriceChangable.SelectedIndex = 0;
                }


                return true;


            }
            catch(Exception ex)
            {
                //log exception
                Utility.WriteToFile(ex);

                return false;
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Cancelling may cause the form to close.\n Data entered may be lost..Are you sure?", "Cancel Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                _parentReference.btnBuy.Enabled = true;
                this.Close();
            }
        }


        #region [KeyPress]

        private void txtISBN_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char pressedKey = e.KeyChar;
            if (_parentReference.txtISBN_Validation(pressedKey))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }

        private void txtTitle_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char pressedKey = e.KeyChar;
            if (_parentReference.Number_Validation(pressedKey))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }

        private void txtAuthor_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char pressedKey = e.KeyChar;
            if (NameChecking(pressedKey))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }

        }

        private void txtEdition_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char pressedKey = e.KeyChar;
            if (NameChecking(pressedKey))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }

        private void txtPublisher_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char pressedKey = e.KeyChar;
            if (NameChecking(pressedKey))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }

        private void txtAdvance_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char pressedKey = e.KeyChar;
            if (_parentReference.Amount_Validation(pressedKey))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }

        private void txtCount_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char pressedKey = e.KeyChar;
            if (_parentReference.Number_Validation(pressedKey))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char pressedKey = e.KeyChar;
            if (_parentReference.Amount_Validation(pressedKey))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }

        private void txtBalance_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char pressedKey = e.KeyChar;
            if (_parentReference.Amount_Validation(pressedKey))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }

        public bool NameChecking(Char pressedKey)
        {
            if (_parentReference.Name_Validation(pressedKey))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        # endregion

        private void frmBuy_FormClosing(object sender, FormClosingEventArgs e)
        {
            _parentReference.btnBuy.Enabled = true;
        }



    }
}
