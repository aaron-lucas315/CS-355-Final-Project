namespace DB_Project_drug_delivery
{
    partial class Employee_or_Customer
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
            this.employee = new System.Windows.Forms.Button();
            this.customer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // employee
            // 
            this.employee.Location = new System.Drawing.Point(83, 50);
            this.employee.Name = "employee";
            this.employee.Size = new System.Drawing.Size(210, 68);
            this.employee.TabIndex = 0;
            this.employee.Text = "Employee";
            this.employee.UseVisualStyleBackColor = true;
            this.employee.Click += new System.EventHandler(this.Employee_Click);
            // 
            // customer
            // 
            this.customer.Location = new System.Drawing.Point(83, 140);
            this.customer.Name = "customer";
            this.customer.Size = new System.Drawing.Size(210, 68);
            this.customer.TabIndex = 1;
            this.customer.Text = "Customer";
            this.customer.UseVisualStyleBackColor = true;
            this.customer.Click += new System.EventHandler(this.Customer_Click);
            // 
            // Employee_or_Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 260);
            this.Controls.Add(this.customer);
            this.Controls.Add(this.employee);
            this.Name = "Employee_or_Customer";
            this.Text = "Employee or Customer";
            this.Load += new System.EventHandler(this.Employee_or_Customer_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button employee;
        private System.Windows.Forms.Button customer;
    }
}