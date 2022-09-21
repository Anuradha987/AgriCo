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
    public partial class Farmer : Form
    {
        public void showControl(Control control)
        {
            PanelF.Controls.Clear();

            control.Dock = DockStyle.Fill;
            control.BringToFront();
            control.Focus();

            PanelF.Controls.Add(control);
        }

        public Farmer()
        {
            InitializeComponent();
            FarmerDashboard fdash = new FarmerDashboard();

            showControl(fdash);
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btnFarmerDashboard_Click(object sender, EventArgs e)
        {
            FarmerDashboard fdash = new FarmerDashboard();

            showControl(fdash);
        }

        private void Paneld_Paint(object sender, PaintEventArgs e)
        {

        }
        private void btnFarmerWeather_Click(object sender, EventArgs e)
        {
            FWeather fweather = new FWeather();
            showControl(fweather);

        }

        private void btnFarmerCalender_Click(object sender, EventArgs e)
        {
            FCalender fCalender = new FCalender();
            showControl(fCalender);
        }

        private void btnFarmerHarvesting_Click(object sender, EventArgs e)
        {
            HarvestDetails harvestDetails = new HarvestDetails();
            showControl(harvestDetails);
        }

        private void btnFarmerNewlyCultivated_Click(object sender, EventArgs e)
        {
            FSalesDetails fSalesDetails = new FSalesDetails();
            showControl(fSalesDetails);
        }

        private void btnFarmerFarmDetails_Click(object sender, EventArgs e)
        {
            FarmerMap farmerMap = new FarmerMap();
            showControl(farmerMap);
        }
    }
}
