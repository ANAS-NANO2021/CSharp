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
    public partial class FrmSifreGüncelleme : Form
    {
        public FrmSifreGüncelleme()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-FOJUIL9;Initial Catalog=OrtaDünyaPansiyon;Integrated Security=True");

        private void BtnGirisYap_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update admingiris set KullaniciAdi='" + TxtKullaniciAdi1.Text + "',Sifre='" + TxtParola2.Text + "'", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();

            
        }
    }
}
