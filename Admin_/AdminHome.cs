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
    public partial class AdminHome : Form
    {
        private Panel homePanelReference;
        string adminName;
        public AdminHome(Panel mainpanel,string username)
        {
            InitializeComponent();
            homePanelReference = mainpanel;
            adminName = username;
    }

        

        private void button11_Click_1(object sender, EventArgs e)
        {
            Admin_Check_New_Delivey adminHome = new Admin_Check_New_Delivey(mainpanel,adminName); // Pass the homepanel control
            adminHome.TopLevel = false;
            adminHome.FormBorderStyle = FormBorderStyle.None;
            adminHome.Dock = DockStyle.Fill;

            mainpanel.Controls.Clear();
            mainpanel.Controls.Add(adminHome);

            adminHome.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Admin_CheckCancelOrder admin_CheckCancelOrder = new Admin_CheckCancelOrder(mainpanel,adminName); // Pass the homepanel control
            admin_CheckCancelOrder.TopLevel = false;
            admin_CheckCancelOrder.FormBorderStyle = FormBorderStyle.None;
            admin_CheckCancelOrder.Dock = DockStyle.Fill;

            mainpanel.Controls.Clear();
            mainpanel.Controls.Add(admin_CheckCancelOrder);

            admin_CheckCancelOrder.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Admin_MyDetails admin_MyDetails = new Admin_MyDetails(mainpanel, adminName); // Pass the homepanel control
            admin_MyDetails.TopLevel = false;
            admin_MyDetails.FormBorderStyle = FormBorderStyle.None;
            admin_MyDetails.Dock = DockStyle.Fill;

            mainpanel.Controls.Clear();
            mainpanel.Controls.Add(admin_MyDetails);

            admin_MyDetails.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Admin_CheckCompleteOrder admin_CheckCompleteOrder = new Admin_CheckCompleteOrder(mainpanel,adminName); // Pass the homepanel control
            admin_CheckCompleteOrder.TopLevel = false;
            admin_CheckCompleteOrder.FormBorderStyle = FormBorderStyle.None;
            admin_CheckCompleteOrder.Dock = DockStyle.Fill;

            mainpanel.Controls.Clear();
            mainpanel.Controls.Add(admin_CheckCompleteOrder);

            admin_CheckCompleteOrder.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            AdminTrackOrder adminTrackOrder = new AdminTrackOrder(mainpanel,adminName); // Pass the homepanel control
            adminTrackOrder.TopLevel = false;
            adminTrackOrder.FormBorderStyle = FormBorderStyle.None;
            adminTrackOrder.Dock = DockStyle.Fill;

            mainpanel.Controls.Clear();
            mainpanel.Controls.Add(adminTrackOrder);

            adminTrackOrder.Show();
        }
    }
}
