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
    public partial class frmSearchOrders : Form
    {
        public frmSearchOrders()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                dgvOrders.DataSource = null;
                BLSSchema BSchema = new BLSSchema();
                BSchema.ctOrders.Clear();
                BusinessLogic BLgc = new BusinessLogic();
                string strOrdersQuery = ConstructCustQuery();
                BLgc.GetOrders(BSchema, strOrdersQuery);
                if (BSchema.ctOrders.Rows.Count > 0)
                {
                    dgvOrders.DataSource = BSchema.ctOrders;
                }
                else
                {
                    lblCustomerStatus.Text = "No Data found.";
                }
            }
            catch (Exception ex)
            {
                //log exception
                Utility.WriteToFile(ex, "Error occured while retrieving record");
                
                MessageBox.Show("Error occured while retrieving record : " + ex.ToString(), "Error");
            }
        }

        private string ConstructCustQuery()
        {
            string strQuery = string.Empty;
            try
            {
                strQuery = "SELECT [CustomerID],[Date],[ISBN],[Count],[DepositAmount],[OrderClearanceDate],[Mobile] FROM TblOrders " +
                    "WHERE [Date] > '" + dtpFromDate.Value + "' AND [Date] < '" + dtpToDate.Value + "'";

                return strQuery;
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
            this.Close();
        }
    }
}
