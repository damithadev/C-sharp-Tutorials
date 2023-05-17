using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public string connectionString = @"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Projects\Uni\C#\Lec\q39\MyTestDB.mdf;Integrated Security=True;Connect Timeout=30";
        private void button1_Click(object sender, EventArgs e)
        {
            

            int ID = int.Parse(textBox1.Text);

            SqlConnection con = new SqlConnection(connectionString);
            string query = "INSERT INTO info (ID) VALUES (@ID)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@ID", ID); // Add the parameter and its value

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Inserted Successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
    }
}
