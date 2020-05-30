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
    public partial class HR_Dashbard : Form
    {
        public HR_Dashbard()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Manage_Employee me = new Manage_Employee();
            this.Close();
            me.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            HR_Dashbard hd = new HR_Dashbard();
            this.Close();
            hd.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Logging Out,Good Bye..");
            Login_As la = new Login_As();
            this.Close();
            la.Show();
        }

        private void HR_Dashbard_Load(object sender, EventArgs e)
        {
            ServiceReference1.ServiceClient client = new ServiceReference1.ServiceClient();
            label3.Text = client.totalEmployee().ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Manage_Project mp = new Manage_Project();
            this.Close();
            mp.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Manage_Leave ml = new Manage_Leave();
            this.Close();
            ml.Show();
        }
    }
}
