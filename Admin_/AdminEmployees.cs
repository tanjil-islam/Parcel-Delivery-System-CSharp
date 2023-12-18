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
    public partial class AdminEmployees : Form
    {
        private Panel homePanelReference;

        string username;
        int userid;

        DBAccess dBAccessLibrary = new DBAccess();
        DataTable dtUser = new DataTable();
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-D76J3JK4\SQLEXPRESS;Initial Catalog=ParcelDeliveryManagement;Integrated Security=True");
        public AdminEmployees(Panel mainpanel)
        {
            InitializeComponent();
            homePanelReference = mainpanel;
        }

        private void txtSearchBook_TextChanged(object sender, EventArgs e)
        {
            try
            {

                SqlDataAdapter sda = new SqlDataAdapter("Select * from EmployeeInfo where (Emp_Name like '%" + txtSearchBook.Text + "%' or Emp_ID like '%" + txtSearchBook.Text + "%')", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                dataGridView1.Rows.Clear();

                foreach (DataRow item in dt.Rows)
                {
                    int n = dataGridView1.Rows.Add();

                    dataGridView1.Rows[n].Cells[0].Value = item[0].ToString();
                    dataGridView1.Rows[n].Cells[1].Value = item[1].ToString();
                    dataGridView1.Rows[n].Cells[2].Value = item[2].ToString();
                    dataGridView1.Rows[n].Cells[3].Value = item[3].ToString();
                    dataGridView1.Rows[n].Cells[4].Value = item[4].ToString();
                    dataGridView1.Rows[n].Cells[5].Value = item[5].ToString();
                   
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error in search " + exp.ToString());
            }
        }

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            userid = Int32.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            username= dataGridView1.SelectedRows[0].Cells[1].Value.ToString();

            txtUserName.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            txtEmail.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            txtPassword.Text= dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            txtPhoneNo.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            txtSalary.Text= dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
        }

        private void AdminEmployees_Load(object sender, EventArgs e)
        {
            showDetails();
        }

        public void showDetails()
        {
            try
            {

                SqlDataAdapter sda = new SqlDataAdapter("Select * from EmployeeInfo" , con);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                dataGridView1.Rows.Clear();

                foreach (DataRow item in dt.Rows)
                {
                    int n = dataGridView1.Rows.Add();

                    dataGridView1.Rows[n].Cells[0].Value = item[0].ToString();
                    dataGridView1.Rows[n].Cells[1].Value = item[1].ToString();
                    dataGridView1.Rows[n].Cells[2].Value = item[2].ToString();
                    dataGridView1.Rows[n].Cells[3].Value = item[3].ToString();
                    dataGridView1.Rows[n].Cells[4].Value = item[4].ToString();
                    dataGridView1.Rows[n].Cells[5].Value = item[5].ToString();
                }

            }
            catch (Exception exp)
            {
                MessageBox.Show("Error in ShowInformation " + exp.ToString());
            }

        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string Username = txtUserName.Text;
            string useremail = txtEmail.Text;
            string userphoneno = txtPhoneNo.Text;
            string userpassword = txtPassword.Text;
            string salary = txtSalary.Text;

            if (this.txtUserName.Text.Length == 0 || this.txtEmail.Text.Length == 0 || this.txtPhoneNo.Text.Length == 0 ||
                this.txtPassword.Text.Length==0 || this.txtSalary.Text.Length==0)
            {
                MessageBox.Show("You don't have permission to make null");
            }
            else
            {
                string query = "Update EmployeeInfo set Emp_Email='" + useremail + "'," +
                    "Emp_PhoneNo='" + userphoneno + "',Emp_Salary='"+salary+"' where Emp_ID=" + userid;

                SqlCommand updateCommand = new SqlCommand(query);

                updateCommand.Parameters.AddWithValue("@userid", userid);
                updateCommand.Parameters.AddWithValue("@useremail", useremail);
                updateCommand.Parameters.AddWithValue("@userphoneno", userphoneno);
                //updateCommand.Parameters.AddWithValue("@Username", Username);
                //updateCommand.Parameters.AddWithValue("@userpassword", userpassword);
                updateCommand.Parameters.AddWithValue("@salary", salary);

                int row = dBAccessLibrary.executeQuery(updateCommand);

                if (row >= 1)
                {
                    MessageBox.Show(" Information updated into table : " + Username);

                }
                else
                {
                    MessageBox.Show("Information updation failed: " + Username);
                }

                //showDetails();

                this.txtUserName.Text = "";
                this.txtEmail.Text = "";
                this.txtPhoneNo.Text = "";
                this.txtSalary.Text = "";
                this.txtPassword.Text = "";
                
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
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
                        MessageBox.Show(username + " Success account delete from UserInfo Table..... ");


                    }
                    else
                    {
                        MessageBox.Show(username + " Account deletion failed from UserInfo Table ");
                    }


                    string query = "delete from EmployeeInfo where Emp_ID=" + userid;

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

                    showDetails();
                    this.txtUserName.Text = "";
                    this.txtEmail.Text = "";
                    this.txtPhoneNo.Text = "";
                    this.txtPassword.Text = "";
                    this.txtSalary.Text = "";



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
