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
    public partial class DoctorPage : Form
    {
        public String connectionString = "Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = HospitalManagementSystem; Integrated Security = True; Encrypt = False; TrustServerCertificate = False";
        public DoctorPage()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void DoctorPage_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btn_doctor_update_Click(object sender, EventArgs e)
        {
            String query = "UPDATE Doctor SET DFirstName = @DFirstName, DLastName = @DLastName, Age = @Age, DGender = @DGender, DPhoneNumber = @DPhoneNumber, Degree = @Degree, Specialization = @Specialization, DAddress = @DAddress WHERE DFirstName = @DFirstName AND DLastName = @DLastName";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@DFirstName", txt_DoctorName.Text);
                    cmd.Parameters.AddWithValue("@DLastName", txt_DoctorLastName.Text);
                    cmd.Parameters.AddWithValue("@Age", Convert.ToInt32((txt_DoctorAge.Text)));
                    cmd.Parameters.AddWithValue("@DGender", txt_DoctorGender.Text);
                    cmd.Parameters.AddWithValue("@DPhoneNumber", txt_DoctorPhone.Text);
                    cmd.Parameters.AddWithValue("@Degree", txt_DoctorDegree.Text);
                    cmd.Parameters.AddWithValue("@Specialization", txt_DoctorSpecial.Text);
                    cmd.Parameters.AddWithValue("@DAddress", txt_DoctorAddress.Text);

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

        private void btn_doctor_save_Click(object sender, EventArgs e)
        {

            String query = "INSERT INTO Doctor(DFirstName, DLastName, Age, DGender, DPhoneNumber, Degree, Specialization, DAddress)" +
                            "VALUES(@DFirstName, @DLastName, @Age, @DGender, @DPhoneNumber, @Degree, @Specialization, @DAddress)";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using(SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@DFirstName", txt_DoctorName.Text);
                    cmd.Parameters.AddWithValue("@DLastName", txt_DoctorLastName.Text);
                    cmd.Parameters.AddWithValue("@Age", txt_DoctorAge.Text);
                    cmd.Parameters.AddWithValue("@DGender", txt_DoctorGender.Text);
                    cmd.Parameters.AddWithValue("@DPhoneNumber", txt_DoctorPhone.Text);
                    cmd.Parameters.AddWithValue("@Degree", txt_DoctorDegree .Text);
                    cmd.Parameters.AddWithValue("@Specialization", txt_DoctorSpecial.Text);
                    cmd.Parameters.AddWithValue("@DAddress", txt_DoctorAddress.Text);

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

        private void btn_DoctorDelete_Click(object sender, EventArgs e)
        {
            String query = "DELETE FROM Doctor WHERE (DFirstName = @DFirstName AND DLastName = DLastName)";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@DFirstName", txt_DoctorName.Text);
                    cmd.Parameters.AddWithValue("@DLastName", txt_DoctorLastName.Text);

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

        private void doctor_gridView_CellContentClick(object sender, EventArgs e)
        {
                
            
            
        }

        private void btn_DoctorHome_Click(object sender, EventArgs e)
        {
            HomeForm homeForm = new HomeForm();
            homeForm.Show();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void List_Doctor_Click(object sender, EventArgs e)
        {
            String query = "SELECT * FROM Doctor";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter())
                    {
                        adapter.SelectCommand = cmd;
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        doctor_gridView.DataSource = dataTable;
                    }
                }
            }
        }
    }
}
