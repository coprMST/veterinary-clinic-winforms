
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
            this.goToCreateMeeting = new Guna.UI2.WinForms.Guna2Button();
            this.goToSettingsPage = new Guna.UI2.WinForms.Guna2Button();
            this.goToLogOut = new Guna.UI2.WinForms.Guna2Button();
            this.userPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.myNameLabel = new System.Windows.Forms.Label();
            this.goToAuthPage = new Guna.UI2.WinForms.Guna2Button();
            this.goToSerivcesPage = new Guna.UI2.WinForms.Guna2Button();
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
            this.userPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.formPanel.SuspendLayout();
            this.headerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuPanel
            // 
            this.menuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(116)))), ((int)(((byte)(144)))));
            this.menuPanel.Controls.Add(this.goToCreateMeeting);
            this.menuPanel.Controls.Add(this.goToSettingsPage);
            this.menuPanel.Controls.Add(this.goToLogOut);
            this.menuPanel.Controls.Add(this.userPanel);
            this.menuPanel.Controls.Add(this.goToAuthPage);
            this.menuPanel.Controls.Add(this.goToSerivcesPage);
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
            // goToCreateMeeting
            // 
            this.goToCreateMeeting.Animated = true;
            this.goToCreateMeeting.BorderRadius = 12;
            this.goToCreateMeeting.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.goToCreateMeeting.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(94)))), ((int)(((byte)(117)))));
            this.goToCreateMeeting.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.goToCreateMeeting.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.goToCreateMeeting.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.goToCreateMeeting.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.goToCreateMeeting.Dock = System.Windows.Forms.DockStyle.Top;
            this.goToCreateMeeting.FillColor = System.Drawing.Color.Transparent;
            this.goToCreateMeeting.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.goToCreateMeeting.ForeColor = System.Drawing.Color.White;
            this.goToCreateMeeting.Location = new System.Drawing.Point(12, 261);
            this.goToCreateMeeting.Name = "goToCreateMeeting";
            this.goToCreateMeeting.Size = new System.Drawing.Size(196, 45);
            this.goToCreateMeeting.TabIndex = 37;
            this.goToCreateMeeting.Text = "Запись";
            this.mainToolTip.SetToolTip(this.goToCreateMeeting, "Переход на страницу данных");
            this.goToCreateMeeting.Visible = false;
            this.goToCreateMeeting.Click += new System.EventHandler(this.goToCreateMeeting_Click);
            // 
            // goToSettingsPage
            // 
            this.goToSettingsPage.BorderRadius = 12;
            this.goToSettingsPage.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(94)))), ((int)(((byte)(117)))));
            this.goToSettingsPage.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.goToSettingsPage.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.goToSettingsPage.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.goToSettingsPage.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.goToSettingsPage.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.goToSettingsPage.FillColor = System.Drawing.Color.Transparent;
            this.goToSettingsPage.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.goToSettingsPage.ForeColor = System.Drawing.Color.White;
            this.goToSettingsPage.ImageOffset = new System.Drawing.Point(-10, 0);
            this.goToSettingsPage.Location = new System.Drawing.Point(12, 538);
            this.goToSettingsPage.Name = "goToSettingsPage";
            this.goToSettingsPage.Size = new System.Drawing.Size(196, 45);
            this.goToSettingsPage.TabIndex = 36;
            this.goToSettingsPage.Text = "Настройки";
            this.goToSettingsPage.TextOffset = new System.Drawing.Point(0, -1);
            this.mainToolTip.SetToolTip(this.goToSettingsPage, "Переход на страницу настройек");
            this.goToSettingsPage.Click += new System.EventHandler(this.goToSettings_Click);
            // 
            // goToLogOut
            // 
            this.goToLogOut.BorderRadius = 12;
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
            this.goToLogOut.Location = new System.Drawing.Point(12, 583);
            this.goToLogOut.Name = "goToLogOut";
            this.goToLogOut.Size = new System.Drawing.Size(196, 45);
            this.goToLogOut.TabIndex = 35;
            this.goToLogOut.Text = "Выйти";
            this.goToLogOut.TextOffset = new System.Drawing.Point(0, -1);
            this.mainToolTip.SetToolTip(this.goToLogOut, "Выйти из системы");
            this.goToLogOut.Visible = false;
            this.goToLogOut.Click += new System.EventHandler(this.goToLogOut_Click);
            // 
            // userPanel
            // 
            this.userPanel.Controls.Add(this.label1);
            this.userPanel.Controls.Add(this.guna2CirclePictureBox1);
            this.userPanel.Controls.Add(this.myNameLabel);
            this.userPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.userPanel.Location = new System.Drawing.Point(12, 628);
            this.userPanel.Name = "userPanel";
            this.userPanel.Size = new System.Drawing.Size(196, 83);
            this.userPanel.TabIndex = 34;
            this.userPanel.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(44, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 19);
            this.label1.TabIndex = 38;
            this.label1.Text = "Здравствуйте,";
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2CirclePictureBox1.Image")));
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(3, 18);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(40, 40);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2CirclePictureBox1.TabIndex = 37;
            this.guna2CirclePictureBox1.TabStop = false;
            // 
            // myNameLabel
            // 
            this.myNameLabel.AutoSize = true;
            this.myNameLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.myNameLabel.ForeColor = System.Drawing.Color.White;
            this.myNameLabel.Location = new System.Drawing.Point(44, 38);
            this.myNameLabel.Name = "myNameLabel";
            this.myNameLabel.Size = new System.Drawing.Size(118, 19);
            this.myNameLabel.TabIndex = 0;
            this.myNameLabel.Text = "myNameLabel";
            // 
            // goToAuthPage
            // 
            this.goToAuthPage.BorderRadius = 12;
            this.goToAuthPage.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(94)))), ((int)(((byte)(117)))));
            this.goToAuthPage.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.goToAuthPage.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.goToAuthPage.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.goToAuthPage.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.goToAuthPage.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.goToAuthPage.FillColor = System.Drawing.Color.Transparent;
            this.goToAuthPage.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.goToAuthPage.ForeColor = System.Drawing.Color.White;
            this.goToAuthPage.ImageOffset = new System.Drawing.Point(-10, 0);
            this.goToAuthPage.Location = new System.Drawing.Point(12, 711);
            this.goToAuthPage.Name = "goToAuthPage";
            this.goToAuthPage.Size = new System.Drawing.Size(196, 45);
            this.goToAuthPage.TabIndex = 33;
            this.goToAuthPage.Text = "Авторизоваться";
            this.goToAuthPage.TextOffset = new System.Drawing.Point(0, -1);
            this.mainToolTip.SetToolTip(this.goToAuthPage, "Переход на авторизацию в системе");
            this.goToAuthPage.Click += new System.EventHandler(this.GoToAuth_Click);
            // 
            // goToSerivcesPage
            // 
            this.goToSerivcesPage.Animated = true;
            this.goToSerivcesPage.BorderRadius = 12;
            this.goToSerivcesPage.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.goToSerivcesPage.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(94)))), ((int)(((byte)(117)))));
            this.goToSerivcesPage.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.goToSerivcesPage.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.goToSerivcesPage.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.goToSerivcesPage.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.goToSerivcesPage.Dock = System.Windows.Forms.DockStyle.Top;
            this.goToSerivcesPage.FillColor = System.Drawing.Color.Transparent;
            this.goToSerivcesPage.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.goToSerivcesPage.ForeColor = System.Drawing.Color.White;
            this.goToSerivcesPage.Location = new System.Drawing.Point(12, 216);
            this.goToSerivcesPage.Name = "goToSerivcesPage";
            this.goToSerivcesPage.Size = new System.Drawing.Size(196, 45);
            this.goToSerivcesPage.TabIndex = 27;
            this.goToSerivcesPage.Text = "Услуги";
            this.mainToolTip.SetToolTip(this.goToSerivcesPage, "Переход на страницу услуг");
            this.goToSerivcesPage.Click += new System.EventHandler(this.goToSerivcesPage_Click);
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
            this.goDataPage.Visible = false;
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
            this.helperButton.Location = new System.Drawing.Point(948, 708);
            this.helperButton.Name = "helperButton";
            this.helperButton.PressedState.ImageSize = new System.Drawing.Size(42, 42);
            this.helperButton.Size = new System.Drawing.Size(60, 60);
            this.helperButton.TabIndex = 27;
            this.mainToolTip.SetToolTip(this.helperButton, "Открыть руководство пользователя");
            this.helperButton.Click += new System.EventHandler(this.HelperButton_Click);
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
            this.userPanel.ResumeLayout(false);
            this.userPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
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
        internal Guna.UI2.WinForms.Guna2Button goToSerivcesPage;
        internal Guna.UI2.WinForms.Guna2Button goToLogOut;
        internal Guna.UI2.WinForms.Guna2Panel userPanel;
        internal Guna.UI2.WinForms.Guna2Button goToSettingsPage;
        internal System.Windows.Forms.Label myNameLabel;
        internal Guna.UI2.WinForms.Guna2Button goToAuthPage;
        internal System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        internal Guna.UI2.WinForms.Guna2Button goToCreateMeeting;
    }
}

