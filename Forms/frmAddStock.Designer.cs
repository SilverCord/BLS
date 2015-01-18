namespace LibraryDesign_frontEndUI
{
    partial class frmAddStock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddStock));
            this.btnAddStock = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblEdition = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.cmbPriceChangable = new System.Windows.Forms.ComboBox();
            this.cmbYear = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPublisher = new System.Windows.Forms.TextBox();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.txtEdition = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.txtCount = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddStock
            // 
            this.btnAddStock.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddStock.BackgroundImage")));
            this.btnAddStock.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddStock.Location = new System.Drawing.Point(351, 4);
            this.btnAddStock.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddStock.Name = "btnAddStock";
            this.btnAddStock.Size = new System.Drawing.Size(168, 60);
            this.btnAddStock.TabIndex = 11;
            this.btnAddStock.Text = "ADD";
            this.btnAddStock.UseVisualStyleBackColor = true;
            this.btnAddStock.Click += new System.EventHandler(this.btnAddStock_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnReset.BackgroundImage")));
            this.btnReset.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(3, 4);
            this.btnReset.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(168, 60);
            this.btnReset.TabIndex = 10;
            this.btnReset.Text = "RESET";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancel.BackgroundImage")));
            this.btnCancel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(525, 4);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(169, 60);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.btnCancel, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnAddStock, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnReset, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnBrowse, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 245);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(697, 68);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // btnBrowse
            // 
            this.btnBrowse.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBrowse.BackgroundImage")));
            this.btnBrowse.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowse.Location = new System.Drawing.Point(177, 4);
            this.btnBrowse.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(168, 60);
            this.btnBrowse.TabIndex = 10;
            this.btnBrowse.Text = "BROWSE STOCK";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblPrice);
            this.groupBox1.Controls.Add(this.lblEdition);
            this.groupBox1.Controls.Add(this.lblAuthor);
            this.groupBox1.Controls.Add(this.lblTitle);
            this.groupBox1.Controls.Add(this.cmbPriceChangable);
            this.groupBox1.Controls.Add(this.cmbYear);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtPublisher);
            this.groupBox1.Controls.Add(this.txtDiscount);
            this.groupBox1.Controls.Add(this.txtEdition);
            this.groupBox1.Controls.Add(this.txtPrice);
            this.groupBox1.Controls.Add(this.txtAuthor);
            this.groupBox1.Controls.Add(this.txtCount);
            this.groupBox1.Controls.Add(this.txtTitle);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(697, 245);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.ForeColor = System.Drawing.Color.Lime;
            this.lblPrice.Location = new System.Drawing.Point(661, 94);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(26, 31);
            this.lblPrice.TabIndex = 10;
            this.lblPrice.Text = "*";
            // 
            // lblEdition
            // 
            this.lblEdition.AutoSize = true;
            this.lblEdition.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdition.ForeColor = System.Drawing.Color.Lime;
            this.lblEdition.Location = new System.Drawing.Point(405, 128);
            this.lblEdition.Name = "lblEdition";
            this.lblEdition.Size = new System.Drawing.Size(26, 31);
            this.lblEdition.TabIndex = 10;
            this.lblEdition.Text = "*";
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuthor.ForeColor = System.Drawing.Color.Lime;
            this.lblAuthor.Location = new System.Drawing.Point(404, 78);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(26, 31);
            this.lblAuthor.TabIndex = 10;
            this.lblAuthor.Text = "*";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Lime;
            this.lblTitle.Location = new System.Drawing.Point(404, 28);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(26, 31);
            this.lblTitle.TabIndex = 10;
            this.lblTitle.Text = "*";
            // 
            // cmbPriceChangable
            // 
            this.cmbPriceChangable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPriceChangable.FormattingEnabled = true;
            this.cmbPriceChangable.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.cmbPriceChangable.Location = new System.Drawing.Point(553, 188);
            this.cmbPriceChangable.Name = "cmbPriceChangable";
            this.cmbPriceChangable.Size = new System.Drawing.Size(104, 24);
            this.cmbPriceChangable.TabIndex = 9;
            // 
            // cmbYear
            // 
            this.cmbYear.FormattingEnabled = true;
            this.cmbYear.Items.AddRange(new object[] {
            "2020",
            "2019",
            "2018",
            "2017",
            "2016",
            "2015",
            "2014",
            "2013",
            "2012",
            "2011",
            "2010",
            "2009",
            "2008",
            "2007",
            "2006",
            "2005",
            "2004",
            "2003",
            "2002",
            "2001",
            "2000",
            "1999",
            "1998",
            "1997",
            "1996",
            "1995",
            "1994",
            "1993",
            "1992",
            "1991",
            "1990",
            "1989",
            "1988",
            "1987",
            "1986",
            "1985",
            "1984",
            "1983",
            "1982",
            "1981",
            "1980"});
            this.cmbYear.Location = new System.Drawing.Point(554, 20);
            this.cmbYear.Name = "cmbYear";
            this.cmbYear.Size = new System.Drawing.Size(106, 24);
            this.cmbYear.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "Publisher :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Edition :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Author :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Title :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(428, 188);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(109, 16);
            this.label10.TabIndex = 1;
            this.label10.Text = "Price Changable :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(470, 145);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 16);
            this.label9.TabIndex = 1;
            this.label9.Text = "Discount :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(664, 147);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(20, 16);
            this.label11.TabIndex = 1;
            this.label11.Text = "%";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(491, 100);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 16);
            this.label8.TabIndex = 1;
            this.label8.Text = "Price :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(487, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 16);
            this.label7.TabIndex = 1;
            this.label7.Text = "Count :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(494, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 16);
            this.label6.TabIndex = 1;
            this.label6.Text = "Year :";
            // 
            // txtPublisher
            // 
            this.txtPublisher.Location = new System.Drawing.Point(78, 179);
            this.txtPublisher.MaxLength = 100;
            this.txtPublisher.Name = "txtPublisher";
            this.txtPublisher.Size = new System.Drawing.Size(318, 23);
            this.txtPublisher.TabIndex = 4;
            this.txtPublisher.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Name_Validation);
            // 
            // txtDiscount
            // 
            this.txtDiscount.Location = new System.Drawing.Point(554, 145);
            this.txtDiscount.MaxLength = 2;
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(104, 23);
            this.txtDiscount.TabIndex = 8;
            this.txtDiscount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Number_Validation);
            // 
            // txtEdition
            // 
            this.txtEdition.Location = new System.Drawing.Point(78, 128);
            this.txtEdition.MaxLength = 100;
            this.txtEdition.Name = "txtEdition";
            this.txtEdition.Size = new System.Drawing.Size(318, 23);
            this.txtEdition.TabIndex = 3;
            this.txtEdition.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Name_Validation);
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(554, 100);
            this.txtPrice.MaxLength = 10;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(104, 23);
            this.txtPrice.TabIndex = 7;
            this.txtPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Amount_Validation);
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(79, 75);
            this.txtAuthor.MaxLength = 100;
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(320, 23);
            this.txtAuthor.TabIndex = 2;
            this.txtAuthor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Name_Validation);
            // 
            // txtCount
            // 
            this.txtCount.Location = new System.Drawing.Point(554, 57);
            this.txtCount.MaxLength = 4;
            this.txtCount.Name = "txtCount";
            this.txtCount.Size = new System.Drawing.Size(104, 23);
            this.txtCount.TabIndex = 6;
            this.txtCount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Number_Validation);
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(78, 28);
            this.txtTitle.MaxLength = 100;
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(318, 23);
            this.txtTitle.TabIndex = 1;
            this.txtTitle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Name_Validation);
            // 
            // frmAddStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(697, 313);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmAddStock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stock";
            this.Load += new System.EventHandler(this.frmAddStock_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddStock;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbPriceChangable;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblEdition;
        internal System.Windows.Forms.TextBox txtPublisher;
        internal System.Windows.Forms.TextBox txtEdition;
        internal System.Windows.Forms.TextBox txtPrice;
        internal System.Windows.Forms.TextBox txtAuthor;
        internal System.Windows.Forms.TextBox txtCount;
        internal System.Windows.Forms.TextBox txtTitle;
        internal System.Windows.Forms.ComboBox cmbYear;
        private System.Windows.Forms.Button btnBrowse;
        internal System.Windows.Forms.TextBox txtDiscount;
    }
}

