namespace Pharmacy
{
    partial class SalesDetails
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
            this.dtgrdvwSD = new System.Windows.Forms.DataGridView();
            this.btnSDDelete = new System.Windows.Forms.Button();
            this.btnSDEdit = new System.Windows.Forms.Button();
            this.btnSDAdd = new System.Windows.Forms.Button();
            this.btnSDExit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSDPrice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbSDGroupName = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtSDMedicineName = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.cmbSDCompanyName = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtSDQty = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtSDMedicineId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSDBack = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSDMedicineNameSearch = new System.Windows.Forms.TextBox();
            this.btnSDSearch = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrdvwSD)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgrdvwSD
            // 
            this.dtgrdvwSD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrdvwSD.Location = new System.Drawing.Point(641, 165);
            this.dtgrdvwSD.Name = "dtgrdvwSD";
            this.dtgrdvwSD.Size = new System.Drawing.Size(538, 250);
            this.dtgrdvwSD.TabIndex = 35;
            // 
            // btnSDDelete
            // 
            this.btnSDDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSDDelete.Location = new System.Drawing.Point(13, 54);
            this.btnSDDelete.Name = "btnSDDelete";
            this.btnSDDelete.Size = new System.Drawing.Size(130, 34);
            this.btnSDDelete.TabIndex = 42;
            this.btnSDDelete.Text = "Delete";
            this.btnSDDelete.UseVisualStyleBackColor = true;
            this.btnSDDelete.Click += new System.EventHandler(this.btnSDDelete_Click);
            // 
            // btnSDEdit
            // 
            this.btnSDEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSDEdit.Location = new System.Drawing.Point(13, 10);
            this.btnSDEdit.Name = "btnSDEdit";
            this.btnSDEdit.Size = new System.Drawing.Size(130, 36);
            this.btnSDEdit.TabIndex = 41;
            this.btnSDEdit.Text = "Edit";
            this.btnSDEdit.UseVisualStyleBackColor = true;
            this.btnSDEdit.Click += new System.EventHandler(this.btnSDEdit_Click);
            // 
            // btnSDAdd
            // 
            this.btnSDAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSDAdd.Location = new System.Drawing.Point(33, 465);
            this.btnSDAdd.Name = "btnSDAdd";
            this.btnSDAdd.Size = new System.Drawing.Size(130, 43);
            this.btnSDAdd.TabIndex = 40;
            this.btnSDAdd.Text = "Add";
            this.btnSDAdd.UseVisualStyleBackColor = true;
            this.btnSDAdd.Click += new System.EventHandler(this.btnSDAdd_Click);
            // 
            // btnSDExit
            // 
            this.btnSDExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSDExit.Location = new System.Drawing.Point(1089, 581);
            this.btnSDExit.Name = "btnSDExit";
            this.btnSDExit.Size = new System.Drawing.Size(90, 34);
            this.btnSDExit.TabIndex = 39;
            this.btnSDExit.Text = "Exit";
            this.btnSDExit.UseVisualStyleBackColor = true;
            this.btnSDExit.Click += new System.EventHandler(this.btnSDExit_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtSDPrice);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cmbSDGroupName);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.txtSDMedicineName);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.cmbSDCompanyName);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.txtSDQty);
            this.panel1.Location = new System.Drawing.Point(20, 165);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(615, 250);
            this.panel1.TabIndex = 45;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(38, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 29);
            this.label3.TabIndex = 54;
            this.label3.Text = "Price (per box)";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSDPrice
            // 
            this.txtSDPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSDPrice.Location = new System.Drawing.Point(323, 187);
            this.txtSDPrice.Name = "txtSDPrice";
            this.txtSDPrice.Size = new System.Drawing.Size(253, 29);
            this.txtSDPrice.TabIndex = 53;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 32);
            this.label1.TabIndex = 52;
            this.label1.Text = "Group Name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbSDGroupName
            // 
            this.cmbSDGroupName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSDGroupName.FormattingEnabled = true;
            this.cmbSDGroupName.Location = new System.Drawing.Point(323, 59);
            this.cmbSDGroupName.Name = "cmbSDGroupName";
            this.cmbSDGroupName.Size = new System.Drawing.Size(253, 32);
            this.cmbSDGroupName.TabIndex = 51;
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(38, 104);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(182, 29);
            this.label13.TabIndex = 50;
            this.label13.Text = "Medicine Name";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSDMedicineName
            // 
            this.txtSDMedicineName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSDMedicineName.Location = new System.Drawing.Point(323, 103);
            this.txtSDMedicineName.Name = "txtSDMedicineName";
            this.txtSDMedicineName.Size = new System.Drawing.Size(253, 29);
            this.txtSDMedicineName.TabIndex = 49;
            // 
            // label16
            // 
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(38, 16);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(182, 32);
            this.label16.TabIndex = 46;
            this.label16.Text = "Company name";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbSDCompanyName
            // 
            this.cmbSDCompanyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSDCompanyName.FormattingEnabled = true;
            this.cmbSDCompanyName.Items.AddRange(new object[] {
            "Square",
            "Incepta",
            "Aci"});
            this.cmbSDCompanyName.Location = new System.Drawing.Point(323, 16);
            this.cmbSDCompanyName.Name = "cmbSDCompanyName";
            this.cmbSDCompanyName.Size = new System.Drawing.Size(253, 32);
            this.cmbSDCompanyName.TabIndex = 45;
            this.cmbSDCompanyName.SelectedIndexChanged += new System.EventHandler(this.cmbSDCompanyName_SelectedIndexChanged);
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(38, 143);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(182, 29);
            this.label14.TabIndex = 48;
            this.label14.Text = "Qty";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSDQty
            // 
            this.txtSDQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSDQty.Location = new System.Drawing.Point(323, 143);
            this.txtSDQty.Name = "txtSDQty";
            this.txtSDQty.Size = new System.Drawing.Size(253, 29);
            this.txtSDQty.TabIndex = 47;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.txtSDMedicineId);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.btnSDEdit);
            this.panel2.Controls.Add(this.btnSDDelete);
            this.panel2.Location = new System.Drawing.Point(20, 527);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(530, 98);
            this.panel2.TabIndex = 53;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // txtSDMedicineId
            // 
            this.txtSDMedicineId.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSDMedicineId.Location = new System.Drawing.Point(323, 35);
            this.txtSDMedicineId.Name = "txtSDMedicineId";
            this.txtSDMedicineId.Size = new System.Drawing.Size(179, 29);
            this.txtSDMedicineId.TabIndex = 54;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(174, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 29);
            this.label4.TabIndex = 49;
            this.label4.Text = "Medicine Id";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSDBack
            // 
            this.btnSDBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSDBack.Location = new System.Drawing.Point(971, 581);
            this.btnSDBack.Name = "btnSDBack";
            this.btnSDBack.Size = new System.Drawing.Size(90, 34);
            this.btnSDBack.TabIndex = 54;
            this.btnSDBack.Text = "Back";
            this.btnSDBack.UseVisualStyleBackColor = true;
            this.btnSDBack.Click += new System.EventHandler(this.btnSDBack_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 29);
            this.label2.TabIndex = 54;
            this.label2.Text = "Company Name";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSDMedicineNameSearch
            // 
            this.txtSDMedicineNameSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSDMedicineNameSearch.Location = new System.Drawing.Point(219, 18);
            this.txtSDMedicineNameSearch.Name = "txtSDMedicineNameSearch";
            this.txtSDMedicineNameSearch.Size = new System.Drawing.Size(151, 29);
            this.txtSDMedicineNameSearch.TabIndex = 53;
            // 
            // btnSDSearch
            // 
            this.btnSDSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSDSearch.Location = new System.Drawing.Point(24, 57);
            this.btnSDSearch.Name = "btnSDSearch";
            this.btnSDSearch.Size = new System.Drawing.Size(346, 33);
            this.btnSDSearch.TabIndex = 43;
            this.btnSDSearch.Text = "Search";
            this.btnSDSearch.UseVisualStyleBackColor = true;
            this.btnSDSearch.Click += new System.EventHandler(this.btnSDSearch_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.btnSDSearch);
            this.panel3.Controls.Add(this.txtSDMedicineNameSearch);
            this.panel3.Location = new System.Drawing.Point(565, 527);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(390, 98);
            this.panel3.TabIndex = 55;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(403, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(474, 66);
            this.label5.TabIndex = 56;
            this.label5.Text = "Sales Details";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SalesDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1202, 696);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnSDAdd);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btnSDBack);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSDExit);
            this.Controls.Add(this.dtgrdvwSD);
            this.Name = "SalesDetails";
            this.Text = "SalesDetails";
            this.Load += new System.EventHandler(this.SalesDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgrdvwSD)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgrdvwSD;
        private System.Windows.Forms.Button btnSDDelete;
        private System.Windows.Forms.Button btnSDEdit;
        private System.Windows.Forms.Button btnSDAdd;
        private System.Windows.Forms.Button btnSDExit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbSDGroupName;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtSDMedicineName;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cmbSDCompanyName;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtSDQty;
        private System.Windows.Forms.Button btnSDBack;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSDMedicineNameSearch;
        private System.Windows.Forms.Button btnSDSearch;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSDPrice;
        private System.Windows.Forms.TextBox txtSDMedicineId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}