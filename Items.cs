using System;
using System.Collections;
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
    public partial class Items : UserControl
    {
        public Items()
        {
            InitializeComponent();
        }
        private void guna2Panel1_Click(object sender, EventArgs e)
        {
            String str = @"data source=Gareebooo; initial catalog=ELO; integrated security=true;";
            SqlConnection con = new SqlConnection(str);
            String query = "select * from items where id = '" + Tag + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            Order order = new Order();
            if (dr.Read())
            {
                order.productId.Text=dr[0].ToString();
                order.productTitle.Text = dr[1].ToString();
                order.productPrice.Text =  dr[2].ToString();
                order.productImage.Image = Image.FromFile(dr[4].ToString());
                order.productImage.Tag = dr[4].ToString();

            }
            con.Close();
            Home.Childform(order, sender);
        }

        private void ItemPicture_Click(object sender, EventArgs e)
        {
            String str = @"data source=Gareebooo; initial catalog=ELO; integrated security=true;";
            SqlConnection con = new SqlConnection(str);
            String query = "select * from items where id = '" + Tag + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            Order order = new Order();
            if (dr.Read())
            {
                order.productId.Text = dr[0].ToString();
                order.productTitle.Text = dr[1].ToString();
                order.productPrice.Text = dr[2].ToString();
                order.productImage.Image = Image.FromFile(dr[4].ToString());
                order.productImage.Tag = dr[4].ToString();

            }
            con.Close();
            Home.Childform(order, sender);
        }
    }
}
