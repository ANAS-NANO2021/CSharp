using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SuperMarket_Projesi
{
    public partial class ProductForm : Form
    {
        SqlConnection Con = new SqlConnection("Data Source=DESKTOP-NJLRNMK\\SQLEXPRESS;Initial Catalog=SuperMarket;User ID=sa;Password=anas21");

        SqlCommand cmnd;
        SqlDataAdapter adpt;
        DataTable dt;
        public ProductForm()
        {
            InitializeComponent();
            DisPlay();
        }
        
        private void bunifuMaterialTextbox5_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void ÜrünForm_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
       

        int n = 0;

        private void EkleButton_Click(object sender, EventArgs e)
        {
           
          


                /*   Con.Open();
                   cmnd = new SqlCommand("insert into Product_Categories values ('" + prodId.Text + "','" + NameTxt.Text + "','" + QuenTxt.Text + "','"+ PurchasePriceTxt.Text + "','"+ PriceTxt.Text + "','"+ Detailstxt.Text + ,"+ Date1.Value.ToString("yyyy/MM/dd 00:00:00")+" ,'"+ Suppliers.Text + "','"+ CatCB.Text + "')", Con);

                   cmnd.ExecuteNonQuery();
                   MessageBox.Show("verileri başaralı kayd edilmış");
                   Con.Close();
                   DisPlay();
                   Clear();*/
                Con.Open();
                cmnd = new SqlCommand("insert into Product values (@Poduct_Id,@ProductName,@Quantity,@Price,@PurchasePrice,@Details)", Con);
              
                cmnd.Parameters.AddWithValue("@Poduct_Id", prodId.Text);
                cmnd.Parameters.AddWithValue("@ProductName", NameTxt.Text);
                cmnd.Parameters.AddWithValue("@Quantity", QuenTxt.Text);
                cmnd.Parameters.AddWithValue("@Price", PriceTxt.Text);
                cmnd.Parameters.AddWithValue("@PurchasePrice", PurchasePriceTxt.Text);
                cmnd.Parameters.AddWithValue("@Details", Detailstxt.Text);
            cmnd.Parameters.AddWithValue("@date", Date1.Value.ToString("yyyy/MM/dd 00:00:00"));
            cmnd.Parameters.AddWithValue("@suplliers", Supply.Text);
            cmnd.Parameters.AddWithValue("@catagori", CatCB.SelectedValue.ToString());
            cmnd.ExecuteNonQuery();
                MessageBox.Show("deleted successfuly");
                Con.Close();
                DisPlay();
                Clear();

         
            
      

          
        }
        public void DisPlay()
        {
            Con.Open();
            DataTable dt = new DataTable();
            adpt = new SqlDataAdapter("select * from Product ", Con);
            adpt.Fill(dt);
            productdv2.DataSource = dt;
            Con.Close();
        }
        public void Clear()
        {
            prodId.Text = "";
            NameTxt.Text = "";
            QuenTxt.Text = "";
            PriceTxt.Text = "";
            PurchasePriceTxt.Text = "";
            Detailstxt.Text = "";
            Supply.Text = "";
        }

        private void Detailstxt_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox2_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void QuenTxt_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void NameTxt_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Catagory catagori = new Catagory();
            catagori.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SatısForm satıs = new SatısForm();
            satıs.Show();
            this.Hide();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bills bills = new Bills();
            bills.Show();
            this.Hide();
        }
    }
}
