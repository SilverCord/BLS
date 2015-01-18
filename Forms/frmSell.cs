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
    public partial class frmSell : Form
    {
        LibMain _frmMainRef = null;

        public frmSell()
        {
            InitializeComponent();
            
        }

        public frmSell(LibMain frmMainRef)
        {
            InitializeComponent();
            _frmMainRef = frmMainRef;
        }
       
        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Cancelling may cause the form to close.\n Data entered may be lost..Are you sure?", "Cancel Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                _frmMainRef.btnSell.Enabled = true;
                this.Close();
            }
        }

        private void frmSell_Load(object sender, EventArgs e)
        {
            btnSell.Enabled = false;
        }

        private void btnSearchStock_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtKeyWord.Text) != true)
            {
                frmSellStockSearch frmSellSrch = new frmSellStockSearch(txtKeyWord.Text, this);
                //frmSellSrch.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please enter the keyword to search", "Error");
            }
        }

        private void btnSell_Click(object sender, EventArgs e)
        {
            //1.We are validating fields.(if few fields like advance,count,balance field are empty we are setting it to default values)
            //2.Update the transaction to transaction History.
            //3.Update the stock.to reflect the sold changes.
            
            try
            {
                //if (ValidateFields())
                //{
                //    BusinessLogic BL = new BusinessLogic();

                //    //Consturcting TransactionHistory table
                //    Guid id = Guid.NewGuid();

                //    float flttotalAmount = 0;

                //    BLSSchema.ctTransactionHistoryDataTable dtTransactionHistory = new BLSSchema.ctTransactionHistoryDataTable();

                //    BLSSchema.ctTransactionHistoryRow row = dtTransactionHistory.NewctTransactionHistoryRow();

                //    row.HistoryUID = id.ToString();

                //    row.IssueDate = DateTime.Now.ToString();

                //    row.CustomerID = "None";                    

                //    flttotalAmount = int.Parse(txtCount.Text) * float.Parse(txtSellingPrice.Text);

                //    row.AmountIn = flttotalAmount.ToString();

                //    row.AmountOut = "0";             
                                       
                //    row.RecieptNumber = GetReceiptNumber();

                //    dtTransactionHistory.Rows.Add(row);

                //    DataTable dtNewTransHistry = GetRawDataTable(dtTransactionHistory);

                //    if (BL.AddHistory(dtNewTransHistry, id))//If transactionhistory is successfully updated.
                //    {
                //        try
                //        {
                //            //Update the Stock.
                //           // BL.UpdateStock("Issue", txtISBN.Text, int.Parse(txtCount.Text));
                //        }
                //        catch (Exception)
                //        {
                //            //Write it to file.So that there is no mismatch in existing stock and DB stock.
                //            throw;
                //        }

                //        BL.InsertReceipt(row.RecieptNumber, "");
                //        MessageBox.Show("Selling process completed.", "Done");

                //    }
                //}
                

            }
            catch (Exception)
            {

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


        private bool ValidateFields()
        {          
            if (string.IsNullOrWhiteSpace(txtISBN.Text))
            {
                MessageBox.Show("ISBN is Empty", "Error");
                lblISBN.ForeColor = System.Drawing.Color.Red;
                return false;
            }
            lblISBN.ForeColor = System.Drawing.Color.Lime;
            
            if (string.IsNullOrWhiteSpace(txtPrice.Text))
            {
                MessageBox.Show("Price field is Empty", "Error");
                lblActualPrice.ForeColor = System.Drawing.Color.Red;
                return false;
            }
            lblActualPrice.ForeColor = System.Drawing.Color.Lime;

            if (string.IsNullOrWhiteSpace(txtCount.Text) == true)
            {
                txtCount.Text = "1";
            }
            if (string.IsNullOrWhiteSpace(txtAdvance.Text) == true)
            {
                txtAdvance.Text = "0";
            }
            if (string.IsNullOrWhiteSpace(txtBalance.Text) == true)
            {
                txtBalance.Text = "0";
            }

            if (string.IsNullOrWhiteSpace(txtSellingPrice.Text))
            {
                MessageBox.Show("Selling price field is Empty", "Error");
                lblSellingPrice.ForeColor = System.Drawing.Color.Red;
                return false;
            }
            lblSellingPrice.ForeColor = System.Drawing.Color.Lime;

            return true;

        }

        private void txtISBN_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char pressedKey = e.KeyChar;
            if (Char.IsNumber(pressedKey) || (int)pressedKey == 8 || (int)pressedKey == 45)
            {
                // Allow input.
                e.Handled = false;
            }
            else
                // Stop the character from being entered into the control since not a letter, nor punctuation, nor a space.
                e.Handled = true;
        }


        private void Amount_Validation(object sender, KeyPressEventArgs e)
        {
            Char pressedKey = e.KeyChar;
            if (Char.IsNumber(pressedKey) || (int)pressedKey == 8 || pressedKey == '.')
            {
                // Allow input.
                e.Handled = false;
            }
            else
            {
                // Stop the character from being entered into the control since not a letter, nor punctuation, nor a space.
                e.Handled = true;
            }
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

        private void Name_Validation(object sender, KeyPressEventArgs e)
        {
            Char pressedKey = e.KeyChar;
            if (Char.IsLetter(pressedKey) || Char.IsNumber(pressedKey) || Char.IsWhiteSpace(pressedKey) || (int)pressedKey == 8)
            {
                // Allow input.
                e.Handled = false;
            }
            else
                // Stop the character from being entered into the control since not a letter, nor punctuation, nor a space.
                e.Handled = true;
        }

        internal string GetReceiptNumber()
        {
            BusinessLogic bl = new BusinessLogic();

            string strLatestReceiptNumber = bl.GetReceiptNumber();

            return strLatestReceiptNumber;

        }

        private void frmSell_FormClosing(object sender, FormClosingEventArgs e)
        {
            _frmMainRef.btnSell.Enabled = true;
        }
        
    }
}
