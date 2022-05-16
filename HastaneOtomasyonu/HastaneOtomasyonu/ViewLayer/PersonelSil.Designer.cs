
namespace HastaneOtomasyonu.ViewLayer
{
    partial class PersonelSil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PersonelSil));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.exitButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.personeldgv = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.adsoyad = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.tc = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.tel = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.dtarihi = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuTileButton5 = new Bunifu.Framework.UI.BunifuTileButton();
            ((System.ComponentModel.ISupportInitialize)(this.exitButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personeldgv)).BeginInit();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.Image = ((System.Drawing.Image)(resources.GetObject("exitButton.Image")));
            this.exitButton.ImageActive = null;
            this.exitButton.Location = new System.Drawing.Point(899, 8);
            this.exitButton.Margin = new System.Windows.Forms.Padding(2);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(39, 41);
            this.exitButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.exitButton.TabIndex = 28;
            this.exitButton.TabStop = false;
            this.exitButton.Zoom = 10;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(0, 41);
            this.bunifuSeparator1.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(938, 8);
            this.bunifuSeparator1.TabIndex = 29;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // personeldgv
            // 
            this.personeldgv.AllowCustomTheming = false;
            this.personeldgv.AllowUserToAddRows = false;
            this.personeldgv.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.personeldgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.personeldgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.personeldgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.personeldgv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.personeldgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.personeldgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.personeldgv.ColumnHeadersHeight = 40;
            this.personeldgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.personeldgv.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.personeldgv.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.personeldgv.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.personeldgv.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.personeldgv.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.personeldgv.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.personeldgv.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.personeldgv.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.personeldgv.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.personeldgv.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.personeldgv.CurrentTheme.Name = null;
            this.personeldgv.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.personeldgv.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.personeldgv.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.personeldgv.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.personeldgv.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.personeldgv.DefaultCellStyle = dataGridViewCellStyle3;
            this.personeldgv.EnableHeadersVisualStyles = false;
            this.personeldgv.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.personeldgv.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.personeldgv.HeaderBgColor = System.Drawing.Color.Empty;
            this.personeldgv.HeaderForeColor = System.Drawing.Color.White;
            this.personeldgv.Location = new System.Drawing.Point(250, 56);
            this.personeldgv.Name = "personeldgv";
            this.personeldgv.ReadOnly = true;
            this.personeldgv.RowHeadersVisible = false;
            this.personeldgv.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.personeldgv.RowTemplate.Height = 40;
            this.personeldgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.personeldgv.Size = new System.Drawing.Size(688, 388);
            this.personeldgv.TabIndex = 46;
            this.personeldgv.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            this.personeldgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.personeldgv_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(-6, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 25);
            this.label1.TabIndex = 47;
            this.label1.Text = "Seçilen Personel Bilgileri";
            // 
            // adsoyad
            // 
            this.adsoyad.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.adsoyad.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.adsoyad.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.adsoyad.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.adsoyad.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.adsoyad.ForeColor = System.Drawing.Color.White;
            this.adsoyad.HintForeColor = System.Drawing.Color.Empty;
            this.adsoyad.HintText = " ";
            this.adsoyad.isPassword = false;
            this.adsoyad.LineFocusedColor = System.Drawing.Color.Blue;
            this.adsoyad.LineIdleColor = System.Drawing.Color.Gray;
            this.adsoyad.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.adsoyad.LineThickness = 3;
            this.adsoyad.Location = new System.Drawing.Point(0, 101);
            this.adsoyad.Margin = new System.Windows.Forms.Padding(4);
            this.adsoyad.MaxLength = 32767;
            this.adsoyad.Name = "adsoyad";
            this.adsoyad.Size = new System.Drawing.Size(243, 33);
            this.adsoyad.TabIndex = 48;
            this.adsoyad.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // tc
            // 
            this.tc.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.tc.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.tc.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tc.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tc.ForeColor = System.Drawing.Color.White;
            this.tc.HintForeColor = System.Drawing.Color.Empty;
            this.tc.HintText = " ";
            this.tc.isPassword = false;
            this.tc.LineFocusedColor = System.Drawing.Color.Blue;
            this.tc.LineIdleColor = System.Drawing.Color.Gray;
            this.tc.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.tc.LineThickness = 3;
            this.tc.Location = new System.Drawing.Point(1, 159);
            this.tc.Margin = new System.Windows.Forms.Padding(4);
            this.tc.MaxLength = 32767;
            this.tc.Name = "tc";
            this.tc.Size = new System.Drawing.Size(243, 33);
            this.tc.TabIndex = 49;
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
            this.tel.HintForeColor = System.Drawing.Color.Empty;
            this.tel.HintText = " ";
            this.tel.isPassword = false;
            this.tel.LineFocusedColor = System.Drawing.Color.Blue;
            this.tel.LineIdleColor = System.Drawing.Color.Gray;
            this.tel.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.tel.LineThickness = 3;
            this.tel.Location = new System.Drawing.Point(1, 227);
            this.tel.Margin = new System.Windows.Forms.Padding(4);
            this.tel.MaxLength = 32767;
            this.tel.Name = "tel";
            this.tel.Size = new System.Drawing.Size(243, 33);
            this.tel.TabIndex = 50;
            this.tel.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // dtarihi
            // 
            this.dtarihi.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.dtarihi.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.dtarihi.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.dtarihi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.dtarihi.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.dtarihi.ForeColor = System.Drawing.Color.White;
            this.dtarihi.HintForeColor = System.Drawing.Color.Empty;
            this.dtarihi.HintText = " ";
            this.dtarihi.isPassword = false;
            this.dtarihi.LineFocusedColor = System.Drawing.Color.Blue;
            this.dtarihi.LineIdleColor = System.Drawing.Color.Gray;
            this.dtarihi.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.dtarihi.LineThickness = 3;
            this.dtarihi.Location = new System.Drawing.Point(1, 295);
            this.dtarihi.Margin = new System.Windows.Forms.Padding(4);
            this.dtarihi.MaxLength = 32767;
            this.dtarihi.Name = "dtarihi";
            this.dtarihi.Size = new System.Drawing.Size(243, 33);
            this.dtarihi.TabIndex = 51;
            this.dtarihi.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuTileButton5
            // 
            this.bunifuTileButton5.BackColor = System.Drawing.Color.Crimson;
            this.bunifuTileButton5.color = System.Drawing.Color.Crimson;
            this.bunifuTileButton5.colorActive = System.Drawing.Color.IndianRed;
            this.bunifuTileButton5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTileButton5.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.bunifuTileButton5.ForeColor = System.Drawing.Color.White;
            this.bunifuTileButton5.Image = ((System.Drawing.Image)(resources.GetObject("bunifuTileButton5.Image")));
            this.bunifuTileButton5.ImagePosition = 0;
            this.bunifuTileButton5.ImageZoom = 50;
            this.bunifuTileButton5.LabelPosition = 41;
            this.bunifuTileButton5.LabelText = "Personel Sil";
            this.bunifuTileButton5.Location = new System.Drawing.Point(4, 367);
            this.bunifuTileButton5.Margin = new System.Windows.Forms.Padding(6);
            this.bunifuTileButton5.Name = "bunifuTileButton5";
            this.bunifuTileButton5.Size = new System.Drawing.Size(240, 52);
            this.bunifuTileButton5.TabIndex = 52;
            this.bunifuTileButton5.Click += new System.EventHandler(this.bunifuTileButton5_Click);
            // 
            // PersonelSil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(57)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(937, 450);
            this.Controls.Add(this.bunifuTileButton5);
            this.Controls.Add(this.dtarihi);
            this.Controls.Add(this.tel);
            this.Controls.Add(this.tc);
            this.Controls.Add(this.adsoyad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.personeldgv);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.bunifuSeparator1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PersonelSil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PersonelSil";
            ((System.ComponentModel.ISupportInitialize)(this.exitButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personeldgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuImageButton exitButton;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private Bunifu.UI.WinForms.BunifuDataGridView personeldgv;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox adsoyad;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tc;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tel;
        private Bunifu.Framework.UI.BunifuMaterialTextbox dtarihi;
        private Bunifu.Framework.UI.BunifuTileButton bunifuTileButton5;
    }
}