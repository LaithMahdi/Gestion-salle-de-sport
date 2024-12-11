using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace gym_app
{
    public partial class Product : Form
    {
        private bool isUpdateMode = false;

        public Product()
        {
            InitializeComponent();
            LoadDataIntoGridView(); // Load initial data into the DataGridView
        }

        // Event handler for when a DataGridView cell is clicked
        private void onCellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Retrieve data from the selected row and populate form fields
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                id.Text = row.Cells["id"]?.Value?.ToString() ?? "";
                name.Text = row.Cells["name"]?.Value?.ToString() ?? "";
                category.Text = row.Cells["category"]?.Value?.ToString() ?? "";
                price.Text = row.Cells["price"]?.Value?.ToString() ?? "";
                quantity.Text = row.Cells["quantity"]?.Value?.ToString() ?? "";
                promotion.Checked = (row.Cells["promotion"]?.Value?.ToString() ?? "") == "1";

                // Switch to update mode
                isUpdateMode = true;
                button1.Text = "Update";
                button1.BackColor = Color.Orange;
            }
        }

        // Load product data into the DataGridView
        private void LoadDataIntoGridView()
        {
            using (MySqlConnection con = new MySqlConnection(DatabaseConfig.ConnectionString))
            {
                try
                {
                    con.Open();
                    string query = "SELECT * FROM product";
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, con))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dataGridView1.DataSource = dt; // Bind data to DataGridView
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error loading data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Handle create or update actions
        private void button1_Click(object sender, EventArgs e)
        {
            // Retrieve form values
            string productId = id.Text.Trim();
            string productName = name.Text.Trim();
            string productCategory = category.Text.Trim();
            string productPriceText = price.Text.Trim();
            string productQuantityText = quantity.Text.Trim();
            int promotionValue = promotion.Checked ? 1 : 0;

            // Validate mandatory fields
            if (string.IsNullOrWhiteSpace(productName) || string.IsNullOrWhiteSpace(productCategory))
            {
                MessageBox.Show("Please fill in all required fields (Name and Category).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validate numeric fields
            if (!double.TryParse(productPriceText, out double productPrice) || productPrice <= 0)
            {
                MessageBox.Show("Please enter a valid positive price.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(productQuantityText, out int productQuantity) || productQuantity < 0)
            {
                MessageBox.Show("Please enter a valid non-negative quantity.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Perform create or update operation based on mode
            if (isUpdateMode)
            {
                updateProduct(productId, productName, productCategory, productPrice, productQuantity, promotionValue);
            }
            else
            {
                addProduct(productName, productCategory, productPrice, productQuantity, promotionValue);
            }

            LoadDataIntoGridView(); // Refresh the DataGridView after the operation
        }

        // Add a new product to the database
        private void addProduct(string name, string category, double price, int quantity, int promotion)
        {
            string query = "INSERT INTO product (name, category, price, quantity, promotion) VALUES (@name, @category, @price, @quantity, @promotion)";
            using (MySqlConnection con = new MySqlConnection(DatabaseConfig.ConnectionString))
            {
                try
                {
                    con.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        // Bind parameters
                        cmd.Parameters.AddWithValue("@name", name);
                        cmd.Parameters.AddWithValue("@category", category);
                        cmd.Parameters.AddWithValue("@price", price);
                        cmd.Parameters.AddWithValue("@quantity", quantity);
                        cmd.Parameters.AddWithValue("@promotion", promotion);
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Product added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        resetFields();
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("MySQL Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Update an existing product in the database
        private void updateProduct(string id, string name, string category, double price, int quantity, int promotion)
        {
            string query = "UPDATE product SET name = @name, category = @category, price = @price, quantity = @quantity, promotion = @promotion WHERE id = @id";
            using (MySqlConnection con = new MySqlConnection(DatabaseConfig.ConnectionString))
            {
                try
                {
                    con.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        // Bind parameters
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.Parameters.AddWithValue("@name", name);
                        cmd.Parameters.AddWithValue("@category", category);
                        cmd.Parameters.AddWithValue("@price", price);
                        cmd.Parameters.AddWithValue("@quantity", quantity);
                        cmd.Parameters.AddWithValue("@promotion", promotion);
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Product updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        resetFields();
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("MySQL Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Delete a product from the database
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            string productId = id.Text.Trim();

            // Confirm before deleting
            DialogResult result = MessageBox.Show("Are you sure you want to delete this product?",
                                                  "Confirmation",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                DeleteProduct(productId);
                LoadDataIntoGridView();
            }
        }

        private void DeleteProduct(string id)
        {
            if (string.IsNullOrWhiteSpace(id))
            {
                MessageBox.Show("Please select a product to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string query = "DELETE FROM product WHERE id = @id";
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
                            MessageBox.Show("Product deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            resetFields();
                        }
                        else
                        {
                            MessageBox.Show("No product found with this ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("MySQL Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Reset all form fields and toggle to create mode
        private void resetFields()
        {
            id.Text = "";
            name.Text = "";
            category.Text = "";
            price.Text = "";
            quantity.Text = "";
            promotion.Checked = false;
            isUpdateMode = false;
            button1.Text = "Create";
            button1.BackColor = Color.Green;
        }
    }
}
