namespace Pharmacy
{
    partial class AferLogin
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
            this.btnSalesDetails = new System.Windows.Forms.Button();
            this.btnStockDetails = new System.Windows.Forms.Button();
            this.btnHRM = new System.Windows.Forms.Button();
            this.btnAccounts = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSalesDetails
            // 
            this.btnSalesDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalesDetails.Location = new System.Drawing.Point(215, 133);
            this.btnSalesDetails.Name = "btnSalesDetails";
            this.btnSalesDetails.Size = new System.Drawing.Size(273, 86);
            this.btnSalesDetails.TabIndex = 0;
            this.btnSalesDetails.Text = "Sales Details";
            this.btnSalesDetails.UseVisualStyleBackColor = true;
            this.btnSalesDetails.Click += new System.EventHandler(this.btnSalesDetails_Click);
            // 
            // btnStockDetails
            // 
            this.btnStockDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStockDetails.Location = new System.Drawing.Point(215, 279);
            this.btnStockDetails.Name = "btnStockDetails";
            this.btnStockDetails.Size = new System.Drawing.Size(273, 86);
            this.btnStockDetails.TabIndex = 1;
            this.btnStockDetails.Text = "Stock Details";
            this.btnStockDetails.UseVisualStyleBackColor = true;
            this.btnStockDetails.Click += new System.EventHandler(this.btnStockDetails_Click);
            // 
            // btnHRM
            // 
            this.btnHRM.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHRM.Location = new System.Drawing.Point(689, 133);
            this.btnHRM.Name = "btnHRM";
            this.btnHRM.Size = new System.Drawing.Size(273, 86);
            this.btnHRM.TabIndex = 2;
            this.btnHRM.Text = "HRM";
            this.btnHRM.UseVisualStyleBackColor = true;
            this.btnHRM.Click += new System.EventHandler(this.btnHRM_Click);
            // 
            // btnAccounts
            // 
            this.btnAccounts.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccounts.Location = new System.Drawing.Point(689, 279);
            this.btnAccounts.Name = "btnAccounts";
            this.btnAccounts.Size = new System.Drawing.Size(273, 86);
            this.btnAccounts.TabIndex = 3;
            this.btnAccounts.Text = "Accounts";
            this.btnAccounts.UseVisualStyleBackColor = true;
            this.btnAccounts.Click += new System.EventHandler(this.btnAccounts_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(1073, 425);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(90, 34);
            this.btnExit.TabIndex = 12;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // AferLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1191, 481);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAccounts);
            this.Controls.Add(this.btnHRM);
            this.Controls.Add(this.btnStockDetails);
            this.Controls.Add(this.btnSalesDetails);
            this.Name = "AferLogin";
            this.Text = "Pharmacy Management System";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSalesDetails;
        private System.Windows.Forms.Button btnStockDetails;
        private System.Windows.Forms.Button btnHRM;
        private System.Windows.Forms.Button btnAccounts;
        private System.Windows.Forms.Button btnExit;
    }
}