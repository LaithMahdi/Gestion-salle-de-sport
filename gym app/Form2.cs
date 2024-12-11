using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gym_app
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }


        private void member_Click(object sender, EventArgs e)
        {
            Membre membre = new Membre();
            membre.ShowDialog();
        }

        private void coach_click(object sender, EventArgs e)
        {
            Coach coach = new Coach();
            coach.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Equipement equipement = new Equipement();
            equipement.ShowDialog();
        }

        private void products_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            product.ShowDialog();
        }

        private void onOpenPage(object sender, EventArgs e)
        {
            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(w, h);
        }

        private void cours_Click(object sender, EventArgs e)
        {
            Course course = new Course();
            course.ShowDialog();
        }

        private void click_vente(object sender, EventArgs e)
        {
            Vente vente = new Vente();
            vente.ShowDialog();
        }
    }
}
