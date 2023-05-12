using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();

            

            if (username.Text == "" && password.Text == "")
            {
                MessageBox.Show("Username and password cannot be empty");
            }
            else if (username.Text == "Admin" && password.Text == "admin123")
            {
                form2.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Incorrect username or password");
            }
            
        }
    }
}
