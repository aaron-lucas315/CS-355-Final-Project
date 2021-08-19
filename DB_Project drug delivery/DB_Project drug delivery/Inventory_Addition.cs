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
    public partial class Inventory : Form
    {
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\aaron\Documents\test.mdf;Integrated Security=True;Connect Timeout=30";
        public Inventory()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlCommand sqlCmd = new SqlCommand("UserAdd", sqlCon);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@Country", comboBox1.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@City", comboBox2.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@Contact_Number_1", textBox1.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@Contact_Number_2", dateTimePicker1.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@Username", dateTimePicker2.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@Password", numericUpDown1.Text.Trim());
                sqlCmd.ExecuteNonQuery();
                comboBox2.Text = "";
                comboBox1.Text = "";
                textBox1.Clear();
                dateTimePicker1.Text = "";
                dateTimePicker2.Text = "";
                numericUpDown1.Text = "";
                Customer_Desk f1 = new Customer_Desk();
                f1.Show();
                this.Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Employee_Desk f1 = new Employee_Desk();
            f1.Show();
            this.Hide();
        }
    }
}
