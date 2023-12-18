
namespace Parcel_Delivery_Management_System
{
    partial class Employee_MyDetails
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
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDeleteAccount = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Back = new System.Windows.Forms.PictureBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPhoneNo = new System.Windows.Forms.TextBox();
            this.Emp_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Emp_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Emp_Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Emp_PhoneNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Emp_Salary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Back)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtcheckhname);
            this.panel1.Controls.Add(this.lblcheckusername);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.btnDeleteAccount);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.Back);
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtUserName);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtPhoneNo);
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
            this.txtcheckhname.Location = new System.Drawing.Point(522, 76);
            this.txtcheckhname.Multiline = true;
            this.txtcheckhname.Name = "txtcheckhname";
            this.txtcheckhname.Size = new System.Drawing.Size(384, 42);
            this.txtcheckhname.TabIndex = 104;
            this.txtcheckhname.Text = "tab to check your username";
            this.txtcheckhname.TextChanged += new System.EventHandler(this.txtcheckhname_TextChanged);
            // 
            // lblcheckusername
            // 
            this.lblcheckusername.AutoSize = true;
            this.lblcheckusername.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcheckusername.ForeColor = System.Drawing.Color.Red;
            this.lblcheckusername.Location = new System.Drawing.Point(221, 79);
            this.lblcheckusername.Name = "lblcheckusername";
            this.lblcheckusername.Size = new System.Drawing.Size(269, 32);
            this.lblcheckusername.TabIndex = 103;
            this.lblcheckusername.Text = "Your username is: ";
            this.lblcheckusername.Click += new System.EventHandler(this.lblcheckusername_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnUpdate.Location = new System.Drawing.Point(47, 561);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(443, 64);
            this.btnUpdate.TabIndex = 102;
            this.btnUpdate.Text = "Update Your Information";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDeleteAccount
            // 
            this.btnDeleteAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteAccount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnDeleteAccount.Location = new System.Drawing.Point(527, 561);
            this.btnDeleteAccount.Name = "btnDeleteAccount";
            this.btnDeleteAccount.Size = new System.Drawing.Size(489, 64);
            this.btnDeleteAccount.TabIndex = 101;
            this.btnDeleteAccount.Text = "Do you want to delete Account?";
            this.btnDeleteAccount.UseVisualStyleBackColor = true;
            this.btnDeleteAccount.Click += new System.EventHandler(this.btnDeleteAccount_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Emp_ID,
            this.Emp_Name,
            this.Emp_Email,
            this.Emp_PhoneNo,
            this.Emp_Salary});
            this.dataGridView1.Location = new System.Drawing.Point(227, 157);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(679, 88);
            this.dataGridView1.TabIndex = 100;
            this.dataGridView1.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseDoubleClick);
            // 
            // Back
            // 
            this.Back.Image = global::Parcel_Delivery_Management_System.Properties.Resources.BlueBack;
            this.Back.Location = new System.Drawing.Point(3, 3);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(73, 50);
            this.Back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Back.TabIndex = 99;
            this.Back.TabStop = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(506, 349);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(345, 32);
            this.txtEmail.TabIndex = 92;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label2.Location = new System.Drawing.Point(208, 310);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 32);
            this.label2.TabIndex = 89;
            this.label2.Text = "User Name";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(506, 310);
            this.txtUserName.Multiline = true;
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(345, 32);
            this.txtUserName.TabIndex = 90;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label3.Location = new System.Drawing.Point(208, 349);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 32);
            this.label3.TabIndex = 91;
            this.label3.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label5.Location = new System.Drawing.Point(208, 395);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 32);
            this.label5.TabIndex = 93;
            this.label5.Text = "PhoneNo";
            // 
            // txtPhoneNo
            // 
            this.txtPhoneNo.Location = new System.Drawing.Point(506, 395);
            this.txtPhoneNo.Multiline = true;
            this.txtPhoneNo.Name = "txtPhoneNo";
            this.txtPhoneNo.Size = new System.Drawing.Size(345, 32);
            this.txtPhoneNo.TabIndex = 94;
            // 
            // Emp_ID
            // 
            this.Emp_ID.HeaderText = "Emp_ID";
            this.Emp_ID.MinimumWidth = 6;
            this.Emp_ID.Name = "Emp_ID";
            this.Emp_ID.Width = 125;
            // 
            // Emp_Name
            // 
            this.Emp_Name.HeaderText = "Emp_Name";
            this.Emp_Name.MinimumWidth = 6;
            this.Emp_Name.Name = "Emp_Name";
            this.Emp_Name.Width = 125;
            // 
            // Emp_Email
            // 
            this.Emp_Email.HeaderText = "Emp_Email";
            this.Emp_Email.MinimumWidth = 6;
            this.Emp_Email.Name = "Emp_Email";
            this.Emp_Email.Width = 125;
            // 
            // Emp_PhoneNo
            // 
            this.Emp_PhoneNo.HeaderText = "Emp_PhoneNo";
            this.Emp_PhoneNo.MinimumWidth = 6;
            this.Emp_PhoneNo.Name = "Emp_PhoneNo";
            this.Emp_PhoneNo.Width = 125;
            // 
            // Emp_Salary
            // 
            this.Emp_Salary.HeaderText = "Emp_Salary";
            this.Emp_Salary.MinimumWidth = 6;
            this.Emp_Salary.Name = "Emp_Salary";
            this.Emp_Salary.Width = 125;
            // 
            // Employee_MyDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 729);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Employee_MyDetails";
            this.Text = "Employee_MyDetails";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Back)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtcheckhname;
        private System.Windows.Forms.Label lblcheckusername;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDeleteAccount;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox Back;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPhoneNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Emp_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Emp_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Emp_Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Emp_PhoneNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Emp_Salary;
    }
}