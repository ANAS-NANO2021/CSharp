using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace OrtaDünyaPansiyonKayıt
{
    public partial class FrmGelirGider : Form
    {
        public FrmGelirGider()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-FOJUIL9;Initial Catalog=OrtaDünyaPansiyon;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {

            int personel;
            personel = Convert.ToInt16(textBox1.Text);
            LblPersonelMaas.Text = (personel * 3000).ToString();

            int sonuc;
            sonuc = Convert.ToInt32(LblKasaToplam.Text) - (Convert.ToInt32(LblPersonelMaas.Text) + Convert.ToInt32(LblAlinanUrunFatura1.Text) + Convert.ToInt32(LblAlinanUrunFatura2.Text) + Convert.ToInt32(LblAlinanUrunFatura3.Text) + Convert.ToInt32(LblFaturalar1.Text) + Convert.ToInt32(LblFaturalar2.Text) + Convert.ToInt32(LblFaturalar3.Text));
            LblSonuc.Text = sonuc.ToString();

        }

        private void FrmGelirGider_Load(object sender, EventArgs e)
        {
            //kasadaki toplam tutar
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select sum(Ucret) as toplam from MusteriEkle", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                LblKasaToplam.Text = oku["toplam"].ToString();
            }
            baglanti.Close();
            //Gidalar

            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("Select sum(Gida) as toplam2 from Stoklar", baglanti);
            SqlDataReader oku2 = komut2.ExecuteReader();
            while (oku2.Read())
            {
                LblAlinanUrunFatura1.Text = oku2["toplam2"].ToString();
            }
            baglanti.Close();
            //içecekler
            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("Select sum(İcecek) as toplam3 from Stoklar", baglanti);
            SqlDataReader oku3 = komut3.ExecuteReader();
            while (oku3.Read())
            {
                LblAlinanUrunFatura2.Text = oku3["toplam3"].ToString();
            }
            baglanti.Close();
            //cerezler
            baglanti.Open();
            SqlCommand komut4 = new SqlCommand("Select sum(Cerezler) as toplam4 from Stoklar", baglanti);
            SqlDataReader oku4 = komut4.ExecuteReader();
            while (oku4.Read())
            {
                LblAlinanUrunFatura3.Text = oku4["toplam4"].ToString();
            }
            baglanti.Close();

            //int personel;
            // personel = Convert.ToInt16(textBox1.Text);
            //LblPersonelMaas.Text = (personel * 1500).ToString();

            //faturalar
            baglanti.Open();
            SqlCommand komut5 = new SqlCommand("Select sum(Elektrik) as toplam5 from Faturalar", baglanti);
            SqlDataReader oku5 = komut5.ExecuteReader();
            while (oku5.Read())
            {
                LblFaturalar1.Text = oku5["toplam5"].ToString();
            }
            baglanti.Close();
            //Su
            baglanti.Open();
            SqlCommand komut6 = new SqlCommand("Select sum(Su) as toplam6 from Faturalar", baglanti);
            SqlDataReader oku6 = komut6.ExecuteReader();
            while (oku6.Read())
            {
                LblFaturalar2.Text = oku6["toplam6"].ToString();
            }
            baglanti.Close();
            //internet
            baglanti.Open();
            SqlCommand komut7 = new SqlCommand("Select sum(Internet) as toplam7 from Faturalar", baglanti);
            SqlDataReader oku7 = komut7.ExecuteReader();
            while (oku7.Read())
            {
                LblFaturalar3.Text = oku7["toplam7"].ToString();
            }
            baglanti.Close();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void LblAlınanÜrünFatura1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
