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
    public partial class EmployeePage : Form
    {
        public String connectionString = "Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = HospitalManagementSystem; Integrated Security = True; Encrypt = False; TrustServerCertificate = False";

        public EmployeePage()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btn_patient_save_Click(object sender, EventArgs e)
        {
            String query = "INSERT INTO Employee (EFirstName, ELastName, Age, EGender, EPhoneNumber, EmployeeType, Salary, EAddress)" +
                            "VALUES(@EFirstName, @ELastName, @Age, @EGender, @EPhoneNumber, @EmployeeType, @Salary, @EAddress)";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@EFirstName", txt_EmployeeName.Text);
                    cmd.Parameters.AddWithValue("@ELastName", txt_EmployeeLastName.Text);
                    cmd.Parameters.AddWithValue("@Age", Convert.ToInt32((txt_EmployeeAge.Text)));
                    cmd.Parameters.AddWithValue("@EGender", txt_EmployeeGender.Text);
                    cmd.Parameters.AddWithValue("@EPhoneNumber", txt_EmployeePhoneNumber.Text);
                    cmd.Parameters.AddWithValue("@EmployeeType", txt_EmployeeType.Text);
                    cmd.Parameters.AddWithValue("@Salary", Convert.ToInt32((txt_Salary.Text)));
                    cmd.Parameters.AddWithValue("@EAddress", txt_EmployeeAddress.Text);

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

        private void btn_employee_update_Click(object sender, EventArgs e)
        {
            String query = "UPDATE Employee SET EFirstName = @EFirstName, ELastName = @ELastName, Age = @Age, EGender = @EGender, EPhoneNumber = @EPhoneNumber, EmployeeType = @EmployeeType, Salary = @Salary, EAddress = @EAddress WHERE EFirstName = @EFirstName AND ELastName = @ELastName";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@EFirstName", txt_EmployeeName.Text);
                    cmd.Parameters.AddWithValue("@ELastName", txt_EmployeeLastName.Text);
                    cmd.Parameters.AddWithValue("@Age", Convert.ToInt32((txt_EmployeeAge.Text)));
                    cmd.Parameters.AddWithValue("@EGender", txt_EmployeeGender.Text);
                    cmd.Parameters.AddWithValue("@EPhoneNumber", txt_EmployeePhoneNumber.Text);
                    cmd.Parameters.AddWithValue("@EmployeeType", txt_EmployeeType.Text);
                    cmd.Parameters.AddWithValue("@Salary", Convert.ToInt32((txt_Salary.Text)));
                    cmd.Parameters.AddWithValue("@EAddress", txt_EmployeeAddress.Text);

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

        private void btn_employee_delete_Click(object sender, EventArgs e)
        {
            String query = "DELETE FROM Employee WHERE (EFirstName = @EFirstName AND ELastName = ELastName)";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@EFirstName", txt_EmployeeName.Text);
                    cmd.Parameters.AddWithValue("@ELastName", txt_EmployeeLastName.Text);

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

        private void btn_PatientHome_Click(object sender, EventArgs e)
        {
            HomeForm homeForm = new HomeForm();
            homeForm.Show();
        }

        private void List_Employee_Click(object sender, EventArgs e)
        {
            String query = "SELECT * FROM Employee";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter())
                    {
                        adapter.SelectCommand = cmd;
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        employee_gridView.DataSource = dataTable;   
                    }
                }
            }
        }
    }
}
