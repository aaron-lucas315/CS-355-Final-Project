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
    public partial class Employee_Desk : Form
    {
        public Employee_Desk()
        {
            InitializeComponent();
        }

        private void Employee_Desk_Load(object sender, EventArgs e)
        {

        }

        private void order_button_Click(object sender, EventArgs e)
        {
            drug_registration f1 = new drug_registration();
            f1.Show();
            this.Hide();
        }

        private void customer_history_Click(object sender, EventArgs e)
        {
            Manager_Desk f1 = new Manager_Desk();
            f1.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Employee_Signin f1 = new Employee_Signin();
            f1.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Inventory f1 = new Inventory();
            f1.Show();
            this.Hide();
        }
    }
}
