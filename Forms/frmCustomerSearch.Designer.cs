namespace LibraryDesign_frontEndUI
{
    partial class frmCustomerSearch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCustomerSearch));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ctStockSearchDataTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCount = new System.Windows.Forms.TextBox();
            this.chkAllowZeroCount = new System.Windows.Forms.CheckBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtCustCollege = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCustName = new System.Windows.Forms.TextBox();
            this.txtMemberNumber = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvCustDetails = new System.Windows.Forms.DataGridView();
            this.CustomerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fatherNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DOB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parentPhoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parentMobileDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentMobile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.collegeNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Course = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CourseDuration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmailID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MembershipDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MembershipType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MembershipPeriod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Activation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DepositAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AdvanceAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BalanceAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RefundAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RecieptNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaxLimit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UsedLimit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.View = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ctCustomerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bLSSchema = new LibraryDesign_frontEndUI.BLSSchema();
            this.ctCustomerDataTableBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.ctCustomerDataTableBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.ctCustomerDataTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.frmReturn = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnEarlyIssue = new System.Windows.Forms.Button();
            this.ctCustomerDataTableBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ctStockSearchDataTableBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctCustomerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bLSSchema)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctCustomerDataTableBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctCustomerDataTableBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctCustomerDataTableBindingSource)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ctCustomerDataTableBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // ctStockSearchDataTableBindingSource
            // 
            this.ctStockSearchDataTableBindingSource.DataSource = typeof(LibraryDesign_frontEndUI.BLSSchema.ctStockSearchDataTable);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtCount);
            this.groupBox1.Controls.Add(this.chkAllowZeroCount);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.txtCustCollege);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtCustName);
            this.groupBox1.Controls.Add(this.txtMemberNumber);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1091, 81);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(68, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 16);
            this.label1.TabIndex = 21;
            this.label1.Text = "Count :";
            // 
            // txtCount
            // 
            this.txtCount.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCount.Location = new System.Drawing.Point(129, 47);
            this.txtCount.MaxLength = 8;
            this.txtCount.Name = "txtCount";
            this.txtCount.Size = new System.Drawing.Size(106, 25);
            this.txtCount.TabIndex = 22;
            this.txtCount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Number_Validation);
            // 
            // chkAllowZeroCount
            // 
            this.chkAllowZeroCount.AutoSize = true;
            this.chkAllowZeroCount.Checked = true;
            this.chkAllowZeroCount.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAllowZeroCount.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAllowZeroCount.ForeColor = System.Drawing.Color.White;
            this.chkAllowZeroCount.Location = new System.Drawing.Point(769, 19);
            this.chkAllowZeroCount.Name = "chkAllowZeroCount";
            this.chkAllowZeroCount.Size = new System.Drawing.Size(178, 20);
            this.chkAllowZeroCount.TabIndex = 20;
            this.chkAllowZeroCount.Text = "Display zero count records";
            this.chkAllowZeroCount.UseVisualStyleBackColor = true;
            this.chkAllowZeroCount.CheckedChanged += new System.EventHandler(this.chkAllowZeroCount_CheckedChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSearch.BackgroundImage")));
            this.btnSearch.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSearch.Font = new System.Drawing.Font("Tahoma", 10.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(991, 16);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(97, 62);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtCustCollege
            // 
            this.txtCustCollege.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustCollege.Location = new System.Drawing.Point(372, 47);
            this.txtCustCollege.Name = "txtCustCollege";
            this.txtCustCollege.Size = new System.Drawing.Size(391, 25);
            this.txtCustCollege.TabIndex = 19;
            this.txtCustCollege.TextChanged += new System.EventHandler(this.txtCustCollege_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(259, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "Customer Name :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(304, 52);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 16);
            this.label12.TabIndex = 18;
            this.label12.Text = "College :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(41, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "M-Number :";
            // 
            // txtCustName
            // 
            this.txtCustName.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustName.Location = new System.Drawing.Point(372, 16);
            this.txtCustName.Name = "txtCustName";
            this.txtCustName.Size = new System.Drawing.Size(391, 25);
            this.txtCustName.TabIndex = 16;
            this.txtCustName.TextChanged += new System.EventHandler(this.txtCustName_TextChanged);
            // 
            // txtMemberNumber
            // 
            this.txtMemberNumber.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMemberNumber.Location = new System.Drawing.Point(129, 15);
            this.txtMemberNumber.Name = "txtMemberNumber";
            this.txtMemberNumber.Size = new System.Drawing.Size(106, 25);
            this.txtMemberNumber.TabIndex = 15;
            this.txtMemberNumber.TextChanged += new System.EventHandler(this.txtReceiptNumber_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.dgvCustDetails);
            this.groupBox2.Location = new System.Drawing.Point(1, 85);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1084, 290);
            this.groupBox2.TabIndex = 25;
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
            this.CustName,
            this.fatherNameDataGridViewTextBoxColumn,
            this.DOB,
            this.parentPhoneDataGridViewTextBoxColumn,
            this.parentMobileDataGridViewTextBoxColumn,
            this.StudentMobile,
            this.addressDataGridViewTextBoxColumn,
            this.collegeNameDataGridViewTextBoxColumn,
            this.Course,
            this.CourseDuration,
            this.EmailID,
            this.MembershipDate,
            this.MembershipType,
            this.MembershipPeriod,
            this.Activation,
            this.BookCount,
            this.DepositAmount,
            this.AdvanceAmount,
            this.BalanceAmount,
            this.RefundAmount,
            this.RecieptNumber,
            this.MaxLimit,
            this.UsedLimit,
            this.View});
            this.dgvCustDetails.DataSource = this.ctCustomerBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Goldenrod;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCustDetails.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCustDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCustDetails.Location = new System.Drawing.Point(3, 16);
            this.dgvCustDetails.Name = "dgvCustDetails";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCustDetails.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCustDetails.Size = new System.Drawing.Size(1078, 271);
            this.dgvCustDetails.TabIndex = 11;
            this.dgvCustDetails.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvCustDetails_CellFormatting);
            this.dgvCustDetails.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvCustDetails_CellMouseClick);
            this.dgvCustDetails.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvCustDetails_RowPostPaint);
            // 
            // CustomerID
            // 
            this.CustomerID.DataPropertyName = "CustomerID";
            this.CustomerID.HeaderText = "M-Number";
            this.CustomerID.Name = "CustomerID";
            // 
            // CustName
            // 
            this.CustName.DataPropertyName = "CustName";
            this.CustName.HeaderText = "CustName";
            this.CustName.Name = "CustName";
            // 
            // fatherNameDataGridViewTextBoxColumn
            // 
            this.fatherNameDataGridViewTextBoxColumn.DataPropertyName = "Father Name";
            this.fatherNameDataGridViewTextBoxColumn.HeaderText = "Father Name";
            this.fatherNameDataGridViewTextBoxColumn.Name = "fatherNameDataGridViewTextBoxColumn";
            this.fatherNameDataGridViewTextBoxColumn.Visible = false;
            // 
            // DOB
            // 
            this.DOB.DataPropertyName = "DOB";
            dataGridViewCellStyle1.Format = "dd/MM/yyyy";
            this.DOB.DefaultCellStyle = dataGridViewCellStyle1;
            this.DOB.HeaderText = "DOB";
            this.DOB.Name = "DOB";
            // 
            // parentPhoneDataGridViewTextBoxColumn
            // 
            this.parentPhoneDataGridViewTextBoxColumn.DataPropertyName = "Parent Phone";
            this.parentPhoneDataGridViewTextBoxColumn.HeaderText = "Parent Phone";
            this.parentPhoneDataGridViewTextBoxColumn.Name = "parentPhoneDataGridViewTextBoxColumn";
            this.parentPhoneDataGridViewTextBoxColumn.Visible = false;
            // 
            // parentMobileDataGridViewTextBoxColumn
            // 
            this.parentMobileDataGridViewTextBoxColumn.DataPropertyName = "Parent Mobile";
            this.parentMobileDataGridViewTextBoxColumn.HeaderText = "Parent Mobile";
            this.parentMobileDataGridViewTextBoxColumn.Name = "parentMobileDataGridViewTextBoxColumn";
            this.parentMobileDataGridViewTextBoxColumn.Visible = false;
            // 
            // StudentMobile
            // 
            this.StudentMobile.DataPropertyName = "Student Mobile";
            this.StudentMobile.HeaderText = "Mobile";
            this.StudentMobile.Name = "StudentMobile";
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.Visible = false;
            // 
            // collegeNameDataGridViewTextBoxColumn
            // 
            this.collegeNameDataGridViewTextBoxColumn.DataPropertyName = "CollegeName";
            this.collegeNameDataGridViewTextBoxColumn.HeaderText = "College";
            this.collegeNameDataGridViewTextBoxColumn.Name = "collegeNameDataGridViewTextBoxColumn";
            // 
            // Course
            // 
            this.Course.DataPropertyName = "Course";
            this.Course.HeaderText = "Course";
            this.Course.Name = "Course";
            // 
            // CourseDuration
            // 
            this.CourseDuration.DataPropertyName = "CourseDuration";
            this.CourseDuration.HeaderText = "CourseDuration";
            this.CourseDuration.Name = "CourseDuration";
            this.CourseDuration.Visible = false;
            // 
            // EmailID
            // 
            this.EmailID.DataPropertyName = "EmailID";
            this.EmailID.HeaderText = "EmailID";
            this.EmailID.Name = "EmailID";
            this.EmailID.Visible = false;
            // 
            // MembershipDate
            // 
            this.MembershipDate.DataPropertyName = "MembershipDate";
            this.MembershipDate.HeaderText = "M-Date";
            this.MembershipDate.Name = "MembershipDate";
            // 
            // MembershipType
            // 
            this.MembershipType.DataPropertyName = "MembershipType";
            this.MembershipType.HeaderText = "M-Type";
            this.MembershipType.Name = "MembershipType";
            // 
            // MembershipPeriod
            // 
            this.MembershipPeriod.DataPropertyName = "MembershipPeriod";
            this.MembershipPeriod.HeaderText = "M-Period";
            this.MembershipPeriod.Name = "MembershipPeriod";
            // 
            // Activation
            // 
            this.Activation.DataPropertyName = "Activation";
            this.Activation.HeaderText = "Activation";
            this.Activation.Name = "Activation";
            this.Activation.Visible = false;
            // 
            // BookCount
            // 
            this.BookCount.DataPropertyName = "BookCount";
            this.BookCount.HeaderText = "BookCount";
            this.BookCount.Name = "BookCount";
            // 
            // DepositAmount
            // 
            this.DepositAmount.DataPropertyName = "DepositAmount";
            this.DepositAmount.HeaderText = "Deposit";
            this.DepositAmount.Name = "DepositAmount";
            // 
            // AdvanceAmount
            // 
            this.AdvanceAmount.DataPropertyName = "AdvanceAmount";
            this.AdvanceAmount.HeaderText = "Advance";
            this.AdvanceAmount.Name = "AdvanceAmount";
            // 
            // BalanceAmount
            // 
            this.BalanceAmount.DataPropertyName = "BalanceAmount";
            this.BalanceAmount.HeaderText = "Balance";
            this.BalanceAmount.Name = "BalanceAmount";
            // 
            // RefundAmount
            // 
            this.RefundAmount.DataPropertyName = "RefundAmount";
            this.RefundAmount.HeaderText = "Refund";
            this.RefundAmount.Name = "RefundAmount";
            this.RefundAmount.Visible = false;
            // 
            // RecieptNumber
            // 
            this.RecieptNumber.DataPropertyName = "RecieptNumber";
            this.RecieptNumber.HeaderText = "RecieptNumber";
            this.RecieptNumber.Name = "RecieptNumber";
            // 
            // MaxLimit
            // 
            this.MaxLimit.DataPropertyName = "MaxLimit";
            this.MaxLimit.HeaderText = "MaxLimit";
            this.MaxLimit.Name = "MaxLimit";
            // 
            // UsedLimit
            // 
            this.UsedLimit.DataPropertyName = "UsedLimit";
            this.UsedLimit.HeaderText = "UsedLimit";
            this.UsedLimit.Name = "UsedLimit";
            // 
            // View
            // 
            this.View.DataPropertyName = "View";
            this.View.HeaderText = "View";
            this.View.Name = "View";
            this.View.Text = "View";
            this.View.UseColumnTextForButtonValue = true;
            // 
            // ctCustomerBindingSource
            // 
            this.ctCustomerBindingSource.DataMember = "ctCustomer";
            this.ctCustomerBindingSource.DataSource = this.bLSSchema;
            // 
            // bLSSchema
            // 
            this.bLSSchema.DataSetName = "BLSSchema";
            this.bLSSchema.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ctCustomerDataTableBindingSource3
            // 
            this.ctCustomerDataTableBindingSource3.DataSource = typeof(LibraryDesign_frontEndUI.BLSSchema.ctCustomerDataTable);
            // 
            // ctCustomerDataTableBindingSource1
            // 
            this.ctCustomerDataTableBindingSource1.DataSource = typeof(LibraryDesign_frontEndUI.BLSSchema.ctCustomerDataTable);
            // 
            // ctCustomerDataTableBindingSource
            // 
            this.ctCustomerDataTableBindingSource.DataSource = typeof(LibraryDesign_frontEndUI.BLSSchema.ctCustomerDataTable);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 7;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.Controls.Add(this.frmReturn, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnDelete, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.button3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.button4, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnEarlyIssue, 5, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 382);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1091, 59);
            this.tableLayoutPanel1.TabIndex = 22;
            // 
            // frmReturn
            // 
            this.frmReturn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("frmReturn.BackgroundImage")));
            this.frmReturn.Font = new System.Drawing.Font("Tahoma", 10.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frmReturn.Location = new System.Drawing.Point(468, 4);
            this.frmReturn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.frmReturn.Name = "frmReturn";
            this.frmReturn.Size = new System.Drawing.Size(149, 51);
            this.frmReturn.TabIndex = 5;
            this.frmReturn.Text = "Return";
            this.frmReturn.UseVisualStyleBackColor = true;
            this.frmReturn.Click += new System.EventHandler(this.frmReturn_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDelete.BackgroundImage")));
            this.btnDelete.Font = new System.Drawing.Font("Tahoma", 10.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(623, 4);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(149, 51);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // button3
            // 
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.Font = new System.Drawing.Font("Tahoma", 10.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(313, 4);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(149, 51);
            this.button3.TabIndex = 6;
            this.button3.Text = "Issue";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
            this.button4.Font = new System.Drawing.Font("Tahoma", 10.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(158, 4);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(149, 51);
            this.button4.TabIndex = 7;
            this.button4.Text = "Edit Details";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnEarlyIssue
            // 
            this.btnEarlyIssue.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEarlyIssue.BackgroundImage")));
            this.btnEarlyIssue.Enabled = false;
            this.btnEarlyIssue.Font = new System.Drawing.Font("Tahoma", 10.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEarlyIssue.Location = new System.Drawing.Point(778, 4);
            this.btnEarlyIssue.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEarlyIssue.Name = "btnEarlyIssue";
            this.btnEarlyIssue.Size = new System.Drawing.Size(149, 51);
            this.btnEarlyIssue.TabIndex = 8;
            this.btnEarlyIssue.Text = "E-Issue";
            this.btnEarlyIssue.UseVisualStyleBackColor = true;
            this.btnEarlyIssue.Click += new System.EventHandler(this.btnEarlyIssue_Click);
            // 
            // ctCustomerDataTableBindingSource2
            // 
            this.ctCustomerDataTableBindingSource2.DataSource = typeof(LibraryDesign_frontEndUI.BLSSchema.ctCustomerDataTable);
            // 
            // frmCustomerSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1091, 441);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "frmCustomerSearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search Customer";
            this.Activated += new System.EventHandler(this.frmCustomerSearch_Activated);
            this.Load += new System.EventHandler(this.frmCustomerSearch_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmCustomerSearch_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.ctStockSearchDataTableBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctCustomerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bLSSchema)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctCustomerDataTableBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctCustomerDataTableBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctCustomerDataTableBindingSource)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ctCustomerDataTableBindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource ctStockSearchDataTableBindingSource;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtCustCollege;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCustName;
        private System.Windows.Forms.TextBox txtMemberNumber;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvCustDetails;
        private System.Windows.Forms.BindingSource ctCustomerDataTableBindingSource;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobileDataGridViewTextBoxColumn;
        private System.Windows.Forms.CheckBox chkAllowZeroCount;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button frmReturn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCount;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.BindingSource ctCustomerDataTableBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MNumber;
        private System.Windows.Forms.Button btnEarlyIssue;
        private System.Windows.Forms.BindingSource ctCustomerDataTableBindingSource2;
        private System.Windows.Forms.BindingSource ctCustomerDataTableBindingSource3;
        private System.Windows.Forms.BindingSource ctCustomerBindingSource;
        private BLSSchema bLSSchema;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustName;
        private System.Windows.Forms.DataGridViewTextBoxColumn fatherNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DOB;
        private System.Windows.Forms.DataGridViewTextBoxColumn parentPhoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn parentMobileDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentMobile;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn collegeNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Course;
        private System.Windows.Forms.DataGridViewTextBoxColumn CourseDuration;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmailID;
        private System.Windows.Forms.DataGridViewTextBoxColumn MembershipDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn MembershipType;
        private System.Windows.Forms.DataGridViewTextBoxColumn MembershipPeriod;
        private System.Windows.Forms.DataGridViewTextBoxColumn Activation;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn DepositAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn AdvanceAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn BalanceAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn RefundAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn RecieptNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaxLimit;
        private System.Windows.Forms.DataGridViewTextBoxColumn UsedLimit;
        private System.Windows.Forms.DataGridViewButtonColumn View;

    }
}