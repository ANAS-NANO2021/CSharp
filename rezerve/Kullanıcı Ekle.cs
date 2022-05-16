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
    public partial class Kullanıcı_Ekle : Form
    {
        string baglantiAdres = "Server= localhost; Database= Kullanici; User Id=sa; Password=as;";



        SqlConnection con;
        SqlDataReader oku;
        SqlCommand cmd;
        SqlDataReader dr;
        public Kullanıcı_Ekle()
        {
            InitializeComponent();
        }
        public void connect()
        {

            con = new SqlConnection(baglantiAdres);
            con.ConnectionString = baglantiAdres;
            con.Open();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string baglantiAdres = "Server= localhost; Database= Kullanici; User Id=sa; Password=as;";
            string sorgu = "insert into login (kullaniciAdi, parola ) values (@kullaniciAdi, @parola)";
            con = new SqlConnection(baglantiAdres);
            con.ConnectionString = baglantiAdres;
            con.Open();
            
            SqlCommand cmd = new SqlCommand(sorgu, con);
            cmd.Parameters.AddWithValue("@kullaniciAdi", textBox1.Text);
            cmd.Parameters.AddWithValue("@parola", textBox2.Text);

            cmd.ExecuteNonQuery();
            
            con.Close();
            MessageBox.Show("Tebrikler! Kullanıcı Eklendi.");
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
