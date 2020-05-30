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
    public partial class Manage_Employee : Form
    {
        public Manage_Employee()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dataGridView1.DataSource;
            bs.Filter = string.Format("CONVERT(E_Id,System.String) like '{0}%' OR Fname like '{0}%' OR Lname like '{0}%' OR ContactNo_1 like '{0}%' OR ContactNo_2 like '{0}%' OR Email like '{0}%' OR Address like '{0}%' OR CONVERT(DOB,System.String) like '{0}%' OR Gender like '{0}%' OR Designation like '{0}%' OR AdharCard like '{0}%' OR EmployeeType like '{0}%' OR WorkExperience like '{0}%'", textBox1.Text.ToString()); ;
            dataGridView1.DataSource = bs;
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee();
            this.Close();
            emp.Show();
        }

        private void Manage_Employee_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hRMSDataSet5.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter1.Fill(this.hRMSDataSet5.Employee);
         

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow.Index != -1)
            {
                Employee emp = new Employee(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value), dataGridView1.CurrentRow.Cells[1].Value.ToString(), dataGridView1.CurrentRow.Cells[2].Value.ToString(), dataGridView1.CurrentRow.Cells[3].Value.ToString(), dataGridView1.CurrentRow.Cells[4].Value.ToString(), dataGridView1.CurrentRow.Cells[5].Value.ToString(), dataGridView1.CurrentRow.Cells[6].Value.ToString(), Convert.ToDateTime(dataGridView1.CurrentRow.Cells[7].Value), dataGridView1.CurrentRow.Cells[8].Value.ToString(), dataGridView1.CurrentRow.Cells[9].Value.ToString(), dataGridView1.CurrentRow.Cells[10].Value.ToString(), dataGridView1.CurrentRow.Cells[11].Value.ToString(), dataGridView1.CurrentRow.Cells[12].Value.ToString());
                Close();
                emp.Show();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow.Index != -1)
            {
                ServiceReference1.ServiceClient client = new ServiceReference1.ServiceClient();
                client.deleteEmployee(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));
                Manage_Employee me = new Manage_Employee();
                this.Close();
                me.Show();
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            HR_Dashbard hd = new HR_Dashbard();
            this.Close();
            hd.Show();
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
    }
}
