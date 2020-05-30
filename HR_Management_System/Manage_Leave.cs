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
    public partial class Manage_Leave : Form
    {
        public Manage_Leave()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dataGridView1.DataSource;
            bs.Filter = string.Format("CONVERT(L_Id,System.String) like '{0}%' OR CONVERT(E_Id,System.String) like '{0}%' OR Fname like '{0}%' OR Leave_Type like '{0}%' OR CONVERT(Start_Date,System.String) like '{0}%' OR CONVERT(End_Date,System.String) like '{0}%' OR Reason like '{0}%' OR Status like '{0}%'", textBox1.Text.ToString()); ;
            dataGridView1.DataSource = bs;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow.Index != -1)
            {
                ServiceReference1.ServiceClient client = new ServiceReference1.ServiceClient();
                client.setLeaveStatus(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value), "Approved");
                MessageBox.Show("Employee will be notified.");
                Manage_Leave me = new Manage_Leave();
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

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow.Index != -1)
            {
                if (dataGridView1.CurrentRow.Cells[7].Value.ToString() == "Waiting")
                {
                    ServiceReference1.ServiceClient client = new ServiceReference1.ServiceClient();
                    client.setLeaveStatus(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value), "Rejected");
                    MessageBox.Show("Employee will be notified.");
                    Manage_Leave me = new Manage_Leave();
                    this.Close();
                    me.Show();
                }
                else
                {
                    MessageBox.Show("Already the request is completed.");
                }
            }
        }

        private void Manage_Leave_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hRMSDataSet4.Leave' table. You can move, or remove it, as needed.
            this.leaveTableAdapter.Fill(this.hRMSDataSet4.Leave);

        }
    }
}
