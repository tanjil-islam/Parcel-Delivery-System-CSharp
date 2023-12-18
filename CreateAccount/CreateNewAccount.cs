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
    public partial class CreateNewAccount : Form
    {
        public CreateNewAccount()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (RaAdmin.Checked == true)
            {
                this.Hide();
                AdminCreateAccount adminnewaccount = new AdminCreateAccount();
                adminnewaccount.Show();
            }
            else if (RaEmployee.Checked == true)
            {
                this.Hide();
                EmployeeCreateAccount employeenewaccount = new EmployeeCreateAccount();
                employeenewaccount.Show();
            }
            else if (RaCustomer.Checked == true)
            {
                this.Hide();
                CustomerCreateAccount customernewaccount = new CustomerCreateAccount();
                customernewaccount.Show();

            }
        }

        private void lblBackPreviousPage_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }
    }
}
