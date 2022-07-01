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
using VeterinaryClinic.Forms;
using static System.String;

namespace VeterinaryClinic.MiniForms
{
    internal partial class SettingsForm : Form
    {
        internal SettingsForm()
        {
            InitializeComponent();
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            serverTextBox.PlaceholderText = Data.Settings.DataSource;
            databaseTextBox.PlaceholderText = Data.Settings.InitialCatalog;
            maxAmountRecordsTextBox.Value = AppUser.AmountRecordsInPage;
        }

        private void GoToCloseForm_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void GoToSave_Click(object sender, EventArgs e)
        {
            if (serverTextBox.Text.Trim() == Empty && databaseTextBox.Text.Trim() == Empty && maxAmountRecordsTextBox.Value == AppUser.AmountRecordsInPage && !mainCheckBox.Checked)
                return;

            if (serverTextBox.Text.Trim() != Empty)
                Data.Settings.DataSource = serverTextBox.Text.Trim();

            if (mainCheckBox.Checked)
                Data.Settings.DataSource = Environment.MachineName;

            if (databaseTextBox.Text.Trim() != Empty)
                Data.Settings.InitialCatalog = databaseTextBox.Text.Trim();

            if (maxAmountRecordsTextBox.Value != AppUser.AmountRecordsInPage)
                AppUser.AmountRecordsInPage = Convert.ToInt32(maxAmountRecordsTextBox.Value);

            myMessageBoxInfo.Show("Настройки были успешно изменены");

            Close();
        }

        private void GoToDefault_Click(object sender, EventArgs e)
        {
            Data.Settings.DataSource = Environment.MachineName;
            Data.Settings.InitialCatalog = "VeterinaryClinicDB";
            AppUser.AmountRecordsInPage = 10;
            myMessageBoxInfo.Show("Настройки были успешно сброшены");

            Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            mainCheckBox.Checked = !mainCheckBox.Checked;
        }

        private void MainCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            serverTextBox.Enabled = !mainCheckBox.Checked;
        }

        private void KeyPressValidate(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 'A' && e.KeyChar <= 'Z') || (e.KeyChar >= 'А' && e.KeyChar <= 'Я') || (e.KeyChar >= 'а' && e.KeyChar <= 'я') || (e.KeyChar >= 1 && e.KeyChar <= 31) || (e.KeyChar >= 'a' && e.KeyChar <= 'z') || (e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == '-' || (e.KeyChar >= 33 && e.KeyChar <= 38) || (e.KeyChar >= 40 && e.KeyChar <= 126) || e.KeyChar == (char)Keys.Back) { }
            else e.Handled = true;
        }

        private void helperButton_Click(object sender, EventArgs e)
        {
            Helper.Open();
        }
    }
}
