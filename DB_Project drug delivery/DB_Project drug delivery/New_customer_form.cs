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
    public partial class New_customer_form : Form
    {
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\aaron\Drug_Registration.mdf;Integrated Security=True;Connect Timeout=30";
        public New_customer_form()
        {
            InitializeComponent();
        }

        private void OK_Click(object sender, EventArgs e)
        {
            if (textBox8.Text == "" || textBox7.Text == "" || textBox6.Text == "")
                MessageBox.Show("Please fill the required fields!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (textBox7.Text != textBox6.Text)
                MessageBox.Show("Passwords do not match!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if(textBox7.Text.Length<8)
                MessageBox.Show("Your password must contain at least 8 characters!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                using (SqlConnection sqlCon = new SqlConnection(connectionString))
                {
                    sqlCon.Open();
                    SqlCommand sqlCmd = new SqlCommand("NewCustomer", sqlCon);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@CustomerName", textBox2.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Address", textBox3.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Zip_Code", textBox5.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Country", comboBox2.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@City", comboBox1.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Contact_Number_1", textBox1.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Contact_Number_2", textBox4.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Username", textBox8.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Password_2", textBox7.Text.Trim());
                    sqlCmd.ExecuteNonQuery();
                    textBox2.Clear();
                    textBox3.Clear();
                    textBox5.Clear();
                    comboBox2.Text = "";
                    comboBox1.Text = "";
                    textBox1.Clear();
                    textBox4.Clear();
                    textBox8.Clear();
                    textBox7.Clear();
                    textBox6.Clear();
                    Customer_Desk f1 = new Customer_Desk();
                    f1.Show();
                    this.Hide();
                }
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            comboBox1.Text = "";
            if (comboBox2.Text == "Pakistan")
            {
                comboBox1.Items.Add("Karachi");
                comboBox1.Items.Add("Islamabad");
            }
            else if (comboBox2.Text == "India")
            {
                comboBox1.Items.Add("Delhi");
                comboBox1.Items.Add("Mumbai");
            }
            if(comboBox2.Text == "USA")
            {
                comboBox1.Items.Add("New York");
                comboBox1.Items.Add("New Jersey");
                comboBox1.Items.Add("Chicago");
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Customer_Signin f1 = new Customer_Signin();
            f1.Show();
            this.Hide();
        }
    }
}
