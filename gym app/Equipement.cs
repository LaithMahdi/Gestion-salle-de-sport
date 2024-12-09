using MySql.Data.MySqlClient;
using System.Data;

namespace gym_app
{
    public partial class Equipement : Form
    {
        private bool isUpdateMode = false;
        public Equipement()
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
                deliveryDate.Value = row.Cells["deliveryDate"] != null ? Convert.ToDateTime(row.Cells["deliveryDate"].Value) : DateTime.Now;
                category.Text = row.Cells["category"]?.Value?.ToString() ?? "";
                emplacement.Text = row.Cells["emplacement"]?.Value?.ToString() ?? "";
                status.Text = row.Cells["status"]?.Value?.ToString() ?? "";

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
                    string query = "SELECT * FROM equipement";
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
            string equipementID = id.Text.Trim();
            string equipementNameEuip = name.Text.Trim();
            string descriptionEquip = description.Text.Trim();
            string categoryEquip = category.Text.Trim();
            string deliveryDateEquip = deliveryDate.Value.ToString("yyyy-MM-dd");
            string statusEquip = status.Text.Trim();
            string emplacementEquip = emplacement.Text.Trim();

            // Validation des champs obligatoires
            if (string.IsNullOrWhiteSpace(equipementNameEuip) || string.IsNullOrWhiteSpace(categoryEquip))
            {
                MessageBox.Show("Veuillez remplir tous les champs obligatoires.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (isUpdateMode)
            {
                UpdateEquipment(equipementID, equipementNameEuip, descriptionEquip, categoryEquip, deliveryDateEquip, statusEquip, emplacementEquip);
            }
            else
            {
                AddEquipment(equipementID, equipementNameEuip, descriptionEquip, categoryEquip, deliveryDateEquip, statusEquip, emplacementEquip);
            }


            LoadDataIntoGridView();
        }


        private void AddEquipment(string id, string equipementName, string description, string category, string deliveryDate, string status, string emplacement)
        {
            string query = "INSERT INTO equipement (id, name, description, category, deliveryDate, status, emplacement) " +
                           "VALUES (@id, @name, @description, @category, @deliveryDate, @status, @emplacement)";

            using (MySqlConnection con = new MySqlConnection(DatabaseConfig.ConnectionString))
            {
                try
                {
                    con.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.Parameters.AddWithValue("@name", equipementName);
                        cmd.Parameters.AddWithValue("@description", description);
                        cmd.Parameters.AddWithValue("@category", category);
                        cmd.Parameters.AddWithValue("@deliveryDate", deliveryDate);
                        cmd.Parameters.AddWithValue("@status", status);
                        cmd.Parameters.AddWithValue("@emplacement", emplacement);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Équipement ajouté avec succès !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        resetFields();
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Erreur MySQL : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void UpdateEquipment(string id, string equipementName, string description, string category, string deliveryDate, string status, string emplacement)
        {
            string query = "UPDATE equipement SET name = @name, description = @description, category = @category, " +
                           "deliveryDate = @deliveryDate, status = @status, emplacement = @emplacement WHERE id = @id";

            using (MySqlConnection con = new MySqlConnection(DatabaseConfig.ConnectionString))
            {
                try
                {
                    con.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.Parameters.AddWithValue("@name", equipementName);
                        cmd.Parameters.AddWithValue("@description", description);
                        cmd.Parameters.AddWithValue("@category", category);
                        cmd.Parameters.AddWithValue("@deliveryDate", deliveryDate);
                        cmd.Parameters.AddWithValue("@status", status);
                        cmd.Parameters.AddWithValue("@emplacement", emplacement);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Équipement mis à jour avec succès !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            DialogResult result = MessageBox.Show("Êtes-vous sûr de vouloir supprimer cet équipement ?",
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
                MessageBox.Show("Veuillez sélectionner un équipement à supprimer.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string query = "DELETE FROM equipement WHERE id = @id";

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
                            MessageBox.Show("Équipement supprimé avec succès !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            resetFields();
                        }
                        else
                        {
                            MessageBox.Show("Aucun équipement trouvé avec cet ID.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Erreur MySQL : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void resetFields()
        {
            id.Text = "";
            name.Text = "";
            description.Text = "";
            category.Text = "";
            deliveryDate.Value = DateTime.Now;
            text.Text = "";
            emplacement.Text = "";
            status.Text = "";
            button1.Text = "Create";
            button1.BackColor = Color.Green;
        }


        private void Equipement_Load(object sender, EventArgs e)
        {
        }



        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void category_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

       
    }
}
