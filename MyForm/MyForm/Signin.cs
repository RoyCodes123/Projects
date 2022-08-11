using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyForm
{
    public partial class Signin : Form
    {
        public static string id, name, country, email, password;

        DBAccess objDBAccess = new DBAccess();

        private void label1_Click(object sender, EventArgs e)
        {
            this.Hide();
            CommandBuilderForm cbf = new CommandBuilderForm();
            cbf.Show();
        }

        DataTable dtUsers = new DataTable();
        public Signin()
        {
            InitializeComponent();
        }

        private void btnSignin_Click(object sender, EventArgs e)
        {
            string userEmail = txtEmailLogin.Text;
            string userPassword = txtPasswordLogin.Text;    

            if (userEmail.Equals(""))
            {
                MessageBox.Show("Please enter your email.");
            }
            else if (userPassword.Equals(""))
            {
                MessageBox.Show("Please enter your password.");
            }
            else
            {
                string query = "Select * From Users Where Email='" + userEmail + "' AND Password = '" + userPassword + "'";

                //the function takes the select query as a parameter and saves the returned information in a temporary table(dtUsers)
                objDBAccess.readDatathroughAdapter(query, dtUsers);

                if (dtUsers.Rows.Count == 1)
                {
                    id = dtUsers.Rows[0]["ID"].ToString();
                    name = dtUsers.Rows[0]["Name"].ToString();
                    country = dtUsers.Rows[0]["Country"].ToString();
                    password = dtUsers.Rows[0]["Password"].ToString();
                    email = dtUsers.Rows[0]["Email"].ToString();


                    MessageBox.Show("Congratulations you have logged in succesfully.");
                    objDBAccess.closeConn();

                    this.Hide(); //sends user to homepage
                    HomePage home = new HomePage();
                    home.Show();
                }
                else
                {
                    MessageBox.Show("Error occured try again.");
                }
            }

        }

        private void lblCreateAccount_Click(object sender, EventArgs e)
        {
            this.Hide(); //sends user to homepage
            Form1 signUp = new Form1();
            signUp.Show();
        }
    }
}
