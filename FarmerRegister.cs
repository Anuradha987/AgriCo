using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agriculture
{
    public partial class FarmerRegister : Form
    {
        public FarmerRegister()
        {
            InitializeComponent();
        }

        private void FarmerRegister_Load(object sender, EventArgs e)
        {

        }

        private void close1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2TextBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }



        public void FullNameValidations()
        {
            if (guna2TextBox1.Text.Trim() == string.Empty)
            {
                label24.Text = "This field cannot be empty!";
                return;
            }
            else if (!Regex.Match(guna2TextBox1.Text, "^[a-zA-Z]*$").Success)
            {
                label24.Text = "Invalid full name ";
                return;
            }
            else
            {
                label24.Text = "";
                return;
            }

        }
        public void ConNoVali()
        {
            if (guna2TextBox10.Text.Trim() == string.Empty)
            {
                label32.Text = "This field cannot be empty!";
                return;
            }
            Regex phoneNumpattern = new Regex(@"[0-9]");
            if (!(phoneNumpattern.IsMatch(guna2TextBox10.Text) && guna2TextBox10.Text.Length == 10))
            {
                label32.Text = "Invalid phone number";
            }
            else
            {
                label32.Text = "";
                return;
            }
        }
        public void purposeVali()
        {
            if (guna2TextBox11.Text.Trim() == string.Empty)
            {
                label27.Text = "This field cannot be empty!";
                return;
            }
            else
            {
                label27.Text = "";
            }
        }
        public void userVali()
        {
            if (guna2TextBox4.Text.Trim() == string.Empty)
            {
                label28.Text = "This field cannot be empty!";
                return;
            }
            else
            {
                label28.Text = "";
            }
        }
        public void passVali()
        {
            if (guna2TextBox5.Text.Trim() == string.Empty)
            {
                label29.Text = "This field cannot be empty!";
                return;
            }

            else if (guna2TextBox5.Text.Length < 8)
            {
                label29.Text = "Password length should be 8 symbols or more.";
                return;
            }
            else
            {
                label29.Text = "";
            }
        }
        public void confVali()
        {

            if (guna2TextBox9.Text.Trim() == string.Empty)
            {
                label33.Text = "This field cannot be empty!";
                return;
            }

            else if (guna2TextBox9.Text != guna2TextBox9.Text)
            {
                label33.Text = "Passwords do not match.";
                return;
            }
            else
            {
                label33.Text = "";
                return;
            }


        }
        public void emailVali()
        {

            if (guna2TextBox6.Text.Trim() == string.Empty)
            {
                label31.Text = "This field cannot be empty!";
                return;
            }

            Regex mRegxExpression = new Regex(@"^([a-zA-Z0-9_\-])([a-zA-Z0-9_\-\.]*)@(\[((25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\.){3}|((([a-zA-Z0-9\-]+)\.)+))([a-zA-Z]{2,}|(25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\])$");

            if (!mRegxExpression.IsMatch(guna2TextBox6.Text.Trim()))
            {
                label31.Text = "E-mail address format is not correct.";
                return;
            }

            else
            {
                label31.Text = "";
                return;
            }
        }

        public void dobVali()
        {

            if (guna2TextBox2.Text.Trim() == string.Empty)
            {
                label25.Text = "This field cannot be empty!";
                return;
            }

            if (!Regex.IsMatch(guna2TextBox2.Text, @"(0[1-9]|1[012])[- /.](0[1-9]|[12][0-9]|3[01])[- /.](19|20)\d\d"))
            {
                label25.Text = "Date format is not correct.";
                return;
            }

            else
            {
                label25.Text = "";
                return;
            }

        }

        public void check_gender(RadioButton guna2RadioButton1, RadioButton guna2RadioButton2)
        {
            //none of them aare selected
            if ((guna2RadioButton1.Checked) || (guna2RadioButton2.Checked))
            {

                label30.Text = "";
            }
            else
            {
                label30.Text = "This field cannot be empty!";
                return;
            }

        }

        public void nicVli()
        {

            if (guna2TextBox7.Text.Trim() == string.Empty)
            {
                label26.Text = "This field cannot be empty!";
                return;
            }

            else if (guna2TextBox7.Text.Length < 9)
            {
                label26.Text = "The length should be 9 or more digits.";
                return;
            }
            else
            {
                label26.Text = "";
            }
        }

        public void fadresVali()
        {
            if (guna2TextBox8.Text.Trim() == string.Empty)
            {
                label34.Text = "This field cannot be empty!";
                return;
            }
            else
            {
                label34.Text = "";
                return;
            }

        }
        public void areaVali()
        {
            if (guna2TextBox3.Text.Trim() == string.Empty)
            {
                label37.Text = "This field cannot be empty!";
                return;
            }
            else
            {
                label37.Text = "";
                return;
            }
        }
        public void sectionVali()
        {
            if (guna2TextBox12.Text.Trim() == string.Empty)
            {
                label35.Text = "This field cannot be empty!";
                return;
            }
            if (!Regex.IsMatch(guna2TextBox12.Text, @"(([a-zA-Z\,]))"))
            {
                label35.Text = "Incorrect section identifications.";
                return;
            }
            else
            {
                label35.Text = "";
                return;
            }
        }
        public void checkboxVali()
        {
            if (checkBox1.CheckState == CheckState.Checked || checkBox2.CheckState == CheckState.Checked || checkBox3.CheckState == CheckState.Checked || checkBox4.CheckState == CheckState.Checked)
            {
                label36.Text = "";
                return;
            }
            else
            {
                label36.Text = "This field cannot be empty!";
                return;

            }
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            FullNameValidations(); ConNoVali(); purposeVali(); passVali(); userVali(); confVali(); emailVali(); dobVali(); nicVli();
            check_gender(guna2RadioButton1, guna2RadioButton2);
            fadresVali(); areaVali(); sectionVali(); checkboxVali();
        }
    }
}
