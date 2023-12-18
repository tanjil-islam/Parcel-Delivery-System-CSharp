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
    public partial class Admin_Approval : Form
    {
        private Panel homepanelReference;

        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-D76J3JK4\SQLEXPRESS;Initial Catalog=ParcelDeliveryManagement;Integrated Security=True");
        DBAccess dBAccessLibrary = new DBAccess();
        DataTable dtUser = new DataTable();

        public Admin_Approval(Panel mainpanel)
        {
            InitializeComponent();

            homepanelReference = mainpanel;
        }

        private void Admin_Approval_Load(object sender, EventArgs s)
        {
            showDetails();
        }

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtUsername.Text = dataGridView1.Rows[0].Cells[0].Value.ToString();
            txtPassword.Text = dataGridView1.Rows[0].Cells[1].Value.ToString();
            txtRole.Text = dataGridView1.Rows[0].Cells[1].Value.ToString();
        }

        private void txtSearchPerson_TextChanged(object sender, EventArgs e)
        {
            try
            {

                SqlDataAdapter sda = new SqlDataAdapter("Select * from ApprovalList where (UserName like '%" + txtSearchPerson.Text + "%' " +
                    "or Role like '%" + txtSearchPerson.Text + "%')", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                dataGridView1.Rows.Clear();

                foreach (DataRow item in dt.Rows)
                {
                    int n = dataGridView1.Rows.Add();

                    dataGridView1.Rows[n].Cells[0].Value = item[0].ToString();
                    dataGridView1.Rows[n].Cells[1].Value = item[1].ToString();
                    dataGridView1.Rows[n].Cells[2].Value = item[2].ToString();

                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error in search " + exp.ToString());
            }
        }

        public void showDetails()
        {
            try
            {

                SqlDataAdapter sda = new SqlDataAdapter("Select * from ApprovalList", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                dataGridView1.Rows.Clear();

                foreach (DataRow item in dt.Rows)
                {
                    int n = dataGridView1.Rows.Add();
                    dataGridView1.Rows[n].Cells[0].Value = item[0].ToString();
                    dataGridView1.Rows[n].Cells[1].Value = item[1].ToString();
                    dataGridView1.Rows[n].Cells[2].Value = item[2].ToString();
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error in ShowInformation " + exp.ToString());
            }

        }

        private void Approve_Click(object sender, EventArgs e)
        {
            string username;
            string role;
            string password;
            

            if (dataGridView1.SelectedRows.Count > 0 && dataGridView1.SelectedRows[0].Cells["UserName"].Value.ToString().Length != 0)
            {
                username = dataGridView1.SelectedRows[0].Cells["UserName"].Value.ToString();
                password = dataGridView1.SelectedRows[0].Cells["Password"].Value.ToString();
                role = dataGridView1.SelectedRows[0].Cells["Role"].Value.ToString();


                try
                {
                    using (SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-D76J3JK4\SQLEXPRESS;Initial Catalog=ParcelDeliveryManagement;Integrated Security=True"))
                    {
                        con.Open();


                        using (SqlCommand insertCommand = new SqlCommand("INSERT INTO UserInfo(UserName, Password, Role) VALUES (@username, @password, @role)", con))
                        {
                            insertCommand.Parameters.AddWithValue("@username", username);
                            insertCommand.Parameters.AddWithValue("@password", password);
                            insertCommand.Parameters.AddWithValue("@role", role);

                            int row = insertCommand.ExecuteNonQuery();

                            if (row > 0)
                            {
                                MessageBox.Show("Successfully Added " + username+ " as a"+role);
                            }
                            else
                            {
                                MessageBox.Show("Failed to add " + username);
                            }
                        }

                        using (SqlCommand deleteCommand = new SqlCommand("DELETE FROM ApprovalList WHERE Username = @username", con))
                        {
                            deleteCommand.Parameters.AddWithValue("@username", username);

                            int row = deleteCommand.ExecuteNonQuery();

                            if (row > 0)
                            {
                                MessageBox.Show("Congratulation now Active this account");
                            }
                            else
                            {
                                MessageBox.Show("! Failed to active... ");
                            }
                        }   

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                

                 txtUsername.Text = "";
                 txtRole.Text = "";
                 txtPassword.Text = "";
                 
                showDetails();

            }
        }

        private void btnDecline_Click(object sender, EventArgs e)
        {
            string username;
            string role;
            string password;


            if (dataGridView1.SelectedRows.Count > 0 && dataGridView1.SelectedRows[0].Cells["UserName"].Value.ToString().Length != 0)
            {
                username = dataGridView1.SelectedRows[0].Cells["UserName"].Value.ToString();
                password = dataGridView1.SelectedRows[0].Cells["Password"].Value.ToString();
                role = dataGridView1.SelectedRows[0].Cells["Role"].Value.ToString();


                try
                {
                    using (SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-D76J3JK4\SQLEXPRESS;Initial Catalog=ParcelDeliveryManagement;Integrated Security=True"))
                    {
                        con.Open();
                   
                        using (SqlCommand deleteCommand = new SqlCommand("DELETE FROM ApprovalList WHERE Username = @username", con))
                        {
                            deleteCommand.Parameters.AddWithValue("@username", username);

                            int row = deleteCommand.ExecuteNonQuery();

                            if (row > 0)
                            {
                                MessageBox.Show("This account decline successfully");
                            }
                            else
                            {
                                MessageBox.Show("! Failed to decline... ");
                            }
                        }

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }


                txtUsername.Text = "";
                txtRole.Text = "";
                txtPassword.Text = "";

                showDetails();

            }
        }
    }
}
