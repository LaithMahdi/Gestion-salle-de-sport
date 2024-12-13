
using gym_app;
using MySql.Data.MySqlClient;

namespace gym_app
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            try
            {
                DatabaseConnection.OpenConnection();
                //MessageBox.Show("Connexion réussie");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur de connexion à la base de données: " + ex.Message);
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string email = textBox1.Text;
            string password = textBox2.Text;

            // Perform validations
            if (!Validator.IsNotEmpty(email) || !Validator.IsNotEmpty(password))
            {
                MessageBox.Show("Veuillez remplir tous les champs");
                return;
            }

            if (!Validator.IsValidEmail(email))
            {
                MessageBox.Show("Veuillez saisir un email valide");
                return;
            }

            if (!Validator.IsValidPassword(password))
            {
                MessageBox.Show("Le mot de passe doit contenir au moins 8 caractères");
                return;
            }

            try
            {
                // Ensure connection is open
                DatabaseConnection.OpenConnection();

                // Create the query
                string query = "SELECT * FROM user WHERE email = @Email AND password = @Password";
                MySqlCommand command = DatabaseConnection.GetConnection().CreateCommand();
                command.CommandText = query;

                // Add parameters
                command.Parameters.AddWithValue("@Email", email);
                command.Parameters.AddWithValue("@Password", password);

                // Execute the query
                MySqlDataReader reader = command.ExecuteReader();

                if (reader.Read()) // If a record is found
                {
                    string name = reader["name"].ToString();
                    string role = reader["role"].ToString();

                    MessageBox.Show($"Bienvenue {name}, Role: {role}");

                    // Navigate to Form2
                    this.Hide();
                    Form2 form2 = new Form2();
                    form2.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Email ou mot de passe incorrect");
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la connexion: " + ex.Message);
            }
        }



    }
}
