using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB_Project_drug_delivery
{
    public partial class Customer_Desk : Form
    {
        public Customer_Desk()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Customer_Information f1 = new Customer_Information();
            f1.Show();
            this.Hide();
        }

        private void Order_button_Click(object sender, EventArgs e)
        {
            Order f1 = new Order();
            f1.Show();
            this.Hide();
        }

        private void customer_history_Click(object sender, EventArgs e)
        {

        }
    }
}
