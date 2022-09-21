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
    public partial class ceoDashboard : UserControl
    {
        public ceoDashboard()
        {
            InitializeComponent();

            chart2.Series["Income"].Points.AddXY("2011","831985");
            chart2.Series["Expenses"].Points.AddXY("2011", "150008");

            chart2.Series["Income"].Points.AddXY("2012", "704934");
            chart2.Series["Expenses"].Points.AddXY("2012", "919039");

            chart2.Series["Income"].Points.AddXY("2013", "1545305");
            chart2.Series["Expenses"].Points.AddXY("2013", "930342");

            chart2.Series["Income"].Points.AddXY("2014", "1047678");
            chart2.Series["Expenses"].Points.AddXY("2014", "580980");

            chart2.Series["Income"].Points.AddXY("2015", "1129298");
            chart2.Series["Expenses"].Points.AddXY("2015", "455563");

            chart2.Series["Income"].Points.AddXY("2016", "2531428");
            chart2.Series["Expenses"].Points.AddXY("2016", "2089043");

            chart2.Series["Income"].Points.AddXY("2017", "3650239");
            chart2.Series["Expenses"].Points.AddXY("2017", "2572840");

            chart2.Series["Income"].Points.AddXY("2018", "3009672");
            chart2.Series["Expenses"].Points.AddXY("2018", "3509322");

            chart2.Series["Income"].Points.AddXY("2019", "4055014");
            chart2.Series["Expenses"].Points.AddXY("2019", "2923107");

            chart2.Series["Income"].Points.AddXY("2020", "4789111");
            chart2.Series["Expenses"].Points.AddXY("2020", "4234654");

            chart2.Series["Income"].Points.AddXY("2021", "4789670");
            chart2.Series["Expenses"].Points.AddXY("2021", "4374721");
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

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            Messages.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            notifi.Show();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            notifi.Hide();
        }
    }
}
