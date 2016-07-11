using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoCheckBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string str = "";

            if (chkJava.Checked == true)
            {
                str = "You selected :" + chkJava.Text;
            }

            if (chkPHP.Checked == true)
            {
                
                str = str + chkPHP.Text;
            }

            if (chkCSharp.Checked == true)
            {
                str = str + chkCSharp.Text;
            }

            if (str.Length != 0)
                MessageBox.Show(str);
            else
                MessageBox.Show("You have not selected any thing");

        }
    }
}
