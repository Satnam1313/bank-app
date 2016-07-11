using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sheharyar_Khan_Ex_01
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
            ComputerProgrammerComboBox.Hide();
            ComputerProgrammerAnalystComboBox.Hide();

        }


        private void ComputerProgrammerComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            lstCourses.Items.Add(ComputerProgrammerComboBox.SelectedItem);
        }


        private void btnDisplay_Click(object sender, EventArgs e)
        {
            try
            {

                txtDisplay.Text = txtName.Text + "    " + txtAddress.Text + "    ";

                if (lstCourses.Items.Count < 1)
                {
                    MessageBox.Show("List is Empty");
                }
                else
                {
                    for (int i = 0; i < lstCourses.Items.Count; ++i)
                    {
                        txtDisplay.Text += lstCourses.Items[i] + "   ";

                    }// end for
                }// end else
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }


        private void rbtnComputerProgrammer_CheckedChanged(object sender, EventArgs e)
        {
            ComputerProgrammerComboBox.Show();
            ComputerProgrammerAnalystComboBox.Hide();
            lstCourses.Items.Clear();

        }

        private void rbtnComputerProgrammerAnalyst_CheckedChanged(object sender, EventArgs e)
        {
            ComputerProgrammerAnalystComboBox.Show();
            ComputerProgrammerComboBox.Hide();


        }

        private void ComputerProgrammerAnalystComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstCourses.Items.Add(ComputerProgrammerAnalystComboBox.SelectedItem);
        }


    }
}
