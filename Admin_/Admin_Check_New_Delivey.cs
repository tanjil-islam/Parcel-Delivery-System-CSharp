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
    public partial class Admin_Check_New_Delivey : Form
    {
        private Panel homePanelReference;
        string username;

        DBAccess dBAccessLibrary = new DBAccess();
        DataTable dtUser = new DataTable();
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-D76J3JK4\SQLEXPRESS;Initial Catalog=ParcelDeliveryManagement;Integrated Security=True");
        public Admin_Check_New_Delivey(Panel mainpanel,string name)
        {
            InitializeComponent();

            homePanelReference = mainpanel;
            username = name;
        }

        private void Admin_Check_New_Delivey_Load(object sender, EventArgs e)
        {
            try
            {

                SqlDataAdapter sda = new SqlDataAdapter("Select * from CompleteOrdersInfo", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                dataGridView1.Rows.Clear();

                foreach (DataRow item in dt.Rows)
                {
                    int n = dataGridView1.Rows.Add();

                    dataGridView1.Rows[n].Cells[0].Value = item[0].ToString();
                    dataGridView1.Rows[n].Cells[1].Value = item[6].ToString();
                    dataGridView1.Rows[n].Cells[2].Value = item[1].ToString();
                    dataGridView1.Rows[n].Cells[3].Value = item[2].ToString();
                    dataGridView1.Rows[n].Cells[4].Value = item[3].ToString();
                    dataGridView1.Rows[n].Cells[5].Value = item[4].ToString();
                    dataGridView1.Rows[n].Cells[6].Value = item[5].ToString();
                    dataGridView1.Rows[n].Cells[7].Value = item[7].ToString();

                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error in search " + exp.ToString());
            }
        }

        private void Back_Click(object sender, EventArgs e)
        {
            AdminHome adminHome = new AdminHome(homePanelReference, username); // Pass the homepanel control
            adminHome.TopLevel = false;
            adminHome.FormBorderStyle = FormBorderStyle.None;
            adminHome.Dock = DockStyle.Fill;

            homePanelReference.Controls.Clear();
            homePanelReference.Controls.Add(adminHome);

            adminHome.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "SELECT COUNT(*) FROM TransitOrdersInfo ";

                try
                {
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }

                    using (SqlCommand command = new SqlCommand(query, con))
                    {


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

        private void txtSearchPerson_TextChanged(object sender, EventArgs e)
        {
            try
            {

                SqlDataAdapter sda = new SqlDataAdapter("Select * from TransitOrdersInfo where (Cust_Name like '%" + txtSearchPerson.Text + "%' " +
                    "or Cust_ID like '%" + txtSearchPerson.Text + "%' or Order_ID like '%" + txtSearchPerson.Text + "%')", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                dataGridView1.Rows.Clear();

                foreach (DataRow item in dt.Rows)
                {
                    int n = dataGridView1.Rows.Add();

                    dataGridView1.Rows[n].Cells[0].Value = item[0].ToString();
                    dataGridView1.Rows[n].Cells[1].Value = item[6].ToString();
                    dataGridView1.Rows[n].Cells[2].Value = item[1].ToString();
                    dataGridView1.Rows[n].Cells[3].Value = item[2].ToString();
                    dataGridView1.Rows[n].Cells[4].Value = item[3].ToString();
                    dataGridView1.Rows[n].Cells[5].Value = item[4].ToString();
                    dataGridView1.Rows[n].Cells[6].Value = item[5].ToString();
                    dataGridView1.Rows[n].Cells[7].Value = item[7].ToString();

                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error in search " + exp.ToString());
            }
        }
    }
}
