namespace Arac_Kiralama_Programi__WinForm_OOP__
{
    partial class frmModels
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
            this.btnDeleteModel = new System.Windows.Forms.Button();
            this.btnSaveModel = new System.Windows.Forms.Button();
            this.btnAddModel = new System.Windows.Forms.Button();
            this.txtModelName = new System.Windows.Forms.TextBox();
            this.lstModelNames = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnDeleteModel
            // 
            this.btnDeleteModel.Enabled = false;
            this.btnDeleteModel.Location = new System.Drawing.Point(244, 654);
            this.btnDeleteModel.Name = "btnDeleteModel";
            this.btnDeleteModel.Size = new System.Drawing.Size(106, 34);
            this.btnDeleteModel.TabIndex = 5;
            this.btnDeleteModel.Text = "Sil";
            this.btnDeleteModel.UseVisualStyleBackColor = true;
            this.btnDeleteModel.Click += new System.EventHandler(this.btnDeleteModel_Click);
            // 
            // btnSaveModel
            // 
            this.btnSaveModel.Enabled = false;
            this.btnSaveModel.Location = new System.Drawing.Point(128, 654);
            this.btnSaveModel.Name = "btnSaveModel";
            this.btnSaveModel.Size = new System.Drawing.Size(110, 34);
            this.btnSaveModel.TabIndex = 6;
            this.btnSaveModel.Text = "Kaydet";
            this.btnSaveModel.UseVisualStyleBackColor = true;
            this.btnSaveModel.Click += new System.EventHandler(this.btnSaveModel_Click);
            // 
            // btnAddModel
            // 
            this.btnAddModel.Enabled = false;
            this.btnAddModel.Location = new System.Drawing.Point(12, 654);
            this.btnAddModel.Name = "btnAddModel";
            this.btnAddModel.Size = new System.Drawing.Size(110, 34);
            this.btnAddModel.TabIndex = 7;
            this.btnAddModel.Text = "Ekle";
            this.btnAddModel.UseVisualStyleBackColor = true;
            this.btnAddModel.Click += new System.EventHandler(this.btnAddModel_Click);
            // 
            // txtModelName
            // 
            this.txtModelName.Location = new System.Drawing.Point(12, 608);
            this.txtModelName.Name = "txtModelName";
            this.txtModelName.PlaceholderText = "Model Adı giriniz...";
            this.txtModelName.Size = new System.Drawing.Size(338, 31);
            this.txtModelName.TabIndex = 4;
            this.txtModelName.TextChanged += new System.EventHandler(this.txtModelName_TextChanged);
            // 
            // lstModelNames
            // 
            this.lstModelNames.FormattingEnabled = true;
            this.lstModelNames.ItemHeight = 25;
            this.lstModelNames.Location = new System.Drawing.Point(12, 12);
            this.lstModelNames.Name = "lstModelNames";
            this.lstModelNames.Size = new System.Drawing.Size(338, 579);
            this.lstModelNames.TabIndex = 3;
            this.lstModelNames.SelectedIndexChanged += new System.EventHandler(this.lstModelNames_SelectedIndexChanged);
            // 
            // frmModels
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 700);
            this.Controls.Add(this.btnDeleteModel);
            this.Controls.Add(this.btnSaveModel);
            this.Controls.Add(this.btnAddModel);
            this.Controls.Add(this.txtModelName);
            this.Controls.Add(this.lstModelNames);
            this.Name = "frmModels";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmModels";
            this.Load += new System.EventHandler(this.frmModels_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnDeleteModel;
        private Button btnSaveModel;
        private Button btnAddModel;
        private TextBox txtModelName;
        private ListBox lstModelNames;
    }
}