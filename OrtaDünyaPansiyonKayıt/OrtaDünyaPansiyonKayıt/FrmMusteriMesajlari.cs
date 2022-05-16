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
    public partial class FrmMusteriMesajlari : Form
    {
        public FrmMusteriMesajlari()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-FOJUIL9;Initial Catalog=OrtaDünyaPansiyon;Integrated Security=True");

        private void verilergoster()
        {

            listView1.Items.Clear();
            if (baglanti.State == ConnectionState.Closed) {
                baglanti.Open();
            }
                SqlCommand komut = new SqlCommand("select * from MusteriMesaj",baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["Mesajid"].ToString();
                ekle.SubItems.Add(oku["Adsoyad"].ToString());
                ekle.SubItems.Add(oku["Mesaj"].ToString());
                listView1.Items.Add(ekle);
            }
            baglanti.Close();
            


        }
        private void FrmMusteriMesajlari_Load(object sender, EventArgs e)
            {
            verilergoster();
            }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into MusteriMesaj(Adsoyad,Mesaj) values ('"+TxtAdSoyad.Text+"','"+RchMesaj.Text+"')",baglanti);
            komut.ExecuteNonQuery();
            verilergoster();
            
        }
        int id = 0;

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            TxtAdSoyad.Text = listView1.SelectedItems[0].SubItems[1].Text;
            RchMesaj.Text = listView1.SelectedItems[0].SubItems[2].Text;

        }
    }
    } 
