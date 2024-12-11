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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace gym_app
{
    public partial class Course : Form
    {
        private bool isUpdateMode = false;
        public Course()
        {
            InitializeComponent();
            LoadDataIntoGridView();
        }

        private void onCellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                id.Text = row.Cells["id"]?.Value?.ToString() ?? "";
                name.Text = row.Cells["name"]?.Value?.ToString() ?? "";
                description.Text = row.Cells["description"]?.Value?.ToString() ?? "";
                duration.Text = row.Cells["duration"]?.Value?.ToString() ?? "";

                // Passer en mode mise à jour
                isUpdateMode = true;
                button1.Text = "Update";
                button1.BackColor = Color.Orange;
            }
        }

        private void LoadDataIntoGridView()
        {
            using (MySqlConnection con = new MySqlConnection(DatabaseConfig.ConnectionString))
            {
                try
                {
                    con.Open();
                    string query = "SELECT * FROM course";
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, con))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dataGridView1.DataSource = dt;
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Erreur lors du chargement des données : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Récupérer les valeurs des champs
            string courseID = id.Text.Trim();
            string courseName = name.Text.Trim();
            string courseDescription = description.Text.Trim();
            int courseDuration = int.Parse(duration.Text.Trim());

            // Validation des champs obligatoires
            if (string.IsNullOrWhiteSpace(courseName) || string.IsNullOrWhiteSpace(courseDescription))
            {
                MessageBox.Show("Veuillez remplir tous les champs obligatoires.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (isUpdateMode)
            {
                updateCourse(courseID, courseName, courseDescription, courseDuration);
            }
            else
            {
                addCourse(courseName, courseDescription, courseDuration);
            }


            LoadDataIntoGridView();
        }

        private void addCourse(string courseName, string courseDescription, int courseDuration)
        {
            string query = "INSERT INTO course (name,description,duration) " +
                           "VALUES (@name, @description, @duration)";

            using (MySqlConnection con = new MySqlConnection(DatabaseConfig.ConnectionString))
            {
                try
                {
                    con.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@name", courseName);
                        cmd.Parameters.AddWithValue("@description", courseDescription);
                        cmd.Parameters.AddWithValue("@duration", courseDuration);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Cours ajouté avec succès !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        resetFields();
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Erreur MySQL : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void updateCourse(string courseID, string courseName, string courseDescription, int courseDuration)
        {
            string query = "UPDATE course SET name = @name, description = @description, duration = @duration WHERE id = @id";
            using (MySqlConnection con = new MySqlConnection(DatabaseConfig.ConnectionString))
            {
                try
                {
                    con.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@id", courseID);
                        cmd.Parameters.AddWithValue("@name", courseName);
                        cmd.Parameters.AddWithValue("@description", courseDescription);
                        cmd.Parameters.AddWithValue("@duration", courseDuration);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Cours modifié avec succès !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        resetFields();
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Erreur MySQL : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            string equipementID = id.Text.Trim();

            // Confirm before deleting
            DialogResult result = MessageBox.Show("Êtes-vous sûr de vouloir supprimer cet cour ?",
                                                  "Confirmation",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                DeleteEquipment(equipementID);
                LoadDataIntoGridView();
            }
        }


        private void DeleteEquipment(string id)
        {
            if (string.IsNullOrWhiteSpace(id))
            {
                MessageBox.Show("Veuillez sélectionner un cour à supprimer.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string query = "DELETE FROM course WHERE id = @id";

            using (MySqlConnection con = new MySqlConnection(DatabaseConfig.ConnectionString))
            {
                try
                {
                    con.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@id", id);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Cour supprimé avec succès !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            resetFields();
                        }
                        else
                        {
                            MessageBox.Show("Aucun cour trouvé avec cet ID.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Erreur MySQL : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        void resetFields()
        {
            id.Text = "";
            name.Text = "";
            description.Text = "";
            duration.Text = "";
            button1.Text = "Create";
            button1.BackColor = Color.Green;
        }



        private void Course_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
