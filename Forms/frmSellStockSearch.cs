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
    public partial class frmSellStockSearch : Form
    {
        string _strKeyWord = string.Empty;
        frmSell _frmParentRef = null;
        frmBuy _frmBuyParentref = null;
        string _strCurrentParent = "";
        int _intRowIndex = -1;
        
        
        public frmSellStockSearch(string strKeyword, frmSell frmParentReference)
        {
            InitializeComponent();
            _frmParentRef = frmParentReference;
            _strCurrentParent = "SELL";
            _strKeyWord = strKeyword;
            Search();

            if (dgvSellStockSearch.RowCount > 0)
            {
                this.ShowDialog();
            }
            else
            {
                MessageBox.Show("No result found");
            }
        }

        public frmSellStockSearch(string strKeyword, frmBuy frmParentReference)
        {
            InitializeComponent();
            _frmBuyParentref = frmParentReference;
            _strCurrentParent = "BUY";
            _strKeyWord = strKeyword;
            Search();


            if (dgvSellStockSearch.RowCount > 0)
            {
                this.ShowDialog();
            }
            else
            {
                MessageBox.Show("No result found");
            }
        }

        private void frmSellStockSearch_Load(object sender, EventArgs e)
        {

        }

        private void Search()
        {
            try
            {
                BusinessLogic BLgc = new BusinessLogic();
                BLSSchema BSchema = new BLSSchema();
                string strQuery = ConstructQuery();
                BLgc.GetStock(BSchema, strQuery);
                dgvSellStockSearch.DataSource = BSchema.ctStockSearch;
            }
            catch (Exception ex)
            {
                //log exception
                Utility.WriteToFile(ex, "Error occured while retrieving record");

                MessageBox.Show("Error occured while retrieving records.Please try after some time", "Error");
                Close();
            }
        }

        private string ConstructQuery()
        {
            string strQuery = string.Empty;

            strQuery = "SELECT * FROM TblStock WHERE ISBN LIKE '%" + _strKeyWord + "%' OR Title LIKE '%" + _strKeyWord + "%' OR Author LIKE '%" + _strKeyWord + "%' OR Publisher LIKE '%" + _strKeyWord  + "%'";

            return strQuery;
            
        }

        private void btnPlace_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (_intRowIndex >= 0)
            {
                if (_strCurrentParent == "SELL")
                {
                    _frmParentRef.txtISBN.Text = dgvSellStockSearch.Rows[_intRowIndex].Cells["ISBN"].Value.ToString();//ISBN column
                    _frmParentRef.txtTitle.Text = dgvSellStockSearch.Rows[_intRowIndex].Cells["Title"].Value.ToString();//Title Column
                    _frmParentRef.txtPrice.Text = dgvSellStockSearch.Rows[_intRowIndex].Cells["OriginalPrice"].Value.ToString();//Original Price column
                    _frmParentRef.btnSell.Enabled = true;
                    this.Close();
                }
                else if (_strCurrentParent == "BUY")
                {
                    _frmBuyParentref.txtISBN.Text = dgvSellStockSearch.Rows[_intRowIndex].Cells["ISBN"].Value.ToString();
                    _frmBuyParentref.txtTitle.Text = dgvSellStockSearch.Rows[_intRowIndex].Cells["Title"].Value.ToString();
                    _frmBuyParentref.txtAuthor.Text= dgvSellStockSearch.Rows[_intRowIndex].Cells["Author"].Value.ToString();
                    _frmBuyParentref.txtEdition.Text= dgvSellStockSearch.Rows[_intRowIndex].Cells["Edition"].Value.ToString();
                    _frmBuyParentref.txtPublisher.Text= dgvSellStockSearch.Rows[_intRowIndex].Cells["Publisher"].Value.ToString();
                    _frmBuyParentref.txtPrice.Text = dgvSellStockSearch.Rows[_intRowIndex].Cells["OriginalPrice"].Value.ToString();
                    _frmBuyParentref.btnBuy.Enabled = true;
                    this.Close();
                   
                }
                else
                {
                    //do nothing.
                }
            }
            else
            {
                MessageBox.Show("Please select a row by clicking row number and then press OK button", "No record selected");
            }
        }

        private void dgvSellStockSearch_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                _intRowIndex = e.RowIndex;               

            }
        }
    }
}
