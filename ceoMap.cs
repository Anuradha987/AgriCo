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
    public partial class ceoMap : UserControl
    {
        public ceoMap()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            gp07.Show();
        }

        private void label26_Click(object sender, EventArgs e)
        {
            ga30.Show();
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            gp07.Hide();
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            ga30.Hide();
        }

        private void label27_Click(object sender, EventArgs e)
        {
            gm19.Show();
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            gm19.Hide();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }
}
