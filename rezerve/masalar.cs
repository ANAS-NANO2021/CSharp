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
    public partial class masalar : Form
    {
       
        static public int masa_numarasi;
        
        public masalar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            menu form2 = new menu();
            form2.Show();
            masa_numarasi = 1;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            menu form2 = new menu();
            form2.Show();
            masa_numarasi = 3;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            menu form2 = new menu();
            form2.Show();
            masa_numarasi = 6;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            menu form2 = new menu();
            form2.Show();
            masa_numarasi = 4;

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            
            button1.Enabled = true;
            button1.BackColor = Color.Green;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button1.BackColor = Color.DarkRed;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button1.BackColor = Color.Yellow;
            
            
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            
            button2.Enabled = true;
            button2.BackColor = Color.Green;
        }

        private void radioButton14_CheckedChanged(object sender, EventArgs e)
        {
            button2.Enabled = false;
            button2.BackColor = Color.DarkRed;
        }

        private void radioButton22_CheckedChanged(object sender, EventArgs e)
        {
            
            button2.Enabled = false;
            button2.BackColor = Color.Yellow;
           
            
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            
            button3.Enabled = true;
            button3.BackColor = Color.Green;
        }

        private void radioButton17_CheckedChanged(object sender, EventArgs e)
        {
            button3.Enabled = false;
            button3.BackColor = Color.DarkRed;
        }

        private void radioButton25_CheckedChanged(object sender, EventArgs e)
        {
            
            button3.Enabled = false;
            button3.BackColor = Color.Yellow;
            
           

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            
            button4.Enabled = true;
            button4.BackColor = Color.Green;
        }

        private void radioButton12_CheckedChanged(object sender, EventArgs e)
        {
            button4.Enabled = false;
            button4.BackColor = Color.DarkRed;
        }

        private void radioButton20_CheckedChanged(object sender, EventArgs e)
        {
           
            button4.Enabled = false;
            button4.BackColor = Color.Yellow;
            
            
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
           
            button9.Enabled = true;
            button9.BackColor = Color.Green;

        }

        private void radioButton15_CheckedChanged(object sender, EventArgs e)
        {
            button9.Enabled = false;
            button9.BackColor = Color.DarkRed;

        }

        private void radioButton23_CheckedChanged(object sender, EventArgs e)
        {
            
            button9.Enabled = false;
            button9.BackColor = Color.Yellow;
           
           
        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            
            button5.Enabled = true;
            button5.BackColor = Color.Green;
        }

        private void radioButton18_CheckedChanged(object sender, EventArgs e)
        {
            button5.Enabled = false;
            button5.BackColor = Color.DarkRed;
        }

        private void radioButton26_CheckedChanged(object sender, EventArgs e)
        {
            
            button5.Enabled = false;
            button5.BackColor = Color.Yellow;
         
           
        }

        private void radioButton11_CheckedChanged(object sender, EventArgs e)
        {
            
            button6.Enabled = true;
            button6.BackColor = Color.Green;
        }

        private void radioButton19_CheckedChanged(object sender, EventArgs e)
        {
            button6.Enabled = false;
            button6.BackColor = Color.DarkRed;
        }

        private void radioButton27_CheckedChanged(object sender, EventArgs e)
        {
            
            button6.Enabled = false;
            button6.BackColor = Color.Yellow;
            
            
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            
            button7.Enabled = true;
            button7.BackColor = Color.Green; ;
        }

        private void radioButton13_CheckedChanged(object sender, EventArgs e)
        {
            button7.Enabled = false;
            button7.BackColor = Color.DarkRed;
        }

        private void radioButton21_CheckedChanged(object sender, EventArgs e)
        {
           
            button7.Enabled = false;
            button7.BackColor = Color.Yellow;
          
           
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
           
            button8.Enabled = true;
            button8.BackColor = Color.Green;
        }

        private void radioButton16_CheckedChanged(object sender, EventArgs e)
        {
            button8.Enabled = false;
            button8.BackColor = Color.DarkRed;
        }

        private void radioButton24_CheckedChanged(object sender, EventArgs e)
        {
            
            button8.Enabled = false;
            button8.BackColor = Color.Yellow;
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            menu form2 = new menu();
            form2.Show();
            masa_numarasi = 2;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            menu form2 = new menu();
            form2.Show();
            masa_numarasi = 5;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            menu form2 = new menu();
            form2.Show();
            masa_numarasi = 7;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            menu form2 = new menu();
            form2.Show();
            masa_numarasi = 8;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            menu form2 = new menu();
            form2.Show();
            masa_numarasi = 9;
        }

        public int Masaa_Numarasi()
        {
            return masa_numarasi;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            rezervasyon rezerve = new rezervasyon();
            rezerve.Show();

        }
    }
}
