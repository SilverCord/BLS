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
    public partial class frmCustAmount : Form
    {
        frmIssuePreview _frmParentref = null;

        public frmCustAmount(frmIssuePreview frmParentref, string strType,float fltAmountPayable)
        {
            InitializeComponent();
            _frmParentref = frmParentref;
            txtAmountPayable.Text = fltAmountPayable.ToString();                      
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                if (PerformValidation())
                {
                    if (_frmParentref != null)
                    {
                        _frmParentref.fltCustomerPaidAmount = float.Parse(txtAmountPaying.Text);
                        Close();
                    }                    
                }
            }
            catch (Exception ex)
            {
                //log exception
                Utility.WriteToFile(ex);

                MessageBox.Show(ex.ToString());
            }
        }

        private bool PerformValidation()
        {
            if (string.IsNullOrWhiteSpace(txtAmountPaying.Text))
            {
                MessageBox.Show("Please enter the amount first", "Error");
                return false;
            }
            else
            {
                decimal value;
                if (!Decimal.TryParse(txtAmountPaying.Text, out value))
                {
                    MessageBox.Show("Please enter valid amount", "Error");
                    return false;
                }
            }           

            return true;

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (_frmParentref != null)
            {
                _frmParentref.blnCustomerCanceled = true;
            }            
            Close();
        }

        private void frmCustAmount_Load(object sender, EventArgs e)
        {
           if (_frmParentref != null)
            {
                _frmParentref.blnCustomerCanceled = false;
            }            
        }

        private void txtAmountPaying_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.MainObj.Number_Validation(sender, e);
        }


    }
}
