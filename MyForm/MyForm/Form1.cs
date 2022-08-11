using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace MyForm
{
    public partial class Form1 : Form
    {
        DBAccess objDBAccess = new DBAccess();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            string userName = txtName.Text;
            string userEmail = txtEmail.Text;
            string userPassword = txtPassword.Text;
            string userCountry = txtCountry.Text;

            if (userName.Equals("")) {
                MessageBox.Show("Please enter your Name.");
            }
            else if (userEmail.Equals(""))
            {
                MessageBox.Show("Please enter your Email.");
            }
            else if (userCountry.Equals(""))
            {
                MessageBox.Show("Please select your Country.");
            }
            else if (userPassword.Equals(""))
            {
                MessageBox.Show("Please enter your Password.");
            }
            else 
            {
                SqlCommand insertCommand = new SqlCommand("insert into Users(Name,Email,Password,Country) values(@userName ,@userEmail, @userPassword, @userCountry)");

                insertCommand.Parameters.AddWithValue("@userName", userName);
                insertCommand.Parameters.AddWithValue("@userEmail", userEmail);
                insertCommand.Parameters.AddWithValue("@userPassword", userPassword);
                insertCommand.Parameters.AddWithValue("@userCountry", userCountry);

                int row = objDBAccess.executeQuery(insertCommand);

                if (row == 1) //row == 1 means the user was inserted succesfully
                {
                    MessageBox.Show("Account created succesfully. Please login now");

                    this.Hide();
                    Signin sign = new Signin();
                    sign.Show();
                }
                else // row == 0 unsuccesful
                {
                    MessageBox.Show("User not found");
                }
            }
        }
    }
}
