namespace LibraryDesign_frontEndUI
{
    partial class frmCustomerSearch1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCustomerSearch1));
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
            this.dgvStockSearchResult = new System.Windows.Forms.DataGridView();
            this.ISBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Publisher = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.btnEditStock = new System.Windows.Forms.Button();
            this.btnDeleteStock = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.ctStockSearchDataTableBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.ctStockSearchDataTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ctStockBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStockSearchResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctStockBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bLSSchema)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ctStockSearchDataTableBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctStockSearchDataTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctStockBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtEdition
            // 
            this.txtEdition.Location = new System.Drawing.Point(62, 65);
            this.txtEdition.Name = "txtEdition";
            this.txtEdition.Size = new System.Drawing.Size(357, 20);
            this.txtEdition.TabIndex = 1;
            this.txtEdition.TextChanged += new System.EventHandler(this.txtEdition_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(814, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Record Count :";
            // 
            // groupBox2
            // 
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
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Criteria";
            // 
            // chkMatchExact
            // 
            this.chkMatchExact.AutoSize = true;
            this.chkMatchExact.Location = new System.Drawing.Point(817, 64);
            this.chkMatchExact.Name = "chkMatchExact";
            this.chkMatchExact.Size = new System.Drawing.Size(86, 17);
            this.chkMatchExact.TabIndex = 4;
            this.chkMatchExact.Text = "Match Exact";
            this.chkMatchExact.UseVisualStyleBackColor = true;
            this.chkMatchExact.CheckedChanged += new System.EventHandler(this.chkMatchExact_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(440, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Publisher :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(440, 72);
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
            this.txtPublisher.Location = new System.Drawing.Point(497, 23);
            this.txtPublisher.Name = "txtPublisher";
            this.txtPublisher.Size = new System.Drawing.Size(293, 20);
            this.txtPublisher.TabIndex = 0;
            this.txtPublisher.TextChanged += new System.EventHandler(this.txtPublisher_TextChanged);
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
            this.txtRecordCount.Location = new System.Drawing.Point(894, 26);
            this.txtRecordCount.MaxLength = 8;
            this.txtRecordCount.Name = "txtRecordCount";
            this.txtRecordCount.Size = new System.Drawing.Size(42, 20);
            this.txtRecordCount.TabIndex = 0;
            this.txtRecordCount.Text = "100";
            this.txtRecordCount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Number_Validation);
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(62, 24);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(357, 20);
            this.txtTitle.TabIndex = 0;
            this.txtTitle.TextChanged += new System.EventHandler(this.txtTitle_TextChanged);
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(497, 62);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(293, 20);
            this.txtAuthor.TabIndex = 0;
            this.txtAuthor.TextChanged += new System.EventHandler(this.txtAuthor_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvStockSearchResult);
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 91);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1044, 437);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkOliveGreen;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStockSearchResult.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvStockSearchResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStockSearchResult.Location = new System.Drawing.Point(3, 16);
            this.dgvStockSearchResult.Name = "dgvStockSearchResult";
            this.dgvStockSearchResult.Size = new System.Drawing.Size(1038, 359);
            this.dgvStockSearchResult.TabIndex = 0;
            this.dgvStockSearchResult.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvStockSearchResult_CellMouseClick);
            this.dgvStockSearchResult.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvStockSearchResult_RowPostPaint);
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
            this.tableLayoutPanel1.Controls.Add(this.btnEditStock, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnDeleteStock, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnSearch, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnCancel, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 375);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1038, 59);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // btnEditStock
            // 
            this.btnEditStock.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEditStock.BackgroundImage")));
            this.btnEditStock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEditStock.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditStock.Location = new System.Drawing.Point(3, 4);
            this.btnEditStock.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEditStock.Name = "btnEditStock";
            this.btnEditStock.Size = new System.Drawing.Size(253, 51);
            this.btnEditStock.TabIndex = 3;
            this.btnEditStock.Text = "Edit";
            this.btnEditStock.UseVisualStyleBackColor = true;
            this.btnEditStock.Visible = false;
            this.btnEditStock.Click += new System.EventHandler(this.btnEditStock_Click);
            // 
            // btnDeleteStock
            // 
            this.btnDeleteStock.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDeleteStock.BackgroundImage")));
            this.btnDeleteStock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDeleteStock.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteStock.Location = new System.Drawing.Point(780, 4);
            this.btnDeleteStock.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDeleteStock.Name = "btnDeleteStock";
            this.btnDeleteStock.Size = new System.Drawing.Size(255, 51);
            this.btnDeleteStock.TabIndex = 3;
            this.btnDeleteStock.Text = "Delete";
            this.btnDeleteStock.UseVisualStyleBackColor = true;
            this.btnDeleteStock.Visible = false;
            this.btnDeleteStock.Click += new System.EventHandler(this.btnDeleteStock_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSearch.BackgroundImage")));
            this.btnSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSearch.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(262, 4);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(253, 51);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
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
            // frmCustomerSearch1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1044, 528);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.KeyPreview = true;
            this.Name = "frmCustomerSearch1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search Stock";
            this.Activated += new System.EventHandler(this.frmCustomerSearch1_Activated);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmCustomerSearch1_KeyPress);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStockSearchResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctStockBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bLSSchema)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ctStockSearchDataTableBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctStockSearchDataTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctStockBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtEdition;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPublisher;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRecordCount;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvStockSearchResult;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.CheckBox chkMatchExact;
        private System.Windows.Forms.BindingSource ctStockSearchDataTableBindingSource;
        private System.Windows.Forms.BindingSource ctStockSearchDataTableBindingSource1;
        private System.Windows.Forms.Button btnEditStock;
        private System.Windows.Forms.Button btnDeleteStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn ISBN;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Author;
        private System.Windows.Forms.DataGridViewTextBoxColumn Year;
        private System.Windows.Forms.DataGridViewTextBoxColumn Edition;
        private System.Windows.Forms.DataGridViewTextBoxColumn Publisher;
        private System.Windows.Forms.DataGridViewTextBoxColumn Count;
        private System.Windows.Forms.DataGridViewTextBoxColumn OriginalPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Discount;
        private System.Windows.Forms.DataGridViewTextBoxColumn PurchasePrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceChangable;
        private System.Windows.Forms.DataGridViewTextBoxColumn OutCount;
        private System.Windows.Forms.DataGridViewButtonColumn Issue;
        private System.Windows.Forms.BindingSource ctStockBindingSource1;
        private BLSSchema bLSSchema;
        private System.Windows.Forms.BindingSource ctStockBindingSource;
    }
}