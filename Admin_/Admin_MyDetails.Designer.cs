
namespace Parcel_Delivery_Management_System
{
    partial class Admin_MyDetails
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtcheckhname = new System.Windows.Forms.TextBox();
            this.lblcheckusername = new System.Windows.Forms.Label();
            this.Back = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Admin_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Admin_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Admin_PhoneNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apartment_No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Street_Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Postal_Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.City = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDeleteAccount = new System.Windows.Forms.Button();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtStreetAddress = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPostalCode = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtApartmentNo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPhoneNo = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Back)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtCity);
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtStreetAddress);
            this.panel1.Controls.Add(this.txtUserName);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtPostalCode);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txtApartmentNo);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtPhoneNo);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.btnDeleteAccount);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.Back);
            this.panel1.Controls.Add(this.txtcheckhname);
            this.panel1.Controls.Add(this.lblcheckusername);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1080, 729);
            this.panel1.TabIndex = 0;
            // 
            // txtcheckhname
            // 
            this.txtcheckhname.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcheckhname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtcheckhname.Location = new System.Drawing.Point(477, 65);
            this.txtcheckhname.Multiline = true;
            this.txtcheckhname.Name = "txtcheckhname";
            this.txtcheckhname.Size = new System.Drawing.Size(384, 42);
            this.txtcheckhname.TabIndex = 90;
            this.txtcheckhname.Text = "tab to check your username";
            this.txtcheckhname.TextChanged += new System.EventHandler(this.txtcheckhname_TextChanged);
            // 
            // lblcheckusername
            // 
            this.lblcheckusername.AutoSize = true;
            this.lblcheckusername.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcheckusername.ForeColor = System.Drawing.Color.Red;
            this.lblcheckusername.Location = new System.Drawing.Point(182, 68);
            this.lblcheckusername.Name = "lblcheckusername";
            this.lblcheckusername.Size = new System.Drawing.Size(269, 32);
            this.lblcheckusername.TabIndex = 89;
            this.lblcheckusername.Text = "Your username is: ";
            this.lblcheckusername.Click += new System.EventHandler(this.lblcheckusername_Click);
            // 
            // Back
            // 
            this.Back.Image = global::Parcel_Delivery_Management_System.Properties.Resources.BlueBack;
            this.Back.Location = new System.Drawing.Point(3, 0);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(73, 50);
            this.Back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Back.TabIndex = 91;
            this.Back.TabStop = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Admin_ID,
            this.Admin_Name,
            this.Admin_PhoneNo,
            this.Apartment_No,
            this.Street_Address,
            this.Postal_Code,
            this.City,
            this.Email});
            this.dataGridView1.Location = new System.Drawing.Point(3, 129);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1065, 130);
            this.dataGridView1.TabIndex = 92;
            this.dataGridView1.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseDoubleClick);
            // 
            // Admin_ID
            // 
            this.Admin_ID.HeaderText = "Admin_ID";
            this.Admin_ID.MinimumWidth = 6;
            this.Admin_ID.Name = "Admin_ID";
            this.Admin_ID.Width = 125;
            // 
            // Admin_Name
            // 
            this.Admin_Name.HeaderText = "Admin_Name";
            this.Admin_Name.MinimumWidth = 6;
            this.Admin_Name.Name = "Admin_Name";
            this.Admin_Name.Width = 125;
            // 
            // Admin_PhoneNo
            // 
            this.Admin_PhoneNo.HeaderText = "Admin_PhoneNo";
            this.Admin_PhoneNo.MinimumWidth = 6;
            this.Admin_PhoneNo.Name = "Admin_PhoneNo";
            this.Admin_PhoneNo.Width = 125;
            // 
            // Apartment_No
            // 
            this.Apartment_No.HeaderText = "Apartment_No";
            this.Apartment_No.MinimumWidth = 6;
            this.Apartment_No.Name = "Apartment_No";
            this.Apartment_No.Width = 125;
            // 
            // Street_Address
            // 
            this.Street_Address.HeaderText = "Street_Address";
            this.Street_Address.MinimumWidth = 6;
            this.Street_Address.Name = "Street_Address";
            this.Street_Address.Width = 125;
            // 
            // Postal_Code
            // 
            this.Postal_Code.HeaderText = "Postal_Code";
            this.Postal_Code.MinimumWidth = 6;
            this.Postal_Code.Name = "Postal_Code";
            this.Postal_Code.Width = 125;
            // 
            // City
            // 
            this.City.HeaderText = "City";
            this.City.MinimumWidth = 6;
            this.City.Name = "City";
            this.City.Width = 125;
            // 
            // Email
            // 
            this.Email.HeaderText = "Email";
            this.Email.MinimumWidth = 6;
            this.Email.Name = "Email";
            this.Email.Width = 125;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnUpdate.Location = new System.Drawing.Point(42, 643);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(443, 64);
            this.btnUpdate.TabIndex = 94;
            this.btnUpdate.Text = "Update Your Information";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDeleteAccount
            // 
            this.btnDeleteAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteAccount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnDeleteAccount.Location = new System.Drawing.Point(531, 643);
            this.btnDeleteAccount.Name = "btnDeleteAccount";
            this.btnDeleteAccount.Size = new System.Drawing.Size(489, 64);
            this.btnDeleteAccount.TabIndex = 93;
            this.btnDeleteAccount.Text = "Do you want to delete Account?";
            this.btnDeleteAccount.UseVisualStyleBackColor = true;
            this.btnDeleteAccount.Click += new System.EventHandler(this.btnDeleteAccount_Click);
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(516, 576);
            this.txtCity.Multiline = true;
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(345, 32);
            this.txtCity.TabIndex = 108;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(516, 345);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(345, 32);
            this.txtEmail.TabIndex = 98;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label10.Location = new System.Drawing.Point(218, 576);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 32);
            this.label10.TabIndex = 107;
            this.label10.Text = "City";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label2.Location = new System.Drawing.Point(218, 306);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 32);
            this.label2.TabIndex = 95;
            this.label2.Text = "User Name";
            // 
            // txtStreetAddress
            // 
            this.txtStreetAddress.Location = new System.Drawing.Point(516, 529);
            this.txtStreetAddress.Multiline = true;
            this.txtStreetAddress.Name = "txtStreetAddress";
            this.txtStreetAddress.Size = new System.Drawing.Size(345, 32);
            this.txtStreetAddress.TabIndex = 106;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(516, 306);
            this.txtUserName.Multiline = true;
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(345, 32);
            this.txtUserName.TabIndex = 96;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label9.Location = new System.Drawing.Point(218, 529);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(216, 32);
            this.label9.TabIndex = 105;
            this.label9.Text = "Street Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label3.Location = new System.Drawing.Point(218, 345);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 32);
            this.label3.TabIndex = 97;
            this.label3.Text = "Email";
            // 
            // txtPostalCode
            // 
            this.txtPostalCode.Location = new System.Drawing.Point(516, 485);
            this.txtPostalCode.Multiline = true;
            this.txtPostalCode.Name = "txtPostalCode";
            this.txtPostalCode.Size = new System.Drawing.Size(345, 32);
            this.txtPostalCode.TabIndex = 104;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label8.Location = new System.Drawing.Point(218, 485);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(181, 32);
            this.label8.TabIndex = 103;
            this.label8.Text = "Postal Code";
            // 
            // txtApartmentNo
            // 
            this.txtApartmentNo.Location = new System.Drawing.Point(516, 441);
            this.txtApartmentNo.Multiline = true;
            this.txtApartmentNo.Name = "txtApartmentNo";
            this.txtApartmentNo.Size = new System.Drawing.Size(345, 32);
            this.txtApartmentNo.TabIndex = 102;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label5.Location = new System.Drawing.Point(218, 391);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 32);
            this.label5.TabIndex = 99;
            this.label5.Text = "PhoneNo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label7.Location = new System.Drawing.Point(218, 441);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(201, 32);
            this.label7.TabIndex = 101;
            this.label7.Text = "Apartment No";
            // 
            // txtPhoneNo
            // 
            this.txtPhoneNo.Location = new System.Drawing.Point(516, 391);
            this.txtPhoneNo.Multiline = true;
            this.txtPhoneNo.Name = "txtPhoneNo";
            this.txtPhoneNo.Size = new System.Drawing.Size(345, 32);
            this.txtPhoneNo.TabIndex = 100;
            // 
            // Admin_MyDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 729);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Admin_MyDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin_MyDetails";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Back)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDeleteAccount;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Admin_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Admin_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Admin_PhoneNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apartment_No;
        private System.Windows.Forms.DataGridViewTextBoxColumn Street_Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn Postal_Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn City;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.PictureBox Back;
        private System.Windows.Forms.TextBox txtcheckhname;
        private System.Windows.Forms.Label lblcheckusername;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtStreetAddress;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPostalCode;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtApartmentNo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPhoneNo;
    }
}