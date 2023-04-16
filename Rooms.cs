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
    public partial class Rooms : Form
    {
        public String connectionString = "Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = HospitalManagementSystem; Integrated Security = True; Encrypt = False; TrustServerCertificate = False";

        public Rooms()
        {
            InitializeComponent();
        }

        private void btn_room_Click(object sender, EventArgs e)
        {
            String query = "SELECT * FROM RoomInformation";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter())
                    {
                        adapter.SelectCommand = cmd;
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        room_GridView.DataSource = dataTable;
                    }
                }
            }
        }

        private void btn_find_Click(object sender, EventArgs e)
        {
            String query = "EXEC find_patientRoom @Patient_name = '"+txt_findByName.Text+"'";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                        conn.Open();
                    
                        SqlDataReader dr = cmd.ExecuteReader();

                        DataTable dataTable = new DataTable();
                        dataTable.Load(dr);
                        room_GridView.DataSource = dataTable;
                    
                }
            }
        }

        private void btn_RoomHome_Click(object sender, EventArgs e)
        {
            HomeForm homeForm = new HomeForm();
            homeForm.Show();
        }

        private void txt_findByName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
