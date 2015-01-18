namespace LibraryDesign_frontEndUI
{
    partial class frmPlaceOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPlaceOrder));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblMobile = new System.Windows.Forms.Label();
            this.lblOrderISBN = new System.Windows.Forms.Label();
            this.lblClearanceDate = new System.Windows.Forms.Label();
            this.dtpClearanceDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBookCount = new System.Windows.Forms.TextBox();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.txtDepositAmount = new System.Windows.Forms.TextBox();
            this.txtMobile = new System.Windows.Forms.TextBox();
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnPlace = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.lblMobile);
            this.groupBox1.Controls.Add(this.lblOrderISBN);
            this.groupBox1.Controls.Add(this.lblClearanceDate);
            this.groupBox1.Controls.Add(this.dtpClearanceDate);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtBookCount);
            this.groupBox1.Controls.Add(this.txtISBN);
            this.groupBox1.Controls.Add(this.txtDepositAmount);
            this.groupBox1.Controls.Add(this.txtMobile);
            this.groupBox1.Controls.Add(this.txtCustomerID);
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Location = new System.Drawing.Point(11, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(648, 289);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(269, 95);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(36, 23);
            this.btnSearch.TabIndex = 23;
            this.btnSearch.Text = "...";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblMobile
            // 
            this.lblMobile.AutoSize = true;
            this.lblMobile.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMobile.ForeColor = System.Drawing.Color.Lime;
            this.lblMobile.Location = new System.Drawing.Point(313, 157);
            this.lblMobile.Name = "lblMobile";
            this.lblMobile.Size = new System.Drawing.Size(26, 31);
            this.lblMobile.TabIndex = 22;
            this.lblMobile.Text = "*";
            // 
            // lblOrderISBN
            // 
            this.lblOrderISBN.AutoSize = true;
            this.lblOrderISBN.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderISBN.ForeColor = System.Drawing.Color.Lime;
            this.lblOrderISBN.Location = new System.Drawing.Point(313, 96);
            this.lblOrderISBN.Name = "lblOrderISBN";
            this.lblOrderISBN.Size = new System.Drawing.Size(26, 31);
            this.lblOrderISBN.TabIndex = 22;
            this.lblOrderISBN.Text = "*";
            // 
            // lblClearanceDate
            // 
            this.lblClearanceDate.AutoSize = true;
            this.lblClearanceDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClearanceDate.ForeColor = System.Drawing.Color.Lime;
            this.lblClearanceDate.Location = new System.Drawing.Point(593, 157);
            this.lblClearanceDate.Name = "lblClearanceDate";
            this.lblClearanceDate.Size = new System.Drawing.Size(26, 31);
            this.lblClearanceDate.TabIndex = 22;
            this.lblClearanceDate.Text = "*";
            // 
            // dtpClearanceDate
            // 
            this.dtpClearanceDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpClearanceDate.Location = new System.Drawing.Point(504, 157);
            this.dtpClearanceDate.Name = "dtpClearanceDate";
            this.dtpClearanceDate.Size = new System.Drawing.Size(83, 20);
            this.dtpClearanceDate.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(63, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "ISBN :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(53, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mobile :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(366, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 16);
            this.label6.TabIndex = 2;
            this.label6.Text = "Clearance Date :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(390, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "Book Count :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(366, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Deposit Amount :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(19, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Customer ID :";
            // 
            // txtBookCount
            // 
            this.txtBookCount.Location = new System.Drawing.Point(504, 96);
            this.txtBookCount.MaxLength = 2;
            this.txtBookCount.Name = "txtBookCount";
            this.txtBookCount.Size = new System.Drawing.Size(83, 20);
            this.txtBookCount.TabIndex = 1;
            this.txtBookCount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBookCount_KeyPress);
            // 
            // txtISBN
            // 
            this.txtISBN.Location = new System.Drawing.Point(123, 96);
            this.txtISBN.MaxLength = 11;
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(141, 20);
            this.txtISBN.TabIndex = 1;
            this.txtISBN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtISBN_KeyPress);
            // 
            // txtDepositAmount
            // 
            this.txtDepositAmount.Location = new System.Drawing.Point(504, 33);
            this.txtDepositAmount.MaxLength = 10;
            this.txtDepositAmount.Name = "txtDepositAmount";
            this.txtDepositAmount.Size = new System.Drawing.Size(83, 20);
            this.txtDepositAmount.TabIndex = 1;
            this.txtDepositAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDepositAmount_KeyPress);
            // 
            // txtMobile
            // 
            this.txtMobile.Location = new System.Drawing.Point(123, 157);
            this.txtMobile.MaxLength = 10;
            this.txtMobile.Name = "txtMobile";
            this.txtMobile.Size = new System.Drawing.Size(141, 20);
            this.txtMobile.TabIndex = 1;
            this.txtMobile.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMobile_KeyPress);
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.Location = new System.Drawing.Point(123, 33);
            this.txtCustomerID.MaxLength = 20;
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.Size = new System.Drawing.Size(184, 20);
            this.txtCustomerID.TabIndex = 1;
            this.txtCustomerID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCustomerID_KeyPress);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.btnPlace, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.button2, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 226);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(636, 57);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnPlace
            // 
            this.btnPlace.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPlace.BackgroundImage")));
            this.btnPlace.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPlace.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlace.ForeColor = System.Drawing.Color.White;
            this.btnPlace.Location = new System.Drawing.Point(162, 3);
            this.btnPlace.Name = "btnPlace";
            this.btnPlace.Size = new System.Drawing.Size(153, 51);
            this.btnPlace.TabIndex = 0;
            this.btnPlace.Text = "PLACE ORDER";
            this.btnPlace.UseVisualStyleBackColor = true;
            this.btnPlace.Click += new System.EventHandler(this.btnPlace_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(321, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(153, 51);
            this.button2.TabIndex = 1;
            this.button2.Text = "CANCEL";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmPlaceOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(672, 313);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmPlaceOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Place Order";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPlaceOrder_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnPlace;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBookCount;
        private System.Windows.Forms.TextBox txtDepositAmount;
        private System.Windows.Forms.TextBox txtMobile;
        private System.Windows.Forms.TextBox txtCustomerID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpClearanceDate;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblMobile;
        private System.Windows.Forms.Label lblOrderISBN;
        private System.Windows.Forms.Label lblClearanceDate;
        internal System.Windows.Forms.TextBox txtISBN;
    }
}