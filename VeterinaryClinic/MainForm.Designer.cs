
namespace VeterinaryClinic
{
    sealed partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.goToSettings = new Guna.UI2.WinForms.Guna2Button();
            this.goToLogOut = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.myNameLabel = new System.Windows.Forms.Label();
            this.goToAuth = new Guna.UI2.WinForms.Guna2Button();
            this.goToReg = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.goDataPage = new Guna.UI2.WinForms.Guna2Button();
            this.goHeadPage = new Guna.UI2.WinForms.Guna2Button();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.formPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.helperButton = new Guna.UI2.WinForms.Guna2ImageButton();
            this.headerPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.goToResizeApp = new Guna.UI2.WinForms.Guna2Button();
            this.goToMinimizedApp = new Guna.UI2.WinForms.Guna2Button();
            this.goToCloseApp = new Guna.UI2.WinForms.Guna2Button();
            this.mainToolTip = new Guna.UI2.WinForms.Guna2HtmlToolTip();
            this.menuPanel.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.formPanel.SuspendLayout();
            this.headerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuPanel
            // 
            this.menuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(116)))), ((int)(((byte)(144)))));
            this.menuPanel.Controls.Add(this.goToSettings);
            this.menuPanel.Controls.Add(this.goToLogOut);
            this.menuPanel.Controls.Add(this.guna2Panel1);
            this.menuPanel.Controls.Add(this.goToAuth);
            this.menuPanel.Controls.Add(this.goToReg);
            this.menuPanel.Controls.Add(this.guna2Button1);
            this.menuPanel.Controls.Add(this.guna2Button2);
            this.menuPanel.Controls.Add(this.goDataPage);
            this.menuPanel.Controls.Add(this.goHeadPage);
            this.menuPanel.Controls.Add(this.guna2PictureBox1);
            this.menuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuPanel.Location = new System.Drawing.Point(0, 0);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Padding = new System.Windows.Forms.Padding(12);
            this.menuPanel.Size = new System.Drawing.Size(220, 768);
            this.menuPanel.TabIndex = 1;
            this.menuPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.MenuPanel_Paint);
            // 
            // goToSettings
            // 
            this.goToSettings.Animated = true;
            this.goToSettings.BorderRadius = 12;
            this.goToSettings.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.goToSettings.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(94)))), ((int)(((byte)(117)))));
            this.goToSettings.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.goToSettings.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.goToSettings.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.goToSettings.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.goToSettings.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.goToSettings.FillColor = System.Drawing.Color.Transparent;
            this.goToSettings.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.goToSettings.ForeColor = System.Drawing.Color.White;
            this.goToSettings.ImageOffset = new System.Drawing.Point(-10, 0);
            this.goToSettings.Location = new System.Drawing.Point(12, 493);
            this.goToSettings.Name = "goToSettings";
            this.goToSettings.Size = new System.Drawing.Size(196, 45);
            this.goToSettings.TabIndex = 36;
            this.goToSettings.Text = "Настройки";
            this.goToSettings.TextOffset = new System.Drawing.Point(0, -1);
            this.mainToolTip.SetToolTip(this.goToSettings, "Переход на страницу настройек");
            this.goToSettings.Click += new System.EventHandler(this.goToSettings_Click);
            // 
            // goToLogOut
            // 
            this.goToLogOut.Animated = true;
            this.goToLogOut.BorderRadius = 12;
            this.goToLogOut.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.goToLogOut.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(94)))), ((int)(((byte)(117)))));
            this.goToLogOut.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.goToLogOut.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.goToLogOut.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.goToLogOut.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.goToLogOut.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.goToLogOut.FillColor = System.Drawing.Color.Transparent;
            this.goToLogOut.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.goToLogOut.ForeColor = System.Drawing.Color.White;
            this.goToLogOut.ImageOffset = new System.Drawing.Point(-10, 0);
            this.goToLogOut.Location = new System.Drawing.Point(12, 538);
            this.goToLogOut.Name = "goToLogOut";
            this.goToLogOut.Size = new System.Drawing.Size(196, 45);
            this.goToLogOut.TabIndex = 35;
            this.goToLogOut.Text = "Выйти";
            this.goToLogOut.TextOffset = new System.Drawing.Point(0, -1);
            this.mainToolTip.SetToolTip(this.goToLogOut, "Выйти из системы");
            this.goToLogOut.Visible = false;
            this.goToLogOut.Click += new System.EventHandler(this.goToLogOut_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.myNameLabel);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.guna2Panel1.Location = new System.Drawing.Point(12, 583);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(196, 83);
            this.guna2Panel1.TabIndex = 34;
            this.guna2Panel1.Visible = false;
            // 
            // myNameLabel
            // 
            this.myNameLabel.AutoSize = true;
            this.myNameLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.myNameLabel.ForeColor = System.Drawing.Color.White;
            this.myNameLabel.Location = new System.Drawing.Point(43, 19);
            this.myNameLabel.Name = "myNameLabel";
            this.myNameLabel.Size = new System.Drawing.Size(54, 19);
            this.myNameLabel.TabIndex = 0;
            this.myNameLabel.Text = "label1";
            // 
            // goToAuth
            // 
            this.goToAuth.Animated = true;
            this.goToAuth.BorderRadius = 12;
            this.goToAuth.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.goToAuth.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(94)))), ((int)(((byte)(117)))));
            this.goToAuth.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.goToAuth.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.goToAuth.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.goToAuth.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.goToAuth.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.goToAuth.FillColor = System.Drawing.Color.Transparent;
            this.goToAuth.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.goToAuth.ForeColor = System.Drawing.Color.White;
            this.goToAuth.ImageOffset = new System.Drawing.Point(-10, 0);
            this.goToAuth.Location = new System.Drawing.Point(12, 666);
            this.goToAuth.Name = "goToAuth";
            this.goToAuth.Size = new System.Drawing.Size(196, 45);
            this.goToAuth.TabIndex = 33;
            this.goToAuth.Text = "Авторизоваться";
            this.goToAuth.TextOffset = new System.Drawing.Point(0, -1);
            this.mainToolTip.SetToolTip(this.goToAuth, "Переход на авторизацию в системе");
            this.goToAuth.Click += new System.EventHandler(this.GoToAuth_Click);
            // 
            // goToReg
            // 
            this.goToReg.Animated = true;
            this.goToReg.BorderRadius = 12;
            this.goToReg.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.goToReg.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(94)))), ((int)(((byte)(117)))));
            this.goToReg.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.goToReg.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.goToReg.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.goToReg.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.goToReg.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.goToReg.FillColor = System.Drawing.Color.Transparent;
            this.goToReg.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.goToReg.ForeColor = System.Drawing.Color.White;
            this.goToReg.ImageOffset = new System.Drawing.Point(-10, 0);
            this.goToReg.Location = new System.Drawing.Point(12, 711);
            this.goToReg.Name = "goToReg";
            this.goToReg.Size = new System.Drawing.Size(196, 45);
            this.goToReg.TabIndex = 32;
            this.goToReg.Text = "Регистрация";
            this.goToReg.TextOffset = new System.Drawing.Point(0, -1);
            this.mainToolTip.SetToolTip(this.goToReg, "Переход на регистрацию в системе");
            // 
            // guna2Button1
            // 
            this.guna2Button1.Animated = true;
            this.guna2Button1.BorderRadius = 12;
            this.guna2Button1.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.guna2Button1.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(94)))), ((int)(((byte)(117)))));
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Button1.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.ImageOffset = new System.Drawing.Point(-10, 0);
            this.guna2Button1.ImageSize = new System.Drawing.Size(25, 25);
            this.guna2Button1.Location = new System.Drawing.Point(12, 261);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(196, 45);
            this.guna2Button1.TabIndex = 28;
            this.guna2Button1.Text = "Профиль";
            this.mainToolTip.SetToolTip(this.guna2Button1, "Переход на страницу своего профиля");
            // 
            // guna2Button2
            // 
            this.guna2Button2.Animated = true;
            this.guna2Button2.BorderRadius = 12;
            this.guna2Button2.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.guna2Button2.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(94)))), ((int)(((byte)(117)))));
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Button2.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.Location = new System.Drawing.Point(12, 216);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Size = new System.Drawing.Size(196, 45);
            this.guna2Button2.TabIndex = 27;
            this.guna2Button2.Text = "Услуги";
            this.mainToolTip.SetToolTip(this.guna2Button2, "Переход на страницу услуг");
            // 
            // goDataPage
            // 
            this.goDataPage.Animated = true;
            this.goDataPage.BorderRadius = 12;
            this.goDataPage.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.goDataPage.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(94)))), ((int)(((byte)(117)))));
            this.goDataPage.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.goDataPage.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.goDataPage.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.goDataPage.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.goDataPage.Dock = System.Windows.Forms.DockStyle.Top;
            this.goDataPage.FillColor = System.Drawing.Color.Transparent;
            this.goDataPage.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.goDataPage.ForeColor = System.Drawing.Color.White;
            this.goDataPage.Location = new System.Drawing.Point(12, 171);
            this.goDataPage.Name = "goDataPage";
            this.goDataPage.Size = new System.Drawing.Size(196, 45);
            this.goDataPage.TabIndex = 21;
            this.goDataPage.Text = "Данные";
            this.mainToolTip.SetToolTip(this.goDataPage, "Переход на страницу данных");
            this.goDataPage.Click += new System.EventHandler(this.GoDataPage_Click);
            // 
            // goHeadPage
            // 
            this.goHeadPage.Animated = true;
            this.goHeadPage.BorderRadius = 12;
            this.goHeadPage.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.goHeadPage.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(94)))), ((int)(((byte)(117)))));
            this.goHeadPage.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.goHeadPage.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.goHeadPage.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.goHeadPage.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.goHeadPage.Dock = System.Windows.Forms.DockStyle.Top;
            this.goHeadPage.FillColor = System.Drawing.Color.Transparent;
            this.goHeadPage.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.goHeadPage.ForeColor = System.Drawing.Color.White;
            this.goHeadPage.ImageOffset = new System.Drawing.Point(-10, 0);
            this.goHeadPage.ImageSize = new System.Drawing.Size(25, 25);
            this.goHeadPage.Location = new System.Drawing.Point(12, 126);
            this.goHeadPage.Name = "goHeadPage";
            this.goHeadPage.Size = new System.Drawing.Size(196, 45);
            this.goHeadPage.TabIndex = 20;
            this.goHeadPage.Text = "Главная";
            this.mainToolTip.SetToolTip(this.goHeadPage, "Переход на главную страницу");
            this.goHeadPage.Click += new System.EventHandler(this.GoHeadPage_Click);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2PictureBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(12, 12);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(196, 114);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 19;
            this.guna2PictureBox1.TabStop = false;
            // 
            // formPanel
            // 
            this.formPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.formPanel.Controls.Add(this.helperButton);
            this.formPanel.Controls.Add(this.headerPanel);
            this.formPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.formPanel.Location = new System.Drawing.Point(220, 0);
            this.formPanel.Name = "formPanel";
            this.formPanel.Size = new System.Drawing.Size(1008, 768);
            this.formPanel.TabIndex = 2;
            this.formPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.FormPanel_Paint);
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
            this.helperButton.Location = new System.Drawing.Point(945, 705);
            this.helperButton.Name = "helperButton";
            this.helperButton.PressedState.ImageSize = new System.Drawing.Size(42, 42);
            this.helperButton.Size = new System.Drawing.Size(60, 60);
            this.helperButton.TabIndex = 27;
            this.mainToolTip.SetToolTip(this.helperButton, "Открыть руководство по данной странице");
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.headerPanel.Controls.Add(this.goToResizeApp);
            this.headerPanel.Controls.Add(this.goToMinimizedApp);
            this.headerPanel.Controls.Add(this.goToCloseApp);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(1008, 35);
            this.headerPanel.TabIndex = 26;
            this.headerPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.headerPanel_MouseDown);
            this.headerPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.headerPanel_MouseMove);
            // 
            // goToResizeApp
            // 
            this.goToResizeApp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.goToResizeApp.Animated = true;
            this.goToResizeApp.BackColor = System.Drawing.Color.Transparent;
            this.goToResizeApp.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            this.goToResizeApp.CheckedState.FillColor = System.Drawing.Color.Transparent;
            this.goToResizeApp.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.goToResizeApp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.goToResizeApp.FillColor = System.Drawing.Color.Transparent;
            this.goToResizeApp.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.goToResizeApp.ForeColor = System.Drawing.Color.White;
            this.goToResizeApp.Image = ((System.Drawing.Image)(resources.GetObject("goToResizeApp.Image")));
            this.goToResizeApp.ImageOffset = new System.Drawing.Point(1, 0);
            this.goToResizeApp.ImageSize = new System.Drawing.Size(25, 25);
            this.goToResizeApp.Location = new System.Drawing.Point(908, 0);
            this.goToResizeApp.Margin = new System.Windows.Forms.Padding(0);
            this.goToResizeApp.Name = "goToResizeApp";
            this.goToResizeApp.Size = new System.Drawing.Size(50, 35);
            this.goToResizeApp.TabIndex = 24;
            this.mainToolTip.SetToolTip(this.goToResizeApp, "Развернуть/Восстановить");
            this.goToResizeApp.Click += new System.EventHandler(this.GoToResizeApp_Click);
            // 
            // goToMinimizedApp
            // 
            this.goToMinimizedApp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.goToMinimizedApp.Animated = true;
            this.goToMinimizedApp.BackColor = System.Drawing.Color.Transparent;
            this.goToMinimizedApp.CheckedState.FillColor = System.Drawing.Color.Transparent;
            this.goToMinimizedApp.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            this.goToMinimizedApp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.goToMinimizedApp.FillColor = System.Drawing.Color.Transparent;
            this.goToMinimizedApp.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.goToMinimizedApp.ForeColor = System.Drawing.Color.White;
            this.goToMinimizedApp.Image = ((System.Drawing.Image)(resources.GetObject("goToMinimizedApp.Image")));
            this.goToMinimizedApp.ImageOffset = new System.Drawing.Point(1, 0);
            this.goToMinimizedApp.ImageSize = new System.Drawing.Size(25, 25);
            this.goToMinimizedApp.Location = new System.Drawing.Point(858, 0);
            this.goToMinimizedApp.Margin = new System.Windows.Forms.Padding(0);
            this.goToMinimizedApp.Name = "goToMinimizedApp";
            this.goToMinimizedApp.Size = new System.Drawing.Size(50, 35);
            this.goToMinimizedApp.TabIndex = 25;
            this.mainToolTip.SetToolTip(this.goToMinimizedApp, "Свернуть");
            this.goToMinimizedApp.Click += new System.EventHandler(this.GoToMinimizedApp_Click);
            // 
            // goToCloseApp
            // 
            this.goToCloseApp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.goToCloseApp.Animated = true;
            this.goToCloseApp.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(94)))), ((int)(((byte)(117)))));
            this.goToCloseApp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.goToCloseApp.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.goToCloseApp.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.goToCloseApp.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.goToCloseApp.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.goToCloseApp.FillColor = System.Drawing.Color.Transparent;
            this.goToCloseApp.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.goToCloseApp.ForeColor = System.Drawing.Color.White;
            this.goToCloseApp.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(81)))), ((int)(((byte)(93)))));
            this.goToCloseApp.Image = ((System.Drawing.Image)(resources.GetObject("goToCloseApp.Image")));
            this.goToCloseApp.ImageOffset = new System.Drawing.Point(1, 0);
            this.goToCloseApp.ImageSize = new System.Drawing.Size(25, 25);
            this.goToCloseApp.Location = new System.Drawing.Point(958, 0);
            this.goToCloseApp.Margin = new System.Windows.Forms.Padding(0);
            this.goToCloseApp.Name = "goToCloseApp";
            this.goToCloseApp.Size = new System.Drawing.Size(50, 35);
            this.goToCloseApp.TabIndex = 23;
            this.mainToolTip.SetToolTip(this.goToCloseApp, "Закрыть");
            this.goToCloseApp.Click += new System.EventHandler(this.GoToCloseApp_Click);
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1228, 768);
            this.Controls.Add(this.formPanel);
            this.Controls.Add(this.menuPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1024, 768);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Петан - Главная";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuPanel.ResumeLayout(false);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.formPanel.ResumeLayout(false);
            this.headerPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel menuPanel;
        private Guna.UI2.WinForms.Guna2Panel formPanel;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2HtmlToolTip mainToolTip;
        private Guna.UI2.WinForms.Guna2Button goToCloseApp;
        private Guna.UI2.WinForms.Guna2Button goToResizeApp;
        private Guna.UI2.WinForms.Guna2Button goToMinimizedApp;
        private Guna.UI2.WinForms.Guna2Panel headerPanel;
        private Guna.UI2.WinForms.Guna2ImageButton helperButton;
        internal Guna.UI2.WinForms.Guna2Button goHeadPage;
        internal Guna.UI2.WinForms.Guna2Button goDataPage;
        internal Guna.UI2.WinForms.Guna2Button guna2Button1;
        internal Guna.UI2.WinForms.Guna2Button guna2Button2;
        internal Guna.UI2.WinForms.Guna2Button goToLogOut;
        internal Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        internal Guna.UI2.WinForms.Guna2Button goToReg;
        internal Guna.UI2.WinForms.Guna2Button goToSettings;
        internal System.Windows.Forms.Label myNameLabel;
        internal Guna.UI2.WinForms.Guna2Button goToAuth;
    }
}

