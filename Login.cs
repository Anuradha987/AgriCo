using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agriculture
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            panel2.BackColor = Color.FromArgb(125, Color.Black);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
                    }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void guna2CustomGradientPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

            string userid = guna2TextBox1.Text;
            string pass = password.Text;
            if (userid == "farmer" || pass == "farmer123")
            {
               // MessageBox.Show("Farmer Login sucess");
                Farmer farmer = new Farmer();
                farmer.Show();
                this.Hide();
                /* Form3 f3 = new Form3(); // Instantiate a Form3 object.
                 f3.Show(); // Show Form3 and
                 this.Close(); // closes the Form2 instance.*/
            }
            else if (userid == "admin" || pass == "admin123")
            {
                ceo ceo = new ceo();
                ceo.Show();
                this.Hide();
            }
            else if (userid == "stock" || pass == "stock123")
            {
                Stock stock = new Stock();
                stock.Show();
                this.Hide();
                //MessageBox.Show("Stock manager Login sucess");
            }
            else
            {
                MessageBox.Show("Invalid Login please check username and password");
            }
        }

        private void label13_Click(object sender, EventArgs e)
        {
            FarmerRegister farmerRegister = new FarmerRegister();
            this.Hide();
            farmerRegister.Show();
        }
    }
}
