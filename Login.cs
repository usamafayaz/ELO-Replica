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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void signUpLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Home.Childform(new SignUp(), sender);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (tbLoginEmail.Text.Equals("") || tbLoginPassword.Text.Equals(""))
            {
                errorMessage.Text = "Please Provide Email and Password to Login!";
            }
            else
            {
                String str = @"data source=Gareebooo; initial catalog=ELO; integrated security=true;";
                SqlConnection con = new SqlConnection(str);
                con.Open();
                String query = "select * from users where email='" + tbLoginEmail.Text + "'";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader rd = cmd.ExecuteReader();
                if (rd.HasRows)
                {
                    rd.Read();
                    if (tbLoginEmail.Text.Equals("Admin@gmail.com") && tbLoginPassword.Text.Equals("123"))
                    {
                        Admin admin = new Admin();
                        admin.WindowState=FormWindowState.Maximized;
                        admin.Show();
                        this.Hide();
                    }
                    else if (rd[3].ToString() == tbLoginPassword.Text)
                    {
                        MessageBox.Show("Welcome! " + rd[1].ToString());
                        //this.Hide();
                        Home.Childform(new Cart(), sender);
                    }
                    else
                    {
                        errorMessage.Text = "Invalid Password! ";
                    }
                }
                else
                {
                    errorMessage.Text = "No User Found with this Email! ";
                }
                con.Close();
                rd.Close();
            }
        }

        private void btnLogin_MouseHover(object sender, EventArgs e)
        {
            btnLogin.BackColor = Color.Orange;
            btnLogin.ForeColor = Color.White;
        }
        private void btnLogin_MouseLeave(object sender, EventArgs e)
        {
            btnLogin.BackColor = Color.DarkGray;
            btnLogin.ForeColor = Color.Black;
        }
    }
}
