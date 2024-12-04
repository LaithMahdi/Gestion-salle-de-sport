using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace gym_app
{
    public partial class Equipement : Form
    {
        public Equipement()
        {
            InitializeComponent();
            LoadDataIntoGridView();

        }

        //private void Equipement_Load(object sender, EventArgs e)
        //{
        //    LoadDataIntoGridView();
        //}


    
       


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        
        }

       private void LoadDataIntoGridView()
{
            MySqlConnection databaseConnection = DatabaseConnection.GetConnection();
            //MySqlConnection databaseConnection = new MySqlConnection();
            //MySqlCommand commandDatabase = new MySqlCommand("SELECT id, name, description, deliveryDate, status, category, emplacement, réf FROM equipement", databaseConnection);

            try
    {
                databaseConnection.Open();
                using (MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT id, name, description, deliveryDate, status, category, emplacement, réf FROM equipement", databaseConnection))

                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;
                }

            }
            catch (Exception ex)
    {
        MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
    finally
    {
        // Ensure the connection is closed
        DatabaseConnection.CloseConnection();
    }
}



    }
}
