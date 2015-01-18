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
    public partial class frmReturnPreviews : Form
    {
        bool _blnKeyOk = false;

        internal string _strCheckNumber = string.Empty;

        internal string _strCheckClearnaceDate = string.Empty;

        internal string _strCheckAmount = string.Empty;

        internal float fltCustomerPaidAmount = 0;

        internal bool blnCustomerCanceled = false;

        frmReturn _frmRefToParent = null;
        
        float _fltAdvance = 0;

        float _fltBalance = 0;

        float _fltTotalAmtPayable = 0;

        float fltTotalPrice = 0;

        float fltAmountPayable = 0;
       
        float fltPercentAmount = 0;

        internal string _strPreviousAdvance = string.Empty;

        internal string _strPreviousBalance = string.Empty;

        internal string _strName = string.Empty;

        internal int _intBookCount = 0;
        
        public frmReturnPreviews(frmReturn refToParent)
        {
            InitializeComponent();
            _frmRefToParent = refToParent;                               
           
        }       

        private int GetExtraDays(string strReturndate)
        {
            try
            {
                int intExtradays = -1;
                DateTime dtReturnDate = DateTime.Parse(strReturndate);
                if (dtReturnDate >= DateTime.Now)
                {
                    intExtradays = 0;
                }
                else if (dtReturnDate < DateTime.Now)
                {
                    intExtradays = DateTime.Now.Subtract(dtReturnDate).Days;
                  
                }
                return intExtradays;
            }
            catch (Exception ex)
            {
                //log exception
                Utility.WriteToFile(ex, "Error occured while calcualting extra days");

                MessageBox.Show("Error occured while calcualting extra days", "Error");
                return -1;
            }
            
        }
        
        private void btnOK_Click(object sender, EventArgs e)
        {
            if (float.Parse(txtTotalAmountPayable.Text) > 0)
            {
                frmAmount frmAmt = new frmAmount(this,"Return");
                frmAmt.lblName.Text = txtCustName.Text;
                frmAmt.lblDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
                frmAmt.txtAmount.Text = txtTotalAmountPayable.Text;
                frmAmt.lblAmount.Text = Program.MainObj.NumberToWords(int.Parse(txtTotalAmountPayable.Text));
                frmAmt.ShowDialog();
            }
            
            if (!blnCustomerCanceled)
            {
                if (fltCustomerPaidAmount < _fltTotalAmtPayable)
                {
                    _fltAdvance += _fltTotalAmtPayable - fltCustomerPaidAmount;
                    _frmRefToParent.lblAdvance.Text = _fltAdvance.ToString();
                }
                else
                {
                    _fltAdvance = 0;
                    _frmRefToParent.lblAdvance.Text = "0";
                }

                if (fltCustomerPaidAmount > _fltTotalAmtPayable)
                {
                    _fltBalance += fltCustomerPaidAmount - _fltTotalAmtPayable;
                    _frmRefToParent.lblBalanceAmount.Text = _fltBalance.ToString();
                }
                else
                {
                    _fltBalance = 0;
                    _frmRefToParent.lblBalanceAmount.Text = "0";
                }
                _frmRefToParent._strCheckAmount = _strCheckAmount;
                _frmRefToParent._strCheckClearnaceDate = _strCheckClearnaceDate;
                _frmRefToParent._strCheckNumber = _strCheckNumber;
                Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _frmRefToParent._blnCancelledFromPreview = true;
            Close();
        }

        private void frmReturnPreviews_FormClosing(object sender, FormClosingEventArgs e)
        {
            //_frmRefToParent._blnCancelledFromPreview = true;
        }

        private void txtpercentageDeduction_TextChanged(object sender, EventArgs e)
       {
           if (_blnKeyOk)
           {
               if (true)
               {
                   fltPercentAmount = 0;
               }
               else
               {
                   //fltPercentAmount = fltTotalPrice * (float.Parse(txtpercentageDeduction.Text) / 100);
               }

               _fltTotalAmtPayable = fltAmountPayable = fltTotalPrice - fltPercentAmount;


               if (float.Parse(_strPreviousAdvance) > 0)
               {
                   _fltTotalAmtPayable = fltAmountPayable + float.Parse(_strPreviousAdvance);
               }

               if (float.Parse(_strPreviousBalance) > 0)
               {
                   if (float.Parse(_strPreviousBalance) >= fltAmountPayable)
                   {
                       _fltBalance = float.Parse(_strPreviousBalance) - _fltTotalAmtPayable;
                       _fltTotalAmtPayable = 0;
                   }
                   else
                   {
                       _fltTotalAmtPayable = fltAmountPayable - float.Parse(_strPreviousBalance);
                   }

               }

               txtAmountPayable.Text = fltAmountPayable.ToString();
               txtTotalAmountPayable.Text = _fltTotalAmtPayable.ToString();               
            
           }
            
        }

        private void txtpercentageDeduction_KeyPress(object sender, KeyPressEventArgs e)
        {
            _blnKeyOk = false;
            Char pressedKey = e.KeyChar;
            if (Char.IsNumber(pressedKey))
            {
                // Allow input.
                e.Handled = false;
                _blnKeyOk = true;
            }
            else if ((int)pressedKey == 8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
           
        }

        private void frmReturnPreviews_Activated(object sender, EventArgs e)
        {
            try
            {
                _fltTotalAmtPayable = float.Parse(txtAmountPayable.Text);

                if (float.Parse(txtPreviousBalance.Text) > 0)
                {
                    if (float.Parse(txtPreviousBalance.Text) > _fltTotalAmtPayable)
                    {
                        _fltBalance = float.Parse(txtPreviousBalance.Text) - _fltTotalAmtPayable;
                        _fltTotalAmtPayable = 0;
                    }
                    else
                    {
                        _fltTotalAmtPayable = _fltTotalAmtPayable - float.Parse(txtPreviousBalance.Text);
                        _fltBalance = 0;

                    }                 

                }

                if (float.Parse(txtPreviousAdvance.Text) > 0)
                {
                   _fltTotalAmtPayable += float.Parse(txtPreviousAdvance.Text);
                   _fltAdvance = 0;
                }

                txtTotalAmountPayable.Text = _fltTotalAmtPayable.ToString();


            }
            catch (Exception ex)
            {
                //log exception
                Utility.WriteToFile(ex, "Error occured while doing return calculations");

                MessageBox.Show("Error occured while doing return calculations", "Error");
            }
        }
    }
}
