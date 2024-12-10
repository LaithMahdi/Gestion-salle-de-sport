namespace gym_app
{
    partial class Membre
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
            price = new Label();
            label9 = new Label();
            label1 = new Label();
            dateBirth = new DateTimePicker();
            joinDate = new DateTimePicker();
            phoneNumber = new TextBox();
            email = new TextBox();
            membershipTime = new ComboBox();
            text = new Label();
            label6 = new Label();
            label2 = new Label();
            button3 = new Button();
            button1 = new Button();
            id = new TextBox();
            label3 = new Label();
            fullName = new TextBox();
            gender = new ComboBox();
            label4 = new Label();
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
            label8.Size = new Size(95, 26);
            label8.TabIndex = 27;
            label8.Text = "Membres";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(price);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(dateBirth);
            groupBox1.Controls.Add(joinDate);
            groupBox1.Controls.Add(phoneNumber);
            groupBox1.Controls.Add(email);
            groupBox1.Controls.Add(membershipTime);
            groupBox1.Controls.Add(text);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(id);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(fullName);
            groupBox1.Controls.Add(gender);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label5);
            groupBox1.Location = new Point(48, 81);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(350, 662);
            groupBox1.TabIndex = 26;
            groupBox1.TabStop = false;
            // 
            // price
            // 
            price.AutoSize = true;
            price.Font = new Font("Calibri", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            price.Location = new Point(68, 577);
            price.Name = "price";
            price.Size = new Size(0, 21);
            price.TabIndex = 25;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Calibri", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(15, 577);
            label9.Name = "label9";
            label9.Size = new Size(45, 21);
            label9.TabIndex = 24;
            label9.Text = "Price";
            label9.Click += label9_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(15, 505);
            label1.Name = "label1";
            label1.Size = new Size(76, 21);
            label1.TabIndex = 23;
            label1.Text = "Join Date";
            // 
            // dateBirth
            // 
            dateBirth.Location = new Point(15, 191);
            dateBirth.Name = "dateBirth";
            dateBirth.Size = new Size(313, 23);
            dateBirth.TabIndex = 22;
            // 
            // joinDate
            // 
            joinDate.Location = new Point(15, 537);
            joinDate.Name = "joinDate";
            joinDate.Size = new Size(313, 23);
            joinDate.TabIndex = 21;
            // 
            // phoneNumber
            // 
            phoneNumber.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            phoneNumber.Location = new Point(15, 327);
            phoneNumber.MaxLength = 8;
            phoneNumber.Name = "phoneNumber";
            phoneNumber.PlaceholderText = "+216 99 888 777";
            phoneNumber.Size = new Size(313, 27);
            phoneNumber.TabIndex = 20;
            // 
            // email
            // 
            email.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            email.Location = new Point(15, 257);
            email.Name = "email";
            email.PlaceholderText = "E-mail";
            email.Size = new Size(313, 27);
            email.TabIndex = 19;
            // 
            // membershipTime
            // 
            membershipTime.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            membershipTime.FormattingEnabled = true;
            membershipTime.Items.AddRange(new object[] { "1 Month", "3 Month", "6 Month", "1 Year" });
            membershipTime.Location = new Point(15, 467);
            membershipTime.Name = "membershipTime";
            membershipTime.Size = new Size(313, 27);
            membershipTime.TabIndex = 18;
            membershipTime.SelectedIndexChanged += select_member;
            membershipTime.SelectedValueChanged += select_member;
            // 
            // text
            // 
            text.AutoSize = true;
            text.Font = new Font("Calibri", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            text.Location = new Point(15, 435);
            text.Name = "text";
            text.Size = new Size(141, 21);
            text.TabIndex = 17;
            text.Text = "MemberShip Time";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Calibri", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(15, 295);
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
            label2.Size = new Size(26, 21);
            label2.TabIndex = 2;
            label2.Text = "ID";
            // 
            // button3
            // 
            button3.BackColor = Color.Red;
            button3.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Location = new Point(171, 611);
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
            button1.Location = new Point(81, 611);
            button1.Name = "button1";
            button1.Size = new Size(75, 34);
            button1.TabIndex = 14;
            button1.Text = "Create";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button_click;
            // 
            // id
            // 
            id.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            id.Location = new Point(15, 51);
            id.MaxLength = 8;
            id.Name = "id";
            id.PlaceholderText = "ID";
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
            label3.Size = new Size(81, 21);
            label3.TabIndex = 4;
            label3.Text = "Full Name";
            // 
            // fullName
            // 
            fullName.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            fullName.Location = new Point(15, 121);
            fullName.Name = "fullName";
            fullName.PlaceholderText = "fullname";
            fullName.Size = new Size(313, 27);
            fullName.TabIndex = 5;
            // 
            // gender
            // 
            gender.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gender.FormattingEnabled = true;
            gender.Items.AddRange(new object[] { "Male", "Female" });
            gender.Location = new Point(15, 397);
            gender.Name = "gender";
            gender.Size = new Size(313, 27);
            gender.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(15, 159);
            label4.Name = "label4";
            label4.Size = new Size(83, 21);
            label4.TabIndex = 6;
            label4.Text = "Birth Date";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Calibri", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(15, 365);
            label7.Name = "label7";
            label7.Size = new Size(63, 21);
            label7.TabIndex = 12;
            label7.Text = "Gender";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Calibri", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(15, 225);
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
            button4.TabIndex = 25;
            button4.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(424, 81);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(627, 662);
            dataGridView1.TabIndex = 24;
            dataGridView1.CellClick += onCellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Membre
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.sven_mieke_Lx_GDv7VA9M_unsplash;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1098, 789);
            Controls.Add(label8);
            Controls.Add(groupBox1);
            Controls.Add(button4);
            Controls.Add(dataGridView1);
            Name = "Membre";
            Text = "Membre";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label8;
        private GroupBox groupBox1;
        private TextBox phoneNumber;
        private TextBox email;
        private ComboBox membershipTime;
        private Label text;
        private Label label6;
        private Label label2;
        private Button button3;
        private Button button1;
        private TextBox id;
        private Label label3;
        private TextBox fullName;
        private ComboBox gender;
        private Label label4;
        private Label label7;
        private Label label5;
        private Button button4;
        private DataGridView dataGridView1;
        private Label label1;
        private DateTimePicker dateBirth;
        private DateTimePicker joinDate;
        private Label price;
        private Label label9;
    }
}