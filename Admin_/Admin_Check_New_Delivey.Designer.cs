
namespace Parcel_Delivery_Management_System
{
    partial class Admin_Check_New_Delivey
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
            this.lblSearchPerson = new System.Windows.Forms.Label();
            this.txtSearchPerson = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Order_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cust_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cust_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cust_PhoneNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apartment_No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Street_Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Postal_Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.City = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTotalOrderCheck = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Back = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Back)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSearchPerson
            // 
            this.lblSearchPerson.AutoSize = true;
            this.lblSearchPerson.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchPerson.Location = new System.Drawing.Point(292, 124);
            this.lblSearchPerson.Name = "lblSearchPerson";
            this.lblSearchPerson.Size = new System.Drawing.Size(128, 32);
            this.lblSearchPerson.TabIndex = 113;
            this.lblSearchPerson.Text = "Search: ";
            // 
            // txtSearchPerson
            // 
            this.txtSearchPerson.Location = new System.Drawing.Point(502, 124);
            this.txtSearchPerson.Multiline = true;
            this.txtSearchPerson.Name = "txtSearchPerson";
            this.txtSearchPerson.Size = new System.Drawing.Size(322, 32);
            this.txtSearchPerson.TabIndex = 112;
            this.txtSearchPerson.TextChanged += new System.EventHandler(this.txtSearchPerson_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Order_ID,
            this.Cust_ID,
            this.Cust_Name,
            this.Cust_PhoneNo,
            this.Apartment_No,
            this.Street_Address,
            this.Postal_Code,
            this.City});
            this.dataGridView1.Location = new System.Drawing.Point(14, 203);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1065, 326);
            this.dataGridView1.TabIndex = 111;
            // 
            // Order_ID
            // 
            this.Order_ID.HeaderText = "Order_ID";
            this.Order_ID.MinimumWidth = 6;
            this.Order_ID.Name = "Order_ID";
            this.Order_ID.Width = 125;
            // 
            // Cust_ID
            // 
            this.Cust_ID.HeaderText = "Cust_ID";
            this.Cust_ID.MinimumWidth = 6;
            this.Cust_ID.Name = "Cust_ID";
            this.Cust_ID.Width = 125;
            // 
            // Cust_Name
            // 
            this.Cust_Name.HeaderText = "Cust_Name";
            this.Cust_Name.MinimumWidth = 6;
            this.Cust_Name.Name = "Cust_Name";
            this.Cust_Name.Width = 125;
            // 
            // Cust_PhoneNo
            // 
            this.Cust_PhoneNo.HeaderText = "Cust_PhoneNo";
            this.Cust_PhoneNo.MinimumWidth = 6;
            this.Cust_PhoneNo.Name = "Cust_PhoneNo";
            this.Cust_PhoneNo.Width = 125;
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
            // txtTotalOrderCheck
            // 
            this.txtTotalOrderCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalOrderCheck.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtTotalOrderCheck.Location = new System.Drawing.Point(502, 61);
            this.txtTotalOrderCheck.Multiline = true;
            this.txtTotalOrderCheck.Name = "txtTotalOrderCheck";
            this.txtTotalOrderCheck.Size = new System.Drawing.Size(384, 42);
            this.txtTotalOrderCheck.TabIndex = 110;
            this.txtTotalOrderCheck.Text = "tab to check total order";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(132, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(307, 32);
            this.label1.TabIndex = 109;
            this.label1.Text = "Total Pending Order: ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Back
            // 
            this.Back.Image = global::Parcel_Delivery_Management_System.Properties.Resources.BlueBack;
            this.Back.Location = new System.Drawing.Point(3, 2);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(73, 50);
            this.Back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Back.TabIndex = 108;
            this.Back.TabStop = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Admin_Check_New_Delivey
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 729);
            this.Controls.Add(this.lblSearchPerson);
            this.Controls.Add(this.txtSearchPerson);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtTotalOrderCheck);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Back);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Admin_Check_New_Delivey";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin_Check_New_Delivey";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Back)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSearchPerson;
        private System.Windows.Forms.TextBox txtSearchPerson;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Order_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cust_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cust_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cust_PhoneNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apartment_No;
        private System.Windows.Forms.DataGridViewTextBoxColumn Street_Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn Postal_Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn City;
        private System.Windows.Forms.TextBox txtTotalOrderCheck;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox Back;
    }
}