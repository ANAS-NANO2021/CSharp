using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace rezerve
{
    public partial class rezervasyon : Form
    {
        static string isim;
        static string soyisim;
        static int numara;
        static string tarih;
        masalar masa = new masalar();
        string baglantiAdres = "Server= localhost; Database= Kullanici; User Id=sa; Password=as;";

        SqlConnection con;
        SqlDataReader oku;
        SqlCommand cmd;
        SqlDataReader dr;
        int id;

       
        public rezervasyon()
        {
            InitializeComponent();
        }

       



        public void connect() {



            con = new SqlConnection(baglantiAdres);
            con.ConnectionString = baglantiAdres;
            con.Open();
           

        }

       
        public void Verileri_Goster()
        {

            connect();
            listView1.Items.Clear();
          
            SqlCommand komut = new SqlCommand("Select * From rezervasyon", con);
            SqlDataReader oku = komut.ExecuteReader();

            while ( oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["isim"].ToString();
                ekle.SubItems.Add(oku["soyisim"].ToString());
                ekle.SubItems.Add(oku["telefon"].ToString());
                ekle.SubItems.Add(oku["tarih"].ToString());
                ekle.SubItems.Add(oku["id"].ToString());
                listView1.Items.Add(ekle);
            }

            con.Close();
        }
        private void button4_Click(object sender, EventArgs e)
        {   
            this.Hide();
          
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            isim = textBox1.Text;

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            soyisim = textBox2.Text;
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            numara = int.Parse(maskedTextBox1.Text.ToString());
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            tarih = dateTimePicker1.Text;
        }

        private void rezervasyon_Load(object sender, EventArgs e)
        {
            Verileri_Goster();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            connect();
            string insert_query = "insert into rezervasyon (isim,soyisim,telefon,tarih) values (@isim ,@soyisim ,@telefon ,@tarih)";
            SqlCommand cmd = new SqlCommand(insert_query, con);
            cmd.Parameters.AddWithValue("@isim", textBox1.Text);
            cmd.Parameters.AddWithValue("@soyisim", textBox2.Text);
            cmd.Parameters.AddWithValue("@telefon", maskedTextBox1.Text);
            cmd.Parameters.AddWithValue("@tarih", dateTimePicker1.Value.Date);
            cmd.ExecuteNonQuery();
            con.Close();
            Verileri_Goster();




            //SqlCommand komut = new SqlCommand("insert into rezervasyon (isim,soyisim,telefon,tarih) values ('" 
            //       + textBox1.Text.ToString() + "','"
            //       + textBox2.Text.ToString() + "','" 
            //       + maskedTextBox1.Text.ToString() + "','" 
            //       + dateTimePicker1.Value.Date + "')", con);
            //komut.ExecuteNonQuery();
            MessageBox.Show("rezervasyon eklendi");
            //con.Close();
            //Verileri_Goster();
            //textBox1.Clear();
            //textBox2.Clear();
            //maskedTextBox1.Clear();
            

          
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

           

            connect();
            string insert_query = "delete rezervasyon where id=@id";
            SqlCommand cmd = new SqlCommand(insert_query, con);
            cmd.Parameters.AddWithValue("@id", listView1.SelectedItems[0].SubItems[4].Text);
            cmd.ExecuteNonQuery();
            con.Close();
            Verileri_Goster();




            //connect();

            //SqlCommand komut = new SqlCommand("Delete from rezerve where telefon ='" + maskedTextBox1.Text.ToString() + "')", con);
            //komut.ExecuteNonQuery();
            //con.Close();

        }
        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
           
           
        }

        private void button3_Click(object sender, EventArgs e)
        {

            connect();
            string update_query = "update rezervasyon set isim=@isim, soyisim=@soyisim, telefon=@telefon, tarih=@tarih where id=@id";
            SqlCommand cmd = new SqlCommand(update_query, con);
            cmd.Parameters.AddWithValue("@isim", textBox1.Text);
            cmd.Parameters.AddWithValue("@soyisim", textBox2.Text);
            cmd.Parameters.AddWithValue("@telefon", maskedTextBox1.Text);
            cmd.Parameters.AddWithValue("@tarih", dateTimePicker1.Value.Date);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
            con.Close();
            Verileri_Goster();


            // galiba bitti


            //con.Open();
            //SqlCommand komut = new SqlCommand("Update rezerve set isim= '" + textBox1.Text.ToString()
            //    + "',soyisim='" + textBox2.Text.ToString() + "', numara =' " + maskedTextBox1.Text.ToString() +
            //    "', tarih = '" + tarih+"' where numara = "+numara+" " , con);
            //komut.ExecuteNonQuery();
            //con.Close();
            //Verileri_Goster();
        }

        private void listView1_ColumnClick(object sender, ColumnClickEventArgs e)
        {
           
        }

        private void listView1_MouseDoubleClick_1(object sender, MouseEventArgs e)
        {
            textBox1.Text = listView1.SelectedItems[0].SubItems[0].Text.ToString();
            textBox2.Text = listView1.SelectedItems[0].SubItems[1].Text.ToString();
            maskedTextBox1.Text = listView1.SelectedItems[0].SubItems[2].Text.ToString();
            dateTimePicker1.Text = listView1.SelectedItems[0].SubItems[3].Text.ToString();
            id = Convert.ToInt32(listView1.SelectedItems[0].SubItems[4].Text.ToString());
        }
    }
}
