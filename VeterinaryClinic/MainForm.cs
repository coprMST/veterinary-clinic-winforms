using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VeterinaryClinic
{
    public partial class MainForm : Form
    {
        private readonly Color _borderColor = Color.FromArgb(21, 94, 117);

        public MainForm()
        {
            InitializeComponent();
        }

        private void OpenChildForm(Form childForm)
        {
            childForm.TopLevel = false;
            childForm.Dock = DockStyle.Fill;
            formPanel.Controls.Add(childForm);
            formPanel.Tag = childForm;
            childForm.Show();
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ServicesForm());
        }

        private void MenuPanel_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, menuPanel.ClientRectangle,
                _borderColor, 2, ButtonBorderStyle.Solid,
                _borderColor, 2, ButtonBorderStyle.Solid,
                _borderColor, 0, ButtonBorderStyle.Solid,
                _borderColor, 2, ButtonBorderStyle.Solid);
        }

        private void FormPanel_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, formPanel.ClientRectangle,
                _borderColor, 0, ButtonBorderStyle.Solid,
                _borderColor, 2, ButtonBorderStyle.Solid,
                _borderColor, 2, ButtonBorderStyle.Solid,
                _borderColor, 2, ButtonBorderStyle.Solid);
        }

        private void GoToCloseApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void GoToResizeApp_Click(object sender, EventArgs e)
        { 
            WindowState = goToResizeApp.Checked ? FormWindowState.Maximized : FormWindowState.Normal;
        }

        private void GoToMinimizedApp_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
