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
    public partial class ceoAddStaff : UserControl
    {
        public ceoAddStaff()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            StaffRegiPanel.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            StaffRegiPanel.Hide();
        }

        private void ceoAddStaff_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }
}
