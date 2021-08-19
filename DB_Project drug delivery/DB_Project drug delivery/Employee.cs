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
    public partial class Employee : Form
    {
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\aaron\Drug_Registration.mdf;Integrated Security=True;Connect Timeout=30";
        public Employee()
        {
            InitializeComponent();
        }

        private void Employee_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlCommand sqlCmd = new SqlCommand("NewEmployee", sqlCon);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@EmployeeName", textBox2.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@Address", textBox3.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@CNIC", textBox5.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@Position", textBox10.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@ReportsTo", textBox9.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@BirthDate", this.dateTimePicker1.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@HireDate", this.dateTimePicker2.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@Salary", textBox7.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@Contact_Number_1", textBox1.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@Contact_Number_2", textBox4.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@Username", textBox11.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@Password_2", textBox8.Text.Trim());
                sqlCmd.ExecuteNonQuery();
                textBox2.Clear();
                textBox3.Clear();
                textBox5.Clear();
                textBox10.Clear();
                textBox9.Clear();
                dateTimePicker1.Text = "";
                dateTimePicker2.Text = "";
                textBox7.Clear();
                textBox1.Clear();
                textBox4.Clear();
                textBox11.Clear();
                textBox8.Clear();
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Manager_Desk f1 = new Manager_Desk();
            f1.Show();
            this.Hide();
        }
    }
}
