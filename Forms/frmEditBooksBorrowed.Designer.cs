namespace LibraryDesign_frontEndUI.Forms
{
    partial class frmEditBooksBorrowed
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditBooksBorrowed));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ctStockDataTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvStudentIssuedBooks = new System.Windows.Forms.DataGridView();
            this.HistoryUID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ITitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IAuthor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IEdition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IPublisher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IssueDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RecieptNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IssueType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Returndate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EarlyIssue = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Remove = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ctIssueDataTableBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.ctIssueDataTableBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.txtMemberShipID = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbMonth = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.ctIssueDataTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ctIssueRowBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvStudentBooks = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.ctStockDataTableBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.iSBNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Publisher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceChangableDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.originalPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchasePriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastUpdatedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.outCountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ctStockDataTableBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentIssuedBooks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctIssueDataTableBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctIssueDataTableBindingSource1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ctIssueDataTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctIssueRowBindingSource)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentBooks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctStockDataTableBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // ctStockDataTableBindingSource
            // 
            this.ctStockDataTableBindingSource.DataSource = typeof(LibraryDesign_frontEndUI.BLSSchema.ctStockDataTable);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvStudentIssuedBooks);
            this.groupBox2.Location = new System.Drawing.Point(8, 83);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(997, 181);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
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
            this.IPublisher,
            this.IssueDate,
            this.BookCount,
            this.BookPrice,
            this.RecieptNumber,
            this.IssueType,
            this.Returndate,
            this.EarlyIssue,
            this.Remove});
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
            this.dgvStudentIssuedBooks.Size = new System.Drawing.Size(991, 162);
            this.dgvStudentIssuedBooks.TabIndex = 0;
            this.dgvStudentIssuedBooks.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvStudentIssuedBooks_CellFormatting);
            this.dgvStudentIssuedBooks.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvStudentIssuedBooks_CellMouseClick);
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
            // IPublisher
            // 
            this.IPublisher.DataPropertyName = "Publisher";
            this.IPublisher.HeaderText = "Publisher";
            this.IPublisher.Name = "IPublisher";
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
            // 
            // Remove
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.Remove.DefaultCellStyle = dataGridViewCellStyle1;
            this.Remove.HeaderText = "Remove";
            this.Remove.Name = "Remove";
            this.Remove.Text = "Remove";
            this.Remove.UseColumnTextForButtonValue = true;
            // 
            // ctIssueDataTableBindingSource2
            // 
            this.ctIssueDataTableBindingSource2.DataSource = typeof(LibraryDesign_frontEndUI.BLSSchema.ctIssueDataTable);
            // 
            // ctIssueDataTableBindingSource1
            // 
            this.ctIssueDataTableBindingSource1.DataSource = typeof(LibraryDesign_frontEndUI.BLSSchema.ctIssueDataTable);
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(753, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 36);
            this.button1.TabIndex = 7;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtMemberShipID
            // 
            this.txtMemberShipID.Location = new System.Drawing.Point(132, 18);
            this.txtMemberShipID.Name = "txtMemberShipID";
            this.txtMemberShipID.ReadOnly = true;
            this.txtMemberShipID.Size = new System.Drawing.Size(104, 20);
            this.txtMemberShipID.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(21, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(105, 16);
            this.label9.TabIndex = 1;
            this.label9.Text = "MemberShip ID :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbMonth);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txtMemberShipID);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Location = new System.Drawing.Point(8, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(997, 54);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
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
            this.cmbMonth.Location = new System.Drawing.Point(365, 16);
            this.cmbMonth.Name = "cmbMonth";
            this.cmbMonth.Size = new System.Drawing.Size(121, 21);
            this.cmbMonth.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(265, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Return Month :";
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(872, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(117, 36);
            this.button2.TabIndex = 8;
            this.button2.Text = "Done";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ctIssueDataTableBindingSource
            // 
            this.ctIssueDataTableBindingSource.DataSource = typeof(LibraryDesign_frontEndUI.BLSSchema.ctIssueDataTable);
            // 
            // ctIssueRowBindingSource
            // 
            this.ctIssueRowBindingSource.DataSource = typeof(LibraryDesign_frontEndUI.BLSSchema.ctIssueRow);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvStudentBooks);
            this.groupBox3.Location = new System.Drawing.Point(8, 270);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(997, 259);
            this.groupBox3.TabIndex = 22;
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
            this.Title,
            this.Author,
            this.Year,
            this.Edition,
            this.Publisher,
            this.Count,
            this.priceChangableDataGridViewTextBoxColumn,
            this.originalPriceDataGridViewTextBoxColumn,
            this.discountDataGridViewTextBoxColumn,
            this.purchasePriceDataGridViewTextBoxColumn,
            this.lastUpdatedDataGridViewTextBoxColumn,
            this.outCountDataGridViewTextBoxColumn});
            this.dgvStudentBooks.DataSource = this.ctStockDataTableBindingSource1;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStudentBooks.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvStudentBooks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStudentBooks.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvStudentBooks.Location = new System.Drawing.Point(3, 16);
            this.dgvStudentBooks.Name = "dgvStudentBooks";
            this.dgvStudentBooks.Size = new System.Drawing.Size(991, 240);
            this.dgvStudentBooks.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(9, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 19);
            this.label1.TabIndex = 9;
            this.label1.Text = "Books Issued :";
            // 
            // ctStockDataTableBindingSource1
            // 
            this.ctStockDataTableBindingSource1.DataSource = typeof(LibraryDesign_frontEndUI.BLSSchema.ctStockDataTable);
            // 
            // iSBNDataGridViewTextBoxColumn
            // 
            this.iSBNDataGridViewTextBoxColumn.DataPropertyName = "ISBN";
            this.iSBNDataGridViewTextBoxColumn.HeaderText = "ISBN";
            this.iSBNDataGridViewTextBoxColumn.Name = "iSBNDataGridViewTextBoxColumn";
            this.iSBNDataGridViewTextBoxColumn.Visible = false;
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
            // Edition
            // 
            this.Edition.DataPropertyName = "Edition";
            this.Edition.HeaderText = "Edition";
            this.Edition.Name = "Edition";
            // 
            // Publisher
            // 
            this.Publisher.DataPropertyName = "Publisher";
            this.Publisher.HeaderText = "Publisher";
            this.Publisher.Name = "Publisher";
            // 
            // Count
            // 
            this.Count.DataPropertyName = "Count";
            this.Count.HeaderText = "Count";
            this.Count.Name = "Count";
            this.Count.Visible = false;
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
            this.outCountDataGridViewTextBoxColumn.HeaderText = "Count";
            this.outCountDataGridViewTextBoxColumn.Name = "outCountDataGridViewTextBoxColumn";
            // 
            // frmEditBooksBorrowed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1009, 541);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmEditBooksBorrowed";
            this.Text = "Edit Books Borrowed";
            this.Activated += new System.EventHandler(this.frmEditBooksBorrowed_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.ctStockDataTableBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentIssuedBooks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctIssueDataTableBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctIssueDataTableBindingSource1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ctIssueDataTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctIssueRowBindingSource)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentBooks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctStockDataTableBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource ctStockDataTableBindingSource;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtMemberShipID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.BindingSource ctIssueDataTableBindingSource;
        private System.Windows.Forms.BindingSource ctIssueDataTableBindingSource1;
        private System.Windows.Forms.BindingSource ctIssueRowBindingSource;
        private System.Windows.Forms.DataGridView dgvStudentIssuedBooks;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvStudentBooks;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbMonth;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn HistoryUID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ITitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn IAuthor;
        private System.Windows.Forms.DataGridViewTextBoxColumn IEdition;
        private System.Windows.Forms.DataGridViewTextBoxColumn IPublisher;
        private System.Windows.Forms.DataGridViewTextBoxColumn IssueDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn RecieptNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn IssueType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Returndate;
        private System.Windows.Forms.DataGridViewCheckBoxColumn EarlyIssue;
        private System.Windows.Forms.DataGridViewTextBoxColumn PurchasePrice;
        private System.Windows.Forms.DataGridViewButtonColumn Remove;
        private System.Windows.Forms.BindingSource ctIssueDataTableBindingSource2;
        private System.Windows.Forms.BindingSource ctStockDataTableBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iSBNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Author;
        private System.Windows.Forms.DataGridViewTextBoxColumn Year;
        private System.Windows.Forms.DataGridViewTextBoxColumn Edition;
        private System.Windows.Forms.DataGridViewTextBoxColumn Publisher;
        private System.Windows.Forms.DataGridViewTextBoxColumn Count;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceChangableDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn originalPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn discountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn purchasePriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastUpdatedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn outCountDataGridViewTextBoxColumn;
    }
}