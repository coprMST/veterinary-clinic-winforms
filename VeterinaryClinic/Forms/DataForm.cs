using System;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using VeterinaryClinic.MiniForms;
using static System.String;

namespace VeterinaryClinic.Forms
{
    internal partial class DataForm : Form
    {
        private string _table = "Positions";
        internal static string EditIndex { get; set; }
        private int _amountPage;
        private int _amountRecord;
        private int _nowPage = 1;

        internal DataForm()
        {
            InitializeComponent();
            GoUpdateDataGrid();
        }

        private void GoUpdateDataGrid()
        {
            Data.Result result1 = null;
            Data.Result result2 = null;

            // ORDER BY LastName ASC OFFSET {_nowPage * AppUser.AmountRecordsInPage - AppUser.AmountRecordsInPage} ROWS FETCH NEXT {AppUser.AmountRecordsInPage} ROWS ONLY
            switch (_table)
            {
                case "Positions":
                    result1 = Data.ReturnDataTable(
                        $@"select count(PositionID) from Positions where PositionName like '%{seacher.Text.Trim()}%' or Salary like '%{seacher.Text.Trim()}%' or Responsibilities like '%{seacher.Text.Trim()}%'");
                    result2 = Data.ReturnDataTable(
                        $@"select PositionID, PositionName, Salary, Responsibilities from Positions where PositionName like '%{seacher.Text.Trim()}%' or Salary like '%{seacher.Text.Trim()}%' or Responsibilities like '%{seacher.Text.Trim()}%' ORDER BY PositionName ASC OFFSET {_nowPage * AppUser.AmountRecordsInPage - AppUser.AmountRecordsInPage} ROWS FETCH NEXT {AppUser.AmountRecordsInPage} ROWS ONLY");
                    break;
                case "Employees":
                    result1 = Data.ReturnDataTable(
                        $@"select count(E.EmployeeID) from Employees E left join Positions P on E.PositionID = P.PositionID left join Accounts A on E.AccountID = A.AccountID where Email like '%{seacher.Text.Trim()}%' or PhoneNumber like '%{seacher.Text.Trim()}%' or LastName like '%{seacher.Text.Trim()}%' or FirstName like '%{seacher.Text.Trim()}%' or MiddleName like '%{seacher.Text.Trim()}%' or PositionName like '%{seacher.Text.Trim()}%' or DateOfBith like '%{seacher.Text.Trim()}%' or DateOfEmployment like '%{seacher.Text.Trim()}%'");
                    result2 = Data.ReturnDataTable(
                        $@"select E.AccountID, E.EmployeeID, Email, PhoneNumber, LastName, FirstName, MiddleName, PositionName, DateOfBith, DateOfEmployment from Employees E left join Positions P on E.PositionID = P.PositionID left join Accounts A on E.AccountID = A.AccountID where A.Email like '%{seacher.Text.Trim()}%' or PhoneNumber like '%{seacher.Text.Trim()}%' or LastName like '%{seacher.Text.Trim()}%' or FirstName like '%{seacher.Text.Trim()}%' or MiddleName like '%{seacher.Text.Trim()}%' or PositionName like '%{seacher.Text.Trim()}%' or DateOfBith like '%{seacher.Text.Trim()}%' or DateOfEmployment like '%{seacher.Text.Trim()}%' ORDER BY LastName ASC OFFSET {_nowPage * AppUser.AmountRecordsInPage - AppUser.AmountRecordsInPage} ROWS FETCH NEXT {AppUser.AmountRecordsInPage} ROWS ONLY");
                    break;
                case "Customers":
                    result1 = Data.ReturnDataTable(
                        $@"select count(CustomerID) from Customers С left join Accounts A on С.AccountID = A.AccountID where Email like '%{seacher.Text.Trim()}%' or PhoneNumber like '%{seacher.Text.Trim()}%' or LastName like '%{seacher.Text.Trim()}%' or FirstName like '%{seacher.Text.Trim()}%' or MiddleName like '%{seacher.Text.Trim()}%' or DateOfBith like '%{seacher.Text.Trim()}%'");
                    result2 = Data.ReturnDataTable(
                        $@"select CustomerID, С.AccountID, Email, PhoneNumber, LastName, FirstName, MiddleName, DateOfBith from Customers С left join Accounts A on С.AccountID = A.AccountID where Email like '%{seacher.Text.Trim()}%' or PhoneNumber like '%{seacher.Text.Trim()}%' or LastName like '%{seacher.Text.Trim()}%' or FirstName like '%{seacher.Text.Trim()}%' or MiddleName like '%{seacher.Text.Trim()}%' or DateOfBith like '%{seacher.Text.Trim()}%' ORDER BY LastName ASC OFFSET {_nowPage * AppUser.AmountRecordsInPage - AppUser.AmountRecordsInPage} ROWS FETCH NEXT {AppUser.AmountRecordsInPage} ROWS ONLY");
                    break;
                case "Services":
                    result1 = Data.ReturnDataTable(
                        $@"select count(ServiceID) from Services where ServiceName like '%{seacher.Text.Trim()}%'");
                    result2 = Data.ReturnDataTable(
                        $@"select ServiceID, ServiceName, InArchive from Services where ServiceName like '%{seacher.Text.Trim()}%' ORDER BY ServiceName ASC OFFSET {_nowPage * AppUser.AmountRecordsInPage - AppUser.AmountRecordsInPage} ROWS FETCH NEXT {AppUser.AmountRecordsInPage} ROWS ONLY");
                    break;
                case "ServiceTypes":
                    result1 = Data.ReturnDataTable(
                        $@"select count(ST.ServiceTypeID) from Services S left join ServiceTypes ST on S.ServiceID = ST.ServiceID where ServiceName like '%{seacher.Text.Trim()}%' or ServiceTypeName like '%{seacher.Text.Trim()}%'");
                    result2 = Data.ReturnDataTable(
                        $@"select ST.ServiceTypeID, ServiceName, ServiceTypeName, FirstPrice, SecondPrice, ST.InArchive from Services S left join ServiceTypes ST on S.ServiceID = ST.ServiceID where ServiceName like '%{seacher.Text.Trim()}%' or ServiceTypeName like '%{seacher.Text.Trim()}%' ORDER BY S.ServiceName ASC OFFSET {_nowPage * AppUser.AmountRecordsInPage - AppUser.AmountRecordsInPage} ROWS FETCH NEXT {AppUser.AmountRecordsInPage} ROWS ONLY");
                    break;
            }
            // S.InArchive = 0 and ST.InArchive = 0

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
                countRowsLabel.Text = "";
                seeLabel.Text = "";
                return;
            }

            zeroRowsLabel.Visible = false;

            _amountRecord = Convert.ToInt32(result1.DataTable.Rows[0][0]);

            countRowsLabel.Text = $"Всего найдено {_amountRecord} записей";
            seeLabel.Text = _amountRecord >= _nowPage * AppUser.AmountRecordsInPage
                ? $"показано с {_nowPage * AppUser.AmountRecordsInPage - AppUser.AmountRecordsInPage + 1} по {_nowPage * AppUser.AmountRecordsInPage} запись"
                : $"показано с {_nowPage * AppUser.AmountRecordsInPage - AppUser.AmountRecordsInPage + 1} по {_amountRecord} запись";

            mainTable.ColumnCount = result2.DataTable.Columns.Count;
            mainTable.RowCount = result2.DataTable.Rows.Count;

            switch (_table)
            {
                case "Positions":
                    mainTable.Columns[0].Visible = false;
                    mainTable.Columns[1].Visible = true;
                    mainTable.Columns[0].Width = 0;
                    mainTable.Columns[1].Width = 250;
                    mainTable.Columns[2].Width = 200;
                    mainTable.Columns[3].Width = 500;
                    mainTable.Columns[0].HeaderText = "ID";
                    mainTable.Columns[1].HeaderText = "Должность";
                    mainTable.Columns[2].HeaderText = "Зарплата";
                    mainTable.Columns[3].HeaderText = "Обязанности";
                    for (var i = 0; i < result2.DataTable.Rows.Count; i++)
                    {
                        mainTable[0, i].Value = result2.DataTable.Rows[i][0].ToString();
                        mainTable[1, i].Value = result2.DataTable.Rows[i][1].ToString();
                        mainTable[2, i].Value = result2.DataTable.Rows[i][2] + "P";
                        mainTable[3, i].Value = result2.DataTable.Rows[i][3].ToString();
                    }

                    break;

                case "Employees":
                    mainTable.Columns[0].Visible = false;
                    mainTable.Columns[1].Visible = false;
                    mainTable.Columns[0].Width = 0;
                    mainTable.Columns[1].Width = 0;
                    mainTable.Columns[2].Width = 135;
                    mainTable.Columns[3].Width = 135;
                    mainTable.Columns[4].Width = 135;
                    mainTable.Columns[5].Width = 135;
                    mainTable.Columns[6].Width = 135;
                    mainTable.Columns[7].Width = 135;
                    mainTable.Columns[8].Width = 135;
                    mainTable.Columns[9].Width = 135;
                    mainTable.Columns[0].HeaderText = "ID";
                    mainTable.Columns[1].HeaderText = "ID";
                    mainTable.Columns[2].HeaderText = "Почта";
                    mainTable.Columns[3].HeaderText = "Телефон";
                    mainTable.Columns[4].HeaderText = "Фамилия";
                    mainTable.Columns[5].HeaderText = "Имя";
                    mainTable.Columns[6].HeaderText = "Отчество";
                    mainTable.Columns[7].HeaderText = "Должность";
                    mainTable.Columns[8].HeaderText = "Дата рождения";
                    mainTable.Columns[9].HeaderText = "Дата трудоустр.";
                    for (var i = 0; i < result2.DataTable.Rows.Count; i++)
                    {
                        mainTable[0, i].Value = result2.DataTable.Rows[i][0].ToString();
                        mainTable[1, i].Value = result2.DataTable.Rows[i][1].ToString();
                        mainTable[2, i].Value = result2.DataTable.Rows[i][2].ToString();
                        mainTable[3, i].Value = result2.DataTable.Rows[i][3].ToString();
                        mainTable[4, i].Value = result2.DataTable.Rows[i][4].ToString();
                        mainTable[5, i].Value = result2.DataTable.Rows[i][5].ToString();
                        mainTable[6, i].Value = result2.DataTable.Rows[i][6].ToString();
                        mainTable[7, i].Value = result2.DataTable.Rows[i][7].ToString();
                        mainTable[8, i].Value = Convert.ToDateTime(result2.DataTable.Rows[i][8].ToString())
                            .ToShortDateString();
                        mainTable[9, i].Value = Convert.ToDateTime(result2.DataTable.Rows[i][9].ToString())
                            .ToShortDateString();
                    }

                    break;

                case "Customers":
                    mainTable.Columns[0].Visible = false;
                    mainTable.Columns[1].Visible = false;
                    mainTable.Columns[0].Width = 0;
                    mainTable.Columns[1].Width = 0;
                    mainTable.Columns[2].Width = 250;
                    mainTable.Columns[3].Width = 190;
                    mainTable.Columns[4].Width = 180;
                    mainTable.Columns[5].Width = 180;
                    mainTable.Columns[6].Width = 180;
                    mainTable.Columns[7].Width = 170;
                    mainTable.Columns[0].HeaderText = "ID";
                    mainTable.Columns[1].HeaderText = "ID";
                    mainTable.Columns[2].HeaderText = "Почта";
                    mainTable.Columns[3].HeaderText = "Телефон";
                    mainTable.Columns[4].HeaderText = "Фамилия";
                    mainTable.Columns[5].HeaderText = "Имя";
                    mainTable.Columns[6].HeaderText = "Отчество";
                    mainTable.Columns[7].HeaderText = "Дата рождения";
                    for (var i = 0; i < result2.DataTable.Rows.Count; i++)
                    {
                        mainTable[0, i].Value = result2.DataTable.Rows[i][0].ToString();
                        mainTable[1, i].Value = result2.DataTable.Rows[i][1].ToString();
                        mainTable[2, i].Value = result2.DataTable.Rows[i][2].ToString();
                        mainTable[3, i].Value = result2.DataTable.Rows[i][3].ToString();
                        mainTable[4, i].Value = result2.DataTable.Rows[i][4].ToString();
                        mainTable[5, i].Value = result2.DataTable.Rows[i][5].ToString();
                        mainTable[6, i].Value = result2.DataTable.Rows[i][6].ToString();
                        mainTable[7, i].Value = Convert.ToDateTime(result2.DataTable.Rows[i][7].ToString())
                            .ToShortDateString();
                    }

                    break;

                case "Services":
                    mainTable.Columns[0].Visible = false;
                    mainTable.Columns[1].Visible = true;
                    mainTable.Columns[0].Width = 0;
                    mainTable.Columns[1].Width = 800;
                    mainTable.Columns[2].Width = 150;
                    mainTable.Columns[0].HeaderText = "ID";
                    mainTable.Columns[1].HeaderText = "Категория";
                    mainTable.Columns[2].HeaderText = "В архиве";
                    for (var i = 0; i < result2.DataTable.Rows.Count; i++)
                    {
                        mainTable[0, i].Value = result2.DataTable.Rows[i][0].ToString();
                        mainTable[1, i].Value = result2.DataTable.Rows[i][1].ToString();
                        mainTable[2, i].Value = result2.DataTable.Rows[i][2].ToString() == "True" ? "Да" : "Нет";
                    }

                    break;

                case "ServiceTypes":
                    mainTable.Columns[0].Visible = false;
                    mainTable.Columns[1].Visible = true;
                    mainTable.Columns[0].Width = 0;
                    mainTable.Columns[1].Width = 240;
                    mainTable.Columns[2].Width = 430;
                    mainTable.Columns[3].Width = 160;
                    mainTable.Columns[4].Width = 120;
                    mainTable.Columns[0].HeaderText = "ID";
                    mainTable.Columns[1].HeaderText = "Категория";
                    mainTable.Columns[2].HeaderText = "Услуга";
                    mainTable.Columns[3].HeaderText = "Стоимость";
                    mainTable.Columns[4].HeaderText = "В архиве";
                    for (var i = 0; i < result2.DataTable.Rows.Count; i++)
                    {
                        mainTable[0, i].Value = result2.DataTable.Rows[i][0].ToString();
                        mainTable[1, i].Value = result2.DataTable.Rows[i][1].ToString();
                        mainTable[2, i].Value = result2.DataTable.Rows[i][2].ToString();
                        mainTable[3, i].Value = result2.DataTable.Rows[i][4] == DBNull.Value
                            ? result2.DataTable.Rows[i][3] + "P"
                            : result2.DataTable.Rows[i][3] + " - " + result2.DataTable.Rows[i][4] + "P";
                        mainTable[4, i].Value = result2.DataTable.Rows[i][5].ToString() == "True" ? "Да" : "Нет";
                    }

                    break;
            }

            _amountPage = _amountRecord / AppUser.AmountRecordsInPage;
            if (Convert.ToDouble(_amountRecord % AppUser.AmountRecordsInPage) > 0)
                _amountPage++;

            amountPagesComboBox.Items.Clear();
            for (var i = 0; i < _amountPage; i++)
                amountPagesComboBox.Items.Add(i + 1);
            amountPagesComboBox.SelectedIndex = _nowPage - 1;
        }

        private void GoToSearch_Click(object sender, EventArgs e)
        {
            _nowPage = 1;
            GoUpdateDataGrid();
        }

        private void UpdateMove(object sender, EventArgs e)
        {
            var bt = (Guna2ImageButton) sender;

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
            if (e.KeyChar != (char) Keys.Enter) return;

            _nowPage = 1;
            GoUpdateDataGrid();
        }

        private void MovePage(object sender, EventArgs e)
        {
            var bt = (Guna2Button) sender;

            switch (bt.Name)
            {
                case "goToOpenPositionsTable":
                    _table = "Positions";
                    break;
                case "goToOpenEmployeesTable":
                    _table = "Employees";
                    break;
                case "goToOpenCustomersTable":
                    _table = "Customers";
                    break;
                case "goToOpenServicesTable":
                    _table = "Services";
                    break;
                case "goToOpenServiceTypesTable":
                    _table = "ServiceTypes";
                    break;
            }

            _nowPage = 1;
            GoUpdateDataGrid();
        }

        private void goToDelete_Click(object sender, EventArgs e)
        {
            switch (_table)
            {
                case "Positions":
                    var id = mainTable[0, mainTable.SelectedCells[0].RowIndex].Value.ToString();
                    var name = mainTable[1, mainTable.SelectedCells[0].RowIndex].Value.ToString();

                    var res = myMessageBoxQuestion.Show($@"Вы точно хотите удалить должность {name}?");

                    if (res != DialogResult.Yes) return;

                    var result = Data.ReturnDataTable($@"delete from Positions where PositionID = '{id}'");

                    if (result.HasError && result.ErrorText != "Невозможно найти таблицу 0.")
                    {
                        myMessageBoxError.Show($@"Не удалось удалить должность {name}." + Environment.NewLine +
                                               result.ErrorText);
                        return;
                    }

                    myMessageBoxInfo.Show($@"Вы успешно удалили должность {name}!");

                    break;

                case "Employees":
                    var id1 = mainTable[0, mainTable.SelectedCells[0].RowIndex].Value.ToString();
                    var name1 = mainTable[4, mainTable.SelectedCells[0].RowIndex].Value.ToString();

                    if (id1 == AppUser.AccountId)
                    {
                        myMessageBoxError.Show($@"Не удалось удалить самого себя.");
                        return;
                    }

                    var res1 = myMessageBoxQuestion.Show($@"Вы точно хотите удалить сотрудника {name1}?");

                    if (res1 != DialogResult.Yes) return;

                    var result1 = Data.ReturnDataTable($@"delete from Accounts where AccountID = '{id1}'");

                    if (result1.HasError && result1.ErrorText != "Невозможно найти таблицу 0.")
                    {
                        myMessageBoxError.Show($@"Не удалось удалить сотрудника {name1}." + Environment.NewLine + result1.ErrorText);
                        return;
                    }

                    myMessageBoxInfo.Show($@"Вы успешно удалили сотрудника {name1}!");

                    break;
            }

            GoUpdateDataGrid();
        }

        private void GoToEdit_Click(object sender, EventArgs e)
        {
            switch (_table)
            {
                case "Positions":
                    EditIndex = mainTable[0, mainTable.SelectedCells[0].RowIndex].Value.ToString();
                    OpenMiniForm.Shading(ref Program.MainFormLink, new EditPosition());
                    break;
            }
        }

        private void goToAdd_Click(object sender, EventArgs e)
        {
            switch (_table)
            {
                case "Positions":
                    OpenMiniForm.Shading(ref Program.MainFormLink, new AddPositionForm());
                    break;
            }
        }

        private void goToClearSeacher_Click(object sender, EventArgs e)
        {
            seacher.Text = Empty;
            GoUpdateDataGrid();
        }
    }
}