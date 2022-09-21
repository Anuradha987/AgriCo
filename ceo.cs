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
    public partial class ceo : Form
    {
        public void showControl(Control control)
        {
            PanelF.Controls.Clear();

            control.Dock = DockStyle.Fill;
            control.BringToFront();
            control.Focus();

            PanelF.Controls.Add(control);
        }
        public ceo()
        {
            InitializeComponent();
            ceoDashboard fdash = new ceoDashboard();
            showControl(fdash);
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void btnFarmerDashboard_Click(object sender, EventArgs e)
        {
            ceoDashboard fdash = new ceoDashboard();
            showControl(fdash);
        }

        private void btnFarmerNewlyCultivated_Click(object sender, EventArgs e)
        {
            ceoAddStaff ceoAdd = new ceoAddStaff();
            showControl(ceoAdd);
        }

        private void btnFarmerHarvesting_Click(object sender, EventArgs e)
        {
            FarmerDetails farmerDetails = new FarmerDetails();
            showControl(farmerDetails);
        }

        private void btnFarmerWeather_Click(object sender, EventArgs e)
        {
            CBuyerDetails cBuyerDetails = new CBuyerDetails();
            showControl(cBuyerDetails);
        }

        private void btnFarmerCalender_Click(object sender, EventArgs e)
        {
            cSalePurch cSalePurch = new cSalePurch();
            showControl(cSalePurch);
        }

        private void btnFarmerFarmDetails_Click(object sender, EventArgs e)
        {
            ceoMap ceoMap = new ceoMap();
            showControl(ceoMap);
        }
    }
}
