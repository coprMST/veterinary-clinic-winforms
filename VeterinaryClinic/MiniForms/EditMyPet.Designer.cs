
namespace VeterinaryClinic.MiniForms
{
    partial class EditMyPet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditMyPet));
            this.panel1 = new System.Windows.Forms.Panel();
            this.goToCloseForm = new Guna.UI2.WinForms.Guna2Button();
            this.femaleButton = new Guna.UI2.WinForms.Guna2Button();
            this.maleButton = new Guna.UI2.WinForms.Guna2Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.goToEdit = new Guna.UI2.WinForms.Guna2Button();
            this.petNameTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.peculiaritiesTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.myMessageBoxError = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.myMessageBoxInfo = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(116)))), ((int)(((byte)(144)))));
            this.panel1.Controls.Add(this.goToCloseForm);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(493, 35);
            this.panel1.TabIndex = 115;
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
            this.goToCloseForm.Click += new System.EventHandler(this.goToCloseForm_Click);
            // 
            // femaleButton
            // 
            this.femaleButton.Animated = true;
            this.femaleButton.AutoRoundedCorners = true;
            this.femaleButton.BorderColor = System.Drawing.Color.Transparent;
            this.femaleButton.BorderRadius = 21;
            this.femaleButton.BorderThickness = 2;
            this.femaleButton.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.femaleButton.CheckedState.FillColor = System.Drawing.Color.White;
            this.femaleButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.femaleButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(116)))), ((int)(((byte)(144)))));
            this.femaleButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.femaleButton.ForeColor = System.Drawing.Color.White;
            this.femaleButton.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(116)))), ((int)(((byte)(144)))));
            this.femaleButton.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.femaleButton.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(116)))), ((int)(((byte)(144)))));
            this.femaleButton.Location = new System.Drawing.Point(276, 301);
            this.femaleButton.Name = "femaleButton";
            this.femaleButton.Size = new System.Drawing.Size(164, 45);
            this.femaleButton.TabIndex = 132;
            this.femaleButton.Text = "Женский";
            // 
            // maleButton
            // 
            this.maleButton.Animated = true;
            this.maleButton.AutoRoundedCorners = true;
            this.maleButton.BorderColor = System.Drawing.Color.Transparent;
            this.maleButton.BorderRadius = 21;
            this.maleButton.BorderThickness = 2;
            this.maleButton.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.maleButton.CheckedState.FillColor = System.Drawing.Color.White;
            this.maleButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.maleButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(116)))), ((int)(((byte)(144)))));
            this.maleButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.maleButton.ForeColor = System.Drawing.Color.White;
            this.maleButton.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(116)))), ((int)(((byte)(144)))));
            this.maleButton.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.maleButton.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(116)))), ((int)(((byte)(144)))));
            this.maleButton.Location = new System.Drawing.Point(51, 301);
            this.maleButton.Name = "maleButton";
            this.maleButton.Size = new System.Drawing.Size(174, 45);
            this.maleButton.TabIndex = 131;
            this.maleButton.Text = "Мужской";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(70, 266);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 19);
            this.label3.TabIndex = 130;
            this.label3.Text = "Пол";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(70, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(274, 19);
            this.label2.TabIndex = 125;
            this.label2.Text = "Название питомца (порода и т.д.)";
            // 
            // goToEdit
            // 
            this.goToEdit.Animated = true;
            this.goToEdit.AutoRoundedCorners = true;
            this.goToEdit.BorderColor = System.Drawing.Color.Transparent;
            this.goToEdit.BorderRadius = 21;
            this.goToEdit.BorderThickness = 2;
            this.goToEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.goToEdit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(116)))), ((int)(((byte)(144)))));
            this.goToEdit.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.goToEdit.ForeColor = System.Drawing.Color.White;
            this.goToEdit.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(116)))), ((int)(((byte)(144)))));
            this.goToEdit.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.goToEdit.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(116)))), ((int)(((byte)(144)))));
            this.goToEdit.Location = new System.Drawing.Point(138, 467);
            this.goToEdit.Name = "goToEdit";
            this.goToEdit.Size = new System.Drawing.Size(216, 45);
            this.goToEdit.TabIndex = 129;
            this.goToEdit.Text = "Изменить";
            this.goToEdit.Click += new System.EventHandler(this.goToEdit_Click);
            // 
            // petNameTextBox
            // 
            this.petNameTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.petNameTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(213)))), ((int)(((byte)(215)))));
            this.petNameTextBox.BorderRadius = 8;
            this.petNameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.petNameTextBox.DefaultText = "";
            this.petNameTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.petNameTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.petNameTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.petNameTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.petNameTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(116)))), ((int)(((byte)(144)))));
            this.petNameTextBox.Font = new System.Drawing.Font("Arial", 14F);
            this.petNameTextBox.ForeColor = System.Drawing.Color.Black;
            this.petNameTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(116)))), ((int)(((byte)(144)))));
            this.petNameTextBox.IconLeftOffset = new System.Drawing.Point(6, 0);
            this.petNameTextBox.IconLeftSize = new System.Drawing.Size(30, 30);
            this.petNameTextBox.Location = new System.Drawing.Point(51, 103);
            this.petNameTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.petNameTextBox.MaxLength = 32;
            this.petNameTextBox.Name = "petNameTextBox";
            this.petNameTextBox.PasswordChar = '\0';
            this.petNameTextBox.PlaceholderText = "Алабай Шарик";
            this.petNameTextBox.SelectedText = "";
            this.petNameTextBox.Size = new System.Drawing.Size(389, 51);
            this.petNameTextBox.TabIndex = 126;
            this.petNameTextBox.TextOffset = new System.Drawing.Point(4, 0);
            this.petNameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.petNameTextBox_KeyPress);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(70, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 19);
            this.label1.TabIndex = 128;
            this.label1.Text = "Особенности животного";
            // 
            // peculiaritiesTextBox
            // 
            this.peculiaritiesTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.peculiaritiesTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(213)))), ((int)(((byte)(215)))));
            this.peculiaritiesTextBox.BorderRadius = 8;
            this.peculiaritiesTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.peculiaritiesTextBox.DefaultText = "";
            this.peculiaritiesTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.peculiaritiesTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.peculiaritiesTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.peculiaritiesTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.peculiaritiesTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(116)))), ((int)(((byte)(144)))));
            this.peculiaritiesTextBox.Font = new System.Drawing.Font("Arial", 14F);
            this.peculiaritiesTextBox.ForeColor = System.Drawing.Color.Black;
            this.peculiaritiesTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(116)))), ((int)(((byte)(144)))));
            this.peculiaritiesTextBox.IconLeftOffset = new System.Drawing.Point(6, 0);
            this.peculiaritiesTextBox.IconLeftSize = new System.Drawing.Size(30, 30);
            this.peculiaritiesTextBox.IconRightOffset = new System.Drawing.Point(12, 0);
            this.peculiaritiesTextBox.IconRightSize = new System.Drawing.Size(26, 26);
            this.peculiaritiesTextBox.Location = new System.Drawing.Point(51, 196);
            this.peculiaritiesTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.peculiaritiesTextBox.MaxLength = 128;
            this.peculiaritiesTextBox.Name = "peculiaritiesTextBox";
            this.peculiaritiesTextBox.PasswordChar = '\0';
            this.peculiaritiesTextBox.PlaceholderText = "Сердечно-сосудистая недостаточность";
            this.peculiaritiesTextBox.SelectedText = "";
            this.peculiaritiesTextBox.Size = new System.Drawing.Size(389, 51);
            this.peculiaritiesTextBox.TabIndex = 127;
            this.peculiaritiesTextBox.TextOffset = new System.Drawing.Point(4, 0);
            this.peculiaritiesTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.petNameTextBox_KeyPress);
            // 
            // myMessageBoxError
            // 
            this.myMessageBoxError.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
            this.myMessageBoxError.Caption = "Изменение";
            this.myMessageBoxError.Icon = Guna.UI2.WinForms.MessageDialogIcon.Error;
            this.myMessageBoxError.Parent = null;
            this.myMessageBoxError.Style = Guna.UI2.WinForms.MessageDialogStyle.Dark;
            this.myMessageBoxError.Text = null;
            // 
            // myMessageBoxInfo
            // 
            this.myMessageBoxInfo.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
            this.myMessageBoxInfo.Caption = "Изменение";
            this.myMessageBoxInfo.Icon = Guna.UI2.WinForms.MessageDialogIcon.Information;
            this.myMessageBoxInfo.Parent = null;
            this.myMessageBoxInfo.Style = Guna.UI2.WinForms.MessageDialogStyle.Dark;
            this.myMessageBoxInfo.Text = null;
            // 
            // EditMyPet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.ClientSize = new System.Drawing.Size(493, 542);
            this.Controls.Add(this.femaleButton);
            this.Controls.Add(this.maleButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.goToEdit);
            this.Controls.Add(this.petNameTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.peculiaritiesTextBox);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditMyPet";
            this.Text = "EditMyPet";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button goToCloseForm;
        private Guna.UI2.WinForms.Guna2Button femaleButton;
        private Guna.UI2.WinForms.Guna2Button maleButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button goToEdit;
        private Guna.UI2.WinForms.Guna2TextBox petNameTextBox;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox peculiaritiesTextBox;
        private Guna.UI2.WinForms.Guna2MessageDialog myMessageBoxError;
        private Guna.UI2.WinForms.Guna2MessageDialog myMessageBoxInfo;
    }
}