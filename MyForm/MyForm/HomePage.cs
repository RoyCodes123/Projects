using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MyForm
{
    public partial class HomePage : Form
    {

        DBAccess objDbAccess = new DBAccess();
        public HomePage()
        {
            InitializeComponent();
        }

        private void HomePage_Load(object sender, EventArgs e)
        {
            txtCountryHome.Text = Signin.country;
            txtNameHome.Text = Signin.name;
            txtPasswordHome.Text = Signin.password;
            txtEmailHome.Text = Signin.email;

            lblWelcomeName.Text = "Welcome "+ Signin.name;
        }

        private void btnUpdateInfo_Click(object sender, EventArgs e)
        {
            string newUserName = txtNameHome.Text;
            string newUserEmail = txtEmailHome.Text;
            string newUserCountry = txtCountryHome.Text;
            string newUserPassword = txtPasswordHome.Text;

            if (newUserName.Equals(""))
            {
                MessageBox.Show("Please enter your name");
            }
            else if (newUserEmail.Equals(""))
            {
                MessageBox.Show("Please enter your email");
            }
            else if (newUserPassword.Equals(""))
            {
                MessageBox.Show("Please enter your password");
            }
            else if (newUserCountry.Equals(""))
            {
                MessageBox.Show("Please select your country");
            }
            else
            {
                string query = "Update Users SET Name = '" + @newUserName + "', Email = '" + @newUserEmail + "', Country = '" + @newUserCountry + "', Password = '" + @newUserPassword + "' where ID = '" + Signin.id + "'";

                SqlCommand updateCommand = new SqlCommand(query);

                updateCommand.Parameters.AddWithValue("@newUserName", newUserName);
                updateCommand.Parameters.AddWithValue("@newUserEmail", newUserEmail);
                updateCommand.Parameters.AddWithValue("@newUserPassword", newUserPassword);
                updateCommand.Parameters.AddWithValue("@newUserCountry", newUserCountry);

                int row = objDbAccess.executeQuery(updateCommand);

                if (row == 1) //row == 1 means the user was inserted succesfully
                {
                    MessageBox.Show("Information Updated Succesfully");

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

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Are you sure?", "Delete Account", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dialog == DialogResult.Yes)
            {
                string query = "DELETE from Users Where ID = '" + Signin.id + "'";

                SqlCommand deleteCommand = new SqlCommand(query);

                int row = objDbAccess.executeQuery(deleteCommand);

                if (row == 1) //row == 1 means the user was inserted succesfully
                {
                    MessageBox.Show("Account Deleted Succesfully");

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
