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

namespace LibraryDesign_frontEndUI.Forms
{
    public partial class frmEditStock : Form
    {
        float _fltOriginalPurchasePrice = 0;
        float _fltCurrentPurchasedPrice = 0;

        frmCustomerSearch1 _frmparentRef = null;

        public frmEditStock(string[] strElements, frmCustomerSearch1 frmparentRef)
        {
            InitializeComponent();
            txtISBN.Text = strElements[0];
            txtTitle.Text = strElements[1];
            txtAuthor.Text = strElements[2];
            txtEdition.Text = strElements[3];
            txtPublisher.Text = strElements[4];
            txtYear.Text = strElements[5];
            txtCount.Text = strElements[6];
            txtPrice.Text = strElements[7];
            txtDiscount.Text = strElements[8];
            txtPurchasePrice.Text = strElements[9];
            _fltOriginalPurchasePrice = float.Parse(strElements[9]);
            cmbPriceChangable.SelectedIndex = (strElements[10] == "True") ? 0 : 1;
            txtOutCount.Text = strElements[11];
            _frmparentRef = frmparentRef;
            
        }

        private void Number_validation(object sender, KeyPressEventArgs e)
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

        private bool ValidateAmount(string s)
        {
            if ((int)s.Where(x => x == '.').Count() > 1 || s.StartsWith(".") || s.EndsWith("."))
            {
                MessageBox.Show("Invalid price.\nPlease enter valid price.", "Error");
                lblPrice.ForeColor = System.Drawing.Color.Red;
                return false;
            }
            return true;
        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {
            calculateChanges();

        }

        private void calculateChanges()
        {
            if (ValidateAmount(txtPrice.Text))
            {
                txtPurchasePrice.Text = "";
                float fltOriginalPrice = 0;
                if (string.IsNullOrWhiteSpace(txtPrice.Text) != true)
                {
                    fltOriginalPrice = float.Parse(txtPrice.Text);
                }
                float fltPercentAmount;
                if (txtDiscount.Text == "")
                {
                    fltPercentAmount = 0;
                }
                else
                {
                    fltPercentAmount = fltOriginalPrice * (float.Parse(txtDiscount.Text) / 100);
                }


                _fltCurrentPurchasedPrice = fltOriginalPrice - fltPercentAmount;
                txtPurchasePrice.Text = _fltCurrentPurchasedPrice.ToString();
            }
        }

        private void txtDiscount_TextChanged(object sender, EventArgs e)
        {
            calculateChanges();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Cancelling may cause the form to close.\n Data entered may be lost.Are you sure?",
                "Cancel Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Close();
            }
        }

        private void btnAddStock_Click(object sender, EventArgs e)
        {
             BusinessLogic BL = new BusinessLogic();

             try
             {
                 if (ValidateFields())
                 {
                     BLSSchema.ctStockDataTable dtStockTable = new BLSSchema.ctStockDataTable();
                     BLSSchema.ctStockRow row = dtStockTable.NewctStockRow();

                     row.ISBN = txtISBN.Text;
                     row.Title = txtTitle.Text;
                     row.Author = txtAuthor.Text;
                     row.Edition = txtEdition.Text;
                     row.Publisher = txtPublisher.Text;
                     row.Year = txtYear.Text;
                     row.Count = (txtCount.Text == "") ? 1 : int.Parse(txtCount.Text);
                     row.OriginalPrice = txtPrice.Text;
                     row.Discount = txtDiscount.Text;
                     row.PurchasePrice = txtPurchasePrice.Text;
                     row.LastUpdated = DateTime.UtcNow.ToString("yyyy-MM-dd").Substring(0, 10);
                     if (cmbPriceChangable.SelectedIndex == 0)
                     {
                         row.PriceChangable = "1";
                     }
                     else
                     {
                         row.PriceChangable = "0";
                     }

                     row.OutCount = int.Parse(txtOutCount.Text);

                     dtStockTable.Rows.Add(row);

                     DataTable dtNewStock = Program.MainObj.GetRawDataTable(dtStockTable);

                     BL.UpdatestockDetails(txtTitle.Text, txtAuthor.Text, txtEdition.Text, _fltOriginalPurchasePrice, _fltCurrentPurchasedPrice, dtNewStock);

                     MessageBox.Show("Record updated successfully", "Done");

                     _frmparentRef._BSchema.ctStockSearch.Clear();
                     _frmparentRef.SearchButtonClick();

                     Close();
                 }
             }
             catch (Exception ex)
             {
                 //log exception
                 Utility.WriteToFile(ex, "Error occured while updating stock details");

                 MessageBox.Show("Error occured while updating stock details " + ex.ToString());
             }
        }

        private bool ValidateFields()
        {
            try
            {

                if (string.IsNullOrWhiteSpace(txtCount.Text))
                {
                     MessageBox.Show("Count field is Empty", "Error");
                    lblCount.ForeColor = System.Drawing.Color.Red;
                    return false;
                }
                lblCount.ForeColor = System.Drawing.Color.Lime;

                if (string.IsNullOrWhiteSpace(txtPrice.Text))
                {
                    MessageBox.Show("Price field is Empty", "Error");
                    lblPrice.ForeColor = System.Drawing.Color.Red;
                    return false;
                }
                else
                {
                    if ((int)txtPrice.Text.Where(x => x == '.').Count() > 1 || txtPrice.Text.StartsWith(".") || txtPrice.Text.EndsWith("."))
                    {
                        MessageBox.Show("Invalid price", "Error");
                        lblPrice.ForeColor = System.Drawing.Color.Red;
                        return false;
                    }
                }
                lblPrice.ForeColor = System.Drawing.Color.Lime;

                if (string.IsNullOrWhiteSpace(txtDiscount.Text))
                {
                    txtDiscount.Text = "0";
                }

                if (string.IsNullOrWhiteSpace(txtOutCount.Text))
                {
                    MessageBox.Show("Count field is Empty", "Error");
                    lblOutCount.ForeColor = System.Drawing.Color.Red;
                    return false;
                }
                lblOutCount.ForeColor = System.Drawing.Color.Lime;

                return true;


            }
            catch(Exception ex)
            {
                //log exception
                Utility.WriteToFile(ex);

                return false;
            }
        }

        private void txtPrice_KeyUp(object sender, KeyEventArgs e)
        {
        }

        private void txtDiscount_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char pressedKey = e.KeyChar;
            if (Char.IsNumber(pressedKey) || (int)pressedKey == 8 )
            {
                // Allow input.
                e.Handled = false;
            }
            else
            {
                // Stop the character from being entered into the control since not a letter, nor punctuation, nor a space.
                e.Handled = true;
                MessageBox.Show("Only numbers and dot are allowed here.", "Only Numbers and Dot");
            }
        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
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
                MessageBox.Show("Only numbers and dot are allowed here.", "Only Numbers and Dot");
            }
        }

        }
}
