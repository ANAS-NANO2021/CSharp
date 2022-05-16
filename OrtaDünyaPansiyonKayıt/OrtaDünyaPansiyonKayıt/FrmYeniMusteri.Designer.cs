
namespace OrtaDünyaPansiyonKayıt
{
    partial class FrmYeniMusteri
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CmbCinsiyet = new System.Windows.Forms.ComboBox();
            this.DtpCikisTarihi = new System.Windows.Forms.DateTimePicker();
            this.DtpGirisTarihi = new System.Windows.Forms.DateTimePicker();
            this.MstTelefon = new System.Windows.Forms.MaskedTextBox();
            this.TxtOdaNumarasi = new System.Windows.Forms.TextBox();
            this.TxtKimlikNo = new System.Windows.Forms.TextBox();
            this.TxtMail = new System.Windows.Forms.TextBox();
            this.TxtUcret = new System.Windows.Forms.TextBox();
            this.TxtSoyadi = new System.Windows.Forms.TextBox();
            this.TxtAdi = new System.Windows.Forms.TextBox();
            this.BtnKaydet = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Btn109 = new System.Windows.Forms.Button();
            this.Btn108 = new System.Windows.Forms.Button();
            this.Btn107 = new System.Windows.Forms.Button();
            this.Btn106 = new System.Windows.Forms.Button();
            this.Btn105 = new System.Windows.Forms.Button();
            this.Btn104 = new System.Windows.Forms.Button();
            this.Btn103 = new System.Windows.Forms.Button();
            this.Btn102 = new System.Windows.Forms.Button();
            this.Btn101 = new System.Windows.Forms.Button();
            this.BtnDolu = new System.Windows.Forms.Button();
            this.BtnBos = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CmbCinsiyet);
            this.groupBox1.Controls.Add(this.DtpCikisTarihi);
            this.groupBox1.Controls.Add(this.DtpGirisTarihi);
            this.groupBox1.Controls.Add(this.MstTelefon);
            this.groupBox1.Controls.Add(this.TxtOdaNumarasi);
            this.groupBox1.Controls.Add(this.TxtKimlikNo);
            this.groupBox1.Controls.Add(this.TxtMail);
            this.groupBox1.Controls.Add(this.TxtUcret);
            this.groupBox1.Controls.Add(this.TxtSoyadi);
            this.groupBox1.Controls.Add(this.TxtAdi);
            this.groupBox1.Controls.Add(this.BtnKaydet);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(32, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(404, 464);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Müşteri Bilgileri";
            // 
            // CmbCinsiyet
            // 
            this.CmbCinsiyet.FormattingEnabled = true;
            this.CmbCinsiyet.Items.AddRange(new object[] {
            "Bay",
            "Bayan"});
            this.CmbCinsiyet.Location = new System.Drawing.Point(143, 104);
            this.CmbCinsiyet.Name = "CmbCinsiyet";
            this.CmbCinsiyet.Size = new System.Drawing.Size(237, 28);
            this.CmbCinsiyet.TabIndex = 32;
            // 
            // DtpCikisTarihi
            // 
            this.DtpCikisTarihi.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DtpCikisTarihi.Location = new System.Drawing.Point(142, 352);
            this.DtpCikisTarihi.Name = "DtpCikisTarihi";
            this.DtpCikisTarihi.Size = new System.Drawing.Size(238, 30);
            this.DtpCikisTarihi.TabIndex = 31;
            this.DtpCikisTarihi.ValueChanged += new System.EventHandler(this.DtpCikisTarihi_ValueChanged);
            // 
            // DtpGirisTarihi
            // 
            this.DtpGirisTarihi.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DtpGirisTarihi.Location = new System.Drawing.Point(142, 315);
            this.DtpGirisTarihi.Name = "DtpGirisTarihi";
            this.DtpGirisTarihi.Size = new System.Drawing.Size(238, 30);
            this.DtpGirisTarihi.TabIndex = 30;
            this.DtpGirisTarihi.ValueChanged += new System.EventHandler(this.DtpGirisTarihi_ValueChanged);
            // 
            // MstTelefon
            // 
            this.MstTelefon.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MstTelefon.Location = new System.Drawing.Point(143, 136);
            this.MstTelefon.Mask = "(999) 000-0000";
            this.MstTelefon.Name = "MstTelefon";
            this.MstTelefon.Size = new System.Drawing.Size(237, 30);
            this.MstTelefon.TabIndex = 29;
            // 
            // TxtOdaNumarasi
            // 
            this.TxtOdaNumarasi.Enabled = false;
            this.TxtOdaNumarasi.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtOdaNumarasi.Location = new System.Drawing.Point(142, 274);
            this.TxtOdaNumarasi.Name = "TxtOdaNumarasi";
            this.TxtOdaNumarasi.Size = new System.Drawing.Size(238, 30);
            this.TxtOdaNumarasi.TabIndex = 28;
            // 
            // TxtKimlikNo
            // 
            this.TxtKimlikNo.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtKimlikNo.Location = new System.Drawing.Point(143, 239);
            this.TxtKimlikNo.MaxLength = 11;
            this.TxtKimlikNo.Name = "TxtKimlikNo";
            this.TxtKimlikNo.Size = new System.Drawing.Size(237, 30);
            this.TxtKimlikNo.TabIndex = 27;
            this.TxtKimlikNo.TextChanged += new System.EventHandler(this.TxtKimlikNo_TextChanged);
            // 
            // TxtMail
            // 
            this.TxtMail.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtMail.Location = new System.Drawing.Point(143, 206);
            this.TxtMail.Name = "TxtMail";
            this.TxtMail.Size = new System.Drawing.Size(237, 30);
            this.TxtMail.TabIndex = 26;
            this.TxtMail.TextChanged += new System.EventHandler(this.TxtMail_TextChanged);
            // 
            // TxtUcret
            // 
            this.TxtUcret.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUcret.Location = new System.Drawing.Point(142, 172);
            this.TxtUcret.Name = "TxtUcret";
            this.TxtUcret.Size = new System.Drawing.Size(237, 30);
            this.TxtUcret.TabIndex = 25;
            this.TxtUcret.TextChanged += new System.EventHandler(this.TxtUcret_TextChanged);
            // 
            // TxtSoyadi
            // 
            this.TxtSoyadi.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSoyadi.Location = new System.Drawing.Point(143, 68);
            this.TxtSoyadi.Name = "TxtSoyadi";
            this.TxtSoyadi.Size = new System.Drawing.Size(237, 30);
            this.TxtSoyadi.TabIndex = 23;
            this.TxtSoyadi.TextChanged += new System.EventHandler(this.TxtSoyadi_TextChanged);
            // 
            // TxtAdi
            // 
            this.TxtAdi.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtAdi.Location = new System.Drawing.Point(143, 32);
            this.TxtAdi.Name = "TxtAdi";
            this.TxtAdi.Size = new System.Drawing.Size(237, 30);
            this.TxtAdi.TabIndex = 22;
            this.TxtAdi.TextChanged += new System.EventHandler(this.TxtAdi_TextChanged);
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnKaydet.Location = new System.Drawing.Point(174, 401);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(117, 59);
            this.BtnKaydet.TabIndex = 21;
            this.BtnKaydet.Text = "Kaydet";
            this.BtnKaydet.UseVisualStyleBackColor = true;
            this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(38, 352);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(93, 23);
            this.label10.TabIndex = 20;
            this.label10.Text = "Çıkış tarihi:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(38, 315);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 23);
            this.label9.TabIndex = 19;
            this.label9.Text = "Giriş tarihi:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(5, 277);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 23);
            this.label8.TabIndex = 18;
            this.label8.Text = "Oda Numarası:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(10, 239);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 23);
            this.label7.TabIndex = 17;
            this.label7.Text = "T.C. Kimlik No:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(82, 206);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 23);
            this.label6.TabIndex = 16;
            this.label6.Text = "Mail:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(74, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 23);
            this.label5.TabIndex = 15;
            this.label5.Text = "Ücret:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(55, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 23);
            this.label4.TabIndex = 14;
            this.label4.Text = "Cinsiyet:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(60, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 23);
            this.label3.TabIndex = 13;
            this.label3.Text = "Telefon:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(64, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 23);
            this.label2.TabIndex = 12;
            this.label2.Text = "Soyadı:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(90, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 23);
            this.label1.TabIndex = 11;
            this.label1.Text = "Adı:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Btn109);
            this.groupBox2.Controls.Add(this.Btn108);
            this.groupBox2.Controls.Add(this.Btn107);
            this.groupBox2.Controls.Add(this.Btn106);
            this.groupBox2.Controls.Add(this.Btn105);
            this.groupBox2.Controls.Add(this.Btn104);
            this.groupBox2.Controls.Add(this.Btn103);
            this.groupBox2.Controls.Add(this.Btn102);
            this.groupBox2.Controls.Add(this.Btn101);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(463, 34);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(468, 375);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Odalar";
            // 
            // Btn109
            // 
            this.Btn109.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.Btn109.Location = new System.Drawing.Point(358, 280);
            this.Btn109.Name = "Btn109";
            this.Btn109.Size = new System.Drawing.Size(91, 66);
            this.Btn109.TabIndex = 8;
            this.Btn109.Text = "109";
            this.Btn109.UseVisualStyleBackColor = false;
            this.Btn109.Click += new System.EventHandler(this.Btn109_Click);
            // 
            // Btn108
            // 
            this.Btn108.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.Btn108.Location = new System.Drawing.Point(195, 280);
            this.Btn108.Name = "Btn108";
            this.Btn108.Size = new System.Drawing.Size(91, 66);
            this.Btn108.TabIndex = 7;
            this.Btn108.Text = "108";
            this.Btn108.UseVisualStyleBackColor = false;
            this.Btn108.Click += new System.EventHandler(this.Btn108_Click);
            // 
            // Btn107
            // 
            this.Btn107.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.Btn107.Location = new System.Drawing.Point(24, 280);
            this.Btn107.Name = "Btn107";
            this.Btn107.Size = new System.Drawing.Size(91, 66);
            this.Btn107.TabIndex = 6;
            this.Btn107.Text = "107";
            this.Btn107.UseVisualStyleBackColor = false;
            this.Btn107.Click += new System.EventHandler(this.Btn107_Click);
            // 
            // Btn106
            // 
            this.Btn106.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.Btn106.Location = new System.Drawing.Point(358, 151);
            this.Btn106.Name = "Btn106";
            this.Btn106.Size = new System.Drawing.Size(91, 66);
            this.Btn106.TabIndex = 5;
            this.Btn106.Text = "106";
            this.Btn106.UseVisualStyleBackColor = false;
            this.Btn106.Click += new System.EventHandler(this.Btn106_Click);
            // 
            // Btn105
            // 
            this.Btn105.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.Btn105.Location = new System.Drawing.Point(195, 151);
            this.Btn105.Name = "Btn105";
            this.Btn105.Size = new System.Drawing.Size(91, 66);
            this.Btn105.TabIndex = 4;
            this.Btn105.Text = "105";
            this.Btn105.UseVisualStyleBackColor = false;
            this.Btn105.Click += new System.EventHandler(this.Btn105_Click);
            // 
            // Btn104
            // 
            this.Btn104.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.Btn104.Location = new System.Drawing.Point(24, 151);
            this.Btn104.Name = "Btn104";
            this.Btn104.Size = new System.Drawing.Size(91, 66);
            this.Btn104.TabIndex = 3;
            this.Btn104.Text = "104";
            this.Btn104.UseVisualStyleBackColor = false;
            this.Btn104.Click += new System.EventHandler(this.Btn104_Click);
            // 
            // Btn103
            // 
            this.Btn103.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.Btn103.Location = new System.Drawing.Point(358, 28);
            this.Btn103.Name = "Btn103";
            this.Btn103.Size = new System.Drawing.Size(91, 66);
            this.Btn103.TabIndex = 2;
            this.Btn103.Text = "103";
            this.Btn103.UseVisualStyleBackColor = false;
            this.Btn103.Click += new System.EventHandler(this.Btn103_Click);
            // 
            // Btn102
            // 
            this.Btn102.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.Btn102.Location = new System.Drawing.Point(195, 28);
            this.Btn102.Name = "Btn102";
            this.Btn102.Size = new System.Drawing.Size(91, 66);
            this.Btn102.TabIndex = 1;
            this.Btn102.Text = "102";
            this.Btn102.UseVisualStyleBackColor = false;
            this.Btn102.Click += new System.EventHandler(this.Btn102_Click);
            // 
            // Btn101
            // 
            this.Btn101.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.Btn101.Location = new System.Drawing.Point(24, 26);
            this.Btn101.Name = "Btn101";
            this.Btn101.Size = new System.Drawing.Size(91, 66);
            this.Btn101.TabIndex = 0;
            this.Btn101.Text = "101";
            this.Btn101.UseVisualStyleBackColor = false;
            this.Btn101.Click += new System.EventHandler(this.Btn101_Click);
            // 
            // BtnDolu
            // 
            this.BtnDolu.BackColor = System.Drawing.Color.Red;
            this.BtnDolu.Location = new System.Drawing.Point(658, 433);
            this.BtnDolu.Name = "BtnDolu";
            this.BtnDolu.Size = new System.Drawing.Size(91, 66);
            this.BtnDolu.TabIndex = 2;
            this.BtnDolu.Text = "Dolu";
            this.BtnDolu.UseVisualStyleBackColor = false;
            this.BtnDolu.Click += new System.EventHandler(this.BtnDolu_Click);
            // 
            // BtnBos
            // 
            this.BtnBos.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.BtnBos.Location = new System.Drawing.Point(821, 433);
            this.BtnBos.Name = "BtnBos";
            this.BtnBos.Size = new System.Drawing.Size(91, 66);
            this.BtnBos.TabIndex = 3;
            this.BtnBos.Text = "Boş";
            this.BtnBos.UseVisualStyleBackColor = false;
            this.BtnBos.Click += new System.EventHandler(this.BtnBos_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(460, 433);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(23, 25);
            this.label11.TabIndex = 4;
            this.label11.Text = "0";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // FrmYeniMusteri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Red;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(958, 525);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.BtnBos);
            this.Controls.Add(this.BtnDolu);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmYeniMusteri";
            this.Text = "Yeni Müşteri ekle";
            this.Load += new System.EventHandler(this.FrmYeniMusteri_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker DtpCikisTarihi;
        private System.Windows.Forms.DateTimePicker DtpGirisTarihi;
        private System.Windows.Forms.MaskedTextBox MstTelefon;
        private System.Windows.Forms.TextBox TxtOdaNumarasi;
        private System.Windows.Forms.TextBox TxtKimlikNo;
        private System.Windows.Forms.TextBox TxtMail;
        private System.Windows.Forms.TextBox TxtUcret;
        private System.Windows.Forms.TextBox TxtSoyadi;
        private System.Windows.Forms.TextBox TxtAdi;
        private System.Windows.Forms.Button BtnKaydet;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Btn109;
        private System.Windows.Forms.Button Btn108;
        private System.Windows.Forms.Button Btn107;
        private System.Windows.Forms.Button Btn106;
        private System.Windows.Forms.Button Btn105;
        private System.Windows.Forms.Button Btn104;
        private System.Windows.Forms.Button Btn103;
        private System.Windows.Forms.Button Btn102;
        private System.Windows.Forms.Button Btn101;
        private System.Windows.Forms.Button BtnDolu;
        private System.Windows.Forms.Button BtnBos;
        private System.Windows.Forms.ComboBox CmbCinsiyet;
        private System.Windows.Forms.Label label11;
    }
}