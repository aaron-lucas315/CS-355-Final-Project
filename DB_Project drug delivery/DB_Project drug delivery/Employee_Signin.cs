using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DB_Project_drug_delivery
{
    public partial class Employee_Signin : Form
    {
        public Employee_Signin()
        {
            InitializeComponent();
        }

        private void Sign_in_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\aaron\Drug_Registration.mdf;Integrated Security=True;Connect Timeout=30");
            SqlDataAdapter sda = new SqlDataAdapter("select count(*) from Employee where Username='" + username.Text + "' and Password_2='" + password.Text + "'", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                Employee_Desk f1 = new Employee_Desk();
                f1.Show();
                this.Hide();
            }
            else
                MessageBox.Show("Please enter correct username and password!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Employee_or_Customer f1 = new Employee_or_Customer();
            f1.Show();
            this.Hide();
        }
    }
}
