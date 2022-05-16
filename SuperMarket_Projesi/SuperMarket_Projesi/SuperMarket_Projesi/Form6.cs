using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperMarket_Projesi
{
    public partial class Bills : Form
    {
        public Bills()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProductForm prf = new ProductForm();
            prf.Show();
            prf.Hide();
        }
    }
}
