using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoComboBox
{
    public partial class MyForm : Form
    {

        public MyForm()
        {
            InitializeComponent();

            string[] states = { "Ontario", "Quebec", "Manitoba","Alberta", "B.C." };
            
            comboBox1.Items.AddRange(states);
            comboBox1.Items.Add(states[0]);
            //comboBox1.Items.Add(states[i]);

             
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstOutput.Items.Add(comboBox1.SelectedItem.ToString());
           
            MessageBox.Show("You selected: " + comboBox1.SelectedItem.ToString());
        }
    }
}
