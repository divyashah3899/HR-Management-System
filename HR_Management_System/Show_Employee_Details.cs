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
    public partial class Show_Employee_Details : Form
    {
        private int id;
        public Show_Employee_Details(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void Show_Employee_Details_Load(object sender, EventArgs e)
        {
            ServiceReference1.ServiceClient client = new ServiceReference1.ServiceClient();
            ServiceReference1.Employee1 emp = new ServiceReference1.Employee1();
            emp = client.showDetails(id);
            textBox1.Text = emp.Fname;
            textBox2.Text = emp.Lname;
            textBox3.Text = emp.ContactNo_1;
            textBox4.Text = emp.ContactNo_2;
            textBox5.Text = emp.Email;
            textBox6.Text = emp.Address;
            dateTimePicker1.Value = emp.DOB;
            textBox10.Text = emp.Gender;
            textBox11.Text = emp.Designation;
            textBox8.Text = emp.AdharCard;
            textBox12.Text = emp.EmployeeType;
            textBox7.Text = emp.WorkExperience;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Employee_Dashboard em = new Employee_Dashboard(id);
            this.Close();
            em.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Employee_Dashboard em = new Employee_Dashboard(id);
            this.Close();
            em.Show();
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
