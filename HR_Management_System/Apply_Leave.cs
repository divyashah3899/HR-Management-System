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
    public partial class Apply_Leave : Form
    {
        private int id;
        public Apply_Leave(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Employee_Leave_List ed = new Employee_Leave_List(id);
            this.Close();
            ed.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Employee_Dashboard ed = new Employee_Dashboard(id);
            this.Close();
            ed.Show();
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
            client.applyLeave(id, textBox1.Text.ToString(), comboBox1.Text.ToString(),dateTimePicker1.Value,dateTimePicker1.Value,textBox6.Text.ToString());
            MessageBox.Show("Applied For Leave.Wait for the Approval..");
            Employee_Leave_List ed = new Employee_Leave_List(id);
            this.Close();
            ed.Show();
        }
    }
}
