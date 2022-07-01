using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static System.String;

namespace VeterinaryClinic.Forms
{
    internal partial class ServicesForm : Form
    {
        private int _amountPage;
        private int _amountRecord;
        private int _nowPage = 1;
        private string selectedPetId;
        private string[] petIds;
        private readonly Service _service = new Service();
        private string _textCart = Empty;

        internal ServicesForm()
        {
            InitializeComponent();
            GoUpdateDataGrid();

            if (AppUser.AccountType != "1")
                return;

            guna2Panel1.Visible = true;
            guna2Panel2.Visible = true;
            dateComboBox.Visible = true;

            var result = Data.ReturnDataTable($@"select PetID, PetName, Gender, Peculiarities from Pets where CustomerID = (select C.CustomerID from Accounts A left join Customers C on A.AccountID = C.AccountID where A.AccountID = '{AppUser.AccountId}')");
            petIds = new string[result.DataTable.Rows.Count];
            for (var i = 0; i < result.DataTable.Rows.Count; i++)
            {
                petIds[i] = result.DataTable.Rows[i][0].ToString();
                dateComboBox.Items.Add(result.DataTable.Rows[i][1].ToString());
            }

            try
            {
                dateComboBox.SelectedIndex = 0;
            }
            catch
            {
                // ignored
            }
        }

        private void dateComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedPetId = petIds[dateComboBox.SelectedIndex];
        }

        private void GoUpdateDataGrid()
        {
            var result1 = Data.ReturnDataTable($@"select count(ST.ServiceTypeID) from Services S left join ServiceTypes ST on S.ServiceID = ST.ServiceID where S.InArchive = 0 and ST.InArchive = 0 and ServiceName like '%{seacher.Text.Trim()}%' or ServiceTypeName like '%{seacher.Text.Trim()}%'");
            var result2 = Data.ReturnDataTable($@"select ST.ServiceTypeID, ServiceName, ServiceTypeName, FirstPrice, SecondPrice from Services S left join ServiceTypes ST on S.ServiceID = ST.ServiceID where S.InArchive = 0 and ST.InArchive = 0 and ServiceName like '%{seacher.Text.Trim()}%' or ServiceTypeName like '%{seacher.Text.Trim()}%' ORDER BY S.ServiceName ASC OFFSET {_nowPage * AppUser.AmountRecordsInPage - AppUser.AmountRecordsInPage} ROWS FETCH NEXT {AppUser.AmountRecordsInPage} ROWS ONLY");

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

            countRowsLabel.Text = $"Всего найдено {_amountRecord} услуг";
            seeLabel.Text = _amountRecord >= _nowPage * AppUser.AmountRecordsInPage ? $"показано с {_nowPage * AppUser.AmountRecordsInPage - AppUser.AmountRecordsInPage + 1} по {_nowPage * AppUser.AmountRecordsInPage} услугу" : $"показано с {_nowPage * AppUser.AmountRecordsInPage - AppUser.AmountRecordsInPage + 1} по {_amountRecord} услугу";

            mainTable.ColumnCount = result2.DataTable.Columns.Count;
            mainTable.RowCount = result2.DataTable.Rows.Count;

            mainTable.Columns[0].Visible = false;
            mainTable.Columns[0].Width = 0;
            mainTable.Columns[1].Width = 250;
            mainTable.Columns[2].Width = 520;
            mainTable.Columns[3].Width = 180;
            mainTable.Columns[0].HeaderText = "Id";
            mainTable.Columns[1].HeaderText = "Категория";
            mainTable.Columns[2].HeaderText = "Услуга";
            mainTable.Columns[3].HeaderText = "Стоимость";
            for (var i = 0; i < result2.DataTable.Rows.Count; i++)
            {
                mainTable[0, i].Value = result2.DataTable.Rows[i][0].ToString();
                mainTable[1, i].Value = result2.DataTable.Rows[i][1].ToString();
                mainTable[2, i].Value = result2.DataTable.Rows[i][2].ToString();
                mainTable[3, i].Value = result2.DataTable.Rows[i][4] == DBNull.Value ? result2.DataTable.Rows[i][3] + "Р" : result2.DataTable.Rows[i][3] + " - " + result2.DataTable.Rows[i][4] + "P";
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
            var bt = (Guna2ImageButton)sender;

            switch (bt.Name)
            {
                case "doubleRightWarp":
                    _nowPage = _amountPage;
                    break;

                case "rightWarp":
                    if (_nowPage + 1 <= _amountPage)
                    {
                        _nowPage += 1;
                    }

                    break;

                case "doubleLeftWarp":
                    _nowPage = 1;
                    break;

                case "leftWarp":
                    if (_nowPage - 1 > 0)
                    {
                        _nowPage -= 1;
                    }

                    break;
            }

            GoUpdateDataGrid();
        }

        private void AmountPagesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_nowPage.ToString() == amountPagesComboBox.SelectedItem.ToString())
            {
                return;
            }

            _nowPage = Convert.ToInt32(amountPagesComboBox.SelectedItem);
            GoUpdateDataGrid();
        }

        private void Seacher_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)Keys.Enter)
            {
                return;
            }

            _nowPage = 1;
            GoUpdateDataGrid();
        }

        private void goToClearSeacher_Click(object sender, EventArgs e)
        {
            seacher.Text = Empty;
            GoUpdateDataGrid();
        }

        private void goToAddCart_Click(object sender, EventArgs e)
        {
            if (mainTable[3, mainTable.SelectedCells[0].RowIndex].Value.ToString().Contains(" "))
            {
                myMessageBoxError.Show("Нельзя добавить данный товар");
                return;
            }

            _service.AddService(mainTable[0, mainTable.SelectedCells[0].RowIndex].Value.ToString(),
                mainTable[2, mainTable.SelectedCells[0].RowIndex].Value.ToString(),
                Convert.ToDouble(mainTable[3, mainTable.SelectedCells[0].RowIndex].Value.ToString().Replace("Р", "")));

            var quantity = 0;
            var price = 0d;
            var countServices = 0;
            _textCart = "";

            foreach (var servc in _service.Services)
            {
                countServices++;
                quantity += servc.Quantity;
                price += servc.Quantity * servc.Price;
                _textCart += servc.ServiceName + " - " + servc.Quantity + " шт. по " + servc.Price + " руб.\n";
            }

            label1.Text = $@"Итого: {price} руб.";
            label2.Text = $@"В корзине {countServices} вида товара суммано {quantity} шт.";
        }

        private void goToRemoveLast_Click(object sender, EventArgs e)
        {
            _service.Clear();
            _textCart = "Пусто";
            label1.Text = "";
            label2.Text = @"В корзине лежит целое ничего";
        }

        private void goToBuy_Click(object sender, EventArgs e)
        {
            if (dateComboBox.SelectedIndex < 0)
                return;

            var finalPrice = Convert.ToDecimal(label1.Text.Split(' ')[1]);
            var result = Data.ReturnDataTable($@"exec [dbo].[AddNewOrder] '{finalPrice}'");
            var id = result.DataTable.Rows[0][0].ToString();

            foreach (var servc in _service.Services)
            {
                Data.ReturnDataTable($@"insert into [dbo].[ListOfOrders](OrderID, ServiceID, PetID, Amount) values ('{id}', '{servc.Identificator}', '{selectedPetId}', '{servc.Quantity}')");
            }

            _service.Clear();
            _textCart = "Пусто";
            label1.Text = "";
            label2.Text = @"В корзине лежит целое ничего";
            myMessageBoxInfo.Show("Поздравляем с покупкой!");
        }

        private void cartImage_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_textCart);
        }
    }

    internal class Service
    {
        public List<Service> Services = new List<Service>();
        internal string Identificator;
        internal string ServiceName;
        internal int Quantity;
        internal double Price;

        internal void AddService(string serviceId, string serviceName, double price)
        {
            var search = Services.Find(x => x.Identificator == serviceId);
            if (search == null)
                Services.Add(new Service { Identificator = serviceId, ServiceName = serviceName, Price = price, Quantity = 1 });
            else
                Services[Services.IndexOf(search)].Quantity++;
        }

        internal void Clear()
        {
            Services.Clear();
        }
    }
}
