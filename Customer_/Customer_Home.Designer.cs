
namespace Parcel_Delivery_Management_System
{
    partial class Customer_Home
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
            this.btnCancelOrder = new System.Windows.Forms.Button();
            this.btnMyDetails = new System.Windows.Forms.Button();
            this.btnNewDelivery = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCancelOrder);
            this.panel1.Controls.Add(this.btnMyDetails);
            this.panel1.Controls.Add(this.btnNewDelivery);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1080, 729);
            this.panel1.TabIndex = 1;
            // 
            // btnCancelOrder
            // 
            this.btnCancelOrder.BackColor = System.Drawing.SystemColors.Control;
            this.btnCancelOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelOrder.ForeColor = System.Drawing.Color.Blue;
            this.btnCancelOrder.Image = global::Parcel_Delivery_Management_System.Properties.Resources.Canel_Order;
            this.btnCancelOrder.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCancelOrder.Location = new System.Drawing.Point(562, 60);
            this.btnCancelOrder.Name = "btnCancelOrder";
            this.btnCancelOrder.Size = new System.Drawing.Size(288, 287);
            this.btnCancelOrder.TabIndex = 28;
            this.btnCancelOrder.Text = "Cancel Order";
            this.btnCancelOrder.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancelOrder.UseVisualStyleBackColor = false;
            this.btnCancelOrder.Click += new System.EventHandler(this.btnCancelOrder_Click);
            // 
            // btnMyDetails
            // 
            this.btnMyDetails.BackColor = System.Drawing.SystemColors.Control;
            this.btnMyDetails.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnMyDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMyDetails.ForeColor = System.Drawing.Color.Blue;
            this.btnMyDetails.Image = global::Parcel_Delivery_Management_System.Properties.Resources.Admin;
            this.btnMyDetails.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMyDetails.Location = new System.Drawing.Point(390, 387);
            this.btnMyDetails.Name = "btnMyDetails";
            this.btnMyDetails.Size = new System.Drawing.Size(288, 287);
            this.btnMyDetails.TabIndex = 27;
            this.btnMyDetails.Text = "My Details";
            this.btnMyDetails.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMyDetails.UseVisualStyleBackColor = false;
            this.btnMyDetails.Click += new System.EventHandler(this.btnMyDetails_Click);
            // 
            // btnNewDelivery
            // 
            this.btnNewDelivery.BackColor = System.Drawing.SystemColors.Control;
            this.btnNewDelivery.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewDelivery.ForeColor = System.Drawing.Color.Blue;
            this.btnNewDelivery.Image = global::Parcel_Delivery_Management_System.Properties.Resources.New_Delivey_Change;
            this.btnNewDelivery.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnNewDelivery.Location = new System.Drawing.Point(230, 60);
            this.btnNewDelivery.Name = "btnNewDelivery";
            this.btnNewDelivery.Size = new System.Drawing.Size(288, 287);
            this.btnNewDelivery.TabIndex = 26;
            this.btnNewDelivery.Text = "New Delivery";
            this.btnNewDelivery.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNewDelivery.UseVisualStyleBackColor = false;
            this.btnNewDelivery.Click += new System.EventHandler(this.btnNewDelivery_Click);
            // 
            // Customer_Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 729);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Customer_Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer_Home";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCancelOrder;
        private System.Windows.Forms.Button btnMyDetails;
        private System.Windows.Forms.Button btnNewDelivery;
    }
}