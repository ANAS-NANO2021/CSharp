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
    public partial class Recete : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        DbLayer.DbCommands db = new DbLayer.DbCommands();
        int randevuid;


        private void Form1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        public Recete(int randevuid)
        {
            this.randevuid= randevuid;
            InitializeComponent();
            db.Muayeneldu(this.randevuid);

            
            ilaclardgv.DataSource = db.Ilacgetir().Tables[0].DefaultView;
            ilaclardgv.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MuayenePanel_Load(object sender, EventArgs e)
        {
        }

        private void ilaclardgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
         
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            DbLayer.DbCommands db1 = new DbLayer.DbCommands();
            db1.ilacEkle(randevuid, Int32.Parse(ilaclardgv.CurrentRow.Cells["ID"].Value.ToString()), bulgutxtbx.Text);
        }
    }
    }

