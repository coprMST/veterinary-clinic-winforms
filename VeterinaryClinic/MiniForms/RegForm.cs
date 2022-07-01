using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.String;

namespace VeterinaryClinic.MiniForms
{
    internal partial class RegForm : Form
    {
        internal RegForm()
        {
            InitializeComponent();
        }

        private void goToReg_Click(object sender, EventArgs e)
        {
            var phone = phoneTextBox.Text.Trim();
            var email = emailTextBox.Text.Trim();
            var fio = fioTextBox.Text.Trim();
            var dob = dobTextBox.Text.Trim();
            var topPassword = password1TextBox.Text.Trim();
            var bottomPassword = password2TextBox.Text.Trim();

            if (IsNullOrEmpty(phone) || IsNullOrEmpty(email) || IsNullOrEmpty(fio) || IsNullOrEmpty(dob) || IsNullOrEmpty(topPassword) || IsNullOrEmpty(bottomPassword))
                return;


            if (fio.Split(' ').Length < 2 || fio.Split(' ').Length > 3 || fio.Length < 3)
            {
                myMessageBoxError.Show("Введите корретно ФИО");
                return;
            }
            if (!DateTime.TryParse(dob, out _))
            {
                myMessageBoxError.Show("Введите корретно дату рождения");
                return;
            }
            if (DateTime.TryParse(dob, out var date) && (date.AddYears(14) - DateTime.Today).TotalDays >= 0)
            {
                myMessageBoxError.Show("Вам должно быть не меньше 14 лет");
                return;
            }
            if (!Regex.IsMatch(email, ".+[@].+[.].+"))
            {
                myMessageBoxError.Show("Введите корретно электронную почту");
                return;
            }
            if (topPassword != bottomPassword)
            {
                myMessageBoxError.Show("Пароли не совпадают");
                return;
            }
            if (topPassword.Length < 8)
            {
                myMessageBoxError.Show("Пароль должен состоять минимум из 8 символов");
                return;
            }
            phone = "7" + phone;
            if (phone.Length < 11)
            {
                myMessageBoxError.Show("Введите корректный номер телефона");
                return;
            }
            var tempResult = Data.ReturnDataTable($@"execute [dbo].[CheckPhoneAndEmail] '{phone}', '{email}'");
            if (tempResult.DataTable.Rows[0][0].ToString() == "1")
            {
                myMessageBoxError.Show("Аккаунт с данным номером телефона или почтой уже существует");
                return;
            }

            var tempFio = fio.Split(' ');
            var lastName = tempFio[0];
            var firstName = tempFio[1];
            var middleName = "NULL";
            if (tempFio.Length == 3)
                middleName = tempFio[2];

            Data.Result result;
            if (middleName == "NULL")
                result = Data.ReturnDataTable($@"exec [dbo].[AddNewCustomer] '{lastName}', '{firstName}', NULL, '{dob}', '{phone}', '{email}', '{topPassword}'");
            else
                result = Data.ReturnDataTable($@"exec [dbo].[AddNewCustomer] '{lastName}', '{firstName}', '{middleName}', '{dob}', '{phone}', '{email}', '{topPassword}'");

            if (result.HasError)
            {
                myMessageBoxError.Show(@"Не удалось зарегистрироваться." + Environment.NewLine + result.ErrorText);
                return;
            }

            AppUser.AccountType = "1";
            AppUser.AccountId = result.DataTable.Rows[0][0].ToString();
            AppUser.LastName = lastName;
            AppUser.FirstName = firstName;
            if (middleName != "NULL")
                AppUser.MiddleName = middleName;

            if (MainCheckBox.Checked)
                AppUser.CreateUserFile(phone, topPassword);

            myMessageBoxGoodAuth.Show(@"С успешной регистрацией," + Environment.NewLine + $@"{AppUser.GetName()}");

            Program.MainFormLink.goToAuthPage.Visible = false;
            Program.MainFormLink.goToLogOut.Visible = true;
            Program.MainFormLink.userPanel.Visible = true;
            Program.MainFormLink.goToReg.Visible = false;
            Program.MainFormLink.myNameLabel.Text = AppUser.GetName();
            Program.MainFormLink.goToCreateMeeting.Visible = true;

            Close();
        }

        private void GoToCloseForm_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void NumberTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0' && e.KeyChar <= '9') || (e.KeyChar >= 1 && e.KeyChar <= 31) || e.KeyChar == (char)Keys.Back) { }
            else e.Handled = true;
        }

        private void emailTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0' && e.KeyChar <= '9') || (e.KeyChar >= 'a' && e.KeyChar <= 'z') || (e.KeyChar >= 'A' && e.KeyChar <= 'Z') || e.KeyChar == '@' || e.KeyChar == '.' || e.KeyChar == '-' || e.KeyChar == '_' || (e.KeyChar >= 1 && e.KeyChar <= 31) || e.KeyChar == (char)Keys.Back) { }
            else e.Handled = true;
        }

        private void fioTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 'а' && e.KeyChar <= 'я') || (e.KeyChar >= 'А' && e.KeyChar <= 'Я') || e.KeyChar == ' ' || (e.KeyChar >= 1 && e.KeyChar <= 31) || e.KeyChar == (char)Keys.Back) { }
            else e.Handled = true;
        }

        private void dobTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == '.'  || (e.KeyChar >= 1 && e.KeyChar <= 31) || e.KeyChar == (char)Keys.Back) { }
            else e.Handled = true;
        }

        private void password1TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 'A' && e.KeyChar <= 'Z') || (e.KeyChar >= 1 && e.KeyChar <= 31) || (e.KeyChar >= 'a' && e.KeyChar <= 'z') || (e.KeyChar >= '0' && e.KeyChar <= '9') || (e.KeyChar >= 33 && e.KeyChar <= 38) || (e.KeyChar >= 40 && e.KeyChar <= 126) || e.KeyChar == (char)Keys.Back) { }
            else e.Handled = true;
        }

        private void CheckBox_Click(object sender, EventArgs e)
        {
            MainCheckBox.Checked = !MainCheckBox.Checked;
        }

        private async void password1TextBox_IconRightClick(object sender, EventArgs e)
        {
            password1TextBox.PasswordChar = '\0';
            await Task.Delay(2000);
            password1TextBox.PasswordChar = '●';
        }

        private async void password2TextBox_IconRightClick(object sender, EventArgs e)
        {
            password2TextBox.PasswordChar = '\0';
            await Task.Delay(2000);
            password2TextBox.PasswordChar = '●';
        }
    }
}
