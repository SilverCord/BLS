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
    public partial class frmTransactionReport : Form
    {
        public frmTransactionReport()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime dtFrom = DateTime.Parse(dtpFromDate.Value.ToString());
                DateTime dtTo = DateTime.Parse(dtpToDate.Value.ToString());

                if (dtTo > DateTime.Now)
                {
                    dtTo = DateTime.Now;
                }
                else if (dtFrom > dtTo)
                {
                    MessageBox.Show("From date cannot be greater than to date", "Error");
                    return;
                }
                else
                {
                    BLSSchema bschema = new BLSSchema();
                    bschema.ctTransactionHistory.Clear();
                    BusinessLogic BLgc = new BusinessLogic();
                    string strCustomerQuery = "select * from TblTransactionHistory where [Date] >= '" + dtFrom.ToString() + "' AND [Date] <= '" + dtTo.ToString()+ "'";                    
                    BLgc.GetHistory(bschema, strCustomerQuery);
                    if (bschema.ctTransactionHistory.Rows.Count > 0)
                    {
                        float fltCashIn = 0;
                        float fltCashOut = 0;
                        float fltAdvance = 0;
                        float fltBalance = 0;
                        
                        dgvTransactionreport.DataSource = bschema.ctTransactionHistory;

                        for (int intI = 0; intI < dgvTransactionreport.Rows.Count; intI++)
                        {
                            if (string.IsNullOrWhiteSpace(dgvTransactionreport.Rows[intI].Cells["AmountIN"].Value.ToString()) != true
                                && float.Parse(dgvTransactionreport.Rows[intI].Cells["AmountIN"].Value.ToString()) > 0)
                            {
                                dgvTransactionreport.Rows[intI].DefaultCellStyle.BackColor = System.Drawing.Color.Green;
                                fltCashIn = fltCashIn + float.Parse(dgvTransactionreport.Rows[intI].Cells["AmountIN"].Value.ToString());

                            }
                            if (string.IsNullOrWhiteSpace(dgvTransactionreport.Rows[intI].Cells["AmountOut"].Value.ToString()) != true
                                && float.Parse(dgvTransactionreport.Rows[intI].Cells["AmountOut"].Value.ToString()) > 0)
                            {
                                dgvTransactionreport.Rows[intI].DefaultCellStyle.BackColor = System.Drawing.Color.Red;
                                fltCashOut = fltCashOut + float.Parse(dgvTransactionreport.Rows[intI].Cells["AmountOut"].Value.ToString());
                            }
                            if (string.IsNullOrWhiteSpace(dgvTransactionreport.Rows[intI].Cells["Advance"].Value.ToString()) != true
                                && float.Parse(dgvTransactionreport.Rows[intI].Cells["Advance"].Value.ToString()) > 0)
                            {
                                fltAdvance = fltAdvance + float.Parse(dgvTransactionreport.Rows[intI].Cells["Advance"].Value.ToString());
                            }
                            if (string.IsNullOrWhiteSpace(dgvTransactionreport.Rows[intI].Cells["Balance"].Value.ToString()) != true
                                && float.Parse(dgvTransactionreport.Rows[intI].Cells["Balance"].Value.ToString()) > 0)
                            {
                                fltBalance = fltBalance + float.Parse(dgvTransactionreport.Rows[intI].Cells["Balance"].Value.ToString());
                            }
                        }

                        txtCashIn.Text = fltCashIn.ToString();
                        txtCashOut.Text = fltCashOut.ToString();
                        txtAdvance.Text = fltAdvance.ToString();
                        txtBalance.Text = fltBalance.ToString();
                    }
                    else
                    {
                        // lblCustomerStatus.Text = "No Data found.";
                    }

                }



            }
            catch (Exception ex)
            {
                //log exception
                Utility.WriteToFile(ex, "Error occured while generating report");
                
                MessageBox.Show("Error occured while generating report. Error:" + ex.ToString(), "Error");             
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
