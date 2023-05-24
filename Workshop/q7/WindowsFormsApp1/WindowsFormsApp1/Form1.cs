using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string fname;
        public string lname;
        public string uname;
        public string stringage;
        public string email;
        public string password1;
        public string password2;
        

        

        public void button1_Click(object sender, EventArgs e)
        {
            fname = fnamebox.Text;
            lname = lnamebox.Text;
            uname = unamebox.Text;
            stringage = agebox.Text;
            email = emailbox.Text;
            password1 = passwordbox.Text;
            password2 = repasswordbox.Text;

            if (ValidateForm())
            {
                MessageBox.Show("Successfully Signup to the sysytem");
            }
            
        }

        static bool ValidateUsername(string uname)
        {
            // Regular expression pattern for lowercase letters only and minimum length of 10
            string pattern = "^[a-z]{10,}$";

            return Regex.IsMatch(uname, pattern);
        }

        public bool ValidateForm()
        {
            bool isValid = true;
            

            if (String.IsNullOrWhiteSpace(fname) || String.IsNullOrWhiteSpace(lname) || String.IsNullOrWhiteSpace(uname) || String.IsNullOrWhiteSpace(stringage) || String.IsNullOrWhiteSpace(email) || String.IsNullOrWhiteSpace(password1) || String.IsNullOrWhiteSpace(password2))
            {
                isValid = false;
                MessageBox.Show("Enter all required fileds");
            }
            else if (!(ValidateUsername(uname)))
            {
                isValid = false;
                MessageBox.Show("Username Doesn't valid");
            }
            else if (!int.TryParse(agebox.Text, out int age) || age < 18)
            {
                    isValid = false;
                    MessageBox.Show("You must be at least 18 years old to sign up.");
                
            }
            else if (!Regex.IsMatch(email, @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$"))
            {
                isValid = false;
                MessageBox.Show("Invalid email address.");
                
            }
            else if (password1.Length < 6)
            {
                    isValid = false;
                    MessageBox.Show("Password should be at least 6 characters long.");
                    
            }
            else if (!(password1 == password2))
            {
                isValid = false;
                MessageBox.Show("Password doesn't match.");
               
            }
            else
            {
                return isValid;
            }
            return isValid;           
        }
    }
}
