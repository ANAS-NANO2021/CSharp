using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastaneOtomasyonu.ViewLayer
{
    public partial class PasswordReset : Form
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
        int userid = -1;
        int code= new Random().Next(1000, 9999); // Onaylama Kodu için Random Sayı Oluşturuyoruz

        public PasswordReset()
        {
            InitializeComponent();
            
        

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void send_Click(object sender, EventArgs e)
        {
            userid = dbCommands.getuseridbymail(mailTxtbx.Text); // Girilen E Postanın sistemde kayıtlı olup olmadığını Kontrol Ediyoruz
            if (userid==-1)
            {
                MessageBox.Show("E Posta Sistemde Kayıtlı Degil");
            }
            else
            {
                
                try
                {
                    var client = new SmtpClient("smtp.gmail.com", 587)
                    {
                        Credentials = new NetworkCredential("noreply.hastaneotomasyonu@gmail.com", "Yusufk47"),
                        EnableSsl = true
                    };
                    client.Send("noreply.hastaneotomasyonu@gmail.com", mailTxtbx.Text, "Hastane Otomasyonu Şifre Yenileme Kodu", "Merhaba,\nPersonel Şifre Yenileme Kodunuz:\n" + code+ "\nDoğrulama Kodunu Girerek Şifrenizi Değiştirebilirsiniz"); // Maili Gönderiyoruz
                    MessageBox.Show("Gönderildi!");
                    sendbutton.Enabled = false;
                    mailTxtbx.Enabled = false;
                    resetCode.Enabled = true;
                    onaylabuton.Enabled = true;
                    

                }
                catch(SmtpException ex)
                {
                    MessageBox.Show(ex.Message.ToString()+ex.StatusCode.ToString()+"\nCihazınızın internet bağlantısını kontrol ederek tekrar deneyin.");
                }
                }

            }

        private void onaylabuton_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(resetCode.Text))
            {
                if (code == Int32.Parse(resetCode.Text))
                {
                    resetCode.Enabled = false;
                    onaylabuton.Enabled = false;
                    newpw.Enabled = true;
                    pwsave.Enabled = true;
                    MessageBox.Show("E Posta Doğrulandı Şifrenizi Değiştirebilirsiniz");
                }
                else
                    MessageBox.Show("Doğruama Kodu Hatalı");
             
            }
            else MessageBox.Show("Lütfen Doğrulama Kodu Giriniz");
        }
      
        private void newpw_OnValueChanged(object sender, EventArgs e)
        {
            // Girilen Parolanın Ön Kontrolleri
           if(Regex.IsMatch(newpw.Text, "[A-Z]")&& Regex.IsMatch(newpw.Text, "[a-z]")) //Girilen Parolada Alanında A - Z Arası büyük ve a-z küçük harf girilmiş 
            {
                harfkontrol.CheckState = Bunifu.UI.WinForms.BunifuCheckBox.CheckStates.Checked;
            }
            else harfkontrol.CheckState = Bunifu.UI.WinForms.BunifuCheckBox.CheckStates.Unchecked;
           if(Regex.IsMatch(newpw.Text, "[0-9]")) // Girilen Parolara da Rakam var mı
            {
                rakamkontrol.CheckState = Bunifu.UI.WinForms.BunifuCheckBox.CheckStates.Checked;
            }
           else
                rakamkontrol.CheckState = Bunifu.UI.WinForms.BunifuCheckBox.CheckStates.Unchecked;
           if(newpw.Text.Length>=8) // Girilen Parolanın karakter uzunluğu en az 8 karkatermi
            {
                karakterkontrol.CheckState = Bunifu.UI.WinForms.BunifuCheckBox.CheckStates.Checked;
        
            }
           else
                karakterkontrol.CheckState = Bunifu.UI.WinForms.BunifuCheckBox.CheckStates.Unchecked;


        }

        private void pwsave_Click(object sender, EventArgs e)
        {
            if (rakamkontrol.Checked == true && karakterkontrol.Checked == true &&harfkontrol.Checked == true)
            {
                if (dbCommands.updatePwByuserid(userid, newpw.Text))
                {
                    MessageBox.Show("Şifre Değiştirildi Yeni Şifrenizle Sisteme Giriş Yapabilirsiniz");
                    this.Hide();
                }
                else
                    MessageBox.Show("Hata!");
            }
            else
                MessageBox.Show("Girdiğiniz Şifre kriterlerle uyuşmuyor!");
        }
    }
    }

