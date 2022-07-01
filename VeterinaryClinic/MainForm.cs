using System;
using System.Drawing;
using System.Windows.Forms;
using VeterinaryClinic.Forms;
using VeterinaryClinic.MiniForms;

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
            InitializeComponent();

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


            switch (AppUser.AccountType)
            {
                case "1":
                    goToCreateMeeting.Visible = true;
                    goToMyPets.Visible = true;
                    break;
                case "2":
                    goDataPage.Visible = true;
                    break;
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (AppUser.AutoAuthUser())
            {
                goToAuthPage.Visible = false;
                goToLogOut.Visible = true;
                userPanel.Visible = true;
                goToReg.Visible = false;
                myNameLabel.Text = AppUser.GetName();
            }
            else
            {
                goToAuthPage.Visible = true;
                goToLogOut.Visible = false;
                userPanel.Visible = false;
            }

            goHeadPage.Checked = true;
            Text = "Петан - Главная";
            OpenChildForm(new HeadForm());
        }

        private void goToCreateMeeting_Click(object sender, EventArgs e)
        {
            Text = "Петан - Запись";
            OpenChildForm(new MeetingForm());
        }

        private void goToSettings_Click(object sender, EventArgs e)
        {
            Text = "Петан - Настройки";
            OpenMiniForm.Shading(new SettingsForm());
        }

        private void goToReg_Click(object sender, EventArgs e)
        {
            Text = "Петан - Регистрация";
            OpenMiniForm.Shading(new RegForm());
        }

        private void GoToAuth_Click(object sender, EventArgs e)
        {
            Text = "Петан - Авторизация";
            OpenMiniForm.Shading(new AuthForm());
        }

        private void goToMyPets_Click(object sender, EventArgs e)
        {
            Text = "Петан - Мои животные";
            OpenChildForm(new MyPetsForm());
        }

        private void goToSerivcesPage_Click(object sender, EventArgs e)
        {
            Text = "Петан - Услуги";
            OpenChildForm(new ServicesForm());
        }

        private void GoHeadPage_Click(object sender, EventArgs e)
        {
            Text = "Петан - Главная";
            OpenChildForm(new HeadForm());
        }

        private void GoDataPage_Click(object sender, EventArgs e)
        {
            Text = "Петан - Данные";
            OpenChildForm(new DataForm());
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
            goToAuthPage.Visible = true;
            goToReg.Visible = true;
            goToLogOut.Visible = false;
            userPanel.Visible = false;
            AppUser.DeleteUserFile();
            AppUser.AccountType = null;
            AppUser.AccountId = null;
            goToCreateMeeting.Visible = false;
            goDataPage.Visible = false;
            goToMyPets.Visible = false;

            if (goToCreateMeeting.Checked || goDataPage.Checked)
            {
                goHeadPage.Checked = true;
                Text = "Петан - Главная";
                OpenChildForm(new HeadForm());
                goToCreateMeeting.Visible = false;
                goDataPage.Visible = false;
            }
            else
            {
                goToCreateMeeting.Visible = false;
                goDataPage.Visible = false;
            }
            
        }

        private void HelperButton_Click(object sender, EventArgs e)
        {
            Helper.Open();
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
