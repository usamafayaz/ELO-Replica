using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ELO
{
    public partial class Cart : Form
    {
        public int grand =0;
        public Cart()
        {
                InitializeComponent();
        }

        public void executeQuery(String Query)
        {
            String str = @"data source=Gareebooo; initial catalog=ELO; integrated security=true;";
            SqlConnection con = new SqlConnection(str);
            String query = Query;
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                CartItem itm = new CartItem();
                itm.Tag = dr[0].ToString();
                itm.productTitle.Text = dr[1].ToString();
                itm.productPrice.Text = dr[2].ToString();
                itm.pictureBox1.Image = Image.FromFile(dr[3].ToString());
                itm.productQuantity.Text = dr[4].ToString();
                itm.productSize.Text = dr[5].ToString();
                int total = int.Parse(itm.productPrice.Text.ToString()) * int.Parse(itm.productQuantity.Text.ToString());
                itm.ItemTotal.Text = total.ToString();
                grand += total;
                tableLayoutPanel1.Controls.Add(itm);
            }
            con.Close();
            GrandTotal.Text = grand.ToString();
        }

        private void Cart_Load(object sender, EventArgs e)
        {
            executeQuery("select * from cart");

        }

        private void btnCheckout_MouseHover(object sender, EventArgs e)
        {
            btnCheckout.BackColor = Color.Orange;
            btnCheckout.ForeColor = Color.White;
        }

        private void btnCheckout_MouseLeave(object sender, EventArgs e)
        {
            btnCheckout.BackColor = Color.DarkGray;
            btnCheckout.ForeColor = Color.Black;
        }
    }
}
