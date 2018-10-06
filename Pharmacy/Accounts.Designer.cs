namespace Pharmacy
{
    partial class Accounts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Accounts));
            this.dtgrdvwAccounts = new System.Windows.Forms.DataGridView();
            this.btnAccountsBack = new System.Windows.Forms.Button();
            this.btnAccountExit = new System.Windows.Forms.Button();
            this.btnAccountsPrint = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrdvwAccounts)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgrdvwAccounts
            // 
            this.dtgrdvwAccounts.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgrdvwAccounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrdvwAccounts.Location = new System.Drawing.Point(44, 199);
            this.dtgrdvwAccounts.Name = "dtgrdvwAccounts";
            this.dtgrdvwAccounts.Size = new System.Drawing.Size(1106, 302);
            this.dtgrdvwAccounts.TabIndex = 0;
            // 
            // btnAccountsBack
            // 
            this.btnAccountsBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccountsBack.Location = new System.Drawing.Point(925, 564);
            this.btnAccountsBack.Name = "btnAccountsBack";
            this.btnAccountsBack.Size = new System.Drawing.Size(90, 34);
            this.btnAccountsBack.TabIndex = 56;
            this.btnAccountsBack.Text = "Back";
            this.btnAccountsBack.UseVisualStyleBackColor = true;
            this.btnAccountsBack.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAccountExit
            // 
            this.btnAccountExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccountExit.Location = new System.Drawing.Point(1043, 564);
            this.btnAccountExit.Name = "btnAccountExit";
            this.btnAccountExit.Size = new System.Drawing.Size(90, 34);
            this.btnAccountExit.TabIndex = 55;
            this.btnAccountExit.Text = "Exit";
            this.btnAccountExit.UseVisualStyleBackColor = true;
            this.btnAccountExit.Click += new System.EventHandler(this.btnAccountExit_Click);
            // 
            // btnAccountsPrint
            // 
            this.btnAccountsPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccountsPrint.Location = new System.Drawing.Point(522, 564);
            this.btnAccountsPrint.Name = "btnAccountsPrint";
            this.btnAccountsPrint.Size = new System.Drawing.Size(90, 34);
            this.btnAccountsPrint.TabIndex = 57;
            this.btnAccountsPrint.Text = "Print";
            this.btnAccountsPrint.UseVisualStyleBackColor = true;
            this.btnAccountsPrint.Click += new System.EventHandler(this.btnAccountsPrint_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(512, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 55);
            this.label1.TabIndex = 58;
            this.label1.Text = "Accounts";
            // 
            // Accounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1218, 640);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAccountsPrint);
            this.Controls.Add(this.btnAccountsBack);
            this.Controls.Add(this.btnAccountExit);
            this.Controls.Add(this.dtgrdvwAccounts);
            this.Name = "Accounts";
            this.Text = "Accounts";
            this.Load += new System.EventHandler(this.Accounts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgrdvwAccounts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgrdvwAccounts;
        private System.Windows.Forms.Button btnAccountsBack;
        private System.Windows.Forms.Button btnAccountExit;
        private System.Windows.Forms.Button btnAccountsPrint;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Label label1;
    }
}