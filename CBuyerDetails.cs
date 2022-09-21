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
    public partial class CBuyerDetails : UserControl
    {
        public CBuyerDetails()
        {
            InitializeComponent();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            NewBuyerPanel.Hide();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            NewBuyerPanel.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Login login = new Login();            
            login.Show();

            ceo ceo = new ceo();
            ceo.Close();
        }
    }
}
