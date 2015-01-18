namespace LibraryDesign_frontEndUI
{
    partial class frmSellStockSearch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSellStockSearch));
            this.dgvSellStockSearch = new System.Windows.Forms.DataGridView();
            this.ISBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Publisher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceChangable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OriginalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PurchasePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastUpdated = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ctStockDataTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnPlace = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSellStockSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctStockDataTableBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvSellStockSearch
            // 
            this.dgvSellStockSearch.AllowUserToAddRows = false;
            this.dgvSellStockSearch.AutoGenerateColumns = false;
            this.dgvSellStockSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSellStockSearch.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ISBN,
            this.Title,
            this.Author,
            this.Year,
            this.Edition,
            this.Publisher,
            this.Count,
            this.PriceChangable,
            this.OriginalPrice,
            this.Discount,
            this.PurchasePrice,
            this.LastUpdated});
            this.dgvSellStockSearch.DataSource = this.ctStockDataTableBindingSource;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSellStockSearch.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSellStockSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSellStockSearch.Location = new System.Drawing.Point(0, 0);
            this.dgvSellStockSearch.Name = "dgvSellStockSearch";
            this.dgvSellStockSearch.Size = new System.Drawing.Size(1116, 299);
            this.dgvSellStockSearch.TabIndex = 0;
            this.dgvSellStockSearch.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvSellStockSearch_CellMouseClick);
            // 
            // ISBN
            // 
            this.ISBN.DataPropertyName = "ISBN";
            this.ISBN.HeaderText = "ISBN";
            this.ISBN.Name = "ISBN";
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
            // PriceChangable
            // 
            this.PriceChangable.DataPropertyName = "PriceChangable";
            this.PriceChangable.HeaderText = "PriceChangable";
            this.PriceChangable.Name = "PriceChangable";
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
            // 
            // PurchasePrice
            // 
            this.PurchasePrice.DataPropertyName = "PurchasePrice";
            this.PurchasePrice.HeaderText = "PurchasePrice";
            this.PurchasePrice.Name = "PurchasePrice";
            // 
            // LastUpdated
            // 
            this.LastUpdated.DataPropertyName = "LastUpdated";
            this.LastUpdated.HeaderText = "LastUpdated";
            this.LastUpdated.Name = "LastUpdated";
            // 
            // ctStockDataTableBindingSource
            // 
            this.ctStockDataTableBindingSource.DataSource = typeof(LibraryDesign_frontEndUI.BLSSchema.ctStockDataTable);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvSellStockSearch);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1116, 299);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tableLayoutPanel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 305);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1116, 49);
            this.panel2.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Controls.Add(this.btnPlace, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.button1, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1116, 49);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnPlace
            // 
            this.btnPlace.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPlace.BackgroundImage")));
            this.btnPlace.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPlace.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlace.ForeColor = System.Drawing.Color.White;
            this.btnPlace.Location = new System.Drawing.Point(558, 3);
            this.btnPlace.Name = "btnPlace";
            this.btnPlace.Size = new System.Drawing.Size(179, 43);
            this.btnPlace.TabIndex = 1;
            this.btnPlace.Text = "Cancel";
            this.btnPlace.UseVisualStyleBackColor = true;
            this.btnPlace.Click += new System.EventHandler(this.btnPlace_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(373, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(179, 43);
            this.button1.TabIndex = 2;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmSellStockSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1116, 354);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "frmSellStockSearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search Results";
            this.Load += new System.EventHandler(this.frmSellStockSearch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSellStockSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctStockDataTableBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSellStockSearch;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnPlace;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource ctStockDataTableBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn ISBN;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Author;
        private System.Windows.Forms.DataGridViewTextBoxColumn Year;
        private System.Windows.Forms.DataGridViewTextBoxColumn Edition;
        private System.Windows.Forms.DataGridViewTextBoxColumn Publisher;
        private System.Windows.Forms.DataGridViewTextBoxColumn Count;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceChangable;
        private System.Windows.Forms.DataGridViewTextBoxColumn OriginalPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Discount;
        private System.Windows.Forms.DataGridViewTextBoxColumn PurchasePrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastUpdated;
    }
}