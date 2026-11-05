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
    public partial class Bicycle : Form
    {
        public Bicycle()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int startHour;
            int endHour;


            if (!int.TryParse(txtStart.Text, out startHour) ||
                !int.TryParse(txtEnd.Text, out endHour))
            {
                MessageBox.Show("Please enter whole numbers only (no letters or decimals).");
                return;
            }


            if (startHour < 0 || startHour > 23)
            {
                MessageBox.Show("Start hour must be between 0 and 23.");
                return;
            }

            if (endHour < 1 || endHour > 24)
            {
                MessageBox.Show("End hour must be between 1 and 24.");
                return;
            }

            if (startHour >= endHour)
            {
                MessageBox.Show("Start hour must be less than end hour.");
                return;
            }
            int totalCost = 0;

            for (int h = startHour; h < endHour; h++)
            {
                if (h < 7 || h >= 21)
                {
                    totalCost = totalCost + 500;
                }
                else if ((h >= 7 && h < 14) || (h >= 19 && h < 21))
                {
                    totalCost = totalCost + 1000;
                }
                else if (h >= 14 && h < 19)
                {
                    totalCost = totalCost + 1500;
                }
            }


            txtTotal.Text = totalCost + " RWF";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Choose chooseForm = new Choose();
            chooseForm.Show();
            this.Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Login loginForm = new Login();
            loginForm.Show();
            this.Hide();
        }

        private void Bicycle_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
