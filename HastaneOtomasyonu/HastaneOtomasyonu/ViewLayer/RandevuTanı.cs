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
    public partial class RandevuTanı : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        DbLayer.DbCommands db = new DbLayer.DbCommands();
        int taniid = -1;
        int randevuid;

        private void Form1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        public RandevuTanı(int randevuid)
        {
            InitializeComponent();
            tanilardgv.DataSource = db.tanigetir().Tables[0].DefaultView;
            tanilardgv.Columns["ID"].Visible = false;
            this.randevuid = randevuid;
            
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            AnamezPanel mp = new AnamezPanel(randevuid);
            mp.Show();
            this.Hide();
        }

        private void RandevuTanı_Load(object sender, EventArgs e)
        {

        }
        private void arabox_OnValueChanged(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = tanilardgv.DataSource;
            bs.Filter = string.Format("CONVERT(" + tanilardgv.Columns[2].DataPropertyName + ", System.String) like '%" + arabox.Text.Replace("'", "''") + "%'");
            tanilardgv.DataSource = bs;
            tanilardgv.Columns["ID"].Visible = false;
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            if (taniid != -1 )
            {
               if( db.taniekle(randevuid, taniid))
                {
                    MessageBox.Show("tanı eklendi");
                    AnamezPanel mp = new AnamezPanel(randevuid);
                    mp.Show();
                    this.Hide();
                }
              
               
            }
            if(taniid ==-1)
            {
                MessageBox.Show("Listeden tani seçiniz");
            }

           
        }

        private void tanilardgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            taniid = Int32.Parse(tanilardgv.CurrentRow.Cells[0].Value.ToString());
        }
    }
}
