namespace gym_app
{
    partial class Product
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
            quantity = new TextBox();
            label1 = new Label();
            price = new TextBox();
            promotion = new CheckBox();
            category = new ComboBox();
            text = new Label();
            label2 = new Label();
            button3 = new Button();
            button1 = new Button();
            id = new TextBox();
            label3 = new Label();
            name = new TextBox();
            label7 = new Label();
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
            label8.Size = new Size(79, 26);
            label8.TabIndex = 23;
            label8.Text = "Product";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(quantity);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(price);
            groupBox1.Controls.Add(promotion);
            groupBox1.Controls.Add(category);
            groupBox1.Controls.Add(text);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(id);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(name);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label5);
            groupBox1.Location = new Point(48, 81);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(350, 500);
            groupBox1.TabIndex = 22;
            groupBox1.TabStop = false;
            // 
            // quantity
            // 
            quantity.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            quantity.Location = new Point(24, 340);
            quantity.Name = "quantity";
            quantity.PlaceholderText = "0 TND";
            quantity.Size = new Size(313, 27);
            quantity.TabIndex = 23;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(24, 307);
            label1.Name = "label1";
            label1.Size = new Size(72, 21);
            label1.TabIndex = 22;
            label1.Text = "Quantity";
            // 
            // price
            // 
            price.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            price.Location = new Point(24, 268);
            price.Name = "price";
            price.PlaceholderText = "0 TND";
            price.Size = new Size(313, 27);
            price.TabIndex = 21;
            // 
            // promotion
            // 
            promotion.AutoSize = true;
            promotion.Location = new Point(24, 412);
            promotion.Name = "promotion";
            promotion.RightToLeft = RightToLeft.No;
            promotion.Size = new Size(43, 19);
            promotion.TabIndex = 19;
            promotion.Text = "Yes";
            promotion.UseVisualStyleBackColor = true;
            // 
            // category
            // 
            category.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            category.FormattingEnabled = true;
            category.Items.AddRange(new object[] { "Fitness Equipment", "Free Weights", "Yoga & Pilates", "Cardio Accessories", "Sportswear & Apparel", "Nutrition & Supplements" });
            category.Location = new Point(24, 196);
            category.Name = "category";
            category.Size = new Size(313, 27);
            category.TabIndex = 18;
            // 
            // text
            // 
            text.AutoSize = true;
            text.Font = new Font("Calibri", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            text.Location = new Point(24, 163);
            text.Name = "text";
            text.Size = new Size(73, 21);
            text.TabIndex = 17;
            text.Text = "Category";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Calibri", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(24, 19);
            label2.Name = "label2";
            label2.Size = new Size(24, 21);
            label2.TabIndex = 2;
            label2.Text = "Id";
            // 
            // button3
            // 
            button3.BackColor = Color.Red;
            button3.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Location = new Point(166, 449);
            button3.Name = "button3";
            button3.Size = new Size(75, 34);
            button3.TabIndex = 16;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = false;
            button3.Click += buttonDelete_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Green;
            button1.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(76, 449);
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
            id.Location = new Point(24, 52);
            id.Name = "id";
            id.PlaceholderText = "id";
            id.ReadOnly = true;
            id.Size = new Size(313, 27);
            id.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(24, 91);
            label3.Name = "label3";
            label3.Size = new Size(52, 21);
            label3.TabIndex = 4;
            label3.Text = "Name";
            // 
            // name
            // 
            name.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            name.Location = new Point(24, 124);
            name.Name = "name";
            name.PlaceholderText = "name";
            name.Size = new Size(313, 27);
            name.TabIndex = 5;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Calibri", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(24, 379);
            label7.Name = "label7";
            label7.Size = new Size(85, 21);
            label7.TabIndex = 12;
            label7.Text = "Promotion";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Calibri", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(24, 235);
            label5.Name = "label5";
            label5.Size = new Size(45, 21);
            label5.TabIndex = 9;
            label5.Text = "Price";
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
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(424, 81);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 40;
            dataGridView1.Size = new Size(627, 500);
            dataGridView1.TabIndex = 20;
            dataGridView1.CellClick += onCellClick;
            // 
            // Product
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.ctrl_a_meal_replacement_03e4RajfFAE_unsplash;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1098, 614);
            Controls.Add(label8);
            Controls.Add(groupBox1);
            Controls.Add(button4);
            Controls.Add(dataGridView1);
            Name = "Product";
            Text = "Product";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label8;
        private GroupBox groupBox1;
        private Label text;
        private Label label2;
        private Button button3;
        private Button button1;
        private TextBox id;
        private Label label3;
        private TextBox name;
        private Label label7;
        private ComboBox category;
        private Label label5;
        private Button button4;
        private DataGridView dataGridView1;
        private Label label1;
        private TextBox price;
        private CheckBox promotion;
        private TextBox quantity;
    }
}