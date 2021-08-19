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
    public partial class Employee_or_Customer : Form
    {
        public Employee_or_Customer()
        {
            InitializeComponent();
        }


        private void Employee_or_Customer_Load(object sender, EventArgs e)
        {

        }

        private void Employee_Click(object sender, EventArgs e)
        {
            Employee_Signin f1 = new Employee_Signin();
            f1.Show();
            this.Hide();
        }

        private void Customer_Click(object sender, EventArgs e)
        {
            Customer_Signin f1 = new Customer_Signin();
            f1.Show();
            this.Hide();
        }
    }
}
