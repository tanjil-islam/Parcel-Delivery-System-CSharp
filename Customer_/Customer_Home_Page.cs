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
    public partial class Customer_Home_Page : Form
    {
        public string Customername;
        public Customer_Home_Page(string username)
        {
            InitializeComponent();
            Customername = username;
        }

        

        private void btnHome_Click(object sender, EventArgs e)
        {
            Customer_Home customer_Home = new Customer_Home(mainpanel, Customername); // Pass the homepanel control
            customer_Home.TopLevel = false;
            customer_Home.FormBorderStyle = FormBorderStyle.None;
            customer_Home.Dock = DockStyle.Fill;

            mainpanel.Controls.Clear();
            mainpanel.Controls.Add(customer_Home);

            customer_Home.Show();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private void lblname_Click(object sender, EventArgs e)
        {
            lblname.Text = "Welcome, " + Customername;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnTrackOrder_Click(object sender, EventArgs e)
        {
            Customer_TrackOrder customer_TrackOrder = new Customer_TrackOrder(mainpanel, Customername); // Pass the homepanel control
            customer_TrackOrder.TopLevel = false;
            customer_TrackOrder.FormBorderStyle = FormBorderStyle.None;
            customer_TrackOrder.Dock = DockStyle.Fill;

            mainpanel.Controls.Clear();
            mainpanel.Controls.Add(customer_TrackOrder);

            customer_TrackOrder.Show();
        }
    }
}
