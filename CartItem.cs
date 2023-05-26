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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace ELO
{
    public partial class CartItem : UserControl
    {
        public CartItem()
        {
            InitializeComponent();
        }

        private void pcbDelete_Click_1(object sender, EventArgs e)
        {
            String str = @"data source=Gareebooo; initial catalog=ELO; integrated security=true;";
            SqlConnection con = new SqlConnection(str);
            String query = "delete from cart where id='" + Tag.ToString() + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            cmd.ExecuteReader();
            con.Close();
            Home.Childform(new Cart(), sender);

        }
    }
}
