namespace LibraryDesign_frontEndUI
{
    partial class frmSell
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSell));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSearchStock = new System.Windows.Forms.Button();
            this.txtKeyWord = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblSellingPrice = new System.Windows.Forms.Label();
            this.lblActualPrice = new System.Windows.Forms.Label();
            this.lblISBN = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnSell = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtBalance = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSellingPrice = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCount = new System.Windows.Forms.TextBox();
            this.txtAdvance = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
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
            this.groupBox1.Size = new System.Drawing.Size(888, 87);
            this.groupBox1.TabIndex = 0;
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
            this.groupBox2.Controls.Add(this.lblSellingPrice);
            this.groupBox2.Controls.Add(this.lblActualPrice);
            this.groupBox2.Controls.Add(this.lblISBN);
            this.groupBox2.Controls.Add(this.tableLayoutPanel1);
            this.groupBox2.Controls.Add(this.txtBalance);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtSellingPrice);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtCount);
            this.groupBox2.Controls.Add(this.txtAdvance);
            this.groupBox2.Controls.Add(this.txtTitle);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtPrice);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtISBN);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(0, 93);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(888, 285);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // lblSellingPrice
            // 
            this.lblSellingPrice.AutoSize = true;
            this.lblSellingPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSellingPrice.ForeColor = System.Drawing.Color.Lime;
            this.lblSellingPrice.Location = new System.Drawing.Point(826, 95);
            this.lblSellingPrice.Name = "lblSellingPrice";
            this.lblSellingPrice.Size = new System.Drawing.Size(26, 31);
            this.lblSellingPrice.TabIndex = 12;
            this.lblSellingPrice.Text = "*";
            // 
            // lblActualPrice
            // 
            this.lblActualPrice.AutoSize = true;
            this.lblActualPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActualPrice.ForeColor = System.Drawing.Color.Lime;
            this.lblActualPrice.Location = new System.Drawing.Point(376, 76);
            this.lblActualPrice.Name = "lblActualPrice";
            this.lblActualPrice.Size = new System.Drawing.Size(26, 31);
            this.lblActualPrice.TabIndex = 12;
            this.lblActualPrice.Text = "*";
            // 
            // lblISBN
            // 
            this.lblISBN.AutoSize = true;
            this.lblISBN.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblISBN.ForeColor = System.Drawing.Color.Lime;
            this.lblISBN.Location = new System.Drawing.Point(376, 29);
            this.lblISBN.Name = "lblISBN";
            this.lblISBN.Size = new System.Drawing.Size(26, 31);
            this.lblISBN.TabIndex = 12;
            this.lblISBN.Text = "*";
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
            this.tableLayoutPanel1.Controls.Add(this.btnSell, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnCancel, 3, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 223);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(882, 59);
            this.tableLayoutPanel1.TabIndex = 11;
            // 
            // btnSell
            // 
            this.btnSell.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSell.BackgroundImage")));
            this.btnSell.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSell.ForeColor = System.Drawing.Color.White;
            this.btnSell.Location = new System.Drawing.Point(295, 3);
            this.btnSell.Name = "btnSell";
            this.btnSell.Size = new System.Drawing.Size(140, 53);
            this.btnSell.TabIndex = 7;
            this.btnSell.Text = "SELL";
            this.btnSell.UseVisualStyleBackColor = true;
            this.btnSell.Click += new System.EventHandler(this.btnSell_Click);
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
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtBalance
            // 
            this.txtBalance.Location = new System.Drawing.Point(584, 158);
            this.txtBalance.MaxLength = 10;
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.Size = new System.Drawing.Size(236, 20);
            this.txtBalance.TabIndex = 6;
            this.txtBalance.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Amount_Validation);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(507, 159);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 16);
            this.label7.TabIndex = 9;
            this.label7.Text = "Balance :";
            // 
            // txtSellingPrice
            // 
            this.txtSellingPrice.Location = new System.Drawing.Point(584, 95);
            this.txtSellingPrice.MaxLength = 10;
            this.txtSellingPrice.Name = "txtSellingPrice";
            this.txtSellingPrice.Size = new System.Drawing.Size(236, 20);
            this.txtSellingPrice.TabIndex = 5;
            this.txtSellingPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Amount_Validation);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(481, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Selling Price :";
            // 
            // txtCount
            // 
            this.txtCount.Location = new System.Drawing.Point(134, 167);
            this.txtCount.MaxLength = 2;
            this.txtCount.Name = "txtCount";
            this.txtCount.Size = new System.Drawing.Size(236, 20);
            this.txtCount.TabIndex = 3;
            this.txtCount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Number_Validation);
            // 
            // txtAdvance
            // 
            this.txtAdvance.Location = new System.Drawing.Point(134, 120);
            this.txtAdvance.MaxLength = 10;
            this.txtAdvance.Name = "txtAdvance";
            this.txtAdvance.Size = new System.Drawing.Size(236, 20);
            this.txtAdvance.TabIndex = 2;
            this.txtAdvance.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Amount_Validation);
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(584, 35);
            this.txtTitle.MaxLength = 100;
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.ReadOnly = true;
            this.txtTitle.Size = new System.Drawing.Size(236, 20);
            this.txtTitle.TabIndex = 4;
            this.txtTitle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Name_Validation);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(51, 168);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 16);
            this.label8.TabIndex = 7;
            this.label8.Text = "Count :";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(134, 76);
            this.txtPrice.MaxLength = 10;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.ReadOnly = true;
            this.txtPrice.Size = new System.Drawing.Size(236, 20);
            this.txtPrice.TabIndex = 1;
            this.txtPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Amount_Validation);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(37, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "Advance :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(526, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Title :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(57, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Price :";
            // 
            // txtISBN
            // 
            this.txtISBN.Location = new System.Drawing.Point(134, 29);
            this.txtISBN.MaxLength = 11;
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.ReadOnly = true;
            this.txtISBN.Size = new System.Drawing.Size(236, 20);
            this.txtISBN.TabIndex = 0;
            this.txtISBN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtISBN_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(57, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "ISBN :";
            // 
            // frmSell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(888, 378);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmSell";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sell";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmSell_FormClosing);
            this.Load += new System.EventHandler(this.frmSell_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtKeyWord;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearchStock;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        internal System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.Label label2;
        internal System.Windows.Forms.TextBox txtTitle;
        internal System.Windows.Forms.TextBox txtSellingPrice;
        internal System.Windows.Forms.TextBox txtPrice;
        internal System.Windows.Forms.TextBox txtBalance;
        internal System.Windows.Forms.TextBox txtAdvance;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        internal System.Windows.Forms.Button btnSell;
        internal System.Windows.Forms.Button btnCancel;
        internal System.Windows.Forms.TextBox txtCount;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblSellingPrice;
        private System.Windows.Forms.Label lblActualPrice;
        private System.Windows.Forms.Label lblISBN;
    }
}