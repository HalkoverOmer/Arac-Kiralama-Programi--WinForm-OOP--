namespace Arac_Kiralama_Programi__WinForm_OOP__
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dosyaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kaydetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yenidenBaşlatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.markaYönetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmModels = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lstCars = new System.Windows.Forms.ListBox();
            this.btnCarsDelete = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pbPicture = new System.Windows.Forms.PictureBox();
            this.btnCarInfoAdd = new System.Windows.Forms.Button();
            this.btnSelectImage = new System.Windows.Forms.Button();
            this.chkRent = new System.Windows.Forms.CheckBox();
            this.nudDailyPrice = new System.Windows.Forms.NumericUpDown();
            this.nudYear = new System.Windows.Forms.NumericUpDown();
            this.nudKM = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbModels = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbBrand = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.btnRent = new System.Windows.Forms.Button();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.txtCustomerSN = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.nudFirstPayment = new System.Windows.Forms.NumericUpDown();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lstCustomerRents = new System.Windows.Forms.ListBox();
            this.btnDeleteRent = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDailyPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKM)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudFirstPayment)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dosyaToolStripMenuItem,
            this.markaYönetToolStripMenuItem,
            this.tsmModels});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1682, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dosyaToolStripMenuItem
            // 
            this.dosyaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kaydetToolStripMenuItem,
            this.yenidenBaşlatToolStripMenuItem,
            this.toolStripMenuItem1,
            this.çıkışToolStripMenuItem});
            this.dosyaToolStripMenuItem.Name = "dosyaToolStripMenuItem";
            this.dosyaToolStripMenuItem.Size = new System.Drawing.Size(78, 29);
            this.dosyaToolStripMenuItem.Text = "Dosya";
            // 
            // kaydetToolStripMenuItem
            // 
            this.kaydetToolStripMenuItem.Name = "kaydetToolStripMenuItem";
            this.kaydetToolStripMenuItem.Size = new System.Drawing.Size(226, 34);
            this.kaydetToolStripMenuItem.Text = "Kaydet";
            this.kaydetToolStripMenuItem.Click += new System.EventHandler(this.kaydetToolStripMenuItem_Click);
            // 
            // yenidenBaşlatToolStripMenuItem
            // 
            this.yenidenBaşlatToolStripMenuItem.Name = "yenidenBaşlatToolStripMenuItem";
            this.yenidenBaşlatToolStripMenuItem.Size = new System.Drawing.Size(226, 34);
            this.yenidenBaşlatToolStripMenuItem.Text = "Yeniden Başlat";
            this.yenidenBaşlatToolStripMenuItem.Click += new System.EventHandler(this.yenidenBaşlatToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(223, 6);
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(226, 34);
            this.çıkışToolStripMenuItem.Text = "Çıkış";
            this.çıkışToolStripMenuItem.Click += new System.EventHandler(this.çıkışToolStripMenuItem_Click);
            // 
            // markaYönetToolStripMenuItem
            // 
            this.markaYönetToolStripMenuItem.Name = "markaYönetToolStripMenuItem";
            this.markaYönetToolStripMenuItem.Size = new System.Drawing.Size(126, 29);
            this.markaYönetToolStripMenuItem.Text = "Marka Yönet";
            this.markaYönetToolStripMenuItem.Click += new System.EventHandler(this.markaYönetToolStripMenuItem_Click);
            // 
            // tsmModels
            // 
            this.tsmModels.Name = "tsmModels";
            this.tsmModels.Size = new System.Drawing.Size(128, 29);
            this.tsmModels.Text = "Model Yönet";
            this.tsmModels.Click += new System.EventHandler(this.tsmModels_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstCars);
            this.groupBox1.Controls.Add(this.btnCarsDelete);
            this.groupBox1.Location = new System.Drawing.Point(12, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(314, 816);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Araçlar";
            // 
            // lstCars
            // 
            this.lstCars.FormattingEnabled = true;
            this.lstCars.ItemHeight = 25;
            this.lstCars.Location = new System.Drawing.Point(6, 30);
            this.lstCars.Name = "lstCars";
            this.lstCars.Size = new System.Drawing.Size(302, 729);
            this.lstCars.TabIndex = 1;
            // 
            // btnCarsDelete
            // 
            this.btnCarsDelete.Location = new System.Drawing.Point(196, 774);
            this.btnCarsDelete.Name = "btnCarsDelete";
            this.btnCarsDelete.Size = new System.Drawing.Size(112, 34);
            this.btnCarsDelete.TabIndex = 0;
            this.btnCarsDelete.Text = "Sil";
            this.btnCarsDelete.UseVisualStyleBackColor = true;
            this.btnCarsDelete.Click += new System.EventHandler(this.btnCarsDelete_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pbPicture);
            this.groupBox2.Controls.Add(this.btnCarInfoAdd);
            this.groupBox2.Controls.Add(this.btnSelectImage);
            this.groupBox2.Controls.Add(this.chkRent);
            this.groupBox2.Controls.Add(this.nudDailyPrice);
            this.groupBox2.Controls.Add(this.nudYear);
            this.groupBox2.Controls.Add(this.nudKM);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.cmbModels);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.cmbBrand);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(332, 58);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(323, 816);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Araç Bilgileri";
            // 
            // pbPicture
            // 
            this.pbPicture.Location = new System.Drawing.Point(6, 451);
            this.pbPicture.Name = "pbPicture";
            this.pbPicture.Size = new System.Drawing.Size(311, 258);
            this.pbPicture.TabIndex = 4;
            this.pbPicture.TabStop = false;
            // 
            // btnCarInfoAdd
            // 
            this.btnCarInfoAdd.Location = new System.Drawing.Point(205, 774);
            this.btnCarInfoAdd.Name = "btnCarInfoAdd";
            this.btnCarInfoAdd.Size = new System.Drawing.Size(112, 34);
            this.btnCarInfoAdd.TabIndex = 8;
            this.btnCarInfoAdd.Text = "Ekle";
            this.btnCarInfoAdd.UseVisualStyleBackColor = true;
            this.btnCarInfoAdd.Click += new System.EventHandler(this.btnCarInfoAdd_Click);
            // 
            // btnSelectImage
            // 
            this.btnSelectImage.Location = new System.Drawing.Point(205, 715);
            this.btnSelectImage.Name = "btnSelectImage";
            this.btnSelectImage.Size = new System.Drawing.Size(112, 34);
            this.btnSelectImage.TabIndex = 7;
            this.btnSelectImage.Text = "Resim Seç";
            this.btnSelectImage.UseVisualStyleBackColor = true;
            this.btnSelectImage.Click += new System.EventHandler(this.btnSelectImage_Click);
            // 
            // chkRent
            // 
            this.chkRent.AutoSize = true;
            this.chkRent.Location = new System.Drawing.Point(6, 405);
            this.chkRent.Name = "chkRent";
            this.chkRent.Size = new System.Drawing.Size(128, 29);
            this.chkRent.TabIndex = 6;
            this.chkRent.Text = "Kiralanabilir";
            this.chkRent.UseVisualStyleBackColor = true;
            // 
            // nudDailyPrice
            // 
            this.nudDailyPrice.DecimalPlaces = 2;
            this.nudDailyPrice.Location = new System.Drawing.Point(6, 359);
            this.nudDailyPrice.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudDailyPrice.Name = "nudDailyPrice";
            this.nudDailyPrice.Size = new System.Drawing.Size(311, 31);
            this.nudDailyPrice.TabIndex = 5;
            // 
            // nudYear
            // 
            this.nudYear.Location = new System.Drawing.Point(6, 287);
            this.nudYear.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.nudYear.Minimum = new decimal(new int[] {
            1940,
            0,
            0,
            0});
            this.nudYear.Name = "nudYear";
            this.nudYear.Size = new System.Drawing.Size(311, 31);
            this.nudYear.TabIndex = 4;
            this.nudYear.Value = new decimal(new int[] {
            1940,
            0,
            0,
            0});
            // 
            // nudKM
            // 
            this.nudKM.Location = new System.Drawing.Point(6, 213);
            this.nudKM.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nudKM.Name = "nudKM";
            this.nudKM.Size = new System.Drawing.Size(311, 31);
            this.nudKM.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 331);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "Günlük Fiyat";
            // 
            // cmbModels
            // 
            this.cmbModels.FormattingEnabled = true;
            this.cmbModels.Location = new System.Drawing.Point(6, 135);
            this.cmbModels.Name = "cmbModels";
            this.cmbModels.Size = new System.Drawing.Size(311, 33);
            this.cmbModels.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 259);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Yılı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "KM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Modeller";
            // 
            // cmbBrand
            // 
            this.cmbBrand.FormattingEnabled = true;
            this.cmbBrand.Location = new System.Drawing.Point(6, 58);
            this.cmbBrand.Name = "cmbBrand";
            this.cmbBrand.Size = new System.Drawing.Size(311, 33);
            this.cmbBrand.TabIndex = 1;
            this.cmbBrand.SelectedIndexChanged += new System.EventHandler(this.cmbBrand_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Markalar";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dtpEndDate);
            this.groupBox3.Controls.Add(this.btnRent);
            this.groupBox3.Controls.Add(this.dtpStartDate);
            this.groupBox3.Controls.Add(this.txtCustomerSN);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.nudFirstPayment);
            this.groupBox3.Controls.Add(this.txtCustomerName);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Location = new System.Drawing.Point(661, 58);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(336, 816);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Kiralayan Bilgileri";
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Location = new System.Drawing.Point(6, 287);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(324, 31);
            this.dtpEndDate.TabIndex = 12;
            // 
            // btnRent
            // 
            this.btnRent.Location = new System.Drawing.Point(218, 400);
            this.btnRent.Name = "btnRent";
            this.btnRent.Size = new System.Drawing.Size(112, 34);
            this.btnRent.TabIndex = 14;
            this.btnRent.Text = "Kirala";
            this.btnRent.UseVisualStyleBackColor = true;
            this.btnRent.Click += new System.EventHandler(this.btnRent_Click);
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Location = new System.Drawing.Point(6, 213);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(324, 31);
            this.dtpStartDate.TabIndex = 11;
            // 
            // txtCustomerSN
            // 
            this.txtCustomerSN.Location = new System.Drawing.Point(6, 137);
            this.txtCustomerSN.Name = "txtCustomerSN";
            this.txtCustomerSN.Size = new System.Drawing.Size(324, 31);
            this.txtCustomerSN.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 259);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 25);
            this.label9.TabIndex = 0;
            this.label9.Text = "Bitiş Tarihi";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 185);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(130, 25);
            this.label8.TabIndex = 0;
            this.label8.Text = "Başlangıç Tarihi";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 107);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 25);
            this.label7.TabIndex = 0;
            this.label7.Text = "Müşteri TC No";
            // 
            // nudFirstPayment
            // 
            this.nudFirstPayment.Location = new System.Drawing.Point(6, 359);
            this.nudFirstPayment.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudFirstPayment.Name = "nudFirstPayment";
            this.nudFirstPayment.Size = new System.Drawing.Size(324, 31);
            this.nudFirstPayment.TabIndex = 13;
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(6, 60);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(324, 31);
            this.txtCustomerName.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(154, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "Müşteri Ad Soyad";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 331);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 25);
            this.label10.TabIndex = 0;
            this.label10.Text = "Kaparo";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lstCustomerRents);
            this.groupBox4.Controls.Add(this.btnDeleteRent);
            this.groupBox4.Location = new System.Drawing.Point(1003, 58);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(651, 816);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Kiralama Listesi";
            // 
            // lstCustomerRents
            // 
            this.lstCustomerRents.FormattingEnabled = true;
            this.lstCustomerRents.ItemHeight = 25;
            this.lstCustomerRents.Location = new System.Drawing.Point(6, 30);
            this.lstCustomerRents.Name = "lstCustomerRents";
            this.lstCustomerRents.Size = new System.Drawing.Size(639, 729);
            this.lstCustomerRents.TabIndex = 0;
            // 
            // btnDeleteRent
            // 
            this.btnDeleteRent.Location = new System.Drawing.Point(533, 774);
            this.btnDeleteRent.Name = "btnDeleteRent";
            this.btnDeleteRent.Size = new System.Drawing.Size(112, 34);
            this.btnDeleteRent.TabIndex = 0;
            this.btnDeleteRent.Text = "Sil";
            this.btnDeleteRent.UseVisualStyleBackColor = true;
            this.btnDeleteRent.Click += new System.EventHandler(this.btnDeleteRent_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1682, 887);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Araç Kiralama Yazılımı";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDailyPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKM)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudFirstPayment)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem dosyaToolStripMenuItem;
        private ToolStripMenuItem kaydetToolStripMenuItem;
        private ToolStripMenuItem yenidenBaşlatToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem çıkışToolStripMenuItem;
        private ToolStripMenuItem markaYönetToolStripMenuItem;
        private ToolStripMenuItem tsmModels;
        private GroupBox groupBox1;
        private ListBox lstCars;
        private Button btnCarsDelete;
        private GroupBox groupBox2;
        private PictureBox pbPicture;
        private Button btnCarInfoAdd;
        private Button btnSelectImage;
        private CheckBox chkRent;
        private NumericUpDown nudDailyPrice;
        private NumericUpDown nudYear;
        private NumericUpDown nudKM;
        private Label label5;
        private ComboBox cmbModels;
        private Label label4;
        private Label label3;
        private Label label2;
        private ComboBox cmbBrand;
        private Label label1;
        private GroupBox groupBox3;
        private DateTimePicker dtpEndDate;
        private Button btnRent;
        private DateTimePicker dtpStartDate;
        private TextBox txtCustomerSN;
        private Label label9;
        private Label label8;
        private Label label7;
        private NumericUpDown nudFirstPayment;
        private TextBox txtCustomerName;
        private Label label6;
        private Label label10;
        private GroupBox groupBox4;
        private ListBox lstCustomerRents;
        private Button btnDeleteRent;
    }
}