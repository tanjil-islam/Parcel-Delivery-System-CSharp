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
    public partial class Employee_Home : Form
    {
        string employeename;
        private Panel homePanelReference;
        public Employee_Home(Panel mainpanel,string username)
        {
            InitializeComponent();

            homePanelReference = mainpanel;
            employeename = username;
        }

        private void btnMyDetails_Click(object sender, EventArgs e)
        {
            Employee_MyDetails employee_MyDetails = new Employee_MyDetails(homePanelReference, employeename); // Pass the homepanel control
            employee_MyDetails.TopLevel = false;
            employee_MyDetails.FormBorderStyle = FormBorderStyle.None;
            employee_MyDetails.Dock = DockStyle.Fill;

            homePanelReference.Controls.Clear();
            homePanelReference.Controls.Add(employee_MyDetails);

            employee_MyDetails.Show();
        }

        private void btnNewDelivery_Click(object sender, EventArgs e)
        {
            Employee_AddNewOrder employee_AddNewOrder = new Employee_AddNewOrder(homePanelReference, employeename); // Pass the homepanel control
            employee_AddNewOrder.TopLevel = false;
            employee_AddNewOrder.FormBorderStyle = FormBorderStyle.None;
            employee_AddNewOrder.Dock = DockStyle.Fill;

            homePanelReference.Controls.Clear();
            homePanelReference.Controls.Add(employee_AddNewOrder);

            employee_AddNewOrder.Show();
        }

        private void btnComplete_Click(object sender, EventArgs e)
        {
            Employee_CompleteOrder employee_CompleteOrder = new Employee_CompleteOrder(homePanelReference, employeename); // Pass the homepanel control
            employee_CompleteOrder.TopLevel = false;
            employee_CompleteOrder.FormBorderStyle = FormBorderStyle.None;
            employee_CompleteOrder.Dock = DockStyle.Fill;

            homePanelReference.Controls.Clear();
            homePanelReference.Controls.Add(employee_CompleteOrder);

            employee_CompleteOrder.Show();
        }
    }
}
