
namespace HastaneOtomasyonu.ViewLayer
{
    partial class PasswordReset
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PasswordReset));
            this.sendbutton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.mailTxtbx = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.exitButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.resetCode = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.newpw = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.karakterkontrol = new Bunifu.UI.WinForms.BunifuCheckBox();
            this.harfkontrol = new Bunifu.UI.WinForms.BunifuCheckBox();
            this.rakamkontrol = new Bunifu.UI.WinForms.BunifuCheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.onaylabuton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pwsave = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            ((System.ComponentModel.ISupportInitialize)(this.exitButton)).BeginInit();
            this.SuspendLayout();
            // 
            // sendbutton
            // 
            this.sendbutton.Active = false;
            this.sendbutton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.sendbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.sendbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.sendbutton.BorderRadius = 0;
            this.sendbutton.ButtonText = "Dogrulama Kodu Gönder";
            this.sendbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sendbutton.DisabledColor = System.Drawing.Color.Gray;
            this.sendbutton.Iconcolor = System.Drawing.Color.Transparent;
            this.sendbutton.Iconimage = ((System.Drawing.Image)(resources.GetObject("sendbutton.Iconimage")));
            this.sendbutton.Iconimage_right = null;
            this.sendbutton.Iconimage_right_Selected = null;
            this.sendbutton.Iconimage_Selected = null;
            this.sendbutton.IconMarginLeft = 0;
            this.sendbutton.IconMarginRight = 0;
            this.sendbutton.IconRightVisible = true;
            this.sendbutton.IconRightZoom = 0D;
            this.sendbutton.IconVisible = true;
            this.sendbutton.IconZoom = 90D;
            this.sendbutton.IsTab = false;
            this.sendbutton.Location = new System.Drawing.Point(356, 93);
            this.sendbutton.Name = "sendbutton";
            this.sendbutton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.sendbutton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.sendbutton.OnHoverTextColor = System.Drawing.Color.White;
            this.sendbutton.selected = false;
            this.sendbutton.Size = new System.Drawing.Size(206, 50);
            this.sendbutton.TabIndex = 7;
            this.sendbutton.Text = "Dogrulama Kodu Gönder";
            this.sendbutton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sendbutton.Textcolor = System.Drawing.Color.White;
            this.sendbutton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendbutton.Click += new System.EventHandler(this.send_Click);
            // 
            // mailTxtbx
            // 
            this.mailTxtbx.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.mailTxtbx.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.mailTxtbx.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.mailTxtbx.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.mailTxtbx.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.mailTxtbx.ForeColor = System.Drawing.Color.White;
            this.mailTxtbx.HintForeColor = System.Drawing.Color.White;
            this.mailTxtbx.HintText = "Personel E Posta Girin";
            this.mailTxtbx.isPassword = false;
            this.mailTxtbx.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(230)))), ((int)(((byte)(118)))));
            this.mailTxtbx.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(246)))), ((int)(((byte)(202)))));
            this.mailTxtbx.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(240)))), ((int)(((byte)(174)))));
            this.mailTxtbx.LineThickness = 3;
            this.mailTxtbx.Location = new System.Drawing.Point(21, 93);
            this.mailTxtbx.MaxLength = 32767;
            this.mailTxtbx.Name = "mailTxtbx";
            this.mailTxtbx.Size = new System.Drawing.Size(297, 50);
            this.mailTxtbx.TabIndex = 5;
            this.mailTxtbx.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // exitButton
            // 
            this.exitButton.Image = ((System.Drawing.Image)(resources.GetObject("exitButton.Image")));
            this.exitButton.ImageActive = null;
            this.exitButton.Location = new System.Drawing.Point(634, 10);
            this.exitButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(39, 41);
            this.exitButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.exitButton.TabIndex = 9;
            this.exitButton.TabStop = false;
            this.exitButton.Zoom = 10;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // resetCode
            // 
            this.resetCode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.resetCode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.resetCode.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.resetCode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.resetCode.Enabled = false;
            this.resetCode.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.resetCode.ForeColor = System.Drawing.Color.White;
            this.resetCode.HintForeColor = System.Drawing.Color.White;
            this.resetCode.HintText = "Doğrulama kodu";
            this.resetCode.isPassword = false;
            this.resetCode.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(230)))), ((int)(((byte)(118)))));
            this.resetCode.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(246)))), ((int)(((byte)(202)))));
            this.resetCode.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(240)))), ((int)(((byte)(174)))));
            this.resetCode.LineThickness = 3;
            this.resetCode.Location = new System.Drawing.Point(21, 161);
            this.resetCode.MaxLength = 32767;
            this.resetCode.Name = "resetCode";
            this.resetCode.Size = new System.Drawing.Size(297, 50);
            this.resetCode.TabIndex = 10;
            this.resetCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // newpw
            // 
            this.newpw.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.newpw.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.newpw.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.newpw.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.newpw.Enabled = false;
            this.newpw.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.newpw.ForeColor = System.Drawing.Color.White;
            this.newpw.HintForeColor = System.Drawing.Color.White;
            this.newpw.HintText = "Yeni Şifre";
            this.newpw.isPassword = false;
            this.newpw.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(230)))), ((int)(((byte)(118)))));
            this.newpw.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(246)))), ((int)(((byte)(202)))));
            this.newpw.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(240)))), ((int)(((byte)(174)))));
            this.newpw.LineThickness = 3;
            this.newpw.Location = new System.Drawing.Point(21, 255);
            this.newpw.MaxLength = 32767;
            this.newpw.Name = "newpw";
            this.newpw.Size = new System.Drawing.Size(297, 50);
            this.newpw.TabIndex = 11;
            this.newpw.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.newpw.OnValueChanged += new System.EventHandler(this.newpw_OnValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(352, 238);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 24);
            this.label1.TabIndex = 13;
            this.label1.Text = "Şifre Kriterleri";
            // 
            // karakterkontrol
            // 
            this.karakterkontrol.AllowBindingControlAnimation = true;
            this.karakterkontrol.AllowBindingControlColorChanges = false;
            this.karakterkontrol.AllowBindingControlLocation = true;
            this.karakterkontrol.AllowCheckBoxAnimation = true;
            this.karakterkontrol.AllowCheckmarkAnimation = true;
            this.karakterkontrol.AllowOnHoverStates = true;
            this.karakterkontrol.AutoCheck = true;
            this.karakterkontrol.BackColor = System.Drawing.Color.Transparent;
            this.karakterkontrol.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("karakterkontrol.BackgroundImage")));
            this.karakterkontrol.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.karakterkontrol.BindingControl = null;
            this.karakterkontrol.BindingControlPosition = Bunifu.UI.WinForms.BunifuCheckBox.BindingControlPositions.Right;
            this.karakterkontrol.Checked = false;
            this.karakterkontrol.CheckState = Bunifu.UI.WinForms.BunifuCheckBox.CheckStates.Unchecked;
            this.karakterkontrol.Cursor = System.Windows.Forms.Cursors.Hand;
            this.karakterkontrol.CustomCheckmarkImage = null;
            this.karakterkontrol.Enabled = false;
            this.karakterkontrol.Location = new System.Drawing.Point(356, 274);
            this.karakterkontrol.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.karakterkontrol.MinimumSize = new System.Drawing.Size(13, 14);
            this.karakterkontrol.Name = "karakterkontrol";
            this.karakterkontrol.OnCheck.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(69)))), ((int)(((byte)(155)))));
            this.karakterkontrol.OnCheck.BorderRadius = 1;
            this.karakterkontrol.OnCheck.BorderThickness = 2;
            this.karakterkontrol.OnCheck.CheckBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(69)))), ((int)(((byte)(155)))));
            this.karakterkontrol.OnCheck.CheckmarkColor = System.Drawing.Color.White;
            this.karakterkontrol.OnCheck.CheckmarkThickness = 2;
            this.karakterkontrol.OnDisable.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(69)))), ((int)(((byte)(155)))));
            this.karakterkontrol.OnDisable.BorderRadius = 1;
            this.karakterkontrol.OnDisable.BorderThickness = 2;
            this.karakterkontrol.OnDisable.CheckBoxColor = System.Drawing.Color.Transparent;
            this.karakterkontrol.OnDisable.CheckmarkColor = System.Drawing.Color.White;
            this.karakterkontrol.OnDisable.CheckmarkThickness = 2;
            this.karakterkontrol.OnHoverChecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(131)))), ((int)(((byte)(188)))));
            this.karakterkontrol.OnHoverChecked.BorderRadius = 1;
            this.karakterkontrol.OnHoverChecked.BorderThickness = 2;
            this.karakterkontrol.OnHoverChecked.CheckBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(131)))), ((int)(((byte)(188)))));
            this.karakterkontrol.OnHoverChecked.CheckmarkColor = System.Drawing.Color.White;
            this.karakterkontrol.OnHoverChecked.CheckmarkThickness = 2;
            this.karakterkontrol.OnHoverUnchecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(131)))), ((int)(((byte)(188)))));
            this.karakterkontrol.OnHoverUnchecked.BorderRadius = 1;
            this.karakterkontrol.OnHoverUnchecked.BorderThickness = 2;
            this.karakterkontrol.OnHoverUnchecked.CheckBoxColor = System.Drawing.Color.Transparent;
            this.karakterkontrol.OnUncheck.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(69)))), ((int)(((byte)(155)))));
            this.karakterkontrol.OnUncheck.BorderRadius = 1;
            this.karakterkontrol.OnUncheck.BorderThickness = 2;
            this.karakterkontrol.OnUncheck.CheckBoxColor = System.Drawing.Color.Transparent;
            this.karakterkontrol.Size = new System.Drawing.Size(16, 16);
            this.karakterkontrol.Style = Bunifu.UI.WinForms.BunifuCheckBox.CheckBoxStyles.Flat;
            this.karakterkontrol.TabIndex = 14;
            this.karakterkontrol.ThreeState = false;
            this.karakterkontrol.ToolTipText = null;
            // 
            // harfkontrol
            // 
            this.harfkontrol.AllowBindingControlAnimation = true;
            this.harfkontrol.AllowBindingControlColorChanges = false;
            this.harfkontrol.AllowBindingControlLocation = true;
            this.harfkontrol.AllowCheckBoxAnimation = false;
            this.harfkontrol.AllowCheckmarkAnimation = true;
            this.harfkontrol.AllowOnHoverStates = true;
            this.harfkontrol.AutoCheck = true;
            this.harfkontrol.BackColor = System.Drawing.Color.Transparent;
            this.harfkontrol.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("harfkontrol.BackgroundImage")));
            this.harfkontrol.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.harfkontrol.BindingControl = null;
            this.harfkontrol.BindingControlPosition = Bunifu.UI.WinForms.BunifuCheckBox.BindingControlPositions.Right;
            this.harfkontrol.Checked = false;
            this.harfkontrol.CheckState = Bunifu.UI.WinForms.BunifuCheckBox.CheckStates.Unchecked;
            this.harfkontrol.Cursor = System.Windows.Forms.Cursors.Hand;
            this.harfkontrol.CustomCheckmarkImage = null;
            this.harfkontrol.Enabled = false;
            this.harfkontrol.Location = new System.Drawing.Point(356, 309);
            this.harfkontrol.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.harfkontrol.MinimumSize = new System.Drawing.Size(13, 14);
            this.harfkontrol.Name = "harfkontrol";
            this.harfkontrol.OnCheck.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(69)))), ((int)(((byte)(155)))));
            this.harfkontrol.OnCheck.BorderRadius = 1;
            this.harfkontrol.OnCheck.BorderThickness = 2;
            this.harfkontrol.OnCheck.CheckBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(69)))), ((int)(((byte)(155)))));
            this.harfkontrol.OnCheck.CheckmarkColor = System.Drawing.Color.White;
            this.harfkontrol.OnCheck.CheckmarkThickness = 2;
            this.harfkontrol.OnDisable.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(69)))), ((int)(((byte)(155)))));
            this.harfkontrol.OnDisable.BorderRadius = 1;
            this.harfkontrol.OnDisable.BorderThickness = 2;
            this.harfkontrol.OnDisable.CheckBoxColor = System.Drawing.Color.Transparent;
            this.harfkontrol.OnDisable.CheckmarkColor = System.Drawing.Color.White;
            this.harfkontrol.OnDisable.CheckmarkThickness = 2;
            this.harfkontrol.OnHoverChecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(131)))), ((int)(((byte)(188)))));
            this.harfkontrol.OnHoverChecked.BorderRadius = 1;
            this.harfkontrol.OnHoverChecked.BorderThickness = 2;
            this.harfkontrol.OnHoverChecked.CheckBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(131)))), ((int)(((byte)(188)))));
            this.harfkontrol.OnHoverChecked.CheckmarkColor = System.Drawing.Color.White;
            this.harfkontrol.OnHoverChecked.CheckmarkThickness = 2;
            this.harfkontrol.OnHoverUnchecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(131)))), ((int)(((byte)(188)))));
            this.harfkontrol.OnHoverUnchecked.BorderRadius = 1;
            this.harfkontrol.OnHoverUnchecked.BorderThickness = 2;
            this.harfkontrol.OnHoverUnchecked.CheckBoxColor = System.Drawing.Color.Transparent;
            this.harfkontrol.OnUncheck.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(69)))), ((int)(((byte)(155)))));
            this.harfkontrol.OnUncheck.BorderRadius = 1;
            this.harfkontrol.OnUncheck.BorderThickness = 2;
            this.harfkontrol.OnUncheck.CheckBoxColor = System.Drawing.Color.Transparent;
            this.harfkontrol.Size = new System.Drawing.Size(16, 16);
            this.harfkontrol.Style = Bunifu.UI.WinForms.BunifuCheckBox.CheckBoxStyles.Flat;
            this.harfkontrol.TabIndex = 15;
            this.harfkontrol.ThreeState = false;
            this.harfkontrol.ToolTipText = null;
            // 
            // rakamkontrol
            // 
            this.rakamkontrol.AllowBindingControlAnimation = true;
            this.rakamkontrol.AllowBindingControlColorChanges = false;
            this.rakamkontrol.AllowBindingControlLocation = true;
            this.rakamkontrol.AllowCheckBoxAnimation = false;
            this.rakamkontrol.AllowCheckmarkAnimation = true;
            this.rakamkontrol.AllowOnHoverStates = true;
            this.rakamkontrol.AutoCheck = true;
            this.rakamkontrol.BackColor = System.Drawing.Color.Transparent;
            this.rakamkontrol.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rakamkontrol.BackgroundImage")));
            this.rakamkontrol.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.rakamkontrol.BindingControl = null;
            this.rakamkontrol.BindingControlPosition = Bunifu.UI.WinForms.BunifuCheckBox.BindingControlPositions.Right;
            this.rakamkontrol.Checked = false;
            this.rakamkontrol.CheckState = Bunifu.UI.WinForms.BunifuCheckBox.CheckStates.Unchecked;
            this.rakamkontrol.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rakamkontrol.CustomCheckmarkImage = null;
            this.rakamkontrol.Enabled = false;
            this.rakamkontrol.Location = new System.Drawing.Point(356, 347);
            this.rakamkontrol.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rakamkontrol.MinimumSize = new System.Drawing.Size(13, 14);
            this.rakamkontrol.Name = "rakamkontrol";
            this.rakamkontrol.OnCheck.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(69)))), ((int)(((byte)(155)))));
            this.rakamkontrol.OnCheck.BorderRadius = 1;
            this.rakamkontrol.OnCheck.BorderThickness = 2;
            this.rakamkontrol.OnCheck.CheckBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(69)))), ((int)(((byte)(155)))));
            this.rakamkontrol.OnCheck.CheckmarkColor = System.Drawing.Color.White;
            this.rakamkontrol.OnCheck.CheckmarkThickness = 2;
            this.rakamkontrol.OnDisable.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(69)))), ((int)(((byte)(155)))));
            this.rakamkontrol.OnDisable.BorderRadius = 1;
            this.rakamkontrol.OnDisable.BorderThickness = 2;
            this.rakamkontrol.OnDisable.CheckBoxColor = System.Drawing.Color.Transparent;
            this.rakamkontrol.OnDisable.CheckmarkColor = System.Drawing.Color.White;
            this.rakamkontrol.OnDisable.CheckmarkThickness = 2;
            this.rakamkontrol.OnHoverChecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(131)))), ((int)(((byte)(188)))));
            this.rakamkontrol.OnHoverChecked.BorderRadius = 1;
            this.rakamkontrol.OnHoverChecked.BorderThickness = 2;
            this.rakamkontrol.OnHoverChecked.CheckBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(131)))), ((int)(((byte)(188)))));
            this.rakamkontrol.OnHoverChecked.CheckmarkColor = System.Drawing.Color.White;
            this.rakamkontrol.OnHoverChecked.CheckmarkThickness = 2;
            this.rakamkontrol.OnHoverUnchecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(131)))), ((int)(((byte)(188)))));
            this.rakamkontrol.OnHoverUnchecked.BorderRadius = 1;
            this.rakamkontrol.OnHoverUnchecked.BorderThickness = 2;
            this.rakamkontrol.OnHoverUnchecked.CheckBoxColor = System.Drawing.Color.Transparent;
            this.rakamkontrol.OnUncheck.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(69)))), ((int)(((byte)(155)))));
            this.rakamkontrol.OnUncheck.BorderRadius = 1;
            this.rakamkontrol.OnUncheck.BorderThickness = 2;
            this.rakamkontrol.OnUncheck.CheckBoxColor = System.Drawing.Color.Transparent;
            this.rakamkontrol.Size = new System.Drawing.Size(16, 16);
            this.rakamkontrol.Style = Bunifu.UI.WinForms.BunifuCheckBox.CheckBoxStyles.Flat;
            this.rakamkontrol.TabIndex = 16;
            this.rakamkontrol.ThreeState = false;
            this.rakamkontrol.ToolTipText = null;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(376, 271);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(247, 18);
            this.label2.TabIndex = 17;
            this.label2.Text = "Şifre en az 8 karakterden oluşmalıdır";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(376, 306);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(296, 18);
            this.label3.TabIndex = 18;
            this.label3.Text = "Şifre en az 1 büyük ve küçük harf içermelidir";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(376, 344);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(207, 18);
            this.label4.TabIndex = 19;
            this.label4.Text = "Şifre en az 1 rakam içermelidir";
            // 
            // onaylabuton
            // 
            this.onaylabuton.Active = false;
            this.onaylabuton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.onaylabuton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.onaylabuton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.onaylabuton.BorderRadius = 0;
            this.onaylabuton.ButtonText = "Onayla";
            this.onaylabuton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.onaylabuton.DisabledColor = System.Drawing.Color.Gray;
            this.onaylabuton.Enabled = false;
            this.onaylabuton.Iconcolor = System.Drawing.Color.Transparent;
            this.onaylabuton.Iconimage = ((System.Drawing.Image)(resources.GetObject("onaylabuton.Iconimage")));
            this.onaylabuton.Iconimage_right = null;
            this.onaylabuton.Iconimage_right_Selected = null;
            this.onaylabuton.Iconimage_Selected = null;
            this.onaylabuton.IconMarginLeft = 0;
            this.onaylabuton.IconMarginRight = 0;
            this.onaylabuton.IconRightVisible = true;
            this.onaylabuton.IconRightZoom = 0D;
            this.onaylabuton.IconVisible = true;
            this.onaylabuton.IconZoom = 90D;
            this.onaylabuton.IsTab = false;
            this.onaylabuton.Location = new System.Drawing.Point(356, 161);
            this.onaylabuton.Name = "onaylabuton";
            this.onaylabuton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.onaylabuton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.onaylabuton.OnHoverTextColor = System.Drawing.Color.White;
            this.onaylabuton.selected = false;
            this.onaylabuton.Size = new System.Drawing.Size(206, 50);
            this.onaylabuton.TabIndex = 20;
            this.onaylabuton.Text = "Onayla";
            this.onaylabuton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.onaylabuton.Textcolor = System.Drawing.Color.White;
            this.onaylabuton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.onaylabuton.Click += new System.EventHandler(this.onaylabuton_Click);
            // 
            // pwsave
            // 
            this.pwsave.Active = false;
            this.pwsave.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.pwsave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.pwsave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pwsave.BorderRadius = 0;
            this.pwsave.ButtonText = "Şifreyi Değiştir";
            this.pwsave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pwsave.DisabledColor = System.Drawing.Color.Gray;
            this.pwsave.Enabled = false;
            this.pwsave.Iconcolor = System.Drawing.Color.Transparent;
            this.pwsave.Iconimage = ((System.Drawing.Image)(resources.GetObject("pwsave.Iconimage")));
            this.pwsave.Iconimage_right = null;
            this.pwsave.Iconimage_right_Selected = null;
            this.pwsave.Iconimage_Selected = null;
            this.pwsave.IconMarginLeft = 0;
            this.pwsave.IconMarginRight = 0;
            this.pwsave.IconRightVisible = true;
            this.pwsave.IconRightZoom = 0D;
            this.pwsave.IconVisible = true;
            this.pwsave.IconZoom = 90D;
            this.pwsave.IsTab = false;
            this.pwsave.Location = new System.Drawing.Point(65, 344);
            this.pwsave.Name = "pwsave";
            this.pwsave.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.pwsave.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.pwsave.OnHoverTextColor = System.Drawing.Color.White;
            this.pwsave.selected = false;
            this.pwsave.Size = new System.Drawing.Size(206, 50);
            this.pwsave.TabIndex = 21;
            this.pwsave.Text = "Şifreyi Değiştir";
            this.pwsave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pwsave.Textcolor = System.Drawing.Color.White;
            this.pwsave.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pwsave.Click += new System.EventHandler(this.pwsave_Click);
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(1, 42);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(692, 35);
            this.bunifuSeparator1.TabIndex = 22;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // PasswordReset
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(57)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(689, 435);
            this.Controls.Add(this.pwsave);
            this.Controls.Add(this.onaylabuton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rakamkontrol);
            this.Controls.Add(this.harfkontrol);
            this.Controls.Add(this.karakterkontrol);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.newpw);
            this.Controls.Add(this.resetCode);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.sendbutton);
            this.Controls.Add(this.mailTxtbx);
            this.Controls.Add(this.bunifuSeparator1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "PasswordReset";
            this.Text = "PasswordReset";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.exitButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuFlatButton sendbutton;
        private Bunifu.Framework.UI.BunifuMaterialTextbox mailTxtbx;
        private Bunifu.Framework.UI.BunifuImageButton exitButton;
        private Bunifu.Framework.UI.BunifuMaterialTextbox resetCode;
        private Bunifu.Framework.UI.BunifuMaterialTextbox newpw;
        private System.Windows.Forms.Label label1;
        private Bunifu.UI.WinForms.BunifuCheckBox karakterkontrol;
        private Bunifu.UI.WinForms.BunifuCheckBox harfkontrol;
        private Bunifu.UI.WinForms.BunifuCheckBox rakamkontrol;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuFlatButton onaylabuton;
        private Bunifu.Framework.UI.BunifuFlatButton pwsave;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
    }
}