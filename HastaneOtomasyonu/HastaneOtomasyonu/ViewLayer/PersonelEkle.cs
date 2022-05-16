using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastaneOtomasyonu.ViewLayer
{
    public partial class PersonelEkle : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        DbLayer.DbCommands db = new DbLayer.DbCommands();
        int bransid;
        private void Form1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        public PersonelEkle()
        {
            InitializeComponent();
            branslardgv.DataSource = db.bransgetir().Tables[0].DefaultView;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void arabox_OnValueChanged(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = branslardgv.DataSource;
            bs.Filter = string.Format("CONVERT(" + branslardgv.Columns[1].DataPropertyName + ", System.String) like '%" + arabox.Text.Replace("'", "''") + "%'");
            branslardgv.DataSource = bs;
        }

        private void branslardgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show("Brans Seçildi:" + branslardgv.CurrentRow.Cells[1].Value.ToString());
            bransid = Int32.Parse(branslardgv.CurrentRow.Cells[0].Value.ToString());
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
if(tc.Text!=""&&ad.Text!=""&&soyad.Text!=""&&tel.Text!=""&&kullaniciadi.Text!=""&&sifre.Text!=""&&eposta.Text!=""&&tc.Text.Length==11&&tel.Text.Length==11)
            {
                if (doctorradio.Checked == true)
                {
                    if(bransid==0)
                    {
                        MessageBox.Show("brans seçilmelidir!");
                    }
                    else
                    {
                        if (db.personelkayıt(ad.Text.ToString(), soyad.Text.ToString(),
                   tc.Text.ToString(), tel.Text.ToString(), dtarihi.Value, 1, 1, bransid, kullaniciadi.Text.ToString(), sifre.Text.ToString(), eposta.Text.ToString()))
                        {
                            MessageBox.Show("Doktor Kaydedildi.");
                        }
                    }
               
                }
                if (sekreterradio.Checked == true)
                {
                    if (db.personelkayıt(ad.Text.ToString(), soyad.Text.ToString(),
                     tc.Text.ToString(), tel.Text.ToString(), dtarihi.Value, 0, 0, 0, kullaniciadi.Text.ToString(), sifre.Text.ToString(), eposta.Text.ToString()))
                    {
                        MessageBox.Show("Sekreter Kaydedildi.");
                    }

                }
                if (yoneticiradio.Checked == true)
                {
                    if (db.personelkayıt(ad.Text.ToString(), soyad.Text.ToString(),
                     tc.Text.ToString(), tel.Text.ToString(), dtarihi.Value, 0, 2, 0, kullaniciadi.Text.ToString(), sifre.Text.ToString(), eposta.Text.ToString()))
                    {
                        MessageBox.Show("Yönetici Kaydedildi.");
                    }

                }
            }
            else
            {
                MessageBox.Show("alanlar doldurulmadı veya hatalı dolduruldu tc ve telefon 11 haneden oluşmalıdır ve boş alan bırakılmamalıdır");
            }
          
        }
    }
}
