namespace LibraryDesign_frontEndUI
{
    partial class frmReturn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReturn));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvCustDetails = new System.Windows.Forms.DataGridView();
            this.CustomerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookPublisher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IssueDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RecieptNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HistoryUID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IssueType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Returndate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.earlyIssueDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Select = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ctIssueDataTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ctIssueDataTableBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.ctIssueBookListDataTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ctReturnDataTableBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.ctCustomerDataTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pbCustImage = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.btnReturn = new System.Windows.Forms.Button();
            this.lblBalanceAmount = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblCustID = new System.Windows.Forms.Label();
            this.lblCustomerType = new System.Windows.Forms.Label();
            this.lblAdvance = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ctStockSearchDataTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ctReturnDataTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ctIssueDataTableBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bLSSchema = new LibraryDesign_frontEndUI.BLSSchema();
            this.ctCustomerBookDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ctIssueBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblTotAmtDisplay = new System.Windows.Forms.Label();
            this.lblBookCountDisplay = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvSelectedBooks = new System.Windows.Forms.DataGridView();
            this.customerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SelectedTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SelectedAuthor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SelectedEdition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SelectedIssueDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SelectedBookCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SelectedBookPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recieptNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SelectedReturndate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SelectedHistoryUID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.earlyIssueDataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Remove = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ctIssueBookListDataTableBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.blsSchema1 = new LibraryDesign_frontEndUI.BLSSchema();
            this.grbInfoDisplay = new System.Windows.Forms.GroupBox();
            this.txtRefundAmt = new System.Windows.Forms.TextBox();
            this.txtPercentDeduction = new System.Windows.Forms.TextBox();
            this.txtBookCount = new System.Windows.Forms.TextBox();
            this.txtBookPrice = new System.Windows.Forms.TextBox();
            this.txtReturnDate = new System.Windows.Forms.TextBox();
            this.txtExtraDays = new System.Windows.Forms.TextBox();
            this.txtIssueDate = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.lblAmountPayable = new System.Windows.Forms.Label();
            this.lblBooksCount = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctIssueDataTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctIssueDataTableBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctIssueBookListDataTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctReturnDataTableBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctCustomerDataTableBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCustImage)).BeginInit();
            this.tableLayoutPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ctStockSearchDataTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctReturnDataTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctIssueDataTableBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bLSSchema)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctCustomerBookDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctIssueBindingSource)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelectedBooks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctIssueBookListDataTableBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blsSchema1)).BeginInit();
            this.grbInfoDisplay.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvCustDetails);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(908, 170);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            // 
            // dgvCustDetails
            // 
            this.dgvCustDetails.AllowUserToAddRows = false;
            this.dgvCustDetails.AutoGenerateColumns = false;
            this.dgvCustDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCustDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CustomerID,
            this.Title,
            this.Author,
            this.Edition,
            this.BookPublisher,
            this.IssueDate,
            this.BookCount,
            this.BookPrice,
            this.RecieptNumber,
            this.HistoryUID,
            this.IssueType,
            this.Returndate,
            this.earlyIssueDataGridViewCheckBoxColumn,
            this.Select});
            this.dgvCustDetails.DataSource = this.ctIssueDataTableBindingSource;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCustDetails.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCustDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCustDetails.Location = new System.Drawing.Point(3, 16);
            this.dgvCustDetails.Name = "dgvCustDetails";
            this.dgvCustDetails.Size = new System.Drawing.Size(902, 151);
            this.dgvCustDetails.TabIndex = 11;
            this.dgvCustDetails.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCustDetails_CellClick);
            this.dgvCustDetails.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCustDetails_CellContentClick);
            this.dgvCustDetails.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvCustDetails_CellFormatting);
            this.dgvCustDetails.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvCustDetails_CellMouseClick);
            this.dgvCustDetails.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvCustDetails_RowPostPaint);
            // 
            // CustomerID
            // 
            this.CustomerID.DataPropertyName = "CustomerID";
            this.CustomerID.HeaderText = "CustomerID";
            this.CustomerID.Name = "CustomerID";
            this.CustomerID.Visible = false;
            // 
            // Title
            // 
            this.Title.DataPropertyName = "Title";
            this.Title.HeaderText = "Title";
            this.Title.Name = "Title";
            // 
            // Author
            // 
            this.Author.DataPropertyName = "Author";
            this.Author.HeaderText = "Author";
            this.Author.Name = "Author";
            // 
            // Edition
            // 
            this.Edition.DataPropertyName = "Edition";
            this.Edition.HeaderText = "Edition";
            this.Edition.Name = "Edition";
            // 
            // BookPublisher
            // 
            this.BookPublisher.DataPropertyName = "Publisher";
            this.BookPublisher.HeaderText = "Publisher";
            this.BookPublisher.Name = "BookPublisher";
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
            this.RecieptNumber.Visible = false;
            // 
            // HistoryUID
            // 
            this.HistoryUID.DataPropertyName = "HistoryUID";
            this.HistoryUID.HeaderText = "HistoryUID";
            this.HistoryUID.Name = "HistoryUID";
            this.HistoryUID.Visible = false;
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
            // earlyIssueDataGridViewCheckBoxColumn
            // 
            this.earlyIssueDataGridViewCheckBoxColumn.DataPropertyName = "EarlyIssue";
            this.earlyIssueDataGridViewCheckBoxColumn.HeaderText = "EarlyIssue";
            this.earlyIssueDataGridViewCheckBoxColumn.Name = "earlyIssueDataGridViewCheckBoxColumn";
            this.earlyIssueDataGridViewCheckBoxColumn.Visible = false;
            // 
            // Select
            // 
            this.Select.DataPropertyName = "Select";
            this.Select.HeaderText = "Select";
            this.Select.Name = "Select";
            this.Select.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Select.Text = "Select";
            this.Select.UseColumnTextForButtonValue = true;
            // 
            // ctIssueDataTableBindingSource
            // 
            this.ctIssueDataTableBindingSource.DataSource = typeof(LibraryDesign_frontEndUI.BLSSchema.ctIssueDataTable);
            // 
            // ctIssueDataTableBindingSource2
            // 
            this.ctIssueDataTableBindingSource2.DataSource = typeof(LibraryDesign_frontEndUI.BLSSchema.ctIssueDataTable);
            // 
            // ctIssueBookListDataTableBindingSource
            // 
            this.ctIssueBookListDataTableBindingSource.DataSource = typeof(LibraryDesign_frontEndUI.BLSSchema.ctIssueBookListDataTable);
            // 
            // ctReturnDataTableBindingSource1
            // 
            this.ctReturnDataTableBindingSource1.DataSource = typeof(LibraryDesign_frontEndUI.BLSSchema.ctReturnDataTable);
            // 
            // ctCustomerDataTableBindingSource
            // 
            this.ctCustomerDataTableBindingSource.DataSource = typeof(LibraryDesign_frontEndUI.BLSSchema.ctCustomerDataTable);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel6);
            this.groupBox1.Controls.Add(this.lblBalanceAmount);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lblCustID);
            this.groupBox1.Controls.Add(this.lblCustomerType);
            this.groupBox1.Controls.Add(this.lblAdvance);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblCustomerName);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(973, 94);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            // 
            // pbCustImage
            // 
            this.pbCustImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbCustImage.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pbCustImage.ErrorImage")));
            this.pbCustImage.Image = ((System.Drawing.Image)(resources.GetObject("pbCustImage.Image")));
            this.pbCustImage.InitialImage = ((System.Drawing.Image)(resources.GetObject("pbCustImage.InitialImage")));
            this.pbCustImage.Location = new System.Drawing.Point(982, 3);
            this.pbCustImage.Name = "pbCustImage";
            this.pbCustImage.Size = new System.Drawing.Size(148, 94);
            this.pbCustImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCustImage.TabIndex = 39;
            this.pbCustImage.TabStop = false;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 1;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Controls.Add(this.btnReturn, 0, 1);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Right;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(840, 16);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 3;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34.375F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65.625F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(130, 75);
            this.tableLayoutPanel6.TabIndex = 0;
            // 
            // btnReturn
            // 
            //this.btnReturn.BackgroundImage = global::LibraryDesign_frontEndUI.Properties.Resources._009___Copy2;
            this.btnReturn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnReturn.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.Location = new System.Drawing.Point(3, 21);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(124, 30);
            this.btnReturn.TabIndex = 18;
            this.btnReturn.Text = "RETURN";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // lblBalanceAmount
            // 
            this.lblBalanceAmount.AutoSize = true;
            this.lblBalanceAmount.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalanceAmount.ForeColor = System.Drawing.Color.White;
            this.lblBalanceAmount.Location = new System.Drawing.Point(326, 62);
            this.lblBalanceAmount.Name = "lblBalanceAmount";
            this.lblBalanceAmount.Size = new System.Drawing.Size(110, 16);
            this.lblBalanceAmount.TabIndex = 17;
            this.lblBalanceAmount.Text = "[Balance Amount]";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(268, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 16);
            this.label5.TabIndex = 16;
            this.label5.Text = "Balance :";
            // 
            // lblCustID
            // 
            this.lblCustID.AutoSize = true;
            this.lblCustID.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustID.ForeColor = System.Drawing.Color.White;
            this.lblCustID.Location = new System.Drawing.Point(95, 62);
            this.lblCustID.Name = "lblCustID";
            this.lblCustID.Size = new System.Drawing.Size(89, 16);
            this.lblCustID.TabIndex = 17;
            this.lblCustID.Text = "[Customer ID]";
            // 
            // lblCustomerType
            // 
            this.lblCustomerType.AutoSize = true;
            this.lblCustomerType.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerType.ForeColor = System.Drawing.Color.White;
            this.lblCustomerType.Location = new System.Drawing.Point(573, 22);
            this.lblCustomerType.Name = "lblCustomerType";
            this.lblCustomerType.Size = new System.Drawing.Size(105, 16);
            this.lblCustomerType.TabIndex = 17;
            this.lblCustomerType.Text = "[Customer Type]";
            // 
            // lblAdvance
            // 
            this.lblAdvance.AutoSize = true;
            this.lblAdvance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdvance.ForeColor = System.Drawing.Color.White;
            this.lblAdvance.Location = new System.Drawing.Point(327, 22);
            this.lblAdvance.Name = "lblAdvance";
            this.lblAdvance.Size = new System.Drawing.Size(114, 16);
            this.lblAdvance.TabIndex = 15;
            this.lblAdvance.Text = "[Advance Amount]";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(60, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "ID :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(525, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 16);
            this.label3.TabIndex = 16;
            this.label3.Text = "Type :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(264, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "Advance :";
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerName.ForeColor = System.Drawing.Color.White;
            this.lblCustomerName.Location = new System.Drawing.Point(95, 22);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(110, 16);
            this.lblCustomerName.TabIndex = 15;
            this.lblCustomerName.Text = "[Customer Name]";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(41, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "Name :";
            // 
            // ctStockSearchDataTableBindingSource
            // 
            this.ctStockSearchDataTableBindingSource.DataSource = typeof(LibraryDesign_frontEndUI.BLSSchema.ctStockSearchDataTable);
            // 
            // ctReturnDataTableBindingSource
            // 
            this.ctReturnDataTableBindingSource.DataSource = typeof(LibraryDesign_frontEndUI.BLSSchema.ctReturnDataTable);
            // 
            // ctIssueDataTableBindingSource1
            // 
            this.ctIssueDataTableBindingSource1.DataSource = typeof(LibraryDesign_frontEndUI.BLSSchema.ctIssueDataTable);
            // 
            // bLSSchema
            // 
            this.bLSSchema.DataSetName = "BLSSchema";
            this.bLSSchema.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ctCustomerBookDetailsBindingSource
            // 
            this.ctCustomerBookDetailsBindingSource.DataMember = "ctCustomerBookDetails";
            this.ctCustomerBookDetailsBindingSource.DataSource = this.bLSSchema;
            // 
            // ctIssueBindingSource
            // 
            this.ctIssueBindingSource.DataMember = "ctIssue";
            this.ctIssueBindingSource.DataSource = this.bLSSchema;
            // 
            // lblTotAmtDisplay
            // 
            this.lblTotAmtDisplay.AutoSize = true;
            this.lblTotAmtDisplay.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotAmtDisplay.ForeColor = System.Drawing.Color.White;
            this.lblTotAmtDisplay.Location = new System.Drawing.Point(3, 17);
            this.lblTotAmtDisplay.Name = "lblTotAmtDisplay";
            this.lblTotAmtDisplay.Size = new System.Drawing.Size(68, 17);
            this.lblTotAmtDisplay.TabIndex = 17;
            this.lblTotAmtDisplay.Text = "Total Amount Payable :";
            // 
            // lblBookCountDisplay
            // 
            this.lblBookCountDisplay.AutoSize = true;
            this.lblBookCountDisplay.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookCountDisplay.ForeColor = System.Drawing.Color.White;
            this.lblBookCountDisplay.Location = new System.Drawing.Point(3, 0);
            this.lblBookCountDisplay.Name = "lblBookCountDisplay";
            this.lblBookCountDisplay.Size = new System.Drawing.Size(86, 16);
            this.lblBookCountDisplay.TabIndex = 17;
            this.lblBookCountDisplay.Text = "Book Count:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvSelectedBooks);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(3, 179);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(908, 186);
            this.groupBox3.TabIndex = 31;
            this.groupBox3.TabStop = false;
            // 
            // dgvSelectedBooks
            // 
            this.dgvSelectedBooks.AllowUserToAddRows = false;
            this.dgvSelectedBooks.AutoGenerateColumns = false;
            this.dgvSelectedBooks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSelectedBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSelectedBooks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customerIDDataGridViewTextBoxColumn,
            this.SelectedTitle,
            this.SelectedAuthor,
            this.SelectedEdition,
            this.SelectedIssueDate,
            this.SelectedBookCount,
            this.SelectedBookPrice,
            this.recieptNumberDataGridViewTextBoxColumn,
            this.SelectedReturndate,
            this.SelectedHistoryUID,
            this.earlyIssueDataGridViewCheckBoxColumn1,
            this.Remove});
            this.dgvSelectedBooks.DataSource = this.ctIssueBookListDataTableBindingSource1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSelectedBooks.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSelectedBooks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSelectedBooks.Location = new System.Drawing.Point(3, 16);
            this.dgvSelectedBooks.Name = "dgvSelectedBooks";
            this.dgvSelectedBooks.Size = new System.Drawing.Size(902, 167);
            this.dgvSelectedBooks.TabIndex = 11;
            this.dgvSelectedBooks.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSelectedBooks_CellClick);
            this.dgvSelectedBooks.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvSelectedBooks_CellFormatting);
            // 
            // customerIDDataGridViewTextBoxColumn
            // 
            this.customerIDDataGridViewTextBoxColumn.DataPropertyName = "CustomerID";
            this.customerIDDataGridViewTextBoxColumn.HeaderText = "CustomerID";
            this.customerIDDataGridViewTextBoxColumn.Name = "customerIDDataGridViewTextBoxColumn";
            this.customerIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // SelectedTitle
            // 
            this.SelectedTitle.DataPropertyName = "Title";
            this.SelectedTitle.HeaderText = "Title";
            this.SelectedTitle.Name = "SelectedTitle";
            // 
            // SelectedAuthor
            // 
            this.SelectedAuthor.DataPropertyName = "Author";
            this.SelectedAuthor.HeaderText = "Author";
            this.SelectedAuthor.Name = "SelectedAuthor";
            // 
            // SelectedEdition
            // 
            this.SelectedEdition.DataPropertyName = "Edition";
            this.SelectedEdition.HeaderText = "Edition";
            this.SelectedEdition.Name = "SelectedEdition";
            // 
            // SelectedIssueDate
            // 
            this.SelectedIssueDate.DataPropertyName = "IssueDate";
            this.SelectedIssueDate.HeaderText = "IssueDate";
            this.SelectedIssueDate.Name = "SelectedIssueDate";
            // 
            // SelectedBookCount
            // 
            this.SelectedBookCount.DataPropertyName = "BookCount";
            this.SelectedBookCount.HeaderText = "BookCount";
            this.SelectedBookCount.Name = "SelectedBookCount";
            // 
            // SelectedBookPrice
            // 
            this.SelectedBookPrice.DataPropertyName = "BookPrice";
            this.SelectedBookPrice.HeaderText = "BookPrice";
            this.SelectedBookPrice.Name = "SelectedBookPrice";
            // 
            // recieptNumberDataGridViewTextBoxColumn
            // 
            this.recieptNumberDataGridViewTextBoxColumn.DataPropertyName = "RecieptNumber";
            this.recieptNumberDataGridViewTextBoxColumn.HeaderText = "RecieptNumber";
            this.recieptNumberDataGridViewTextBoxColumn.Name = "recieptNumberDataGridViewTextBoxColumn";
            this.recieptNumberDataGridViewTextBoxColumn.Visible = false;
            // 
            // SelectedReturndate
            // 
            this.SelectedReturndate.DataPropertyName = "Returndate";
            this.SelectedReturndate.HeaderText = "Returndate";
            this.SelectedReturndate.Name = "SelectedReturndate";
            // 
            // SelectedHistoryUID
            // 
            this.SelectedHistoryUID.DataPropertyName = "HistoryUID";
            this.SelectedHistoryUID.HeaderText = "HistoryUID";
            this.SelectedHistoryUID.Name = "SelectedHistoryUID";
            this.SelectedHistoryUID.Visible = false;
            // 
            // earlyIssueDataGridViewCheckBoxColumn1
            // 
            this.earlyIssueDataGridViewCheckBoxColumn1.DataPropertyName = "EarlyIssue";
            this.earlyIssueDataGridViewCheckBoxColumn1.HeaderText = "EarlyIssue";
            this.earlyIssueDataGridViewCheckBoxColumn1.Name = "earlyIssueDataGridViewCheckBoxColumn1";
            this.earlyIssueDataGridViewCheckBoxColumn1.Visible = false;
            // 
            // Remove
            // 
            this.Remove.HeaderText = "Remove";
            this.Remove.Name = "Remove";
            this.Remove.Text = "Remove";
            this.Remove.UseColumnTextForButtonValue = true;
            // 
            // ctIssueBookListDataTableBindingSource1
            // 
            this.ctIssueBookListDataTableBindingSource1.DataSource = typeof(LibraryDesign_frontEndUI.BLSSchema.ctIssueBookListDataTable);
            // 
            // blsSchema1
            // 
            this.blsSchema1.DataSetName = "BLSSchema";
            this.blsSchema1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // grbInfoDisplay
            // 
            this.grbInfoDisplay.Controls.Add(this.txtRefundAmt);
            this.grbInfoDisplay.Controls.Add(this.txtPercentDeduction);
            this.grbInfoDisplay.Controls.Add(this.txtBookCount);
            this.grbInfoDisplay.Controls.Add(this.txtBookPrice);
            this.grbInfoDisplay.Controls.Add(this.txtReturnDate);
            this.grbInfoDisplay.Controls.Add(this.txtExtraDays);
            this.grbInfoDisplay.Controls.Add(this.txtIssueDate);
            this.grbInfoDisplay.Controls.Add(this.label15);
            this.grbInfoDisplay.Controls.Add(this.label14);
            this.grbInfoDisplay.Controls.Add(this.label13);
            this.grbInfoDisplay.Controls.Add(this.label12);
            this.grbInfoDisplay.Controls.Add(this.label11);
            this.grbInfoDisplay.Controls.Add(this.label10);
            this.grbInfoDisplay.Controls.Add(this.btnAdd);
            this.grbInfoDisplay.Controls.Add(this.label9);
            this.grbInfoDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbInfoDisplay.Location = new System.Drawing.Point(3, 3);
            this.grbInfoDisplay.Name = "grbInfoDisplay";
            this.grbInfoDisplay.Size = new System.Drawing.Size(201, 322);
            this.grbInfoDisplay.TabIndex = 33;
            this.grbInfoDisplay.TabStop = false;
            // 
            // txtRefundAmt
            // 
            this.txtRefundAmt.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtRefundAmt.Location = new System.Drawing.Point(102, 232);
            this.txtRefundAmt.Name = "txtRefundAmt";
            this.txtRefundAmt.ReadOnly = true;
            this.txtRefundAmt.Size = new System.Drawing.Size(88, 20);
            this.txtRefundAmt.TabIndex = 36;
            // 
            // txtPercentDeduction
            // 
            this.txtPercentDeduction.Location = new System.Drawing.Point(102, 197);
            this.txtPercentDeduction.Name = "txtPercentDeduction";
            this.txtPercentDeduction.Size = new System.Drawing.Size(88, 20);
            this.txtPercentDeduction.TabIndex = 35;
            this.txtPercentDeduction.Text = "25";
            this.txtPercentDeduction.TextChanged += new System.EventHandler(this.txtPercentDeduction_TextChanged);
            this.txtPercentDeduction.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPercentDeduction_KeyPress);
            // 
            // txtBookCount
            // 
            this.txtBookCount.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtBookCount.Location = new System.Drawing.Point(102, 159);
            this.txtBookCount.Name = "txtBookCount";
            this.txtBookCount.ReadOnly = true;
            this.txtBookCount.Size = new System.Drawing.Size(88, 20);
            this.txtBookCount.TabIndex = 34;
            this.txtBookCount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBookCount_KeyPress);
            // 
            // txtBookPrice
            // 
            this.txtBookPrice.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtBookPrice.Location = new System.Drawing.Point(103, 124);
            this.txtBookPrice.Name = "txtBookPrice";
            this.txtBookPrice.ReadOnly = true;
            this.txtBookPrice.Size = new System.Drawing.Size(87, 20);
            this.txtBookPrice.TabIndex = 33;
            // 
            // txtReturnDate
            // 
            this.txtReturnDate.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtReturnDate.Location = new System.Drawing.Point(102, 53);
            this.txtReturnDate.Name = "txtReturnDate";
            this.txtReturnDate.ReadOnly = true;
            this.txtReturnDate.Size = new System.Drawing.Size(88, 20);
            this.txtReturnDate.TabIndex = 32;
            // 
            // txtExtraDays
            // 
            this.txtExtraDays.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtExtraDays.Location = new System.Drawing.Point(103, 90);
            this.txtExtraDays.Name = "txtExtraDays";
            this.txtExtraDays.ReadOnly = true;
            this.txtExtraDays.Size = new System.Drawing.Size(87, 20);
            this.txtExtraDays.TabIndex = 32;
            this.txtExtraDays.Text = "0";
            // 
            // txtIssueDate
            // 
            this.txtIssueDate.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtIssueDate.Location = new System.Drawing.Point(103, 19);
            this.txtIssueDate.Name = "txtIssueDate";
            this.txtIssueDate.ReadOnly = true;
            this.txtIssueDate.Size = new System.Drawing.Size(87, 20);
            this.txtIssueDate.TabIndex = 32;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(22, 233);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(77, 16);
            this.label15.TabIndex = 31;
            this.label15.Text = "Refnd Amt :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(21, 124);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(76, 16);
            this.label14.TabIndex = 30;
            this.label14.Text = "Book Price :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(9, 197);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(89, 16);
            this.label13.TabIndex = 29;
            this.label13.Text = "% Deduction :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(17, 159);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(81, 16);
            this.label12.TabIndex = 28;
            this.label12.Text = "Book Count :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(20, 91);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 16);
            this.label11.TabIndex = 27;
            this.label11.Text = "Extra Days :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(26, 53);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 16);
            this.label10.TabIndex = 26;
            this.label10.Text = "Due Date :";
            // 
            // btnAdd
            // 
            //this.btnAdd.BackgroundImage = global::LibraryDesign_frontEndUI.Properties.Resources._009___Copy2;
            this.btnAdd.Font = new System.Drawing.Font("Tahoma", 10.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(43, 265);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(127, 32);
            this.btnAdd.TabIndex = 25;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(20, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 16);
            this.label9.TabIndex = 15;
            this.label9.Text = "Issue Date :";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 81.24495F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.75505F));
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel1, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 111);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1133, 374);
            this.tableLayoutPanel3.TabIndex = 34;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.groupBox2, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.groupBox3, 0, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.0315F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.9685F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(914, 368);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel5, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.grbInfoDisplay, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(923, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 89.19598F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.80402F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(207, 368);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.78899F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53.21101F));
            this.tableLayoutPanel5.Controls.Add(this.lblTotAmtDisplay, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.lblBookCountDisplay, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.lblBooksCount, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.lblAmountPayable, 1, 1);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 331);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(201, 34);
            this.tableLayoutPanel5.TabIndex = 0;
            // 
            // lblAmountPayable
            // 
            this.lblAmountPayable.AutoSize = true;
            this.lblAmountPayable.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmountPayable.ForeColor = System.Drawing.Color.White;
            this.lblAmountPayable.Location = new System.Drawing.Point(97, 17);
            this.lblAmountPayable.Name = "lblAmountPayable";
            this.lblAmountPayable.Size = new System.Drawing.Size(16, 16);
            this.lblAmountPayable.TabIndex = 16;
            this.lblAmountPayable.Text = "0";
            // 
            // lblBooksCount
            // 
            this.lblBooksCount.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblBooksCount.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBooksCount.ForeColor = System.Drawing.Color.White;
            this.lblBooksCount.Location = new System.Drawing.Point(97, 0);
            this.lblBooksCount.Name = "lblBooksCount";
            this.lblBooksCount.Size = new System.Drawing.Size(93, 17);
            this.lblBooksCount.TabIndex = 16;
            this.lblBooksCount.Text = "0";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 86.43006F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.56994F));
            this.tableLayoutPanel2.Controls.Add(this.pbCustImage, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1133, 100);
            this.tableLayoutPanel2.TabIndex = 40;
            // 
            // frmReturn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1133, 485);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Name = "frmReturn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Return";
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctIssueDataTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctIssueDataTableBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctIssueBookListDataTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctReturnDataTableBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctCustomerDataTableBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCustImage)).EndInit();
            this.tableLayoutPanel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ctStockSearchDataTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctReturnDataTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctIssueDataTableBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bLSSchema)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctCustomerBookDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctIssueBindingSource)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelectedBooks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctIssueBookListDataTableBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blsSchema1)).EndInit();
            this.grbInfoDisplay.ResumeLayout(false);
            this.grbInfoDisplay.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvCustDetails;
        private System.Windows.Forms.BindingSource ctCustomerDataTableBindingSource;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.BindingSource ctStockSearchDataTableBindingSource;
        private System.Windows.Forms.BindingSource ctReturnDataTableBindingSource;
        private System.Windows.Forms.BindingSource ctReturnDataTableBindingSource1;
        private System.Windows.Forms.Label lblCustomerType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.BindingSource ctIssueDataTableBindingSource;
        private System.Windows.Forms.BindingSource ctIssueDataTableBindingSource1;
        private BLSSchema bLSSchema;
        private System.Windows.Forms.BindingSource ctCustomerBookDetailsBindingSource;
        private System.Windows.Forms.BindingSource ctIssueBindingSource;
        private System.Windows.Forms.BindingSource ctIssueBookListDataTableBindingSource;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Label lblBalanceAmount;
        internal System.Windows.Forms.Label lblAdvance;
        private System.Windows.Forms.Label lblCustID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource ctIssueDataTableBindingSource2;
        private System.Windows.Forms.Label lblTotAmtDisplay;
        private System.Windows.Forms.Label lblBookCountDisplay;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvSelectedBooks;
        private System.Windows.Forms.DataGridViewTextBoxColumn Publisher;
        private BLSSchema blsSchema1;
        private System.Windows.Forms.GroupBox grbInfoDisplay;
        private System.Windows.Forms.TextBox txtRefundAmt;
        private System.Windows.Forms.TextBox txtPercentDeduction;
        private System.Windows.Forms.TextBox txtBookCount;
        private System.Windows.Forms.TextBox txtBookPrice;
        private System.Windows.Forms.TextBox txtReturnDate;
        private System.Windows.Forms.TextBox txtExtraDays;
        private System.Windows.Forms.TextBox txtIssueDate;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SelectedTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn SelectedAuthor;
        private System.Windows.Forms.DataGridViewTextBoxColumn SelectedEdition;
        private System.Windows.Forms.DataGridViewTextBoxColumn SelectedIssueDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn SelectedBookCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn SelectedBookPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn recieptNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SelectedReturndate;
        private System.Windows.Forms.DataGridViewTextBoxColumn SelectedHistoryUID;
        private System.Windows.Forms.DataGridViewCheckBoxColumn earlyIssueDataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewButtonColumn Remove;
        private System.Windows.Forms.BindingSource ctIssueBookListDataTableBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Author;
        private System.Windows.Forms.DataGridViewTextBoxColumn Edition;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookPublisher;
        private System.Windows.Forms.DataGridViewTextBoxColumn IssueDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn RecieptNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn HistoryUID;
        private System.Windows.Forms.DataGridViewTextBoxColumn IssueType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Returndate;
        private System.Windows.Forms.DataGridViewCheckBoxColumn earlyIssueDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Select;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.PictureBox pbCustImage;
        private System.Windows.Forms.Label lblBooksCount;
        private System.Windows.Forms.Label lblAmountPayable;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    }
}