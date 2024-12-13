using MySql.Data.MySqlClient;
using System.Data;
using System.Xml.Linq;


namespace gym_app
{
    public partial class Coach : Form
    {
        private bool isUpdateMode = false;

        public Coach()
        {
            InitializeComponent();
            LoadDataIntoGridView();
        }


        private void LoadDataIntoGridView()
        {
            using (MySqlConnection con = new MySqlConnection(DatabaseConfig.ConnectionString))
            {
                try
                {
                    con.Open();
                    string query = "SELECT * FROM coach";
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

        private void onCellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                cin.Text = row.Cells["cin"]?.Value?.ToString() ?? "";
                lastName.Text = row.Cells["last_name"]?.Value?.ToString() ?? "";
                firstName.Text = row.Cells["first_name"]?.Value?.ToString() ?? "";
                email.Text = row.Cells["email"]?.Value?.ToString() ?? "";
                phoneNumber.Text = row.Cells["phone"]?.Value?.ToString() ?? "";
                specialty.Text = row.Cells["specialty"]?.Value?.ToString() ?? "";
                status.Text = row.Cells["availability"]?.Value?.ToString() == "True" ? "Disponible" : "Non Disponible";

                // Passer en mode mise à jour
                isUpdateMode = true;
                button1.Text = "Update";
                button1.BackColor = Color.Orange;
            }
        }



        private void button_click(object sender, EventArgs e)
        {
            // Récupérer les valeurs des champs
            string cinCoach = cin.Text.Trim();
            string lastnameCoach = lastName.Text.Trim();
            string firstnameCoach = firstName.Text.Trim();
            string emailCoach = email.Text.Trim();
            string phoneCoach = phoneNumber.Text.Trim();
            string specialityCoach = specialty.Text.Trim();
            string statusCoach = status.Text.Trim();

            bool availability = statusCoach == "Disponible" ? true : false;

            // Validation des champs obligatoires
            if (!Validator.IsNotEmpty(cinCoach))
            {
                MessageBox.Show("CIN est obligatoire.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!Validator.IsValidCIN(cinCoach))
            {
                MessageBox.Show("CIN doit être un nombre de 8 chiffres.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!Validator.IsNotEmpty(lastnameCoach))
            {
                MessageBox.Show("Nom est obligatoire.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!Validator.IsNotEmpty(firstnameCoach))
            {
                MessageBox.Show("Prénom est obligatoire.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!Validator.IsNotEmpty(emailCoach))
            {
                MessageBox.Show("Email est obligatoire.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!Validator.IsValidEmail(emailCoach))
            {
                MessageBox.Show("Email n'est pas valide.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!Validator.IsNotEmpty(phoneCoach))
            {
                MessageBox.Show("Numéro de téléphone est obligatoire.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!Validator.IsValidPhoneNumber(phoneCoach))
            {
                MessageBox.Show("Numéro de téléphone doit être un nombre de 8 chiffres.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!Validator.IsNotEmpty(specialityCoach))
            {
                MessageBox.Show("Spécialité est obligatoire.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!Validator.IsNotEmpty(statusCoach))
            {
                MessageBox.Show("Statut est obligatoire.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if (isUpdateMode)
            {
                updateCoach(int.Parse(cinCoach), lastnameCoach, firstnameCoach, emailCoach, int.Parse(phoneCoach), availability, specialityCoach);
            }
            else
            {
                addCoach(int.Parse(cinCoach), lastnameCoach, firstnameCoach, emailCoach, int.Parse(phoneCoach), availability, specialityCoach);
            }


            LoadDataIntoGridView();
        }


        private void addCoach(int cin, string lastname, string firstname, string email, int phone, bool availability, string specialty)
        {
            string query = "INSERT INTO coach (cin, last_name, first_name, email, phone, availability, specialty) " +
                           "VALUES (@cin, @lastname, @firstname, @email, @phone, @availability, @specialty)";

            using (MySqlConnection con = new MySqlConnection(DatabaseConfig.ConnectionString))
            {
                try
                {
                    con.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@cin", cin);
                        cmd.Parameters.AddWithValue("@lastname", lastname);
                        cmd.Parameters.AddWithValue("@firstname", firstname);
                        cmd.Parameters.AddWithValue("@email", email);
                        cmd.Parameters.AddWithValue("@phone", phone);
                        cmd.Parameters.AddWithValue("@availability", availability);
                        cmd.Parameters.AddWithValue("@specialty", specialty);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Coach ajouté avec succès !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        resetFields();
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Erreur MySQL : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void updateCoach(int cin, string lastname, string firstname, string email, int phone, bool availability, string specialty)
        {
            string query = "UPDATE coach SET last_name = @lastname, first_name = @firstname, email = @email, phone = @phone, availability = @availability, specialty = @specialty WHERE cin = @cin";
            using (MySqlConnection con = new MySqlConnection(DatabaseConfig.ConnectionString))
            {
                try
                {
                    con.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@cin", cin);
                        cmd.Parameters.AddWithValue("@lastname", lastname);
                        cmd.Parameters.AddWithValue("@firstname", firstname);
                        cmd.Parameters.AddWithValue("@email", email);
                        cmd.Parameters.AddWithValue("@phone", phone);
                        cmd.Parameters.AddWithValue("@availability", availability);
                        cmd.Parameters.AddWithValue("@specialty", specialty);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Coach modifié avec succès !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            string equipementID = cin.Text.Trim();

            // Confirm before deleting
            DialogResult result = MessageBox.Show("Êtes-vous sûr de vouloir supprimer cet coach ?",
                                                  "Confirmation",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                deleteCoach(equipementID);
                LoadDataIntoGridView();
            }
        }


        private void deleteCoach(string id)
        {
            if (string.IsNullOrWhiteSpace(id))
            {
                MessageBox.Show("Veuillez sélectionner un coach à supprimer.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            string query = "DELETE FROM coach WHERE cin = @cin";

            using (MySqlConnection con = new MySqlConnection(DatabaseConfig.ConnectionString))
            {
                try
                {
                    con.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@cin", id);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Coach supprimé avec succès !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            resetFields();
                        }
                        else
                        {
                            MessageBox.Show("Aucun coach trouvé avec cet cin.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            cin.Text = "";
            lastName.Text = "";
            firstName.Text = "";
            email.Text = "";
            phoneNumber.Text = "";
            specialty.Text = "";
            status.Text = "";
            button1.Text = "Create";
            button1.BackColor = Color.Green;
        }

  

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
