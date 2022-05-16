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
    public partial class DoktorPanel : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        DbLayer.DbCommands db = new DbLayer.DbCommands();
        DbLayer.DbCommands db2 = new DbLayer.DbCommands();


        private void Form1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        public DoktorPanel()
        {
            InitializeComponent();

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DoktorPanel_Load(object sender, EventArgs e)
        {
            tarihsecici.Value = DateTime.Now.Date;
            muayeneolanlardgv.DataSource = db.getmuayeneolanastalarım(Login.loginuserid, tarihsecici.Value).Tables[0].DefaultView;
            muayeneolmayandgv.DataSource = db2.getmuayeneolmayanhastalarım(Login.loginuserid, tarihsecici.Value).Tables[0].DefaultView;
            muayeneolmayandgv.Columns["RANDEVU_ID"].Visible = false;
            muayeneolanlardgv.Columns["RANDEVU_ID"].Visible = false;
        }

        private void tarihsecici_onValueChanged(object sender, EventArgs e)
        {

        }

        private void tarihegorelistelebtn_Click(object sender, EventArgs e)
        {
            muayeneolanlardgv.DataSource = db.getmuayeneolanastalarım(Login.loginuserid, tarihsecici.Value).Tables[0].DefaultView;
            muayeneolmayandgv.DataSource = db2.getmuayeneolmayanhastalarım(Login.loginuserid, tarihsecici.Value).Tables[0].DefaultView;
            muayeneolmayandgv.Columns["RANDEVU_ID"].Visible = false;
        }

        private void muayeneolmayandgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
          
                AnamezPanel mp = new AnamezPanel(Int32.Parse(muayeneolmayandgv.CurrentRow.Cells[5].Value.ToString()));
                mp.Show();
            
        }
        private void muayeneolanlardgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            AnamezPanel mp = new AnamezPanel(Int32.Parse(muayeneolanlardgv.CurrentRow.Cells[5].Value.ToString()));
            mp.Show();

        }
    }
}
