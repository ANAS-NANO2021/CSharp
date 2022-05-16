
namespace HastaneOtomasyonu.ViewLayer
{
    partial class Recete
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Recete));
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.exitButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.bulgutxtbx = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.ilaclardgv = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.bunifuFlatButton2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BARKOD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ADI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.exitButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ilaclardgv)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(4, 41);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(938, 8);
            this.bunifuSeparator1.TabIndex = 25;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
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
            this.bulgutxtbx.Location = new System.Drawing.Point(11, 455);
            this.bulgutxtbx.Margin = new System.Windows.Forms.Padding(4);
            this.bulgutxtbx.MaxLength = 32767;
            this.bulgutxtbx.Name = "bulgutxtbx";
            this.bulgutxtbx.Size = new System.Drawing.Size(439, 84);
            this.bulgutxtbx.TabIndex = 27;
            this.bulgutxtbx.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // ilaclardgv
            // 
            this.ilaclardgv.AllowUserToAddRows = false;
            this.ilaclardgv.AllowUserToDeleteRows = false;
            this.ilaclardgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ilaclardgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.BARKOD,
            this.ADI});
            this.ilaclardgv.Location = new System.Drawing.Point(11, 54);
            this.ilaclardgv.Margin = new System.Windows.Forms.Padding(2);
            this.ilaclardgv.Name = "ilaclardgv";
            this.ilaclardgv.ReadOnly = true;
            this.ilaclardgv.RowHeadersWidth = 51;
            this.ilaclardgv.RowTemplate.Height = 24;
            this.ilaclardgv.Size = new System.Drawing.Size(448, 359);
            this.ilaclardgv.TabIndex = 29;
            this.ilaclardgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ilaclardgv_CellClick);
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
            this.bunifuFlatButton2.Location = new System.Drawing.Point(290, 555);
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
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            this.ID.Width = 5;
            // 
            // BARKOD
            // 
            this.BARKOD.HeaderText = "Barkod";
            this.BARKOD.Name = "BARKOD";
            this.BARKOD.ReadOnly = true;
            this.BARKOD.Visible = false;
            // 
            // ADI
            // 
            this.ADI.HeaderText = "Adı";
            this.ADI.Name = "ADI";
            this.ADI.ReadOnly = true;
            this.ADI.Visible = false;
            this.ADI.Width = 250;
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
            // Recete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(473, 610);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bunifuFlatButton2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ilaclardgv);
            this.Controls.Add(this.bulgutxtbx);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.exitButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Recete";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.MuayenePanel_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.exitButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ilaclardgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private Bunifu.Framework.UI.BunifuImageButton exitButton;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bulgutxtbx;
        private System.Windows.Forms.DataGridView ilaclardgv;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn BARKOD;
        private System.Windows.Forms.DataGridViewTextBoxColumn ADI;
        private System.Windows.Forms.Label label3;
    }
}