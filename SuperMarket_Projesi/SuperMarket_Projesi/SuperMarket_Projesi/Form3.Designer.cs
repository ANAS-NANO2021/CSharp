
namespace SuperMarket_Projesi
{
    partial class ProductForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.productdv2 = new System.Windows.Forms.DataGridView();
            this.Date1 = new Bunifu.Framework.UI.BunifuDatepicker();
            this.PriceTxt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PurchasePriceTxt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Detailstxt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.QuenTxt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.NameTxt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.prodId = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.CatCB = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.Supply = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.button1 = new System.Windows.Forms.Button();
            this.bunifuThinButton23 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuThinButton22 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.EkleButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productdv2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkOrange;
            this.panel1.Controls.Add(this.Supply);
            this.panel1.Controls.Add(this.productdv2);
            this.panel1.Controls.Add(this.Date1);
            this.panel1.Controls.Add(this.PriceTxt);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.bunifuThinButton23);
            this.panel1.Controls.Add(this.bunifuThinButton22);
            this.panel1.Controls.Add(this.bunifuThinButton21);
            this.panel1.Controls.Add(this.EkleButton);
            this.panel1.Controls.Add(this.PurchasePriceTxt);
            this.panel1.Controls.Add(this.Detailstxt);
            this.panel1.Controls.Add(this.QuenTxt);
            this.panel1.Controls.Add(this.NameTxt);
            this.panel1.Controls.Add(this.prodId);
            this.panel1.Controls.Add(this.CatCB);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(111, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(722, 461);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // productdv2
            // 
            this.productdv2.BackgroundColor = System.Drawing.Color.White;
            this.productdv2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productdv2.Location = new System.Drawing.Point(316, 78);
            this.productdv2.Name = "productdv2";
            this.productdv2.Size = new System.Drawing.Size(400, 373);
            this.productdv2.TabIndex = 41;
            // 
            // Date1
            // 
            this.Date1.BackColor = System.Drawing.Color.White;
            this.Date1.BorderRadius = 0;
            this.Date1.ForeColor = System.Drawing.Color.DarkOrange;
            this.Date1.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.Date1.FormatCustom = null;
            this.Date1.Location = new System.Drawing.Point(102, 269);
            this.Date1.Name = "Date1";
            this.Date1.Size = new System.Drawing.Size(126, 22);
            this.Date1.TabIndex = 40;
            this.Date1.Value = new System.DateTime(2021, 12, 1, 22, 37, 24, 78);
            // 
            // PriceTxt
            // 
            this.PriceTxt.BackColor = System.Drawing.Color.DarkOrange;
            this.PriceTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PriceTxt.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.PriceTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PriceTxt.HintForeColor = System.Drawing.Color.Empty;
            this.PriceTxt.HintText = "";
            this.PriceTxt.isPassword = false;
            this.PriceTxt.LineFocusedColor = System.Drawing.Color.Blue;
            this.PriceTxt.LineIdleColor = System.Drawing.Color.White;
            this.PriceTxt.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.PriceTxt.LineThickness = 3;
            this.PriceTxt.Location = new System.Drawing.Point(102, 208);
            this.PriceTxt.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.PriceTxt.Name = "PriceTxt";
            this.PriceTxt.Size = new System.Drawing.Size(126, 22);
            this.PriceTxt.TabIndex = 39;
            this.PriceTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label10.Location = new System.Drawing.Point(0, 209);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 25);
            this.label10.TabIndex = 38;
            this.label10.Text = "Alışfiyatı";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label9.Location = new System.Drawing.Point(2, 302);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 25);
            this.label9.TabIndex = 37;
            this.label9.Text = "Tedarikçi";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label8.Location = new System.Drawing.Point(0, 270);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 25);
            this.label8.TabIndex = 34;
            this.label8.Text = "Tarih";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(209, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 37);
            this.label1.TabIndex = 32;
            this.label1.Text = "ÜRÜNLERİ YÖNET";
            // 
            // PurchasePriceTxt
            // 
            this.PurchasePriceTxt.BackColor = System.Drawing.Color.DarkOrange;
            this.PurchasePriceTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PurchasePriceTxt.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.PurchasePriceTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PurchasePriceTxt.HintForeColor = System.Drawing.Color.Empty;
            this.PurchasePriceTxt.HintText = "";
            this.PurchasePriceTxt.isPassword = false;
            this.PurchasePriceTxt.LineFocusedColor = System.Drawing.Color.Blue;
            this.PurchasePriceTxt.LineIdleColor = System.Drawing.Color.White;
            this.PurchasePriceTxt.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.PurchasePriceTxt.LineThickness = 3;
            this.PurchasePriceTxt.Location = new System.Drawing.Point(102, 179);
            this.PurchasePriceTxt.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.PurchasePriceTxt.Name = "PurchasePriceTxt";
            this.PurchasePriceTxt.Size = new System.Drawing.Size(126, 21);
            this.PurchasePriceTxt.TabIndex = 22;
            this.PurchasePriceTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.PurchasePriceTxt.OnValueChanged += new System.EventHandler(this.bunifuMaterialTextbox5_OnValueChanged);
            // 
            // Detailstxt
            // 
            this.Detailstxt.BackColor = System.Drawing.Color.DarkOrange;
            this.Detailstxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Detailstxt.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Detailstxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Detailstxt.HintForeColor = System.Drawing.Color.Empty;
            this.Detailstxt.HintText = "";
            this.Detailstxt.isPassword = false;
            this.Detailstxt.LineFocusedColor = System.Drawing.Color.Blue;
            this.Detailstxt.LineIdleColor = System.Drawing.Color.White;
            this.Detailstxt.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.Detailstxt.LineThickness = 3;
            this.Detailstxt.Location = new System.Drawing.Point(102, 238);
            this.Detailstxt.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Detailstxt.Name = "Detailstxt";
            this.Detailstxt.Size = new System.Drawing.Size(126, 21);
            this.Detailstxt.TabIndex = 21;
            this.Detailstxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Detailstxt.OnValueChanged += new System.EventHandler(this.Detailstxt_OnValueChanged);
            // 
            // QuenTxt
            // 
            this.QuenTxt.BackColor = System.Drawing.Color.DarkOrange;
            this.QuenTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.QuenTxt.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.QuenTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.QuenTxt.HintForeColor = System.Drawing.Color.Empty;
            this.QuenTxt.HintText = "";
            this.QuenTxt.isPassword = false;
            this.QuenTxt.LineFocusedColor = System.Drawing.Color.Blue;
            this.QuenTxt.LineIdleColor = System.Drawing.Color.White;
            this.QuenTxt.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.QuenTxt.LineThickness = 3;
            this.QuenTxt.Location = new System.Drawing.Point(102, 137);
            this.QuenTxt.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.QuenTxt.Name = "QuenTxt";
            this.QuenTxt.Size = new System.Drawing.Size(126, 21);
            this.QuenTxt.TabIndex = 20;
            this.QuenTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.QuenTxt.OnValueChanged += new System.EventHandler(this.QuenTxt_OnValueChanged);
            // 
            // NameTxt
            // 
            this.NameTxt.BackColor = System.Drawing.Color.DarkOrange;
            this.NameTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NameTxt.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.NameTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.NameTxt.HintForeColor = System.Drawing.Color.Empty;
            this.NameTxt.HintText = "";
            this.NameTxt.isPassword = false;
            this.NameTxt.LineFocusedColor = System.Drawing.Color.Blue;
            this.NameTxt.LineIdleColor = System.Drawing.Color.White;
            this.NameTxt.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.NameTxt.LineThickness = 3;
            this.NameTxt.Location = new System.Drawing.Point(102, 102);
            this.NameTxt.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.NameTxt.Name = "NameTxt";
            this.NameTxt.Size = new System.Drawing.Size(126, 27);
            this.NameTxt.TabIndex = 19;
            this.NameTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.NameTxt.OnValueChanged += new System.EventHandler(this.NameTxt_OnValueChanged);
            // 
            // prodId
            // 
            this.prodId.BackColor = System.Drawing.Color.DarkOrange;
            this.prodId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.prodId.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.prodId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.prodId.HintForeColor = System.Drawing.Color.Empty;
            this.prodId.HintText = "";
            this.prodId.isPassword = false;
            this.prodId.LineFocusedColor = System.Drawing.Color.Blue;
            this.prodId.LineIdleColor = System.Drawing.Color.White;
            this.prodId.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.prodId.LineThickness = 3;
            this.prodId.Location = new System.Drawing.Point(102, 68);
            this.prodId.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.prodId.Name = "prodId";
            this.prodId.Size = new System.Drawing.Size(126, 26);
            this.prodId.TabIndex = 18;
            this.prodId.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // CatCB
            // 
            this.CatCB.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CatCB.ForeColor = System.Drawing.Color.DarkOrange;
            this.CatCB.FormattingEnabled = true;
            this.CatCB.Items.AddRange(new object[] {
            "Gıda",
            "Ağız Bakımı",
            "Aydınlatma",
            "NULL"});
            this.CatCB.Location = new System.Drawing.Point(102, 342);
            this.CatCB.Name = "CatCB";
            this.CatCB.Size = new System.Drawing.Size(121, 25);
            this.CatCB.TabIndex = 17;
            this.CatCB.Text = "Tedarikçi tipi Seç";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(3, 342);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 25);
            this.label7.TabIndex = 16;
            this.label7.Text = "Kategori";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(-1, 238);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 25);
            this.label6.TabIndex = 10;
            this.label6.Text = "Açıklama";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(3, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "Satışfiyatı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(0, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Miktar";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(1, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ürün Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(9, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ürün ID";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.DarkOrange;
            this.button2.Location = new System.Drawing.Point(12, 176);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 32);
            this.button2.TabIndex = 2;
            this.button2.Text = " Satış";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.DarkOrange;
            this.button3.Location = new System.Drawing.Point(3, 235);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(102, 32);
            this.button3.TabIndex = 3;
            this.button3.Text = "Kategori";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Supply
            // 
            this.Supply.BackColor = System.Drawing.Color.DarkOrange;
            this.Supply.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Supply.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Supply.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Supply.HintForeColor = System.Drawing.Color.Empty;
            this.Supply.HintText = "";
            this.Supply.isPassword = false;
            this.Supply.LineFocusedColor = System.Drawing.Color.Blue;
            this.Supply.LineIdleColor = System.Drawing.Color.White;
            this.Supply.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.Supply.LineThickness = 3;
            this.Supply.Location = new System.Drawing.Point(102, 302);
            this.Supply.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Supply.Name = "Supply";
            this.Supply.Size = new System.Drawing.Size(126, 25);
            this.Supply.TabIndex = 42;
            this.Supply.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.DarkOrange;
            this.button1.Location = new System.Drawing.Point(3, 124);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 32);
            this.button1.TabIndex = 4;
            this.button1.Text = "Faturalar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bunifuThinButton23
            // 
            this.bunifuThinButton23.ActiveBorderThickness = 1;
            this.bunifuThinButton23.ActiveCornerRadius = 20;
            this.bunifuThinButton23.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton23.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton23.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton23.BackColor = System.Drawing.Color.DarkOrange;
            this.bunifuThinButton23.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton23.BackgroundImage")));
            this.bunifuThinButton23.ButtonText = "yenile";
            this.bunifuThinButton23.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton23.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton23.ForeColor = System.Drawing.Color.Transparent;
            this.bunifuThinButton23.IdleBorderThickness = 1;
            this.bunifuThinButton23.IdleCornerRadius = 20;
            this.bunifuThinButton23.IdleFillColor = System.Drawing.Color.White;
            this.bunifuThinButton23.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton23.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton23.Location = new System.Drawing.Point(580, 38);
            this.bunifuThinButton23.Margin = new System.Windows.Forms.Padding(0);
            this.bunifuThinButton23.Name = "bunifuThinButton23";
            this.bunifuThinButton23.Size = new System.Drawing.Size(84, 37);
            this.bunifuThinButton23.TabIndex = 31;
            this.bunifuThinButton23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuThinButton22
            // 
            this.bunifuThinButton22.ActiveBorderThickness = 1;
            this.bunifuThinButton22.ActiveCornerRadius = 20;
            this.bunifuThinButton22.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton22.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton22.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton22.BackColor = System.Drawing.Color.DarkOrange;
            this.bunifuThinButton22.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton22.BackgroundImage")));
            this.bunifuThinButton22.ButtonText = "Sil";
            this.bunifuThinButton22.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton22.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton22.ForeColor = System.Drawing.Color.Transparent;
            this.bunifuThinButton22.IdleBorderThickness = 1;
            this.bunifuThinButton22.IdleCornerRadius = 20;
            this.bunifuThinButton22.IdleFillColor = System.Drawing.Color.White;
            this.bunifuThinButton22.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton22.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton22.Location = new System.Drawing.Point(192, 382);
            this.bunifuThinButton22.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.bunifuThinButton22.Name = "bunifuThinButton22";
            this.bunifuThinButton22.Size = new System.Drawing.Size(71, 34);
            this.bunifuThinButton22.TabIndex = 26;
            this.bunifuThinButton22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuThinButton21
            // 
            this.bunifuThinButton21.ActiveBorderThickness = 1;
            this.bunifuThinButton21.ActiveCornerRadius = 20;
            this.bunifuThinButton21.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton21.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.BackColor = System.Drawing.Color.DarkOrange;
            this.bunifuThinButton21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton21.BackgroundImage")));
            this.bunifuThinButton21.ButtonText = "Güncelle";
            this.bunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton21.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton21.ForeColor = System.Drawing.Color.Transparent;
            this.bunifuThinButton21.IdleBorderThickness = 1;
            this.bunifuThinButton21.IdleCornerRadius = 20;
            this.bunifuThinButton21.IdleFillColor = System.Drawing.Color.White;
            this.bunifuThinButton21.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.Location = new System.Drawing.Point(92, 382);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(88, 34);
            this.bunifuThinButton21.TabIndex = 25;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton21.Click += new System.EventHandler(this.bunifuThinButton21_Click);
            // 
            // EkleButton
            // 
            this.EkleButton.ActiveBorderThickness = 1;
            this.EkleButton.ActiveCornerRadius = 20;
            this.EkleButton.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.EkleButton.ActiveForecolor = System.Drawing.Color.White;
            this.EkleButton.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.EkleButton.BackColor = System.Drawing.Color.DarkOrange;
            this.EkleButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("EkleButton.BackgroundImage")));
            this.EkleButton.ButtonText = "Ekle";
            this.EkleButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EkleButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EkleButton.ForeColor = System.Drawing.Color.Transparent;
            this.EkleButton.IdleBorderThickness = 1;
            this.EkleButton.IdleCornerRadius = 20;
            this.EkleButton.IdleFillColor = System.Drawing.Color.White;
            this.EkleButton.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.EkleButton.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.EkleButton.Location = new System.Drawing.Point(0, 382);
            this.EkleButton.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.EkleButton.Name = "EkleButton";
            this.EkleButton.Size = new System.Drawing.Size(80, 34);
            this.EkleButton.TabIndex = 23;
            this.EkleButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.EkleButton.Click += new System.EventHandler(this.EkleButton_Click);
            // 
            // ProductForm
            // 
            this.AccessibleName = "";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 495);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Name = "ProductForm";
            this.Text = "ÜrünForm";
            this.Load += new System.EventHandler(this.ÜrünForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productdv2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox CatCB;
        private Bunifu.Framework.UI.BunifuMaterialTextbox prodId;
        private Bunifu.Framework.UI.BunifuMaterialTextbox PurchasePriceTxt;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Detailstxt;
        private Bunifu.Framework.UI.BunifuMaterialTextbox QuenTxt;
        private Bunifu.Framework.UI.BunifuMaterialTextbox NameTxt;
        private Bunifu.Framework.UI.BunifuThinButton2 EkleButton;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton22;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton23;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private Bunifu.Framework.UI.BunifuMaterialTextbox PriceTxt;
        private System.Windows.Forms.Label label10;
        private Bunifu.Framework.UI.BunifuDatepicker Date1;
        private System.Windows.Forms.DataGridView productdv2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Supply;
        private System.Windows.Forms.Button button1;
    }
}