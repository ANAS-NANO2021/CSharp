
namespace HastaneOtomasyonu.ViewLayer
{
    partial class RandevuRecete
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RandevuRecete));
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.bulgutxtbx = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ilaclardgv = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.bunifuFlatButton2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.exitButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.arabox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.ilaclardgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(4, 41);
            this.bunifuSeparator1.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(938, 8);
            this.bunifuSeparator1.TabIndex = 25;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // bulgutxtbx
            // 
            this.bulgutxtbx.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.bulgutxtbx.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.bulgutxtbx.BackColor = System.Drawing.Color.Gainsboro;
            this.bulgutxtbx.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.bulgutxtbx.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bulgutxtbx.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bulgutxtbx.ForeColor = System.Drawing.Color.Black;
            this.bulgutxtbx.HintForeColor = System.Drawing.Color.Empty;
            this.bulgutxtbx.HintText = "";
            this.bulgutxtbx.isPassword = false;
            this.bulgutxtbx.LineFocusedColor = System.Drawing.Color.Blue;
            this.bulgutxtbx.LineIdleColor = System.Drawing.Color.LightCoral;
            this.bulgutxtbx.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.bulgutxtbx.LineThickness = 3;
            this.bulgutxtbx.Location = new System.Drawing.Point(4, 455);
            this.bulgutxtbx.Margin = new System.Windows.Forms.Padding(4);
            this.bulgutxtbx.MaxLength = 32767;
            this.bulgutxtbx.Name = "bulgutxtbx";
            this.bulgutxtbx.Size = new System.Drawing.Size(467, 84);
            this.bulgutxtbx.TabIndex = 27;
            this.bulgutxtbx.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(11, 423);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 24);
            this.label2.TabIndex = 35;
            this.label2.Text = "Açıklama";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(11, 18);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 24);
            this.label3.TabIndex = 39;
            this.label3.Text = "İlaçlar";
            // 
            // ilaclardgv
            // 
            this.ilaclardgv.AllowCustomTheming = false;
            this.ilaclardgv.AllowUserToAddRows = false;
            this.ilaclardgv.AllowUserToDeleteRows = false;
            this.ilaclardgv.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            this.ilaclardgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.ilaclardgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ilaclardgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ilaclardgv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ilaclardgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ilaclardgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.ilaclardgv.ColumnHeadersHeight = 40;
            this.ilaclardgv.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.ilaclardgv.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.ilaclardgv.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.White;
            this.ilaclardgv.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            this.ilaclardgv.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            this.ilaclardgv.CurrentTheme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.ilaclardgv.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.ilaclardgv.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.ilaclardgv.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.ilaclardgv.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.ilaclardgv.CurrentTheme.Name = null;
            this.ilaclardgv.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.ilaclardgv.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.ilaclardgv.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.ilaclardgv.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            this.ilaclardgv.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ilaclardgv.DefaultCellStyle = dataGridViewCellStyle3;
            this.ilaclardgv.EnableHeadersVisualStyles = false;
            this.ilaclardgv.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.ilaclardgv.HeaderBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.ilaclardgv.HeaderBgColor = System.Drawing.Color.Empty;
            this.ilaclardgv.HeaderForeColor = System.Drawing.Color.White;
            this.ilaclardgv.Location = new System.Drawing.Point(4, 85);
            this.ilaclardgv.Name = "ilaclardgv";
            this.ilaclardgv.ReadOnly = true;
            this.ilaclardgv.RowHeadersVisible = false;
            this.ilaclardgv.RowTemplate.Height = 40;
            this.ilaclardgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ilaclardgv.Size = new System.Drawing.Size(467, 335);
            this.ilaclardgv.TabIndex = 41;
            this.ilaclardgv.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Dark;
            // 
            // bunifuFlatButton2
            // 
            this.bunifuFlatButton2.Active = false;
            this.bunifuFlatButton2.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton2.BorderRadius = 0;
            this.bunifuFlatButton2.ButtonText = "İlaç Ekle";
            this.bunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton2.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton2.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton2.Iconimage")));
            this.bunifuFlatButton2.Iconimage_right = null;
            this.bunifuFlatButton2.Iconimage_right_Selected = null;
            this.bunifuFlatButton2.Iconimage_Selected = null;
            this.bunifuFlatButton2.IconMarginLeft = 0;
            this.bunifuFlatButton2.IconMarginRight = 0;
            this.bunifuFlatButton2.IconRightVisible = true;
            this.bunifuFlatButton2.IconRightZoom = 0D;
            this.bunifuFlatButton2.IconVisible = true;
            this.bunifuFlatButton2.IconZoom = 90D;
            this.bunifuFlatButton2.IsTab = false;
            this.bunifuFlatButton2.Location = new System.Drawing.Point(133, 558);
            this.bunifuFlatButton2.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuFlatButton2.Name = "bunifuFlatButton2";
            this.bunifuFlatButton2.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton2.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton2.selected = false;
            this.bunifuFlatButton2.Size = new System.Drawing.Size(160, 39);
            this.bunifuFlatButton2.TabIndex = 37;
            this.bunifuFlatButton2.Text = "İlaç Ekle";
            this.bunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton2.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton2.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton2.Click += new System.EventHandler(this.bunifuFlatButton2_Click);
            // 
            // exitButton
            // 
            this.exitButton.Image = ((System.Drawing.Image)(resources.GetObject("exitButton.Image")));
            this.exitButton.ImageActive = null;
            this.exitButton.Location = new System.Drawing.Point(420, 0);
            this.exitButton.Margin = new System.Windows.Forms.Padding(2);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(39, 41);
            this.exitButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.exitButton.TabIndex = 24;
            this.exitButton.TabStop = false;
            this.exitButton.Zoom = 10;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
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
            this.arabox.HintText = "Aramak İçin İlaç Adı Yazın";
            this.arabox.isPassword = false;
            this.arabox.LineFocusedColor = System.Drawing.Color.Blue;
            this.arabox.LineIdleColor = System.Drawing.Color.Gray;
            this.arabox.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.arabox.LineThickness = 3;
            this.arabox.Location = new System.Drawing.Point(48, 47);
            this.arabox.Margin = new System.Windows.Forms.Padding(4);
            this.arabox.MaxLength = 32767;
            this.arabox.Name = "arabox";
            this.arabox.Size = new System.Drawing.Size(423, 33);
            this.arabox.TabIndex = 42;
            this.arabox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.arabox.OnValueChanged += new System.EventHandler(this.arabox_OnValueChanged);
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(4, 46);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(37, 33);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bunifuImageButton1.TabIndex = 43;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            // 
            // Recete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(57)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(473, 610);
            this.Controls.Add(this.bunifuImageButton1);
            this.Controls.Add(this.ilaclardgv);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bunifuFlatButton2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bulgutxtbx);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.arabox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Recete";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.MuayenePanel_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.ilaclardgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private Bunifu.Framework.UI.BunifuImageButton exitButton;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bulgutxtbx;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton2;
        private System.Windows.Forms.Label label3;
        private Bunifu.UI.WinForms.BunifuDataGridView ilaclardgv;
        private Bunifu.Framework.UI.BunifuMaterialTextbox arabox;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
    }
}