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
    public partial class Membre : Form
    {
        private bool isUpdateMode = false;
        float deflautPrice = 30;
        public Membre()
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
                    string query = "SELECT * FROM membre";
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, con))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dataGridView1.DataSource = dt;
                        price.Text = deflautPrice.ToString();
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
                id.Text = row.Cells["id"]?.Value?.ToString() ?? "";
                fullName.Text = row.Cells["full_name"]?.Value?.ToString() ?? "";
                dateBirth.Text = row.Cells["date_birth"]?.Value?.ToString() ?? "";
                email.Text = row.Cells["email"]?.Value?.ToString() ?? "";
                phoneNumber.Text = row.Cells["phone"]?.Value?.ToString() ?? "";
                gender.Text = row.Cells["gender"]?.Value?.ToString() ?? "";
                membershipTime.Text = row.Cells["membership_time"]?.Value?.ToString() ?? "";
                joinDate.Text = row.Cells["join_date"]?.Value?.ToString() ?? "";
                price.Text = row.Cells["price"]?.Value?.ToString() ?? deflautPrice.ToString();


                // Passer en mode mise à jour
                isUpdateMode = true;
                button1.Text = "Update";
                button1.BackColor = Color.Orange;
            }
        }


        private void button_click(object sender, EventArgs e)
        {
            // Récupérer les valeurs des champs
            string idMember = id.Text.Trim();
            string fullNameMember = fullName.Text.Trim();
            string birthDateMember = dateBirth.Value.ToString("yyyy-MM-dd");
            string emailMember = email.Text.Trim();
            string phoneCoach = phoneNumber.Text.Trim();
            string genderMember = gender.Text.Trim();
            string memberShipTimeMember = membershipTime.Text.Trim();
            string joinDateMember = joinDate.Value.ToString("yyyy-MM-dd");



            // Validation des champs obligatoires
            if (string.IsNullOrWhiteSpace(fullNameMember) || string.IsNullOrWhiteSpace(birthDateMember))
            {
                MessageBox.Show("Veuillez remplir tous les champs obligatoires.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (isUpdateMode)
            {
                updateMembre(int.Parse(idMember), fullNameMember, genderMember, birthDateMember, int.Parse(phoneCoach), emailMember, joinDateMember, memberShipTimeMember, float.Parse(price.Text));
            }
            else
            {
                addMembre(fullNameMember, genderMember, birthDateMember, int.Parse(phoneCoach), emailMember, joinDateMember, memberShipTimeMember, float.Parse(price.Text));
            }


            LoadDataIntoGridView();
        }

        private void addMembre(string fullName, string gender, string dateBirth, int phone, string email, string joinDate,string membershipTime,float price)
        {
            string query = "INSERT INTO membre (full_name, gender, date_birth, phone, email, join_date,membership_time,price) " +
                           "VALUES (@full_name, @gender, @date_birth,@email, @phone, @join_date,@membership_time,@price)";

            using (MySqlConnection con = new MySqlConnection(DatabaseConfig.ConnectionString))
            {
                try
                {
                    con.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@full_name", fullName);
                        cmd.Parameters.AddWithValue("@gender", gender);
                        cmd.Parameters.AddWithValue("@date_birth", dateBirth);
                        cmd.Parameters.AddWithValue("@phone", email);
                        cmd.Parameters.AddWithValue("@email", phone);
                        cmd.Parameters.AddWithValue("@join_date", joinDate);
                        cmd.Parameters.AddWithValue("@membership_time",membershipTime );
                        cmd.Parameters.AddWithValue("@price", price);


                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Membre ajouté avec succès !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        resetFields();
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Erreur MySQL : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void updateMembre(int id, string fullName, string gender, string dateBirth, int phone, string email, string joinDate, string membershipTime, float price)
        {
            string query = "UPDATE membre SET " +
                           "full_name=@full_name, gender=@gender, date_birth=@date_birth, phone=@phone, " +
                           "email=@email, join_date=@join_date, membership_time=@membership_time, price=@price " +
                           "WHERE id=@id";

            using (MySqlConnection con = new MySqlConnection(DatabaseConfig.ConnectionString))
            {
                try
                {
                    con.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.Parameters.AddWithValue("@full_name", fullName);
                        cmd.Parameters.AddWithValue("@gender", gender);
                        cmd.Parameters.AddWithValue("@date_birth", dateBirth);
                        cmd.Parameters.AddWithValue("@phone", phone);
                        cmd.Parameters.AddWithValue("@email", email);
                        cmd.Parameters.AddWithValue("@join_date", joinDate);
                        cmd.Parameters.AddWithValue("@membership_time", membershipTime);
                        cmd.Parameters.AddWithValue("@price", price);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Membre mis à jour avec succès !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Aucun membre trouvé avec cet ID.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
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
            DialogResult result = MessageBox.Show("Êtes-vous sûr de vouloir supprimer cet membre ?",
                                                  "Confirmation",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                deleteMembre(equipementID);
                LoadDataIntoGridView();
            }
        }


        private void deleteMembre(string id)
        {
            if (string.IsNullOrWhiteSpace(id))
            {
                MessageBox.Show("Veuillez sélectionner un membre à supprimer.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            string query = "DELETE FROM membre WHERE id = @id";

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
                            MessageBox.Show("Membre supprimé avec succès !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            resetFields();
                        }
                        else
                        {
                            MessageBox.Show("Aucun membre trouvé avec cet id.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            fullName.Text = "";
            dateBirth.Text = "";
            email.Text = "";
            phoneNumber.Text = "";
            gender.Text = "";
            membershipTime.Text = "";
            joinDate.Text = "";
            price.Text = deflautPrice.ToString();

            button1.Text = "Create";
            button1.BackColor = Color.Green;

        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void select_member(object sender, EventArgs e)
        {
            if (membershipTime.Text =="1 Month")
            {
                price.Text = (deflautPrice * 1).ToString();
            }
            else if (membershipTime.Text == "3 Month")
            {
                price.Text = (deflautPrice * 3).ToString();
            }
            else if (membershipTime.Text == "6 Month")
            {
                price.Text = (deflautPrice * 6).ToString();
            }
            else if (membershipTime.Text == "1 Year")
            {
                price.Text = (deflautPrice * 12).ToString();
            }
            
        }
    }
}
