namespace gym_app
{
    partial class Coach
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
            phoneNumber = new TextBox();
            email = new TextBox();
            status = new ComboBox();
            text = new Label();
            label6 = new Label();
            label2 = new Label();
            button3 = new Button();
            button1 = new Button();
            cin = new TextBox();
            label3 = new Label();
            lastName = new TextBox();
            specialty = new ComboBox();
            label4 = new Label();
            label7 = new Label();
            firstName = new TextBox();
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
            label8.Size = new Size(64, 26);
            label8.TabIndex = 23;
            label8.Text = "Coach";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(phoneNumber);
            groupBox1.Controls.Add(email);
            groupBox1.Controls.Add(status);
            groupBox1.Controls.Add(text);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(cin);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(lastName);
            groupBox1.Controls.Add(specialty);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(firstName);
            groupBox1.Controls.Add(label5);
            groupBox1.Location = new Point(48, 81);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(350, 545);
            groupBox1.TabIndex = 22;
            groupBox1.TabStop = false;
            // 
            // phoneNumber
            // 
            phoneNumber.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            phoneNumber.Location = new Point(15, 311);
            phoneNumber.MaxLength = 8;
            phoneNumber.Name = "phoneNumber";
            phoneNumber.PlaceholderText = "+216 99 888 777";
            phoneNumber.Size = new Size(313, 27);
            phoneNumber.TabIndex = 20;
            // 
            // email
            // 
            email.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            email.Location = new Point(15, 247);
            email.Name = "email";
            email.PlaceholderText = "E-mail";
            email.Size = new Size(313, 27);
            email.TabIndex = 19;
            // 
            // status
            // 
            status.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            status.FormattingEnabled = true;
            status.Items.AddRange(new object[] { "Non Disponible", "Disponible" });
            status.Location = new Point(15, 454);
            status.Name = "status";
            status.Size = new Size(313, 27);
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
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Calibri", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(15, 287);
            label6.Name = "label6";
            label6.Size = new Size(55, 21);
            label6.TabIndex = 11;
            label6.Text = "Phone";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Calibri", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(15, 19);
            label2.Name = "label2";
            label2.Size = new Size(35, 21);
            label2.TabIndex = 2;
            label2.Text = "CIN";
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
            button1.Click += button_click;
            // 
            // cin
            // 
            cin.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cin.Location = new Point(15, 50);
            cin.MaxLength = 8;
            cin.Name = "cin";
            cin.PlaceholderText = "CIN";
            cin.Size = new Size(313, 27);
            cin.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(15, 87);
            label3.Name = "label3";
            label3.Size = new Size(80, 21);
            label3.TabIndex = 4;
            label3.Text = "LastName";
            // 
            // lastName
            // 
            lastName.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lastName.Location = new Point(15, 118);
            lastName.Name = "lastName";
            lastName.PlaceholderText = "lastname";
            lastName.Size = new Size(313, 27);
            lastName.TabIndex = 5;
            // 
            // specialty
            // 
            specialty.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            specialty.FormattingEnabled = true;
            specialty.Items.AddRange(new object[] { "Bodybuilding and Physique Training", "Group Fitness Instruction", "CrossFit and Functional Training", "Yoga and Flexibility Training", "Rehabilitation", "Strength and Conditioning", "Personal Training " });
            specialty.Location = new Point(15, 386);
            specialty.Name = "specialty";
            specialty.Size = new Size(313, 27);
            specialty.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(15, 155);
            label4.Name = "label4";
            label4.Size = new Size(83, 21);
            label4.TabIndex = 6;
            label4.Text = "FirstName";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Calibri", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(15, 355);
            label7.Name = "label7";
            label7.Size = new Size(73, 21);
            label7.TabIndex = 12;
            label7.Text = "Specialty";
            // 
            // firstName
            // 
            firstName.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            firstName.Location = new Point(15, 186);
            firstName.Name = "firstName";
            firstName.PlaceholderText = "FirstName";
            firstName.Size = new Size(313, 27);
            firstName.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Calibri", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(15, 223);
            label5.Name = "label5";
            label5.Size = new Size(53, 21);
            label5.TabIndex = 9;
            label5.Text = "E-mail";
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
            dataGridView1.RowTemplate.Height = 40;
            dataGridView1.Size = new Size(627, 545);
            dataGridView1.TabIndex = 20;
            dataGridView1.CellClick += onCellClick;
            // 
            // Coach
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.meghan_holmes_buWcS7G1_28_unsplash;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1098, 649);
            Controls.Add(label8);
            Controls.Add(groupBox1);
            Controls.Add(button4);
            Controls.Add(dataGridView1);
            Name = "Coach";
            Text = "Coach";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label8;
        private GroupBox groupBox1;
        private ComboBox status;
        private Label text;
        private Label label6;
        private Label label2;
        private Button button3;
        private Button button1;
        private TextBox cin;
        private Label label3;
        private TextBox lastName;
        private ComboBox specialty;
        private Label label4;
        private Label label7;
        private TextBox firstName;
        private Label label5;
        private Button button4;
        private DataGridView dataGridView1;
        private TextBox phoneNumber;
        private TextBox email;
    }
}