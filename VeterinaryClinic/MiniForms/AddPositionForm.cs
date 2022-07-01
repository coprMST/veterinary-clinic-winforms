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
    public partial class AddPositionForm : Form
    {
        public AddPositionForm()
        {
            InitializeComponent();
        }

        private void goToAdd_Click(object sender, EventArgs e)
        {
            if (IsNullOrEmpty(positionNameTextBox.Text.Trim()) || IsNullOrEmpty(respTextBox.Text.Trim()) || IsNullOrEmpty(salaryTextBox.Text.Trim()))
                return;

            Data.ReturnDataTable($@"insert into [dbo].[Positions] ([PositionName], [Salary], [Responsibilities]) values ('{positionNameTextBox.Text.Trim()}', '{salaryTextBox.Text.Trim()}', '{respTextBox.Text.Trim()}')");

            myMessageBoxInfo.Show($@"Вы успешно добавили данные!");
            Close();
        }

        private void salaryTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '1' && e.KeyChar <= '9') || e.KeyChar == ',' || e.KeyChar == (char)Keys.Back) { }
            else e.Handled = true;
        }

        private void goToCloseForm_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
