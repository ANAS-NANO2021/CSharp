
namespace HastaneOtomasyonu
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.exitButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.usernameTxtbx = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.PwTxtbx = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.loginButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pwResButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            ((System.ComponentModel.ISupportInitialize)(this.exitButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.Image = ((System.Drawing.Image)(resources.GetObject("exitButton.Image")));
            this.exitButton.ImageActive = null;
            this.exitButton.Location = new System.Drawing.Point(736, 12);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(52, 50);
            this.exitButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.exitButton.TabIndex = 0;
            this.exitButton.TabStop = false;
            this.exitButton.Zoom = 10;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // usernameTxtbx
            // 
            this.usernameTxtbx.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.usernameTxtbx.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.usernameTxtbx.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.usernameTxtbx.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.usernameTxtbx.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.usernameTxtbx.ForeColor = System.Drawing.Color.White;
            this.usernameTxtbx.HintForeColor = System.Drawing.Color.White;
            this.usernameTxtbx.HintText = "Personel Kullanici Adi";
            this.usernameTxtbx.isPassword = false;
            this.usernameTxtbx.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(230)))), ((int)(((byte)(118)))));
            this.usernameTxtbx.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(246)))), ((int)(((byte)(202)))));
            this.usernameTxtbx.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(240)))), ((int)(((byte)(174)))));
            this.usernameTxtbx.LineThickness = 3;
            this.usernameTxtbx.Location = new System.Drawing.Point(31, 182);
            this.usernameTxtbx.Margin = new System.Windows.Forms.Padding(4);
            this.usernameTxtbx.MaxLength = 32767;
            this.usernameTxtbx.Name = "usernameTxtbx";
            this.usernameTxtbx.Size = new System.Drawing.Size(396, 62);
            this.usernameTxtbx.TabIndex = 1;
            this.usernameTxtbx.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // PwTxtbx
            // 
            this.PwTxtbx.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.PwTxtbx.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.PwTxtbx.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.PwTxtbx.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PwTxtbx.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.PwTxtbx.ForeColor = System.Drawing.Color.White;
            this.PwTxtbx.HintForeColor = System.Drawing.Color.White;
            this.PwTxtbx.HintText = "Personel Şifre";
            this.PwTxtbx.isPassword = true;
            this.PwTxtbx.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(230)))), ((int)(((byte)(118)))));
            this.PwTxtbx.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(246)))), ((int)(((byte)(202)))));
            this.PwTxtbx.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(240)))), ((int)(((byte)(174)))));
            this.PwTxtbx.LineThickness = 3;
            this.PwTxtbx.Location = new System.Drawing.Point(31, 294);
            this.PwTxtbx.Margin = new System.Windows.Forms.Padding(4);
            this.PwTxtbx.MaxLength = 32767;
            this.PwTxtbx.Name = "PwTxtbx";
            this.PwTxtbx.Size = new System.Drawing.Size(396, 62);
            this.PwTxtbx.TabIndex = 2;
            this.PwTxtbx.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // loginButton
            // 
            this.loginButton.Active = false;
            this.loginButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.loginButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.loginButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.loginButton.BorderRadius = 0;
            this.loginButton.ButtonText = "Giriş Yap";
            this.loginButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginButton.DisabledColor = System.Drawing.Color.Gray;
            this.loginButton.Iconcolor = System.Drawing.Color.Transparent;
            this.loginButton.Iconimage = ((System.Drawing.Image)(resources.GetObject("loginButton.Iconimage")));
            this.loginButton.Iconimage_right = null;
            this.loginButton.Iconimage_right_Selected = null;
            this.loginButton.Iconimage_Selected = null;
            this.loginButton.IconMarginLeft = 0;
            this.loginButton.IconMarginRight = 0;
            this.loginButton.IconRightVisible = true;
            this.loginButton.IconRightZoom = 0D;
            this.loginButton.IconVisible = true;
            this.loginButton.IconZoom = 90D;
            this.loginButton.IsTab = false;
            this.loginButton.Location = new System.Drawing.Point(466, 182);
            this.loginButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.loginButton.Name = "loginButton";
            this.loginButton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.loginButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.loginButton.OnHoverTextColor = System.Drawing.Color.White;
            this.loginButton.selected = false;
            this.loginButton.Size = new System.Drawing.Size(321, 75);
            this.loginButton.TabIndex = 3;
            this.loginButton.Text = "Giriş Yap";
            this.loginButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.loginButton.Textcolor = System.Drawing.Color.White;
            this.loginButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // pwResButton
            // 
            this.pwResButton.Active = false;
            this.pwResButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(35)))), ((int)(((byte)(126)))));
            this.pwResButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(53)))), ((int)(((byte)(147)))));
            this.pwResButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pwResButton.BorderRadius = 0;
            this.pwResButton.ButtonText = "Şifremi Unuttum";
            this.pwResButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pwResButton.DisabledColor = System.Drawing.Color.Gray;
            this.pwResButton.Iconcolor = System.Drawing.Color.Transparent;
            this.pwResButton.Iconimage = ((System.Drawing.Image)(resources.GetObject("pwResButton.Iconimage")));
            this.pwResButton.Iconimage_right = null;
            this.pwResButton.Iconimage_right_Selected = null;
            this.pwResButton.Iconimage_Selected = null;
            this.pwResButton.IconMarginLeft = 0;
            this.pwResButton.IconMarginRight = 0;
            this.pwResButton.IconRightVisible = true;
            this.pwResButton.IconRightZoom = 0D;
            this.pwResButton.IconVisible = true;
            this.pwResButton.IconZoom = 90D;
            this.pwResButton.IsTab = false;
            this.pwResButton.Location = new System.Drawing.Point(467, 285);
            this.pwResButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pwResButton.Name = "pwResButton";
            this.pwResButton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(53)))), ((int)(((byte)(147)))));
            this.pwResButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(35)))), ((int)(((byte)(126)))));
            this.pwResButton.OnHoverTextColor = System.Drawing.Color.White;
            this.pwResButton.selected = false;
            this.pwResButton.Size = new System.Drawing.Size(321, 75);
            this.pwResButton.TabIndex = 4;
            this.pwResButton.Text = "Şifremi Unuttum";
            this.pwResButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pwResButton.Textcolor = System.Drawing.Color.White;
            this.pwResButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pwResButton.Click += new System.EventHandler(this.pwResButton_Click);
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(12, 12);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(98, 82);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 5;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(-45, 90);
            this.bunifuSeparator1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(922, 14);
            this.bunifuSeparator1.TabIndex = 23;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(57)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.bunifuImageButton1);
            this.Controls.Add(this.pwResButton);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.PwTxtbx);
            this.Controls.Add(this.usernameTxtbx);
            this.Controls.Add(this.exitButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giriş";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.exitButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuImageButton exitButton;
        private Bunifu.Framework.UI.BunifuMaterialTextbox usernameTxtbx;
        private Bunifu.Framework.UI.BunifuMaterialTextbox PwTxtbx;
        private Bunifu.Framework.UI.BunifuFlatButton loginButton;
        private Bunifu.Framework.UI.BunifuFlatButton pwResButton;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
    }
}

