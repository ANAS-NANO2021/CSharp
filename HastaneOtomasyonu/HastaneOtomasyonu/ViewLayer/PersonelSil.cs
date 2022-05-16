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
    public partial class PersonelSil : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        DbLayer.DbCommands db = new DbLayer.DbCommands();
        int personid = -1;
        private void Form1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        public PersonelSil()
        {
            InitializeComponent();
            personeldgv.DataSource = db.tumpersoneller().Tables[0].DefaultView;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void personeldgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            adsoyad.Text = personeldgv.CurrentRow.Cells[1].Value.ToString() + " " + personeldgv.CurrentRow.Cells[2].Value.ToString();
            tc.Text = personeldgv.CurrentRow.Cells[3].Value.ToString();
            tel.Text= personeldgv.CurrentRow.Cells[4].Value.ToString();
            dtarihi.Text= personeldgv.CurrentRow.Cells[5].Value.ToString();
            personid = Int32.Parse( personeldgv.CurrentRow.Cells[0].Value.ToString());
        }

        private void bunifuTileButton5_Click(object sender, EventArgs e)
        {
            if(personid==-1)
            {
                MessageBox.Show("listeden personel seçmelisiniz");

            }
            else
            {
                db.personelsil(personid);
                MessageBox.Show("seçilen personel silindi");
                this.Hide();
                PersonelSil psil = new PersonelSil();
                psil.Show();
            }
        }
    }
}
