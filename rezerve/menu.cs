using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rezerve
{
    public partial class menu : Form
    {
       static public int pizza=0;
       static  public int kahve = 0;
       static  public int cay = 0;
       static  public int pasta = 0;
       static  public int milkshake = 0;
       static  public int wuffle = 0;
         
        public menu()
        {
            InitializeComponent();
        }
        
        private void button3_Click(object sender, EventArgs e)
        {
            pizza++;
            label7.Text = pizza +"";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(pizza>0)
            pizza--;
            label7.Text = pizza +"";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            kahve++;
            label8.Text = kahve + "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(kahve>0)
            kahve--;
            label8.Text = kahve + "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            cay++;
            label9.Text = cay + "";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if(cay>0)
            cay--;
            label9.Text = cay + "" ;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            pasta++;
            label10.Text = pasta + "";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if(pasta>0)
            pasta--;
            label10.Text = pasta + "";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            wuffle++;
            label11.Text = wuffle + "";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if(wuffle>0)
            wuffle--;
            label11.Text = wuffle + "";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            milkshake++;
            label12.Text = milkshake + "";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if(milkshake>0)
            milkshake--;
            label12.Text = milkshake + "";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            HESAPLAMA hesaplamaformu = new HESAPLAMA();
            hesaplamaformu.Visible = true;
            this.Visible = false;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            masalar FRM = new masalar();
            
            this.Visible = false;
        }

        public int Pizza()
        {
            return pizza;
        }

        public int Cay()
        {
            return cay;
        }

        public int Kahve()
        {
            return kahve;
        }
        public int Milkshake()
        {
            return milkshake;
        }

        public int Waffle()
        {
            return wuffle;
        }

        public int Pasta()
        {
            return pasta;
        }
        private void menu_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
