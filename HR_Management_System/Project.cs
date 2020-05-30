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
    public partial class Project : Form
    {
        private bool u = false;
        private int v1;
        private string v2;
        private string v3;
        private string v4;
        private int v5;
        private string v6;
        private string v7;

        public Project()
        {
            InitializeComponent();
            u = false;
        }

        public Project(int v1, string v2, string v3, string v4, int v5, string v6, string v7)
        {
            InitializeComponent();
            this.v1 = v1;
            this.v2 = v2;
            this.v3 = v3;
            this.v4 = v4;
            this.v5 = v5;
            this.v6 = v6;
            this.v7 = v7;
            u = true;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Manage_Project mp = new Manage_Project();
            this.Close();
            mp.Show();
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
            if(login.Text=="SAVE")
            {
                client.addProject(textBox1.Text.ToString(), textBox2.Text.ToString(), textBox3.Text.ToString(),Convert.ToInt32(comboBox1.Text.ToString()),comboBox2.Text.ToString(),textBox4.Text.ToString()) ;
            }
            else
            {
                client.updateProject(v1, textBox1.Text.ToString(), textBox2.Text.ToString(), textBox3.Text.ToString(), Convert.ToInt32(comboBox1.Text.ToString()), comboBox2.Text.ToString(), textBox4.Text.ToString());
            }
            Manage_Project mp = new Manage_Project();
            this.Close();
            mp.Show();
        }

        private void Project_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hRMSDataSet2.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.hRMSDataSet2.Employee);
            if(u)
            {
                textBox1.Text = v2;
                textBox2.Text = v3;
                textBox3.Text = v4;
                comboBox1.SelectedItem = v5.ToString();
                comboBox2.SelectedItem = v6;
                textBox4.Text = v7;
                login.Text = "UPDATE";
            }

        }
    }
}
