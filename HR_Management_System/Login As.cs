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
    public partial class Login_As : Form
    {
        public Login_As()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HR_Login hr = new HR_Login();
            this.Hide();
            hr.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Employee_Login el = new Employee_Login();
            this.Hide();
            el.Show();
        }
    }
}
