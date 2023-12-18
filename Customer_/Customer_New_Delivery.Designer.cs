
namespace Parcel_Delivery_Management_System
{
    partial class Customer_New_Delivery
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
            this.lblCalculateAmount = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txtAmountPay = new System.Windows.Forms.TextBox();
            this.lblAmountPay = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ComShipmentType = new System.Windows.Forms.ComboBox();
            this.lblShipmentType = new System.Windows.Forms.Label();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblWeight = new System.Windows.Forms.Label();
            this.lblSearchPerson = new System.Windows.Forms.Label();
            this.txtSearchPerson = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Cust_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cust_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cust_PhoneNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apartment_No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Street_Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Postal_Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.City = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.Back = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Back)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCalculateAmount
            // 
            this.lblCalculateAmount.AutoSize = true;
            this.lblCalculateAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalculateAmount.ForeColor = System.Drawing.Color.Red;
            this.lblCalculateAmount.Location = new System.Drawing.Point(552, 598);
            this.lblCalculateAmount.Name = "lblCalculateAmount";
            this.lblCalculateAmount.Size = new System.Drawing.Size(348, 29);
            this.lblCalculateAmount.TabIndex = 38;
            this.lblCalculateAmount.Text = "Click Here To Check Amount";
            this.lblCalculateAmount.Click += new System.EventHandler(this.lblCalculateAmount_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.ForeColor = System.Drawing.Color.Blue;
            this.btnConfirm.Location = new System.Drawing.Point(909, 653);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(146, 58);
            this.btnConfirm.TabIndex = 37;
            this.btnConfirm.Text = "Comfirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label10.Location = new System.Drawing.Point(381, 630);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(165, 32);
            this.label10.TabIndex = 36;
            this.label10.Text = "Online Pay";
            // 
            // txtAmountPay
            // 
            this.txtAmountPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmountPay.Location = new System.Drawing.Point(387, 596);
            this.txtAmountPay.Multiline = true;
            this.txtAmountPay.Name = "txtAmountPay";
            this.txtAmountPay.Size = new System.Drawing.Size(232, 31);
            this.txtAmountPay.TabIndex = 35;
            this.txtAmountPay.Text = "BDT";
            // 
            // lblAmountPay
            // 
            this.lblAmountPay.AutoSize = true;
            this.lblAmountPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmountPay.Location = new System.Drawing.Point(93, 588);
            this.lblAmountPay.Name = "lblAmountPay";
            this.lblAmountPay.Size = new System.Drawing.Size(272, 32);
            this.lblAmountPay.TabIndex = 34;
            this.lblAmountPay.Text = "Amount to be Pay: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(93, 630);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(234, 32);
            this.label8.TabIndex = 33;
            this.label8.Text = "Payment Mode: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Blue;
            this.label7.Location = new System.Drawing.Point(41, 530);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(406, 46);
            this.label7.TabIndex = 32;
            this.label7.Text = "Payment Information";
            // 
            // ComShipmentType
            // 
            this.ComShipmentType.FormattingEnabled = true;
            this.ComShipmentType.Items.AddRange(new object[] {
            "Document",
            "Non-Document"});
            this.ComShipmentType.Location = new System.Drawing.Point(374, 453);
            this.ComShipmentType.Name = "ComShipmentType";
            this.ComShipmentType.Size = new System.Drawing.Size(232, 24);
            this.ComShipmentType.TabIndex = 31;
            // 
            // lblShipmentType
            // 
            this.lblShipmentType.AutoSize = true;
            this.lblShipmentType.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShipmentType.Location = new System.Drawing.Point(80, 447);
            this.lblShipmentType.Name = "lblShipmentType";
            this.lblShipmentType.Size = new System.Drawing.Size(236, 32);
            this.lblShipmentType.TabIndex = 30;
            this.lblShipmentType.Text = "Shipment Type: ";
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(374, 399);
            this.txtWeight.Multiline = true;
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(232, 31);
            this.txtWeight.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(28, 332);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(418, 46);
            this.label3.TabIndex = 28;
            this.label3.Text = "Shipment Information";
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeight.Location = new System.Drawing.Point(80, 399);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(127, 32);
            this.lblWeight.TabIndex = 27;
            this.lblWeight.Text = "Weight: ";
            // 
            // lblSearchPerson
            // 
            this.lblSearchPerson.AutoSize = true;
            this.lblSearchPerson.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchPerson.Location = new System.Drawing.Point(80, 128);
            this.lblSearchPerson.Name = "lblSearchPerson";
            this.lblSearchPerson.Size = new System.Drawing.Size(562, 32);
            this.lblSearchPerson.TabIndex = 26;
            this.lblSearchPerson.Text = "Search your destination person account:";
            // 
            // txtSearchPerson
            // 
            this.txtSearchPerson.Location = new System.Drawing.Point(716, 128);
            this.txtSearchPerson.Multiline = true;
            this.txtSearchPerson.Name = "txtSearchPerson";
            this.txtSearchPerson.Size = new System.Drawing.Size(322, 32);
            this.txtSearchPerson.TabIndex = 25;
            this.txtSearchPerson.TextChanged += new System.EventHandler(this.txtSearchPerson_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cust_ID,
            this.Cust_Name,
            this.Cust_PhoneNo,
            this.Apartment_No,
            this.Street_Address,
            this.Postal_Code,
            this.City});
            this.dataGridView1.Location = new System.Drawing.Point(86, 179);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(928, 150);
            this.dataGridView1.TabIndex = 24;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(19, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(697, 46);
            this.label1.TabIndex = 23;
            this.label1.Text = "Pickup Address and Delivery Details";
            // 
            // Back
            // 
            this.Back.Image = global::Parcel_Delivery_Management_System.Properties.Resources.BlueBack;
            this.Back.Location = new System.Drawing.Point(0, 0);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(73, 50);
            this.Back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Back.TabIndex = 22;
            this.Back.TabStop = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Customer_New_Delivery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 729);
            this.Controls.Add(this.lblCalculateAmount);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtAmountPay);
            this.Controls.Add(this.lblAmountPay);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ComShipmentType);
            this.Controls.Add(this.lblShipmentType);
            this.Controls.Add(this.txtWeight);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblWeight);
            this.Controls.Add(this.lblSearchPerson);
            this.Controls.Add(this.txtSearchPerson);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Back);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Customer_New_Delivery";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer_New_Delivery";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Back)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Back;
        private System.Windows.Forms.Label lblCalculateAmount;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtAmountPay;
        private System.Windows.Forms.Label lblAmountPay;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox ComShipmentType;
        private System.Windows.Forms.Label lblShipmentType;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.Label lblSearchPerson;
        private System.Windows.Forms.TextBox txtSearchPerson;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cust_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cust_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cust_PhoneNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apartment_No;
        private System.Windows.Forms.DataGridViewTextBoxColumn Street_Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn Postal_Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn City;
        private System.Windows.Forms.Label label1;
    }
}