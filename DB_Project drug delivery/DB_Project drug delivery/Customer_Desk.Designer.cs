namespace DB_Project_drug_delivery
{
    partial class Customer_Desk
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
            this.customer_information = new System.Windows.Forms.Button();
            this.order_button = new System.Windows.Forms.Button();
            this.customer_history = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // customer_information
            // 
            this.customer_information.Location = new System.Drawing.Point(139, 276);
            this.customer_information.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.customer_information.Name = "customer_information";
            this.customer_information.Size = new System.Drawing.Size(259, 59);
            this.customer_information.TabIndex = 0;
            this.customer_information.Text = "View Customer Information";
            this.customer_information.UseVisualStyleBackColor = true;
            this.customer_information.Click += new System.EventHandler(this.Button1_Click);
            // 
            // order_button
            // 
            this.order_button.Location = new System.Drawing.Point(139, 73);
            this.order_button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.order_button.Name = "order_button";
            this.order_button.Size = new System.Drawing.Size(259, 59);
            this.order_button.TabIndex = 1;
            this.order_button.Text = "Order Medication";
            this.order_button.UseVisualStyleBackColor = true;
            this.order_button.Click += new System.EventHandler(this.Order_button_Click);
            // 
            // customer_history
            // 
            this.customer_history.Location = new System.Drawing.Point(139, 171);
            this.customer_history.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.customer_history.Name = "customer_history";
            this.customer_history.Size = new System.Drawing.Size(259, 59);
            this.customer_history.TabIndex = 2;
            this.customer_history.Text = "View Order History";
            this.customer_history.UseVisualStyleBackColor = true;
            this.customer_history.Click += new System.EventHandler(this.customer_history_Click);
            // 
            // Customer_Desk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 416);
            this.Controls.Add(this.customer_history);
            this.Controls.Add(this.order_button);
            this.Controls.Add(this.customer_information);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Customer_Desk";
            this.Text = "Customer_Desk";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button customer_information;
        private System.Windows.Forms.Button order_button;
        private System.Windows.Forms.Button customer_history;
    }
}