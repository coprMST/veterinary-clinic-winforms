
namespace VeterinaryClinic.MiniForms
{
    partial class SettingsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.goToSave = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.databaseTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.serverTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.mainCheckBox = new Guna.UI2.WinForms.Guna2CustomCheckBox();
            this.helperButton = new Guna.UI2.WinForms.Guna2ImageButton();
            this.goToDefault = new Guna.UI2.WinForms.Guna2Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.goToCloseForm = new Guna.UI2.WinForms.Guna2Button();
            this.myMessageBoxInfo = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.label4 = new System.Windows.Forms.Label();
            this.maxAmountRecordsTextBox = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.mainToolTip = new Guna.UI2.WinForms.Guna2HtmlToolTip();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maxAmountRecordsTextBox)).BeginInit();
            this.SuspendLayout();
            // 
            // goToSave
            // 
            this.goToSave.Animated = true;
            this.goToSave.AutoRoundedCorners = true;
            this.goToSave.BorderColor = System.Drawing.Color.Transparent;
            this.goToSave.BorderRadius = 21;
            this.goToSave.BorderThickness = 2;
            this.goToSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.goToSave.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(116)))), ((int)(((byte)(144)))));
            this.goToSave.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.goToSave.ForeColor = System.Drawing.Color.White;
            this.goToSave.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(116)))), ((int)(((byte)(144)))));
            this.goToSave.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.goToSave.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(116)))), ((int)(((byte)(144)))));
            this.goToSave.Location = new System.Drawing.Point(131, 422);
            this.goToSave.Name = "goToSave";
            this.goToSave.Size = new System.Drawing.Size(220, 45);
            this.goToSave.TabIndex = 97;
            this.goToSave.Text = "Сохранить";
            this.mainToolTip.SetToolTip(this.goToSave, "Сохранить настройки");
            this.goToSave.Click += new System.EventHandler(this.GoToSave_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(71, 199);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 19);
            this.label1.TabIndex = 96;
            this.label1.Text = "Имя базы данных";
            // 
            // databaseTextBox
            // 
            this.databaseTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.databaseTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(213)))), ((int)(((byte)(215)))));
            this.databaseTextBox.BorderRadius = 8;
            this.databaseTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.databaseTextBox.DefaultText = "";
            this.databaseTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.databaseTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.databaseTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.databaseTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.databaseTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(116)))), ((int)(((byte)(144)))));
            this.databaseTextBox.Font = new System.Drawing.Font("Arial", 14F);
            this.databaseTextBox.ForeColor = System.Drawing.Color.Black;
            this.databaseTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(116)))), ((int)(((byte)(144)))));
            this.databaseTextBox.IconLeftOffset = new System.Drawing.Point(6, 0);
            this.databaseTextBox.IconLeftSize = new System.Drawing.Size(30, 30);
            this.databaseTextBox.IconRightOffset = new System.Drawing.Point(12, 0);
            this.databaseTextBox.IconRightSize = new System.Drawing.Size(26, 26);
            this.databaseTextBox.Location = new System.Drawing.Point(52, 227);
            this.databaseTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.databaseTextBox.MaxLength = 128;
            this.databaseTextBox.Name = "databaseTextBox";
            this.databaseTextBox.PasswordChar = '\0';
            this.databaseTextBox.PlaceholderText = "";
            this.databaseTextBox.SelectedText = "";
            this.databaseTextBox.Size = new System.Drawing.Size(389, 51);
            this.databaseTextBox.TabIndex = 95;
            this.databaseTextBox.TextOffset = new System.Drawing.Point(4, 0);
            this.mainToolTip.SetToolTip(this.databaseTextBox, "Введите имя базы данных");
            this.databaseTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressValidate);
            // 
            // serverTextBox
            // 
            this.serverTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.serverTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(213)))), ((int)(((byte)(215)))));
            this.serverTextBox.BorderRadius = 8;
            this.serverTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.serverTextBox.DefaultText = "";
            this.serverTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.serverTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.serverTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.serverTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.serverTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(116)))), ((int)(((byte)(144)))));
            this.serverTextBox.Font = new System.Drawing.Font("Arial", 14F);
            this.serverTextBox.ForeColor = System.Drawing.Color.Black;
            this.serverTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(116)))), ((int)(((byte)(144)))));
            this.serverTextBox.IconLeftOffset = new System.Drawing.Point(6, 0);
            this.serverTextBox.IconLeftSize = new System.Drawing.Size(30, 30);
            this.serverTextBox.Location = new System.Drawing.Point(52, 91);
            this.serverTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.serverTextBox.MaxLength = 128;
            this.serverTextBox.Name = "serverTextBox";
            this.serverTextBox.PasswordChar = '\0';
            this.serverTextBox.PlaceholderText = "";
            this.serverTextBox.SelectedText = "";
            this.serverTextBox.Size = new System.Drawing.Size(389, 51);
            this.serverTextBox.TabIndex = 94;
            this.serverTextBox.TextOffset = new System.Drawing.Point(4, 0);
            this.mainToolTip.SetToolTip(this.serverTextBox, "Введите имя сервера");
            this.serverTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressValidate);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(71, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 19);
            this.label2.TabIndex = 93;
            this.label2.Text = "Имя сервера";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label3.Location = new System.Drawing.Point(101, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(217, 20);
            this.label3.TabIndex = 99;
            this.label3.Text = "Использовать имя машины";
            this.mainToolTip.SetToolTip(this.label3, "Использовать имя машины в качестве имени сервера");
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // mainCheckBox
            // 
            this.mainCheckBox.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(116)))), ((int)(((byte)(144)))));
            this.mainCheckBox.CheckedState.BorderRadius = 2;
            this.mainCheckBox.CheckedState.BorderThickness = 0;
            this.mainCheckBox.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(116)))), ((int)(((byte)(144)))));
            this.mainCheckBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mainCheckBox.Location = new System.Drawing.Point(75, 150);
            this.mainCheckBox.Name = "mainCheckBox";
            this.mainCheckBox.Size = new System.Drawing.Size(24, 24);
            this.mainCheckBox.TabIndex = 98;
            this.mainToolTip.SetToolTip(this.mainCheckBox, "Использовать имя машины в качестве имени сервера");
            this.mainCheckBox.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(48)))), ((int)(((byte)(100)))));
            this.mainCheckBox.UncheckedState.BorderRadius = 2;
            this.mainCheckBox.UncheckedState.BorderThickness = 1;
            this.mainCheckBox.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.mainCheckBox.CheckedChanged += new System.EventHandler(this.MainCheckBox_CheckedChanged);
            // 
            // helperButton
            // 
            this.helperButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.helperButton.BackColor = System.Drawing.Color.Transparent;
            this.helperButton.CheckedState.ImageSize = new System.Drawing.Size(42, 42);
            this.helperButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.helperButton.HoverState.ImageSize = new System.Drawing.Size(42, 42);
            this.helperButton.Image = ((System.Drawing.Image)(resources.GetObject("helperButton.Image")));
            this.helperButton.ImageOffset = new System.Drawing.Point(0, 0);
            this.helperButton.ImageRotate = 0F;
            this.helperButton.ImageSize = new System.Drawing.Size(48, 48);
            this.helperButton.Location = new System.Drawing.Point(433, 482);
            this.helperButton.Margin = new System.Windows.Forms.Padding(0);
            this.helperButton.Name = "helperButton";
            this.helperButton.PressedState.ImageSize = new System.Drawing.Size(42, 42);
            this.helperButton.Size = new System.Drawing.Size(60, 60);
            this.helperButton.TabIndex = 102;
            this.mainToolTip.SetToolTip(this.helperButton, "Открыть руководство по данной странице");
            // 
            // goToDefault
            // 
            this.goToDefault.Animated = true;
            this.goToDefault.AutoRoundedCorners = true;
            this.goToDefault.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(116)))), ((int)(((byte)(144)))));
            this.goToDefault.BorderRadius = 21;
            this.goToDefault.BorderThickness = 2;
            this.goToDefault.Cursor = System.Windows.Forms.Cursors.Hand;
            this.goToDefault.FillColor = System.Drawing.Color.Transparent;
            this.goToDefault.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.goToDefault.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(116)))), ((int)(((byte)(144)))));
            this.goToDefault.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.goToDefault.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(116)))), ((int)(((byte)(144)))));
            this.goToDefault.HoverState.ForeColor = System.Drawing.Color.White;
            this.goToDefault.Location = new System.Drawing.Point(131, 482);
            this.goToDefault.Name = "goToDefault";
            this.goToDefault.Size = new System.Drawing.Size(220, 45);
            this.goToDefault.TabIndex = 103;
            this.goToDefault.Text = "Сбросить";
            this.mainToolTip.SetToolTip(this.goToDefault, "Выставить настройки по умолчанию\r\n");
            this.goToDefault.Click += new System.EventHandler(this.GoToDefault_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(116)))), ((int)(((byte)(144)))));
            this.panel1.Controls.Add(this.goToCloseForm);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(493, 35);
            this.panel1.TabIndex = 104;
            // 
            // goToCloseForm
            // 
            this.goToCloseForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.goToCloseForm.Animated = true;
            this.goToCloseForm.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(94)))), ((int)(((byte)(117)))));
            this.goToCloseForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.goToCloseForm.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.goToCloseForm.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.goToCloseForm.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.goToCloseForm.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.goToCloseForm.FillColor = System.Drawing.Color.Transparent;
            this.goToCloseForm.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.goToCloseForm.ForeColor = System.Drawing.Color.White;
            this.goToCloseForm.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(81)))), ((int)(((byte)(93)))));
            this.goToCloseForm.Image = ((System.Drawing.Image)(resources.GetObject("goToCloseForm.Image")));
            this.goToCloseForm.ImageOffset = new System.Drawing.Point(1, 0);
            this.goToCloseForm.ImageSize = new System.Drawing.Size(25, 25);
            this.goToCloseForm.Location = new System.Drawing.Point(443, 0);
            this.goToCloseForm.Margin = new System.Windows.Forms.Padding(0);
            this.goToCloseForm.Name = "goToCloseForm";
            this.goToCloseForm.Size = new System.Drawing.Size(50, 35);
            this.goToCloseForm.TabIndex = 24;
            this.mainToolTip.SetToolTip(this.goToCloseForm, "Закрыть");
            this.goToCloseForm.Click += new System.EventHandler(this.GoToCloseForm_Click);
            // 
            // myMessageBoxInfo
            // 
            this.myMessageBoxInfo.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
            this.myMessageBoxInfo.Caption = "Настройки";
            this.myMessageBoxInfo.Icon = Guna.UI2.WinForms.MessageDialogIcon.Information;
            this.myMessageBoxInfo.Parent = null;
            this.myMessageBoxInfo.Style = Guna.UI2.WinForms.MessageDialogStyle.Dark;
            this.myMessageBoxInfo.Text = null;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(71, 304);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(302, 19);
            this.label4.TabIndex = 106;
            this.label4.Text = "Макс. количество записей в таблице";
            // 
            // maxAmountRecordsTextBox
            // 
            this.maxAmountRecordsTextBox.BackColor = System.Drawing.Color.Transparent;
            this.maxAmountRecordsTextBox.BorderRadius = 8;
            this.maxAmountRecordsTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.maxAmountRecordsTextBox.Font = new System.Drawing.Font("Arial", 14F);
            this.maxAmountRecordsTextBox.ForeColor = System.Drawing.Color.Black;
            this.maxAmountRecordsTextBox.Location = new System.Drawing.Point(52, 331);
            this.maxAmountRecordsTextBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.maxAmountRecordsTextBox.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.maxAmountRecordsTextBox.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.maxAmountRecordsTextBox.Name = "maxAmountRecordsTextBox";
            this.maxAmountRecordsTextBox.Size = new System.Drawing.Size(389, 51);
            this.maxAmountRecordsTextBox.TabIndex = 107;
            this.mainToolTip.SetToolTip(this.maxAmountRecordsTextBox, "Введите максимальное количество записей в таблице");
            this.maxAmountRecordsTextBox.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(238)))));
            this.maxAmountRecordsTextBox.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // mainToolTip
            // 
            this.mainToolTip.AllowLinksHandling = true;
            this.mainToolTip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(238)))));
            this.mainToolTip.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(213)))), ((int)(((byte)(215)))));
            this.mainToolTip.ForeColor = System.Drawing.Color.Black;
            this.mainToolTip.MaximumSize = new System.Drawing.Size(0, 0);
            this.mainToolTip.TitleFont = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.ClientSize = new System.Drawing.Size(493, 542);
            this.Controls.Add(this.maxAmountRecordsTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.goToDefault);
            this.Controls.Add(this.helperButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.mainCheckBox);
            this.Controls.Add(this.goToSave);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.databaseTextBox);
            this.Controls.Add(this.serverTextBox);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SettingsForm";
            this.ShowInTaskbar = false;
            this.Text = "SettingsForm";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.maxAmountRecordsTextBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button goToSave;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox databaseTextBox;
        private Guna.UI2.WinForms.Guna2TextBox serverTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2CustomCheckBox mainCheckBox;
        private Guna.UI2.WinForms.Guna2ImageButton helperButton;
        private Guna.UI2.WinForms.Guna2Button goToDefault;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button goToCloseForm;
        private Guna.UI2.WinForms.Guna2MessageDialog myMessageBoxInfo;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2NumericUpDown maxAmountRecordsTextBox;
        private Guna.UI2.WinForms.Guna2HtmlToolTip mainToolTip;
    }
}