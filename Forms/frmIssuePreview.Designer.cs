namespace LibraryDesign_frontEndUI
{
    partial class frmIssuePreview
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIssuePreview));
            this.label20 = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtBookPrice = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTotalAmountPayable = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.txtPreviousBalance = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAmountPayable = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIssueType = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPreviousAdvance = new System.Windows.Forms.TextBox();
            this.lblPreviousAdvance = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.White;
            this.label20.Location = new System.Drawing.Point(51, 33);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(109, 16);
            this.label20.TabIndex = 17;
            this.label20.Text = "Customer Name :";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(166, 31);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.ReadOnly = true;
            this.txtFirstName.Size = new System.Drawing.Size(260, 20);
            this.txtFirstName.TabIndex = 18;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBox1.Controls.Add(this.txtPreviousAdvance);
            this.groupBox1.Controls.Add(this.lblPreviousAdvance);
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.txtBookPrice);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtTotalAmountPayable);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btnOK);
            this.groupBox1.Controls.Add(this.txtPreviousBalance);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtAmountPayable);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtIssueType);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.txtFirstName);
            this.groupBox1.Location = new System.Drawing.Point(5, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(468, 418);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            // 
            // btnCancel
            // 
            this.btnCancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancel.BackgroundImage")));
            this.btnCancel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(48, 350);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(161, 54);
            this.btnCancel.TabIndex = 40;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtBookPrice
            // 
            this.txtBookPrice.Location = new System.Drawing.Point(166, 115);
            this.txtBookPrice.Name = "txtBookPrice";
            this.txtBookPrice.ReadOnly = true;
            this.txtBookPrice.Size = new System.Drawing.Size(260, 20);
            this.txtBookPrice.TabIndex = 39;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(114, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 16);
            this.label6.TabIndex = 38;
            this.label6.Text = "Price :";
            // 
            // txtTotalAmountPayable
            // 
            this.txtTotalAmountPayable.Location = new System.Drawing.Point(166, 300);
            this.txtTotalAmountPayable.Name = "txtTotalAmountPayable";
            this.txtTotalAmountPayable.ReadOnly = true;
            this.txtTotalAmountPayable.Size = new System.Drawing.Size(260, 20);
            this.txtTotalAmountPayable.TabIndex = 37;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(17, 301);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 16);
            this.label5.TabIndex = 36;
            this.label5.Text = "Total Amount Payable :";
            // 
            // btnOK
            // 
            this.btnOK.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnOK.BackgroundImage")));
            this.btnOK.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.Location = new System.Drawing.Point(244, 350);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(161, 54);
            this.btnOK.TabIndex = 35;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // txtPreviousBalance
            // 
            this.txtPreviousBalance.Location = new System.Drawing.Point(166, 258);
            this.txtPreviousBalance.Name = "txtPreviousBalance";
            this.txtPreviousBalance.ReadOnly = true;
            this.txtPreviousBalance.Size = new System.Drawing.Size(260, 20);
            this.txtPreviousBalance.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(46, 260);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 16);
            this.label4.TabIndex = 27;
            this.label4.Text = "Previous Balance :";
            // 
            // txtAmountPayable
            // 
            this.txtAmountPayable.Location = new System.Drawing.Point(166, 209);
            this.txtAmountPayable.Name = "txtAmountPayable";
            this.txtAmountPayable.ReadOnly = true;
            this.txtAmountPayable.Size = new System.Drawing.Size(260, 20);
            this.txtAmountPayable.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(80, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 16);
            this.label3.TabIndex = 28;
            this.label3.Text = "Issue Type :";
            // 
            // txtIssueType
            // 
            this.txtIssueType.Location = new System.Drawing.Point(166, 72);
            this.txtIssueType.Name = "txtIssueType";
            this.txtIssueType.ReadOnly = true;
            this.txtIssueType.Size = new System.Drawing.Size(260, 20);
            this.txtIssueType.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(50, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 16);
            this.label2.TabIndex = 29;
            this.label2.Text = "Amount Payable :";
            // 
            // txtPreviousAdvance
            // 
            this.txtPreviousAdvance.Location = new System.Drawing.Point(166, 161);
            this.txtPreviousAdvance.Name = "txtPreviousAdvance";
            this.txtPreviousAdvance.ReadOnly = true;
            this.txtPreviousAdvance.Size = new System.Drawing.Size(260, 20);
            this.txtPreviousAdvance.TabIndex = 42;
            // 
            // lblPreviousAdvance
            // 
            this.lblPreviousAdvance.AutoSize = true;
            this.lblPreviousAdvance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreviousAdvance.ForeColor = System.Drawing.Color.White;
            this.lblPreviousAdvance.Location = new System.Drawing.Point(39, 163);
            this.lblPreviousAdvance.Name = "lblPreviousAdvance";
            this.lblPreviousAdvance.Size = new System.Drawing.Size(117, 16);
            this.lblPreviousAdvance.TabIndex = 41;
            this.lblPreviousAdvance.Text = "Previous Advance :";
            // 
            // frmIssuePreview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(479, 434);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmIssuePreview";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Preview";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label20;
        internal System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCancel;
        internal System.Windows.Forms.TextBox txtBookPrice;
        private System.Windows.Forms.Label label6;
        internal System.Windows.Forms.TextBox txtTotalAmountPayable;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnOK;
        internal System.Windows.Forms.TextBox txtPreviousBalance;
        private System.Windows.Forms.Label label4;
        internal System.Windows.Forms.TextBox txtAmountPayable;
        private System.Windows.Forms.Label label3;
        internal System.Windows.Forms.TextBox txtIssueType;
        private System.Windows.Forms.Label label2;
        internal System.Windows.Forms.TextBox txtPreviousAdvance;
        private System.Windows.Forms.Label lblPreviousAdvance;
    }
}