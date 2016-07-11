using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginPassword
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (txtLogin.Text != "" && txtPassword.Text != "")
            {
                lblMessage.Text = "";
                lblOutputLogin.Text = "Login:" + txtLogin.Text;
                lblOutputPassword.Text = "Password:" + txtPassword.Text;
            }
            else
                lblMessage.Text = "Please enter the above information";

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
