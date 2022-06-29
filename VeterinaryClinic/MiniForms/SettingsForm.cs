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
        }

        private void GoToCloseForm_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void GoToSave_Click(object sender, EventArgs e)
        {
            if (serverTextBox.Text.Trim() != Empty)
                Data.Settings.DataSource = serverTextBox.Text.Trim();

            if (mainCheckBox.Checked)
                Data.Settings.DataSource = Environment.MachineName;

            if (databaseTextBox.Text.Trim() != Empty)
                Data.Settings.InitialCatalog = databaseTextBox.Text.Trim();

            if (serverTextBox.Text.Trim() == Empty && databaseTextBox.Text.Trim() == Empty) 
                return;

            myMessageBoxInfo.Show("Настройки были успешно изменены");

            Close();
        }

        private void GoToDefault_Click(object sender, EventArgs e)
        {
            Data.Settings.DataSource = Environment.MachineName;
            Data.Settings.InitialCatalog = "VeterinaryClinicDB";
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
    }
}
