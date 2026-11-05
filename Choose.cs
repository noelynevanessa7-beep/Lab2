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
    public partial class Choose : Form
    {
        public Choose()
        {
            InitializeComponent();
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bicycle bicycleForm = new Bicycle();
            bicycleForm.Show();
            this.Hide();
        }

        private void btnMushroom_Click(object sender, EventArgs e)
        {
            Mushroom mushroomForm = new Mushroom();
            mushroomForm.Show();
            this.Hide();

        }

        private void Choose_FormClosed(object sender, FormClosedEventArgs e)
        {
           
            Application.Exit();
        }

        private void Choose_Load(object sender, EventArgs e)
        {

        }
    }
}
