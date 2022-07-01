using System;
using System.Windows.Forms;
using VeterinaryClinic.Forms;
using static System.String;

namespace VeterinaryClinic.MiniForms
{
    public partial class EditMyPet : Form
    {
        public EditMyPet()
        {
            InitializeComponent();

            var result = Data.ReturnDataTable($@"select PetName, Peculiarities, Gender from Pets where PetID = '{MyPetsForm.EditIndex}'");

            petNameTextBox.Text = result.DataTable.Rows[0][0].ToString();
            peculiaritiesTextBox.Text = result.DataTable.Rows[0][1].ToString();
            var gender = result.DataTable.Rows[0][2].ToString();
            switch (gender)
            {
                case "М":
                    maleButton.Checked = true;
                    break;
                case "Ж":
                    femaleButton.Checked = true;
                    break;
            }
        }

        private void petNameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 'а' && e.KeyChar <= 'я') || (e.KeyChar >= 'А' && e.KeyChar <= 'Я') || (e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == ' ' || (e.KeyChar >= 1 && e.KeyChar <= 31) || e.KeyChar == (char)Keys.Back) { }
            else
            {
                e.Handled = true;
            }
        }

        private void goToEdit_Click(object sender, EventArgs e)
        {
            if (IsNullOrEmpty(petNameTextBox.Text.Trim()) || IsNullOrEmpty(peculiaritiesTextBox.Text.Trim()) || !maleButton.Checked && !femaleButton.Checked)
            {
                return;
            }

            Data.ReturnDataTable($@"UPDATE Pets SET PetName = '{petNameTextBox.Text.Trim()}' where PetID = '{MyPetsForm.EditIndex}'");
            Data.ReturnDataTable($@"UPDATE Pets SET Peculiarities = '{peculiaritiesTextBox.Text.Trim()}' where PetID = '{MyPetsForm.EditIndex}'");

            if (maleButton.Checked)
            {
                Data.ReturnDataTable($@"UPDATE Pets SET Gender = 'М' where PetID = '{MyPetsForm.EditIndex}'");
            }
            else if (femaleButton.Checked)
            {
                Data.ReturnDataTable($@"UPDATE Pets SET Gender = 'Ж' where PetID = '{MyPetsForm.EditIndex}'");
            }

            myMessageBoxInfo.Show($@"Вы успешно обновили данные!");
            Close();
        }

        private void goToCloseForm_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
