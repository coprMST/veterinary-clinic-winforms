
namespace VeterinaryClinic.Forms
{
    partial class MyPetsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyPetsForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label3 = new System.Windows.Forms.Label();
            this.goToClearSeacher = new Guna.UI2.WinForms.Guna2Button();
            this.rightWarp = new Guna.UI2.WinForms.Guna2ImageButton();
            this.goToSearch = new Guna.UI2.WinForms.Guna2Button();
            this.doubleRightWarp = new Guna.UI2.WinForms.Guna2ImageButton();
            this.amountPagesComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.leftWarp = new Guna.UI2.WinForms.Guna2ImageButton();
            this.doubleLeftWarp = new Guna.UI2.WinForms.Guna2ImageButton();
            this.seacher = new Guna.UI2.WinForms.Guna2TextBox();
            this.mainTable = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goToDelete = new Guna.UI2.WinForms.Guna2Button();
            this.goToEdit = new Guna.UI2.WinForms.Guna2Button();
            this.goToAdd = new Guna.UI2.WinForms.Guna2Button();
            this.myMessageBoxError = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.myMessageBoxInfo = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.errorLabel = new System.Windows.Forms.Label();
            this.zeroRowsLabel = new System.Windows.Forms.Label();
            this.seeLabel = new System.Windows.Forms.Label();
            this.countRowsLabel = new System.Windows.Forms.Label();
            this.myMessageBoxQuestion = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mainTable)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(28, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(228, 22);
            this.label3.TabIndex = 66;
            this.label3.Text = "Раздел моих питомцев";
            // 
            // goToClearSeacher
            // 
            this.goToClearSeacher.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.goToClearSeacher.Animated = true;
            this.goToClearSeacher.BackColor = System.Drawing.Color.Transparent;
            this.goToClearSeacher.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(213)))), ((int)(((byte)(215)))));
            this.goToClearSeacher.BorderRadius = 8;
            this.goToClearSeacher.BorderThickness = 1;
            this.goToClearSeacher.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.goToClearSeacher.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.goToClearSeacher.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.goToClearSeacher.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.goToClearSeacher.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(238)))));
            this.goToClearSeacher.Font = new System.Drawing.Font("Arial", 12F);
            this.goToClearSeacher.ForeColor = System.Drawing.Color.Black;
            this.goToClearSeacher.HoverState.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.goToClearSeacher.Location = new System.Drawing.Point(821, 68);
            this.goToClearSeacher.Margin = new System.Windows.Forms.Padding(0);
            this.goToClearSeacher.Name = "goToClearSeacher";
            this.goToClearSeacher.Size = new System.Drawing.Size(138, 40);
            this.goToClearSeacher.TabIndex = 125;
            this.goToClearSeacher.Text = "Очистить";
            this.goToClearSeacher.Click += new System.EventHandler(this.goToClearSeacher_Click);
            // 
            // rightWarp
            // 
            this.rightWarp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rightWarp.BackColor = System.Drawing.Color.Transparent;
            this.rightWarp.CheckedState.ImageSize = new System.Drawing.Size(42, 42);
            this.rightWarp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rightWarp.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.rightWarp.HoverState.ImageSize = new System.Drawing.Size(42, 42);
            this.rightWarp.Image = ((System.Drawing.Image)(resources.GetObject("rightWarp.Image")));
            this.rightWarp.ImageOffset = new System.Drawing.Point(0, 0);
            this.rightWarp.ImageRotate = 0F;
            this.rightWarp.ImageSize = new System.Drawing.Size(42, 42);
            this.rightWarp.Location = new System.Drawing.Point(451, 604);
            this.rightWarp.Margin = new System.Windows.Forms.Padding(0);
            this.rightWarp.Name = "rightWarp";
            this.rightWarp.PressedState.ImageSize = new System.Drawing.Size(42, 42);
            this.rightWarp.Size = new System.Drawing.Size(35, 35);
            this.rightWarp.TabIndex = 124;
            this.rightWarp.Click += new System.EventHandler(this.UpdateMove);
            // 
            // goToSearch
            // 
            this.goToSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.goToSearch.Animated = true;
            this.goToSearch.BackColor = System.Drawing.Color.Transparent;
            this.goToSearch.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(213)))), ((int)(((byte)(215)))));
            this.goToSearch.BorderRadius = 8;
            this.goToSearch.BorderThickness = 1;
            this.goToSearch.CustomizableEdges.BottomLeft = false;
            this.goToSearch.CustomizableEdges.TopLeft = false;
            this.goToSearch.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.goToSearch.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.goToSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.goToSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.goToSearch.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(238)))));
            this.goToSearch.Font = new System.Drawing.Font("Arial", 12F);
            this.goToSearch.ForeColor = System.Drawing.Color.Black;
            this.goToSearch.HoverState.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.goToSearch.Location = new System.Drawing.Point(653, 68);
            this.goToSearch.Margin = new System.Windows.Forms.Padding(0);
            this.goToSearch.Name = "goToSearch";
            this.goToSearch.Size = new System.Drawing.Size(93, 40);
            this.goToSearch.TabIndex = 123;
            this.goToSearch.Text = "Найти";
            this.goToSearch.Click += new System.EventHandler(this.GoToSearch_Click);
            // 
            // doubleRightWarp
            // 
            this.doubleRightWarp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.doubleRightWarp.BackColor = System.Drawing.Color.Transparent;
            this.doubleRightWarp.CheckedState.ImageSize = new System.Drawing.Size(42, 42);
            this.doubleRightWarp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.doubleRightWarp.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            this.doubleRightWarp.HoverState.ImageSize = new System.Drawing.Size(42, 42);
            this.doubleRightWarp.Image = ((System.Drawing.Image)(resources.GetObject("doubleRightWarp.Image")));
            this.doubleRightWarp.ImageOffset = new System.Drawing.Point(0, 0);
            this.doubleRightWarp.ImageRotate = 0F;
            this.doubleRightWarp.ImageSize = new System.Drawing.Size(42, 42);
            this.doubleRightWarp.Location = new System.Drawing.Point(486, 604);
            this.doubleRightWarp.Margin = new System.Windows.Forms.Padding(0);
            this.doubleRightWarp.Name = "doubleRightWarp";
            this.doubleRightWarp.PressedState.ImageSize = new System.Drawing.Size(42, 42);
            this.doubleRightWarp.Size = new System.Drawing.Size(35, 35);
            this.doubleRightWarp.TabIndex = 122;
            this.doubleRightWarp.Click += new System.EventHandler(this.UpdateMove);
            // 
            // amountPagesComboBox
            // 
            this.amountPagesComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.amountPagesComboBox.BackColor = System.Drawing.Color.Transparent;
            this.amountPagesComboBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.amountPagesComboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.amountPagesComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.amountPagesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.amountPagesComboBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.amountPagesComboBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(116)))), ((int)(((byte)(144)))));
            this.amountPagesComboBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(116)))), ((int)(((byte)(144)))));
            this.amountPagesComboBox.FocusedState.ForeColor = System.Drawing.Color.Black;
            this.amountPagesComboBox.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.amountPagesComboBox.ForeColor = System.Drawing.Color.Black;
            this.amountPagesComboBox.HoverState.ForeColor = System.Drawing.Color.Black;
            this.amountPagesComboBox.ItemHeight = 30;
            this.amountPagesComboBox.Items.AddRange(new object[] {
            "1"});
            this.amountPagesComboBox.ItemsAppearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.amountPagesComboBox.ItemsAppearance.ForeColor = System.Drawing.Color.Black;
            this.amountPagesComboBox.ItemsAppearance.SelectedFont = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.amountPagesComboBox.ItemsAppearance.SelectedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(116)))), ((int)(((byte)(144)))));
            this.amountPagesComboBox.Location = new System.Drawing.Point(357, 603);
            this.amountPagesComboBox.Margin = new System.Windows.Forms.Padding(0);
            this.amountPagesComboBox.Name = "amountPagesComboBox";
            this.amountPagesComboBox.Size = new System.Drawing.Size(94, 36);
            this.amountPagesComboBox.StartIndex = 0;
            this.amountPagesComboBox.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.amountPagesComboBox.TabIndex = 121;
            this.amountPagesComboBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.amountPagesComboBox.SelectedIndexChanged += new System.EventHandler(this.AmountPagesComboBox_SelectedIndexChanged);
            // 
            // leftWarp
            // 
            this.leftWarp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.leftWarp.BackColor = System.Drawing.Color.Transparent;
            this.leftWarp.CheckedState.ImageSize = new System.Drawing.Size(42, 42);
            this.leftWarp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.leftWarp.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image2")));
            this.leftWarp.HoverState.ImageSize = new System.Drawing.Size(42, 42);
            this.leftWarp.Image = ((System.Drawing.Image)(resources.GetObject("leftWarp.Image")));
            this.leftWarp.ImageOffset = new System.Drawing.Point(0, 0);
            this.leftWarp.ImageRotate = 0F;
            this.leftWarp.ImageSize = new System.Drawing.Size(42, 42);
            this.leftWarp.Location = new System.Drawing.Point(322, 604);
            this.leftWarp.Margin = new System.Windows.Forms.Padding(0);
            this.leftWarp.Name = "leftWarp";
            this.leftWarp.PressedState.ImageSize = new System.Drawing.Size(42, 42);
            this.leftWarp.Size = new System.Drawing.Size(35, 35);
            this.leftWarp.TabIndex = 120;
            this.leftWarp.Click += new System.EventHandler(this.UpdateMove);
            // 
            // doubleLeftWarp
            // 
            this.doubleLeftWarp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.doubleLeftWarp.BackColor = System.Drawing.Color.Transparent;
            this.doubleLeftWarp.CheckedState.ImageSize = new System.Drawing.Size(42, 42);
            this.doubleLeftWarp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.doubleLeftWarp.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image3")));
            this.doubleLeftWarp.HoverState.ImageSize = new System.Drawing.Size(42, 42);
            this.doubleLeftWarp.Image = ((System.Drawing.Image)(resources.GetObject("doubleLeftWarp.Image")));
            this.doubleLeftWarp.ImageOffset = new System.Drawing.Point(0, 0);
            this.doubleLeftWarp.ImageRotate = 0F;
            this.doubleLeftWarp.ImageSize = new System.Drawing.Size(42, 42);
            this.doubleLeftWarp.Location = new System.Drawing.Point(287, 603);
            this.doubleLeftWarp.Margin = new System.Windows.Forms.Padding(0);
            this.doubleLeftWarp.Name = "doubleLeftWarp";
            this.doubleLeftWarp.PressedState.ImageSize = new System.Drawing.Size(42, 42);
            this.doubleLeftWarp.Size = new System.Drawing.Size(35, 35);
            this.doubleLeftWarp.TabIndex = 119;
            this.doubleLeftWarp.Click += new System.EventHandler(this.UpdateMove);
            // 
            // seacher
            // 
            this.seacher.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.seacher.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(213)))), ((int)(((byte)(215)))));
            this.seacher.BorderRadius = 8;
            this.seacher.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.seacher.CustomizableEdges.BottomRight = false;
            this.seacher.CustomizableEdges.TopRight = false;
            this.seacher.DefaultText = "";
            this.seacher.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.seacher.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.seacher.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.seacher.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.seacher.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(116)))), ((int)(((byte)(144)))));
            this.seacher.Font = new System.Drawing.Font("Arial", 14F);
            this.seacher.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(116)))), ((int)(((byte)(144)))));
            this.seacher.IconLeft = ((System.Drawing.Image)(resources.GetObject("seacher.IconLeft")));
            this.seacher.IconLeftOffset = new System.Drawing.Point(3, 0);
            this.seacher.IconLeftSize = new System.Drawing.Size(28, 28);
            this.seacher.Location = new System.Drawing.Point(22, 68);
            this.seacher.Margin = new System.Windows.Forms.Padding(0);
            this.seacher.Name = "seacher";
            this.seacher.PasswordChar = '\0';
            this.seacher.PlaceholderText = "Введите поисковый запрос для поиска записей";
            this.seacher.SelectedText = "";
            this.seacher.Size = new System.Drawing.Size(631, 40);
            this.seacher.TabIndex = 118;
            this.seacher.TextOffset = new System.Drawing.Point(-1, 0);
            this.seacher.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Seacher_KeyPress);
            // 
            // mainTable
            // 
            this.mainTable.AllowUserToAddRows = false;
            this.mainTable.AllowUserToDeleteRows = false;
            this.mainTable.AllowUserToResizeColumns = false;
            this.mainTable.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.mainTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.mainTable.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mainTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.mainTable.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.mainTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mainTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.mainTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mainTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.mainTable.ColumnHeadersHeight = 40;
            this.mainTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.mainTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column6,
            this.Column7,
            this.Column8});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(167)))), ((int)(((byte)(187)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.mainTable.DefaultCellStyle = dataGridViewCellStyle3;
            this.mainTable.EnableHeadersVisualStyles = false;
            this.mainTable.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.mainTable.Location = new System.Drawing.Point(22, 135);
            this.mainTable.MultiSelect = false;
            this.mainTable.Name = "mainTable";
            this.mainTable.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(116)))), ((int)(((byte)(144)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mainTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.mainTable.RowHeadersVisible = false;
            this.mainTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.mainTable.RowTemplate.DividerHeight = 5;
            this.mainTable.RowTemplate.Height = 40;
            this.mainTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mainTable.Size = new System.Drawing.Size(724, 447);
            this.mainTable.TabIndex = 117;
            this.mainTable.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.mainTable.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.mainTable.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.mainTable.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.mainTable.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.mainTable.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.mainTable.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.mainTable.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.mainTable.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.mainTable.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.mainTable.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.DimGray;
            this.mainTable.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.mainTable.ThemeStyle.HeaderStyle.Height = 40;
            this.mainTable.ThemeStyle.ReadOnly = true;
            this.mainTable.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.mainTable.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.mainTable.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.mainTable.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.mainTable.ThemeStyle.RowsStyle.Height = 40;
            this.mainTable.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(175)))), ((int)(((byte)(163)))));
            this.mainTable.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.mainTable.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.mainTable_CellEnter);
            // 
            // Column6
            // 
            this.Column6.FillWeight = 283.326F;
            this.Column6.HeaderText = "Категория";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.FillWeight = 7.575562F;
            this.Column7.HeaderText = "Услуга";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.FillWeight = 7.575562F;
            this.Column8.HeaderText = "Стоимость";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // goToDelete
            // 
            this.goToDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.goToDelete.Animated = true;
            this.goToDelete.BackColor = System.Drawing.Color.Transparent;
            this.goToDelete.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(213)))), ((int)(((byte)(215)))));
            this.goToDelete.BorderRadius = 14;
            this.goToDelete.BorderThickness = 1;
            this.goToDelete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.goToDelete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.goToDelete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.goToDelete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.goToDelete.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.goToDelete.Font = new System.Drawing.Font("Arial", 12F);
            this.goToDelete.ForeColor = System.Drawing.Color.Black;
            this.goToDelete.HoverState.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.goToDelete.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(6)))), ((int)(((byte)(29)))));
            this.goToDelete.Location = new System.Drawing.Point(22, 663);
            this.goToDelete.Margin = new System.Windows.Forms.Padding(0);
            this.goToDelete.Name = "goToDelete";
            this.goToDelete.Size = new System.Drawing.Size(153, 37);
            this.goToDelete.TabIndex = 116;
            this.goToDelete.Text = "Удалить";
            this.goToDelete.Click += new System.EventHandler(this.goToDelete_Click);
            // 
            // goToEdit
            // 
            this.goToEdit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.goToEdit.Animated = true;
            this.goToEdit.BackColor = System.Drawing.Color.Transparent;
            this.goToEdit.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(213)))), ((int)(((byte)(215)))));
            this.goToEdit.BorderRadius = 14;
            this.goToEdit.BorderThickness = 1;
            this.goToEdit.CustomizableEdges.BottomRight = false;
            this.goToEdit.CustomizableEdges.TopRight = false;
            this.goToEdit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.goToEdit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.goToEdit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.goToEdit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.goToEdit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(238)))));
            this.goToEdit.Font = new System.Drawing.Font("Arial", 12F);
            this.goToEdit.ForeColor = System.Drawing.Color.Black;
            this.goToEdit.HoverState.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.goToEdit.Location = new System.Drawing.Point(452, 663);
            this.goToEdit.Margin = new System.Windows.Forms.Padding(0);
            this.goToEdit.Name = "goToEdit";
            this.goToEdit.Size = new System.Drawing.Size(153, 37);
            this.goToEdit.TabIndex = 115;
            this.goToEdit.Text = "Изменить";
            this.goToEdit.Click += new System.EventHandler(this.goToEdit_Click);
            // 
            // goToAdd
            // 
            this.goToAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.goToAdd.Animated = true;
            this.goToAdd.BackColor = System.Drawing.Color.Transparent;
            this.goToAdd.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(213)))), ((int)(((byte)(215)))));
            this.goToAdd.BorderRadius = 14;
            this.goToAdd.BorderThickness = 1;
            this.goToAdd.CustomizableEdges.BottomLeft = false;
            this.goToAdd.CustomizableEdges.TopLeft = false;
            this.goToAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.goToAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.goToAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.goToAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.goToAdd.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(238)))));
            this.goToAdd.Font = new System.Drawing.Font("Arial", 12F);
            this.goToAdd.ForeColor = System.Drawing.Color.Black;
            this.goToAdd.HoverState.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.goToAdd.Location = new System.Drawing.Point(605, 663);
            this.goToAdd.Margin = new System.Windows.Forms.Padding(0);
            this.goToAdd.Name = "goToAdd";
            this.goToAdd.Size = new System.Drawing.Size(153, 37);
            this.goToAdd.TabIndex = 114;
            this.goToAdd.Text = "Добавить";
            this.goToAdd.Click += new System.EventHandler(this.GoToAdd_Click);
            // 
            // myMessageBoxError
            // 
            this.myMessageBoxError.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
            this.myMessageBoxError.Caption = "Мои животные";
            this.myMessageBoxError.Icon = Guna.UI2.WinForms.MessageDialogIcon.Error;
            this.myMessageBoxError.Parent = null;
            this.myMessageBoxError.Style = Guna.UI2.WinForms.MessageDialogStyle.Dark;
            this.myMessageBoxError.Text = null;
            // 
            // myMessageBoxInfo
            // 
            this.myMessageBoxInfo.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
            this.myMessageBoxInfo.Caption = "Мои животные";
            this.myMessageBoxInfo.Icon = Guna.UI2.WinForms.MessageDialogIcon.Information;
            this.myMessageBoxInfo.Parent = null;
            this.myMessageBoxInfo.Style = Guna.UI2.WinForms.MessageDialogStyle.Dark;
            this.myMessageBoxInfo.Text = null;
            // 
            // errorLabel
            // 
            this.errorLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.errorLabel.AutoSize = true;
            this.errorLabel.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.errorLabel.ForeColor = System.Drawing.Color.Black;
            this.errorLabel.Location = new System.Drawing.Point(140, 313);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(494, 29);
            this.errorLabel.TabIndex = 128;
            this.errorLabel.Text = "Соединение с базой данной отсутствует";
            this.errorLabel.Visible = false;
            // 
            // zeroRowsLabel
            // 
            this.zeroRowsLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.zeroRowsLabel.AutoSize = true;
            this.zeroRowsLabel.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.zeroRowsLabel.ForeColor = System.Drawing.Color.Black;
            this.zeroRowsLabel.Location = new System.Drawing.Point(146, 342);
            this.zeroRowsLabel.Name = "zeroRowsLabel";
            this.zeroRowsLabel.Size = new System.Drawing.Size(472, 29);
            this.zeroRowsLabel.TabIndex = 127;
            this.zeroRowsLabel.Text = "Услуг по данному запросу не найдено";
            this.zeroRowsLabel.Visible = false;
            // 
            // seeLabel
            // 
            this.seeLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.seeLabel.AutoSize = true;
            this.seeLabel.Font = new System.Drawing.Font("Arial", 12F);
            this.seeLabel.ForeColor = System.Drawing.Color.Black;
            this.seeLabel.Location = new System.Drawing.Point(563, 616);
            this.seeLabel.Name = "seeLabel";
            this.seeLabel.Size = new System.Drawing.Size(0, 18);
            this.seeLabel.TabIndex = 130;
            this.seeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // countRowsLabel
            // 
            this.countRowsLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.countRowsLabel.AutoSize = true;
            this.countRowsLabel.Font = new System.Drawing.Font("Arial", 12F);
            this.countRowsLabel.ForeColor = System.Drawing.Color.Black;
            this.countRowsLabel.Location = new System.Drawing.Point(29, 616);
            this.countRowsLabel.Name = "countRowsLabel";
            this.countRowsLabel.Size = new System.Drawing.Size(0, 18);
            this.countRowsLabel.TabIndex = 129;
            // 
            // myMessageBoxQuestion
            // 
            this.myMessageBoxQuestion.Buttons = Guna.UI2.WinForms.MessageDialogButtons.YesNo;
            this.myMessageBoxQuestion.Caption = "Мои животные";
            this.myMessageBoxQuestion.Icon = Guna.UI2.WinForms.MessageDialogIcon.Question;
            this.myMessageBoxQuestion.Parent = null;
            this.myMessageBoxQuestion.Style = Guna.UI2.WinForms.MessageDialogStyle.Dark;
            this.myMessageBoxQuestion.Text = null;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F);
            this.label2.Location = new System.Drawing.Point(769, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 18);
            this.label2.TabIndex = 132;
            this.label2.Text = "Оформлено:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(769, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 22);
            this.label1.TabIndex = 131;
            this.label1.Text = "Оформлено:";
            // 
            // MyPetsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.ClientSize = new System.Drawing.Size(1008, 733);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.seeLabel);
            this.Controls.Add(this.countRowsLabel);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.zeroRowsLabel);
            this.Controls.Add(this.goToClearSeacher);
            this.Controls.Add(this.rightWarp);
            this.Controls.Add(this.goToSearch);
            this.Controls.Add(this.doubleRightWarp);
            this.Controls.Add(this.amountPagesComboBox);
            this.Controls.Add(this.leftWarp);
            this.Controls.Add(this.doubleLeftWarp);
            this.Controls.Add(this.seacher);
            this.Controls.Add(this.mainTable);
            this.Controls.Add(this.goToDelete);
            this.Controls.Add(this.goToEdit);
            this.Controls.Add(this.goToAdd);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MyPetsForm";
            this.Text = "MyPetsForm";
            ((System.ComponentModel.ISupportInitialize)(this.mainTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Button goToClearSeacher;
        private Guna.UI2.WinForms.Guna2ImageButton rightWarp;
        private Guna.UI2.WinForms.Guna2Button goToSearch;
        private Guna.UI2.WinForms.Guna2ImageButton doubleRightWarp;
        private Guna.UI2.WinForms.Guna2ComboBox amountPagesComboBox;
        private Guna.UI2.WinForms.Guna2ImageButton leftWarp;
        private Guna.UI2.WinForms.Guna2ImageButton doubleLeftWarp;
        private Guna.UI2.WinForms.Guna2TextBox seacher;
        private Guna.UI2.WinForms.Guna2DataGridView mainTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private Guna.UI2.WinForms.Guna2Button goToDelete;
        private Guna.UI2.WinForms.Guna2Button goToEdit;
        private Guna.UI2.WinForms.Guna2Button goToAdd;
        private Guna.UI2.WinForms.Guna2MessageDialog myMessageBoxError;
        private Guna.UI2.WinForms.Guna2MessageDialog myMessageBoxInfo;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.Label zeroRowsLabel;
        private System.Windows.Forms.Label seeLabel;
        private System.Windows.Forms.Label countRowsLabel;
        private Guna.UI2.WinForms.Guna2MessageDialog myMessageBoxQuestion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}