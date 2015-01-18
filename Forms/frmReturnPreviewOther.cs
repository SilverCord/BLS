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
    public partial class frmReturnPreviewOther : Form
    {
        frmReturn _frmRefToParent = null;

        string _strPreviousAdvance = string.Empty;

        string _strPreviousBalance = string.Empty;

        internal float fltCustomerPaidAmount = 0;

        float _fltAdvance = 0;

        float _fltBalance = 0;

        internal bool blnCustomerCanceled = false;

        float _flttotalAmountPayable = 0;

        public frmReturnPreviewOther(string strCustomerName, string strPreviousAdvance,
            string strPreviousBalance, DataGridViewRow row, frmReturn refToParent)
        {
            InitializeComponent();
            _frmRefToParent = refToParent;
            _strPreviousAdvance = strPreviousAdvance;
            _strPreviousBalance = strPreviousBalance;

            int intIssuePeriod;
            int intDueMonths;
            int intDuePeriod;
            CalculateDue(row.Cells["IssueDate"].Value.ToString(), row.Cells["ReturnDate"].Value.ToString(), out intIssuePeriod, out intDueMonths,out intDuePeriod);
            txtCustName.Text = strCustomerName;
            txtBookTitle.Text = row.Cells[0].Value.ToString();
            txtAuthor.Text = row.Cells[1].Value.ToString();
            txtEdition.Text = row.Cells[2].Value.ToString();
            txtIssueDate.Text = row.Cells[3].Value.ToString();
            txtDueDate.Text = row.Cells[7].Value.ToString();
            txtBookCount.Text = row.Cells[4].Value.ToString();
            txtExtraDays.Text = intDueMonths.ToString();
            txtPrice.Text = row.Cells[5].Value.ToString();
            txtPreviousBalance.Text = strPreviousBalance;
            txtPreviousAdvance.Text = strPreviousAdvance;
            if (intDueMonths <= 0)
            {
                txtTotalAmountPayable.Text = "0";
            }
            else
            {
                float fltBookPrice = float.Parse(row.Cells[5].Value.ToString()) * float.Parse(row.Cells[4].Value.ToString());
                float fltBookPercent = fltBookPrice / 4;
                _flttotalAmountPayable = fltBookPercent * intDuePeriod;
                txtTotalAmountPayable.Text = _flttotalAmountPayable.ToString();
            }

            if (float.Parse(_strPreviousBalance) > 0)
            {
                float flttotal = _flttotalAmountPayable + float.Parse(_strPreviousBalance);
                txtTotalAmountPayable.Text = flttotal.ToString();
                _fltBalance = 0;
            }

            if (float.Parse(_strPreviousAdvance) > 0)
            {
                if (float.Parse(_strPreviousAdvance) > _flttotalAmountPayable)
                {
                    txtTotalAmountPayable.Text = "0";
                    _fltAdvance = float.Parse(_strPreviousAdvance) - _flttotalAmountPayable;
                }
                else
                {
                    _fltAdvance = 0;
                    float flttotal = _flttotalAmountPayable - float.Parse(_strPreviousAdvance);
                    txtTotalAmountPayable.Text = flttotal.ToString();
                }
            }
        }

        private void CalculateDue(string strIssueDate, string strDueDate, out int intIssuePeriod, out int intDueMonths, out int intDuePeriod)
        {
            intIssuePeriod = 0;
            intDueMonths = 0;
            intDuePeriod = 0;

            DateTime dtIssueDate = DateTime.Parse(strIssueDate);
            DateTime dtReturnDate = DateTime.Parse(strDueDate);

            if (dtReturnDate >= DateTime.Now)
            {
                return;
            }
            else if (dtReturnDate < DateTime.Now)
            {
                intIssuePeriod = dtReturnDate.Subtract(dtIssueDate).Days;

                int intissueMonths = (int)Math.Floor((double)intIssuePeriod / 30); 

                int intTotalDaysBookWasOut = DateTime.Now.Subtract(dtIssueDate).Days;

                double dblExtraDays = intTotalDaysBookWasOut - intIssuePeriod;

                intDueMonths = (int)Math.Floor(dblExtraDays / 30);

                if (intIssuePeriod != 0)
                {
                    intDuePeriod = (int)Math.Ceiling((double)intDueMonths / intIssuePeriod);
                }
                else
                {
                    intDuePeriod = 0;
                }


            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            _frmRefToParent._blnCancelledFromPreview = true;
            Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (float.Parse(txtTotalAmountPayable.Text) > 0)
            {
                frmAmount frmAmt = new frmAmount(this, "Return Other");
                frmAmt.ShowDialog();
            }

            if (!blnCustomerCanceled)
            {
                if (fltCustomerPaidAmount < _flttotalAmountPayable)
                {
                    _fltAdvance = 0;
                    _frmRefToParent.lblAdvance.Text = "0";
                    _fltBalance += (_flttotalAmountPayable - fltCustomerPaidAmount);
                    _frmRefToParent.lblBalanceAmount.Text = _fltBalance.ToString();
                }
                else if (fltCustomerPaidAmount == _flttotalAmountPayable)
                {
                    _fltBalance = 0;
                    _fltAdvance = 0;
                    _frmRefToParent.lblAdvance.Text = "0";
                    _frmRefToParent.lblBalanceAmount.Text = "0";
                }
                else
                {
                    _fltBalance = 0;
                    _fltAdvance += fltCustomerPaidAmount - _flttotalAmountPayable;
                    _frmRefToParent.lblAdvance.Text = _fltAdvance.ToString();
                    _frmRefToParent.lblBalanceAmount.Text = "0";
                }

                

                Close();
            }
        }
    }
}
