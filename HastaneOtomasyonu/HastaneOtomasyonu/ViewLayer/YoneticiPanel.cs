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
    public partial class YoneticiPanel : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        DbLayer.DbCommands db = new DbLayer.DbCommands();
        private void Form1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        public YoneticiPanel()
        {
            InitializeComponent();
            totalhasta.Text = db.countHasta().ToString();
            totalpersonel.Text = db.countPersonel().ToString();
            totalrandevu.Text = db.countRandevu().ToString();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void personelekle_Click(object sender, EventArgs e)
        {
            ViewLayer.PersonelEkle personelEkle = new ViewLayer.PersonelEkle();
            personelEkle.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            totalhasta.Text = db.countHasta().ToString();
            totalpersonel.Text = db.countPersonel().ToString();
            totalrandevu.Text = db.countRandevu().ToString();
        }

        private void bunifuTileButton4_Click(object sender, EventArgs e)
        {
            HastaListesi hastaListesi = new HastaListesi();
            hastaListesi.Show();
        }

        private void bunifuTileButton5_Click(object sender, EventArgs e)
        {
            PersonelSil personelSil = new PersonelSil();
            personelSil.Show();
        }
    }
}
