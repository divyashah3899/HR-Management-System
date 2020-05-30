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
    public partial class Employee_Leave_List : Form
    {
        private int id;
        public Employee_Leave_List(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void Employee_Leave_List_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hRMSDataSet6.Leave' table. You can move, or remove it, as needed.
            this.leaveTableAdapter.Fill(this.hRMSDataSet6.Leave);
            BindingSource bs = new BindingSource();
            bs.DataSource = dataGridView1.DataSource;
            bs.Filter = string.Format("CONVERT(E_Id,System.String) like '{0}%'", id.ToString()); ; ;
            dataGridView1.DataSource = bs;

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Employee_Dashboard ed = new Employee_Dashboard(id);
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

        private void button1_Click(object sender, EventArgs e)
        {
            Apply_Leave al = new Apply_Leave(id);
            Close();
            al.Show();
        }
    }
}
