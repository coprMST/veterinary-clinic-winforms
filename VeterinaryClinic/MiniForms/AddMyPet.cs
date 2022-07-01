using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.String;

namespace VeterinaryClinic.MiniForms
{
    public partial class AddMyPet : Form
    {
        public AddMyPet()
        {
            InitializeComponent();
        }

        private void goToCloseForm_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void goToAdd_Click(object sender, EventArgs e)
        {
            var petName = petNameTextBox.Text.Trim();
            var peculiarities = peculiaritiesTextBox.Text.Trim();
            var male = maleButton.Checked;
            var female = femaleButton.Checked;

            if (IsNullOrEmpty(petName) || IsNullOrEmpty(peculiarities) || !male && !female)
                return;

            var gender = male ? "М" : "Ж";
            var result = Data.ReturnDataTable($@"exec [dbo].[AddNewPet] '{AppUser.AccountId}', '{petName}', '{peculiarities}', '{gender}'");

            if (result.HasError && result.ErrorText != "Невозможно найти таблицу 0.")
            {
                myMessageBoxError.Show($@"Не удалось добавить животное." + Environment.NewLine + result.ErrorText);
                return;
            }

            myMessageBoxInfo.Show("Вы успешно добавили\nсвое животное!");
            Close();
        }

        private void petNameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 'а' && e.KeyChar <= 'я') || (e.KeyChar >= 'А' && e.KeyChar <= 'Я') || (e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == ' ' || (e.KeyChar >= 1 && e.KeyChar <= 31) || e.KeyChar == (char)Keys.Back) { }
            else e.Handled = true;
        }
    }
}
