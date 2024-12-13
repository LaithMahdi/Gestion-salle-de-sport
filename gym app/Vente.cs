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
    public partial class Vente : Form
    {
        double selectedProductPrice = 0;

        public Vente()
        {
            InitializeComponent();
            LoadDataIntoGridView();
            LoadMembers();
            LoadProducts();

            // Attach event handlers
            product.SelectedIndexChanged += Product_SelectedIndexChanged;
            quantity.TextChanged += Quantity_TextChanged;
        }

        private void LoadDataIntoGridView()
        {
            using (MySqlConnection con = new MySqlConnection(DatabaseConfig.ConnectionString))
            {
                try
                {
                    con.Open();
                    // Update the query to use JOINs to fetch customer names and product names
                    string query = @"
                SELECT 
                    sales.id AS 'Sale ID',
                    membre.full_name AS 'Customer Name',
                    product.name AS 'Product Name',
                    sales.quantity AS 'Quantity',
                    sales.total_price AS 'Total Price'
                FROM sales
                INNER JOIN membre ON sales.customer_id = membre.id
                INNER JOIN product ON sales.product_id = product.id";

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


        private void LoadMembers()
        {
            using (MySqlConnection con = new MySqlConnection(DatabaseConfig.ConnectionString))
            {
                try
                {
                    con.Open();
                    string query = "SELECT id, full_name FROM membre";
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, con))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        // Add placeholder row at the top
                        DataRow placeholderRow = dt.NewRow();
                        placeholderRow["id"] = DBNull.Value;
                        placeholderRow["full_name"] = "Veuillez sélectionner un membre";
                        dt.Rows.InsertAt(placeholderRow, 0);

                        // Bind the DataTable to the ComboBox
                        customer.DataSource = dt;
                        customer.DisplayMember = "full_name";
                        customer.ValueMember = "id";
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Erreur lors du chargement des données : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void LoadProducts()
        {
            using (MySqlConnection con = new MySqlConnection(DatabaseConfig.ConnectionString))
            {
                try
                {
                    con.Open();
                    string query = "SELECT id, name, quantity, price FROM product";
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, con))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        // Create a new column for the combined display
                        dt.Columns.Add("DisplayName", typeof(string));

                        // Populate the new column with concatenated values
                        foreach (DataRow row in dt.Rows)
                        {
                            row["DisplayName"] = $"{row["name"]} ({row["quantity"]})";
                        }

                        // Add placeholder row at the top
                        DataRow placeholderRow = dt.NewRow();
                        placeholderRow["id"] = DBNull.Value;
                        placeholderRow["DisplayName"] = "Veuillez sélectionner un produit";
                        dt.Rows.InsertAt(placeholderRow, 0);

                        // Bind the DataTable to the ComboBox
                        product.DataSource = dt;
                        product.DisplayMember = "DisplayName"; // Use the concatenated column
                        product.ValueMember = "id";

                        // Reset the default price
                        selectedProductPrice = 0;
                        price.Text = "0.00";
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Erreur lors du chargement des données : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void Product_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (product.SelectedItem != null)
            {
                DataRowView selectedRow = product.SelectedItem as DataRowView;
                if (selectedRow != null)
                {
                    // Check if the price is DBNull
                    if (selectedRow["price"] != DBNull.Value)
                    {
                        selectedProductPrice = Convert.ToDouble(selectedRow["price"]);
                        price.Text = selectedProductPrice.ToString();
                    }
                    else
                    {
                        // Handle case where price is DBNull (e.g., set a default value)
                        selectedProductPrice = 0;
                        price.Text = "0.00";
                    }

                    // Recalculate the total price based on the current quantity
                    UpdateTotalPrice();
                }
            }
        }


        private void Quantity_TextChanged(object sender, EventArgs e)
        {
            UpdateTotalPrice();
        }

        private void UpdateTotalPrice()
        {
            if (int.TryParse(quantity.Text, out int userQuantity))
            {
                double totalPrice = selectedProductPrice * userQuantity;
                price.Text = totalPrice.ToString("F2"); // Format to 2 decimal places
            }
            else
            {
                price.Text = "0.00";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (customer.SelectedValue == DBNull.Value || customer.SelectedIndex == 0)
            {
                MessageBox.Show("Veuillez sélectionner un membre.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (product.SelectedValue == DBNull.Value || product.SelectedIndex == 0)
            {
                MessageBox.Show("Veuillez sélectionner un produit.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrWhiteSpace(quantity.Text))
            {
                MessageBox.Show("Veuillez saisir une quantité.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            addSales();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            resetFields();
        }

        private void addSales()
        {
            string checkQuantityQuery = "SELECT quantity FROM product WHERE id = @product_id";
            string insertSaleQuery = "INSERT INTO sales (customer_id, product_id, quantity, total_price) " +
                                     "VALUES (@customer_id, @product_id, @quantity, @total_price)";
            string updateQuantityQuery = "UPDATE product SET quantity = quantity - @quantity WHERE id = @product_id";

            using (MySqlConnection con = new MySqlConnection(DatabaseConfig.ConnectionString))
            {
                try
                {
                    con.Open();

                    // Check if enough quantity is available
                    using (MySqlCommand checkCmd = new MySqlCommand(checkQuantityQuery, con))
                    {
                        checkCmd.Parameters.AddWithValue("@product_id", product.SelectedValue);
                        int availableQuantity = Convert.ToInt32(checkCmd.ExecuteScalar());

                        if (int.Parse(quantity.Text.Trim()) > availableQuantity)
                        {
                            MessageBox.Show($"La quantité demandée dépasse la quantité disponible ({availableQuantity}).", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }

                    // Insert the sale
                    using (MySqlCommand insertCmd = new MySqlCommand(insertSaleQuery, con))
                    {
                        insertCmd.Parameters.AddWithValue("@customer_id", customer.SelectedValue);
                        insertCmd.Parameters.AddWithValue("@product_id", product.SelectedValue);
                        insertCmd.Parameters.AddWithValue("@quantity", int.Parse(quantity.Text.Trim()));
                        insertCmd.Parameters.AddWithValue("@total_price", double.Parse(price.Text.Trim()));

                        insertCmd.ExecuteNonQuery();
                    }

                    // Update product quantity
                    using (MySqlCommand updateCmd = new MySqlCommand(updateQuantityQuery, con))
                    {
                        updateCmd.Parameters.AddWithValue("@quantity", int.Parse(quantity.Text.Trim()));
                        updateCmd.Parameters.AddWithValue("@product_id", product.SelectedValue);

                        updateCmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Vente ajoutée avec succès et quantité mise à jour !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    resetFields();
                    LoadDataIntoGridView();
                    LoadProducts(); // Reload products to update quantities in the ComboBox
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Erreur MySQL : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void resetFields()
        {
            customer.SelectedIndex = 0;
            product.SelectedIndex = 0;
            quantity.Text = "1";
            selectedProductPrice = 0;
            price.Text = "0.00";

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void id_TextChanged(object sender, EventArgs e)
        {

        }
    }


}
