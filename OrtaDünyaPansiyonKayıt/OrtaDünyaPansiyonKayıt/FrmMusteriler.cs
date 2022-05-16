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
    public partial class FrmMusteriler : Form
    {
        public FrmMusteriler()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-FOJUIL9;Initial Catalog=OrtaDünyaPansiyon;Integrated Security=True");

        private void verilergoster()
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from MusteriEkle", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["Musteriid"].ToString();
                ekle.SubItems.Add(oku["Adi"].ToString());
                ekle.SubItems.Add(oku["Soyadi"].ToString());
                ekle.SubItems.Add(oku["Cinsiyet"].ToString());
                ekle.SubItems.Add(oku["Telefon"].ToString());
                ekle.SubItems.Add(oku["Ucret"].ToString());
                ekle.SubItems.Add(oku["Mail"].ToString());
                ekle.SubItems.Add(oku["KimlikNo"].ToString());
                ekle.SubItems.Add(oku["OdaNumarasi"].ToString());
                ekle.SubItems.Add(oku["GirisTarihi"].ToString());
                ekle.SubItems.Add(oku["CikisTarihi"].ToString());

                listView1.Items.Add(ekle);

            }
            baglanti.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            verilergoster();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
        int id = 0;
        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            TxtAdi.Text = listView1.SelectedItems[0].SubItems[1].Text;
            TxtSoyadi.Text = listView1.SelectedItems[0].SubItems[2].Text;
            CmbCinsiyet.Text = listView1.SelectedItems[0].SubItems[3].Text;
           MstTelefon.Text = listView1.SelectedItems[0].SubItems[4].Text;
            TxtUcret.Text = listView1.SelectedItems[0].SubItems[5].Text;
            TxtMail.Text = listView1.SelectedItems[0].SubItems[6].Text;
            TxtKimlikNo.Text = listView1.SelectedItems[0].SubItems[7].Text;
            TxtOdaNumarasi.Text = listView1.SelectedItems[0].SubItems[8].Text;
            DtpGirisTarihi.Text = listView1.SelectedItems[0].SubItems[9].Text;
            DtpCikisTarihi.Text = listView1.SelectedItems[0].SubItems[10].Text;

        }

        private void TxtAdi_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from MusteriEkle where Adi like'%" + TxtİsimAra.Text + "%'", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["Musteriid"].ToString();
                ekle.SubItems.Add(oku["Adi"].ToString());
                ekle.SubItems.Add(oku["Soyadi"].ToString());
                ekle.SubItems.Add(oku["Cinsiyet"].ToString());
                ekle.SubItems.Add(oku["Telefon"].ToString());
                ekle.SubItems.Add(oku["Ucret"].ToString());
                ekle.SubItems.Add(oku["Mail"].ToString());
                ekle.SubItems.Add(oku["KimlikNo"].ToString());
                ekle.SubItems.Add(oku["OdaNumarasi"].ToString());
                ekle.SubItems.Add(oku["GirisTarihi"].ToString());
                ekle.SubItems.Add(oku["CikisTarihi"].ToString());

                listView1.Items.Add(ekle);

            }
            baglanti.Close();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            if (TxtOdaNumarasi.Text == "101")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Oda101", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verilergoster();
            }
            if (TxtOdaNumarasi.Text == "102")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Oda102", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verilergoster();
            }
            if (TxtOdaNumarasi.Text == "103")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Oda103", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verilergoster();
            }
            if (TxtOdaNumarasi.Text == "104")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Oda104", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verilergoster();
            }
            if (TxtOdaNumarasi.Text == "105")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Oda105", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verilergoster();
            }
            if (TxtOdaNumarasi.Text == "106")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Oda106", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verilergoster();
            }
            if (TxtOdaNumarasi.Text == "107")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Oda107", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verilergoster();
            }
            if (TxtOdaNumarasi.Text == "108")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Oda108", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verilergoster();
            }
            if (TxtOdaNumarasi.Text == "109")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Oda109", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verilergoster();
            }

        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            TxtAdi.Clear();
            TxtSoyadi.Clear();
            CmbCinsiyet.Text="";
            MstTelefon.Clear();
            TxtUcret.Clear();
            TxtMail.Text = "";
            TxtKimlikNo.Clear();
            TxtOdaNumarasi.Clear();
            DtpGirisTarihi.Text = "";
            DtpCikisTarihi.Text = "";

        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update MusteriEkle set Adi='" +TxtAdi.Text + "',Soyadi='"+TxtSoyadi.Text + "',Cinsiyet='" + CmbCinsiyet.Text + "',Telefon='" + MstTelefon.Text + "',Ucret='" + TxtUcret.Text + "',Mail='" + TxtMail.Text + "',KimlikNo='" + TxtKimlikNo.Text + "',OdaNumarasi='" + TxtOdaNumarasi.Text + "',GirisTarihi='" + DtpGirisTarihi.Value.ToString("yyyy-MM-dd") + "',CikisTarihi='" + DtpCikisTarihi.Value.ToString("yyyy-MM-dd") +  "'where Musteriid=" + id + "", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            verilergoster();
        }

        private void FrmMusteriler_Load(object sender, EventArgs e)
        {

        }
    }
}
//Data Source=DESKTOP-FOJUIL9;Initial Catalog=OrtaDünyaPansiyon;Integrated Security=True
// SqlCommand komut = new SqlCommand("delete from MusteriEkle where Musteriid=(" + id + ")",baglanti);