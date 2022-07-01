namespace VeterinaryClinic.MiniForms
{
    partial class AuthForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AuthForm));
            this.mainToolTip = new Guna.UI2.WinForms.Guna2HtmlToolTip();
            this.goToLogIn = new Guna.UI2.WinForms.Guna2Button();
            this.passwordTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.loginTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.goToCloseForm = new Guna.UI2.WinForms.Guna2Button();
            this.helperButton = new Guna.UI2.WinForms.Guna2ImageButton();
            this.myMessageBoxGoodAuth = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.myMessageBoxWarning = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.myMessageBoxError = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.MainCheckBox = new Guna.UI2.WinForms.Guna2CustomCheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            // goToLogIn
            // 
            this.goToLogIn.Animated = true;
            this.goToLogIn.AutoRoundedCorners = true;
            this.goToLogIn.BorderColor = System.Drawing.Color.Transparent;
            this.goToLogIn.BorderRadius = 21;
            this.goToLogIn.BorderThickness = 2;
            this.goToLogIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.goToLogIn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(116)))), ((int)(((byte)(144)))));
            this.goToLogIn.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.goToLogIn.ForeColor = System.Drawing.Color.White;
            this.goToLogIn.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(116)))), ((int)(((byte)(144)))));
            this.goToLogIn.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.goToLogIn.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(116)))), ((int)(((byte)(144)))));
            this.goToLogIn.Location = new System.Drawing.Point(138, 434);
            this.goToLogIn.Name = "goToLogIn";
            this.goToLogIn.Size = new System.Drawing.Size(216, 45);
            this.goToLogIn.TabIndex = 90;
            this.goToLogIn.Text = "Войти";
            this.mainToolTip.SetToolTip(this.goToLogIn, "Авторизоваться в системе");
            this.goToLogIn.Click += new System.EventHandler(this.GoToLogIn_Click);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passwordTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(213)))), ((int)(((byte)(215)))));
            this.passwordTextBox.BorderRadius = 8;
            this.passwordTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passwordTextBox.DefaultText = "";
            this.passwordTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.passwordTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.passwordTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passwordTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passwordTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(116)))), ((int)(((byte)(144)))));
            this.passwordTextBox.Font = new System.Drawing.Font("Arial", 14F);
            this.passwordTextBox.ForeColor = System.Drawing.Color.Black;
            this.passwordTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(116)))), ((int)(((byte)(144)))));
            this.passwordTextBox.IconLeft = ((System.Drawing.Image)(resources.GetObject("passwordTextBox.IconLeft")));
            this.passwordTextBox.IconLeftOffset = new System.Drawing.Point(6, 0);
            this.passwordTextBox.IconLeftSize = new System.Drawing.Size(30, 30);
            this.passwordTextBox.IconRight = ((System.Drawing.Image)(resources.GetObject("passwordTextBox.IconRight")));
            this.passwordTextBox.IconRightOffset = new System.Drawing.Point(12, 0);
            this.passwordTextBox.IconRightSize = new System.Drawing.Size(26, 26);
            this.passwordTextBox.Location = new System.Drawing.Point(47, 233);
            this.passwordTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.passwordTextBox.MaxLength = 32;
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '●';
            this.passwordTextBox.PlaceholderText = "●●●●●●●●●●●●";
            this.passwordTextBox.SelectedText = "";
            this.passwordTextBox.Size = new System.Drawing.Size(389, 51);
            this.passwordTextBox.TabIndex = 88;
            this.passwordTextBox.TextOffset = new System.Drawing.Point(4, 0);
            this.mainToolTip.SetToolTip(this.passwordTextBox, "Введите пароль для входа");
            this.passwordTextBox.IconRightClick += new System.EventHandler(this.PasswordTextBox_IconRightClick);
            this.passwordTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressValidate);
            // 
            // loginTextBox
            // 
            this.loginTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.loginTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(213)))), ((int)(((byte)(215)))));
            this.loginTextBox.BorderRadius = 8;
            this.loginTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.loginTextBox.DefaultText = "";
            this.loginTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.loginTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.loginTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.loginTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.loginTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(116)))), ((int)(((byte)(144)))));
            this.loginTextBox.Font = new System.Drawing.Font("Arial", 14F);
            this.loginTextBox.ForeColor = System.Drawing.Color.Black;
            this.loginTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(116)))), ((int)(((byte)(144)))));
            this.loginTextBox.IconLeft = ((System.Drawing.Image)(resources.GetObject("loginTextBox.IconLeft")));
            this.loginTextBox.IconLeftOffset = new System.Drawing.Point(6, 0);
            this.loginTextBox.IconLeftSize = new System.Drawing.Size(30, 30);
            this.loginTextBox.Location = new System.Drawing.Point(47, 124);
            this.loginTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.loginTextBox.MaxLength = 32;
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.PasswordChar = '\0';
            this.loginTextBox.PlaceholderText = "88005553535 или example@mail.ru";
            this.loginTextBox.SelectedText = "";
            this.loginTextBox.Size = new System.Drawing.Size(389, 51);
            this.loginTextBox.TabIndex = 87;
            this.loginTextBox.TextOffset = new System.Drawing.Point(4, 0);
            this.mainToolTip.SetToolTip(this.loginTextBox, "Введите логин для входа");
            this.loginTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressValidate);
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
            this.helperButton.TabIndex = 103;
            this.mainToolTip.SetToolTip(this.helperButton, "Открыть руководство пользователя");
            this.helperButton.Click += new System.EventHandler(this.helperButton_Click);
            // 
            // myMessageBoxGoodAuth
            // 
            this.myMessageBoxGoodAuth.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
            this.myMessageBoxGoodAuth.Caption = "Авторизация";
            this.myMessageBoxGoodAuth.Icon = Guna.UI2.WinForms.MessageDialogIcon.Information;
            this.myMessageBoxGoodAuth.Parent = null;
            this.myMessageBoxGoodAuth.Style = Guna.UI2.WinForms.MessageDialogStyle.Dark;
            this.myMessageBoxGoodAuth.Text = null;
            // 
            // myMessageBoxWarning
            // 
            this.myMessageBoxWarning.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
            this.myMessageBoxWarning.Caption = "Авторизация";
            this.myMessageBoxWarning.Icon = Guna.UI2.WinForms.MessageDialogIcon.Warning;
            this.myMessageBoxWarning.Parent = null;
            this.myMessageBoxWarning.Style = Guna.UI2.WinForms.MessageDialogStyle.Dark;
            this.myMessageBoxWarning.Text = null;
            // 
            // myMessageBoxError
            // 
            this.myMessageBoxError.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
            this.myMessageBoxError.Caption = "Авторизация";
            this.myMessageBoxError.Icon = Guna.UI2.WinForms.MessageDialogIcon.Error;
            this.myMessageBoxError.Parent = null;
            this.myMessageBoxError.Style = Guna.UI2.WinForms.MessageDialogStyle.Dark;
            this.myMessageBoxError.Text = null;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(66, 205);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 19);
            this.label1.TabIndex = 89;
            this.label1.Text = "Пароль";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(66, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(228, 19);
            this.label2.TabIndex = 86;
            this.label2.Text = "Номер телефона или почта";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(116)))), ((int)(((byte)(144)))));
            this.panel1.Controls.Add(this.goToCloseForm);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(493, 35);
            this.panel1.TabIndex = 91;
            // 
            // MainCheckBox
            // 
            this.MainCheckBox.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(116)))), ((int)(((byte)(144)))));
            this.MainCheckBox.CheckedState.BorderRadius = 2;
            this.MainCheckBox.CheckedState.BorderThickness = 0;
            this.MainCheckBox.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(116)))), ((int)(((byte)(144)))));
            this.MainCheckBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MainCheckBox.Location = new System.Drawing.Point(70, 304);
            this.MainCheckBox.Name = "MainCheckBox";
            this.MainCheckBox.Size = new System.Drawing.Size(24, 24);
            this.MainCheckBox.TabIndex = 84;
            this.mainToolTip.SetToolTip(this.MainCheckBox, "Запомнить меня после выхода из приложения");
            this.MainCheckBox.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(48)))), ((int)(((byte)(100)))));
            this.MainCheckBox.UncheckedState.BorderRadius = 2;
            this.MainCheckBox.UncheckedState.BorderThickness = 1;
            this.MainCheckBox.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label3.Location = new System.Drawing.Point(96, 306);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 20);
            this.label3.TabIndex = 85;
            this.label3.Text = "Запомнить меня";
            this.mainToolTip.SetToolTip(this.label3, "Запомнить меня после выхода из приложения");
            this.label3.Click += new System.EventHandler(this.CheckBox_Click);
            // 
            // AuthForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.ClientSize = new System.Drawing.Size(493, 542);
            this.Controls.Add(this.helperButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.goToLogIn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.loginTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.MainCheckBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AuthForm";
            this.ShowInTaskbar = false;
            this.Text = "AuthForm";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2HtmlToolTip mainToolTip;
        private Guna.UI2.WinForms.Guna2MessageDialog myMessageBoxGoodAuth;
        private Guna.UI2.WinForms.Guna2MessageDialog myMessageBoxWarning;
        private Guna.UI2.WinForms.Guna2MessageDialog myMessageBoxError;
        private Guna.UI2.WinForms.Guna2Button goToLogIn;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox passwordTextBox;
        private Guna.UI2.WinForms.Guna2TextBox loginTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button goToCloseForm;
        private Guna.UI2.WinForms.Guna2ImageButton helperButton;
        private Guna.UI2.WinForms.Guna2CustomCheckBox MainCheckBox;
        private System.Windows.Forms.Label label3;
    }
}