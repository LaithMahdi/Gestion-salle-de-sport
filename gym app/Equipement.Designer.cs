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
            label1 = new Label();
            label2 = new Label();
            id = new TextBox();
            name = new TextBox();
            label3 = new Label();
            description = new TextBox();
            label4 = new Label();
            deliveryDate = new DateTimePicker();
            label5 = new Label();
            category = new ComboBox();
            label6 = new Label();
            label7 = new Label();
            emplacement = new ComboBox();
            button1 = new Button();
            button3 = new Button();
            button4 = new Button();
            groupBox1 = new GroupBox();
            status = new ComboBox();
            text = new Label();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(408, 76);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(627, 545);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += onCellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(1790, -137);
            label1.Name = "label1";
            label1.Size = new Size(150, 33);
            label1.TabIndex = 1;
            label1.Text = "Equipement";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Calibri", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(15, 19);
            label2.Name = "label2";
            label2.Size = new Size(24, 21);
            label2.TabIndex = 2;
            label2.Text = "Id";
            // 
            // id
            // 
            id.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            id.Location = new Point(15, 50);
            id.Name = "id";
            id.PlaceholderText = "id";
            id.ReadOnly = true;
            id.Size = new Size(313, 27);
            id.TabIndex = 3;
            // 
            // name
            // 
            name.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            name.Location = new Point(15, 118);
            name.Name = "name";
            name.PlaceholderText = "name";
            name.Size = new Size(313, 27);
            name.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(15, 87);
            label3.Name = "label3";
            label3.Size = new Size(52, 21);
            label3.TabIndex = 4;
            label3.Text = "Name";
            // 
            // description
            // 
            description.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            description.Location = new Point(15, 186);
            description.Name = "description";
            description.PlaceholderText = "description";
            description.Size = new Size(313, 27);
            description.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(15, 155);
            label4.Name = "label4";
            label4.Size = new Size(91, 21);
            label4.TabIndex = 6;
            label4.Text = "Description";
            // 
            // deliveryDate
            // 
            deliveryDate.CalendarFont = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            deliveryDate.Location = new Point(15, 254);
            deliveryDate.Name = "deliveryDate";
            deliveryDate.Size = new Size(305, 23);
            deliveryDate.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Calibri", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(15, 223);
            label5.Name = "label5";
            label5.Size = new Size(107, 21);
            label5.TabIndex = 9;
            label5.Text = "Delivery Date";
            // 
            // category
            // 
            category.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            category.FormattingEnabled = true;
            category.Items.AddRange(new object[] { "Équipements de musculation", "Cardio-training", "Équipements pour les cours collectifs", "Équipements de fitness et d'entraînement" });
            category.Location = new Point(15, 318);
            category.Name = "category";
            category.Size = new Size(305, 27);
            category.TabIndex = 10;
            category.SelectedIndexChanged += category_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Calibri", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(15, 287);
            label6.Name = "label6";
            label6.Size = new Size(73, 21);
            label6.TabIndex = 11;
            label6.Text = "Category";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Calibri", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(15, 355);
            label7.Name = "label7";
            label7.Size = new Size(107, 21);
            label7.TabIndex = 12;
            label7.Text = "Emplacement";
            // 
            // emplacement
            // 
            emplacement.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            emplacement.FormattingEnabled = true;
            emplacement.Items.AddRange(new object[] { "Salle de musculation", "Salle de cardio-training", "Salle de cours collectifs", "Salle de sports de combat ou arts martiaux", "Salle de sport fonctionnel" });
            emplacement.Location = new Point(15, 386);
            emplacement.Name = "emplacement";
            emplacement.Size = new Size(305, 27);
            emplacement.TabIndex = 13;
            // 
            // button1
            // 
            button1.BackColor = Color.Green;
            button1.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(80, 496);
            button1.Name = "button1";
            button1.Size = new Size(75, 34);
            button1.TabIndex = 14;
            button1.Text = "Create";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Red;
            button3.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Location = new Point(170, 496);
            button3.Name = "button3";
            button3.Size = new Size(75, 34);
            button3.TabIndex = 16;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = false;
            button3.Click += buttonDelete_Click;
            // 
            // button4
            // 
            button4.BackgroundImage = Properties.Resources.left_arrow_10117587;
            button4.BackgroundImageLayout = ImageLayout.Stretch;
            button4.Location = new Point(32, 17);
            button4.Name = "button4";
            button4.Size = new Size(43, 42);
            button4.TabIndex = 17;
            button4.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(status);
            groupBox1.Controls.Add(text);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(id);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(name);
            groupBox1.Controls.Add(emplacement);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(description);
            groupBox1.Controls.Add(deliveryDate);
            groupBox1.Controls.Add(category);
            groupBox1.Controls.Add(label5);
            groupBox1.Location = new Point(32, 76);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(350, 545);
            groupBox1.TabIndex = 18;
            groupBox1.TabStop = false;
            // 
            // status
            // 
            status.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            status.FormattingEnabled = true;
            status.Items.AddRange(new object[] { "Non Disponible", "En Entretien", "Disponible" });
            status.Location = new Point(15, 454);
            status.Name = "status";
            status.Size = new Size(305, 27);
            status.TabIndex = 18;
            // 
            // text
            // 
            text.AutoSize = true;
            text.Font = new Font("Calibri", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            text.Location = new Point(15, 423);
            text.Name = "text";
            text.Size = new Size(54, 21);
            text.TabIndex = 17;
            text.Text = "Status";
            text.Click += label9_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(81, 25);
            label8.Name = "label8";
            label8.Size = new Size(117, 26);
            label8.TabIndex = 19;
            label8.Text = "Equipement";
            // 
            // Equipement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = Properties.Resources.victor_freitas_KkYWWpurqbE_unsplash;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1098, 649);
            Controls.Add(label8);
            Controls.Add(groupBox1);
            Controls.Add(button4);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "Equipement";
            Text = "Equipement";
            Load += Equipement_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private TextBox id;
        private TextBox name;
        private Label label3;
        private TextBox description;
        private Label label4;
        private DateTimePicker deliveryDate;
        private Label label5;
        private ComboBox category;
        private Label label6;
        private Label label7;
        private ComboBox emplacement;
        private Button button1;
        private Button button3;
        private Button button4;
        private GroupBox groupBox1;
        private Label label8;
        private ComboBox status;
        private Label text;
    }


}