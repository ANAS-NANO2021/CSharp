using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperMarket_Projesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bunifuMetroTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if (UserTxt.Text == "Anas" && PassTxt.Text == 1234.ToString())
            {
                Catagory prc = new Catagory();
                prc.Show();
                this.Hide();
            }
            else
                MessageBox.Show("Yanlış şifre yada Adı girdiniz !", " Eror"); }

        private void gunaCircleButton2_Click(object sender, EventArgs e)
        {

        }
    }
    
}
