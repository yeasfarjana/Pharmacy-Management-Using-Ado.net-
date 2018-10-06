namespace Pharmacy
{
    partial class StockDetails
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
            this.dtgrdvwSDetails = new System.Windows.Forms.DataGridView();
            this.btnSDetailsExit = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSDetailsRefrash = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrdvwSDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgrdvwSDetails
            // 
            this.dtgrdvwSDetails.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgrdvwSDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrdvwSDetails.Location = new System.Drawing.Point(53, 131);
            this.dtgrdvwSDetails.Name = "dtgrdvwSDetails";
            this.dtgrdvwSDetails.Size = new System.Drawing.Size(1134, 355);
            this.dtgrdvwSDetails.TabIndex = 36;
            // 
            // btnSDetailsExit
            // 
            this.btnSDetailsExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSDetailsExit.Location = new System.Drawing.Point(979, 531);
            this.btnSDetailsExit.Name = "btnSDetailsExit";
            this.btnSDetailsExit.Size = new System.Drawing.Size(90, 34);
            this.btnSDetailsExit.TabIndex = 56;
            this.btnSDetailsExit.Text = "Back";
            this.btnSDetailsExit.UseVisualStyleBackColor = true;
            this.btnSDetailsExit.Click += new System.EventHandler(this.btnSDetailsExit_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(1097, 531);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(90, 34);
            this.btnExit.TabIndex = 55;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSDetailsRefrash
            // 
            this.btnSDetailsRefrash.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSDetailsRefrash.Location = new System.Drawing.Point(546, 531);
            this.btnSDetailsRefrash.Name = "btnSDetailsRefrash";
            this.btnSDetailsRefrash.Size = new System.Drawing.Size(90, 34);
            this.btnSDetailsRefrash.TabIndex = 57;
            this.btnSDetailsRefrash.Text = "Refrash";
            this.btnSDetailsRefrash.UseVisualStyleBackColor = true;
            this.btnSDetailsRefrash.Click += new System.EventHandler(this.btnSDetailsRefrash_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(495, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(316, 55);
            this.label1.TabIndex = 58;
            this.label1.Text = "Stock Details";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // StockDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1227, 605);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSDetailsRefrash);
            this.Controls.Add(this.btnSDetailsExit);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.dtgrdvwSDetails);
            this.Name = "StockDetails";
            this.Text = "Stock Details";
            ((System.ComponentModel.ISupportInitialize)(this.dtgrdvwSDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgrdvwSDetails;
        private System.Windows.Forms.Button btnSDetailsExit;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSDetailsRefrash;
        private System.Windows.Forms.Label label1;
    }
}