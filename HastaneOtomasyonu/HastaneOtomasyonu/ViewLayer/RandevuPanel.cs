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
    public partial class RandevuPanel : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        DbLayer.DbCommands db = new DbLayer.DbCommands();
        DbLayer.DbCommands db2 = new DbLayer.DbCommands();

        //randevu degiskenleri
        int hastaid;
        int doktorid=-1;
        int bransid=-1;
        string date=null;

        //end

        private void Form1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        public RandevuPanel()
        {
            InitializeComponent();
            poliklinikler.DataSource = db.polikliniklistesi().Tables[0].DefaultView;
            poliklinikler.Columns[0].Visible = false;
            randevutarih.Value = DateTime.Now;


        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void kayıtsorgula_Click(object sender, EventArgs e)
        {
            if(tcbox.Text.Length==11)
            {
                if (db.hastabilgigetir(tcbox.Text, "ADI") != null)
                {
                    MessageBox.Show("Hasta Sistemde Kayıtlıdır Randevu bölümünden Devam Ediniz");
                    adbox.Text = db.hastabilgigetir(tcbox.Text, "ADI");
                    soyadbox.Text = db.hastabilgigetir(tcbox.Text, "SOYADI");
                    nobox.Text = db.hastabilgigetir(tcbox.Text, "TEL");
                    dogumtarihibox.Value = DateTime.Parse(db.hastabilgigetir(tcbox.Text, "DOGUM_TARIHI"));
                    dogumyeribox.Text = db.hastabilgigetir(tcbox.Text, "DOGUM_YERI");
                    cinsiyetbox.Text = db.hastabilgigetir(tcbox.Text, "CINSIYET");
                    tcbox.Enabled = false;
                    randevutarih.Enabled = true;
                    poliklinikler.Enabled = true;
                    hastakaydet.Enabled = false;
                    hastaid= Int32.Parse(db.hastabilgigetir(tcbox.Text, "HASTA_ID"));

                }
                else
                {
                    MessageBox.Show("Hasta Sistemde Kayıtlı Değildir Kaydı Tamamladıktan Sonra Randevu Oluşturabilirsiniz");
                    tcbox.Enabled = false;
                    hastakaydet.Enabled = true;

                }
            }
            else
            {
                MessageBox.Show("Tc No Hatalı");
            }
        
    

        }

        private void poliklinikler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            doktordgv.DataSource = db2.poliklinigegoredoktorlistesi(Int32.Parse(poliklinikler.CurrentRow.Cells[0].Value.ToString())).Tables[0].DefaultView;
            polikliniktxtbox.Text = poliklinikler.CurrentRow.Cells[1].Value.ToString();
            doktordgv.Columns[0].Visible = false;
            doktordgv.Enabled = true;
            bransid = Int32.Parse(poliklinikler.CurrentRow.Cells[0].Value.ToString());
        }

        private void doktordgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            doktortxtbox.Text = doktordgv.CurrentRow.Cells[1].Value.ToString()+" "+ doktordgv.CurrentRow.Cells[2].Value.ToString();
            randevukaydet.Enabled = true;
            doktorid = Int32.Parse(doktordgv.CurrentRow.Cells[0].Value.ToString());
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            RandevuPanel rp = new RandevuPanel();
            rp.Show();
        }

        private void hastakaydet_Click(object sender, EventArgs e)
        {
            string hastaad = adbox.Text; ;
            string hastasoyad=soyadbox.Text;
            string cinsiyet = cinsiyetbox.Text;
            string hastatc=tcbox.Text;
            string hastatel=nobox.Text;
            string dogumyeri=dogumyeribox.Text;
            string dogumtarihi= dogumtarihibox.Value.Date.ToString("yyyy-MM-dd");
            if(hastaad.Length>0&&hastasoyad.Length>0&&cinsiyet.Length>0&&hastatel.Length>0&&dogumtarihi.Length>0&&dogumyeri.Length>0)
            {
                if(hastatc.Length==11&&hastatel.Length==11)
                {
                    if (db.hastakayıt(hastaad, hastasoyad, hastatc, cinsiyet, dogumtarihi, hastatel, dogumyeri))
                    {
                        MessageBox.Show("Hasta Kaydedildi Randevu Bölümünden devam ediniz");
                        poliklinikler.Enabled = true;
                        randevutarih.Enabled = true;
                        hastakaydet.Enabled = false;
                        hastaid = Int32.Parse(db.hastabilgigetir(tcbox.Text, "HASTA_ID"));
                    }

                }
                else
                {
                    MessageBox.Show("Tc Kimlik No Ve Telefon numarası 11 haneden oluşmalıdır");
                }
            }
            else
            {
                MessageBox.Show("Boş Alan Bırakmayınız!");
            }
           

        }

        private void randevukaydet_Click(object sender, EventArgs e)
        {
            date = randevutarih.Value.Date.ToString("yyyy-MM-dd");
            if(bransid==-1||doktorid==-1)
            {
                MessageBox.Show("Doktor veya branş seçmediniz");
            }
            else
            {
                if(db.randevukayıt(doktorid.ToString(),hastaid.ToString(),bransid.ToString(),date))
                {
                    MessageBox.Show("Randevu Kayddedildi");
                    this.Hide();
                    RandevuPanel rp = new RandevuPanel();
                    rp.Show();
                }
                else
                {
                    MessageBox.Show("Hata");
                }
            }



        }
    }
    }

