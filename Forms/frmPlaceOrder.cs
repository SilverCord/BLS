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
    public partial class frmPlaceOrder : Form
    {
        LibMain _parentref = null;
      
        public frmPlaceOrder(LibMain parentref)
        {
            InitializeComponent();
            _parentref = parentref;
        }

        private void btnPlace_Click(object sender, EventArgs e)
        {
            BusinessLogic BL = new BusinessLogic();


            try
            {
                if (ValidateFields())
                {
                    BLSSchema.ctOrdersDataTable dtOrder = new BLSSchema.ctOrdersDataTable();

                    BLSSchema.ctOrdersRow row = dtOrder.NewctOrdersRow();

                    row.CustomerID = txtCustomerID.Text;

                    row.Date = DateTime.UtcNow;

                    row.ISBN = txtISBN.Text;

                    row.Count = txtBookCount.Text;

                    row.DepositAmount = txtDepositAmount.Text;

                    row.OrderClearanceDate = DateTime.UtcNow;

                    row.Mobile = txtMobile.Text;

                    dtOrder.Rows.Add(row);

                    DataTable dtNewOrder = GetRawDataTable(dtOrder);


                    BL.PlaceOrder(dtNewOrder, txtISBN.Text, txtCustomerID.Text,int.Parse(txtBookCount.Text));

                    MessageBox.Show("Order placed successfully", "Done");

                    _parentref.btnAddOrder.Enabled = true;
                    
                    Close();
                }
            }
            catch (Exception ex)
            {
                //log exception
                Utility.WriteToFile(ex, "Error placing order");
                
                MessageBox.Show(ex.ToString(), "Error placing order");
            }
        }

        private bool ValidateFields()
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtCustomerID.Text))
                {
                    txtCustomerID.Text = "None";
                }
                
                
                if (string.IsNullOrWhiteSpace(txtISBN.Text))
                {
                    MessageBox.Show("ISBN Field is Empty");
                    lblOrderISBN.ForeColor = System.Drawing.Color.Red;
                    return false;
                }
                lblOrderISBN.ForeColor = System.Drawing.Color.Lime;

                if (string.IsNullOrWhiteSpace(txtMobile.Text))
                {
                    MessageBox.Show("Mobile number Field is Empty");
                    lblMobile.ForeColor = System.Drawing.Color.Red;
                    return false;
                }
                else
                {
                    if (txtMobile.Text.Length > 10 || txtMobile.Text.Length < 10)
                    {
                        MessageBox.Show("Enter valid mobile number");
                        lblMobile.ForeColor = System.Drawing.Color.Red;
                        return false;
                    }
                }
                lblMobile.ForeColor = System.Drawing.Color.Lime;
                
                if (string.IsNullOrWhiteSpace(txtDepositAmount.Text))
                {
                    txtDepositAmount.Text = "0";                    
                }
                
                
                if (string.IsNullOrWhiteSpace(txtBookCount.Text))
                {
                    txtBookCount.Text = "1";
                }
               
                
                if (string.IsNullOrWhiteSpace(dtpClearanceDate.Text))
                {
                    DateTime dtFrom = DateTime.Parse(dtpClearanceDate.Value.ToString());
                    if (dtFrom < DateTime.Today)
                    {
                        MessageBox.Show("Clearance date cannot be lesser than current date", "Error");
                        lblClearanceDate.ForeColor = System.Drawing.Color.Red;
                        return false;
                    }
                }
                lblClearanceDate.ForeColor = System.Drawing.Color.Lime;

               return true;
                
            }
            catch (Exception ex)
            {
                //log exception
                Utility.WriteToFile(ex);

                throw new ApplicationException(ex.ToString());
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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            frmCustomerSearch1 frmStcksrch = new frmCustomerSearch1(this);
            frmStcksrch.ShowDialog();
        }

        private void txtCustomerID_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char pressedKey = e.KeyChar;
            if (_parentref.Name_Validation(pressedKey))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }

        private void txtISBN_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char pressedKey = e.KeyChar;
            if (_parentref.txtISBN_Validation(pressedKey))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }

        private void txtMobile_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char pressedKey = e.KeyChar;
            if (_parentref.Number_Validation(pressedKey))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }

        private void txtDepositAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char pressedKey = e.KeyChar;
            if (_parentref.Amount_Validation(pressedKey))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }

        private void txtBookCount_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char pressedKey = e.KeyChar;
            if (_parentref.Number_Validation(pressedKey))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }

        }

        private void frmPlaceOrder_FormClosing(object sender, FormClosingEventArgs e)
        {
            _parentref.btnAddOrder.Enabled = true;
        }
    }
}
