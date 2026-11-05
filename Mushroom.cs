using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Mushroom : Form
    {
        public Mushroom()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Choose chooseForm = new Choose();
            chooseForm.Show();
            this.Hide();

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            lblResult.Text = "";
            string mushroom = "";

            DialogResult convexCup = MessageBox.Show(
                "Does your mushroom have a convex cup?", "Question 1", MessageBoxButtons.YesNo);

            if (convexCup == DialogResult.Yes)
            {
                DialogResult ring = MessageBox.Show(
                    "Does your mushroom have a ring?", "Question 2", MessageBoxButtons.YesNo);

                if (ring == DialogResult.Yes)
                {
                    DialogResult forest = MessageBox.Show(
                        "Does your mushroom grow in a forest?", "Question 3", MessageBoxButtons.YesNo);

                    if (forest == DialogResult.Yes)
                    {
                        mushroom = "Amanite tue-mouche";
                    }
                    else
                    {
                        mushroom = "Agaric jaunissant";
                    }
                }
                else
                {

                    mushroom = "Pied bleu";
                }
            }
            else
            {
                DialogResult gills = MessageBox.Show(
                    "Does your mushroom have gills?", "Question 2", MessageBoxButtons.YesNo);

                if (gills == DialogResult.No)
                {

                    mushroom = "Cepe de bordeaux";
                }
                else
                {
                    DialogResult forest = MessageBox.Show(
                        "Does your mushroom grow in a forest?", "Question 3", MessageBoxButtons.YesNo);

                    if (forest == DialogResult.Yes)
                    {
                        mushroom = "Girolle";
                    }
                    else
                    {
                        mushroom = "Coprin chevelu";
                    }
                }
            }

            lblResult.Text = "Your mushroom is: " + mushroom;
            MessageBox.Show("Your mushroom is: " + mushroom);
        }


        private void btnLogout_Click(object sender, EventArgs e)
        {
            Login loginForm = new Login();
            loginForm.Show();
            this.Hide();

        }

        private void Mushroom_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
