using System;
using System.Windows.Forms;

namespace VeterinaryClinic.Forms
{
    internal partial class DataForm : Form
    {
        internal DataForm()
        {
            InitializeComponent();
        }

        private void guna2TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                MessageBox.Show("wadaw");
            }
        }

        private void guna2Button12_Click(object sender, EventArgs e)
        {

        }
    }
}
