using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using VeterinaryClinic.MiniForms;
using static System.String;

namespace VeterinaryClinic.Forms
{
    public partial class MyPetsForm : Form
    {
        internal static string EditIndex { get; set; }
        private int _amountPage;
        private int _amountRecord;
        private int _nowPage = 1;
        public MyPetsForm()
        {
            InitializeComponent();
            GoUpdateDataGrid();

            mainTable.ColumnCount = 4;
            mainTable.Columns[0].Visible = false;
            mainTable.Columns[1].Width = 200;
            mainTable.Columns[2].Width = 50;
            mainTable.Columns[3].Width = 374;
            mainTable.Columns[0].HeaderText = "ID";
            mainTable.Columns[1].HeaderText = "Имя животного";
            mainTable.Columns[2].HeaderText = "Пол";
            mainTable.Columns[3].HeaderText = "Особенности";
        }

        private void MainTable_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void Aboba()
        {
            if (mainTable.RowCount == 0)
                return;

            var id = mainTable[0, mainTable.SelectedCells[0].RowIndex].Value.ToString();
            var result = Data.ReturnDataTable($@"exec [dbo].[GetOrders] '{id}'");

            if (result.HasZeroRows)
            {
                label1.Text = "Оформлений нет";
                label2.Text = "";
                return;
            }

            label1.Text = "Оформления:";
            label2.Text = "";
            for (var i = 0; i < result.DataTable.Rows.Count; i++)
            {
                label2.Text += result.DataTable.Rows[i][0] + Environment.NewLine;
                label2.Text += result.DataTable.Rows[i][1] + " шт. - " + result.DataTable.Rows[i][2] + " руб." + Environment.NewLine;
                var temp = Convert.ToInt32(result.DataTable.Rows[i][3].ToString());
                var temp2 = AppUser.UnixToDateTime(temp).ToLongDateString() + " " + AppUser.UnixToDateTime(temp).ToShortTimeString();
                label2.Text += temp2 + Environment.NewLine + Environment.NewLine;
            }
        }

        private void GoToAdd_Click(object sender, EventArgs e)
        {
            OpenMiniForm.Shading(new AddMyPet());
            GoUpdateDataGrid();
        }
        private void GoUpdateDataGrid()
        {
            var result1 = Data.ReturnDataTable($@"select count(PetID) from Pets where CustomerID = (select C.CustomerID from Accounts A left join Customers C on A.AccountID = C.AccountID where A.AccountID = '{AppUser.AccountId}') and (PetName like '%{seacher.Text.Trim()}%' or Gender like '%{seacher.Text.Trim()}%' or Peculiarities like '%{seacher.Text.Trim()}%')");
            var result2 = Data.ReturnDataTable($@"select PetID, PetName, Gender, Peculiarities from Pets where CustomerID = (select C.CustomerID from Accounts A left join Customers C on A.AccountID = C.AccountID where A.AccountID = '{AppUser.AccountId}') and (PetName like '%{seacher.Text.Trim()}%' or Gender like '%{seacher.Text.Trim()}%' or Peculiarities like '%{seacher.Text.Trim()}%') ORDER BY PetName ASC OFFSET {_nowPage * AppUser.AmountRecordsInPage - AppUser.AmountRecordsInPage} ROWS FETCH NEXT {AppUser.AmountRecordsInPage} ROWS ONLY");

            if (result1.HasError || result2.HasError)
            {
                errorLabel.Visible = true;
                mainTable.Rows.Clear();
                return;
            }
            errorLabel.Visible = false;

            if (result2.HasZeroRows)
            {
                zeroRowsLabel.Visible = true;
                mainTable.Rows.Clear();
                zeroRowsLabel.Text = "";
                errorLabel.Text = "";
                return;
            }
            zeroRowsLabel.Visible = false;

            _amountRecord = Convert.ToInt32(result1.DataTable.Rows[0][0]);

            countRowsLabel.Text = $"Всего найдено {_amountRecord} животных";
            seeLabel.Text = _amountRecord >= _nowPage * AppUser.AmountRecordsInPage ? $"показано с {_nowPage * AppUser.AmountRecordsInPage - AppUser.AmountRecordsInPage + 1} по {_nowPage * AppUser.AmountRecordsInPage} животное" : $"показано с {_nowPage * AppUser.AmountRecordsInPage - AppUser.AmountRecordsInPage + 1} по {_amountRecord} животное";

            mainTable.ColumnCount = result2.DataTable.Columns.Count;
            mainTable.RowCount = result2.DataTable.Rows.Count;

            mainTable.Columns[0].Visible = false;
            mainTable.Columns[1].Width = 200;
            mainTable.Columns[2].Width = 50;
            mainTable.Columns[3].Width = 374;
            mainTable.Columns[0].HeaderText = "ID";
            mainTable.Columns[1].HeaderText = "Имя животного";
            mainTable.Columns[2].HeaderText = "Пол";
            mainTable.Columns[3].HeaderText = "Особенности";
            for (var i = 0; i < result2.DataTable.Rows.Count; i++)
            {
                mainTable[0, i].Value = result2.DataTable.Rows[i][0].ToString();
                mainTable[1, i].Value = result2.DataTable.Rows[i][1].ToString();
                mainTable[2, i].Value = result2.DataTable.Rows[i][2].ToString();
                mainTable[3, i].Value = result2.DataTable.Rows[i][3].ToString();
            }

            _amountPage = _amountRecord / AppUser.AmountRecordsInPage;
            if (Convert.ToDouble(_amountRecord % AppUser.AmountRecordsInPage) > 0)
                _amountPage++;

            amountPagesComboBox.Items.Clear();
            for (var i = 0; i < _amountPage; i++)
                amountPagesComboBox.Items.Add(i + 1);
            amountPagesComboBox.SelectedIndex = _nowPage - 1;

            Aboba();
        }

        private void GoToSearch_Click(object sender, EventArgs e)
        {
            _nowPage = 1;
            GoUpdateDataGrid();
        }

        private void UpdateMove(object sender, EventArgs e)
        {
            var bt = (Guna2ImageButton)sender;

            switch (bt.Name)
            {
                case "doubleRightWarp":
                    _nowPage = _amountPage;
                    break;

                case "rightWarp":
                    if (_nowPage + 1 <= _amountPage)
                        _nowPage += 1;
                    break;

                case "doubleLeftWarp":
                    _nowPage = 1;
                    break;

                case "leftWarp":
                    if (_nowPage - 1 > 0)
                        _nowPage -= 1;
                    break;
            }

            GoUpdateDataGrid();
        }

        private void AmountPagesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_nowPage.ToString() == amountPagesComboBox.SelectedItem.ToString())
                return;

            _nowPage = Convert.ToInt32(amountPagesComboBox.SelectedItem);
            GoUpdateDataGrid();
        }

        private void Seacher_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)Keys.Enter) return;

            _nowPage = 1;
            GoUpdateDataGrid();
        }

        private void goToClearSeacher_Click(object sender, EventArgs e)
        {
            seacher.Text = Empty;
            GoUpdateDataGrid();
        }

        private void goToDelete_Click(object sender, EventArgs e)
        {
            var id = mainTable[0, mainTable.SelectedCells[0].RowIndex].Value.ToString();
            var name = mainTable[1, mainTable.SelectedCells[0].RowIndex].Value.ToString();

            var res = myMessageBoxQuestion.Show($@"Вы точно хотите удалить животное {name}?");

            if (res != DialogResult.Yes)
                return;

            var result = Data.ReturnDataTable($@"delete from Pets where PetID = '{id}'");

            if (result.HasError && result.ErrorText != "Невозможно найти таблицу 0.")
            {
                myMessageBoxError.Show($@"Не удалось удалить животное {name}." + Environment.NewLine + result.ErrorText);
                return;
            }

            myMessageBoxInfo.Show($@"Вы успешно удалили животное {name}!");
            GoUpdateDataGrid();
        }

        private async void mainTable_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            await Task.Delay(200);
            Aboba();
        }

        private void goToEdit_Click(object sender, EventArgs e)
        {
            EditIndex = mainTable[0, mainTable.SelectedCells[0].RowIndex].Value.ToString();
            OpenMiniForm.Shading(new EditMyPet());
            GoUpdateDataGrid();
        }
    }
}
