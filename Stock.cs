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
    public partial class Stock : Form
    {
        public void showControl(Control control)
        {
            PanelF.Controls.Clear();

            control.Dock = DockStyle.Fill;
            control.BringToFront();
            control.Focus();

            PanelF.Controls.Add(control);
        }

        public Stock()
        {
            InitializeComponent();
            SDashboard fdash = new SDashboard();

            showControl(fdash);
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

 
        private void btnFarmerDashboard_Click(object sender, EventArgs e)
        {
            SDashboard fdash = new SDashboard();

            showControl(fdash);
        }

        private void btnFarmerCalender_Click(object sender, EventArgs e)
        {
            SCalender sCalender = new SCalender();
            showControl(sCalender);
        }

        private void btnFarmerNewlyCultivated_Click(object sender, EventArgs e)
        {
            SFarmerDetails sFarmerDetails = new SFarmerDetails();
            showControl(sFarmerDetails);
        }

        private void btnFarmerHarvesting_Click(object sender, EventArgs e)
        {
            SBuyerDetails sBuyerDetails = new SBuyerDetails();
            showControl(sBuyerDetails);
        }

        private void btnFarmerFarmDetails_Click(object sender, EventArgs e)
        {
            Sales sales = new Sales();
            showControl(sales);
        }

        private void btnFarmerWeather_Click(object sender, EventArgs e)
        {
            SPurchases sPurchases = new SPurchases();
            showControl(sPurchases);
        }
    }
}
