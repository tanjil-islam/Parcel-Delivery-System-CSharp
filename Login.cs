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

namespace Parcel_Delivery_Management_System
{
    public partial class Login : Form
    {
        DBAccess dBAccessLibrary = new DBAccess();
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-D76J3JK4\SQLEXPRESS;Initial Catalog=ParcelDeliveryManagement;Integrated Security=True");
        public Login()
        {
            InitializeComponent();
        }

        private void btnCreateNewAcount_Click(object sender, EventArgs e)
        {
            this.Hide();
            CreateNewAccount createAccountForm = new CreateNewAccount();
            createAccountForm.Show();
        }

        private void lblBackPreviousPage_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       

        private void LoginPressButton()
        {
            string username = txtUserName.Text;
            string password = txtPassword.Text;

            try
            {
                con.Open();
                string query = "SELECT Role FROM UserInfo WHERE UserName = @username AND PassWord = @password";
                SqlCommand command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password);
                if (txtUserName.Text.Length == 0 || txtPassword.Text.Length == 0)
                {
                    MessageBox.Show("Please provide your username and password");
                }
                else
                {
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            string role = reader["Role"].ToString();

                            if (role == "Admin")
                            {
                                this.Hide();
                                Admin_HomePage admin_homePage = new Admin_HomePage(username);
                                admin_homePage.Show();
                            }
                            else if (role == "Employee")
                            {
                                this.Hide();
                                Employee_HomePage employee_HomePage = new Employee_HomePage(username);
                                employee_HomePage.Show();
                            }
                            else if(role == "Customer")
                            {
                                this.Hide();
                                Customer_Home_Page customercreateaccount = new Customer_Home_Page(username);
                                customercreateaccount.Show();
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid username or password. Please try again.");
                        txtPassword.Text = "";
                        txtUserName.Text = "";
                    }
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }

        private void txtKeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar==(char)Keys.Enter)
            {
                LoginPressButton();
            }
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            LoginPressButton();
        }
    }
}
