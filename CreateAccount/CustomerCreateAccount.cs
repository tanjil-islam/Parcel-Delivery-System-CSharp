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
    public partial class CustomerCreateAccount : Form
    {

        DBAccess dBAccessLibrary = new DBAccess();
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-D76J3JK4\SQLEXPRESS;Initial Catalog=ParcelDeliveryManagement;Integrated Security=True");

        public CustomerCreateAccount()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string userName = txtUserName.Text;
            string userEmail = txtEmail.Text;
            string userPassword = txtPassword.Text;
            string userPhoneNo = txtPhoneNo.Text;
            string userAddress = txtAddress.Text;
            string userAppartmentNo = txtApartmentNo.Text;
            string userPostalCode = txtPostalCode.Text;

            string userStreetAddress = txtStreetAddress.Text;
            string userCity = txtCity.Text;
            string userRole = "Customer";

            if (!IsUsernameUnique(userName))
            {
                MessageBox.Show("Username already exists. Please choose a different username.");
                return; 
            }

            if (!IsPasswordValid(userPassword))
            {
                MessageBox.Show("Password should contain at least one lowercase letter, one uppercase letter, one special character, and a number.");
                return;
            }

            if (!IsEmailValid(userEmail))
            {
                MessageBox.Show("Invalid email format. Please provide a valid Gmail address.");
                return;
            }

            if (!IsPhoneNumberValid(userPhoneNo))
            {
                MessageBox.Show("Invalid phone number format. Please provide a valid 11-digit number starting with '01' and third digit is greater than '2'.");
                return;
            }


            if (this.txtUserName.Text.Length == 0 || this.txtEmail.Text.Length == 0 || this.txtPassword.Text.Length == 0 ||
                this.txtPhoneNo.Text.Length == 0 || this.txtAddress.Text.Length == 0 ||
                this.txtApartmentNo.Text.Length == 0 || this.txtPostalCode.Text.Length == 0 || this.txtStreetAddress.Text.Length == 0 ||
                this.txtCity.Text.Length == 0)
            {
                MessageBox.Show("All field Filled Up Mandatory...");
            }
            else
            {
                Customer customer = new Customer(userName, userEmail, userPassword, userPhoneNo, userAddress,
                                    userAppartmentNo, userPostalCode, userStreetAddress, userCity);

               
                bool registrationSuccess = customer.Register();

                if (registrationSuccess)
                {
                    MessageBox.Show("Congratulation Account Create Successfull");
                    txtUserName.Text = "";
                    txtStreetAddress.Text = "";
                    txtPostalCode.Text = "";
                    txtPhoneNo.Text = "";
                    txtPassword.Text = "";
                    txtEmail.Text = "";
                    txtCity.Text = "";
                    txtApartmentNo.Text = "";
                    txtAddress.Text = "";
                }
                else
                {
                    MessageBox.Show("Opps! Account Creation Failed");
                }

            }
            Loading l1 = new Loading();
            l1.Show();
        }

        private bool IsPhoneNumberValid(string phoneNumber)
        {
            if (phoneNumber.Length == 11 && phoneNumber.StartsWith("01"))
            {
                int thirdDigit = int.Parse(phoneNumber.Substring(2, 1));
                return thirdDigit >= 3;
            }
            return false;
        }
        private bool IsEmailValid(string email)
        {
            
            if (email.Length < 11 || !email.EndsWith("@gmail.com"))
            {
                return false;
            }


            return true;
        }

        private bool IsPasswordValid(string password)
        {
            bool hasLower = false, hasUpper = false, hasSpecial = false, hasNumber = false;

            foreach (char c in password)
            {
                if (char.IsLower(c))
                {
                    hasLower = true;
                }
                else if (char.IsUpper(c))
                {
                    hasUpper = true;
                }
                else if (char.IsDigit(c))
                {
                    hasNumber = true;
                }
                else if (!char.IsLetterOrDigit(c))
                {
                    hasSpecial = true;
                }
            }

            return hasLower && hasUpper && hasSpecial && hasNumber;
        }

        private bool IsUsernameUnique(string username)
        {
            string query = "SELECT COUNT(*) FROM UserInfo WHERE UserName = @userName";

            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                using (SqlCommand command = new SqlCommand(query, con))
                {
                    command.Parameters.AddWithValue("@userName", username);
                    int count = (int)command.ExecuteScalar();
                    return count == 0; 
                }
            }

            catch (Exception ex)
            {
                
                throw;
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }

        private void btnAlreadyAccount_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private void lblBackPreviousPage_Click(object sender, EventArgs e)
        {
            this.Hide();
            CreateNewAccount createNewAccount = new CreateNewAccount();
            createNewAccount.Show();
        }
    }
}
