using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EasyDox;
using static System.String;

namespace VeterinaryClinic.Forms
{
    internal partial class MeetingForm : Form
    {
        internal MeetingForm()
        {
            InitializeComponent();

            for (var i = 0; i < 7; i++)
            {
                dateComboBox.Items.Add(DateTime.Now.AddDays(i).ToLongDateString());
            }

            dateComboBox.SelectedIndex = 0;
        }

        private void DateComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var dt = Convert.ToDateTime(dateComboBox.SelectedItem).ToString("yyyy-MM-dd");
            var result = Data.ReturnDataTable($"select [DateTime] from [dbo].[Meetings] where [DateTime] like '%{dt}%'");

            timeComboBox.Enabled = true;

            timeComboBox.SelectedItem = -1;
            timeComboBox.Items.Clear();
            for (var i = 10; i < 19; i++)
            {
                timeComboBox.Items.Add($"{i}:00");
            }

            if (result.DataTable.Rows.Count == 0) return;

            for (var i = 0; i < result.DataTable.Rows.Count; i++)
            {
                var tempDate = Convert.ToDateTime(result.DataTable.Rows[i][0]).ToString("HH:mm");

                if (timeComboBox.Items.Contains(tempDate))
                    timeComboBox.Items.Remove(tempDate);
            }

            if (timeComboBox.Items.Count != 0) return;

            myMessageBoxInfo.Show(@"В указанный день свободные дни отсутствуют");
            timeComboBox.Text = Empty;
        }

        private void TimeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (timeComboBox.SelectedIndex == -1) return;

            commentBox.Enabled = true;
            goToCreateMeeting.Enabled = true;
        }

        private void GoToCreateMeeting_Click(object sender, EventArgs e)
        {
            var dt = Convert.ToDateTime(dateComboBox.SelectedItem).ToString("yyyy-MM-dd");
            var result = Data.ReturnDataTable($"exec [dbo].[AddNewMeeting] '{AppUser.AccountId}', '{dt + " " + timeComboBox.SelectedItem}', '{commentBox.Text}'");

            if (result.HasError && result.ErrorText != "Невозможно найти таблицу 0.")
            {
                myMessageBoxError.Show($@"Не удалось записаться на данную дату и время" + Environment.NewLine + result.ErrorText);
                return;
            }

            var fieldValues = new Dictionary<string, string> {
                {"Date", Convert.ToDateTime(dt).ToShortDateString()},
                {"Time", timeComboBox.SelectedItem.ToString()},
                {"FioCustomer", AppUser.GetName()},
                {"DateTimeCreated", DateTime.Now.ToString("f")},
            };

            var date = Convert.ToDateTime(dt).ToString("dd-MM-yyyy");
            var time = Convert.ToDateTime(timeComboBox.SelectedItem).ToString("hh-mm");

            var engine = new Engine();
            engine.Merge(Application.StartupPath + @"\\template.docx", fieldValues, Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + $@"\\Talon_{date}_{time}.docx");

            dateComboBox.SelectedIndex = 0;
            timeComboBox.Enabled = false;
            timeComboBox.SelectedIndex = -1;
            commentBox.Enabled = false;
            goToCreateMeeting.Enabled = false;

            myMessageBoxInfo.Show(@"Вы были успешно записаны на встречу с нотариусом");
        }
    }
}
