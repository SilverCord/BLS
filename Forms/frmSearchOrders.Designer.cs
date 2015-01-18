namespace LibraryDesign_frontEndUI
{
    partial class frmSearchOrders
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSearchOrders));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvOrders = new System.Windows.Forms.DataGridView();
            this.customerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iSBNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.depositAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderClearanceDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobileDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ctOrdersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bLSSchema = new LibraryDesign_frontEndUI.BLSSchema();
            this.ctCustomerDataTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblCustomerStatus = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.dtpToDate = new System.Windows.Forms.DateTimePicker();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpFromDate = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.ctStockSearchDataTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctOrdersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bLSSchema)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctCustomerDataTableBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ctStockSearchDataTableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.dgvOrders);
            this.groupBox2.Location = new System.Drawing.Point(1, 85);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1057, 339);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            // 
            // dgvOrders
            // 
            this.dgvOrders.AllowUserToAddRows = false;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            this.dgvOrders.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvOrders.AutoGenerateColumns = false;
            this.dgvOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightPink;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOrders.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customerIDDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.iSBNDataGridViewTextBoxColumn,
            this.countDataGridViewTextBoxColumn,
            this.depositAmountDataGridViewTextBoxColumn,
            this.orderClearanceDateDataGridViewTextBoxColumn,
            this.mobileDataGridViewTextBoxColumn});
            this.dgvOrders.DataSource = this.ctOrdersBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvOrders.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOrders.Location = new System.Drawing.Point(3, 16);
            this.dgvOrders.Name = "dgvOrders";
            this.dgvOrders.Size = new System.Drawing.Size(1051, 320);
            this.dgvOrders.TabIndex = 11;
            // 
            // customerIDDataGridViewTextBoxColumn
            // 
            this.customerIDDataGridViewTextBoxColumn.DataPropertyName = "CustomerID";
            this.customerIDDataGridViewTextBoxColumn.HeaderText = "CustomerID";
            this.customerIDDataGridViewTextBoxColumn.Name = "customerIDDataGridViewTextBoxColumn";
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            // 
            // iSBNDataGridViewTextBoxColumn
            // 
            this.iSBNDataGridViewTextBoxColumn.DataPropertyName = "ISBN";
            this.iSBNDataGridViewTextBoxColumn.HeaderText = "ISBN";
            this.iSBNDataGridViewTextBoxColumn.Name = "iSBNDataGridViewTextBoxColumn";
            // 
            // countDataGridViewTextBoxColumn
            // 
            this.countDataGridViewTextBoxColumn.DataPropertyName = "Count";
            this.countDataGridViewTextBoxColumn.HeaderText = "Count";
            this.countDataGridViewTextBoxColumn.Name = "countDataGridViewTextBoxColumn";
            // 
            // depositAmountDataGridViewTextBoxColumn
            // 
            this.depositAmountDataGridViewTextBoxColumn.DataPropertyName = "DepositAmount";
            this.depositAmountDataGridViewTextBoxColumn.HeaderText = "DepositAmount";
            this.depositAmountDataGridViewTextBoxColumn.Name = "depositAmountDataGridViewTextBoxColumn";
            // 
            // orderClearanceDateDataGridViewTextBoxColumn
            // 
            this.orderClearanceDateDataGridViewTextBoxColumn.DataPropertyName = "OrderClearanceDate";
            this.orderClearanceDateDataGridViewTextBoxColumn.HeaderText = "OrderClearanceDate";
            this.orderClearanceDateDataGridViewTextBoxColumn.Name = "orderClearanceDateDataGridViewTextBoxColumn";
            // 
            // mobileDataGridViewTextBoxColumn
            // 
            this.mobileDataGridViewTextBoxColumn.DataPropertyName = "Mobile";
            this.mobileDataGridViewTextBoxColumn.HeaderText = "Mobile";
            this.mobileDataGridViewTextBoxColumn.Name = "mobileDataGridViewTextBoxColumn";
            // 
            // ctOrdersBindingSource
            // 
            this.ctOrdersBindingSource.DataMember = "ctOrders";
            this.ctOrdersBindingSource.DataSource = this.bLSSchema;
            // 
            // bLSSchema
            // 
            this.bLSSchema.DataSetName = "BLSSchema";
            this.bLSSchema.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ctCustomerDataTableBindingSource
            // 
            this.ctCustomerDataTableBindingSource.DataSource = typeof(LibraryDesign_frontEndUI.BLSSchema.ctCustomerDataTable);
            // 
            // lblCustomerStatus
            // 
            this.lblCustomerStatus.AutoSize = true;
            this.lblCustomerStatus.ForeColor = System.Drawing.Color.White;
            this.lblCustomerStatus.Location = new System.Drawing.Point(41, 376);
            this.lblCustomerStatus.Name = "lblCustomerStatus";
            this.lblCustomerStatus.Size = new System.Drawing.Size(166, 13);
            this.lblCustomerStatus.TabIndex = 27;
            this.lblCustomerStatus.Text = "1234564gfhghgfhgfhfghfghfghfgh";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1064, 81);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 6;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.40541F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54.59459F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 72F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 378F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 211F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 209F));
            this.tableLayoutPanel2.Controls.Add(this.dtpToDate, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnSearch, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.label1, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.dtpFromDate, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label12, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnCancel, 5, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1058, 62);
            this.tableLayoutPanel2.TabIndex = 21;
            // 
            // dtpToDate
            // 
            this.dtpToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpToDate.Location = new System.Drawing.Point(262, 3);
            this.dtpToDate.Name = "dtpToDate";
            this.dtpToDate.Size = new System.Drawing.Size(98, 20);
            this.dtpToDate.TabIndex = 20;
            // 
            // btnSearch
            // 
            this.btnSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSearch.BackgroundImage")));
            this.btnSearch.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(640, 4);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(205, 54);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(190, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 16);
            this.label1.TabIndex = 19;
            this.label1.Text = "To Date :";
            // 
            // dtpFromDate
            // 
            this.dtpFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFromDate.Location = new System.Drawing.Point(88, 3);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.Size = new System.Drawing.Size(89, 20);
            this.dtpFromDate.TabIndex = 20;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label12.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(3, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(79, 62);
            this.label12.TabIndex = 18;
            this.label12.Text = "From Date :";
            // 
            // btnCancel
            // 
            this.btnCancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancel.BackgroundImage")));
            this.btnCancel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(851, 4);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(183, 54);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // ctStockSearchDataTableBindingSource
            // 
            this.ctStockSearchDataTableBindingSource.DataSource = typeof(LibraryDesign_frontEndUI.BLSSchema.ctStockSearchDataTable);
            // 
            // frmSearchOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1064, 426);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lblCustomerStatus);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmSearchOrders";
            this.Text = "frmSearchOrders";
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctOrdersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bLSSchema)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctCustomerDataTableBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ctStockSearchDataTableBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvOrders;
        private System.Windows.Forms.BindingSource ctCustomerDataTableBindingSource;
        private System.Windows.Forms.Label lblCustomerStatus;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpToDate;
        private System.Windows.Forms.DateTimePicker dtpFromDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.BindingSource ctStockSearchDataTableBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iSBNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn depositAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderClearanceDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobileDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource ctOrdersBindingSource;
        private BLSSchema bLSSchema;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    }
}