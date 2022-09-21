using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agriculture
{
    public partial class FarmerMap : UserControl
    {
        public FarmerMap()
        {
            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            StaffRegiPanel.Hide();
        }

        private void guna2Panel7_Paint(object sender, PaintEventArgs e)
        {
        }

        private void guna2Panel6_Paint(object sender, PaintEventArgs e)
        {
        }

        private void guna2Panel6_MouseClick(object sender, MouseEventArgs e)
        {

            StaffRegiPanel.Show();
        }

        private void guna2Panel7_MouseClick(object sender, MouseEventArgs e)
        {
            StaffRegiPanel.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }
}
