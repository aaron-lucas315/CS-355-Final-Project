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
    public partial class Customer_Information : Form
    {
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\aaron\Drug_Registration.mdf;Integrated Security=True;Connect Timeout=30";
        public Customer_Information()
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
                sqlCon.Open();
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Customer_Information_Load(object sender, EventArgs e)
        {
            SqlConnection sqlCon = new SqlConnection(connectionString);
            sqlCon.Open();
            SqlCommand command;
            SqlDataReader datareader;
            string sq1;
            command = new SqlCommand("select * from OnlineCustomer where idOnlineCustomer = " + User.get_id(), sqlCon);

            datareader = command.ExecuteReader();

            while (datareader.Read())
            {
                textBox2.Text = (datareader["CustomerName"].ToString());
                textBox3.Text = (datareader["Address"].ToString());
                textBox5.Text = (datareader["Zip_Code"].ToString());
                textBox7.Text = (datareader["Country"].ToString());
                textBox6.Text = (datareader["City"].ToString());
                textBox1.Text = (datareader["Contact_Number_1"].ToString());
                textBox4.Text = (datareader["Contact_Number_2"].ToString());
            }

            sqlCon.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Customer_Desk f1 = new Customer_Desk();
            f1.Show();
            this.Hide();
        }
    }
}
