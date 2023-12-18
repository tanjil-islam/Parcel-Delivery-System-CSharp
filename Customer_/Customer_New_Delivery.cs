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
    public partial class Customer_New_Delivery : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-D76J3JK4\SQLEXPRESS;Initial Catalog=ParcelDeliveryManagement;Integrated Security=True");

        DBAccess dBAccessLibrary = new DBAccess();
        DataTable dtUser = new DataTable();
        private Panel homepanelReference;
        public string Customername;
        public string charge;

        public Customer_New_Delivery(Panel mainpanel, string customername)
        {
            InitializeComponent();

            homepanelReference = mainpanel;
            Customername = customername;
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

        private void txtSearchPerson_TextChanged(object sender, EventArgs e)
        {

            try
            {

                SqlDataAdapter sda = new SqlDataAdapter("Select * from CustomerInfo where (Cust_Name like '%" + txtSearchPerson.Text + "%' or Cust_ID like '%" + txtSearchPerson.Text + "%')", con);
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

                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error in search " + exp.ToString());
            }
        }

        public void storeData()
        {

            string custName;
            string custID;
            string custPhoneNo;
            string apartmentNo;
            string streetAddress;
            string postalCode;
            string city;


            if (dataGridView1.SelectedRows.Count > 0 && dataGridView1.SelectedRows[0].Cells["Cust_Name"].Value.ToString().Length != 0)
            {
                // Accessing cell values and storing them in variables
                custName = dataGridView1.SelectedRows[0].Cells["Cust_Name"].Value.ToString();
                custID = dataGridView1.SelectedRows[0].Cells["Cust_ID"].Value.ToString();
                custPhoneNo = dataGridView1.SelectedRows[0].Cells["Cust_PhoneNo"].Value.ToString();
                apartmentNo = dataGridView1.SelectedRows[0].Cells["Apartment_No"].Value.ToString();
                streetAddress = dataGridView1.SelectedRows[0].Cells["Street_Address"].Value.ToString();
                postalCode = dataGridView1.SelectedRows[0].Cells["Postal_Code"].Value.ToString();
                city = dataGridView1.SelectedRows[0].Cells["City"].Value.ToString();


                SqlCommand insertCommand = new SqlCommand("insert into PendingOrderInfo(Cust_Name,Cust_ID,Cust_PhoneNo,Apartment_No,Street_Address,Postal_Code,City)" +
                    " values(@custName,@custID,@custPhoneNo,@apartmentNo,@streetAddress,@postalCode,@city)");

                insertCommand.Parameters.AddWithValue("@custName", custName);
                insertCommand.Parameters.AddWithValue("@custID", custID);
                insertCommand.Parameters.AddWithValue("@custPhoneNo", custPhoneNo);
                insertCommand.Parameters.AddWithValue("@apartmentNo", apartmentNo);
                insertCommand.Parameters.AddWithValue("@streetAddress", streetAddress);
                insertCommand.Parameters.AddWithValue("@postalCode", postalCode);
                insertCommand.Parameters.AddWithValue("@city", city);


                int row = dBAccessLibrary.executeQuery(insertCommand);

                if (row >= 1)
                {
                    MessageBox.Show(row + " Number of Order inserted into table : " + custName);

                }
                else
                {
                    MessageBox.Show("User Registration failed with Customer Name: " + custName);
                }


                SqlCommand insertCommandPayment = new SqlCommand("insert into PaymentDetails(Cust_ID,Payment_amount)" +
                   " values(@custID,@charge)");

                insertCommandPayment.Parameters.AddWithValue("@custID", custID);
                insertCommandPayment.Parameters.AddWithValue("@charge", charge);
            }
        }

        private void lblCalculateAmount_Click(object sender, EventArgs e)
        {
            string shipmenttype = ComShipmentType.Text.ToString();
            if (shipmenttype == "Document")
            {
                txtAmountPay.Text = "100";
            }
            else
            {
                if (txtWeight.Text.Length != 0)
                {
                    string s = txtWeight.Text;
                    double taka = Convert.ToDouble(s);
                    taka = taka * 100;
                    string v = taka.ToString();
                    txtAmountPay.Text = v;
                    charge = v;
                }

            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (txtWeight.Text.Length == 0 || dataGridView1.SelectedRows.Count < 1 || ComShipmentType.Text.ToString().Length == 0 || dataGridView1.SelectedRows[0].Cells[0] == null || dataGridView1.SelectedRows[0].Cells[0].Value == null)
            {
                MessageBox.Show("Please give your information correctly");
            }
            else
            {
                storeData();
                Customer_Order_Confirm customer_order_confirm = new Customer_Order_Confirm(homepanelReference); // Pass the homepanel control
                customer_order_confirm.TopLevel = false;
                customer_order_confirm.FormBorderStyle = FormBorderStyle.None;
                customer_order_confirm.Dock = DockStyle.Fill;

                homepanelReference.Controls.Clear();
                homepanelReference.Controls.Add(customer_order_confirm);

                customer_order_confirm.Show();
            }
        }
    }
}
