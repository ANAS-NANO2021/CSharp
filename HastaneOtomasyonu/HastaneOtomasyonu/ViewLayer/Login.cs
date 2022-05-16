using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastaneOtomasyonu
{
    public partial class Login : Form

    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void Form1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        DbLayer.DbCommands dbCommands = new DbLayer.DbCommands();
        public static int loginuserid;
        public Login()
        {
            InitializeComponent();
            
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {

            // 0= personel
            // 1= doktor 
            //2 yönetici
            if(dbCommands.StaffLogin(usernameTxtbx.Text, PwTxtbx.Text) == 2) // Girilen Kullanıcı Adı ve Şifre Yöneticiyie Ait ise Yönetici Menüsünü Açıyoruz
            {
                MessageBox.Show(" Yönetici Giriş Başarılı");
                loginuserid = dbCommands.getuseridbyusername(usernameTxtbx.Text);
                ViewLayer.YoneticiPanel yp = new ViewLayer.YoneticiPanel();
                yp.Show();
            }
            if (dbCommands.StaffLogin(usernameTxtbx.Text, PwTxtbx.Text) == 1) // Girilen Kullanıcı Adı ve Şifre Doktora Ait ise Doktor Menüsünü Açıyoruz
            {
                MessageBox.Show(" Doktor Giriş Başarılı");
                loginuserid = dbCommands.getuseridbyusername(usernameTxtbx.Text);
                ViewLayer.DoktorPanel doktorPanel = new ViewLayer.DoktorPanel();
                doktorPanel.Show();
              
            }
            if (dbCommands.StaffLogin(usernameTxtbx.Text, PwTxtbx.Text) == 0) // Girilen Kullanıcı Adı ve Şifre Sekteter Ait ise Sekreter Menüsünü Açıyoruz
            {
                MessageBox.Show(" Personel Giriş Başarılı");
                loginuserid = dbCommands.getuseridbyusername(usernameTxtbx.Text);
                ViewLayer.RandevuPanel rp = new ViewLayer.RandevuPanel();
                rp.Show();
            }
            if (dbCommands.StaffLogin(usernameTxtbx.Text, PwTxtbx.Text) == -2)
            {
                MessageBox.Show("ID Veya Pw Boş bırakılamaz");
            }
            if (dbCommands.StaffLogin(usernameTxtbx.Text, PwTxtbx.Text) == -1)
            {
                MessageBox.Show("Hatalı Giriş");
            }

         
        }

        private void pwResButton_Click(object sender, EventArgs e)
        {
            ViewLayer.PasswordReset passwordReset = new ViewLayer.PasswordReset();
            passwordReset.Show();
        }
    }
}
