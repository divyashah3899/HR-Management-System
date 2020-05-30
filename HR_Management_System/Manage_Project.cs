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
    public partial class Manage_Project : Form
    {
        public Manage_Project()
        {
            InitializeComponent();
        }

        private void Manage_Project_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hRMSDataSet3.Project' table. You can move, or remove it, as needed.
            this.projectTableAdapter1.Fill(this.hRMSDataSet3.Project);
            

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dataGridView1.DataSource;
            bs.Filter = string.Format("CONVERT(P_Id,System.String) like '{0}%' OR Name like '{0}%' OR Client like '{0}%' OR Duration like '{0}%' OR CONVERT(Manager,System.String) like '{0}%' OR Technology like '{0}%' OR Cost like '{0}%'", textBox1.Text.ToString()); ;
            dataGridView1.DataSource = bs;
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

        private void button1_Click(object sender, EventArgs e)
        {
            Project p = new Project();
            this.Close();
            p.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow.Index != -1)
            {
                Project p = new Project(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value), dataGridView1.CurrentRow.Cells[1].Value.ToString(), dataGridView1.CurrentRow.Cells[2].Value.ToString(), dataGridView1.CurrentRow.Cells[3].Value.ToString(), Convert.ToInt32(dataGridView1.CurrentRow.Cells[4].Value.ToString()), dataGridView1.CurrentRow.Cells[5].Value.ToString(), dataGridView1.CurrentRow.Cells[6].Value.ToString());
                Close();
                p.Show();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow.Index != -1)
            {
                ServiceReference1.ServiceClient client = new ServiceReference1.ServiceClient();
                client.deleteProject(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));
                Manage_Project me = new Manage_Project();
                this.Close();
                me.Show();
            }
        }
    }
}
