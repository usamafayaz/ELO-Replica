using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ELO
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }


        private void loginLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Home.Childform(new Login(), sender);
        }
        private void btnSignup_MouseHover(object sender, EventArgs e)
        {
            btnSignup.BackColor = Color.Orange;
            btnSignup.ForeColor = Color.White;
        }

        private void btnSignup_MouseLeave(object sender, EventArgs e)
        {
            btnSignup.BackColor = Color.DarkGray;
            btnSignup.ForeColor = Color.Black;
        }
        private void btnSignup_Click(object sender, EventArgs e)
        {
            if (tbSignupEmail.Text.Equals("") || tbSignupPassword.Text.Equals(""))
            {
                errorMessage.Text = "Email and Password are Mandatory for Account Creation!";
            }
            else
            {
                String str = @"data source=Gareebooo; initial catalog=ELO; integrated security=true;";
                SqlConnection con = new SqlConnection(str);
                string q = "select * from users where email='" + tbSignupEmail.Text + "'";
                SqlCommand cmd;
                try
                {

                    con.Open();
                    cmd = new SqlCommand(q, con);
                    SqlDataReader rd = cmd.ExecuteReader();
                    if (rd.HasRows)
                    {
                        errorMessage.Text = "Account with this Email Already Exist";
                    }
                    else
                    {
                        rd.Close();
                        if (tbSignupEmail.Text.Contains("@"))
                        {
                            String query = "insert into Users values('" + tbSignupName.Text + "','" + tbSignupEmail.Text + "','" + tbSignupPassword.Text + "')";
                            cmd = new SqlCommand(query, con);
                            int rows = cmd.ExecuteNonQuery();
                            con.Close();
                            Login login = new Login();
                            login.successMessage.Text = "Account Created Successfully";
                            Home.Childform(login, sender);
                        }
                        else
                        {
                            errorMessage.Text = "Incorrect Email Format";
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}

