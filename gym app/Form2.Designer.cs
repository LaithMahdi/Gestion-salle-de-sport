namespace gym_app
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            members = new Button();
            coach = new Button();
            cours = new Button();
            products = new Button();
            equipements = new Button();
            SuspendLayout();
            // 
            // members
            // 
            members.BackgroundImage = Properties.Resources.users_young_svgrepo_com;
            members.BackgroundImageLayout = ImageLayout.Stretch;
            members.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            members.Location = new Point(136, 62);
            members.Name = "members";
            members.Size = new Size(131, 133);
            members.TabIndex = 10;
            members.Text = "Members";
            members.TextAlign = ContentAlignment.BottomCenter;
            members.UseVisualStyleBackColor = true;
            members.Click += button1_Click;
            // 
            // coach
            // 
            coach.BackgroundImage = (Image)resources.GetObject("coach.BackgroundImage");
            coach.BackgroundImageLayout = ImageLayout.Stretch;
            coach.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            coach.ForeColor = Color.Black;
            coach.Location = new Point(331, 62);
            coach.Name = "coach";
            coach.Size = new Size(131, 133);
            coach.TabIndex = 11;
            coach.Text = "Coach";
            coach.TextAlign = ContentAlignment.BottomCenter;
            coach.UseVisualStyleBackColor = true;
            coach.Click += button2_Click;
            // 
            // cours
            // 
            cours.BackgroundImage = (Image)resources.GetObject("cours.BackgroundImage");
            cours.BackgroundImageLayout = ImageLayout.Stretch;
            cours.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cours.ForeColor = Color.Black;
            cours.Location = new Point(526, 62);
            cours.Name = "cours";
            cours.Size = new Size(131, 133);
            cours.TabIndex = 12;
            cours.Text = "Cours";
            cours.TextAlign = ContentAlignment.BottomCenter;
            cours.UseVisualStyleBackColor = true;
            // 
            // products
            // 
            products.BackgroundImage = (Image)resources.GetObject("products.BackgroundImage");
            products.BackgroundImageLayout = ImageLayout.Stretch;
            products.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            products.ForeColor = Color.Black;
            products.Location = new Point(417, 224);
            products.Name = "products";
            products.Size = new Size(131, 133);
            products.TabIndex = 13;
            products.Text = "Products";
            products.TextAlign = ContentAlignment.BottomCenter;
            products.UseVisualStyleBackColor = true;
            products.Click += products_Click;
            // 
            // equipements
            // 
            equipements.BackgroundImage = (Image)resources.GetObject("equipements.BackgroundImage");
            equipements.BackgroundImageLayout = ImageLayout.Stretch;
            equipements.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            equipements.ForeColor = Color.Black;
            equipements.Location = new Point(238, 224);
            equipements.Name = "equipements";
            equipements.Size = new Size(131, 133);
            equipements.TabIndex = 14;
            equipements.Text = "Equipements";
            equipements.TextAlign = ContentAlignment.BottomCenter;
            equipements.UseVisualStyleBackColor = true;
            equipements.Click += button5_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(equipements);
            Controls.Add(products);
            Controls.Add(cours);
            Controls.Add(coach);
            Controls.Add(members);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private Button members;
        private Button coach;
        private Button cours;
        private Button products;
        private Button equipements;
    }
}