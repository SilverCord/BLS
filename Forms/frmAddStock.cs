using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.Windows.Forms;

using LibraryDesign_frontEndUI.Forms;
using LibraryDesign_frontEndUI.Library;

namespace LibraryDesign_frontEndUI
{
    public partial class frmAddStock : Form
    {
        #region [Variables]

        bool _blnCalledFromUI = false;        
        float _fltCurrntLimit = 0;
        string _strCustomerID = string.Empty;
        string _strCustomerType = string.Empty;

        frmStudentRegister2 _ParentRGRef = null;
        frmEditBooksBorrowed _ParentBBRef = null;
        frmMultiIssue _ParentMIRef = null;
        BLSSchema.ctStockDataTable _dtstock = null;

        #endregion

        #region [Constructor]

        public frmAddStock(bool blnCalledFromUI)
        {
            InitializeComponent();
            _blnCalledFromUI = blnCalledFromUI;
            this.Text = "Add Stock";
        }
        
        
        public frmAddStock(Form parentRef,string strType, bool blnCalledFromUI,ref BLSSchema.ctStockDataTable dtstock, 
            int strCustomerID ,string strCustomerType,float fltCurrentLimit = 0)
        {
            InitializeComponent();
            _blnCalledFromUI = blnCalledFromUI;
            _dtstock = dtstock;
            _fltCurrntLimit = fltCurrentLimit;
            _strCustomerID = strCustomerID.ToString();
            _strCustomerType = strCustomerType;
            if (strType == "RG")
            {
                _ParentRGRef = (frmStudentRegister2)parentRef;
                this.Text = "Add borrowed books";
            }
            if (strType == "MI")
            {
                _ParentMIRef = (frmMultiIssue)parentRef;
                this.Text = "Add books";
            }
            else
            {
                _ParentBBRef = (frmEditBooksBorrowed)parentRef;
                this.Text = "Edit borrowed books";
            }
        }       

        #endregion

        private void btnAddStock_Click(object sender, EventArgs e)
        {
            BusinessLogic BL = new BusinessLogic();

            try
            {
                if (ValidateFields())
                {
                    if (_blnCalledFromUI)
                    {
                        BLSSchema.ctStockDataTable dtStock = new BLSSchema.ctStockDataTable();
                        float fltDiscountPrice = (float.Parse(txtPrice.Text) * int.Parse(txtDiscount.Text)) / 100;
                        fltDiscountPrice = float.Parse(txtPrice.Text) - fltDiscountPrice;
                        BLSSchema.ctStockRow row = dtStock.NewctStockRow();

                        row.ISBN = "";
                        row.Title = txtTitle.Text;
                        row.Author = txtAuthor.Text;
                        row.Edition = txtEdition.Text;
                        row.Publisher = txtPublisher.Text;
                        row.Year = cmbYear.SelectedItem.ToString();
                        row.Count = (txtCount.Text == "")?1:int.Parse(txtCount.Text);
                        row.OriginalPrice = txtPrice.Text;
                        row.Discount = txtDiscount.Text;
                        row.PurchasePrice = fltDiscountPrice.ToString();
                        row.LastUpdated =  DateTime.UtcNow.ToString("yyyy-MM-dd").Substring(0, 10);
                        row.PriceChangable = (cmbPriceChangable.SelectedIndex == 0) ? "1" : "0";
                        row.OutCount = 0;

                        dtStock.Rows.Add(row);
                        DataTable dtNewStock = Program.MainObj.GetRawDataTable(dtStock);

                        BL.AddStock(dtNewStock, txtTitle.Text, txtAuthor.Text, txtEdition.Text, fltDiscountPrice, row.Count);

                        MessageBox.Show("Record added successfully", "Done");

                        ResetAllControls();
                    }
                    else
                    {
                        #region [Non-Rental customer]
                        if (_strCustomerType == "N")
                        {

                            bool blnStatus = false;
                            if (_ParentBBRef != null)
                            {
                                //book we are adding should not be duplicate in both borrowed and selected list.
                                blnStatus = DuplicateEntryCheck(_ParentBBRef._dtIssue) && DuplicateEntryCheck(_dtstock);                                
                            }
                            else
                            {
                                blnStatus = DuplicateEntryCheck(_dtstock);
                            }

                            //No duplicate entry.
                            if (blnStatus)
                            {
                                if (LimitsCheckPass(float.Parse(txtPrice.Text) * int.Parse(txtCount.Text)))
                                {
                                    float fltDiscountPrice = (float.Parse(txtPrice.Text) * int.Parse(txtDiscount.Text)) / 100;

                                    fltDiscountPrice = float.Parse(txtPrice.Text) - fltDiscountPrice;

                                    BLSSchema.ctStockRow row = _dtstock.NewctStockRow();

                                    row.ISBN = "";
                                    row.Title = txtTitle.Text;
                                    row.Author = txtAuthor.Text;
                                    row.Edition = txtEdition.Text;
                                    row.Publisher = txtPublisher.Text;
                                    row.Year = cmbYear.SelectedItem.ToString();
                                    row.Count = 0;
                                    row.OriginalPrice = txtPrice.Text;
                                    row.Discount = txtDiscount.Text;
                                    row.PurchasePrice = fltDiscountPrice.ToString();
                                    row.LastUpdated = DateTime.UtcNow.ToString("yyyy-MM-dd").Substring(0, 10);
                                    row.PriceChangable = (cmbPriceChangable.SelectedIndex == 0) ? "1" : "0";
                                    row.OutCount = (txtCount.Text == "") ? 1 : int.Parse(txtCount.Text);
                                    _dtstock.Rows.Add(row);
                                    if (_ParentRGRef != null)
                                    {
                                        _ParentRGRef._fltCurrentBookAmount = _fltCurrntLimit + (float.Parse(txtPrice.Text) * int.Parse(txtCount.Text));

                                    }
                                    else
                                    {
                                        _ParentBBRef._fltCurrentBookAmount = _fltCurrntLimit + (float.Parse(txtPrice.Text) * int.Parse(txtCount.Text));
                                    }

                                    Close();
                                }
                                else
                                {
                                    MessageBox.Show("Cannot add this book to issue list.It exceeds customer's deposit limit.");
                                }

                            }
                            else
                            {
                                MessageBox.Show("Cannot add this book to Issue list.\n Customer already listed this book.\n Please remove the already added entry and add with new count.", "Duplicate entry Error");
                                Close();
                            }

                        }
                        #endregion [Non-Rental customer]

                        #region [Rental customer]
                        else
                        {
                            if (!DuplicateEntryCheck(_dtstock))
                            {
                                MessageBox.Show("This book is already in list.","Error");
                                return;
                            }
                            if (LimitsCheckPass(float.Parse(txtPrice.Text) * int.Parse(txtCount.Text)))
                            {
                                float fltDiscountPrice = (float.Parse(txtPrice.Text) * int.Parse(txtDiscount.Text)) / 100;

                                fltDiscountPrice = float.Parse(txtPrice.Text) - fltDiscountPrice;

                                BLSSchema.ctStockRow row = _dtstock.NewctStockRow();

                                row.ISBN = "";
                                row.Title = txtTitle.Text;
                                row.Author = txtAuthor.Text;
                                row.Edition = txtEdition.Text;
                                row.Publisher = txtPublisher.Text;
                                row.Year = cmbYear.SelectedItem.ToString();
                                row.Count = 0;
                                row.OriginalPrice = txtPrice.Text;
                                row.Discount = txtDiscount.Text;
                                row.PurchasePrice = fltDiscountPrice.ToString();
                                row.LastUpdated = DateTime.UtcNow.ToString("yyyy-MM-dd").Substring(0, 10);
                                row.PriceChangable = (cmbPriceChangable.SelectedIndex == 0) ? "1" : "0";
                                row.OutCount = (txtCount.Text == "") ? 1 : int.Parse(txtCount.Text);
                                _dtstock.Rows.Add(row);
                                if (_ParentRGRef != null)
                                {
                                    _ParentRGRef._fltCurrentBookAmount = _fltCurrntLimit + (float.Parse(txtPrice.Text) * int.Parse(txtCount.Text));

                                }
                                else if (_ParentMIRef != null)
                                {
                                    _ParentMIRef._fltCurrentBookAmount = _fltCurrntLimit + (float.Parse(txtPrice.Text) * int.Parse(txtCount.Text));
                                }
                                else
                                {
                                    _ParentBBRef._fltCurrentBookAmount = _fltCurrntLimit + (float.Parse(txtPrice.Text) * int.Parse(txtCount.Text));
                                }

                                Close();
                            }
                            else
                            {
                                MessageBox.Show("Cannot add this book to issue list.It exceeds customer's deposit limit.");
                            }
                        }
                        #endregion
                    }
                }
                
                
            }
            catch (Exception ex)
            {
                //log exception
                Utility.WriteToFile(ex, "Error while adding stock");

                MessageBox.Show(ex.ToString(), "Error while adding stock");
            }
        }

        private bool DuplicateEntryCheck(BLSSchema.ctStockDataTable dtstock)
        {
            //check whether same book is already added in _dtStock
            string strQuery = "Title = '" + txtTitle.Text + "' AND Author = '" + txtAuthor.Text + "' AND Edition = '" + txtEdition.Text +
                "' AND Publisher = '" + txtPublisher.Text + "' AND OriginalPrice = '" + txtPrice.Text + "'";
            DataRow[] result = dtstock.Select(strQuery);
            return (result.Length == 0);
        }

        private bool DuplicateEntryCheck(BLSSchema.ctIssueDataTable dtIssue)
        {
            //check whether same book is already added in _dtStock
            string strQuery = "Title = '" + txtTitle.Text + "' AND Author = '" + txtAuthor.Text + "' AND Edition = '" + txtEdition.Text + 
                "' AND Publisher = '" + txtPublisher.Text + "' AND BookPrice = '" + txtPrice.Text + "'";
            DataRow[] result = dtIssue.Select(strQuery);
            return (result.Length == 0);
        }


        private bool LimitsCheckPass(float fltCurrentBookAmount)
        {

            BusinessLogic BL = new BusinessLogic();
            float[] fl = BL.GetLimit(_strCustomerID);
            float fltMaxLimit = fl[0];
            float fltLimitUsed = fl[1];

            if (_strCustomerType != "R" && _strCustomerType != "O")
            {
                return !((fltLimitUsed + (_fltCurrntLimit + fltCurrentBookAmount)) > fltMaxLimit);
                
            }
            else
            {
                return true;
            }
        }


        private bool ValidateFields()
        {
            try
            {            

                if (string.IsNullOrWhiteSpace(txtTitle.Text))
                {
                    MessageBox.Show("Book Title is Empty","Error");
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
                lblTitle.ForeColor = System.Drawing.Color.Lime;

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
                    return false;
                }

                if (cmbYear.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select year of publication", "Error");
                    return false;
                }
                
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

                if (string.IsNullOrWhiteSpace(txtCount.Text))
                {
                    txtCount.Text = "1";
                }
                
                return true;
                

            }
            catch(Exception ex)
            {
                //log exception
                Utility.WriteToFile(ex, "Error while validating stock details");

                return false;
            }
        }

        private void frmAddStock_Load(object sender, EventArgs e)
        {
            cmbYear.SelectedIndex = 6;
            cmbPriceChangable.SelectedIndex = 0;
            
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
            {
                // Stop the character from being entered into the control since not a letter, nor punctuation, nor a space.
                e.Handled = true;
                MessageBox.Show("Only numbers are allowed here", "Only Numbers");
            }
        }

        private void Name_Validation(object sender, KeyPressEventArgs e)
       {
            Char pressedKey = e.KeyChar;
            if(pressedKey == '!' || pressedKey == '@' || pressedKey == '#' || pressedKey == '$' || pressedKey == '%' || pressedKey == '^' ||
                pressedKey == '&' || pressedKey == '*' || pressedKey == '(' || pressedKey == ')' || pressedKey == '{' || pressedKey == '}' ||
                pressedKey == '-' || pressedKey == '+' || pressedKey == '|' || pressedKey == '<' || pressedKey == '>' || pressedKey == '=' ||
                pressedKey == '~' || pressedKey == '`' || pressedKey == '_' || pressedKey == '[' || pressedKey == ']' || pressedKey == '/' || 
                pressedKey == ',' || pressedKey == '\\' || pressedKey == '?'||Char.IsLetter(pressedKey) ||Char.IsNumber(pressedKey)||
                Char.IsWhiteSpace(pressedKey) || pressedKey == '.'||(int)pressedKey == 8)
            {
                // Allow input.
                e.Handled = false;
            }
            else
                // Stop the character from being entered into the control since not a letter, nor punctuation, nor a space.
                e.Handled = true;
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

        private void Amount_Validation(object sender, KeyPressEventArgs e)
        {            
            Char pressedKey = e.KeyChar;           
            if (Char.IsNumber(pressedKey) || (int)pressedKey == 8 || pressedKey == '.')
            {               
                if (IsValidAmount(txtPrice.Text + pressedKey))
                {
                    // Allow input.
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                    MessageBox.Show("Only one dot is allowed here.", "Only one dot");
                }
            }
            else
            {
                // Stop the character from being entered into the control since not a letter, nor punctuation, nor a space.
                e.Handled = true;
                MessageBox.Show("Only numbers and dot are allowed here.", "Only Numbers and Dot");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Cancelling may cause the form to close.\n Data entered may be lost..Are you sure?",
                "Cancel Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Close();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you really want to clear all data?", "Clear Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                ResetAllControls();
            }
        }

        private void ResetAllControls()
        {
            //txtISBN.Text = "";
            txtTitle.Text = "";
            txtAuthor.Text = "";
            txtEdition.Text = "";
            txtPublisher.Text = "";
            txtCount.Text = "";
            txtPrice.Text = "";
            txtDiscount.Text = "";
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            frmCustomerSearch1 frmStockSearch = new frmCustomerSearch1(this, 
                (_ParentBBRef!= null || _ParentRGRef != null) ? true : false);
            frmStockSearch.ShowDialog();
            
        }

        private bool IsValidAmount(string strTemp)
        {
            if ((int)strTemp.Where(x => x == '.').Count() > 1 || strTemp.StartsWith("."))
            {
                return false;
            }
            
                return true;
            
        }

       
    }
}
