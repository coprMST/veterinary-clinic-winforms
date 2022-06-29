using System;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.String;

namespace VeterinaryClinic.MiniForms
{
    internal partial class AuthForm : Form
    {
        internal AuthForm()
        {
            InitializeComponent();
        }

        private async void PasswordTextBox_IconRightClick(object sender, EventArgs e)
        {
            passwordTextBox.PasswordChar = '\0';
            await Task.Delay(2000);
            passwordTextBox.PasswordChar = '●';
        }

        private void CheckBox_Click(object sender, EventArgs e)
        {
            MainCheckBox.Checked = !MainCheckBox.Checked;
        }

        private async void GoToLogIn_Click(object sender, EventArgs e)
        {
            goToLogIn.Enabled = false;
            Cursor = Cursors.WaitCursor;
            await Task.Run(GoAuth);
            Cursor = Cursors.Default;
            goToLogIn.Enabled = true;
        }

        private Task GoAuth()
        {
            var login = loginTextBox.Text.Trim();
            var password = passwordTextBox.Text.Trim();
            Data.Result result;
            Data.Result result2;

            if (IsNullOrEmpty(login))
            {
                myMessageBoxWarning.Show(@"Введите электронную почту или телефон");
                return Task.CompletedTask;
            }
            if (IsNullOrEmpty(password))
            {
                myMessageBoxWarning.Show(@"Введите пароль учетной записи");
                return Task.CompletedTask;
            }

            if (Regex.IsMatch(login, ".+[@].+[.].+"))
            {
                result = Data.ReturnDataTable($@"execute [dbo].[CheckPhoneAndEmail] null, '{login}'");
                if (result.HasError)
                {
                    myMessageBoxError.Show(result.ErrorText);
                    return Task.CompletedTask;
                }
                if (result.DataTable.Rows[0][0].ToString() == "0")
                {
                    myMessageBoxError.Show("Аккаунта с данной электронной почтой не существует");
                    SetNullLogin();
                    return Task.CompletedTask;
                }
                result2 = Data.ReturnDataTable($@"execute [dbo].[Auth] null, '{login}', '{password}'");
            }
            else if (long.TryParse(login, out _))
            {
                result = Data.ReturnDataTable($@"execute [dbo].[CheckPhoneAndEmail] '{login}', null");
                if (result.HasError)
                {
                    myMessageBoxError.Show(result.ErrorText);
                    return Task.CompletedTask;
                }
                if (result.DataTable.Rows[0][0].ToString() == "0")
                {
                    myMessageBoxError.Show("Аккаунта с данным номером телефона не существует");
                    SetNullLogin();
                    return Task.CompletedTask;
                }
                result2 = Data.ReturnDataTable($@"execute [dbo].[Auth] '{login}', null, '{password}'");
            }
            else
            {
                myMessageBoxError.Show("Корректно введите электронную почту или телефон");
                SetNullLogin();
                return Task.CompletedTask;
            }

            if (result2.HasError)
            {
                myMessageBoxError.Show(result2.ErrorText);
                return Task.CompletedTask;
            }
            if (result2.HasZeroRows)
            {
                myMessageBoxError.Show("Введен неверный пароль");
                SetNullPassword();
                return Task.CompletedTask;
            }

            switch (result2.DataTable.Rows[0][5].ToString())
            {
                case "1": AppUser.CustomerId = result2.DataTable.Rows[0][5].ToString(); break;
                case "2": AppUser.EmployeeId = result2.DataTable.Rows[0][5].ToString(); break;
            }

            AppUser.AccountId = result2.DataTable.Rows[0][0].ToString();
            AppUser.UserName = result2.DataTable.Rows[0][2] + " " + result2.DataTable.Rows[0][3].ToString().Substring(0, 1) + ".";
            if (result2.DataTable.Rows[0][4] != DBNull.Value)
                AppUser.UserName += result2.DataTable.Rows[0][4].ToString().Substring(0, 1) + ".";
            myMessageBoxGoodAuth.Show($"С успешной авторизацией, {AppUser.UserName}");

            void SetNullLogin()
            {
                goToLogIn.Invoke(new Action(() =>
                {
                    loginTextBox.Text = null;
                }));
            }
            void SetNullPassword()
            {
                goToLogIn.Invoke(new Action(() =>
                {
                    passwordTextBox.Text = null;
                }));
            }

            if (MainCheckBox.Checked)
                AppUser.CreateUserFile(login, password);

            goToLogIn.Invoke(new Action(() =>
            {
                Program.MainFormLink.goToAuthPage.Visible = false;
                Program.MainFormLink.goToRegPage.Visible = false;
                Program.MainFormLink.goToLogOut.Visible = true;
                Program.MainFormLink.userPanel.Visible = true;
                Program.MainFormLink.myNameLabel.Text = AppUser.UserName;

                Close();
            }));

            return Task.CompletedTask;
        }

        private void GoToCloseForm_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
