using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pension_Registration_automation1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void TxtNum1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void Sumbutton1_Click(object sender, EventArgs e)
        {
            int Number1 = Convert.ToInt32(TxtNum1.Text);
            int Number2 = Convert.ToInt32(TxtNum2.Text);


            double Result = Number1 + Number2;
            LblResult.Text = Result.ToString();
        }

        private void TxtNum2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
