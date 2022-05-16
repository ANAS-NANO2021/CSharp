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
    public partial class HESAPLAMA : Form
    {
        public HESAPLAMA()
        {
            InitializeComponent();
        }
        masalar masa = new masalar();
        menu menuu = new menu();
        static int cay;
        static int kahve;
        static int pizza;
        static int milk;
        static int wuffle;
        static int pasta;
        static int cay_fiyat;
        static int kahve_fiyat;
        static int pizza_fiyat;
        static int milk_fiyat;
        static int wuffle_fiyat;
        static int pasta_fiyat;
        private void label2_Click(object sender, EventArgs e)
        {

        }

       

        private void label6_Click(object sender, EventArgs e)
        {
            

           

        }

        private void button2_Click(object sender, EventArgs e)
        {
            menu frm = new menu();
            frm.Visible = true;
            this.Visible = false;
        }

        private void HESAPLAMA_Load(object sender, EventArgs e)
        {
            label11.Text = " MASA " + masa.Masaa_Numarasi();
            pasta = menuu.Pasta();
            textBox12.Text = "" + pasta + " ADET = " + pasta * pasta_fiyat + "TL ";
            cay = menuu.Cay();
            textBox6.Text = " " + cay + " ADET = " + cay * cay_fiyat + "TL ";
            kahve = menuu.Kahve();
            textBox7.Text = "" + kahve + " ADET = " + kahve * kahve_fiyat + "TL ";
            pizza = menuu.Pizza();
            textBox8.Text = "" + pizza + " ADET = " + pizza * pizza_fiyat + "TL ";
            wuffle = menuu.Waffle();
            textBox9.Text = "" + wuffle + " ADET = " + wuffle * wuffle_fiyat + "TL ";
            milk = menuu.Milkshake();
            textBox10.Text = "" + milk + " ADET = " + milk * milk_fiyat + "TL ";
            int toplam = milk * milk_fiyat + cay * cay_fiyat + wuffle * wuffle_fiyat + pizza * pizza_fiyat +
                kahve * kahve_fiyat+pasta*pasta_fiyat;
            textBox11.Text = " " + toplam + " TL";

        }

        private void label7_Click(object sender, EventArgs e)
        {
           

        }

       
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            cay_fiyat = Convert.ToInt32(textBox1.Text);
            cay = menuu.Cay();
            textBox6.Text = " " + cay + " ADET = " + cay * cay_fiyat + "TL ";
            int toplam = milk * milk_fiyat + cay * cay_fiyat + wuffle * wuffle_fiyat + pizza * pizza_fiyat +
                kahve * kahve_fiyat + pasta * pasta_fiyat;
            textBox11.Text = " " + toplam + " TL";
        }

        private void label11_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

            
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            

           
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            kahve_fiyat = Convert.ToInt32(textBox2.Text);
            kahve = menuu.Kahve();
            textBox7.Text = "" + kahve + " ADET = " + kahve * kahve_fiyat + "TL ";
            int toplam = milk * milk_fiyat + cay * cay_fiyat + wuffle * wuffle_fiyat + pizza * pizza_fiyat +
                kahve * kahve_fiyat + pasta * pasta_fiyat;
            textBox11.Text = " " + toplam + " TL";
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            pizza_fiyat = Convert.ToInt32(textBox3.Text);
            pizza = menuu.Pizza();
            textBox8.Text = "" + pizza + " ADET = " + pizza * pizza_fiyat + "TL ";
            int toplam = milk * milk_fiyat + cay * cay_fiyat + wuffle * wuffle_fiyat + pizza * pizza_fiyat +
                kahve * kahve_fiyat + pasta * pasta_fiyat;
            textBox11.Text = " " + toplam + " TL";
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            wuffle_fiyat = Convert.ToInt32(textBox4.Text);
            wuffle = menuu.Waffle();
            textBox9.Text = "" + wuffle + " ADET = " + wuffle * wuffle_fiyat + "TL ";
            int toplam = milk * milk_fiyat + cay * cay_fiyat + wuffle * wuffle_fiyat + pizza * pizza_fiyat +
                kahve * kahve_fiyat + pasta * pasta_fiyat;
            textBox11.Text = " " + toplam + " TL";
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            milk_fiyat = Convert.ToInt32(textBox5.Text);
            milk = menuu.Milkshake();
            textBox10.Text = "" + milk + " ADET = " + milk * milk_fiyat + "TL ";
            int toplam = milk * milk_fiyat + cay * cay_fiyat + wuffle * wuffle_fiyat + pizza * pizza_fiyat +
                kahve * kahve_fiyat + pasta * pasta_fiyat;
            textBox11.Text = " " + toplam + " TL";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ÖDEME TAMAMLANDI");
            textBox6.Clear();
            textBox5.Clear();
            textBox4.Clear();
            textBox3.Clear();
            textBox2.Clear();
            textBox1.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
            textBox10.Clear();
            textBox11.Clear();
            textBox12.Clear();
            textBox13.Clear();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("FİŞ YAZDIRILDI");
        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {
            pasta_fiyat = Convert.ToInt32(textBox13.Text);
            pasta = menuu.Pasta();
            textBox12.Text = "" + pasta + " ADET = " + pasta * pasta_fiyat + "TL ";
            int toplam = milk * milk_fiyat + cay * cay_fiyat + wuffle * wuffle_fiyat + pizza * pizza_fiyat +
                kahve * kahve_fiyat + pasta * pasta_fiyat;
            textBox11.Text = " " + toplam + " TL";
        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
