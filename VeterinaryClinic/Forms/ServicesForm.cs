using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using VeterinaryClinic.MiniForms;

namespace VeterinaryClinic.Forms
{
    internal partial class ServicesForm : Form
    {
        private int _amountPage;
        private int _amountRecord;
        private int _nowPage = 1;

        internal ServicesForm()
        {
            InitializeComponent();
            GoUpdateDataGrid();
        }

        private void GoUpdateDataGrid()
        {
            var result1 = Data.ReturnDataTable($@"select count(ST.ServiceTypeID) from Services S left join ServiceTypes ST on S.ServiceID = ST.ServiceID where S.InArchive = 0 and ST.InArchive = 0 and ServiceName like '%{seacher.Text.Trim()}%' or ServiceTypeName like '%{seacher.Text.Trim()}%'");
            var result2 = Data.ReturnDataTable($@"select ServiceName, ServiceTypeName, FirstPrice, SecondPrice from Services S left join ServiceTypes ST on S.ServiceID = ST.ServiceID where S.InArchive = 0 and ST.InArchive = 0 and ServiceName like '%{seacher.Text.Trim()}%' or ServiceTypeName like '%{seacher.Text.Trim()}%' ORDER BY S.ServiceName ASC OFFSET {_nowPage * AppUser.AmountRecordsInPage - AppUser.AmountRecordsInPage} ROWS FETCH NEXT {AppUser.AmountRecordsInPage} ROWS ONLY");

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

            mainTable.Columns[0].Width = 250;
            mainTable.Columns[1].Width = 520;
            mainTable.Columns[2].Width = 180;
            for (var i = 0; i < result2.DataTable.Rows.Count; i++)
            {
                mainTable[0, i].Value = result2.DataTable.Rows[i][0].ToString();
                mainTable[1, i].Value = result2.DataTable.Rows[i][1].ToString();
                mainTable[2, i].Value = result2.DataTable.Rows[i][3] == DBNull.Value ? result2.DataTable.Rows[i][2] + "P" : result2.DataTable.Rows[i][2] + " - " + result2.DataTable.Rows[i][3] + "P";
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
    }
}
