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
    public partial class SDashboard : UserControl
    {
        public SDashboard()
        {
            InitializeComponent();
            chart1.Series["s1"].IsValueShownAsLabel = true;

            chart1.Series["s1"].Points.AddXY("Pineapple", "135");
            chart1.Series["s1"].Points.AddXY("Avacado", "69");
            chart1.Series["s1"].Points.AddXY("Mangus", "90");
        }

        private void SDashboard_Load(object sender, EventArgs e)
        { 

        }
        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void label26_Click(object sender, EventArgs e)
        {

        }

        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void label28_Click(object sender, EventArgs e)
        {

        }

        private void label29_Click(object sender, EventArgs e)
        {

        }

        private void label38_Click(object sender, EventArgs e)
        {

        }

        private void gunaGradientPanel5_Click(object sender, EventArgs e)
        {

        }

        private void vScrollBar3_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Messages.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
           
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            notifi.Hide();
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox5_Click_1(object sender, EventArgs e)
        {
            notifi.Show();
        }

        private void pictureBox18_Click_1(object sender, EventArgs e)
        {
            Messages.Hide();
        }
    }
}
