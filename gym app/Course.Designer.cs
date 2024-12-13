namespace gym_app
{
    partial class Course
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
            duration = new TextBox();
            description = new RichTextBox();
            label6 = new Label();
            label2 = new Label();
            button3 = new Button();
            button1 = new Button();
            id = new TextBox();
            label3 = new Label();
            name = new TextBox();
            label4 = new Label();
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
            label8.Size = new Size(71, 26);
            label8.TabIndex = 23;
            label8.Text = "Course";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(duration);
            groupBox1.Controls.Add(description);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(id);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(name);
            groupBox1.Controls.Add(label4);
            groupBox1.Location = new Point(48, 81);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(350, 458);
            groupBox1.TabIndex = 22;
            groupBox1.TabStop = false;
            // 
            // duration
            // 
            duration.Location = new Point(15, 373);
            duration.Name = "duration";
            duration.Size = new Size(313, 23);
            duration.TabIndex = 18;
            duration.Text = "30";
            // 
            // description
            // 
            description.Location = new Point(15, 191);
            description.Name = "description";
            description.Size = new Size(313, 139);
            description.TabIndex = 17;
            description.Text = "";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Calibri", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(15, 341);
            label6.Name = "label6";
            label6.Size = new Size(72, 21);
            label6.TabIndex = 11;
            label6.Text = "Duration";
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
            // button3
            // 
            button3.BackColor = Color.Red;
            button3.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Location = new Point(164, 413);
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
            button1.Location = new Point(74, 413);
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
            id.Location = new Point(15, 51);
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
            label3.Location = new Point(15, 89);
            label3.Name = "label3";
            label3.Size = new Size(52, 21);
            label3.TabIndex = 4;
            label3.Text = "Name";
            // 
            // name
            // 
            name.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            name.Location = new Point(15, 121);
            name.Name = "name";
            name.PlaceholderText = "name";
            name.Size = new Size(313, 27);
            name.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(15, 159);
            label4.Name = "label4";
            label4.Size = new Size(91, 21);
            label4.TabIndex = 6;
            label4.Text = "Description";
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
            dataGridView1.Margin = new Padding(10);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 40;
            dataGridView1.Size = new Size(627, 458);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellClick += onCellClick;
            // 
            // Course
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.geert_pieters_3RnkZpDqsEI_unsplash;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1098, 569);
            Controls.Add(label8);
            Controls.Add(groupBox1);
            Controls.Add(button4);
            Controls.Add(dataGridView1);
            Name = "Course";
            Text = "Course";
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
        private TextBox name;
        private Label label4;
        private Button button4;
        private DataGridView dataGridView1;
        private TextBox duration;
        private RichTextBox description;
    }
}