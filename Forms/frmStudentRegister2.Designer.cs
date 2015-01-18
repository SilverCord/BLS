namespace LibraryDesign_frontEndUI.Forms
{
    partial class frmStudentRegister2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStudentRegister2));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbMonth = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAdvance = new System.Windows.Forms.TextBox();
            this.Advance = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtMobile = new System.Windows.Forms.TextBox();
            this.txtBalanceAmount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvStudentBooks = new System.Windows.Forms.DataGridView();
            this.ISBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Publisher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceChangableDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OriginalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PurchasePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastUpdatedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OutCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Remove = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ctStockBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bLSSchema = new LibraryDesign_frontEndUI.BLSSchema();
            this.ctStockDataTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnDone = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentBooks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctStockBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bLSSchema)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctStockDataTableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbMonth);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtAdvance);
            this.groupBox1.Controls.Add(this.Advance);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txtMobile);
            this.groupBox1.Controls.Add(this.txtBalanceAmount);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtFirstName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Location = new System.Drawing.Point(21, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1112, 84);
            this.groupBox1.TabIndex = 0;
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
            this.cmbMonth.Location = new System.Drawing.Point(893, 35);
            this.cmbMonth.Name = "cmbMonth";
            this.cmbMonth.Size = new System.Drawing.Size(121, 21);
            this.cmbMonth.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(793, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Return Month :";
            // 
            // txtAdvance
            // 
            this.txtAdvance.Location = new System.Drawing.Point(489, 54);
            this.txtAdvance.Name = "txtAdvance";
            this.txtAdvance.ReadOnly = true;
            this.txtAdvance.Size = new System.Drawing.Size(276, 20);
            this.txtAdvance.TabIndex = 9;
            // 
            // Advance
            // 
            this.Advance.AutoSize = true;
            this.Advance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Advance.ForeColor = System.Drawing.Color.White;
            this.Advance.Location = new System.Drawing.Point(404, 55);
            this.Advance.Name = "Advance";
            this.Advance.Size = new System.Drawing.Size(65, 16);
            this.Advance.TabIndex = 8;
            this.Advance.Text = "Advance :";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1041, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(52, 31);
            this.button1.TabIndex = 7;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtMobile
            // 
            this.txtMobile.Location = new System.Drawing.Point(78, 54);
            this.txtMobile.Name = "txtMobile";
            this.txtMobile.ReadOnly = true;
            this.txtMobile.Size = new System.Drawing.Size(276, 20);
            this.txtMobile.TabIndex = 6;
            // 
            // txtBalanceAmount
            // 
            this.txtBalanceAmount.Location = new System.Drawing.Point(489, 16);
            this.txtBalanceAmount.Name = "txtBalanceAmount";
            this.txtBalanceAmount.ReadOnly = true;
            this.txtBalanceAmount.Size = new System.Drawing.Size(276, 20);
            this.txtBalanceAmount.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(404, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Balance :";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(78, 16);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.ReadOnly = true;
            this.txtFirstName.Size = new System.Drawing.Size(276, 20);
            this.txtFirstName.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(18, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mobile :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(22, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 16);
            this.label9.TabIndex = 1;
            this.label9.Text = "Name :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvStudentBooks);
            this.groupBox2.Location = new System.Drawing.Point(21, 102);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1112, 338);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // dgvStudentBooks
            // 
            this.dgvStudentBooks.AllowUserToAddRows = false;
            this.dgvStudentBooks.AllowUserToDeleteRows = false;
            this.dgvStudentBooks.AutoGenerateColumns = false;
            this.dgvStudentBooks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStudentBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudentBooks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ISBN,
            this.Title,
            this.Author,
            this.Year,
            this.Edition,
            this.Publisher,
            this.Count,
            this.priceChangableDataGridViewTextBoxColumn,
            this.OriginalPrice,
            this.discountDataGridViewTextBoxColumn,
            this.PurchasePrice,
            this.lastUpdatedDataGridViewTextBoxColumn,
            this.OutCount,
            this.Remove});
            this.dgvStudentBooks.DataSource = this.ctStockBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStudentBooks.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvStudentBooks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStudentBooks.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvStudentBooks.Location = new System.Drawing.Point(3, 16);
            this.dgvStudentBooks.Name = "dgvStudentBooks";
            this.dgvStudentBooks.Size = new System.Drawing.Size(1106, 319);
            this.dgvStudentBooks.TabIndex = 0;
            this.dgvStudentBooks.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvStudentBooks_CellMouseClick);
            this.dgvStudentBooks.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvStudentBooks_RowPostPaint);
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
            this.Count.Visible = false;
            // 
            // priceChangableDataGridViewTextBoxColumn
            // 
            this.priceChangableDataGridViewTextBoxColumn.DataPropertyName = "PriceChangable";
            this.priceChangableDataGridViewTextBoxColumn.HeaderText = "PriceChangable";
            this.priceChangableDataGridViewTextBoxColumn.Name = "priceChangableDataGridViewTextBoxColumn";
            this.priceChangableDataGridViewTextBoxColumn.Visible = false;
            // 
            // OriginalPrice
            // 
            this.OriginalPrice.DataPropertyName = "OriginalPrice";
            this.OriginalPrice.HeaderText = "OriginalPrice";
            this.OriginalPrice.Name = "OriginalPrice";
            // 
            // discountDataGridViewTextBoxColumn
            // 
            this.discountDataGridViewTextBoxColumn.DataPropertyName = "Discount";
            this.discountDataGridViewTextBoxColumn.HeaderText = "Discount";
            this.discountDataGridViewTextBoxColumn.Name = "discountDataGridViewTextBoxColumn";
            this.discountDataGridViewTextBoxColumn.Visible = false;
            // 
            // PurchasePrice
            // 
            this.PurchasePrice.DataPropertyName = "PurchasePrice";
            this.PurchasePrice.HeaderText = "PurchasePrice";
            this.PurchasePrice.Name = "PurchasePrice";
            // 
            // lastUpdatedDataGridViewTextBoxColumn
            // 
            this.lastUpdatedDataGridViewTextBoxColumn.DataPropertyName = "LastUpdated";
            this.lastUpdatedDataGridViewTextBoxColumn.HeaderText = "LastUpdated";
            this.lastUpdatedDataGridViewTextBoxColumn.Name = "lastUpdatedDataGridViewTextBoxColumn";
            this.lastUpdatedDataGridViewTextBoxColumn.Visible = false;
            // 
            // OutCount
            // 
            this.OutCount.DataPropertyName = "OutCount";
            this.OutCount.HeaderText = "Count";
            this.OutCount.Name = "OutCount";
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
            // ctStockBindingSource
            // 
            this.ctStockBindingSource.DataMember = "ctStock";
            this.ctStockBindingSource.DataSource = this.bLSSchema;
            // 
            // bLSSchema
            // 
            this.bLSSchema.DataSetName = "BLSSchema";
            this.bLSSchema.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ctStockDataTableBindingSource
            // 
            this.ctStockDataTableBindingSource.DataSource = typeof(LibraryDesign_frontEndUI.BLSSchema.ctStockDataTable);
            // 
            // btnDone
            // 
            this.btnDone.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDone.BackgroundImage")));
            this.btnDone.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDone.ForeColor = System.Drawing.Color.White;
            this.btnDone.Location = new System.Drawing.Point(470, 446);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(157, 38);
            this.btnDone.TabIndex = 19;
            this.btnDone.TabStop = false;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // frmStudentRegister2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1145, 496);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmStudentRegister2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Books Borrowed";
            this.Activated += new System.EventHandler(this.frmStudentRegister2_Activated);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentBooks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctStockBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bLSSchema)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctStockDataTableBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.BindingSource ctStockDataTableBindingSource;
        private System.Windows.Forms.TextBox txtMobile;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtAdvance;
        private System.Windows.Forms.Label Advance;
        private System.Windows.Forms.TextBox txtBalanceAmount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource ctStockBindingSource;
        private BLSSchema bLSSchema;
        private System.Windows.Forms.DataGridView dgvStudentBooks;
        private System.Windows.Forms.DataGridViewTextBoxColumn ISBN;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Author;
        private System.Windows.Forms.DataGridViewTextBoxColumn Year;
        private System.Windows.Forms.DataGridViewTextBoxColumn Edition;
        private System.Windows.Forms.DataGridViewTextBoxColumn Publisher;
        private System.Windows.Forms.DataGridViewTextBoxColumn Count;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceChangableDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn OriginalPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn discountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PurchasePrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastUpdatedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn OutCount;
        private System.Windows.Forms.DataGridViewButtonColumn Remove;
        private System.Windows.Forms.ComboBox cmbMonth;
        private System.Windows.Forms.Label label3;
    }
}