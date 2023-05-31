using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Projects\Uni\C#\Lec\q39\MyTestDB.mdf;Integrated Security=True;Connect Timeout=30";
            string query = "SELECT * FROM Info";

            SqlDataAdapter da = new SqlDataAdapter(query, connectionString);
            DataSet ds = new DataSet();

            da.Fill(ds, "Info");
            dataGridView1.DataSource = ds.Tables["Info"];
        }
    }
}
