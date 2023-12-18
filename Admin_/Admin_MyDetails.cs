﻿using System;
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
    public partial class Admin_MyDetails : Form
    {
        private Panel homePanelReference;
        string adminName;
        int adminid;

        DBAccess dBAccessLibrary = new DBAccess();
        DataTable dtUser = new DataTable();
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-D76J3JK4\SQLEXPRESS;Initial Catalog=ParcelDeliveryManagement;Integrated Security=True");

        public Admin_MyDetails(Panel mainpanel,string username)
        {
            InitializeComponent();

            homePanelReference = mainpanel;
            adminName = username;
        }

        private void lblcheckusername_Click(object sender, EventArgs e)
        {
            txtcheckhname.Text = adminName;
        }
        
        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
            adminid = Int32.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            txtUserName.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            txtEmail.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
            txtPhoneNo.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            txtApartmentNo.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            txtPostalCode.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            txtStreetAddress.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            txtCity.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string username = txtUserName.Text;
            string useremail = txtEmail.Text;
            string userphoneno = txtPhoneNo.Text;
            string apartmentno = txtApartmentNo.Text;
            string postalcode = txtPostalCode.Text;
            string streetaddress = txtStreetAddress.Text;
            string city = txtCity.Text;
            string sure = useremail;

            if (this.txtUserName.Text.Length == 0 || this.txtEmail.Text.Length == 0 || this.txtPhoneNo.Text.Length == 0 ||
                this.txtApartmentNo.Text.Length == 0 || this.txtPostalCode.Text.Length == 0 || this.txtStreetAddress.Text.Length == 0
                || this.txtCity.Text.Length == 0)
            {
                MessageBox.Show("You don't have permission to make null");
            }
            else
            {
                string query = "Update AdminInfo set Admin_email='" + useremail + "',Admin_PhoneNo='" + userphoneno + "',Apartment_No='"
                    + apartmentno + "',Postal_Code='" + postalcode + "',Street_Address='" + streetaddress + "',City='" + city + "' where Admin_ID=" + adminid;

                SqlCommand updateCommand = new SqlCommand(query);

                updateCommand.Parameters.AddWithValue("@adminid", adminid);
                updateCommand.Parameters.AddWithValue("@useremail", useremail);
                updateCommand.Parameters.AddWithValue("@userphoneno", userphoneno);
                updateCommand.Parameters.AddWithValue("@apartmentno", apartmentno);
                updateCommand.Parameters.AddWithValue("@postalcode", postalcode);
                updateCommand.Parameters.AddWithValue("@streetaddress", streetaddress);
                updateCommand.Parameters.AddWithValue("@city", city);




                int row = dBAccessLibrary.executeQuery(updateCommand);

                if (row >= 1)
                {
                    MessageBox.Show(" Information updated into table : " + adminName);

                }
                else
                {
                    MessageBox.Show("Information updation failed: " + adminName);
                }

                showDetails();

                this.txtUserName.Text = "";
                this.txtEmail.Text = "";
                this.txtPhoneNo.Text = "";
                this.txtApartmentNo.Text = "";
                this.txtPostalCode.Text = "";
                this.txtStreetAddress.Text = "";
                this.txtCity.Text = "";
            }
        }

        public void showDetails()
        {
            try
            {

                SqlDataAdapter sda = new SqlDataAdapter("Select * from AdminInfo where (Admin_Name like '%" + adminName + "%')", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                dataGridView1.Rows.Clear();

                foreach (DataRow item in dt.Rows)
                {
                    int n = dataGridView1.Rows.Add();

                    dataGridView1.Rows[n].Cells[0].Value = item[0].ToString();
                    dataGridView1.Rows[n].Cells[1].Value = item[1].ToString();
                    dataGridView1.Rows[n].Cells[2].Value = item[3].ToString();
                    dataGridView1.Rows[n].Cells[3].Value = item[9].ToString();
                    dataGridView1.Rows[n].Cells[4].Value = item[10].ToString();
                    dataGridView1.Rows[n].Cells[5].Value = item[11].ToString();
                    dataGridView1.Rows[n].Cells[6].Value = item[12].ToString();
                    dataGridView1.Rows[n].Cells[7].Value = item[2].ToString();

                    adminid = Int32.Parse(item[0].ToString());
                }
                
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error in ShowInformation " + exp.ToString());
            }

        }

        private void txtcheckhname_TextChanged(object sender, EventArgs e)
        {

            try
            {

                SqlDataAdapter sda = new SqlDataAdapter("Select * from AdminInfo where (Admin_Name like '%" + adminName + "%')", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                dataGridView1.Rows.Clear();

                foreach (DataRow item in dt.Rows)
                {
                    int n = dataGridView1.Rows.Add();

                    dataGridView1.Rows[n].Cells[0].Value = item[0].ToString();
                    dataGridView1.Rows[n].Cells[1].Value = item[1].ToString();
                    dataGridView1.Rows[n].Cells[2].Value = item[3].ToString();
                    dataGridView1.Rows[n].Cells[3].Value = item[9].ToString();
                    dataGridView1.Rows[n].Cells[4].Value = item[10].ToString();
                    dataGridView1.Rows[n].Cells[5].Value = item[11].ToString();
                    dataGridView1.Rows[n].Cells[6].Value = item[12].ToString();
                    dataGridView1.Rows[n].Cells[7].Value = item[2].ToString();
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error in search " + exp.ToString());
            }
        }

        private void Back_Click(object sender, EventArgs e)
        {
            AdminHome adminHome = new AdminHome(homePanelReference, adminName); // Pass the homepanel control
            adminHome.TopLevel = false;
            adminHome.FormBorderStyle = FormBorderStyle.None;
            adminHome.Dock = DockStyle.Fill;

            homePanelReference.Controls.Clear();
            homePanelReference.Controls.Add(adminHome);

            adminHome.Show();
        }

        private void btnDeleteAccount_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("1: Do you want to permanent delete?, Press = Yes. \n 2:No", " your delete operation ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                if (txtUserName.Text.Length != 0)
                {
                    string username = adminName;


                    string s = "delete from UserInfo where UserName=@username ";

                    SqlCommand userdeleteCommand = new SqlCommand(s);
                    userdeleteCommand.Parameters.AddWithValue("@username", username);


                   int row = dBAccessLibrary.executeQuery(userdeleteCommand);

                    if (row >= 1)
                    {
                        MessageBox.Show(username + " Success..... ");


                    }
                    else
                    {
                        MessageBox.Show(username + " Account deletion failed: ");
                    }


                    string query = "delete from AdminInfo where Admin_ID=" + adminid;

                    SqlCommand deleteCommand = new SqlCommand(query);

                     row = dBAccessLibrary.executeQuery(deleteCommand);

                    if (row >= 1)
                    {
                        MessageBox.Show(username + " Your Account is permanently Deleted ");


                    }
                    else
                    {
                        MessageBox.Show(username + " Account deletion failed: ");
                    }

                    

                    //showDetails();
                    this.txtUserName.Text = "";
                    this.txtEmail.Text = "";
                    this.txtPhoneNo.Text = "";
                    this.txtApartmentNo.Text = "";
                    this.txtPostalCode.Text = "";
                    this.txtStreetAddress.Text = "";
                    this.txtCity.Text = "";

                    this.Hide();
                    Login login = new Login();
                    login.Show();
                }
                else
                {
                    MessageBox.Show("Give your username properly");
                }
            }
            if (dr == DialogResult.No)
            {
                MessageBox.Show("Thank you for stay with us");
            }


        }
    }
    
}
