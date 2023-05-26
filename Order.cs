using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web.UI.HtmlControls;
using System.Windows.Forms;

namespace ELO
{
    public partial class Order : Form
    {
        public Order()
        {
            InitializeComponent();
            Quantity.Text = "1";
        }

        private void btnSmall_Click(object sender, EventArgs e)
        {
            sizeLabel.Text = "S";
        }

        private void btnMedium_Click(object sender, EventArgs e)
        {
            sizeLabel.Text = "M";

        }

        private void btnLarge_Click(object sender, EventArgs e)
        { 
            sizeLabel.Text = "L";
        }

        private void btnXL_Click(object sender, EventArgs e)
        {
            sizeLabel.Text = "XL";
        }

        private void btnDec_Click(object sender, EventArgs e)
        {
            if(Convert.ToInt64(Quantity.Text) >1)
            Quantity.Text = (Convert.ToInt64(Quantity.Text)-1).ToString();
        }

        private void btnInc_Click(object sender, EventArgs e)
        {
            Quantity.Text = (Convert.ToInt64(Quantity.Text) + 1).ToString();

        }

        private void Order_Load(object sender, EventArgs e)
        {

        }

        private void btnAddCart_Click(object sender, EventArgs e)
        {
            try {   
            String str = @"data source=Gareebooo; initial catalog=ELO; integrated security=true;";
            SqlConnection con = new SqlConnection(str);
            String query = "insert into cart values("+ int.Parse(productId.Text) + ",'" + productTitle.Text+ "','"+productPrice.Text+ "','"+ productImage.Tag.ToString() + "',"+int.Parse(Quantity.Text)+",'"+sizeLabel.Text+"')";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            int rows=cmd.ExecuteNonQuery();
            con.Close();
            if (rows > 0)
            {
                MessageBox.Show("Successfully Added to Cart", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Home.Childform(new Cart(), sender);
            }
            else
                MessageBox.Show("Some Error Occured!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            AddedLabel.Visible = true;
            Thread.Sleep(3000);
            AddedLabel.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
