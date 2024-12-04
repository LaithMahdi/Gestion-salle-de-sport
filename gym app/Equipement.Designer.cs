namespace gym_app
{
    partial class Equipement
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
            dataGridView1 = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            name = new DataGridViewTextBoxColumn();
            description = new DataGridViewTextBoxColumn();
            deliveryDate = new DataGridViewTextBoxColumn();
            status = new DataGridViewTextBoxColumn();
            category = new DataGridViewTextBoxColumn();
            emplacement = new DataGridViewTextBoxColumn();
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox3 = new TextBox();
            label4 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label5 = new Label();
            comboBox1 = new ComboBox();
            label6 = new Label();
            label7 = new Label();
            comboBox2 = new ComboBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Id, name, description, deliveryDate, status, category, emplacement });
            dataGridView1.Location = new Point(397, 112);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(627, 323);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.Name = "Id";
            // 
            // name
            // 
            name.HeaderText = "Name";
            name.Name = "name";
            // 
            // description
            // 
            description.HeaderText = "Description";
            description.Name = "description";
            // 
            // deliveryDate
            // 
            deliveryDate.HeaderText = "Delivery Date";
            deliveryDate.Name = "deliveryDate";
            // 
            // status
            // 
            status.HeaderText = "Status";
            status.Name = "status";
            // 
            // category
            // 
            category.HeaderText = "Category";
            category.Name = "category";
            // 
            // emplacement
            // 
            emplacement.HeaderText = "Emplacement";
            emplacement.Name = "emplacement";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(397, 34);
            label1.Name = "label1";
            label1.Size = new Size(150, 33);
            label1.TabIndex = 1;
            label1.Text = "Equipement";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(32, 72);
            label2.Name = "label2";
            label2.Size = new Size(24, 21);
            label2.TabIndex = 2;
            label2.Text = "Id";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(32, 103);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "id";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(208, 27);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(32, 171);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "name";
            textBox2.Size = new Size(208, 27);
            textBox2.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(32, 140);
            label3.Name = "label3";
            label3.Size = new Size(52, 21);
            label3.TabIndex = 4;
            label3.Text = "Name";
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox3.Location = new Point(32, 239);
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "description";
            textBox3.Size = new Size(208, 27);
            textBox3.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(32, 208);
            label4.Name = "label4";
            label4.Size = new Size(91, 21);
            label4.TabIndex = 6;
            label4.Text = "Description";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarFont = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePicker1.Location = new Point(32, 307);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Calibri", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(32, 276);
            label5.Name = "label5";
            label5.Size = new Size(107, 21);
            label5.TabIndex = 9;
            label5.Text = "Delivery Date";
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Équipements de musculation", "Cardio-training", "Équipements pour les cours collectifs", "Équipements de fitness et d'entraînement" });
            comboBox1.Location = new Point(32, 371);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(200, 27);
            comboBox1.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Calibri", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(32, 340);
            label6.Name = "label6";
            label6.Size = new Size(73, 21);
            label6.TabIndex = 11;
            label6.Text = "Category";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Calibri", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(32, 408);
            label7.Name = "label7";
            label7.Size = new Size(107, 21);
            label7.TabIndex = 12;
            label7.Text = "Emplacement";
            // 
            // comboBox2
            // 
            comboBox2.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Salle de musculation", "Salle de cardio-training", "Salle de cours collectifs", "Salle de sports de combat ou arts martiaux", "Salle de sport fonctionnel" });
            comboBox2.Location = new Point(32, 439);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(200, 27);
            comboBox2.TabIndex = 13;
            // 
            // button1
            // 
            button1.BackColor = Color.Blue;
            button1.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(32, 492);
            button1.Name = "button1";
            button1.Size = new Size(75, 35);
            button1.TabIndex = 14;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.Green;
            button2.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(123, 492);
            button2.Name = "button2";
            button2.Size = new Size(75, 35);
            button2.TabIndex = 15;
            button2.Text = "Update";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.Red;
            button3.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Location = new Point(214, 492);
            button3.Name = "button3";
            button3.Size = new Size(75, 35);
            button3.TabIndex = 16;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackgroundImage = Properties.Resources.left_arrow_10117587;
            button4.BackgroundImageLayout = ImageLayout.Stretch;
            button4.Location = new Point(32, 12);
            button4.Name = "button4";
            button4.Size = new Size(43, 42);
            button4.TabIndex = 17;
            button4.UseVisualStyleBackColor = true;
            // 
            // Equipement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1074, 590);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(comboBox2);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(comboBox1);
            Controls.Add(label5);
            Controls.Add(dateTimePicker1);
            Controls.Add(textBox3);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "Equipement";
            Text = "Equipement";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn description;
        private DataGridViewTextBoxColumn deliveryDate;
        private DataGridViewTextBoxColumn status;
        private DataGridViewTextBoxColumn category;
        private DataGridViewTextBoxColumn emplacement;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox3;
        private Label label4;
        private DateTimePicker dateTimePicker1;
        private Label label5;
        private ComboBox comboBox1;
        private Label label6;
        private Label label7;
        private ComboBox comboBox2;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;


    }


}