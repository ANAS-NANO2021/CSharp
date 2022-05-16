using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrtaDünyaPansiyonKayıt
{
    public partial class FrmRadyo : Form
    {
        public FrmRadyo()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            axWindowsMediaPlayer1.URL = "https://listen.powerapp.com.tr/powerturkeniyiler/abr/powerturkeniyiler/128/playlist.m3u8 ";
        }

        private void FrmRadyo_Load(object sender, EventArgs e)
        {
           
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            axWindowsMediaPlayer1.URL = "https://n10101m.mediatriple.net/videoonlylive/mtkgeuihrlfwlive/u_stream_5c9e30cf8d28e_1/playlist.m3u8 ";
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            axWindowsMediaPlayer1.URL = "http://kralpopwmp.radyotvonline.com:80/; ";
        }
    }
}
