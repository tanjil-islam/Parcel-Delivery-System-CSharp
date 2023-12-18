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
    public partial class Customer_Order_Confirm : Form
    {
        private Panel homePanelReference;
        public string Customername;
        public Customer_Order_Confirm(Panel mainpanel)
        {
            InitializeComponent();
            homePanelReference = mainpanel;
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Customer_New_Delivery customer_New_Delivery = new Customer_New_Delivery(homePanelReference, Customername); // Pass the homepanel control
            customer_New_Delivery.TopLevel = false;
            customer_New_Delivery.FormBorderStyle = FormBorderStyle.None;
            customer_New_Delivery.Dock = DockStyle.Fill;

            homePanelReference.Controls.Clear();
            homePanelReference.Controls.Add(customer_New_Delivery);

            customer_New_Delivery.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Customer_Home customer_Home = new Customer_Home(homePanelReference, Customername); // Pass the homepanel control
            customer_Home.TopLevel = false;
            customer_Home.FormBorderStyle = FormBorderStyle.None;
            customer_Home.Dock = DockStyle.Fill;

            homePanelReference.Controls.Clear();
            homePanelReference.Controls.Add(customer_Home);

            customer_Home.Show();
        }
    }
}
