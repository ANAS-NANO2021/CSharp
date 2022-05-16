
namespace Pension_Registration_automation1
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.LblResult = new System.Windows.Forms.Label();
            this.Resultlbl1Txt = new System.Windows.Forms.Label();
            this.TxtNum2 = new System.Windows.Forms.TextBox();
            this.TxtNum1 = new System.Windows.Forms.TextBox();
            this.Sumbutton1 = new System.Windows.Forms.Button();
            this.ClacLabl = new System.Windows.Forms.Label();
            this.LblNum2 = new System.Windows.Forms.Label();
            this.LblNum1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.LblResult);
            this.panel1.Controls.Add(this.Resultlbl1Txt);
            this.panel1.Controls.Add(this.TxtNum2);
            this.panel1.Controls.Add(this.TxtNum1);
            this.panel1.Controls.Add(this.Sumbutton1);
            this.panel1.Controls.Add(this.ClacLabl);
            this.panel1.Controls.Add(this.LblNum2);
            this.panel1.Controls.Add(this.LblNum1);
            this.panel1.Location = new System.Drawing.Point(41, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(575, 272);
            this.panel1.TabIndex = 0;
            // 
            // LblResult
            // 
            this.LblResult.AccessibleName = "";
            this.LblResult.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblResult.Location = new System.Drawing.Point(489, 199);
            this.LblResult.Name = "LblResult";
            this.LblResult.Size = new System.Drawing.Size(50, 33);
            this.LblResult.TabIndex = 6;
            this.LblResult.Text = "0";
            this.LblResult.Click += new System.EventHandler(this.label3_Click_1);
            // 
            // Resultlbl1Txt
            // 
            this.Resultlbl1Txt.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Resultlbl1Txt.Location = new System.Drawing.Point(413, 202);
            this.Resultlbl1Txt.Name = "Resultlbl1Txt";
            this.Resultlbl1Txt.Size = new System.Drawing.Size(70, 70);
            this.Resultlbl1Txt.TabIndex = 5;
            this.Resultlbl1Txt.Text = "Result";
            this.Resultlbl1Txt.Click += new System.EventHandler(this.label3_Click);
            // 
            // TxtNum2
            // 
            this.TxtNum2.AccessibleName = "TxtNum2";
            this.TxtNum2.Location = new System.Drawing.Point(128, 171);
            this.TxtNum2.Name = "TxtNum2";
            this.TxtNum2.Size = new System.Drawing.Size(266, 20);
            this.TxtNum2.TabIndex = 4;
            this.TxtNum2.TextChanged += new System.EventHandler(this.TxtNum2_TextChanged);
            // 
            // TxtNum1
            // 
            this.TxtNum1.AccessibleName = "TxtNum1";
            this.TxtNum1.Location = new System.Drawing.Point(128, 112);
            this.TxtNum1.Name = "TxtNum1";
            this.TxtNum1.Size = new System.Drawing.Size(266, 20);
            this.TxtNum1.TabIndex = 3;
            // 
            // Sumbutton1
            // 
            this.Sumbutton1.Location = new System.Drawing.Point(222, 205);
            this.Sumbutton1.Name = "Sumbutton1";
            this.Sumbutton1.Size = new System.Drawing.Size(75, 23);
            this.Sumbutton1.TabIndex = 2;
            this.Sumbutton1.Text = "+";
            this.Sumbutton1.UseVisualStyleBackColor = true;
            this.Sumbutton1.Click += new System.EventHandler(this.Sumbutton1_Click);
            // 
            // ClacLabl
            // 
            this.ClacLabl.Font = new System.Drawing.Font("Bookman Old Style", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClacLabl.Location = new System.Drawing.Point(197, 0);
            this.ClacLabl.Name = "ClacLabl";
            this.ClacLabl.Size = new System.Drawing.Size(224, 110);
            this.ClacLabl.TabIndex = 1;
            this.ClacLabl.Text = "                   Calculator";
            this.ClacLabl.Click += new System.EventHandler(this.label2_Click);
            // 
            // LblNum2
            // 
            this.LblNum2.AccessibleName = "Lblname";
            this.LblNum2.AutoSize = true;
            this.LblNum2.Location = new System.Drawing.Point(28, 174);
            this.LblNum2.Name = "LblNum2";
            this.LblNum2.Size = new System.Drawing.Size(50, 13);
            this.LblNum2.TabIndex = 1;
            this.LblNum2.Text = "Number2";
            // 
            // LblNum1
            // 
            this.LblNum1.AccessibleName = "Num1";
            this.LblNum1.AutoSize = true;
            this.LblNum1.Location = new System.Drawing.Point(28, 112);
            this.LblNum1.Name = "LblNum1";
            this.LblNum1.Size = new System.Drawing.Size(50, 13);
            this.LblNum1.TabIndex = 0;
            this.LblNum1.Text = "Number1";
            this.LblNum1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 441);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LblNum1;
        private System.Windows.Forms.Label ClacLabl;
        private System.Windows.Forms.Label LblNum2;
        private System.Windows.Forms.Label Resultlbl1Txt;
        private System.Windows.Forms.TextBox TxtNum2;
        private System.Windows.Forms.TextBox TxtNum1;
        private System.Windows.Forms.Button Sumbutton1;
        private System.Windows.Forms.Label LblResult;
    }
}

