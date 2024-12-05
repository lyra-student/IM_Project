using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IM_Project
{
    public partial class LOGIN : Form
    {
        public LOGIN()
        {
            InitializeComponent();
        }

        private void showPass_CheckedChanged(object sender, EventArgs e)
        {
            if (showPass.Checked)
            {
                passwordtxt.PasswordChar = '\0'; // Show the password as plain text
            }
            else
            {
                passwordtxt.PasswordChar = '*'; // Hide the password as asterisks
            }
        }
    }
}
