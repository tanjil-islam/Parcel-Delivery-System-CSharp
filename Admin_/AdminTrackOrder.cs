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
    public partial class AdminTrackOrder : Form
    {
        private Panel homePanelReference;
        string adminName;


        DBAccess dBAccessLibrary = new DBAccess();
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-D76J3JK4\SQLEXPRESS;Initial Catalog=ParcelDeliveryManagement;Integrated Security=True");
        public AdminTrackOrder(Panel mainpanel,string username)
        {
            InitializeComponent();

            homePanelReference = mainpanel;
            adminName = username;
        }

        private void txtSearchOrderID_TextChanged(object sender, EventArgs e)
        {
            txtBooked.Text = "";
            txtInTransit.Text = "";
            txtDeliverd.Text = "";

            string order = txtSearchOrderID.Text;
            int orderID;

            if (txtSearchOrderID.Text.Length == 0)
            {
                return;
            }

            if (int.TryParse(order, out orderID))
            {
                int x = 0;
                try
                {
                    con.Open();

                    
                    string[] tables = { "PendingOrderInfo", "TransitOrdersInfo", "CompleteOrdersInfo" };

                    foreach (string tableName in tables)
                    {
                        string query = $"SELECT Order_ID FROM {tableName} WHERE Order_ID = @orderID";
                        SqlCommand command = new SqlCommand(query, con);
                        command.Parameters.AddWithValue("@orderID", orderID);

                        SqlDataReader reader = command.ExecuteReader();

                        if (reader.HasRows)
                        {
                            switch (tableName)
                            {
                                case "PendingOrderInfo":
                                    txtBooked.Text = "✔";
                                    break;

                                case "TransitOrdersInfo":
                                    txtBooked.Text = "✔";
                                    txtInTransit.Text = "✔";
                                    break;

                                case "CompleteOrdersInfo":
                                    txtBooked.Text = "✔";
                                    txtInTransit.Text = "✔";
                                    txtDeliverd.Text = "✔";
                                    break;
                            }

                            reader.Close();
                            break; 
                        }

                        reader.Close();
                    }

                    if (txtBooked.Text == "" && txtInTransit.Text == "" && txtDeliverd.Text == "")
                    {
                        MessageBox.Show("This is not a valid Order ID. Please provide a valid Order ID. Thank you");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    // txtSearchOrderID.Text = "";
                    if (con.State == ConnectionState.Open)
                    {
                        con.Close();
                    }
                }

            }
            else
            {
                MessageBox.Show("Please provide a valid Order ID (numeric value).");
            }
        }

        private void Back_Click(object sender, EventArgs e)
        {
            
        }

        private void Back_Click_1(object sender, EventArgs e)
        {
            AdminHome adminHome = new AdminHome(homePanelReference, adminName); // Pass the homepanel control
            adminHome.TopLevel = false;
            adminHome.FormBorderStyle = FormBorderStyle.None;
            adminHome.Dock = DockStyle.Fill;

            homePanelReference.Controls.Clear();
            homePanelReference.Controls.Add(adminHome);

            adminHome.Show();
        }
    }
}
