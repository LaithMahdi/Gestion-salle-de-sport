namespace gym_app
{
    partial class Vente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label8 = new Label();
            groupBox1 = new GroupBox();
            label6 = new Label();
            label2 = new Label();
            quantity = new TextBox();
            button3 = new Button();
            button1 = new Button();
            id = new TextBox();
            label3 = new Label();
            product = new ComboBox();
            label4 = new Label();
            price = new Label();
            customer = new ComboBox();
            label5 = new Label();
            button4 = new Button();
            dataGridView1 = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(97, 30);
            label8.Name = "label8";
            label8.Size = new Size(56, 26);
            label8.TabIndex = 23;
            label8.Text = "Sales";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(quantity);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(id);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(product);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(price);
            groupBox1.Controls.Add(customer);
            groupBox1.Controls.Add(label5);
            groupBox1.Location = new Point(48, 81);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(350, 435);
            groupBox1.TabIndex = 22;
            groupBox1.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Calibri", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(20, 291);
            label6.Name = "label6";
            label6.Size = new Size(45, 21);
            label6.TabIndex = 11;
            label6.Text = "Price";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Calibri", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(20, 19);
            label2.Name = "label2";
            label2.Size = new Size(24, 21);
            label2.TabIndex = 2;
            label2.Text = "Id";
            // 
            // quantity
            // 
            quantity.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            quantity.Location = new Point(20, 254);
            quantity.Name = "quantity";
            quantity.PlaceholderText = "description";
            quantity.Size = new Size(313, 27);
            quantity.TabIndex = 7;
            quantity.Text = "1";
            // 
            // button3
            // 
            button3.BackColor = Color.Red;
            button3.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Location = new Point(174, 378);
            button3.Name = "button3";
            button3.Size = new Size(75, 34);
            button3.TabIndex = 16;
            button3.Text = "Reset";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Green;
            button1.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(84, 378);
            button1.Name = "button1";
            button1.Size = new Size(75, 34);
            button1.TabIndex = 14;
            button1.Text = "Create";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // id
            // 
            id.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            id.Location = new Point(20, 50);
            id.Name = "id";
            id.PlaceholderText = "id";
            id.ReadOnly = true;
            id.Size = new Size(313, 27);
            id.TabIndex = 3;
            id.TextChanged += id_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(20, 87);
            label3.Name = "label3";
            label3.Size = new Size(79, 21);
            label3.TabIndex = 4;
            label3.Text = "Customer";
            // 
            // product
            // 
            product.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            product.FormattingEnabled = true;
            product.Items.AddRange(new object[] { "Salle de musculation", "Salle de cardio-training", "Salle de cours collectifs", "Salle de sports de combat ou arts martiaux", "Salle de sport fonctionnel" });
            product.Location = new Point(20, 186);
            product.Name = "product";
            product.Size = new Size(313, 27);
            product.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(20, 155);
            label4.Name = "label4";
            label4.Size = new Size(65, 21);
            label4.TabIndex = 6;
            label4.Text = "Product";
            // 
            // price
            // 
            price.AutoSize = true;
            price.Font = new Font("Calibri", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            price.Location = new Point(20, 322);
            price.Name = "price";
            price.Size = new Size(106, 42);
            price.TabIndex = 12;
            price.Text = "0 TND";
            // 
            // customer
            // 
            customer.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            customer.FormattingEnabled = true;
            customer.Location = new Point(20, 118);
            customer.Name = "customer";
            customer.Size = new Size(313, 27);
            customer.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Calibri", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(20, 223);
            label5.Name = "label5";
            label5.Size = new Size(72, 21);
            label5.TabIndex = 9;
            label5.Text = "Quantity";
            // 
            // button4
            // 
            button4.BackgroundImage = Properties.Resources.left_arrow_10117587;
            button4.BackgroundImageLayout = ImageLayout.Stretch;
            button4.Location = new Point(48, 22);
            button4.Name = "button4";
            button4.Size = new Size(43, 42);
            button4.TabIndex = 21;
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(424, 81);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(627, 435);
            dataGridView1.TabIndex = 20;
            // 
            // Vente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.sven_mieke_MsCgmHuirDo_unsplash;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1098, 547);
            Controls.Add(label8);
            Controls.Add(groupBox1);
            Controls.Add(button4);
            Controls.Add(dataGridView1);
            Name = "Vente";
            Text = "Vente";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label8;
        private GroupBox groupBox1;
        private Label label6;
        private Label label2;
        private Button button3;
        private Button button1;
        private TextBox id;
        private Label label3;
        private ComboBox product;
        private Label label4;
        private Label price;
        private TextBox quantity;
        private ComboBox customer;
        private Label label5;
        private Button button4;
        private DataGridView dataGridView1;
    }
}