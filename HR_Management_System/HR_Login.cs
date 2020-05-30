using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HR_Management_System
{
    public partial class HR_Login : Form
    {
        public HR_Login()
        {
            InitializeComponent();
        }

        private void BackLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login_As la = new Login_As();
            this.Close();
            la.Show();
        }

        private void reset_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            password.Clear();
        }

        private void login_Click(object sender, EventArgs e)
        {
            var user = textBox1.Text;
            var pass = password.Text;
            if (user == "admin" && pass == "admin")
            {
                MessageBox.Show("Successfully logged in");
                HR_Dashbard hr = new HR_Dashbard();
                this.Close();
                hr.Show();
            }
            else
            {
                MessageBox.Show("Invalid credentials");
            }
        }
    }
}
