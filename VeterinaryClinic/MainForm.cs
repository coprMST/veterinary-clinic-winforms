using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using VeterinaryClinic.Forms;

namespace VeterinaryClinic
{
    internal partial class MainForm : Form
    {
        private readonly Color _borderColor = Color.FromArgb(21, 94, 117);
        private int _x;
        private int _y;

        private static Point _oldLoc, _defaultLoc;
        private static Size _oldSize, _defaultSize;

        internal MainForm()
        {
            Program.MainFormLink = this;
            AppUser.AutoAuthUser();

            InitializeComponent();

            if (AppUser.AccountId != null)
            {
                goToAuth.Visible = false;
                goToReg.Visible = false;
                goToLogOut.Visible = true;
                myNameLabel.Text = AppUser.UserName;
            }

            _oldLoc = Location;
            _oldSize = Size;
            _defaultLoc = Location;
            _defaultSize = Size;
        }

        private void OpenChildForm(Form childForm)
        {
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            formPanel.Controls.Add(childForm);
            formPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            helperButton.BringToFront();

            if (childForm.Name == "AuthForm" || childForm.Name == "RegForm")
                helperButton.BackColor = Color.FromArgb(14, 116, 144);
            else
                helperButton.BackColor = Color.FromArgb(243, 244, 246);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            goHeadPage.Checked = true;
            Text = "Петан - Главная";
            OpenChildForm(new HeadForm());
        }

        private void goToSettings_Click(object sender, EventArgs e)
        {
            Text = "Петан - Настройки";
            OpenChildForm(new HeadForm());
        }

        private void GoHeadPage_Click(object sender, EventArgs e)
        {
            Text = "Петан - Главная";
            OpenChildForm(new HeadForm());
        }

        private void GoToAuth_Click(object sender, EventArgs e)
        {
            Text = "Петан - Авторизация";
            OpenChildForm(new AuthForm());
        }

        private void GoDataPage_Click(object sender, EventArgs e)
        {
            Text = "Петан - Данные";
            OpenChildForm(new ServicesForm());
            //var mainForm = this;
            //OpenMiniForm.Shading(ref mainForm, new EditPosition());
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
            if (goToResizeApp.Checked)
            {
                _oldLoc = new Point(Location.X, Location.Y);
                _oldSize = new Size(Size.Width, Size.Height);
                var x = SystemInformation.WorkingArea.Width;
                var y = SystemInformation.WorkingArea.Height;
                WindowState = FormWindowState.Normal;
                Location = new Point(0, 0);
                Size = new Size(x, y);
            }
            else
            {
                if (_oldSize.Width >= SystemInformation.WorkingArea.Width || _oldSize.Height >= SystemInformation.WorkingArea.Height)
                {
                    Location = _defaultLoc;
                    Size = _defaultSize;
                }
                else
                {
                    Location = _oldLoc;
                    Size = _oldSize;
                }
            }
        }

        private void GoToMinimizedApp_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void goToLogOut_Click(object sender, EventArgs e)
        {
            AppUser.DeleteUserFile();
        }

        private void headerPanel_MouseDown(object sender, MouseEventArgs e)
        {
            _x = e.X; _y = e.Y;
        }

        private void headerPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                Location = new Point(Location.X + (e.X - _x), Location.Y + (e.Y - _y));
        }
    }
}
