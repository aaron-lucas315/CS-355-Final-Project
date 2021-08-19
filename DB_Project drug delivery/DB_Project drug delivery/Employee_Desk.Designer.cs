namespace DB_Project_drug_delivery
{
    partial class Employee_Desk
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
            this.customer_history = new System.Windows.Forms.Button();
            this.order_button = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // customer_history
            // 
            this.customer_history.Location = new System.Drawing.Point(138, 259);
            this.customer_history.Margin = new System.Windows.Forms.Padding(4);
            this.customer_history.Name = "customer_history";
            this.customer_history.Size = new System.Drawing.Size(259, 59);
            this.customer_history.TabIndex = 5;
            this.customer_history.Text = "Access Manager Desk";
            this.customer_history.UseVisualStyleBackColor = true;
            this.customer_history.Click += new System.EventHandler(this.customer_history_Click);
            // 
            // order_button
            // 
            this.order_button.Location = new System.Drawing.Point(138, 71);
            this.order_button.Margin = new System.Windows.Forms.Padding(4);
            this.order_button.Name = "order_button";
            this.order_button.Size = new System.Drawing.Size(259, 59);
            this.order_button.TabIndex = 4;
            this.order_button.Text = "Register New Drug";
            this.order_button.UseVisualStyleBackColor = true;
            this.order_button.Click += new System.EventHandler(this.order_button_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(138, 355);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(259, 59);
            this.button1.TabIndex = 6;
            this.button1.Text = "Logout";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(138, 166);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(259, 59);
            this.button2.TabIndex = 7;
            this.button2.Text = "Inventory Addition";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Employee_Desk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 465);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.customer_history);
            this.Controls.Add(this.order_button);
            this.Name = "Employee_Desk";
            this.Text = "Employee_Desk";
            this.Load += new System.EventHandler(this.Employee_Desk_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button customer_history;
        private System.Windows.Forms.Button order_button;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}