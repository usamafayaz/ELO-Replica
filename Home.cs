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
using System.Xml.Linq;

namespace ELO
{
    public partial class Home : Form
    {
        public static Form currentForm;
        public static Panel currentPanel;
        public static Panel homecurrentPanel;


        public Home()
        {
            InitializeComponent();
            currentPanel =  homePanel;
            homecurrentPanel = homeFrontPanel;
        }
        private void cartLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            searchBox.Clear();
            categoryPanel.Hide();
            Childform(new Cart(), sender);
        }

        private void loginLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            searchBox.Clear();
            categoryPanel.Hide();
            Childform(new Login(), sender);
        }
        private void btnMen_MouseHover(object sender, EventArgs e)
        {
            btnMen.BackColor = Color.Orange;
            btnMen.ForeColor = Color.White;
        }

        private void btnWomen_MouseHover(object sender, EventArgs e)
        {
            btnWomen.BackColor = Color.Orange;
            btnWomen.ForeColor = Color.White;
        }

        private void btnMen_MouseLeave(object sender, EventArgs e)
        {
            btnMen.BackColor = Color.White;
            btnMen.ForeColor = Color.Black;
        }

        private void btnWomen_MouseLeave(object sender, EventArgs e)
        {
            btnWomen.BackColor = Color.White;
            btnWomen.ForeColor = Color.Black;
        }

        private void btnKids_MouseHover(object sender, EventArgs e)
        {
            btnKids.BackColor = Color.Orange;
            btnKids.ForeColor = Color.White;
        }

        private void btnKids_MouseLeave(object sender, EventArgs e)
        {
            btnKids.BackColor = Color.White;
            btnKids.ForeColor = Color.Black;
        }
        public static void Childform(Form form,object sender)
        {
            if (currentForm != null)
                currentForm.Close();
            currentForm = form;
            homecurrentPanel.Hide();
            currentForm.FormBorderStyle = FormBorderStyle.None;
            currentForm.TopLevel = false;
            currentForm.Dock = DockStyle.Fill;
            currentPanel.Controls.Add(currentForm);
            currentPanel.BringToFront();
            currentForm.Show();
        }
        

        private void pbLogo_Click(object sender, EventArgs e)
        {
            categoryPanel.Show();
            if (currentForm != null)
            {
                currentForm.Close();
                homecurrentPanel.Show();
            }
            Home_Load_1(sender, e);
            searchBox.Clear();

        }
        public void  Home_Load_1(object sender, EventArgs e)
        {
            executeQuery("select * from items");
            searchBox.Clear();
        }

        private void btnKids_Click(object sender, EventArgs e)
        {
            executeQuery("select * from items where category='kids'");
            searchBox.Clear();

        }

        private void btnWomen_Click(object sender, EventArgs e)
        {
            executeQuery("select * from items where category='women'");
            searchBox.Clear();

        }

        private void btnMen_Click_1(object sender, EventArgs e)
        {
            executeQuery("select * from items where category='Men'");
            searchBox.Clear();

        }
        private void pbSearchLogo_Click(object sender, EventArgs e)
        {
            executeQuery("select * from items where title like '%" +searchBox.Text + "%' or brand like '%" +searchBox.Text + "%' or category like '%" +searchBox.Text + "%' or type like '%" +searchBox.Text + "%'");
            searchBox.Clear();
        }
        public void executeQuery(String Query)
        {
            tableLayoutPanel1.Controls.Clear();
            String str = @"data source=Gareebooo; initial catalog=ELO; integrated security=true;";
            SqlConnection con = new SqlConnection(str);
            String query = Query;
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Items itm = new Items();
                itm.Tag = dr[0].ToString();
                itm.Title.Text = dr[1].ToString();
                itm.Price.Text = "RS " + dr[2].ToString();
                itm.Brand.Text = dr[3].ToString();
                itm.ItemPicture.Image = Image.FromFile(dr[4].ToString());
                tableLayoutPanel1.Controls.Add(itm);
            }
            con.Close();
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            executeQuery("select * from items where title like '%" + searchBox.Text + "%' or brand like '%" + searchBox.Text + "%' or category like '%" + searchBox.Text + "%' or type like '%" + searchBox.Text + "%'");

        }
    }
}
