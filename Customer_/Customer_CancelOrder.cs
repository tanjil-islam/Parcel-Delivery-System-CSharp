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
    public partial class Customer_CancelOrder : Form
    {
        private Panel homepanelReference;
        public string Customername;

        DBAccess dBAccessLibrary = new DBAccess();
        DataTable dtUser = new DataTable();
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-D76J3JK4\SQLEXPRESS;Initial Catalog=ParcelDeliveryManagement;Integrated Security=True");

        public Customer_CancelOrder(Panel mainpanel,string customername)
        {
            InitializeComponent();

            homepanelReference = mainpanel;
            Customername = customername;
        }

        private void txtcheckhname_TextChanged(object sender, EventArgs e)
        {
            try
            {

                SqlDataAdapter sda = new SqlDataAdapter("Select * from PendingOrderInfo where  (Cust_Name like '%" + Customername + "%')", con);
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

        private void lblcheckusername_Click(object sender, EventArgs e)
        {
            txtcheckhname.Text = Customername;
        }

        public void showDetails()
        {
            try
            {

                SqlDataAdapter sda = new SqlDataAdapter("Select * from PendingOrderInfo where  (Cust_Name like '%" + Customername + "%')", con);
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
            Customer_Home customer_Home = new Customer_Home(homepanelReference, Customername); // Pass the homepanel control
            customer_Home.TopLevel = false;
            customer_Home.FormBorderStyle = FormBorderStyle.None;
            customer_Home.Dock = DockStyle.Fill;

            homepanelReference.Controls.Clear();
            homepanelReference.Controls.Add(customer_Home);

            customer_Home.Show();
        }

        int orderid;
        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            orderid = Int32.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());

            txtOrderID.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            txtUserName.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            txtCustomerID.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            txtPhoneNo.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            txtApartmentNo.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            txtPostalCode.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            txtStreetAddress.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            txtCity.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
        }

        private void btnCancelOrder_Click(object sender, EventArgs e)
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
                orderID = Int32.Parse(dataGridView1.SelectedRows[0].Cells["Order_ID"].Value.ToString());
                CancelOrder cancelOrder = new CancelOrder
                {
                    CustName = dataGridView1.SelectedRows[0].Cells["Cust_Name"].Value.ToString(),
                    CustID = Int32.Parse(dataGridView1.SelectedRows[0].Cells["Cust_ID"].Value.ToString()),
                    OrderID = Int32.Parse(dataGridView1.SelectedRows[0].Cells["Order_ID"].Value.ToString()),
                    
                    CustPhoneNo = dataGridView1.SelectedRows[0].Cells["Cust_PhoneNo"].Value.ToString(),
                    ApartmentNo = dataGridView1.SelectedRows[0].Cells["Apartment_No"].Value.ToString(),
                    StreetAddress = dataGridView1.SelectedRows[0].Cells["Street_Address"].Value.ToString(),
                    PostalCode = dataGridView1.SelectedRows[0].Cells["Postal_Code"].Value.ToString(),
                    City = dataGridView1.SelectedRows[0].Cells["City"].Value.ToString()
                };

                int rowsAffected = cancelOrder.CancelOrderOperation();

            if (rowsAffected > 0)
            {
                MessageBox.Show("Your Cancel was successful for " + cancelOrder.CustName);              
            }
            else
            {
                MessageBox.Show("Failed to cancel order for " + cancelOrder.CustName);
            }


                txtOrderID.Text = "";
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
