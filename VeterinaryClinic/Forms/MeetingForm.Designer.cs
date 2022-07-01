
namespace VeterinaryClinic.Forms
{
    partial class MeetingForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.timeComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.commentBox = new System.Windows.Forms.RichTextBox();
            this.goToCreateMeeting = new Guna.UI2.WinForms.Guna2Button();
            this.myMessageBoxInfo = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.myMessageBoxError = new Guna.UI2.WinForms.Guna2MessageDialog();
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
            this.label3.Size = new System.Drawing.Size(211, 22);
            this.label3.TabIndex = 66;
            this.label3.Text = "Запись к ветеринару";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(425, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 29);
            this.label1.TabIndex = 91;
            this.label1.Text = "Дата приема";
            // 
            // dateComboBox
            // 
            this.dateComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateComboBox.BackColor = System.Drawing.Color.Transparent;
            this.dateComboBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(213)))), ((int)(((byte)(215)))));
            this.dateComboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dateComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.dateComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dateComboBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(238)))));
            this.dateComboBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(116)))), ((int)(((byte)(144)))));
            this.dateComboBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(116)))), ((int)(((byte)(144)))));
            this.dateComboBox.FocusedState.ForeColor = System.Drawing.Color.Black;
            this.dateComboBox.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.dateComboBox.ForeColor = System.Drawing.Color.Black;
            this.dateComboBox.HoverState.ForeColor = System.Drawing.Color.Black;
            this.dateComboBox.ItemHeight = 30;
            this.dateComboBox.ItemsAppearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.dateComboBox.ItemsAppearance.ForeColor = System.Drawing.Color.Black;
            this.dateComboBox.ItemsAppearance.SelectedFont = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.dateComboBox.ItemsAppearance.SelectedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(116)))), ((int)(((byte)(144)))));
            this.dateComboBox.Location = new System.Drawing.Point(351, 182);
            this.dateComboBox.Margin = new System.Windows.Forms.Padding(0);
            this.dateComboBox.Name = "dateComboBox";
            this.dateComboBox.Size = new System.Drawing.Size(311, 36);
            this.dateComboBox.TabIndex = 107;
            this.dateComboBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dateComboBox.TextOffset = new System.Drawing.Point(13, 0);
            this.dateComboBox.SelectedIndexChanged += new System.EventHandler(this.DateComboBox_SelectedIndexChanged);
            // 
            // timeComboBox
            // 
            this.timeComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.timeComboBox.BackColor = System.Drawing.Color.Transparent;
            this.timeComboBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(213)))), ((int)(((byte)(215)))));
            this.timeComboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.timeComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.timeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.timeComboBox.Enabled = false;
            this.timeComboBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(238)))));
            this.timeComboBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(116)))), ((int)(((byte)(144)))));
            this.timeComboBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(116)))), ((int)(((byte)(144)))));
            this.timeComboBox.FocusedState.ForeColor = System.Drawing.Color.Black;
            this.timeComboBox.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.timeComboBox.ForeColor = System.Drawing.Color.Black;
            this.timeComboBox.HoverState.ForeColor = System.Drawing.Color.Black;
            this.timeComboBox.ItemHeight = 30;
            this.timeComboBox.Items.AddRange(new object[] {
            "10:00",
            "11:00",
            "12:00",
            "13:00",
            "14:00",
            "15:00",
            "16:00",
            "17:00",
            "18:00"});
            this.timeComboBox.ItemsAppearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.timeComboBox.ItemsAppearance.ForeColor = System.Drawing.Color.Black;
            this.timeComboBox.ItemsAppearance.SelectedFont = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.timeComboBox.ItemsAppearance.SelectedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(116)))), ((int)(((byte)(144)))));
            this.timeComboBox.Location = new System.Drawing.Point(351, 308);
            this.timeComboBox.Margin = new System.Windows.Forms.Padding(0);
            this.timeComboBox.Name = "timeComboBox";
            this.timeComboBox.Size = new System.Drawing.Size(311, 36);
            this.timeComboBox.StartIndex = 0;
            this.timeComboBox.TabIndex = 109;
            this.timeComboBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.timeComboBox.TextOffset = new System.Drawing.Point(13, 0);
            this.timeComboBox.SelectedIndexChanged += new System.EventHandler(this.TimeComboBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(415, 270);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 29);
            this.label2.TabIndex = 108;
            this.label2.Text = "Время приема";
            // 
            // commentBox
            // 
            this.commentBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.commentBox.Enabled = false;
            this.commentBox.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.commentBox.Location = new System.Drawing.Point(171, 401);
            this.commentBox.Name = "commentBox";
            this.commentBox.Size = new System.Drawing.Size(671, 115);
            this.commentBox.TabIndex = 111;
            this.commentBox.Text = "";
            // 
            // goToCreateMeeting
            // 
            this.goToCreateMeeting.Animated = true;
            this.goToCreateMeeting.AutoRoundedCorners = true;
            this.goToCreateMeeting.BorderColor = System.Drawing.Color.Transparent;
            this.goToCreateMeeting.BorderRadius = 21;
            this.goToCreateMeeting.BorderThickness = 2;
            this.goToCreateMeeting.Cursor = System.Windows.Forms.Cursors.Hand;
            this.goToCreateMeeting.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(116)))), ((int)(((byte)(144)))));
            this.goToCreateMeeting.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.goToCreateMeeting.ForeColor = System.Drawing.Color.White;
            this.goToCreateMeeting.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(116)))), ((int)(((byte)(144)))));
            this.goToCreateMeeting.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.goToCreateMeeting.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(116)))), ((int)(((byte)(144)))));
            this.goToCreateMeeting.Location = new System.Drawing.Point(378, 602);
            this.goToCreateMeeting.Name = "goToCreateMeeting";
            this.goToCreateMeeting.Size = new System.Drawing.Size(255, 45);
            this.goToCreateMeeting.TabIndex = 112;
            this.goToCreateMeeting.Text = "Записаться";
            this.goToCreateMeeting.Click += new System.EventHandler(this.GoToCreateMeeting_Click);
            // 
            // myMessageBoxInfo
            // 
            this.myMessageBoxInfo.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
            this.myMessageBoxInfo.Caption = "Запись";
            this.myMessageBoxInfo.Icon = Guna.UI2.WinForms.MessageDialogIcon.Information;
            this.myMessageBoxInfo.Parent = null;
            this.myMessageBoxInfo.Style = Guna.UI2.WinForms.MessageDialogStyle.Dark;
            this.myMessageBoxInfo.Text = null;
            // 
            // myMessageBoxError
            // 
            this.myMessageBoxError.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
            this.myMessageBoxError.Caption = "Запись";
            this.myMessageBoxError.Icon = Guna.UI2.WinForms.MessageDialogIcon.Error;
            this.myMessageBoxError.Parent = null;
            this.myMessageBoxError.Style = Guna.UI2.WinForms.MessageDialogStyle.Dark;
            this.myMessageBoxError.Text = null;
            // 
            // MeetingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.ClientSize = new System.Drawing.Size(1008, 733);
            this.Controls.Add(this.goToCreateMeeting);
            this.Controls.Add(this.commentBox);
            this.Controls.Add(this.timeComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MeetingForm";
            this.Text = "Meeting";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ComboBox dateComboBox;
        private Guna.UI2.WinForms.Guna2ComboBox timeComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox commentBox;
        private Guna.UI2.WinForms.Guna2Button goToCreateMeeting;
        private Guna.UI2.WinForms.Guna2MessageDialog myMessageBoxInfo;
        private Guna.UI2.WinForms.Guna2MessageDialog myMessageBoxError;
    }
}