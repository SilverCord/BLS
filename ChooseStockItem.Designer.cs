namespace LibraryDesign_frontEndUI
{
    partial class frmChooseStockItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChooseStockItem));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnSearch = new System.Windows.Forms.Button();
            this.Count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OriginalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PurchasePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceChangable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OutCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Issue = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ctStockBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bLSSchema = new LibraryDesign_frontEndUI.BLSSchema();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSelectionDone = new System.Windows.Forms.Button();
            this.ctStockSearchDataTableBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.ctStockSearchDataTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ctStockBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Publisher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtEdition = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkMatchExact = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPublisher = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRecordCount = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvSelectedBooks = new System.Windows.Forms.DataGridView();
            this.dgvStockSearchResult = new System.Windows.Forms.DataGridView();
            this.ISBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SelectedTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SelectedAuthor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SelectedEdition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SelectedPublisher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SelectedCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SelectedOriginalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewButtonColumn1 = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ctStockBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bLSSchema)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ctStockSearchDataTableBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctStockSearchDataTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctStockBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelectedBooks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStockSearchResult)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSearch.BackgroundImage")));
            this.btnSearch.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSearch.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(924, 16);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(117, 82);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // Count
            // 
            this.Count.DataPropertyName = "Count";
            this.Count.HeaderText = "Count";
            this.Count.Name = "Count";
            // 
            // OriginalPrice
            // 
            this.OriginalPrice.DataPropertyName = "OriginalPrice";
            this.OriginalPrice.HeaderText = "OriginalPrice";
            this.OriginalPrice.Name = "OriginalPrice";
            // 
            // Discount
            // 
            this.Discount.DataPropertyName = "Discount";
            this.Discount.HeaderText = "Discount";
            this.Discount.Name = "Discount";
            this.Discount.Visible = false;
            // 
            // PurchasePrice
            // 
            this.PurchasePrice.DataPropertyName = "PurchasePrice";
            this.PurchasePrice.HeaderText = "PurchasePrice";
            this.PurchasePrice.Name = "PurchasePrice";
            // 
            // PriceChangable
            // 
            this.PriceChangable.DataPropertyName = "PriceChangable";
            this.PriceChangable.HeaderText = "PriceChangable";
            this.PriceChangable.Name = "PriceChangable";
            this.PriceChangable.Visible = false;
            // 
            // OutCount
            // 
            this.OutCount.DataPropertyName = "OutCount";
            this.OutCount.HeaderText = "OutCount";
            this.OutCount.Name = "OutCount";
            this.OutCount.Visible = false;
            // 
            // Issue
            // 
            this.Issue.HeaderText = "Select";
            this.Issue.Name = "Issue";
            this.Issue.Text = "Select";
            this.Issue.UseColumnTextForButtonValue = true;
            // 
            // ctStockBindingSource1
            // 
            this.ctStockBindingSource1.DataMember = "ctStock";
            this.ctStockBindingSource1.DataSource = this.bLSSchema;
            // 
            // bLSSchema
            // 
            this.bLSSchema.DataSetName = "BLSSchema";
            this.bLSSchema.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.btnCancel, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnSelectionDone, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 375);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1038, 59);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // btnCancel
            // 
            this.btnCancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancel.BackgroundImage")));
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCancel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(521, 4);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(253, 51);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSelectionDone
            // 
            this.btnSelectionDone.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSelectionDone.BackgroundImage")));
            this.btnSelectionDone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSelectionDone.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectionDone.Location = new System.Drawing.Point(262, 4);
            this.btnSelectionDone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSelectionDone.Name = "btnSelectionDone";
            this.btnSelectionDone.Size = new System.Drawing.Size(253, 51);
            this.btnSelectionDone.TabIndex = 3;
            this.btnSelectionDone.Text = "Done";
            this.btnSelectionDone.UseVisualStyleBackColor = true;
            this.btnSelectionDone.Click += new System.EventHandler(this.btnSelectionDone_Click_1);
            // 
            // ctStockSearchDataTableBindingSource1
            // 
            this.ctStockSearchDataTableBindingSource1.DataSource = typeof(LibraryDesign_frontEndUI.BLSSchema.ctStockSearchDataTable);
            // 
            // ctStockSearchDataTableBindingSource
            // 
            this.ctStockSearchDataTableBindingSource.DataSource = typeof(LibraryDesign_frontEndUI.BLSSchema.ctStockSearchDataTable);
            // 
            // ctStockBindingSource
            // 
            this.ctStockBindingSource.DataMember = "ctStock";
            this.ctStockBindingSource.DataSource = this.bLSSchema;
            // 
            // Publisher
            // 
            this.Publisher.DataPropertyName = "Publisher";
            this.Publisher.HeaderText = "Publisher";
            this.Publisher.Name = "Publisher";
            // 
            // Edition
            // 
            this.Edition.DataPropertyName = "Edition";
            this.Edition.HeaderText = "Edition";
            this.Edition.Name = "Edition";
            // 
            // txtEdition
            // 
            this.txtEdition.Location = new System.Drawing.Point(62, 65);
            this.txtEdition.Name = "txtEdition";
            this.txtEdition.Size = new System.Drawing.Size(333, 20);
            this.txtEdition.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(782, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Record Count :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSearch);
            this.groupBox2.Controls.Add(this.chkMatchExact);
            this.groupBox2.Controls.Add(this.txtEdition);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtPublisher);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtRecordCount);
            this.groupBox2.Controls.Add(this.txtTitle);
            this.groupBox2.Controls.Add(this.txtAuthor);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1044, 101);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Criteria";
            // 
            // chkMatchExact
            // 
            this.chkMatchExact.AutoSize = true;
            this.chkMatchExact.Location = new System.Drawing.Point(785, 64);
            this.chkMatchExact.Name = "chkMatchExact";
            this.chkMatchExact.Size = new System.Drawing.Size(86, 17);
            this.chkMatchExact.TabIndex = 4;
            this.chkMatchExact.Text = "Match Exact";
            this.chkMatchExact.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(412, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Publisher :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(412, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Author :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Edition :";
            // 
            // txtPublisher
            // 
            this.txtPublisher.Location = new System.Drawing.Point(469, 23);
            this.txtPublisher.Name = "txtPublisher";
            this.txtPublisher.Size = new System.Drawing.Size(293, 20);
            this.txtPublisher.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Title :";
            // 
            // txtRecordCount
            // 
            this.txtRecordCount.Location = new System.Drawing.Point(862, 26);
            this.txtRecordCount.MaxLength = 8;
            this.txtRecordCount.Name = "txtRecordCount";
            this.txtRecordCount.Size = new System.Drawing.Size(42, 20);
            this.txtRecordCount.TabIndex = 0;
            this.txtRecordCount.Text = "100";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(62, 24);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(333, 20);
            this.txtTitle.TabIndex = 0;
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(469, 62);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(293, 20);
            this.txtAuthor.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel2);
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 91);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1044, 437);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.dgvSelectedBooks, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.dgvStockSearchResult, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1038, 359);
            this.tableLayoutPanel2.TabIndex = 8;
            // 
            // dgvSelectedBooks
            // 
            this.dgvSelectedBooks.AllowUserToAddRows = false;
            this.dgvSelectedBooks.AutoGenerateColumns = false;
            this.dgvSelectedBooks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSelectedBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSelectedBooks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.SelectedTitle,
            this.SelectedAuthor,
            this.dataGridViewTextBoxColumn4,
            this.SelectedEdition,
            this.SelectedPublisher,
            this.SelectedCount,
            this.SelectedOriginalPrice,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewButtonColumn1});
            this.dgvSelectedBooks.DataSource = this.ctStockBindingSource1;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkOliveGreen;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSelectedBooks.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSelectedBooks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSelectedBooks.Location = new System.Drawing.Point(3, 182);
            this.dgvSelectedBooks.Name = "dgvSelectedBooks";
            this.dgvSelectedBooks.Size = new System.Drawing.Size(1032, 174);
            this.dgvSelectedBooks.TabIndex = 1;
            this.dgvSelectedBooks.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvSelectedBooks_CellMouseClick);
            // 
            // dgvStockSearchResult
            // 
            this.dgvStockSearchResult.AllowUserToAddRows = false;
            this.dgvStockSearchResult.AutoGenerateColumns = false;
            this.dgvStockSearchResult.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStockSearchResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStockSearchResult.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ISBN,
            this.Title,
            this.Author,
            this.Year,
            this.Edition,
            this.Publisher,
            this.Count,
            this.OriginalPrice,
            this.Discount,
            this.PurchasePrice,
            this.PriceChangable,
            this.OutCount,
            this.Issue});
            this.dgvStockSearchResult.DataSource = this.ctStockBindingSource1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkOliveGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStockSearchResult.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvStockSearchResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStockSearchResult.Location = new System.Drawing.Point(3, 3);
            this.dgvStockSearchResult.Name = "dgvStockSearchResult";
            this.dgvStockSearchResult.Size = new System.Drawing.Size(1032, 173);
            this.dgvStockSearchResult.TabIndex = 0;
            //this.dgvStockSearchResult.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvStockSearchResult_CellFormatting);
            this.dgvStockSearchResult.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvStockSearchResult_CellMouseClick);
            this.dgvStockSearchResult.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvStockSearchResult_RowPostPaint_1);
            this.dgvStockSearchResult.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvStockSearchResult_RowsAdded);
            // 
            // ISBN
            // 
            this.ISBN.DataPropertyName = "ISBN";
            this.ISBN.HeaderText = "ISBN";
            this.ISBN.Name = "ISBN";
            this.ISBN.Visible = false;
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
            // Year
            // 
            this.Year.DataPropertyName = "Year";
            this.Year.HeaderText = "Year";
            this.Year.Name = "Year";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ISBN";
            this.dataGridViewTextBoxColumn1.HeaderText = "ISBN";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
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
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Year";
            this.dataGridViewTextBoxColumn4.HeaderText = "Year";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // SelectedEdition
            // 
            this.SelectedEdition.DataPropertyName = "Edition";
            this.SelectedEdition.HeaderText = "Edition";
            this.SelectedEdition.Name = "SelectedEdition";
            // 
            // SelectedPublisher
            // 
            this.SelectedPublisher.DataPropertyName = "Publisher";
            this.SelectedPublisher.HeaderText = "Publisher";
            this.SelectedPublisher.Name = "SelectedPublisher";
            // 
            // SelectedCount
            // 
            this.SelectedCount.DataPropertyName = "Count";
            this.SelectedCount.HeaderText = "Count";
            this.SelectedCount.Name = "SelectedCount";
            // 
            // SelectedOriginalPrice
            // 
            this.SelectedOriginalPrice.DataPropertyName = "OriginalPrice";
            this.SelectedOriginalPrice.HeaderText = "OriginalPrice";
            this.SelectedOriginalPrice.Name = "SelectedOriginalPrice";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Discount";
            this.dataGridViewTextBoxColumn9.HeaderText = "Discount";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Visible = false;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "PurchasePrice";
            this.dataGridViewTextBoxColumn10.HeaderText = "PurchasePrice";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "PriceChangable";
            this.dataGridViewTextBoxColumn11.HeaderText = "PriceChangable";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.Visible = false;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "OutCount";
            this.dataGridViewTextBoxColumn12.HeaderText = "OutCount";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.Visible = false;
            // 
            // dataGridViewButtonColumn1
            // 
            this.dataGridViewButtonColumn1.HeaderText = "Remove";
            this.dataGridViewButtonColumn1.Name = "dataGridViewButtonColumn1";
            this.dataGridViewButtonColumn1.Text = "Remove";
            this.dataGridViewButtonColumn1.UseColumnTextForButtonValue = true;
            // 
            // frmChooseStockItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1044, 528);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.KeyPreview = true;
            this.Name = "frmChooseStockItem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Choose Stock Item";
            ((System.ComponentModel.ISupportInitialize)(this.ctStockBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bLSSchema)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ctStockSearchDataTableBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctStockSearchDataTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctStockBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelectedBooks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStockSearchResult)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn Count;
        private System.Windows.Forms.DataGridViewTextBoxColumn OriginalPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Discount;
        private System.Windows.Forms.DataGridViewTextBoxColumn PurchasePrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceChangable;
        private System.Windows.Forms.DataGridViewTextBoxColumn OutCount;
        private System.Windows.Forms.DataGridViewButtonColumn Issue;
        private System.Windows.Forms.BindingSource ctStockBindingSource1;
        private BLSSchema bLSSchema;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.BindingSource ctStockSearchDataTableBindingSource1;
        private System.Windows.Forms.BindingSource ctStockSearchDataTableBindingSource;
        private System.Windows.Forms.BindingSource ctStockBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn Publisher;
        private System.Windows.Forms.DataGridViewTextBoxColumn Edition;
        private System.Windows.Forms.TextBox txtEdition;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chkMatchExact;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPublisher;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRecordCount;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvStockSearchResult;
        private System.Windows.Forms.DataGridViewTextBoxColumn ISBN;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Author;
        private System.Windows.Forms.DataGridViewTextBoxColumn Year;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DataGridView dgvSelectedBooks;
        private System.Windows.Forms.Button btnSelectionDone;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn SelectedTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn SelectedAuthor;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn SelectedEdition;
        private System.Windows.Forms.DataGridViewTextBoxColumn SelectedPublisher;
        private System.Windows.Forms.DataGridViewTextBoxColumn SelectedCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn SelectedOriginalPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewButtonColumn1;

    }
}