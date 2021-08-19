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
    public partial class drug_registration : Form
    {
        public drug_registration()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Employee_Desk f1 = new Employee_Desk();
            f1.Show();
            this.Hide();
        }
    }
}
