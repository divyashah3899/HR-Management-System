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
    public partial class Employee_Dashboard : Form
    {
        private int id;
        public Employee_Dashboard(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Employee_Dashboard ed = new Employee_Dashboard(id);
            this.Close();
            ed.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Logging Out,Good Bye..");
            Login_As la = new Login_As();
            this.Close();
            la.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Employee_Leave_List al = new Employee_Leave_List(id);
            this.Close();
            al.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Show_Employee_Details se = new Show_Employee_Details(id);
            this.Close();
            se.Show();
        }
    }
}
