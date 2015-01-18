using LibraryDesign_frontEndUI.Library;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Speech.Synthesis;


namespace LibraryDesign_frontEndUI
{
    public partial class LibMain : Form
    {
        bool _blnBackUpTaken = false;
        internal bool _blnCustomerErrorDisplay = false;
        internal DBBackup _DbBack = null;
        internal string _strImagePath;
        private int childFormNumber = 0;
        internal Dictionary<string, int> dictCourseDuration = new Dictionary<string, int>();

        //internal int _intStartMembershipNumber = int.Parse(ConfigurationSettings.AppSettings["MemberShipNumber"]);
        internal int _intStartMembershipNumber = 1;

        public LibMain()
        {
            InitializeComponent();
            tlsPgrs.Visible = false;
            _DbBack = new DBBackup();
            dictCourseDuration.Add("PUC", 24);
            dictCourseDuration.Add("Degree", 36);
            dictCourseDuration.Add("PG", 24);
            dictCourseDuration.Add("Diploma", 36);
            dictCourseDuration.Add("BE", 48);
            dictCourseDuration.Add("Medicine", 60);
            dictCourseDuration.Add("Law", 36);
            _strImagePath = ConfigurationSettings.AppSettings["ImageDirectoryPath"];
        }

        internal void SpeakText(string strText)
        {
            if (chkUseSpeechCommands.Checked)
            {
                SpeechSynthesizer synthesizer = new SpeechSynthesizer();
                synthesizer.Volume = 100;  // 0...100
                synthesizer.Rate = -2;     // -10...10

                // Synchronous
                //synthesizer.Speak(strText);

                // Asynchronous
                synthesizer.SpeakAsync(strText);
            }
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        internal string GetCustomerType(string strSelectedText)
        {
            string strType = string.Empty;

            if (strSelectedText == "Rental")
            {
                strType = "R";
            }
            else if (strSelectedText == "Non-Rental")
            {
                strType = "N";
            }
            else
            {
                strType = "O";
            }

            return strType;
        }

        internal string GetDetailedCustomerType(string strSelectedText)
        {
            string strType = string.Empty;

            if (strSelectedText == "R")
            {
                strType = "Rental";
            }
            else if (strSelectedText == "N")
            {
                strType = "Non-Rental";
            }
            else
            {
                strType = "Other";
            }

            return strType;
        }

        internal float GetMaxLimit(string strMembType, float DepositAmt)
        {
            float maxLimit = -1;
            if (strMembType != "R" || strMembType != "O")
            {
                maxLimit = DepositAmt * 90 / 100;
            }
            return maxLimit;
        }

        ///<Author>Shankar</Author>
        /// <summary>
        /// Copies customer image from source directory to destination directory
        /// </summary>
        /// <param name="strImagePath"></param>
        /// <param name="strImageExtension"></param>
        /// <param name="strCustomerID"></param>
        /// <returns></returns>
        internal string CopyCustomerImage(string strImagePath, string strImageExtension, string strCustomerID)
        {
            string strDestinationPath = string.Empty;

            try
            {
                //Create "BLSImages" directory
                if (string.IsNullOrWhiteSpace(Program.MainObj._strImagePath))
                {
                    Program.MainObj._strImagePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "BLSImages");

                    if (!Directory.Exists(Program.MainObj._strImagePath))
                    {
                        Directory.CreateDirectory(Program.MainObj._strImagePath);
                    }
                }
                else
                {
                    if (!Directory.Exists(Program.MainObj._strImagePath))
                    {
                        Directory.CreateDirectory(Program.MainObj._strImagePath);
                    }
                }

                strDestinationPath = string.Format("{0}\\{1}{2}", Program.MainObj._strImagePath, strCustomerID, strImageExtension);

                File.Copy(strImagePath, strDestinationPath, true);
            }
            catch (Exception ex)
            {
                Utility.WriteToFile(ex, "Failed to copy customer image to destination path.");
            }
            return strDestinationPath;
        }

        ///<Author>Shankar</Author>
        /// <summary>
        /// After updating new customer image delete the old files
        /// </summary>
        /// <param name="strImagePath"></param>
        internal void DeletePreviousImageFile(string strImagePath)
        {
            try
            {
                string strExtension = Path.GetExtension(strImagePath);
                string strFileNameWithoutExtension = Path.GetFileNameWithoutExtension(strImagePath);

                foreach (FileInfo file in new DirectoryInfo(Path.GetDirectoryName(strImagePath)).GetFiles(strFileNameWithoutExtension + ".*"))
                {
                    if (file.Exists)
                    {
                        file.Delete();
                    }
                }

            }
            catch (Exception ex)
            {
                Utility.WriteToFile(ex, "Failed to delete customer image file.");
            }
        }

        ///<Author>Shankar</Author>
        /// <summary>
        /// Deletes customer image file
        /// </summary>
        /// <param name="strImagePath"></param>
        internal void DeleteImageFile(string strCustomerID)
        {
            try
            {
                string strImagePath = "";

                //Create "BLSImages" directory
                if (string.IsNullOrWhiteSpace(Program.MainObj._strImagePath))
                {
                    strImagePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "BLSImages");
                }
                else
                {
                    strImagePath = Program.MainObj._strImagePath;
                }
                strImagePath = Path.Combine(strImagePath, strCustomerID);

                foreach (FileInfo file in new DirectoryInfo(Path.GetDirectoryName(strImagePath)).GetFiles(strCustomerID + ".*"))
                {
                    if (file.Exists)
                    {
                        file.Delete();
                    }
                }
            }
            catch (Exception ex)
            {
                Utility.WriteToFile(ex, "Failed to delete customer image file.");
            }
        }

        internal void ActivateOrDeAcivateTextBox(object sender, bool blnIsActivated)
        {
            TextBox txt = (TextBox)sender;
            txt.BackColor = (blnIsActivated) ? System.Drawing.Color.Khaki : System.Drawing.Color.White;
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void aDDSTOCKToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddStock frmAddStock = new frmAddStock(true);
            frmAddStock.Show();
        }

        private void sEARCHToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //frmSearchStockOptions f = new frmSearchStockOptions();
            //f.Show();
        }

        private void aDDNEWToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void sEARCHToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmCustomerSearch frmCustSearch = new frmCustomerSearch();
            frmCustSearch.MdiParent = this;
            frmCustSearch.Show();
        }

        private void sTUDENTToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmCustomerSearch frmCustSearch = new frmCustomerSearch();
            frmCustSearch.MdiParent = this;
            frmCustSearch.Show();
        }

        private void bOOKToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            Close();
        }



        private void button11_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            tlpOrderAddSearch.Visible = false;
            //tlpStockAddSearch.Hide();
            //frmStock frmStock = new frmStock(this);
            //frmStock.MdiParent = this;
            //frmStock.Show();
            tlpStockAddSearch.Show();
        }

        private void btnSearchStock_Click(object sender, EventArgs e)
        {
            //frmCustomerSearch1 frmStckSrch = new frmCustomerSearch1();
            //frmStckSrch.MdiParent = this;
            //frmStckSrch.Show();           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tlpOrderAddSearch.Visible = false;
            tlpStockAddSearch.Hide();

            frmIssueBooks frmIssueBook = new frmIssueBooks();
            frmIssueBook.MdiParent = this;
            frmIssueBook.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tblpnlCustomer.Visible == true)
            {
                tblpnlCustomer.Hide();
            }
            else
            {
                tblpnlCustomer.Visible = true;
            }


        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (tlpOrderAddSearch.Visible == true)
            {
                tlpOrderAddSearch.Hide();
            }
            else
            {
                tlpOrderAddSearch.Visible = true;
            }
        }

        private void btnSell_Click(object sender, EventArgs e)
        {
            //tlpOrderAddSearch.Visible = false;
            //tlpStockAddSearch.Hide();
            btnSell.Enabled = false;
            frmSell frmSell = new frmSell(this);
            frmSell.MdiParent = this;
            frmSell.Show();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            tlpOrderAddSearch.Visible = false;
            tlpStockAddSearch.Hide();

            //frmTransactionReport frmReports = new frmTransactionReport();
            //frmReports.MdiParent = this;
            //frmReports.Show();            
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            btnBuy.Enabled = false;
            frmBuy frmbuy = new frmBuy(this);
            frmbuy.MdiParent = this;
            frmbuy.Show();
        }

        private void btnAddStock_Click(object sender, EventArgs e)
        {
            frmAddStock frmAddStock = new frmAddStock(true);
            frmAddStock.MdiParent = this;
            frmAddStock.Show();

            tlpStockAddSearch.Hide();
        }

        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            tlpOrderAddSearch.Visible = false;
            btnAddOrder.Enabled = false;
            frmPlaceOrder frmPlceOrder = new frmPlaceOrder(this);

            frmPlceOrder.Show();
            frmPlceOrder.MdiParent = this;
        }

        private void btnSearchStock_Click_1(object sender, EventArgs e)
        {
            frmCustomerSearch1 frmStckSrch = new frmCustomerSearch1();
            frmStckSrch.MdiParent = this;
            frmStckSrch.Show();

            tlpStockAddSearch.Hide();
        }

        private void btnSearchOrder_Click(object sender, EventArgs e)
        {
            frmSearchOrders srchOrders = new frmSearchOrders();
            srchOrders.Show();
            srchOrders.MdiParent = this;

            tlpOrderAddSearch.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tlpOrderAddSearch.Visible = false;
            tlpStockAddSearch.Hide();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            tlpOrderAddSearch.Visible = false;
            tlpStockAddSearch.Hide();

        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            if (tlpStockAddSearch.Visible == true)
            {
                tlpStockAddSearch.Hide();
            }
            else
            {
                tlpStockAddSearch.Visible = true;
            }
        }

        #region [Validations]

        internal bool txtISBN_Validation(Char pressedKey)
        {
            if (Char.IsNumber(pressedKey) || (int)pressedKey == 8 || (int)pressedKey == 45)
            {
                // Allow input.
                return false;
            }
            else
                // Stop the character from being entered into the control since not a letter, nor punctuation, nor a space.
                return true;
        }

        internal bool Amount_Validation(Char pressedKey)
        {
            if (Char.IsNumber(pressedKey) || (int)pressedKey == 8 || pressedKey == '.')
            {
                // Allow input.
                return false;
            }
            else
            {
                // Stop the character from being entered into the control since not a letter, nor punctuation, nor a space.
                return true;
            }
        }

        internal bool Number_Validation(Char pressedKey)
        {
            if (Char.IsNumber(pressedKey) || (int)pressedKey == 8)
            {
                // Allow input.
                return false;
            }
            else
                // Stop the character from being entered into the control since not a letter, nor punctuation, nor a space.
                return true;
        }

        internal bool Name_Validation(Char pressedKey)
        {

            if (Char.IsLetter(pressedKey) || Char.IsNumber(pressedKey) || Char.IsWhiteSpace(pressedKey) || (int)pressedKey == 8)
            {
                // Allow input.
                return false;
            }
            else
                // Stop the character from being entered into the control since not a letter, nor punctuation, nor a space.
                return true;
        }

        internal string GetReceiptNumber()
        {
            BusinessLogic bl = new BusinessLogic();

            string strLatestReceiptNumber = bl.GetReceiptNumber();

            return strLatestReceiptNumber;

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

        internal void Name_Validation(object sender, KeyPressEventArgs e)
        {
            Char pressedKey = e.KeyChar;
            if (Char.IsLetter(pressedKey) || Char.IsWhiteSpace(pressedKey) || (int)pressedKey == 8 || pressedKey == '.')
            {
                // Allow input.
                e.Handled = false;
            }
            else
                // Stop the character from being entered into the control since not a letter, nor punctuation, nor a space.
                e.Handled = true;
        }

        internal void Number_Validation(object sender, KeyPressEventArgs e)
        {
            //if (chkExisting.Checked)
            //{
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
                MessageBox.Show("Only Numbers are allowed here.", "Only numbers.!");
            }
            //}
        }

        internal void Amount_Validation(object sender, KeyPressEventArgs e)
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
            }
        }

        internal void Receipt_Validation(object sender, KeyPressEventArgs e)
        {
            Char pressedKey = e.KeyChar;
            if (Char.IsNumber(pressedKey) || Char.IsLetter(pressedKey) || (int)pressedKey == 45 || (int)pressedKey == 47
                || (int)pressedKey == 8)
            {
                // Allow input.
                e.Handled = false;
            }
            else
                // Stop the character from being entered into the control since not a letter, nor punctuation, nor a space.
                e.Handled = true;
        }

        #endregion

        private void btnRegisterr_Click(object sender, EventArgs e)
        {
            btnCustomer.Enabled = false;
            frmRegisterCustomer frmRegisterNewCustomer = new frmRegisterCustomer(this);
            frmRegisterNewCustomer.MdiParent = this;
            frmRegisterNewCustomer.Show();

            tblpnlCustomer.Hide();
        }
        internal DateTime GetReturnDate(int intSelectedMonth)
        {
            DateTime dt = DateTime.Now;
            string strDateTime = dt.ToString("dd/MM/yyyy");
            int intCurrentMonth = int.Parse(strDateTime.Substring(3, 2));
            int intYear = int.Parse(strDateTime.Substring(6, 4));
            intYear = (intSelectedMonth < intCurrentMonth) ? ++intYear : intYear;
            return new DateTime(intYear, intSelectedMonth, DateTime.DaysInMonth(intYear, intSelectedMonth));
        }

        private void btnCustomerSearch_Click(object sender, EventArgs e)
        {
            frmCustomerSearch frmCustSearch = new frmCustomerSearch();
            frmCustSearch.MdiParent = this;
            frmCustSearch.Show();

            tblpnlCustomer.Hide();
        }

        private void tlpStockAddSearch_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LibMain_MdiChildActivate(object sender, EventArgs e)
        {
            if (!_blnBackUpTaken)
            {
                try
                {
                    tlsPgrs.Visible = true;
                    _DbBack.TakeFullBackUp();
                    _blnBackUpTaken = true;
                    tlsPgrs.Visible = false;
                }
                catch (Exception ex)
                {
                    tlsPgrs.Visible = false;
                    //log exception
                    Utility.WriteToFile(ex, "Critical Error occured while taking the database full backup.");
                    Utility.SendExceptionMail(ex, "Critical Error occured while taking the database full backup.");
                    Utility.SendCriticalErrorSMS("Critical message. \n Error occured while taking the BLS database full backup");

                    if (!_blnCustomerErrorDisplay)
                    {
                        MessageBox.Show("Unable to take full backup.\n Please contact help desk.", "Critical Error");
                        _blnCustomerErrorDisplay = true;
                    }
                }
            }

        }
        public string NumberToWords(int number)
        {
            if (number == 0)
                return "zero";

            if (number < 0)
                return "-" + NumberToWords(Math.Abs(number));

            string words = "";

            if ((number / 1000000) > 0)
            {
                words += NumberToWords(number / 1000000) + " Million ";
                number %= 1000000;
            }

            if ((number / 1000) > 0)
            {
                words += NumberToWords(number / 1000) + " Thousand ";
                number %= 1000;
            }

            if ((number / 100) > 0)
            {
                words += NumberToWords(number / 100) + " Hundred ";
                number %= 100;
            }

            if (number > 0)
            {
                if (words != "")
                    words += "and ";

                var unitsMap = new[] { "Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen" };
                var tensMap = new[] { "Zero", "Ten", "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };

                if (number < 20)
                    words += unitsMap[number];
                else
                {
                    words += tensMap[number / 10];
                    if ((number % 10) > 0)
                        words += "-" + unitsMap[number % 10];
                }
            }

            return words;
        }


    }
}
