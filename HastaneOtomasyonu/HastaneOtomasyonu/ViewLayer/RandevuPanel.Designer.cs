
namespace HastaneOtomasyonu.ViewLayer
{
    partial class RandevuPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RandevuPanel));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.randevukaydet = new Bunifu.Framework.UI.BunifuFlatButton();
            this.ilcedropdown = new Bunifu.Framework.UI.BunifuDropdown();
            this.ildropdown = new Bunifu.Framework.UI.BunifuDropdown();
            this.doktordgv = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.randevutarih = new Bunifu.Framework.UI.BunifuDatepicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuSeparator2 = new Bunifu.Framework.UI.BunifuSeparator();
            this.hastakaydet = new Bunifu.Framework.UI.BunifuFlatButton();
            this.dogumtarihibox = new Bunifu.Framework.UI.BunifuDatepicker();
            this.dogumyeribox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.nobox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.soyadbox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.adbox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.tcbox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.kayıtsorgula = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.exitButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.cinsiyetbox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.poliklinikler = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.polikliniktxtbox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.doktortxtbox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.doktordgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.poliklinikler)).BeginInit();
            this.SuspendLayout();
            // 
            // randevukaydet
            // 
            this.randevukaydet.Active = false;
            this.randevukaydet.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.randevukaydet.BackColor = System.Drawing.Color.Tomato;
            this.randevukaydet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.randevukaydet.BorderRadius = 0;
            this.randevukaydet.ButtonText = "Randevu Kaydet";
            this.randevukaydet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.randevukaydet.DisabledColor = System.Drawing.Color.Gray;
            this.randevukaydet.Enabled = false;
            this.randevukaydet.Iconcolor = System.Drawing.Color.Transparent;
            this.randevukaydet.Iconimage = ((System.Drawing.Image)(resources.GetObject("randevukaydet.Iconimage")));
            this.randevukaydet.Iconimage_right = null;
            this.randevukaydet.Iconimage_right_Selected = null;
            this.randevukaydet.Iconimage_Selected = null;
            this.randevukaydet.IconMarginLeft = 0;
            this.randevukaydet.IconMarginRight = 0;
            this.randevukaydet.IconRightVisible = true;
            this.randevukaydet.IconRightZoom = 0D;
            this.randevukaydet.IconVisible = true;
            this.randevukaydet.IconZoom = 90D;
            this.randevukaydet.IsTab = false;
            this.randevukaydet.Location = new System.Drawing.Point(635, 418);
            this.randevukaydet.Name = "randevukaydet";
            this.randevukaydet.Normalcolor = System.Drawing.Color.Tomato;
            this.randevukaydet.OnHovercolor = System.Drawing.Color.Tomato;
            this.randevukaydet.OnHoverTextColor = System.Drawing.Color.White;
            this.randevukaydet.selected = false;
            this.randevukaydet.Size = new System.Drawing.Size(203, 34);
            this.randevukaydet.TabIndex = 72;
            this.randevukaydet.Text = "Randevu Kaydet";
            this.randevukaydet.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.randevukaydet.Textcolor = System.Drawing.Color.White;
            this.randevukaydet.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.randevukaydet.Click += new System.EventHandler(this.randevukaydet_Click);
            // 
            // ilcedropdown
            // 
            this.ilcedropdown.BackColor = System.Drawing.Color.Transparent;
            this.ilcedropdown.BorderRadius = 3;
            this.ilcedropdown.DisabledColor = System.Drawing.Color.Gray;
            this.ilcedropdown.ForeColor = System.Drawing.Color.White;
            this.ilcedropdown.items = new string[] {
        "İlçe Seçiniz"};
            this.ilcedropdown.Location = new System.Drawing.Point(239, 293);
            this.ilcedropdown.Name = "ilcedropdown";
            this.ilcedropdown.NomalColor = System.Drawing.Color.SteelBlue;
            this.ilcedropdown.onHoverColor = System.Drawing.Color.SteelBlue;
            this.ilcedropdown.selectedIndex = 0;
            this.ilcedropdown.Size = new System.Drawing.Size(203, 35);
            this.ilcedropdown.TabIndex = 71;
            // 
            // ildropdown
            // 
            this.ildropdown.BackColor = System.Drawing.Color.Transparent;
            this.ildropdown.BorderRadius = 3;
            this.ildropdown.DisabledColor = System.Drawing.Color.Gray;
            this.ildropdown.ForeColor = System.Drawing.Color.White;
            this.ildropdown.items = new string[] {
        "İl Seçiniz"};
            this.ildropdown.Location = new System.Drawing.Point(13, 293);
            this.ildropdown.Name = "ildropdown";
            this.ildropdown.NomalColor = System.Drawing.Color.SteelBlue;
            this.ildropdown.onHoverColor = System.Drawing.Color.SteelBlue;
            this.ildropdown.selectedIndex = 0;
            this.ildropdown.Size = new System.Drawing.Size(203, 35);
            this.ildropdown.TabIndex = 70;
            // 
            // doktordgv
            // 
            this.doktordgv.AllowCustomTheming = false;
            this.doktordgv.AllowUserToAddRows = false;
            this.doktordgv.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.doktordgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.doktordgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.doktordgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.doktordgv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.doktordgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.doktordgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.doktordgv.ColumnHeadersHeight = 40;
            this.doktordgv.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.doktordgv.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.doktordgv.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.doktordgv.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.doktordgv.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.doktordgv.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.doktordgv.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.doktordgv.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.doktordgv.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.doktordgv.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.doktordgv.CurrentTheme.Name = null;
            this.doktordgv.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.doktordgv.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.doktordgv.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.doktordgv.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.doktordgv.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.doktordgv.DefaultCellStyle = dataGridViewCellStyle3;
            this.doktordgv.Enabled = false;
            this.doktordgv.EnableHeadersVisualStyles = false;
            this.doktordgv.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.doktordgv.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.doktordgv.HeaderBgColor = System.Drawing.Color.Empty;
            this.doktordgv.HeaderForeColor = System.Drawing.Color.White;
            this.doktordgv.Location = new System.Drawing.Point(739, 150);
            this.doktordgv.Name = "doktordgv";
            this.doktordgv.ReadOnly = true;
            this.doktordgv.RowHeadersVisible = false;
            this.doktordgv.RowTemplate.Height = 40;
            this.doktordgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.doktordgv.Size = new System.Drawing.Size(257, 221);
            this.doktordgv.TabIndex = 68;
            this.doktordgv.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            this.doktordgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.doktordgv_CellClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(734, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 25);
            this.label5.TabIndex = 67;
            this.label5.Text = "Doktor Seçimi";
            // 
            // randevutarih
            // 
            this.randevutarih.BackColor = System.Drawing.Color.SeaGreen;
            this.randevutarih.BorderRadius = 0;
            this.randevutarih.Enabled = false;
            this.randevutarih.ForeColor = System.Drawing.Color.White;
            this.randevutarih.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.randevutarih.FormatCustom = "yyyy-dd-MM";
            this.randevutarih.Location = new System.Drawing.Point(611, 69);
            this.randevutarih.Name = "randevutarih";
            this.randevutarih.Size = new System.Drawing.Size(206, 36);
            this.randevutarih.TabIndex = 66;
            this.randevutarih.Value = new System.DateTime(2021, 11, 22, 21, 19, 21, 476);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(462, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 25);
            this.label2.TabIndex = 64;
            this.label2.Text = "Randevu Bilgileri";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(7, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 25);
            this.label1.TabIndex = 63;
            this.label1.Text = "Hasta Bilgileri";
            // 
            // bunifuSeparator2
            // 
            this.bunifuSeparator2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator2.LineThickness = 1;
            this.bunifuSeparator2.Location = new System.Drawing.Point(448, 59);
            this.bunifuSeparator2.Name = "bunifuSeparator2";
            this.bunifuSeparator2.Size = new System.Drawing.Size(10, 352);
            this.bunifuSeparator2.TabIndex = 62;
            this.bunifuSeparator2.Transparency = 255;
            this.bunifuSeparator2.Vertical = true;
            // 
            // hastakaydet
            // 
            this.hastakaydet.Active = false;
            this.hastakaydet.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.hastakaydet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.hastakaydet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.hastakaydet.BorderRadius = 0;
            this.hastakaydet.ButtonText = "Hasta Kayıt";
            this.hastakaydet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hastakaydet.DisabledColor = System.Drawing.Color.Gray;
            this.hastakaydet.Enabled = false;
            this.hastakaydet.Iconcolor = System.Drawing.Color.Transparent;
            this.hastakaydet.Iconimage = ((System.Drawing.Image)(resources.GetObject("hastakaydet.Iconimage")));
            this.hastakaydet.Iconimage_right = null;
            this.hastakaydet.Iconimage_right_Selected = null;
            this.hastakaydet.Iconimage_Selected = null;
            this.hastakaydet.IconMarginLeft = 0;
            this.hastakaydet.IconMarginRight = 0;
            this.hastakaydet.IconRightVisible = true;
            this.hastakaydet.IconRightZoom = 0D;
            this.hastakaydet.IconVisible = true;
            this.hastakaydet.IconZoom = 90D;
            this.hastakaydet.IsTab = false;
            this.hastakaydet.Location = new System.Drawing.Point(126, 368);
            this.hastakaydet.Name = "hastakaydet";
            this.hastakaydet.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.hastakaydet.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.hastakaydet.OnHoverTextColor = System.Drawing.Color.White;
            this.hastakaydet.selected = false;
            this.hastakaydet.Size = new System.Drawing.Size(199, 43);
            this.hastakaydet.TabIndex = 61;
            this.hastakaydet.Text = "Hasta Kayıt";
            this.hastakaydet.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.hastakaydet.Textcolor = System.Drawing.Color.White;
            this.hastakaydet.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hastakaydet.Click += new System.EventHandler(this.hastakaydet_Click);
            // 
            // dogumtarihibox
            // 
            this.dogumtarihibox.BackColor = System.Drawing.Color.SteelBlue;
            this.dogumtarihibox.BorderRadius = 0;
            this.dogumtarihibox.ForeColor = System.Drawing.Color.White;
            this.dogumtarihibox.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dogumtarihibox.FormatCustom = "yyyy-dd-MM";
            this.dogumtarihibox.Location = new System.Drawing.Point(239, 233);
            this.dogumtarihibox.Name = "dogumtarihibox";
            this.dogumtarihibox.Size = new System.Drawing.Size(204, 36);
            this.dogumtarihibox.TabIndex = 60;
            this.dogumtarihibox.Value = new System.DateTime(2021, 11, 22, 0, 0, 0, 0);
            // 
            // dogumyeribox
            // 
            this.dogumyeribox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.dogumyeribox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.dogumyeribox.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.dogumyeribox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.dogumyeribox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.dogumyeribox.ForeColor = System.Drawing.Color.White;
            this.dogumyeribox.HintForeColor = System.Drawing.Color.White;
            this.dogumyeribox.HintText = "Hasta Doğum Yeri";
            this.dogumyeribox.isPassword = false;
            this.dogumyeribox.LineFocusedColor = System.Drawing.Color.SeaGreen;
            this.dogumyeribox.LineIdleColor = System.Drawing.Color.Gray;
            this.dogumyeribox.LineMouseHoverColor = System.Drawing.Color.SpringGreen;
            this.dogumyeribox.LineThickness = 3;
            this.dogumyeribox.Location = new System.Drawing.Point(239, 181);
            this.dogumyeribox.Margin = new System.Windows.Forms.Padding(4);
            this.dogumyeribox.MaxLength = 32767;
            this.dogumyeribox.Name = "dogumyeribox";
            this.dogumyeribox.Size = new System.Drawing.Size(203, 33);
            this.dogumyeribox.TabIndex = 59;
            this.dogumyeribox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // nobox
            // 
            this.nobox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.nobox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.nobox.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.nobox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nobox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.nobox.ForeColor = System.Drawing.Color.White;
            this.nobox.HintForeColor = System.Drawing.Color.White;
            this.nobox.HintText = "Hasta İletişim No";
            this.nobox.isPassword = false;
            this.nobox.LineFocusedColor = System.Drawing.Color.SeaGreen;
            this.nobox.LineIdleColor = System.Drawing.Color.Gray;
            this.nobox.LineMouseHoverColor = System.Drawing.Color.SpringGreen;
            this.nobox.LineThickness = 3;
            this.nobox.Location = new System.Drawing.Point(13, 181);
            this.nobox.Margin = new System.Windows.Forms.Padding(4);
            this.nobox.MaxLength = 32767;
            this.nobox.Name = "nobox";
            this.nobox.Size = new System.Drawing.Size(203, 33);
            this.nobox.TabIndex = 58;
            this.nobox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // soyadbox
            // 
            this.soyadbox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.soyadbox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.soyadbox.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.soyadbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.soyadbox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.soyadbox.ForeColor = System.Drawing.Color.White;
            this.soyadbox.HintForeColor = System.Drawing.Color.White;
            this.soyadbox.HintText = "Hasta Soyadı";
            this.soyadbox.isPassword = false;
            this.soyadbox.LineFocusedColor = System.Drawing.Color.SeaGreen;
            this.soyadbox.LineIdleColor = System.Drawing.Color.Gray;
            this.soyadbox.LineMouseHoverColor = System.Drawing.Color.SpringGreen;
            this.soyadbox.LineThickness = 3;
            this.soyadbox.Location = new System.Drawing.Point(239, 122);
            this.soyadbox.Margin = new System.Windows.Forms.Padding(4);
            this.soyadbox.MaxLength = 32767;
            this.soyadbox.Name = "soyadbox";
            this.soyadbox.Size = new System.Drawing.Size(203, 33);
            this.soyadbox.TabIndex = 57;
            this.soyadbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // adbox
            // 
            this.adbox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.adbox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.adbox.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.adbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.adbox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.adbox.ForeColor = System.Drawing.Color.White;
            this.adbox.HintForeColor = System.Drawing.Color.White;
            this.adbox.HintText = "Hasta Adı";
            this.adbox.isPassword = false;
            this.adbox.LineFocusedColor = System.Drawing.Color.SeaGreen;
            this.adbox.LineIdleColor = System.Drawing.Color.Gray;
            this.adbox.LineMouseHoverColor = System.Drawing.Color.SpringGreen;
            this.adbox.LineThickness = 3;
            this.adbox.Location = new System.Drawing.Point(13, 122);
            this.adbox.Margin = new System.Windows.Forms.Padding(4);
            this.adbox.MaxLength = 32767;
            this.adbox.Name = "adbox";
            this.adbox.Size = new System.Drawing.Size(203, 33);
            this.adbox.TabIndex = 56;
            this.adbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // tcbox
            // 
            this.tcbox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.tcbox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.tcbox.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tcbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tcbox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tcbox.ForeColor = System.Drawing.Color.White;
            this.tcbox.HintForeColor = System.Drawing.Color.White;
            this.tcbox.HintText = "Hasta Tc Kimlik No Giriniz";
            this.tcbox.isPassword = false;
            this.tcbox.LineFocusedColor = System.Drawing.Color.SeaGreen;
            this.tcbox.LineIdleColor = System.Drawing.Color.Gray;
            this.tcbox.LineMouseHoverColor = System.Drawing.Color.SpringGreen;
            this.tcbox.LineThickness = 3;
            this.tcbox.Location = new System.Drawing.Point(12, 69);
            this.tcbox.Margin = new System.Windows.Forms.Padding(4);
            this.tcbox.MaxLength = 32767;
            this.tcbox.Name = "tcbox";
            this.tcbox.Size = new System.Drawing.Size(203, 33);
            this.tcbox.TabIndex = 55;
            this.tcbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // kayıtsorgula
            // 
            this.kayıtsorgula.Active = false;
            this.kayıtsorgula.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.kayıtsorgula.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.kayıtsorgula.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.kayıtsorgula.BorderRadius = 0;
            this.kayıtsorgula.ButtonText = "Hasta Kaydı Sorgula";
            this.kayıtsorgula.Cursor = System.Windows.Forms.Cursors.Hand;
            this.kayıtsorgula.DisabledColor = System.Drawing.Color.Gray;
            this.kayıtsorgula.Iconcolor = System.Drawing.Color.Transparent;
            this.kayıtsorgula.Iconimage = ((System.Drawing.Image)(resources.GetObject("kayıtsorgula.Iconimage")));
            this.kayıtsorgula.Iconimage_right = null;
            this.kayıtsorgula.Iconimage_right_Selected = null;
            this.kayıtsorgula.Iconimage_Selected = null;
            this.kayıtsorgula.IconMarginLeft = 0;
            this.kayıtsorgula.IconMarginRight = 0;
            this.kayıtsorgula.IconRightVisible = true;
            this.kayıtsorgula.IconRightZoom = 0D;
            this.kayıtsorgula.IconVisible = true;
            this.kayıtsorgula.IconZoom = 90D;
            this.kayıtsorgula.IsTab = false;
            this.kayıtsorgula.Location = new System.Drawing.Point(238, 68);
            this.kayıtsorgula.Name = "kayıtsorgula";
            this.kayıtsorgula.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.kayıtsorgula.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.kayıtsorgula.OnHoverTextColor = System.Drawing.Color.White;
            this.kayıtsorgula.selected = false;
            this.kayıtsorgula.Size = new System.Drawing.Size(203, 34);
            this.kayıtsorgula.TabIndex = 54;
            this.kayıtsorgula.Text = "Hasta Kaydı Sorgula";
            this.kayıtsorgula.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.kayıtsorgula.Textcolor = System.Drawing.Color.White;
            this.kayıtsorgula.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kayıtsorgula.Click += new System.EventHandler(this.kayıtsorgula_Click);
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(-120, 52);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(1127, 10);
            this.bunifuSeparator1.TabIndex = 53;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // exitButton
            // 
            this.exitButton.Image = ((System.Drawing.Image)(resources.GetObject("exitButton.Image")));
            this.exitButton.ImageActive = null;
            this.exitButton.Location = new System.Drawing.Point(957, 6);
            this.exitButton.Margin = new System.Windows.Forms.Padding(2);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(39, 41);
            this.exitButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.exitButton.TabIndex = 52;
            this.exitButton.TabStop = false;
            this.exitButton.Zoom = 10;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // cinsiyetbox
            // 
            this.cinsiyetbox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.cinsiyetbox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.cinsiyetbox.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cinsiyetbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.cinsiyetbox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.cinsiyetbox.ForeColor = System.Drawing.Color.White;
            this.cinsiyetbox.HintForeColor = System.Drawing.Color.White;
            this.cinsiyetbox.HintText = "Cinsiyet";
            this.cinsiyetbox.isPassword = false;
            this.cinsiyetbox.LineFocusedColor = System.Drawing.Color.SeaGreen;
            this.cinsiyetbox.LineIdleColor = System.Drawing.Color.Gray;
            this.cinsiyetbox.LineMouseHoverColor = System.Drawing.Color.SpringGreen;
            this.cinsiyetbox.LineThickness = 3;
            this.cinsiyetbox.Location = new System.Drawing.Point(13, 236);
            this.cinsiyetbox.Margin = new System.Windows.Forms.Padding(4);
            this.cinsiyetbox.MaxLength = 32767;
            this.cinsiyetbox.Name = "cinsiyetbox";
            this.cinsiyetbox.Size = new System.Drawing.Size(203, 33);
            this.cinsiyetbox.TabIndex = 73;
            this.cinsiyetbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(464, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 25);
            this.label3.TabIndex = 74;
            this.label3.Text = "Tarih Seçin";
            // 
            // poliklinikler
            // 
            this.poliklinikler.AllowCustomTheming = false;
            this.poliklinikler.AllowUserToAddRows = false;
            this.poliklinikler.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            this.poliklinikler.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.poliklinikler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.poliklinikler.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.poliklinikler.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.poliklinikler.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.poliklinikler.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.poliklinikler.ColumnHeadersHeight = 40;
            this.poliklinikler.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.poliklinikler.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.poliklinikler.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.White;
            this.poliklinikler.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            this.poliklinikler.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            this.poliklinikler.CurrentTheme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.poliklinikler.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.poliklinikler.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.poliklinikler.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.poliklinikler.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.poliklinikler.CurrentTheme.Name = null;
            this.poliklinikler.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.poliklinikler.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.poliklinikler.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.poliklinikler.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            this.poliklinikler.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.poliklinikler.DefaultCellStyle = dataGridViewCellStyle6;
            this.poliklinikler.Enabled = false;
            this.poliklinikler.EnableHeadersVisualStyles = false;
            this.poliklinikler.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.poliklinikler.HeaderBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.poliklinikler.HeaderBgColor = System.Drawing.Color.Empty;
            this.poliklinikler.HeaderForeColor = System.Drawing.Color.White;
            this.poliklinikler.Location = new System.Drawing.Point(469, 150);
            this.poliklinikler.Name = "poliklinikler";
            this.poliklinikler.ReadOnly = true;
            this.poliklinikler.RowHeadersVisible = false;
            this.poliklinikler.RowTemplate.Height = 40;
            this.poliklinikler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.poliklinikler.Size = new System.Drawing.Size(257, 221);
            this.poliklinikler.TabIndex = 76;
            this.poliklinikler.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Dark;
            this.poliklinikler.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.poliklinikler_CellClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(464, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(173, 25);
            this.label4.TabIndex = 75;
            this.label4.Text = "Poliklinik Seçiniz";
            // 
            // polikliniktxtbox
            // 
            this.polikliniktxtbox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.polikliniktxtbox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.polikliniktxtbox.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.polikliniktxtbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.polikliniktxtbox.Enabled = false;
            this.polikliniktxtbox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.polikliniktxtbox.ForeColor = System.Drawing.Color.White;
            this.polikliniktxtbox.HintForeColor = System.Drawing.Color.White;
            this.polikliniktxtbox.HintText = "Poliklinik Seçin";
            this.polikliniktxtbox.isPassword = false;
            this.polikliniktxtbox.LineFocusedColor = System.Drawing.Color.SeaGreen;
            this.polikliniktxtbox.LineIdleColor = System.Drawing.Color.Gray;
            this.polikliniktxtbox.LineMouseHoverColor = System.Drawing.Color.SpringGreen;
            this.polikliniktxtbox.LineThickness = 3;
            this.polikliniktxtbox.Location = new System.Drawing.Point(469, 378);
            this.polikliniktxtbox.Margin = new System.Windows.Forms.Padding(4);
            this.polikliniktxtbox.MaxLength = 32767;
            this.polikliniktxtbox.Name = "polikliniktxtbox";
            this.polikliniktxtbox.Size = new System.Drawing.Size(203, 33);
            this.polikliniktxtbox.TabIndex = 77;
            this.polikliniktxtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // doktortxtbox
            // 
            this.doktortxtbox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.doktortxtbox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.doktortxtbox.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.doktortxtbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.doktortxtbox.Enabled = false;
            this.doktortxtbox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.doktortxtbox.ForeColor = System.Drawing.Color.White;
            this.doktortxtbox.HintForeColor = System.Drawing.Color.White;
            this.doktortxtbox.HintText = "Doktor Seçin";
            this.doktortxtbox.isPassword = false;
            this.doktortxtbox.LineFocusedColor = System.Drawing.Color.SeaGreen;
            this.doktortxtbox.LineIdleColor = System.Drawing.Color.Gray;
            this.doktortxtbox.LineMouseHoverColor = System.Drawing.Color.SpringGreen;
            this.doktortxtbox.LineThickness = 3;
            this.doktortxtbox.Location = new System.Drawing.Point(759, 378);
            this.doktortxtbox.Margin = new System.Windows.Forms.Padding(4);
            this.doktortxtbox.MaxLength = 32767;
            this.doktortxtbox.Name = "doktortxtbox";
            this.doktortxtbox.Size = new System.Drawing.Size(203, 33);
            this.doktortxtbox.TabIndex = 78;
            this.doktortxtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Active = false;
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.Tomato;
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "Ekranı Temizle";
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
            this.bunifuFlatButton1.Location = new System.Drawing.Point(227, 24);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.Tomato;
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.Tomato;
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(182, 25);
            this.bunifuFlatButton1.TabIndex = 79;
            this.bunifuFlatButton1.Text = "Ekranı Temizle";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // RandevuPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(57)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(1012, 458);
            this.Controls.Add(this.bunifuFlatButton1);
            this.Controls.Add(this.doktortxtbox);
            this.Controls.Add(this.polikliniktxtbox);
            this.Controls.Add(this.poliklinikler);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cinsiyetbox);
            this.Controls.Add(this.randevukaydet);
            this.Controls.Add(this.ilcedropdown);
            this.Controls.Add(this.ildropdown);
            this.Controls.Add(this.doktordgv);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.randevutarih);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bunifuSeparator2);
            this.Controls.Add(this.hastakaydet);
            this.Controls.Add(this.dogumtarihibox);
            this.Controls.Add(this.dogumyeribox);
            this.Controls.Add(this.nobox);
            this.Controls.Add(this.soyadbox);
            this.Controls.Add(this.adbox);
            this.Controls.Add(this.tcbox);
            this.Controls.Add(this.kayıtsorgula);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.exitButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RandevuPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RandevuPanel";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.doktordgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.poliklinikler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuFlatButton randevukaydet;
        private Bunifu.Framework.UI.BunifuDropdown ilcedropdown;
        private Bunifu.Framework.UI.BunifuDropdown ildropdown;
        private Bunifu.UI.WinForms.BunifuDataGridView doktordgv;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuDatepicker randevutarih;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator2;
        private Bunifu.Framework.UI.BunifuFlatButton hastakaydet;
        private Bunifu.Framework.UI.BunifuDatepicker dogumtarihibox;
        private Bunifu.Framework.UI.BunifuMaterialTextbox dogumyeribox;
        private Bunifu.Framework.UI.BunifuMaterialTextbox nobox;
        private Bunifu.Framework.UI.BunifuMaterialTextbox soyadbox;
        private Bunifu.Framework.UI.BunifuMaterialTextbox adbox;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tcbox;
        private Bunifu.Framework.UI.BunifuFlatButton kayıtsorgula;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private Bunifu.Framework.UI.BunifuImageButton exitButton;
        private Bunifu.Framework.UI.BunifuMaterialTextbox cinsiyetbox;
        private System.Windows.Forms.Label label3;
        private Bunifu.UI.WinForms.BunifuDataGridView poliklinikler;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuMaterialTextbox polikliniktxtbox;
        private Bunifu.Framework.UI.BunifuMaterialTextbox doktortxtbox;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
    }
}