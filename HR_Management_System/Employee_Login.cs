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
    public partial class Employee_Login : Form
    {
        public Employee_Login()
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
            ServiceReference1.ServiceClient client = new ServiceReference1.ServiceClient();
            var id = client.loginEmployee(textBox1.Text.ToString(), password.Text.ToString());
            if(id == 0)
            {
                MessageBox.Show("Invalid Credentials.Try Again..");
            }
            else
            {
                MessageBox.Show("Logged In Successfully..");
                Employee_Dashboard ed = new Employee_Dashboard(id);
                this.Close();
                ed.Show();
            }
        }
    }
}
