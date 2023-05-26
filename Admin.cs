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
using TheArtOfDevHtmlRenderer.Adapters;

namespace ELO
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void btnAddImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            if (open.ShowDialog() == DialogResult.OK)
            {
                txtPath.Text = open.FileName;
            }
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            try
            {
                String str = @"data source=Gareebooo; initial catalog=ELO; integrated security=true;";
                SqlConnection con = new SqlConnection(str);
                string query;
                if (rbKids.Checked)
                {
                    query = "insert into items values('" + txtTitle.Text + "','" + txtPrice.Text + "','" + txtBrand.Text + "','" + txtPath.Text + "','Kids','" + cbType.SelectedItem + "')";
                }
                else if (rbMen.Checked)
                {
                    query = "insert into items values('" + txtTitle.Text + "','" + txtPrice.Text + "','" + txtBrand.Text + "','" + txtPath.Text + "','Men','" + cbType.SelectedItem + "')";
                }
                else
                {
                    query = "insert into items values('" + txtTitle.Text + "','" + txtPrice.Text + "','" + txtBrand.Text + "','" + txtPath.Text + "','Women','" + cbType.SelectedItem + "')";
                }
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                    MessageBox.Show("Item Added Successfully");

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}