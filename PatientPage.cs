using Microsoft.Data.SqlClient;
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
    public partial class PatientPage : Form
    {
        public String connectionString = "Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = HospitalManagementSystem; Integrated Security = True; Encrypt = False; TrustServerCertificate = False"; 
        public PatientPage()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btn_patient_save_Click_1(object sender, EventArgs e)
        {
            String query = "INSERT INTO Patient(PFirstName, PLastName, Age, PGender, ContactNo, BloodType, NationalNumber, Disease, PAddress)" +
                            "VALUES (@PFirstName, @PLastName, @Age, @PGender, @ContactNo, @BloodType, @NationalNumber, @Disease, @PAddress)";

            using (SqlConnection conn2 = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn2))
                {
                    cmd.Parameters.AddWithValue("@PFirstName", txt_PatientName.Text);
                    cmd.Parameters.AddWithValue("@PLastName", txt_PatientLastName.Text);
                    cmd.Parameters.AddWithValue("@Age", txt_PatientAge.Text);
                    cmd.Parameters.AddWithValue("@PGender", txt_PatientGender.Text);
                    cmd.Parameters.AddWithValue("@ContactNo", txt_ContactNo.Text);
                    cmd.Parameters.AddWithValue("@BloodType", txt_BloodType.Text);
                    cmd.Parameters.AddWithValue("@NationalNumber", txt_NationalNumber.Text);
                    cmd.Parameters.AddWithValue("@Disease", txt_Disease.Text);
                    cmd.Parameters.AddWithValue("@PAddress", txt_PatientAddress.Text);

                    conn2.Open();
                    int result = cmd.ExecuteNonQuery();

                    if (result < 0)
                    {
                        MessageBox.Show("Error");
                    }
                    else
                    {
                        MessageBox.Show("Successful! ");
                    }
                }
            }
        }

        private void btn_patient_update_Click_1(object sender, EventArgs e)
        {
            String query = "UPDATE Patient SET PFirstName = @PFirstName, PLastName = @PLastName, Age = @Age, PGender = @PGender, ContactNo = @ContactNo, BloodType = @BloodType, " +
                "NationalNumber = @NationalNumber, Disease = @Disease, PAddress = @PAddress WHERE NationalNumber = @NationalNumber";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@PFirstName", txt_PatientName.Text);
                    cmd.Parameters.AddWithValue("@PLastName", txt_PatientLastName.Text);
                    cmd.Parameters.AddWithValue("@Age", txt_PatientAge.Text);
                    cmd.Parameters.AddWithValue("@PGender", txt_PatientGender.Text);
                    cmd.Parameters.AddWithValue("@ContactNo", txt_ContactNo.Text);
                    cmd.Parameters.AddWithValue("@BloodType", txt_BloodType.Text);
                    cmd.Parameters.AddWithValue("@NationalNumber", txt_NationalNumber.Text);
                    cmd.Parameters.AddWithValue("@Disease", txt_Disease.Text);
                    cmd.Parameters.AddWithValue("@PAddress", txt_PatientAddress.Text);

                    conn.Open();
                    int result = cmd.ExecuteNonQuery();

                    if (result < 0)
                    {
                        MessageBox.Show("Error");
                    }
                    else
                    {
                        MessageBox.Show("Successful! ");
                    }
                }
            }

        }

        private void btn_patient_delete_Click_1(object sender, EventArgs e)
        {
            String query = "DELETE FROM Patient WHERE (PFirstName = @PFirstName AND PLastName = PLastName)";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@PFirstName", txt_PatientName.Text);
                    cmd.Parameters.AddWithValue("@PLastName", txt_PatientLastName.Text);

                    conn.Open();
                    int result = cmd.ExecuteNonQuery();

                    if (result < 0)
                    {
                        MessageBox.Show("Error");
                    }
                    else
                    {
                        MessageBox.Show("Successful! ");
                    }
                }
            }
        }

        
        private void btn_PatientHome_Click_1(object sender, EventArgs e)
        {
            HomeForm homeForm = new HomeForm();
            homeForm.Show();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_PatientAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void List_Patient_Click_1(object sender, EventArgs e)
        {
            String query = "SELECT * FROM Patient";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter())
                    {
                        adapter.SelectCommand = cmd;
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        patient_gridView.DataSource = dataTable;
                    }
                }
            }
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void view_doctors_Click(object sender, EventArgs e)
        {
            String query = "SELECT * FROM PatientsDoctor";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter())
                    {
                        adapter.SelectCommand = cmd;
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        view_doctor_gridView.DataSource = dataTable;
                    }
                }
            }
        }
    }
}
