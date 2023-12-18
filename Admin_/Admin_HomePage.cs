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
    public partial class Admin_HomePage : Form
    {
        public string adminName;
        public Admin_HomePage(string username)
        {
            InitializeComponent();

            adminName = username;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            AdminHome adminHome = new AdminHome(mainpanel,adminName); // Pass the homepanel control
            adminHome.TopLevel = false;
            adminHome.FormBorderStyle = FormBorderStyle.None;
            adminHome.Dock = DockStyle.Fill;

            mainpanel.Controls.Clear();
            mainpanel.Controls.Add(adminHome);

            adminHome.Show();
        }

        private void btnTrackOrder_Click(object sender, EventArgs e)
        {
            AdminTrackOrder adminTrackOrder = new AdminTrackOrder(mainpanel,adminName); // Pass the homepanel control
            adminTrackOrder.TopLevel = false;
            adminTrackOrder.FormBorderStyle = FormBorderStyle.None;
            adminTrackOrder.Dock = DockStyle.Fill;

            mainpanel.Controls.Clear();
            mainpanel.Controls.Add(adminTrackOrder);

            adminTrackOrder.Show();
        }

        private void btnEmployees_Click(object sender, EventArgs e)
        {
            AdminEmployees adminEmployees = new AdminEmployees(mainpanel); // Pass the homepanel control
            adminEmployees.TopLevel = false;
            adminEmployees.FormBorderStyle = FormBorderStyle.None;
            adminEmployees.Dock = DockStyle.Fill;

            mainpanel.Controls.Clear();
            mainpanel.Controls.Add(adminEmployees);

            adminEmployees.Show();
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            AdminCustomers adminCustomers = new AdminCustomers(mainpanel); // Pass the homepanel control
            adminCustomers.TopLevel = false;
            adminCustomers.FormBorderStyle = FormBorderStyle.None;
            adminCustomers.Dock = DockStyle.Fill;

            mainpanel.Controls.Clear();
            mainpanel.Controls.Add(adminCustomers);

            adminCustomers.Show();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            AdminAdmin adminAdmin = new AdminAdmin(mainpanel); // Pass the homepanel control
            adminAdmin.TopLevel = false;
            adminAdmin.FormBorderStyle = FormBorderStyle.None;
            adminAdmin.Dock = DockStyle.Fill;

            mainpanel.Controls.Clear();
            mainpanel.Controls.Add(adminAdmin);

            adminAdmin.Show();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private void lblname_Click(object sender, EventArgs e)
        {
            lblname.Text = "Welcome, "+adminName;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnApproval_Click(object sender, EventArgs e)
        {
            Admin_Approval admin_Approval = new Admin_Approval(mainpanel); // Pass the homepanel control
            admin_Approval.TopLevel = false;
            admin_Approval.FormBorderStyle = FormBorderStyle.None;
            admin_Approval.Dock = DockStyle.Fill;

            mainpanel.Controls.Clear();
            mainpanel.Controls.Add(admin_Approval);

            admin_Approval.Show();
        }
    }
}
