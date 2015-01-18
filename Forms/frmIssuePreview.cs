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
    public partial class frmIssuePreview : Form
    {
        frmIssueBooks _fmrParentRef = null;

        frmMultiIssue _fmrParentRefrnce = null;

        internal float fltCustomerPaidAmount = 0;

        internal bool blnCustomerCanceled = false;

        float fltAdvanceAfterDeduction = 0;
        
        public frmIssuePreview()
        {
            InitializeComponent();
            //Test comment
        }

        public frmIssuePreview(Dictionary<string,string> dtDataCollection,frmIssueBooks fmrParentRef)
        {
            InitializeComponent();
            //float fltAmtPayable = 0;
            //float fltTotalAmountPayable = 0;            
            //_fmrParentRef = fmrParentRef;
            //if (dtDataCollection["IssueType"] == "O")
            //{
            //    float fltRent = float.Parse(dtDataCollection["BookPrice"]) / 4;
            //    if (float.Parse(dtDataCollection["Advance"]) > 0)
            //    {

            //        fltAmtPayable = fltRent - float.Parse(dtDataCollection["Advance"]);

            //        if (fltAmtPayable < 0)//Customer still have advance amount
            //        {
            //            fltAdvanceAfterDeduction = Math.Abs(fltAmtPayable);
            //            fltAmtPayable = 0;
            //        }
            //        else//Balance got adjusted.Customer still have to pay some money for the book.
            //        {
            //            fltAdvanceAfterDeduction = 0;

            //        }
            //    }
            //    else
            //    {
            //        fltAmtPayable = fltRent;
            //    }

            //    if (float.Parse(dtDataCollection["Balance"]) > 0)
            //    {
            //        fltTotalAmountPayable = fltAmtPayable + float.Parse(dtDataCollection["Balance"]);
            //    }
            //    else
            //    {
            //        fltTotalAmountPayable = fltAmtPayable;
            //    }


            //}
            //else
            //{
            //    if (float.Parse(dtDataCollection["Advance"]) > 0)
            //    {

            //        fltAmtPayable = float.Parse(dtDataCollection["BookPrice"]) - float.Parse(dtDataCollection["Advance"]);

            //        if (fltAmtPayable < 0)//Customer still have advance amount
            //        {
            //            fltAdvanceAfterDeduction = Math.Abs(fltAmtPayable);
            //            fltAmtPayable = 0;
            //        }
            //        else//Balance got adjusted.Customer still have to pay some money for the book.
            //        {
            //            fltAdvanceAfterDeduction = 0;

            //        }
            //    }
            //    else
            //    {
            //        fltAmtPayable = float.Parse(dtDataCollection["BookPrice"]);
            //    }

            //    if (float.Parse(dtDataCollection["Balance"]) > 0)
            //    {
            //        fltTotalAmountPayable = fltAmtPayable + float.Parse(dtDataCollection["Balance"]);
            //    }
            //    else
            //    {
            //        fltTotalAmountPayable = fltAmtPayable;
            //    }

            //}

            //txtFirstName.Text = dtDataCollection["CustomerName"];
            //txtBookPrice.Text = dtDataCollection["BookPrice"];
            //txtBookTitle.Text = dtDataCollection["BookTitle"];
            //txtIssueType.Text = dtDataCollection["IssueType"];
            //txtAmountPayable.Text = fltAmtPayable.ToString();
            //txtPreviousBalance.Text = dtDataCollection["Balance"];
            //txtTotalAmountPayable.Text = fltTotalAmountPayable.ToString();
           
        }

        public frmIssuePreview(Dictionary<string, string> dtDataCollection, frmMultiIssue fmrParentRef)
        {
            InitializeComponent();
            float fltAmtPayable = 0;
            float fltTotalAmountPayable = 0;
            _fmrParentRefrnce = fmrParentRef;
            if (dtDataCollection["IssueType"] == "O")
            {
                float fltRent = float.Parse(dtDataCollection["BookPrice"]) / 4;
                if (float.Parse(dtDataCollection["Advance"]) > 0)
                {

                    fltAmtPayable = fltRent - float.Parse(dtDataCollection["Advance"]);

                    if (fltAmtPayable < 0)//Customer still have advance amount
                    {
                        fltAdvanceAfterDeduction = Math.Abs(fltAmtPayable);
                        fltAmtPayable = 0;
                    }
                    else//Balance got adjusted.Customer still have to pay some money for the book.
                    {
                        fltAdvanceAfterDeduction = 0;

                    }
                }
                else
                {
                    fltAmtPayable = fltRent;
                }

                if (float.Parse(dtDataCollection["Balance"]) > 0)
                {
                    fltTotalAmountPayable = fltAmtPayable + float.Parse(dtDataCollection["Balance"]);
                }
                else
                {
                    fltTotalAmountPayable = fltAmtPayable;
                }


            }
            else
            {
                if (float.Parse(dtDataCollection["Advance"]) > 0)
                {

                    fltAmtPayable = float.Parse(dtDataCollection["BookPrice"]) - float.Parse(dtDataCollection["Advance"]);

                    if (fltAmtPayable < 0)//Customer still have advance amount
                    {
                        fltAdvanceAfterDeduction = Math.Abs(fltAmtPayable);
                        fltAmtPayable = 0;
                    }
                    else//Balance got adjusted.Customer still have to pay some money for the book.
                    {
                        fltAdvanceAfterDeduction = 0;

                    }
                }
                else
                {
                    fltAmtPayable = float.Parse(dtDataCollection["BookPrice"]);
                }

                if (float.Parse(dtDataCollection["Balance"]) > 0)
                {
                    fltTotalAmountPayable = fltAmtPayable + float.Parse(dtDataCollection["Balance"]);
                }
                else
                {
                    fltTotalAmountPayable = fltAmtPayable;
                }

            }

            txtFirstName.Text = dtDataCollection["CustomerName"];
            txtBookPrice.Text = dtDataCollection["BookPrice"];            
            txtIssueType.Text = dtDataCollection["IssueType"];
            txtAmountPayable.Text = fltAmtPayable.ToString();
            txtPreviousBalance.Text = dtDataCollection["Balance"];
            txtPreviousAdvance.Text = dtDataCollection["Advance"];
            txtTotalAmountPayable.Text = fltTotalAmountPayable.ToString();

        }   


        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                if (float.Parse(txtTotalAmountPayable.Text) > 0)
                {
                    frmAmount frmAmt = new frmAmount(this,"Issue");
                    frmAmt.ShowDialog();
                }                
                if (!blnCustomerCanceled)
                {
                    float fltAdvanceAmount = 0;
                    float fltBalanceAmount = float.Parse(txtTotalAmountPayable.Text) - fltCustomerPaidAmount;
                    if (fltBalanceAmount >= 0)
                    {
                        _fmrParentRef.txtBalance.Text = fltBalanceAmount.ToString();
                        _fmrParentRefrnce.lblBalanceAmount.Text = fltBalanceAmount.ToString();
                    }
                    else
                    {
                        fltAdvanceAmount = (float)Math.Abs(decimal.Parse(fltBalanceAmount.ToString()));
                        //_fmrParentRef.txtAdvance.Text = fltAdvanceAmount.ToString();
                        _fmrParentRef.txtBalance.Text = "0";
                        _fmrParentRefrnce.lblAdvanceAmount.Text = "0";
                    }


                    if (fltAdvanceAfterDeduction > 0)
                    {
                        float fltTotalAdvance = fltAdvanceAfterDeduction + fltAdvanceAmount;
                        _fmrParentRef.txtAdvance.Text = fltTotalAdvance.ToString();
                        _fmrParentRefrnce.lblAdvanceAmount.Text = fltTotalAdvance.ToString();
                    }
                    else if (fltAdvanceAmount > 0)
                    {
                        _fmrParentRef.txtAdvance.Text = fltAdvanceAmount.ToString();
                        _fmrParentRefrnce.lblAdvanceAmount.Text= fltAdvanceAmount.ToString();
                    }
                    else
                    {
                        _fmrParentRef.txtAdvance.Text = "0";
                        _fmrParentRefrnce.lblAdvanceAmount.Text = "0";
                    }
                    _fmrParentRef._blnCancelledFromPreview = false;
                    Close();
                }
                
            }
            catch (Exception ex)
            {
                //log exception
                Utility.WriteToFile(ex);

                throw new ApplicationException(ex.ToString());
            }
        }                      

        private void btnCancel_Click(object sender, EventArgs e)
        {
            _fmrParentRefrnce._blnCancelledFromPreview = true;
            Close();
        }
    }
}
