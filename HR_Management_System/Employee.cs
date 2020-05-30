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
    public partial class Employee : Form
    {
        private int v1;
        private string v2;
        private string v3;
        private string v4;
        private string v5;
        private string v6;
        private string v7;
        private DateTime dateTime;
        private string v8;
        private string v9;
        private string v10;
        private string v11;
        private string v12;
        private bool u = false;

        public Employee()
        {
            InitializeComponent();
            u = false;
        }

        public Employee(int v1, string v2, string v3, string v4, string v5, string v6, string v7, DateTime dateTime, string v8, string v9, string v10, string v11, string v12)
        {
            InitializeComponent();
            this.v1 = v1;
            this.v2 = v2;
            this.v3 = v3;
            this.v4 = v4;
            this.v5 = v5;
            this.v6 = v6;
            this.v7 = v7;
            this.dateTime = dateTime;
            this.v8 = v8;
            this.v9 = v9;
            this.v10 = v10;
            this.v11 = v11;
            this.v12 = v12;
  
            u = true;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Manage_Employee me = new Manage_Employee();
            this.Close();
            me.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            HR_Dashbard hd = new HR_Dashbard();
            this.Close();
            hd.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Logging Out,Good Bye..");
            Login_As la = new Login_As();
            this.Close();
            la.Show();
        }

        private void login_Click(object sender, EventArgs e)
        {
            ServiceReference1.ServiceClient client = new ServiceReference1.ServiceClient();
            if (login.Text == "SAVE")
            {
                client.addEmployee(textBox1.Text.ToString(), textBox2.Text.ToString(), textBox3.Text.ToString(), textBox4.Text.ToString(), textBox5.Text.ToString(), textBox6.Text.ToString(), dateTimePicker1.Value, comboBox1.Text.ToString(), comboBox2.Text.ToString(), textBox8.Text.ToString(), comboBox3.Text.ToString(), textBox7.Text.ToString());
            }
            else
            {
                client.updateEmployee(v1, textBox1.Text.ToString(), textBox2.Text.ToString(), textBox3.Text.ToString(), textBox4.Text.ToString(), textBox5.Text.ToString(), textBox6.Text.ToString(), dateTimePicker1.Value, comboBox1.Text.ToString(), comboBox2.Text.ToString(), textBox8.Text.ToString(), comboBox3.Text.ToString(), textBox7.Text.ToString());
            }
            Manage_Employee me = new Manage_Employee();
            Close();
            me.Show();
        }

        private void Employee_Load(object sender, EventArgs e)
        {
            if(u)
            {
                textBox1.Text = v2;
                textBox2.Text = v3;
                textBox3.Text = v4;
                textBox4.Text = v5;
                textBox5.Text = v6;
                textBox6.Text = v7;
                dateTimePicker1.Value = dateTime;
                comboBox1.SelectedItem = v8;
                comboBox2.SelectedItem = v9;
                textBox8.Text = v10;
                comboBox3.SelectedItem = v11;
                textBox7.Text = v12;
                login.Text = "UPDATE";
            }
        }
    }
}
