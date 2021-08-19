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
    public partial class Manufacturer : Form
    {
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\aaron\Drug_Registration.mdf;Integrated Security=True;Connect Timeout=30";
        public Manufacturer()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlCommand sqlCmd = new SqlCommand("NewManufacturer", sqlCon);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@ManufacturerName", textBox2.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@Address", textBox3.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@Contact_Number", textBox1.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@Country", comboBox2.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@City", comboBox1.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@Contact_Person_Name", textBox6.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@Contact_Number_1", textBox4.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@Contact_Number_2", textBox5.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@Designation", textBox7.Text.Trim());
                sqlCmd.ExecuteNonQuery();
                textBox2.Clear();
                textBox3.Clear();
                textBox1.Clear();
                comboBox2.Text = "";
                comboBox1.Text = "";
                textBox6.Clear();
                textBox4.Clear();
                textBox5.Clear();
                textBox7.Clear();
                textBox6.Clear();
            }
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
            if (comboBox2.Text == "USA")
            {
                comboBox1.Items.Add("New York");
                comboBox1.Items.Add("New Jersey");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Manager_Desk f1 = new Manager_Desk();
            f1.Show();
            this.Hide();
        }
    }
}
