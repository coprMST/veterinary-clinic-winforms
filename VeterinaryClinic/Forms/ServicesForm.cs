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

namespace VeterinaryClinic.Forms
{
    internal partial class ServicesForm : Form
    {
        private int _amountRecordsInPage = 10;
        private int _amountPage = 0;
        private int _amountRecord = 0;
        private int _numberPage = 3;
        private int _nowPage = 1;


        internal ServicesForm()
        {
            InitializeComponent();
            UpdateDataGrid();
        }

        private void UpdateDataGrid()
        {
            var result1 = Data.ReturnDataTable($@"select count(ST.ServiceTypeID) from Services S left join ServiceTypes ST on S.ServiceID = ST.ServiceID where S.InArchive = 0 and ST.InArchive = 0 and ServiceName like '%{seacher.Text.Trim()}%' and ServiceTypeName like '%{seacher.Text.Trim()}%'");
            var result2 = Data.ReturnDataTable($@"select ServiceName, ServiceTypeName, FirstPrice, SecondPrice from Services S left join ServiceTypes ST on S.ServiceID = ST.ServiceID where S.InArchive = 0 and ST.InArchive = 0 and ServiceName like '%{seacher.Text.Trim()}%' and ServiceTypeName like '%{seacher.Text.Trim()}%' ORDER BY S.ServiceName DESC OFFSET {_amountRecordsInPage * _numberPage - _amountRecordsInPage} ROWS FETCH NEXT {_amountRecordsInPage} ROWS ONLY");

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
                countRowsLabel.Text = "Записи не найдены";
                return;
            }
            zeroRowsLabel.Visible = false;

            _amountRecord = Convert.ToInt32(result1.DataTable.Rows[0][0]);
            countRowsLabel.Text = $"Всего найдено {_amountRecord} записей";

            mainTable.ColumnCount = result2.DataTable.Columns.Count;
            mainTable.RowCount = _amountRecordsInPage;

            for (var i = 0; i < _amountRecordsInPage; i++)
            {
                mainTable[0, i].Value = result2.DataTable.Rows[i][0].ToString();
                mainTable[1, i].Value = result2.DataTable.Rows[i][1].ToString();
                mainTable[2, i].Value = result2.DataTable.Rows[i][3] == DBNull.Value ? result2.DataTable.Rows[i][2] + "P" : result2.DataTable.Rows[i][2] + " - " + result2.DataTable.Rows[i][3] + "P";
                mainTable.Columns[0].Width = 250;
                mainTable.Columns[1].Width = 520;
                mainTable.Columns[2].Width = 180;
            }

        }

        private void GoToSearch_Click(object sender, EventArgs e)
        {
            UpdateDataGrid();
        }

        private void UpdateMove(object sender, EventArgs e)
        {
            var bt = (Guna2ImageButton)sender;

            switch (bt.Name)
            {
                case "doubleLeftWarp":
                    _nowPage = 1;
                    break;
            }

            void Calc(int move)
            {

            }

            UpdateDataGrid();
        }
    }
}
