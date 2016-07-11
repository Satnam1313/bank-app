using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentInformation
{
    public partial class StudentRegistration : Form
    {
        public StudentRegistration()
        {
            InitializeComponent();

        }

        private void radioBtnProgrammerAnalyst_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioBtnProgrammer_CheckedChanged(object sender, EventArgs e)
        {
            if (sender == radioBtnProgrammer)
            {
                cbxDisplayCourses.Items.Clear();
                this.cbxDisplayCourses.Items.AddRange(new object[] {"CSharp",
                    "Java",
                    "HTML",
                    "Web Programming"});
            }
            
        }

        private void radioBtnProgrammerAnalyst_Click(object sender, EventArgs e)
        {
            if (sender == radioBtnProgrammerAnalyst)
            {
                cbxDisplayCourses.Items.Clear();
                this.cbxDisplayCourses.Items.AddRange(new object[] {"Advance Programming",
                "Computer Fundamentals",
                "Unified Modelling",
                "Software Engineering"});
            }
        }

        private void lstCourses_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstCourses.FindString(cbxDisplayCourses.SelectedItem.ToString()) < 0)
            {
                lstCourses.Items.Add(cbxDisplayCourses.SelectedItem);
            }

        }

        private void BtnDisplay_Click(object sender, EventArgs e)
        {
            double dresult = 0;
            if (Double.TryParse(txtBoxName.Text, out dresult))
            {
                MessageBox.Show("Please enter the correct information type for the fields");
            }
            else
            {
                 txtBoxDisplay.Clear();
            //txtBoxDisplay.Text += (txtBoxName.Text + "\t" + txtBoxAddress.Text + "\t" + txtBoxCity.Text
            //    + "\t" + txtBoxPostalCode.Text + "\t" + txtBoxProvince.Text + "\t" + txtBoxPhoneNumber.Text);
            txtBoxDisplay.Text += (txtBoxName.Text + "\t" + txtBoxAddress.Text + "\t" + lstCourses.SelectedItem);
            }
           
        }

        private void txtBoxName_TextChanged(object sender, EventArgs e)
        {
            double dresult=0;
            if(Double.TryParse(txtBoxName.Text, out dresult))
            {
                MessageBox.Show("Please enter the correct information type for the fields");
            }
            else
            {
                txtBoxDisplay.Clear();
            }
        }

        private void txtBoxProvince_TextChanged(object sender, EventArgs e)
        {
            double dresult = 0;
            if (Double.TryParse(txtBoxProvince.Text, out dresult))
            {
                MessageBox.Show("Please enter the correct information type for the fields");
            }
            else
            {
                txtBoxDisplay.Clear();
                
            }
        }


    }
}
