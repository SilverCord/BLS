namespace LibraryDesign_frontEndUI
{
    partial class frmBuy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBuy));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSearchStock = new System.Windows.Forms.Button();
            this.txtKeyWord = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.lblEdition = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblPublisher = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblISBN = new System.Windows.Forms.Label();
            this.txtDiscount = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnBuy = new System.Windows.Forms.Button();
            this.cmbPriceChangable = new System.Windows.Forms.ComboBox();
            this.cmbYear = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtAdvance = new System.Windows.Forms.TextBox();
            this.txtPublisher = new System.Windows.Forms.TextBox();
            this.txtEdition = new System.Windows.Forms.TextBox();
            this.txtBalance = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.txtCount = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSearchStock);
            this.groupBox1.Controls.Add(this.txtKeyWord);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(885, 87);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // btnSearchStock
            // 
            this.btnSearchStock.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSearchStock.BackgroundImage")));
            this.btnSearchStock.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchStock.ForeColor = System.Drawing.Color.White;
            this.btnSearchStock.Location = new System.Drawing.Point(721, 18);
            this.btnSearchStock.Name = "btnSearchStock";
            this.btnSearchStock.Size = new System.Drawing.Size(153, 51);
            this.btnSearchStock.TabIndex = 7;
            this.btnSearchStock.Text = "SEARCH";
            this.btnSearchStock.UseVisualStyleBackColor = true;
            this.btnSearchStock.Click += new System.EventHandler(this.btnSearchStock_Click);
            // 
            // txtKeyWord
            // 
            this.txtKeyWord.Location = new System.Drawing.Point(106, 34);
            this.txtKeyWord.Name = "txtKeyWord";
            this.txtKeyWord.Size = new System.Drawing.Size(586, 20);
            this.txtKeyWord.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(29, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "KeyWord :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblAuthor);
            this.groupBox2.Controls.Add(this.lblEdition);
            this.groupBox2.Controls.Add(this.lblPrice);
            this.groupBox2.Controls.Add(this.lblYear);
            this.groupBox2.Controls.Add(this.lblPublisher);
            this.groupBox2.Controls.Add(this.lblTitle);
            this.groupBox2.Controls.Add(this.lblISBN);
            this.groupBox2.Controls.Add(this.txtDiscount);
            this.groupBox2.Controls.Add(this.tableLayoutPanel1);
            this.groupBox2.Controls.Add(this.cmbPriceChangable);
            this.groupBox2.Controls.Add(this.cmbYear);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.txtAdvance);
            this.groupBox2.Controls.Add(this.txtPublisher);
            this.groupBox2.Controls.Add(this.txtEdition);
            this.groupBox2.Controls.Add(this.txtBalance);
            this.groupBox2.Controls.Add(this.txtPrice);
            this.groupBox2.Controls.Add(this.txtAuthor);
            this.groupBox2.Controls.Add(this.txtCount);
            this.groupBox2.Controls.Add(this.txtTitle);
            this.groupBox2.Controls.Add(this.txtISBN);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(0, 88);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(885, 366);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuthor.ForeColor = System.Drawing.Color.Lime;
            this.lblAuthor.Location = new System.Drawing.Point(545, 104);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(26, 31);
            this.lblAuthor.TabIndex = 27;
            this.lblAuthor.Text = "*";
            // 
            // lblEdition
            // 
            this.lblEdition.AutoSize = true;
            this.lblEdition.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdition.ForeColor = System.Drawing.Color.Lime;
            this.lblEdition.Location = new System.Drawing.Point(545, 152);
            this.lblEdition.Name = "lblEdition";
            this.lblEdition.Size = new System.Drawing.Size(26, 31);
            this.lblEdition.TabIndex = 27;
            this.lblEdition.Text = "*";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.ForeColor = System.Drawing.Color.Lime;
            this.lblPrice.Location = new System.Drawing.Point(825, 104);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(26, 31);
            this.lblPrice.TabIndex = 27;
            this.lblPrice.Text = "*";
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYear.ForeColor = System.Drawing.Color.Lime;
            this.lblYear.Location = new System.Drawing.Point(827, 23);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(26, 31);
            this.lblYear.TabIndex = 27;
            this.lblYear.Text = "*";
            // 
            // lblPublisher
            // 
            this.lblPublisher.AutoSize = true;
            this.lblPublisher.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPublisher.ForeColor = System.Drawing.Color.Lime;
            this.lblPublisher.Location = new System.Drawing.Point(545, 198);
            this.lblPublisher.Name = "lblPublisher";
            this.lblPublisher.Size = new System.Drawing.Size(26, 31);
            this.lblPublisher.TabIndex = 27;
            this.lblPublisher.Text = "*";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Lime;
            this.lblTitle.Location = new System.Drawing.Point(545, 62);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(26, 31);
            this.lblTitle.TabIndex = 27;
            this.lblTitle.Text = "*";
            // 
            // lblISBN
            // 
            this.lblISBN.AutoSize = true;
            this.lblISBN.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblISBN.ForeColor = System.Drawing.Color.Lime;
            this.lblISBN.Location = new System.Drawing.Point(399, 21);
            this.lblISBN.Name = "lblISBN";
            this.lblISBN.Size = new System.Drawing.Size(26, 31);
            this.lblISBN.TabIndex = 26;
            this.lblISBN.Text = "*";
            // 
            // txtDiscount
            // 
            this.txtDiscount.FormattingEnabled = true;
            this.txtDiscount.Items.AddRange(new object[] {
            "10",
            "15",
            "20"});
            this.txtDiscount.Location = new System.Drawing.Point(715, 151);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(104, 21);
            this.txtDiscount.TabIndex = 9;
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
            this.tableLayoutPanel1.Controls.Add(this.btnCancel, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnBuy, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 304);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(879, 59);
            this.tableLayoutPanel1.TabIndex = 24;
            // 
            // btnCancel
            // 
            this.btnCancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancel.BackgroundImage")));
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCancel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(441, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(140, 53);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnBuy
            // 
            this.btnBuy.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBuy.BackgroundImage")));
            this.btnBuy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBuy.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuy.ForeColor = System.Drawing.Color.White;
            this.btnBuy.Location = new System.Drawing.Point(295, 3);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.Size = new System.Drawing.Size(140, 53);
            this.btnBuy.TabIndex = 12;
            this.btnBuy.Text = "BUY";
            this.btnBuy.UseVisualStyleBackColor = true;
            this.btnBuy.Click += new System.EventHandler(this.btnBuy_Click);
            // 
            // cmbPriceChangable
            // 
            this.cmbPriceChangable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPriceChangable.FormattingEnabled = true;
            this.cmbPriceChangable.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.cmbPriceChangable.Location = new System.Drawing.Point(715, 198);
            this.cmbPriceChangable.Name = "cmbPriceChangable";
            this.cmbPriceChangable.Size = new System.Drawing.Size(106, 21);
            this.cmbPriceChangable.TabIndex = 10;
            // 
            // cmbYear
            // 
            this.cmbYear.FormattingEnabled = true;
            this.cmbYear.Items.AddRange(new object[] {
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
            this.cmbYear.Location = new System.Drawing.Point(715, 24);
            this.cmbYear.Name = "cmbYear";
            this.cmbYear.Size = new System.Drawing.Size(106, 21);
            this.cmbYear.TabIndex = 6;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(32, 248);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(65, 16);
            this.label14.TabIndex = 20;
            this.label14.Text = "Advance :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(32, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 16);
            this.label5.TabIndex = 20;
            this.label5.Text = "Publisher :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(48, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 16);
            this.label4.TabIndex = 19;
            this.label4.Text = "Edition :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(48, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 16);
            this.label3.TabIndex = 18;
            this.label3.Text = "Author :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(59, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "Title :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(637, 248);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(61, 16);
            this.label13.TabIndex = 16;
            this.label13.Text = "Balance :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(590, 203);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(109, 16);
            this.label10.TabIndex = 16;
            this.label10.Text = "Price Changable :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(633, 152);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 16);
            this.label9.TabIndex = 15;
            this.label9.Text = "Discount :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(827, 153);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(20, 16);
            this.label11.TabIndex = 14;
            this.label11.Text = "%";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(652, 104);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 16);
            this.label8.TabIndex = 21;
            this.label8.Text = "Price :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(648, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "Count :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(655, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Year :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(58, 25);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 16);
            this.label12.TabIndex = 11;
            this.label12.Text = "ISBN :";
            // 
            // txtAdvance
            // 
            this.txtAdvance.Location = new System.Drawing.Point(116, 245);
            this.txtAdvance.MaxLength = 10;
            this.txtAdvance.Name = "txtAdvance";
            this.txtAdvance.Size = new System.Drawing.Size(231, 20);
            this.txtAdvance.TabIndex = 5;
            this.txtAdvance.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAdvance_KeyPress);
            // 
            // txtPublisher
            // 
            this.txtPublisher.Location = new System.Drawing.Point(116, 199);
            this.txtPublisher.MaxLength = 75;
            this.txtPublisher.Name = "txtPublisher";
            this.txtPublisher.Size = new System.Drawing.Size(424, 20);
            this.txtPublisher.TabIndex = 4;
            this.txtPublisher.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPublisher_KeyPress);
            // 
            // txtEdition
            // 
            this.txtEdition.Location = new System.Drawing.Point(116, 152);
            this.txtEdition.MaxLength = 50;
            this.txtEdition.Name = "txtEdition";
            this.txtEdition.Size = new System.Drawing.Size(424, 20);
            this.txtEdition.TabIndex = 3;
            this.txtEdition.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEdition_KeyPress);
            // 
            // txtBalance
            // 
            this.txtBalance.Location = new System.Drawing.Point(715, 244);
            this.txtBalance.MaxLength = 10;
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.Size = new System.Drawing.Size(104, 20);
            this.txtBalance.TabIndex = 11;
            this.txtBalance.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBalance_KeyPress);
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(715, 104);
            this.txtPrice.MaxLength = 10;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(104, 20);
            this.txtPrice.TabIndex = 8;
            this.txtPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrice_KeyPress);
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(116, 104);
            this.txtAuthor.MaxLength = 100;
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(424, 20);
            this.txtAuthor.TabIndex = 2;
            this.txtAuthor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAuthor_KeyPress);
            // 
            // txtCount
            // 
            this.txtCount.Location = new System.Drawing.Point(717, 62);
            this.txtCount.MaxLength = 2;
            this.txtCount.Name = "txtCount";
            this.txtCount.Size = new System.Drawing.Size(104, 20);
            this.txtCount.TabIndex = 7;
            this.txtCount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCount_KeyPress);
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(116, 62);
            this.txtTitle.MaxLength = 100;
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(424, 20);
            this.txtTitle.TabIndex = 1;
            this.txtTitle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTitle_KeyPress);
            // 
            // txtISBN
            // 
            this.txtISBN.Location = new System.Drawing.Point(116, 23);
            this.txtISBN.MaxLength = 11;
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(277, 20);
            this.txtISBN.TabIndex = 0;
            this.txtISBN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtISBN_KeyPress);
            // 
            // frmBuy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(885, 454);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmBuy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buy";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmBuy_FormClosing);
            this.Load += new System.EventHandler(this.frmBuy_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSearchStock;
        private System.Windows.Forms.TextBox txtKeyWord;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnCancel;
        internal System.Windows.Forms.ComboBox cmbPriceChangable;
        internal System.Windows.Forms.TextBox txtPublisher;
        internal System.Windows.Forms.TextBox txtEdition;
        internal System.Windows.Forms.TextBox txtPrice;
        internal System.Windows.Forms.TextBox txtAuthor;
        internal System.Windows.Forms.TextBox txtCount;
        internal System.Windows.Forms.TextBox txtTitle;
        internal System.Windows.Forms.TextBox txtISBN;
        internal System.Windows.Forms.Button btnBuy;
        internal System.Windows.Forms.ComboBox cmbYear;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        internal System.Windows.Forms.TextBox txtAdvance;
        internal System.Windows.Forms.TextBox txtBalance;
        private System.Windows.Forms.ComboBox txtDiscount;
        private System.Windows.Forms.Label lblISBN;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.Label lblEdition;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label lblPublisher;
        private System.Windows.Forms.Label lblTitle;
    }
}