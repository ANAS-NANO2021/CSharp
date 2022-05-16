
namespace HastaneOtomasyonu.ViewLayer
{
    partial class PersonelEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PersonelEkle));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.exitButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.ad = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.soyad = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.tc = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.tel = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.eposta = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.kullaniciadi = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.sifre = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.dtarihi = new Bunifu.Framework.UI.BunifuDatepicker();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.doctorradio = new XanderUI.XUIRadio();
            this.label1 = new System.Windows.Forms.Label();
            this.sekreterradio = new XanderUI.XUIRadio();
            this.yoneticiradio = new XanderUI.XUIRadio();
            this.branslardgv = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.arabox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            ((System.ComponentModel.ISupportInitialize)(this.exitButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.branslardgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(-1, 41);
            this.bunifuSeparator1.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(952, 10);
            this.bunifuSeparator1.TabIndex = 29;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // exitButton
            // 
            this.exitButton.Image = ((System.Drawing.Image)(resources.GetObject("exitButton.Image")));
            this.exitButton.ImageActive = null;
            this.exitButton.Location = new System.Drawing.Point(761, 4);
            this.exitButton.Margin = new System.Windows.Forms.Padding(2);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(39, 41);
            this.exitButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.exitButton.TabIndex = 28;
            this.exitButton.TabStop = false;
            this.exitButton.Zoom = 10;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // ad
            // 
            this.ad.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.ad.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.ad.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.ad.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ad.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.ad.ForeColor = System.Drawing.Color.White;
            this.ad.HintForeColor = System.Drawing.Color.White;
            this.ad.HintText = "Personel Adı";
            this.ad.isPassword = false;
            this.ad.LineFocusedColor = System.Drawing.Color.Crimson;
            this.ad.LineIdleColor = System.Drawing.Color.RosyBrown;
            this.ad.LineMouseHoverColor = System.Drawing.Color.Coral;
            this.ad.LineThickness = 3;
            this.ad.Location = new System.Drawing.Point(13, 59);
            this.ad.Margin = new System.Windows.Forms.Padding(4);
            this.ad.MaxLength = 50;
            this.ad.Name = "ad";
            this.ad.Size = new System.Drawing.Size(379, 33);
            this.ad.TabIndex = 30;
            this.ad.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // soyad
            // 
            this.soyad.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.soyad.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.soyad.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.soyad.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.soyad.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.soyad.ForeColor = System.Drawing.Color.White;
            this.soyad.HintForeColor = System.Drawing.Color.White;
            this.soyad.HintText = "Personel Soyadı";
            this.soyad.isPassword = false;
            this.soyad.LineFocusedColor = System.Drawing.Color.Crimson;
            this.soyad.LineIdleColor = System.Drawing.Color.RosyBrown;
            this.soyad.LineMouseHoverColor = System.Drawing.Color.Coral;
            this.soyad.LineThickness = 3;
            this.soyad.Location = new System.Drawing.Point(408, 59);
            this.soyad.Margin = new System.Windows.Forms.Padding(4);
            this.soyad.MaxLength = 50;
            this.soyad.Name = "soyad";
            this.soyad.Size = new System.Drawing.Size(379, 33);
            this.soyad.TabIndex = 31;
            this.soyad.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // tc
            // 
            this.tc.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.tc.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.tc.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tc.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tc.ForeColor = System.Drawing.Color.White;
            this.tc.HintForeColor = System.Drawing.Color.White;
            this.tc.HintText = "Personel Tc";
            this.tc.isPassword = false;
            this.tc.LineFocusedColor = System.Drawing.Color.Crimson;
            this.tc.LineIdleColor = System.Drawing.Color.RosyBrown;
            this.tc.LineMouseHoverColor = System.Drawing.Color.Coral;
            this.tc.LineThickness = 3;
            this.tc.Location = new System.Drawing.Point(13, 115);
            this.tc.Margin = new System.Windows.Forms.Padding(4);
            this.tc.MaxLength = 11;
            this.tc.Name = "tc";
            this.tc.Size = new System.Drawing.Size(379, 33);
            this.tc.TabIndex = 32;
            this.tc.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // tel
            // 
            this.tel.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.tel.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.tel.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tel.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tel.ForeColor = System.Drawing.Color.White;
            this.tel.HintForeColor = System.Drawing.Color.White;
            this.tel.HintText = "Personel Tel";
            this.tel.isPassword = false;
            this.tel.LineFocusedColor = System.Drawing.Color.Crimson;
            this.tel.LineIdleColor = System.Drawing.Color.RosyBrown;
            this.tel.LineMouseHoverColor = System.Drawing.Color.Coral;
            this.tel.LineThickness = 3;
            this.tel.Location = new System.Drawing.Point(408, 115);
            this.tel.Margin = new System.Windows.Forms.Padding(4);
            this.tel.MaxLength = 11;
            this.tel.Name = "tel";
            this.tel.Size = new System.Drawing.Size(379, 33);
            this.tel.TabIndex = 33;
            this.tel.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // eposta
            // 
            this.eposta.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.eposta.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.eposta.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.eposta.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.eposta.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.eposta.ForeColor = System.Drawing.Color.White;
            this.eposta.HintForeColor = System.Drawing.Color.White;
            this.eposta.HintText = "Personel Eposta";
            this.eposta.isPassword = false;
            this.eposta.LineFocusedColor = System.Drawing.Color.Crimson;
            this.eposta.LineIdleColor = System.Drawing.Color.RosyBrown;
            this.eposta.LineMouseHoverColor = System.Drawing.Color.Coral;
            this.eposta.LineThickness = 3;
            this.eposta.Location = new System.Drawing.Point(408, 175);
            this.eposta.Margin = new System.Windows.Forms.Padding(4);
            this.eposta.MaxLength = 50;
            this.eposta.Name = "eposta";
            this.eposta.Size = new System.Drawing.Size(379, 33);
            this.eposta.TabIndex = 35;
            this.eposta.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // kullaniciadi
            // 
            this.kullaniciadi.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.kullaniciadi.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.kullaniciadi.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.kullaniciadi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.kullaniciadi.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.kullaniciadi.ForeColor = System.Drawing.Color.White;
            this.kullaniciadi.HintForeColor = System.Drawing.Color.White;
            this.kullaniciadi.HintText = "Kullanıcı Adı";
            this.kullaniciadi.isPassword = false;
            this.kullaniciadi.LineFocusedColor = System.Drawing.Color.Crimson;
            this.kullaniciadi.LineIdleColor = System.Drawing.Color.RosyBrown;
            this.kullaniciadi.LineMouseHoverColor = System.Drawing.Color.Coral;
            this.kullaniciadi.LineThickness = 3;
            this.kullaniciadi.Location = new System.Drawing.Point(13, 232);
            this.kullaniciadi.Margin = new System.Windows.Forms.Padding(4);
            this.kullaniciadi.MaxLength = 50;
            this.kullaniciadi.Name = "kullaniciadi";
            this.kullaniciadi.Size = new System.Drawing.Size(379, 33);
            this.kullaniciadi.TabIndex = 36;
            this.kullaniciadi.Text = "Kullanıcı Adı:";
            this.kullaniciadi.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // sifre
            // 
            this.sifre.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.sifre.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.sifre.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.sifre.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.sifre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.sifre.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.sifre.ForeColor = System.Drawing.Color.White;
            this.sifre.HintForeColor = System.Drawing.Color.White;
            this.sifre.HintText = "Şifre";
            this.sifre.isPassword = false;
            this.sifre.LineFocusedColor = System.Drawing.Color.Crimson;
            this.sifre.LineIdleColor = System.Drawing.Color.RosyBrown;
            this.sifre.LineMouseHoverColor = System.Drawing.Color.Coral;
            this.sifre.LineThickness = 3;
            this.sifre.Location = new System.Drawing.Point(408, 232);
            this.sifre.Margin = new System.Windows.Forms.Padding(4);
            this.sifre.MaxLength = 50;
            this.sifre.Name = "sifre";
            this.sifre.Size = new System.Drawing.Size(379, 33);
            this.sifre.TabIndex = 37;
            this.sifre.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // dtarihi
            // 
            this.dtarihi.BackColor = System.Drawing.Color.LightSalmon;
            this.dtarihi.BorderRadius = 0;
            this.dtarihi.ForeColor = System.Drawing.Color.White;
            this.dtarihi.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtarihi.FormatCustom = "yyyy-MM-dd";
            this.dtarihi.Location = new System.Drawing.Point(12, 175);
            this.dtarihi.Name = "dtarihi";
            this.dtarihi.Size = new System.Drawing.Size(380, 36);
            this.dtarihi.TabIndex = 38;
            this.dtarihi.Value = new System.DateTime(2021, 12, 10, 22, 47, 44, 291);
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Active = false;
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "Personeli Kaydet";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton1.Iconimage")));
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 90D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(92, 449);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(241, 48);
            this.bunifuFlatButton1.TabIndex = 39;
            this.bunifuFlatButton1.Text = "Personeli Kaydet";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // doctorradio
            // 
            this.doctorradio.Checked = true;
            this.doctorradio.ForeColor = System.Drawing.Color.White;
            this.doctorradio.Location = new System.Drawing.Point(57, 316);
            this.doctorradio.Name = "doctorradio";
            this.doctorradio.RadioColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(162)))), ((int)(((byte)(250)))));
            this.doctorradio.RadioHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(55)))), ((int)(((byte)(98)))));
            this.doctorradio.RadioStyle = XanderUI.XUIRadio.Style.Material;
            this.doctorradio.Size = new System.Drawing.Size(100, 16);
            this.doctorradio.TabIndex = 40;
            this.doctorradio.Text = "Doktor";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(140, 279);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 25);
            this.label1.TabIndex = 41;
            this.label1.Text = "Personel Tipi";
            // 
            // sekreterradio
            // 
            this.sekreterradio.Checked = false;
            this.sekreterradio.ForeColor = System.Drawing.Color.White;
            this.sekreterradio.Location = new System.Drawing.Point(163, 316);
            this.sekreterradio.Name = "sekreterradio";
            this.sekreterradio.RadioColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(162)))), ((int)(((byte)(250)))));
            this.sekreterradio.RadioHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(55)))), ((int)(((byte)(98)))));
            this.sekreterradio.RadioStyle = XanderUI.XUIRadio.Style.Material;
            this.sekreterradio.Size = new System.Drawing.Size(100, 16);
            this.sekreterradio.TabIndex = 42;
            this.sekreterradio.Text = "Sekreter";
            // 
            // yoneticiradio
            // 
            this.yoneticiradio.Checked = false;
            this.yoneticiradio.ForeColor = System.Drawing.Color.White;
            this.yoneticiradio.Location = new System.Drawing.Point(291, 316);
            this.yoneticiradio.Name = "yoneticiradio";
            this.yoneticiradio.RadioColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(162)))), ((int)(((byte)(250)))));
            this.yoneticiradio.RadioHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(55)))), ((int)(((byte)(98)))));
            this.yoneticiradio.RadioStyle = XanderUI.XUIRadio.Style.Material;
            this.yoneticiradio.Size = new System.Drawing.Size(100, 16);
            this.yoneticiradio.TabIndex = 43;
            this.yoneticiradio.Text = "Yönetici";
            // 
            // branslardgv
            // 
            this.branslardgv.AllowCustomTheming = false;
            this.branslardgv.AllowUserToAddRows = false;
            this.branslardgv.AllowUserToDeleteRows = false;
            this.branslardgv.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            this.branslardgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.branslardgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.branslardgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.branslardgv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.branslardgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.branslardgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.branslardgv.ColumnHeadersHeight = 40;
            this.branslardgv.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.branslardgv.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.branslardgv.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.White;
            this.branslardgv.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            this.branslardgv.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            this.branslardgv.CurrentTheme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.branslardgv.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.branslardgv.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.branslardgv.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.branslardgv.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.branslardgv.CurrentTheme.Name = null;
            this.branslardgv.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.branslardgv.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.branslardgv.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.branslardgv.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            this.branslardgv.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.branslardgv.DefaultCellStyle = dataGridViewCellStyle3;
            this.branslardgv.EnableHeadersVisualStyles = false;
            this.branslardgv.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.branslardgv.HeaderBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.branslardgv.HeaderBgColor = System.Drawing.Color.Empty;
            this.branslardgv.HeaderForeColor = System.Drawing.Color.White;
            this.branslardgv.Location = new System.Drawing.Point(408, 377);
            this.branslardgv.Name = "branslardgv";
            this.branslardgv.ReadOnly = true;
            this.branslardgv.RowHeadersVisible = false;
            this.branslardgv.RowTemplate.Height = 40;
            this.branslardgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.branslardgv.Size = new System.Drawing.Size(379, 173);
            this.branslardgv.TabIndex = 44;
            this.branslardgv.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Dark;
            this.branslardgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.branslardgv_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(404, 279);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(255, 25);
            this.label2.TabIndex = 45;
            this.label2.Text = "Doktorlar için brans seçin";
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(409, 336);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(37, 33);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bunifuImageButton1.TabIndex = 47;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            // 
            // arabox
            // 
            this.arabox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.arabox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.arabox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.arabox.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.arabox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.arabox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.arabox.ForeColor = System.Drawing.Color.White;
            this.arabox.HintForeColor = System.Drawing.Color.White;
            this.arabox.HintText = "Aramak İçin Brans Adı Yazın:";
            this.arabox.isPassword = false;
            this.arabox.LineFocusedColor = System.Drawing.Color.Blue;
            this.arabox.LineIdleColor = System.Drawing.Color.Gray;
            this.arabox.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.arabox.LineThickness = 3;
            this.arabox.Location = new System.Drawing.Point(453, 337);
            this.arabox.Margin = new System.Windows.Forms.Padding(4);
            this.arabox.MaxLength = 32767;
            this.arabox.Name = "arabox";
            this.arabox.Size = new System.Drawing.Size(334, 33);
            this.arabox.TabIndex = 46;
            this.arabox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.arabox.OnValueChanged += new System.EventHandler(this.arabox_OnValueChanged);
            // 
            // PersonelEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(57)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(800, 556);
            this.Controls.Add(this.bunifuImageButton1);
            this.Controls.Add(this.arabox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.branslardgv);
            this.Controls.Add(this.yoneticiradio);
            this.Controls.Add(this.sekreterradio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.doctorradio);
            this.Controls.Add(this.bunifuFlatButton1);
            this.Controls.Add(this.dtarihi);
            this.Controls.Add(this.sifre);
            this.Controls.Add(this.kullaniciadi);
            this.Controls.Add(this.eposta);
            this.Controls.Add(this.tel);
            this.Controls.Add(this.tc);
            this.Controls.Add(this.soyad);
            this.Controls.Add(this.ad);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.bunifuSeparator1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PersonelEkle";
            this.Text = "PersonelEkle";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.exitButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.branslardgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuImageButton exitButton;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox ad;
        private Bunifu.Framework.UI.BunifuMaterialTextbox soyad;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tc;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tel;
        private Bunifu.Framework.UI.BunifuMaterialTextbox eposta;
        private Bunifu.Framework.UI.BunifuMaterialTextbox kullaniciadi;
        private Bunifu.Framework.UI.BunifuMaterialTextbox sifre;
        private Bunifu.Framework.UI.BunifuDatepicker dtarihi;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private XanderUI.XUIRadio doctorradio;
        private System.Windows.Forms.Label label1;
        private XanderUI.XUIRadio sekreterradio;
        private XanderUI.XUIRadio yoneticiradio;
        private Bunifu.UI.WinForms.BunifuDataGridView branslardgv;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox arabox;
    }
}