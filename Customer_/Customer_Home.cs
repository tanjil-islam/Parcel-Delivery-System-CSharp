using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcel_Delivery_Management_System
{

    public partial class Customer_Home : Form
    {
        private Panel homepanelReference;
        public string Customername;
        public Customer_Home(Panel mainpanel, string customername)
        {
            InitializeComponent();

            homepanelReference = mainpanel;
            Customername = customername;
        }

        private void btnNewDelivery_Click(object sender, EventArgs e)
        {
            Customer_New_Delivery customer_New_Delivery = new Customer_New_Delivery(homepanelReference, Customername); // Pass the homepanel control
            customer_New_Delivery.TopLevel = false;
            customer_New_Delivery.FormBorderStyle = FormBorderStyle.None;
            customer_New_Delivery.Dock = DockStyle.Fill;

            homepanelReference.Controls.Clear();
            homepanelReference.Controls.Add(customer_New_Delivery);

            customer_New_Delivery.Show();
        }

        private void btnMyDetails_Click(object sender, EventArgs e)
        {
            Customer_My_Details customer_My_Details = new Customer_My_Details(homepanelReference, Customername); // Pass the homepanel control
            customer_My_Details.TopLevel = false;
            customer_My_Details.FormBorderStyle = FormBorderStyle.None;
            customer_My_Details.Dock = DockStyle.Fill;

            homepanelReference.Controls.Clear();
            homepanelReference.Controls.Add(customer_My_Details);

            customer_My_Details.Show();
        }

        private void btnCancelOrder_Click(object sender, EventArgs e)
        {
            Customer_CancelOrder customer_CancelOrder = new Customer_CancelOrder(homepanelReference, Customername); // Pass the homepanel control
            customer_CancelOrder.TopLevel = false;
            customer_CancelOrder.FormBorderStyle = FormBorderStyle.None;
            customer_CancelOrder.Dock = DockStyle.Fill;

            homepanelReference.Controls.Clear();
            homepanelReference.Controls.Add(customer_CancelOrder);

            customer_CancelOrder.Show();
        }
    }
}
