using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalManagementSystem
{
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
        }

        private void HomeForm_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {


        }

        private void Doctor_Click(object sender, EventArgs e)
        {
            DoctorPage doctorPage = new DoctorPage();
            doctorPage.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EmployeePage employeePage = new EmployeePage(); 
            employeePage.Show();    
        }

        private void btn_patient_Click(object sender, EventArgs e)
        {
            PatientPage patientPage = new PatientPage();
            patientPage.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Rooms rooms = new Rooms();
            rooms.Show();  
        }
    }
}
