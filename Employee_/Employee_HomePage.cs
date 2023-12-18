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
    public partial class Employee_HomePage : Form
    {
        public string employeename;
        public Employee_HomePage(string username)
        {
            InitializeComponent();
            employeename = username;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Employee_Home employee_Home = new Employee_Home(mainpanel, employeename); // Pass the homepanel control
            employee_Home.TopLevel = false;
            employee_Home.FormBorderStyle = FormBorderStyle.None;
            employee_Home.Dock = DockStyle.Fill;

            mainpanel.Controls.Clear();
            mainpanel.Controls.Add(employee_Home);

            employee_Home.Show();
        }

        private void lblname_Click(object sender, EventArgs e)
        {
            lblname.Text = "Welcome, " + employeename;
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
