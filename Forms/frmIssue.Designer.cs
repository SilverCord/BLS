namespace LibraryDesign_frontEndUI
{
    partial class frmIssueBooks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIssueBooks));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPurchasedPrice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnChooseBook = new System.Windows.Forms.Button();
            this.txtSelectedAuthor = new System.Windows.Forms.TextBox();
            this.txtSelectedPublisher = new System.Windows.Forms.TextBox();
            this.txtSelectedYear = new System.Windows.Forms.TextBox();
            this.txtSelectedEdition = new System.Windows.Forms.TextBox();
            this.txtSelectedTitle = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ctStockSearchDataTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtCollegeName = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtDOB = new System.Windows.Forms.TextBox();
            this.txtMobileNumber = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.ctCustomerDetailsDataTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtMemberShipType = new System.Windows.Forms.TextBox();
            this.txtBalance = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.txtAdvance = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.txtBookCount = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.txtBookPrice = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnIssue = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnCheck = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ctStockSearchDataTableBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ctCustomerDetailsDataTableBindingSource)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.txtPurchasedPrice);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnChooseBook);
            this.groupBox1.Controls.Add(this.txtSelectedAuthor);
            this.groupBox1.Controls.Add(this.txtSelectedPublisher);
            this.groupBox1.Controls.Add(this.txtSelectedYear);
            this.groupBox1.Controls.Add(this.txtSelectedEdition);
            this.groupBox1.Controls.Add(this.txtSelectedTitle);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 157);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1117, 184);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Book Details";
            // 
            // txtPurchasedPrice
            // 
            this.txtPurchasedPrice.Location = new System.Drawing.Point(156, 65);
            this.txtPurchasedPrice.Name = "txtPurchasedPrice";
            this.txtPurchasedPrice.ReadOnly = true;
            this.txtPurchasedPrice.Size = new System.Drawing.Size(218, 23);
            this.txtPurchasedPrice.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Purchase Price :";
            // 
            // btnChooseBook
            // 
            this.btnChooseBook.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnChooseBook.ForeColor = System.Drawing.Color.Black;
            this.btnChooseBook.Location = new System.Drawing.Point(532, 120);
            this.btnChooseBook.Name = "btnChooseBook";
            this.btnChooseBook.Size = new System.Drawing.Size(141, 39);
            this.btnChooseBook.TabIndex = 9;
            this.btnChooseBook.Text = "Choose One";
            this.btnChooseBook.UseVisualStyleBackColor = true;
            this.btnChooseBook.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtSelectedAuthor
            // 
            this.txtSelectedAuthor.Location = new System.Drawing.Point(884, 20);
            this.txtSelectedAuthor.Name = "txtSelectedAuthor";
            this.txtSelectedAuthor.ReadOnly = true;
            this.txtSelectedAuthor.Size = new System.Drawing.Size(215, 23);
            this.txtSelectedAuthor.TabIndex = 2;
            // 
            // txtSelectedPublisher
            // 
            this.txtSelectedPublisher.Location = new System.Drawing.Point(883, 66);
            this.txtSelectedPublisher.Name = "txtSelectedPublisher";
            this.txtSelectedPublisher.ReadOnly = true;
            this.txtSelectedPublisher.Size = new System.Drawing.Size(216, 23);
            this.txtSelectedPublisher.TabIndex = 2;
            // 
            // txtSelectedYear
            // 
            this.txtSelectedYear.Location = new System.Drawing.Point(532, 65);
            this.txtSelectedYear.Name = "txtSelectedYear";
            this.txtSelectedYear.ReadOnly = true;
            this.txtSelectedYear.Size = new System.Drawing.Size(220, 23);
            this.txtSelectedYear.TabIndex = 2;
            // 
            // txtSelectedEdition
            // 
            this.txtSelectedEdition.Location = new System.Drawing.Point(532, 22);
            this.txtSelectedEdition.Name = "txtSelectedEdition";
            this.txtSelectedEdition.ReadOnly = true;
            this.txtSelectedEdition.Size = new System.Drawing.Size(220, 23);
            this.txtSelectedEdition.TabIndex = 2;
            // 
            // txtSelectedTitle
            // 
            this.txtSelectedTitle.Location = new System.Drawing.Point(156, 20);
            this.txtSelectedTitle.Name = "txtSelectedTitle";
            this.txtSelectedTitle.ReadOnly = true;
            this.txtSelectedTitle.Size = new System.Drawing.Size(218, 23);
            this.txtSelectedTitle.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(822, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 16);
            this.label9.TabIndex = 1;
            this.label9.Text = "Author :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(468, 29);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 16);
            this.label10.TabIndex = 1;
            this.label10.Text = "Edition :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(807, 69);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 16);
            this.label11.TabIndex = 1;
            this.label11.Text = "Publisher :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(480, 69);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 16);
            this.label8.TabIndex = 1;
            this.label8.Text = "Year :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(107, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 16);
            this.label6.TabIndex = 1;
            this.label6.Text = "Title :";
            // 
            // ctStockSearchDataTableBindingSource
            // 
            this.ctStockSearchDataTableBindingSource.DataSource = typeof(LibraryDesign_frontEndUI.BLSSchema.ctStockSearchDataTable);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.txtCollegeName);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.txtEmail);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.txtDOB);
            this.groupBox2.Controls.Add(this.txtMobileNumber);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Controls.Add(this.txtFirstName);
            this.groupBox2.Controls.Add(this.txtID);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1117, 129);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Customer Details";
            // 
            // txtCollegeName
            // 
            this.txtCollegeName.Location = new System.Drawing.Point(884, 79);
            this.txtCollegeName.Name = "txtCollegeName";
            this.txtCollegeName.ReadOnly = true;
            this.txtCollegeName.Size = new System.Drawing.Size(221, 23);
            this.txtCollegeName.TabIndex = 24;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(787, 79);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(96, 16);
            this.label16.TabIndex = 23;
            this.label16.Text = "College Name :";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(532, 73);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ReadOnly = true;
            this.txtEmail.Size = new System.Drawing.Size(220, 23);
            this.txtEmail.TabIndex = 22;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(477, 76);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(48, 16);
            this.label15.TabIndex = 21;
            this.label15.Text = "Email :";
            // 
            // txtDOB
            // 
            this.txtDOB.Location = new System.Drawing.Point(884, 35);
            this.txtDOB.Name = "txtDOB";
            this.txtDOB.ReadOnly = true;
            this.txtDOB.Size = new System.Drawing.Size(188, 23);
            this.txtDOB.TabIndex = 19;
            // 
            // txtMobileNumber
            // 
            this.txtMobileNumber.Location = new System.Drawing.Point(156, 76);
            this.txtMobileNumber.Name = "txtMobileNumber";
            this.txtMobileNumber.ReadOnly = true;
            this.txtMobileNumber.Size = new System.Drawing.Size(218, 23);
            this.txtMobileNumber.TabIndex = 20;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(834, 38);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(49, 16);
            this.label19.TabIndex = 15;
            this.label19.Text = "D.O.B :";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(93, 80);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(54, 16);
            this.label20.TabIndex = 16;
            this.label20.Text = "Mobile :";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(532, 36);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.ReadOnly = true;
            this.txtFirstName.Size = new System.Drawing.Size(220, 23);
            this.txtFirstName.TabIndex = 12;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(154, 40);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(220, 23);
            this.txtID.TabIndex = 12;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(447, 39);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(79, 16);
            this.label13.TabIndex = 11;
            this.label13.Text = "First Name :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(119, 45);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(29, 16);
            this.label14.TabIndex = 11;
            this.label14.Text = "ID :";
            // 
            // ctCustomerDetailsDataTableBindingSource
            // 
            this.ctCustomerDetailsDataTableBindingSource.DataSource = typeof(LibraryDesign_frontEndUI.BLSSchema.ctCustomerDetailsDataTable);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.txtMemberShipType);
            this.groupBox3.Controls.Add(this.txtBalance);
            this.groupBox3.Controls.Add(this.label23);
            this.groupBox3.Controls.Add(this.txtAdvance);
            this.groupBox3.Controls.Add(this.label22);
            this.groupBox3.Controls.Add(this.txtBookCount);
            this.groupBox3.Controls.Add(this.label21);
            this.groupBox3.Controls.Add(this.txtBookPrice);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(12, 347);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1117, 74);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Other";
            // 
            // txtMemberShipType
            // 
            this.txtMemberShipType.Location = new System.Drawing.Point(110, 31);
            this.txtMemberShipType.Name = "txtMemberShipType";
            this.txtMemberShipType.ReadOnly = true;
            this.txtMemberShipType.Size = new System.Drawing.Size(141, 23);
            this.txtMemberShipType.TabIndex = 28;
            // 
            // txtBalance
            // 
            this.txtBalance.Location = new System.Drawing.Point(951, 31);
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.ReadOnly = true;
            this.txtBalance.Size = new System.Drawing.Size(96, 23);
            this.txtBalance.TabIndex = 27;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(887, 35);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(61, 16);
            this.label23.TabIndex = 26;
            this.label23.Text = "Balance :";
            // 
            // txtAdvance
            // 
            this.txtAdvance.Location = new System.Drawing.Point(748, 30);
            this.txtAdvance.Name = "txtAdvance";
            this.txtAdvance.ReadOnly = true;
            this.txtAdvance.Size = new System.Drawing.Size(102, 23);
            this.txtAdvance.TabIndex = 25;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(461, 31);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(45, 16);
            this.label22.TabIndex = 24;
            this.label22.Text = "Price :";
            // 
            // txtBookCount
            // 
            this.txtBookCount.Location = new System.Drawing.Point(340, 30);
            this.txtBookCount.Name = "txtBookCount";
            this.txtBookCount.Size = new System.Drawing.Size(93, 23);
            this.txtBookCount.TabIndex = 23;
            this.txtBookCount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBookCount_KeyPress);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(289, 33);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(50, 16);
            this.label21.TabIndex = 19;
            this.label21.Text = "Count :";
            // 
            // txtBookPrice
            // 
            this.txtBookPrice.Location = new System.Drawing.Point(510, 27);
            this.txtBookPrice.Name = "txtBookPrice";
            this.txtBookPrice.ReadOnly = true;
            this.txtBookPrice.Size = new System.Drawing.Size(121, 23);
            this.txtBookPrice.TabIndex = 23;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(681, 31);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(65, 16);
            this.label18.TabIndex = 19;
            this.label18.Text = "Advance :";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(25, 33);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(79, 16);
            this.label17.TabIndex = 17;
            this.label17.Text = "Issue Type :";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Controls.Add(this.btnCancel, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnIssue, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnReset, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnCheck, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 430);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1129, 60);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // btnCancel
            // 
            this.btnCancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancel.BackgroundImage")));
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCancel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(755, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(182, 54);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnIssue
            // 
            this.btnIssue.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnIssue.BackgroundImage")));
            this.btnIssue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnIssue.Enabled = false;
            this.btnIssue.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIssue.Location = new System.Drawing.Point(567, 3);
            this.btnIssue.Name = "btnIssue";
            this.btnIssue.Size = new System.Drawing.Size(182, 54);
            this.btnIssue.TabIndex = 0;
            this.btnIssue.Text = "ISSUE";
            this.btnIssue.UseVisualStyleBackColor = true;
            this.btnIssue.Click += new System.EventHandler(this.btnIssue_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnReset.BackgroundImage")));
            this.btnReset.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnReset.Enabled = false;
            this.btnReset.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(379, 3);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(182, 54);
            this.btnReset.TabIndex = 0;
            this.btnReset.Text = "RESET";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnCheck
            // 
            this.btnCheck.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCheck.BackgroundImage")));
            this.btnCheck.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCheck.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheck.Location = new System.Drawing.Point(191, 3);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(182, 54);
            this.btnCheck.TabIndex = 0;
            this.btnCheck.Text = "CHECK";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // frmIssueBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1142, 494);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "frmIssueBooks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Issue Book";
            this.Load += new System.EventHandler(this.frmIssue_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ctStockSearchDataTableBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ctCustomerDetailsDataTableBindingSource)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.BindingSource ctStockSearchDataTableBindingSource;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.BindingSource ctCustomerDetailsDataTableBindingSource;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtBookCount;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnIssue;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Button btnChooseBook;
        internal System.Windows.Forms.GroupBox groupBox1;
        internal System.Windows.Forms.TextBox txtSelectedYear;
        internal System.Windows.Forms.TextBox txtSelectedTitle;
        internal System.Windows.Forms.TextBox txtSelectedAuthor;
        internal System.Windows.Forms.TextBox txtSelectedPublisher;
        internal System.Windows.Forms.TextBox txtSelectedEdition;
        internal System.Windows.Forms.TextBox txtDOB;
        internal System.Windows.Forms.TextBox txtMobileNumber;
        internal System.Windows.Forms.TextBox txtFirstName;
        internal System.Windows.Forms.TextBox txtID;
        internal System.Windows.Forms.TextBox txtCollegeName;
        internal System.Windows.Forms.TextBox txtEmail;
        internal System.Windows.Forms.TextBox txtBalance;
        internal System.Windows.Forms.TextBox txtAdvance;
        internal System.Windows.Forms.TextBox txtBookPrice;
        internal System.Windows.Forms.TextBox txtPurchasedPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMemberShipType;
    }
}