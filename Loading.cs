﻿using System;
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
    public partial class Loading : Form
    {
        public Loading()
        {
            InitializeComponent();
        }

        private void Loading_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(progressBar1.Value<100)
            {
                progressBar1.Value += 1;
                label2.Text = progressBar1.Value.ToString() + " %";
            }
            else
            {
                timer1.Stop();

                this.Hide();

                Login login = new Login();
                login.Show();
            }
        }

        private void lblBackPreviousPage_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
