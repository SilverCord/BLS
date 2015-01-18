namespace LibraryDesign_frontEndUI
{
    partial class frmMultiIssue
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMultiIssue));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvStudentBooks = new System.Windows.Forms.DataGridView();
            this.iSBNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publisherDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceChangableDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.originalPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchasePriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastUpdatedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.outCountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ctStockDataTableBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblAdvanceAmount = new System.Windows.Forms.Label();
            this.lblAdvance = new System.Windows.Forms.Label();
            this.lblRecieptNumber = new System.Windows.Forms.Label();
            this.lblRcptNum = new System.Windows.Forms.Label();
            this.lblBalanceAmount = new System.Windows.Forms.Label();
            this.lblBalance = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnIssue = new System.Windows.Forms.Button();
            this.pbCustImage = new System.Windows.Forms.PictureBox();
            this.lblCustID = new System.Windows.Forms.Label();
            this.lblCustomerType = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dgvStudentIssuedBooks = new System.Windows.Forms.DataGridView();
            this.HistoryUID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ITitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IAuthor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IEdition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IssueDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RecieptNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IssueType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Returndate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EarlyIssue = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ctIssueDataTableBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.ctStockDataTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ctIssueDataTableBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.cmbMonth = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentBooks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctStockDataTableBindingSource1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCustImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentIssuedBooks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctIssueDataTableBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctStockDataTableBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ctIssueDataTableBindingSource1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvStudentBooks);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(3, 189);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1129, 122);
            this.groupBox3.TabIndex = 26;
            this.groupBox3.TabStop = false;
            // 
            // dgvStudentBooks
            // 
            this.dgvStudentBooks.AllowUserToAddRows = false;
            this.dgvStudentBooks.AutoGenerateColumns = false;
            this.dgvStudentBooks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStudentBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudentBooks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iSBNDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn,
            this.authorDataGridViewTextBoxColumn,
            this.yearDataGridViewTextBoxColumn,
            this.editionDataGridViewTextBoxColumn,
            this.publisherDataGridViewTextBoxColumn,
            this.countDataGridViewTextBoxColumn,
            this.priceChangableDataGridViewTextBoxColumn,
            this.originalPriceDataGridViewTextBoxColumn,
            this.discountDataGridViewTextBoxColumn,
            this.purchasePriceDataGridViewTextBoxColumn,
            this.lastUpdatedDataGridViewTextBoxColumn,
            this.outCountDataGridViewTextBoxColumn});
            this.dgvStudentBooks.DataSource = this.ctStockDataTableBindingSource1;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStudentBooks.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvStudentBooks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStudentBooks.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvStudentBooks.Location = new System.Drawing.Point(3, 16);
            this.dgvStudentBooks.Name = "dgvStudentBooks";
            this.dgvStudentBooks.Size = new System.Drawing.Size(1123, 103);
            this.dgvStudentBooks.TabIndex = 0;
            this.dgvStudentBooks.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStudentBooks_CellContentClick);
            this.dgvStudentBooks.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvStudentBooks_CellFormatting);
            // 
            // iSBNDataGridViewTextBoxColumn
            // 
            this.iSBNDataGridViewTextBoxColumn.DataPropertyName = "ISBN";
            this.iSBNDataGridViewTextBoxColumn.HeaderText = "ISBN";
            this.iSBNDataGridViewTextBoxColumn.Name = "iSBNDataGridViewTextBoxColumn";
            this.iSBNDataGridViewTextBoxColumn.Visible = false;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            // 
            // authorDataGridViewTextBoxColumn
            // 
            this.authorDataGridViewTextBoxColumn.DataPropertyName = "Author";
            this.authorDataGridViewTextBoxColumn.HeaderText = "Author";
            this.authorDataGridViewTextBoxColumn.Name = "authorDataGridViewTextBoxColumn";
            // 
            // yearDataGridViewTextBoxColumn
            // 
            this.yearDataGridViewTextBoxColumn.DataPropertyName = "Year";
            this.yearDataGridViewTextBoxColumn.HeaderText = "Year";
            this.yearDataGridViewTextBoxColumn.Name = "yearDataGridViewTextBoxColumn";
            this.yearDataGridViewTextBoxColumn.Visible = false;
            // 
            // editionDataGridViewTextBoxColumn
            // 
            this.editionDataGridViewTextBoxColumn.DataPropertyName = "Edition";
            this.editionDataGridViewTextBoxColumn.HeaderText = "Edition";
            this.editionDataGridViewTextBoxColumn.Name = "editionDataGridViewTextBoxColumn";
            // 
            // publisherDataGridViewTextBoxColumn
            // 
            this.publisherDataGridViewTextBoxColumn.DataPropertyName = "Publisher";
            this.publisherDataGridViewTextBoxColumn.HeaderText = "Publisher";
            this.publisherDataGridViewTextBoxColumn.Name = "publisherDataGridViewTextBoxColumn";
            // 
            // countDataGridViewTextBoxColumn
            // 
            this.countDataGridViewTextBoxColumn.DataPropertyName = "Count";
            this.countDataGridViewTextBoxColumn.HeaderText = "Count";
            this.countDataGridViewTextBoxColumn.Name = "countDataGridViewTextBoxColumn";
            // 
            // priceChangableDataGridViewTextBoxColumn
            // 
            this.priceChangableDataGridViewTextBoxColumn.DataPropertyName = "PriceChangable";
            this.priceChangableDataGridViewTextBoxColumn.HeaderText = "PriceChangable";
            this.priceChangableDataGridViewTextBoxColumn.Name = "priceChangableDataGridViewTextBoxColumn";
            this.priceChangableDataGridViewTextBoxColumn.Visible = false;
            // 
            // originalPriceDataGridViewTextBoxColumn
            // 
            this.originalPriceDataGridViewTextBoxColumn.DataPropertyName = "OriginalPrice";
            this.originalPriceDataGridViewTextBoxColumn.HeaderText = "OriginalPrice";
            this.originalPriceDataGridViewTextBoxColumn.Name = "originalPriceDataGridViewTextBoxColumn";
            // 
            // discountDataGridViewTextBoxColumn
            // 
            this.discountDataGridViewTextBoxColumn.DataPropertyName = "Discount";
            this.discountDataGridViewTextBoxColumn.HeaderText = "Discount";
            this.discountDataGridViewTextBoxColumn.Name = "discountDataGridViewTextBoxColumn";
            this.discountDataGridViewTextBoxColumn.Visible = false;
            // 
            // purchasePriceDataGridViewTextBoxColumn
            // 
            this.purchasePriceDataGridViewTextBoxColumn.DataPropertyName = "PurchasePrice";
            this.purchasePriceDataGridViewTextBoxColumn.HeaderText = "PurchasePrice";
            this.purchasePriceDataGridViewTextBoxColumn.Name = "purchasePriceDataGridViewTextBoxColumn";
            this.purchasePriceDataGridViewTextBoxColumn.Visible = false;
            // 
            // lastUpdatedDataGridViewTextBoxColumn
            // 
            this.lastUpdatedDataGridViewTextBoxColumn.DataPropertyName = "LastUpdated";
            this.lastUpdatedDataGridViewTextBoxColumn.HeaderText = "LastUpdated";
            this.lastUpdatedDataGridViewTextBoxColumn.Name = "lastUpdatedDataGridViewTextBoxColumn";
            this.lastUpdatedDataGridViewTextBoxColumn.Visible = false;
            // 
            // outCountDataGridViewTextBoxColumn
            // 
            this.outCountDataGridViewTextBoxColumn.DataPropertyName = "OutCount";
            this.outCountDataGridViewTextBoxColumn.HeaderText = "OutCount";
            this.outCountDataGridViewTextBoxColumn.Name = "outCountDataGridViewTextBoxColumn";
            this.outCountDataGridViewTextBoxColumn.Visible = false;
            // 
            // ctStockDataTableBindingSource1
            // 
            this.ctStockDataTableBindingSource1.DataSource = typeof(LibraryDesign_frontEndUI.BLSSchema.ctStockDataTable);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbMonth);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblAdvanceAmount);
            this.groupBox1.Controls.Add(this.lblAdvance);
            this.groupBox1.Controls.Add(this.lblRecieptNumber);
            this.groupBox1.Controls.Add(this.lblRcptNum);
            this.groupBox1.Controls.Add(this.lblBalanceAmount);
            this.groupBox1.Controls.Add(this.lblBalance);
            this.groupBox1.Controls.Add(this.tableLayoutPanel4);
            this.groupBox1.Controls.Add(this.lblCustID);
            this.groupBox1.Controls.Add(this.lblCustomerType);
            this.groupBox1.Controls.Add(this.lblType);
            this.groupBox1.Controls.Add(this.lblCustomerName);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1141, 151);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            // 
            // lblAdvanceAmount
            // 
            this.lblAdvanceAmount.AutoSize = true;
            this.lblAdvanceAmount.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdvanceAmount.ForeColor = System.Drawing.Color.White;
            this.lblAdvanceAmount.Location = new System.Drawing.Point(129, 85);
            this.lblAdvanceAmount.Name = "lblAdvanceAmount";
            this.lblAdvanceAmount.Size = new System.Drawing.Size(114, 16);
            this.lblAdvanceAmount.TabIndex = 20;
            this.lblAdvanceAmount.Text = "[Advance Amount]";
            // 
            // lblAdvance
            // 
            this.lblAdvance.AutoSize = true;
            this.lblAdvance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdvance.ForeColor = System.Drawing.Color.White;
            this.lblAdvance.Location = new System.Drawing.Point(58, 85);
            this.lblAdvance.Name = "lblAdvance";
            this.lblAdvance.Size = new System.Drawing.Size(65, 16);
            this.lblAdvance.TabIndex = 18;
            this.lblAdvance.Text = "Advance :";
            // 
            // lblRecieptNumber
            // 
            this.lblRecieptNumber.AutoSize = true;
            this.lblRecieptNumber.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecieptNumber.ForeColor = System.Drawing.Color.White;
            this.lblRecieptNumber.Location = new System.Drawing.Point(587, 87);
            this.lblRecieptNumber.Name = "lblRecieptNumber";
            this.lblRecieptNumber.Size = new System.Drawing.Size(109, 16);
            this.lblRecieptNumber.TabIndex = 45;
            this.lblRecieptNumber.Text = "[Receipt Number]";
            // 
            // lblRcptNum
            // 
            this.lblRcptNum.AutoSize = true;
            this.lblRcptNum.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRcptNum.ForeColor = System.Drawing.Color.White;
            this.lblRcptNum.Location = new System.Drawing.Point(469, 87);
            this.lblRcptNum.Name = "lblRcptNum";
            this.lblRcptNum.Size = new System.Drawing.Size(61, 16);
            this.lblRcptNum.TabIndex = 44;
            this.lblRcptNum.Text = "Balance :";
            // 
            // lblBalanceAmount
            // 
            this.lblBalanceAmount.AutoSize = true;
            this.lblBalanceAmount.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalanceAmount.ForeColor = System.Drawing.Color.White;
            this.lblBalanceAmount.Location = new System.Drawing.Point(327, 87);
            this.lblBalanceAmount.Name = "lblBalanceAmount";
            this.lblBalanceAmount.Size = new System.Drawing.Size(110, 16);
            this.lblBalanceAmount.TabIndex = 28;
            this.lblBalanceAmount.Text = "[Balance Amount]";
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalance.ForeColor = System.Drawing.Color.White;
            this.lblBalance.Location = new System.Drawing.Point(260, 87);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(61, 16);
            this.lblBalance.TabIndex = 22;
            this.lblBalance.Text = "Balance :";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.pbCustImage, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(837, 16);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(301, 132);
            this.tableLayoutPanel4.TabIndex = 40;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.btnPrint, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.btnAdd, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnIssue, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(153, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.19048F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.80952F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(145, 126);
            this.tableLayoutPanel3.TabIndex = 39;
            // 
            // btnAdd
            // 
            this.btnAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAdd.BackgroundImage")));
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(3, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(139, 37);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnIssue
            // 
            this.btnIssue.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnIssue.BackgroundImage")));
            this.btnIssue.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIssue.ForeColor = System.Drawing.Color.White;
            this.btnIssue.Location = new System.Drawing.Point(3, 46);
            this.btnIssue.Name = "btnIssue";
            this.btnIssue.Size = new System.Drawing.Size(139, 35);
            this.btnIssue.TabIndex = 8;
            this.btnIssue.Text = "Issue";
            this.btnIssue.UseVisualStyleBackColor = true;
            this.btnIssue.Click += new System.EventHandler(this.btnIssue_Click);
            // 
            // pbCustImage
            // 
            this.pbCustImage.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pbCustImage.ErrorImage")));
            this.pbCustImage.Image = ((System.Drawing.Image)(resources.GetObject("pbCustImage.Image")));
            this.pbCustImage.InitialImage = ((System.Drawing.Image)(resources.GetObject("pbCustImage.InitialImage")));
            this.pbCustImage.Location = new System.Drawing.Point(3, 3);
            this.pbCustImage.Name = "pbCustImage";
            this.pbCustImage.Size = new System.Drawing.Size(144, 126);
            this.pbCustImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbCustImage.TabIndex = 38;
            this.pbCustImage.TabStop = false;
            // 
            // lblCustID
            // 
            this.lblCustID.AutoSize = true;
            this.lblCustID.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustID.ForeColor = System.Drawing.Color.White;
            this.lblCustID.Location = new System.Drawing.Point(129, 20);
            this.lblCustID.Name = "lblCustID";
            this.lblCustID.Size = new System.Drawing.Size(89, 16);
            this.lblCustID.TabIndex = 26;
            this.lblCustID.Text = "[Customer ID]";
            // 
            // lblCustomerType
            // 
            this.lblCustomerType.AutoSize = true;
            this.lblCustomerType.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerType.ForeColor = System.Drawing.Color.White;
            this.lblCustomerType.Location = new System.Drawing.Point(539, 20);
            this.lblCustomerType.Name = "lblCustomerType";
            this.lblCustomerType.Size = new System.Drawing.Size(105, 16);
            this.lblCustomerType.TabIndex = 27;
            this.lblCustomerType.Text = "[Customer Type]";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.ForeColor = System.Drawing.Color.White;
            this.lblType.Location = new System.Drawing.Point(483, 20);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(45, 16);
            this.lblType.TabIndex = 24;
            this.lblType.Text = "Type :";
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerName.ForeColor = System.Drawing.Color.White;
            this.lblCustomerName.Location = new System.Drawing.Point(327, 21);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(110, 16);
            this.lblCustomerName.TabIndex = 21;
            this.lblCustomerName.Text = "[Customer Name]";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(271, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 16);
            this.label8.TabIndex = 19;
            this.label8.Text = "Name :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(22, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(105, 16);
            this.label9.TabIndex = 1;
            this.label9.Text = "MemberShip ID :";
            // 
            // dgvStudentIssuedBooks
            // 
            this.dgvStudentIssuedBooks.AllowUserToAddRows = false;
            this.dgvStudentIssuedBooks.AllowUserToDeleteRows = false;
            this.dgvStudentIssuedBooks.AutoGenerateColumns = false;
            this.dgvStudentIssuedBooks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStudentIssuedBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudentIssuedBooks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HistoryUID,
            this.CustomerID,
            this.ITitle,
            this.IAuthor,
            this.IEdition,
            this.IssueDate,
            this.BookCount,
            this.BookPrice,
            this.RecieptNumber,
            this.IssueType,
            this.Returndate,
            this.EarlyIssue});
            this.dgvStudentIssuedBooks.DataSource = this.ctIssueDataTableBindingSource2;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Goldenrod;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStudentIssuedBooks.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvStudentIssuedBooks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStudentIssuedBooks.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvStudentIssuedBooks.Location = new System.Drawing.Point(3, 16);
            this.dgvStudentIssuedBooks.Name = "dgvStudentIssuedBooks";
            this.dgvStudentIssuedBooks.Size = new System.Drawing.Size(1123, 161);
            this.dgvStudentIssuedBooks.TabIndex = 0;
            this.dgvStudentIssuedBooks.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvStudentIssuedBooks_CellFormatting);
            // 
            // HistoryUID
            // 
            this.HistoryUID.DataPropertyName = "HistoryUID";
            this.HistoryUID.HeaderText = "HistoryUID";
            this.HistoryUID.Name = "HistoryUID";
            this.HistoryUID.Visible = false;
            // 
            // CustomerID
            // 
            this.CustomerID.DataPropertyName = "CustomerID";
            this.CustomerID.HeaderText = "CustomerID";
            this.CustomerID.Name = "CustomerID";
            this.CustomerID.Visible = false;
            // 
            // ITitle
            // 
            this.ITitle.DataPropertyName = "Title";
            this.ITitle.HeaderText = "Title";
            this.ITitle.Name = "ITitle";
            // 
            // IAuthor
            // 
            this.IAuthor.DataPropertyName = "Author";
            this.IAuthor.HeaderText = "Author";
            this.IAuthor.Name = "IAuthor";
            // 
            // IEdition
            // 
            this.IEdition.DataPropertyName = "Edition";
            this.IEdition.HeaderText = "Edition";
            this.IEdition.Name = "IEdition";
            // 
            // IssueDate
            // 
            this.IssueDate.DataPropertyName = "IssueDate";
            this.IssueDate.HeaderText = "IssueDate";
            this.IssueDate.Name = "IssueDate";
            // 
            // BookCount
            // 
            this.BookCount.DataPropertyName = "BookCount";
            this.BookCount.HeaderText = "BookCount";
            this.BookCount.Name = "BookCount";
            // 
            // BookPrice
            // 
            this.BookPrice.DataPropertyName = "BookPrice";
            this.BookPrice.HeaderText = "BookPrice";
            this.BookPrice.Name = "BookPrice";
            // 
            // RecieptNumber
            // 
            this.RecieptNumber.DataPropertyName = "RecieptNumber";
            this.RecieptNumber.HeaderText = "RecieptNumber";
            this.RecieptNumber.Name = "RecieptNumber";
            // 
            // IssueType
            // 
            this.IssueType.DataPropertyName = "IssueType";
            this.IssueType.HeaderText = "IssueType";
            this.IssueType.Name = "IssueType";
            // 
            // Returndate
            // 
            this.Returndate.DataPropertyName = "Returndate";
            this.Returndate.HeaderText = "Returndate";
            this.Returndate.Name = "Returndate";
            // 
            // EarlyIssue
            // 
            this.EarlyIssue.DataPropertyName = "EarlyIssue";
            this.EarlyIssue.HeaderText = "EarlyIssue";
            this.EarlyIssue.Name = "EarlyIssue";
            this.EarlyIssue.Visible = false;
            // 
            // ctIssueDataTableBindingSource2
            // 
            this.ctIssueDataTableBindingSource2.DataSource = typeof(LibraryDesign_frontEndUI.BLSSchema.ctIssueDataTable);
            // 
            // ctStockDataTableBindingSource
            // 
            this.ctStockDataTableBindingSource.DataSource = typeof(LibraryDesign_frontEndUI.BLSSchema.ctStockDataTable);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvStudentIssuedBooks);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1129, 180);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            // 
            // ctIssueDataTableBindingSource1
            // 
            this.ctIssueDataTableBindingSource1.DataSource = typeof(LibraryDesign_frontEndUI.BLSSchema.ctIssueDataTable);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.63989F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 160);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1141, 320);
            this.tableLayoutPanel1.TabIndex = 27;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.groupBox2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.groupBox3, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 59.45946F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.54054F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1135, 314);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel1, 0, 1);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 32.50518F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 67.49483F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(1147, 483);
            this.tableLayoutPanel5.TabIndex = 28;
            // 
            // cmbMonth
            // 
            this.cmbMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMonth.FormattingEnabled = true;
            this.cmbMonth.Items.AddRange(new object[] {
            "--SELECT--",
            "JAN",
            "FEB",
            "MAR",
            "APR",
            "MAY",
            "JUN",
            "JUL",
            "AUG",
            "SEP",
            "OCT",
            "NOV",
            "DEC"});
            this.cmbMonth.Location = new System.Drawing.Point(687, 47);
            this.cmbMonth.Name = "cmbMonth";
            this.cmbMonth.Size = new System.Drawing.Size(121, 21);
            this.cmbMonth.TabIndex = 47;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(684, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 16);
            this.label3.TabIndex = 46;
            this.label3.Text = "Return Month :";
            // 
            // btnPrint
            // 
            this.btnPrint.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPrint.BackgroundImage")));
            this.btnPrint.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Location = new System.Drawing.Point(3, 87);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(139, 36);
            this.btnPrint.TabIndex = 9;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // frmMultiIssue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1147, 483);
            this.Controls.Add(this.tableLayoutPanel5);
            this.Name = "frmMultiIssue";
            this.Text = "Multi Issue";
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentBooks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctStockDataTableBindingSource1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbCustImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentIssuedBooks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctIssueDataTableBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctStockDataTableBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ctIssueDataTableBindingSource1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        internal System.Windows.Forms.DataGridView dgvStudentBooks;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnIssue;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dgvStudentIssuedBooks;
        private System.Windows.Forms.BindingSource ctIssueDataTableBindingSource2;
        private System.Windows.Forms.BindingSource ctStockDataTableBindingSource;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.BindingSource ctIssueDataTableBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IPublisher;
        private System.Windows.Forms.BindingSource ctStockDataTableBindingSource1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Label lblCustID;
        private System.Windows.Forms.Label lblCustomerType;
        internal System.Windows.Forms.Label lblAdvanceAmount;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblAdvance;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Label label8;
        internal System.Windows.Forms.Label lblBalanceAmount;
        private System.Windows.Forms.PictureBox pbCustImage;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.DataGridViewTextBoxColumn HistoryUID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ITitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn IAuthor;
        private System.Windows.Forms.DataGridViewTextBoxColumn IEdition;
        private System.Windows.Forms.DataGridViewTextBoxColumn IssueDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn RecieptNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn IssueType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Returndate;
        private System.Windows.Forms.DataGridViewCheckBoxColumn EarlyIssue;
        internal System.Windows.Forms.Label lblRecieptNumber;
        private System.Windows.Forms.Label lblRcptNum;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.DataGridViewTextBoxColumn iSBNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn authorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn editionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn publisherDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceChangableDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn originalPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn discountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn purchasePriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastUpdatedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn outCountDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox cmbMonth;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnPrint;
    }
}