
namespace OrtaDünyaPansiyonKayıt
{
    partial class FrmSifreGüncelleme
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
            this.BtnGirisYap = new System.Windows.Forms.Button();
            this.TxtParola2 = new System.Windows.Forms.TextBox();
            this.TxtKullaniciAdi1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnGirisYap
            // 
            this.BtnGirisYap.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGirisYap.Location = new System.Drawing.Point(232, 188);
            this.BtnGirisYap.Name = "BtnGirisYap";
            this.BtnGirisYap.Size = new System.Drawing.Size(189, 64);
            this.BtnGirisYap.TabIndex = 10;
            this.BtnGirisYap.Text = "Güncelle";
            this.BtnGirisYap.UseCompatibleTextRendering = true;
            this.BtnGirisYap.UseVisualStyleBackColor = true;
            this.BtnGirisYap.Click += new System.EventHandler(this.BtnGirisYap_Click);
            // 
            // TxtParola2
            // 
            this.TxtParola2.BackColor = System.Drawing.Color.NavajoWhite;
            this.TxtParola2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtParola2.Location = new System.Drawing.Point(250, 123);
            this.TxtParola2.Name = "TxtParola2";
            this.TxtParola2.Size = new System.Drawing.Size(150, 30);
            this.TxtParola2.TabIndex = 9;
            // 
            // TxtKullaniciAdi1
            // 
            this.TxtKullaniciAdi1.BackColor = System.Drawing.Color.NavajoWhite;
            this.TxtKullaniciAdi1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtKullaniciAdi1.Location = new System.Drawing.Point(250, 75);
            this.TxtKullaniciAdi1.Name = "TxtKullaniciAdi1";
            this.TxtKullaniciAdi1.Size = new System.Drawing.Size(150, 30);
            this.TxtKullaniciAdi1.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(161, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 23);
            this.label2.TabIndex = 7;
            this.label2.Text = "Parola";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(110, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "Kullanıcı Adı";
            // 
            // FrmSifreGüncelleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(583, 363);
            this.Controls.Add(this.BtnGirisYap);
            this.Controls.Add(this.TxtParola2);
            this.Controls.Add(this.TxtKullaniciAdi1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmSifreGüncelleme";
            this.Text = "FrmSifreGüncelleme";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnGirisYap;
        private System.Windows.Forms.TextBox TxtParola2;
        private System.Windows.Forms.TextBox TxtKullaniciAdi1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}