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
    public partial class FarmerDashboard : UserControl
    {
        public FarmerDashboard()
        {
            InitializeComponent();

            chartHarvesting.Series["Pineapple"].Points.AddXY("Jan", "50");
            chartHarvesting.Series["Avacado"].Points.AddXY("Jan", "40");
            chartHarvesting.Series["Mangus"].Points.AddXY("Jan", "35");

            chartHarvesting.Series["Pineapple"].Points.AddXY("Feb", "23");
            chartHarvesting.Series["Avacado"].Points.AddXY("Feb", "30");
            chartHarvesting.Series["Mangus"].Points.AddXY("Feb", "55");

            chartHarvesting.Series["Pineapple"].Points.AddXY("Mar", "63");
            chartHarvesting.Series["Avacado"].Points.AddXY("Mar", "30");
            chartHarvesting.Series["Mangus"].Points.AddXY("Mar", "45");

            chartHarvesting.Series["Pineapple"].Points.AddXY("Apr", "28");
            chartHarvesting.Series["Avacado"].Points.AddXY("Apr", "37");
            chartHarvesting.Series["Mangus"].Points.AddXY("Apr", "60");

            chartHarvesting.Series["Pineapple"].Points.AddXY("May", "27");
            chartHarvesting.Series["Avacado"].Points.AddXY("May", "55");
            chartHarvesting.Series["Mangus"].Points.AddXY("May", "44");

            chartHarvesting.Series["Pineapple"].Points.AddXY("June", "35");
            chartHarvesting.Series["Avacado"].Points.AddXY("June", "57");
            chartHarvesting.Series["Mangus"].Points.AddXY("June", "34");

            chartHarvesting.Series["Pineapple"].Points.AddXY("July", "20");
            chartHarvesting.Series["Avacado"].Points.AddXY("July", "38");
            chartHarvesting.Series["Mangus"].Points.AddXY("July", "21");

            chartHarvesting.Series["Pineapple"].Points.AddXY("Aug", "0");
            chartHarvesting.Series["Avacado"].Points.AddXY("Aug", "0");
            chartHarvesting.Series["Mangus"].Points.AddXY("Aug", "0");

            chartHarvesting.Series["Pineapple"].Points.AddXY("Sep", "0");
            chartHarvesting.Series["Avacado"].Points.AddXY("Sep", "0");
            chartHarvesting.Series["Mangus"].Points.AddXY("Sep", "0");

            chartHarvesting.Series["Pineapple"].Points.AddXY("Oct", "0");
            chartHarvesting.Series["Avacado"].Points.AddXY("Oct", "0");
            chartHarvesting.Series["Mangus"].Points.AddXY("Oct", "0");

            chartHarvesting.Series["Pineapple"].Points.AddXY("Nov", "0");
            chartHarvesting.Series["Avacado"].Points.AddXY("Nov", "0");
            chartHarvesting.Series["Mangus"].Points.AddXY("Nov", "0");

            chartHarvesting.Series["Pineapple"].Points.AddXY("Dec", "0");
            chartHarvesting.Series["Avacado"].Points.AddXY("Dec", "0");
            chartHarvesting.Series["Mangus"].Points.AddXY("Dec", "0");
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged_1(object sender, EventArgs e)
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
            notifi.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            notifi.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            Messages.Hide();
        }
    }
}
