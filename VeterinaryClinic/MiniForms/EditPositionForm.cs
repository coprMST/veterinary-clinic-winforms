using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VeterinaryClinic.Forms;
using static System.String;

namespace VeterinaryClinic.MiniForms
{
    internal partial class EditPosition : Form
    {
        internal EditPosition()
        {
            InitializeComponent();

            var result = Data.ReturnDataTable($@"select PositionName, Salary, Responsibilities from Positions where PositionID = {DataForm.EditIndex}");

            positionNameTextBox.Text = result.DataTable.Rows[0][0].ToString();
            salaryTextBox.Text = result.DataTable.Rows[0][1].ToString();
            respTextBox.Text = result.DataTable.Rows[0][2].ToString();
        }

        private void GoToCloseForm_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void goToAdd_Click(object sender, EventArgs e)
        {
            if (IsNullOrEmpty(positionNameTextBox.Text.Trim()) || IsNullOrEmpty(respTextBox.Text.Trim()) || IsNullOrEmpty(salaryTextBox.Text.Trim()))
                return;

            Data.ReturnDataTable($@"UPDATE Positions SET PositionName = '{positionNameTextBox.Text.Trim()}' where PositionID = '{DataForm.EditIndex}'");
            Data.ReturnDataTable($@"UPDATE Positions SET Salary = '{Convert.ToDouble(salaryTextBox.Text.Trim())}' where PositionID = '{DataForm.EditIndex}'");
            Data.ReturnDataTable($@"UPDATE Positions SET Responsibilities = '{respTextBox.Text.Trim()}' where PositionID = '{DataForm.EditIndex}'");

            myMessageBoxInfo.Show($@"Вы успешно обновили данные!");
            Close();
        }

        private void salaryTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void salaryTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '1' && e.KeyChar <= '9') || e.KeyChar == ',' || e.KeyChar == (char)Keys.Back) { }
            else e.Handled = true;
        }
    }
}
