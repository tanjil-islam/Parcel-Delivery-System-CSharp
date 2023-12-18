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
    public partial class Employee_MyDetails : Form
    {
        string employeename;
        int employeeid;
        private Panel homePanelReference;

        DBAccess dBAccessLibrary = new DBAccess();
        DataTable dtUser = new DataTable();
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-D76J3JK4\SQLEXPRESS;Initial Catalog=ParcelDeliveryManagement;Integrated Security=True");

        public Employee_MyDetails(Panel mainpanel,string username)
        {
            InitializeComponent();

            homePanelReference = mainpanel;
            employeename = username;
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Employee_Home employee_Home = new Employee_Home(homePanelReference, employeename); // Pass the homepanel control
            employee_Home.TopLevel = false;
            employee_Home.FormBorderStyle = FormBorderStyle.None;
            employee_Home.Dock = DockStyle.Fill;

            homePanelReference.Controls.Clear();
            homePanelReference.Controls.Add(employee_Home);

            employee_Home.Show();
        }

        private void lblcheckusername_Click(object sender, EventArgs e)
        {
            txtcheckhname.Text = employeename;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string username = txtUserName.Text;
            string useremail = txtEmail.Text;
            string userphoneno = txtPhoneNo.Text;

            if (this.txtUserName.Text.Length == 0 || this.txtEmail.Text.Length == 0 || this.txtPhoneNo.Text.Length == 0)
            {
                MessageBox.Show("You don't have permission to make null");
            }
            else
            {
                string query = "Update EmployeeInfo set Emp_Email='" + useremail + "',Emp_PhoneNo='" + userphoneno + "' where Emp_ID=" + employeeid;

                SqlCommand updateCommand = new SqlCommand(query);

                updateCommand.Parameters.AddWithValue("@employeeid", employeeid);
                updateCommand.Parameters.AddWithValue("@useremail", useremail);
                updateCommand.Parameters.AddWithValue("@userphoneno", userphoneno);

                int row = dBAccessLibrary.executeQuery(updateCommand);

                if (row >= 1)
                {
                    MessageBox.Show(" Information updated into table : " + employeeid);

                }
                else
                {
                    MessageBox.Show("Information updation failed: " + employeeid);
                }

                showDetails();

                this.txtUserName.Text = "";
                this.txtEmail.Text = "";
                this.txtPhoneNo.Text = "";
            }
        }

        public void showDetails()
        {
            try
            {

                SqlDataAdapter sda = new SqlDataAdapter("Select * from EmployeeInfo where (Emp_Name like '%" + employeename + "%')", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                dataGridView1.Rows.Clear();

                foreach (DataRow item in dt.Rows)
                {
                    int n = dataGridView1.Rows.Add();

                    dataGridView1.Rows[n].Cells[0].Value = item[0].ToString();
                    dataGridView1.Rows[n].Cells[1].Value = item[1].ToString();
                    dataGridView1.Rows[n].Cells[2].Value = item[2].ToString();
                    dataGridView1.Rows[n].Cells[3].Value = item[4].ToString();
                    dataGridView1.Rows[n].Cells[4].Value = item[5].ToString();

                    employeeid = Int32.Parse(item[0].ToString());
                }
               
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error in ShowInformation " + exp.ToString());
            }

        }

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            employeeid = Int32.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            txtUserName.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            txtEmail.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            txtPhoneNo.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
         
        }

        private void txtcheckhname_TextChanged(object sender, EventArgs e)
        {
            try
            {

                SqlDataAdapter sda = new SqlDataAdapter("Select * from EmployeeInfo where (Emp_Name like '%" + employeename + "%')", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                dataGridView1.Rows.Clear();

                foreach (DataRow item in dt.Rows)
                {
                    int n = dataGridView1.Rows.Add();

                    dataGridView1.Rows[n].Cells[0].Value = item[0].ToString();
                    dataGridView1.Rows[n].Cells[1].Value = item[1].ToString();
                    dataGridView1.Rows[n].Cells[2].Value = item[2].ToString();
                    dataGridView1.Rows[n].Cells[3].Value = item[4].ToString();
                    dataGridView1.Rows[n].Cells[4].Value = item[5].ToString();
                    
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error in search " + exp.ToString());
            }
        }

        private void btnDeleteAccount_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("1: Do you want to permanent delete?, Press = Yes. \n 2:No", " your delete operation ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
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


                    string query = "delete from EmployeeInfo where Emp_ID=" + employeeid;

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
