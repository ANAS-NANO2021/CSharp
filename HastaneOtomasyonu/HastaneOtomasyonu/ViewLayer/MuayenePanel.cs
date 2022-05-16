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
    public partial class MuayenePanel : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        DbLayer.DbCommands db = new DbLayer.DbCommands();
        DbLayer.DbCommands db2 = new DbLayer.DbCommands();
        int randevuid;


        private void Form1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        public MuayenePanel(int randevuid)
        {
            this.randevuid= randevuid;
            InitializeComponent();
            db.Muayeneldu(this.randevuid);

            sikayettxtbox.Text = db.randevusikayetgetir(randevuid);
            bulgutxtbx.Text = db.randevumuayenebulgusugetir(randevuid);
            notlartxbx.Text = db.randevunotugetirr(randevuid);
            tedavisonuctxtbx.Text = db.randevumuayenesonucgetir(randevuid);
            ilaclardgv.DataSource = db.randevuilacgetir(randevuid).Tables[0].DefaultView;
            tanilardgv.DataSource = db2.randevutanigetir(randevuid).Tables[0].DefaultView;
            
            tanilardgv.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            ilaclardgv.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MuayenePanel_Load(object sender, EventArgs e)
        {
        }

        private void tanilardgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            int taniid = Int32.Parse(tanilardgv.CurrentRow.Cells[3].Value.ToString());
            if (e.ColumnIndex == tanilardgv.Columns["button"].Index && e.RowIndex >= 0)
            {

                if (db2.tanisil(randevuid, taniid))
                {
                    MessageBox.Show("Tanı Silindi");
                    tanilardgv.DataSource = db2.randevutanigetir(randevuid).Tables[0].DefaultView;
                }
                else
                    MessageBox.Show("Silinemedi");
            }
        }

        private void ilaclardgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int ilacid = Int32.Parse(ilaclardgv.CurrentRow.Cells[3].Value.ToString());
            if (e.ColumnIndex == ilaclardgv.Columns["ilacsilbutton"].Index && e.RowIndex >= 0)
            {

                if (db.ilacsil(randevuid, ilacid))
                {
                    MessageBox.Show("İlac Silindi");
                    ilaclardgv.DataSource = db.randevuilacgetir(randevuid).Tables[0].DefaultView;
                }
                else
                    MessageBox.Show("Silinemedi");
            }
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            Recete RCT = new Recete(randevuid);
            RCT.ShowDialog();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            db.InsertAnamez(randevuid, sikayettxtbox.Text, bulgutxtbx.Text, tedavisonuctxtbx.Text, notlartxbx.Text);
        }

    }
    }

