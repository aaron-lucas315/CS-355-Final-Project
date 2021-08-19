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
    public partial class Manager_Desk : Form
    {
        public Manager_Desk()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Employee_Signin f1 = new Employee_Signin();
            f1.Show();
            this.Hide();
        }

        private void customer_history_Click(object sender, EventArgs e)
        {
            Transporter f1 = new Transporter();
            f1.Show();
            this.Hide();
        }

        private void order_button_Click(object sender, EventArgs e)
        {
            Manufacturer f1 = new Manufacturer();
            f1.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Employee f1 = new Employee();
            f1.Show();
            this.Hide();
        }
    }
}
