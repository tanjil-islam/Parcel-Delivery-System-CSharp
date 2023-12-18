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
    public partial class Customer_My_Details : Form
    {

        private Panel homepanelReference;
         string Customername;

        DBAccess dBAccessLibrary = new DBAccess();
        DataTable dtUser = new DataTable();
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-D76J3JK4\SQLEXPRESS;Initial Catalog=ParcelDeliveryManagement;Integrated Security=True");
       
        public Customer_My_Details(Panel mainpanel, string customername)
        {
            InitializeComponent();

            homepanelReference = mainpanel;
            Customername = customername;
        }

        private void txtTotalOrderCheck_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Back_Click(object sender, EventArgs e)
        {
           
        }

        private void Back_Click_1(object sender, EventArgs e)
        {
            Customer_Home customer_Home = new Customer_Home(homepanelReference, Customername); // Pass the homepanel control
            customer_Home.TopLevel = false;
            customer_Home.FormBorderStyle = FormBorderStyle.None;
            customer_Home.Dock = DockStyle.Fill;

            homepanelReference.Controls.Clear();
            homepanelReference.Controls.Add(customer_Home);

            customer_Home.Show();
        }

        private void txtTotalOrderCheck_TextChanged_1(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            string check = Customername;

            try
            {
                string query = "SELECT COUNT(*) FROM CompleteOrdersInfo WHERE Cust_Name = @check";

                try
                {
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }

                    using (SqlCommand command = new SqlCommand(query, con))
                    {
                        command.Parameters.AddWithValue("@check", check); // Add parameter to prevent SQL injection

                        int count = (int)command.ExecuteScalar();

                        txtTotalOrderCheck.Text = count.ToString();
                    }
                }
                catch (Exception ex)
                {
                    // Log or handle the exception appropriately
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
            catch (Exception exp)
            {
                MessageBox.Show("Error in search " + exp.ToString());
            }
        }

        private void lblcheckusername_Click(object sender, EventArgs e)
        {
            txtcheckhname.Text = Customername; 
        }

        private void txtcheckhname_TextChanged(object sender, EventArgs e)
        {
            try
            {

                SqlDataAdapter sda = new SqlDataAdapter("Select * from CustomerInfo where (Cust_Name like '%" + Customername + "%')", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                dataGridView1.Rows.Clear();

                foreach (DataRow item in dt.Rows)
                {
                    int n = dataGridView1.Rows.Add();

                    dataGridView1.Rows[n].Cells[0].Value = item[0].ToString();
                    dataGridView1.Rows[n].Cells[1].Value = item[1].ToString();
                    dataGridView1.Rows[n].Cells[2].Value = item[4].ToString();
                    dataGridView1.Rows[n].Cells[3].Value = item[6].ToString();
                    dataGridView1.Rows[n].Cells[4].Value = item[7].ToString();
                    dataGridView1.Rows[n].Cells[5].Value = item[8].ToString();
                    dataGridView1.Rows[n].Cells[6].Value = item[9].ToString();
                    dataGridView1.Rows[n].Cells[7].Value = item[2].ToString();
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error in search " + exp.ToString());
            }
        }

        int customerid;
        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            customerid = Int32.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            txtUserName.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            txtEmail.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();  
            txtPhoneNo.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            txtApartmentNo.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            txtPostalCode.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            txtStreetAddress.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            txtCity.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string username = txtUserName.Text;
            string useremail = txtEmail.Text;
            string userphoneno = txtPhoneNo.Text;
            string apartmentno = txtApartmentNo.Text;
            string postalcode = txtPostalCode.Text;
            string streetaddress = txtStreetAddress.Text;
            string city = txtCity.Text;
            string sure = useremail;

            if(this.txtUserName.Text.Length==0 || this.txtEmail.Text.Length == 0 || this.txtPhoneNo.Text.Length == 0 ||
                this.txtApartmentNo.Text.Length == 0 || this.txtPostalCode.Text.Length == 0 || this.txtStreetAddress.Text.Length == 0
                || this.txtCity.Text.Length == 0)
            {
                MessageBox.Show("You don't have permission to make null");
            }
            else
            {
                string query = "Update CustomerInfo set Cust_email='" + useremail + "',Cust_PhoneNo='" + userphoneno + "',Apartment_No='" 
                    + apartmentno + "',Postal_Code='" + postalcode + "',Street_Address='" + streetaddress + "',City='" + city + "' where Cust_ID="+ customerid;

                SqlCommand updateCommand = new SqlCommand(query);

               updateCommand.Parameters.AddWithValue("@customerid", customerid);
                updateCommand.Parameters.AddWithValue("@useremail", useremail);
                updateCommand.Parameters.AddWithValue("@userphoneno", userphoneno);
                updateCommand.Parameters.AddWithValue("@apartmentno", apartmentno);
                updateCommand.Parameters.AddWithValue("@postalcode", postalcode);
                updateCommand.Parameters.AddWithValue("@streetaddress", streetaddress);
                updateCommand.Parameters.AddWithValue("@city", city);




                int row = dBAccessLibrary.executeQuery(updateCommand);

                if (row >= 1)
                {
                    MessageBox.Show(" Information updated into table : " + Customername);

                }
                else
                {
                    MessageBox.Show("Information updation failed: " + Customername);
                }

                showDetails();

                this.txtUserName.Text = "";
                this.txtEmail.Text = "";
                this.txtPhoneNo.Text = "";
                this.txtApartmentNo.Text = "";
                this.txtPostalCode.Text = "";
                this.txtStreetAddress.Text = "";
                this.txtCity.Text = "";
            }
        }

        public void showDetails()
        {
            try
            {

                SqlDataAdapter sda = new SqlDataAdapter("Select * from CustomerInfo where (Cust_Name like '%" + Customername + "%')", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                dataGridView1.Rows.Clear();

                foreach (DataRow item in dt.Rows)
                {
                    int n = dataGridView1.Rows.Add();

                    dataGridView1.Rows[n].Cells[0].Value = item[0].ToString();
                    dataGridView1.Rows[n].Cells[1].Value = item[1].ToString();
                    dataGridView1.Rows[n].Cells[2].Value = item[4].ToString();
                    dataGridView1.Rows[n].Cells[3].Value = item[6].ToString();
                    dataGridView1.Rows[n].Cells[4].Value = item[7].ToString();
                    dataGridView1.Rows[n].Cells[5].Value = item[8].ToString();
                    dataGridView1.Rows[n].Cells[6].Value = item[9].ToString();
                    dataGridView1.Rows[n].Cells[7].Value = item[2].ToString();

                    customerid = Int32.Parse(item[0].ToString());
                }
               // customerid = Int32.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error in ShowInformation " + exp.ToString());
            }

        }

        private void btnDeleteAccount_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("1: Do you want to permanent delete?, Press = Yes. \n 2:No"," your delete operation ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(dr==DialogResult.Yes)
            {
                if (txtUserName.Text.Length != 0)
                {
                    string username = txtUserName.Text;


                    string s = "delete from UserInfo where UserName=@username ";

                    SqlCommand userdeleteCommand = new SqlCommand(s);
                    userdeleteCommand.Parameters.AddWithValue("@username", username);


                    int row = dBAccessLibrary.executeQuery(userdeleteCommand);

                    if (row >= 1)
                    {
                        MessageBox.Show(username + " Success..... ");


                    }
                    else
                    {
                        MessageBox.Show(username + " Account deletion failed: ");
                    }


                    string query = "delete from CustomerInfo where Cust_ID=" + customerid;

                    SqlCommand deleteCommand = new SqlCommand(query);

                     row = dBAccessLibrary.executeQuery(deleteCommand);

                    if (row >= 1)
                    {
                        MessageBox.Show(username + " Your Account is permanently Deleted ");
                        

                    }
                    else
                    {
                        MessageBox.Show(username + " Account deletion failed: ");
                    }

                    //showDetails();
                    this.txtUserName.Text = "";
                    this.txtEmail.Text = "";
                    this.txtPhoneNo.Text = "";
                    this.txtApartmentNo.Text = "";
                    this.txtPostalCode.Text = "";
                    this.txtStreetAddress.Text = "";
                    this.txtCity.Text = "";

                    this.Hide();
                    Login login = new Login();
                    login.Show();
                }
                else
                {
                    MessageBox.Show("Give your username properly");
                }
            }
            if (dr == DialogResult.No)
            {
                MessageBox.Show("Thank you for stay with us");
            }

        }
    }
}
