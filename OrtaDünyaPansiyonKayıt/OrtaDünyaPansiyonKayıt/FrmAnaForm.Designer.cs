
namespace OrtaDünyaPansiyonKayıt
{
    partial class FrmAnaForm
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.BtnMusteriler = new System.Windows.Forms.Button();
            this.TxtPersonelMaas = new System.Windows.Forms.Button();
            this.BtnStok = new System.Windows.Forms.Button();
            this.BtnMesaj = new System.Windows.Forms.Button();
            this.BtnMuzik = new System.Windows.Forms.Button();
            this.BtnHakkimizda = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SlateBlue;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(77, 46);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 73);
            this.button1.TabIndex = 0;
            this.button1.Text = "Admin Giriş";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Magenta;
            this.button2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(326, 46);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(122, 73);
            this.button2.TabIndex = 1;
            this.button2.Text = "Müşteri Ekle";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.BlueViolet;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.Location = new System.Drawing.Point(583, 46);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(127, 73);
            this.button3.TabIndex = 2;
            this.button3.Text = "Odalar";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // BtnMusteriler
            // 
            this.BtnMusteriler.BackColor = System.Drawing.Color.Lime;
            this.BtnMusteriler.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnMusteriler.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnMusteriler.Location = new System.Drawing.Point(77, 210);
            this.BtnMusteriler.Name = "BtnMusteriler";
            this.BtnMusteriler.Size = new System.Drawing.Size(128, 73);
            this.BtnMusteriler.TabIndex = 3;
            this.BtnMusteriler.Text = "Müşteriler";
            this.BtnMusteriler.UseVisualStyleBackColor = false;
            this.BtnMusteriler.Click += new System.EventHandler(this.BtnMusteriler_Click);
            // 
            // TxtPersonelMaas
            // 
            this.TxtPersonelMaas.BackColor = System.Drawing.Color.LightGreen;
            this.TxtPersonelMaas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.TxtPersonelMaas.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtPersonelMaas.Location = new System.Drawing.Point(326, 210);
            this.TxtPersonelMaas.Name = "TxtPersonelMaas";
            this.TxtPersonelMaas.Size = new System.Drawing.Size(122, 73);
            this.TxtPersonelMaas.TabIndex = 4;
            this.TxtPersonelMaas.Text = "Gelir-Gider Formu";
            this.TxtPersonelMaas.UseVisualStyleBackColor = false;
            this.TxtPersonelMaas.Click += new System.EventHandler(this.TxtPersonelMaas_Click);
            // 
            // BtnStok
            // 
            this.BtnStok.BackColor = System.Drawing.Color.Yellow;
            this.BtnStok.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnStok.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnStok.Location = new System.Drawing.Point(583, 210);
            this.BtnStok.Name = "BtnStok";
            this.BtnStok.Size = new System.Drawing.Size(127, 73);
            this.BtnStok.TabIndex = 5;
            this.BtnStok.Text = "Stoklar";
            this.BtnStok.UseVisualStyleBackColor = false;
            this.BtnStok.Click += new System.EventHandler(this.BtnStok_Click);
            // 
            // BtnMesaj
            // 
            this.BtnMesaj.BackColor = System.Drawing.Color.Orange;
            this.BtnMesaj.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnMesaj.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnMesaj.Location = new System.Drawing.Point(77, 374);
            this.BtnMesaj.Name = "BtnMesaj";
            this.BtnMesaj.Size = new System.Drawing.Size(128, 73);
            this.BtnMesaj.TabIndex = 6;
            this.BtnMesaj.Text = "Müşteri Mesajları";
            this.BtnMesaj.UseVisualStyleBackColor = false;
            this.BtnMesaj.Click += new System.EventHandler(this.button4_Click);
            // 
            // BtnMuzik
            // 
            this.BtnMuzik.BackColor = System.Drawing.Color.SkyBlue;
            this.BtnMuzik.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnMuzik.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnMuzik.Location = new System.Drawing.Point(326, 374);
            this.BtnMuzik.Name = "BtnMuzik";
            this.BtnMuzik.Size = new System.Drawing.Size(122, 73);
            this.BtnMuzik.TabIndex = 7;
            this.BtnMuzik.Text = "Müzik Dinle";
            this.BtnMuzik.UseVisualStyleBackColor = false;
            this.BtnMuzik.Click += new System.EventHandler(this.BtnMuzik_Click);
            // 
            // BtnHakkimizda
            // 
            this.BtnHakkimizda.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.BtnHakkimizda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnHakkimizda.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnHakkimizda.Location = new System.Drawing.Point(583, 374);
            this.BtnHakkimizda.Name = "BtnHakkimizda";
            this.BtnHakkimizda.Size = new System.Drawing.Size(127, 73);
            this.BtnHakkimizda.TabIndex = 8;
            this.BtnHakkimizda.Text = "Hakkımızda";
            this.BtnHakkimizda.UseVisualStyleBackColor = false;
            this.BtnHakkimizda.Click += new System.EventHandler(this.BtnHakkimizda_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Orchid;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button4.Location = new System.Drawing.Point(793, 46);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(137, 73);
            this.button4.TabIndex = 9;
            this.button4.Text = "Şifre Güncelleme";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.YellowGreen;
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button5.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button5.Location = new System.Drawing.Point(800, 210);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(130, 73);
            this.button5.TabIndex = 10;
            this.button5.Text = "Gazeteler";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Red;
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button6.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button6.Location = new System.Drawing.Point(800, 374);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(130, 73);
            this.button6.TabIndex = 11;
            this.button6.Text = "Çıkış";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(973, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(1037, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 25);
            this.label2.TabIndex = 13;
            this.label2.Text = "label2";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FrmAnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.ForestGreen;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1263, 491);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.BtnHakkimizda);
            this.Controls.Add(this.BtnMuzik);
            this.Controls.Add(this.BtnMesaj);
            this.Controls.Add(this.BtnStok);
            this.Controls.Add(this.TxtPersonelMaas);
            this.Controls.Add(this.BtnMusteriler);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAnaForm";
            this.Text = "Ana Sayfa";
            this.Load += new System.EventHandler(this.FrmAnaForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button BtnMusteriler;
        private System.Windows.Forms.Button TxtPersonelMaas;
        private System.Windows.Forms.Button BtnStok;
        private System.Windows.Forms.Button BtnMesaj;
        private System.Windows.Forms.Button BtnMuzik;
        private System.Windows.Forms.Button BtnHakkimizda;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
    }
}