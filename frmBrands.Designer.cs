namespace Arac_Kiralama_Programi__WinForm_OOP__
{
    partial class frmBrands
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
            this.lstBrandNames = new System.Windows.Forms.ListBox();
            this.txtBrandName = new System.Windows.Forms.TextBox();
            this.btnAddBrand = new System.Windows.Forms.Button();
            this.btnSaveBrand = new System.Windows.Forms.Button();
            this.btnDeleteBrand = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstBrandNames
            // 
            this.lstBrandNames.FormattingEnabled = true;
            this.lstBrandNames.ItemHeight = 25;
            this.lstBrandNames.Location = new System.Drawing.Point(12, 12);
            this.lstBrandNames.Name = "lstBrandNames";
            this.lstBrandNames.Size = new System.Drawing.Size(338, 579);
            this.lstBrandNames.TabIndex = 0;
            this.lstBrandNames.SelectedIndexChanged += new System.EventHandler(this.lstBrandNames_SelectedIndexChanged);
            // 
            // txtBrandName
            // 
            this.txtBrandName.Location = new System.Drawing.Point(12, 608);
            this.txtBrandName.Name = "txtBrandName";
            this.txtBrandName.PlaceholderText = "Marka Adı giriniz...";
            this.txtBrandName.Size = new System.Drawing.Size(338, 31);
            this.txtBrandName.TabIndex = 1;
            this.txtBrandName.TextChanged += new System.EventHandler(this.txtBrandName_TextChanged);
            // 
            // btnAddBrand
            // 
            this.btnAddBrand.Enabled = false;
            this.btnAddBrand.Location = new System.Drawing.Point(12, 654);
            this.btnAddBrand.Name = "btnAddBrand";
            this.btnAddBrand.Size = new System.Drawing.Size(110, 34);
            this.btnAddBrand.TabIndex = 2;
            this.btnAddBrand.Text = "Ekle";
            this.btnAddBrand.UseVisualStyleBackColor = true;
            this.btnAddBrand.Click += new System.EventHandler(this.btnAddBrand_Click);
            // 
            // btnSaveBrand
            // 
            this.btnSaveBrand.Enabled = false;
            this.btnSaveBrand.Location = new System.Drawing.Point(128, 654);
            this.btnSaveBrand.Name = "btnSaveBrand";
            this.btnSaveBrand.Size = new System.Drawing.Size(110, 34);
            this.btnSaveBrand.TabIndex = 2;
            this.btnSaveBrand.Text = "Kaydet";
            this.btnSaveBrand.UseVisualStyleBackColor = true;
            this.btnSaveBrand.Click += new System.EventHandler(this.btnSaveBrand_Click);
            // 
            // btnDeleteBrand
            // 
            this.btnDeleteBrand.Enabled = false;
            this.btnDeleteBrand.Location = new System.Drawing.Point(244, 654);
            this.btnDeleteBrand.Name = "btnDeleteBrand";
            this.btnDeleteBrand.Size = new System.Drawing.Size(106, 34);
            this.btnDeleteBrand.TabIndex = 2;
            this.btnDeleteBrand.Text = "Sil";
            this.btnDeleteBrand.UseVisualStyleBackColor = true;
            this.btnDeleteBrand.Click += new System.EventHandler(this.btnDeleteBrand_Click);
            // 
            // frmBrands
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 700);
            this.Controls.Add(this.btnDeleteBrand);
            this.Controls.Add(this.btnSaveBrand);
            this.Controls.Add(this.btnAddBrand);
            this.Controls.Add(this.txtBrandName);
            this.Controls.Add(this.lstBrandNames);
            this.Name = "frmBrands";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmBrands";
            this.Load += new System.EventHandler(this.frmBrands_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox lstBrandNames;
        private TextBox txtBrandName;
        private Button btnAddBrand;
        private Button btnSaveBrand;
        private Button btnDeleteBrand;
    }
}