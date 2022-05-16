using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rezerve
{
    public partial class gi_r : Form
    {

        masalar masa = new masalar();
        string baglantiAdres = "Server= localhost; Database= Kullanici; User Id=sa; Password=as;";
        


    SqlConnection con;
        SqlDataReader oku;
        SqlCommand cmd;
        SqlDataReader dr;


        public gi_r()
        {
            InitializeComponent();
        }

        public void connect()
        {

            con = new SqlConnection(baglantiAdres);
            con.ConnectionString = baglantiAdres;
            con.Open();
            

        }

        public void kullanici_dogrula()
        {
            string sorgu = "SELECT * FROM login where kullaniciAdi=@kullaniciAdi AND parola=@parola";
            connect();
            cmd = new SqlCommand(sorgu, con);
            cmd.Parameters.AddWithValue("@kullaniciAdi", textBox1.Text);
            cmd.Parameters.AddWithValue("@parola", maskedTextBox1.Text);
            
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                MessageBox.Show("Tebrikler! Başarılı bir şekilde giriş yaptınız.");
                masalar masalar = new masalar();
                masalar.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı adını ve şifrenizi kontrol ediniz.");
            }
            con.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            kullanici_dogrula();

        }

        private void gi_r_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Kullanıcı_Ekle kullan = new Kullanıcı_Ekle();
            kullan.Show();
            this.Hide();
        }
    }
}
