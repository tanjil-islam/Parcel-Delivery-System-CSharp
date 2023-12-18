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
    public partial class Employee_AddNewOrder : Form
    {

        string employeename;
        private Panel homePanelReference;

        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-D76J3JK4\SQLEXPRESS;Initial Catalog=ParcelDeliveryManagement;Integrated Security=True");

        DBAccess dBAccessLibrary = new DBAccess();
        DataTable dtUser = new DataTable();

        public Employee_AddNewOrder(Panel mainpanel,string username)
        {
            InitializeComponent();

            homePanelReference = mainpanel;
            employeename = username;
        }

        public void showDetails()
        {
            try
            {

                SqlDataAdapter sda = new SqlDataAdapter("Select * from PendingOrderInfo", con);
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
                    dataGridView1.Rows[n].Cells[7].Value = item[8].ToString();
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error in ShowInformation " + exp.ToString());
            }

        }

        private void txtSearchPerson_TextChanged(object sender, EventArgs e)
        {
            try
            {

                SqlDataAdapter sda = new SqlDataAdapter("Select * from PendingOrderInfo where (Cust_Name like '%" + txtSearchPerson.Text + "%' " +
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
                    dataGridView1.Rows[n].Cells[7].Value = item[8].ToString();

                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error in search " + exp.ToString());
            }
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

        int orderid;
        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            orderid = Int32.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());

            txtOrderID.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            txtUserName.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            txtCustomerID .Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            txtPhoneNo.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            txtApartmentNo.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            txtPostalCode.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            txtStreetAddress.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            txtCity.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();

        }

        private void btnAddToDelivery_Click(object sender, EventArgs e)
        {
            string custName;
            int custID;
            string custPhoneNo;
            string apartmentNo;
            string streetAddress;
            string postalCode;
            string city;
            int orderID;

            if (dataGridView1.SelectedRows.Count > 0 && dataGridView1.SelectedRows[0].Cells["Cust_Name"].Value.ToString().Length != 0)
            {
                custName = dataGridView1.SelectedRows[0].Cells["Cust_Name"].Value.ToString();
                custID = Int32.Parse(dataGridView1.SelectedRows[0].Cells["Cust_ID"].Value.ToString());
                orderID = Int32.Parse(dataGridView1.SelectedRows[0].Cells["Order_ID"].Value.ToString());
                custPhoneNo = dataGridView1.SelectedRows[0].Cells["Cust_PhoneNo"].Value.ToString();
                apartmentNo = dataGridView1.SelectedRows[0].Cells["Apartment_No"].Value.ToString();
                streetAddress = dataGridView1.SelectedRows[0].Cells["Street_Address"].Value.ToString();
                postalCode = dataGridView1.SelectedRows[0].Cells["Postal_Code"].Value.ToString();
                city = dataGridView1.SelectedRows[0].Cells["City"].Value.ToString();

                TransitOrder transitOrder = new TransitOrder
                {
                    CustName = custName,
                    CustID = custID,
                    OrderID = orderID,
                    CustPhoneNo = custPhoneNo,
                    ApartmentNo = apartmentNo,
                    StreetAddress = streetAddress,
                    PostalCode = postalCode,
                    City = city
                };

                int rowsAffected = transitOrder.AddToTransit();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Number of orders inserted into Transit: " + custName);
                }
                else
                {
                    MessageBox.Show("Failed to add order to Transit: " + custName);
                }

                txtOrderID.Text ="";
                txtUserName.Text = "";
                txtCustomerID.Text = "";
                txtPhoneNo.Text = "";
                txtApartmentNo.Text = "";
                txtPostalCode.Text = "";
                txtStreetAddress.Text = "";
                txtCity.Text = "";

                showDetails();

            }
        }
    }
}
