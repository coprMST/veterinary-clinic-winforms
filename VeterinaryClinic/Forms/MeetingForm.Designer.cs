
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
            this.guna2DateTimePicker1 = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.amountPagesComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
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
            this.label1.Location = new System.Drawing.Point(394, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 29);
            this.label1.TabIndex = 91;
            this.label1.Text = "Дата приема";
            // 
            // guna2DateTimePicker1
            // 
            this.guna2DateTimePicker1.Checked = true;
            this.guna2DateTimePicker1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.guna2DateTimePicker1.Location = new System.Drawing.Point(382, 280);
            this.guna2DateTimePicker1.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.guna2DateTimePicker1.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.guna2DateTimePicker1.Name = "guna2DateTimePicker1";
            this.guna2DateTimePicker1.Size = new System.Drawing.Size(200, 36);
            this.guna2DateTimePicker1.TabIndex = 92;
            this.guna2DateTimePicker1.Value = new System.DateTime(2022, 7, 1, 0, 6, 16, 34);
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
            this.amountPagesComboBox.Location = new System.Drawing.Point(359, 175);
            this.amountPagesComboBox.Margin = new System.Windows.Forms.Padding(0);
            this.amountPagesComboBox.Name = "amountPagesComboBox";
            this.amountPagesComboBox.Size = new System.Drawing.Size(234, 36);
            this.amountPagesComboBox.StartIndex = 0;
            this.amountPagesComboBox.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.amountPagesComboBox.TabIndex = 107;
            this.amountPagesComboBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MeetingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.ClientSize = new System.Drawing.Size(1008, 733);
            this.Controls.Add(this.amountPagesComboBox);
            this.Controls.Add(this.guna2DateTimePicker1);
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
        private Guna.UI2.WinForms.Guna2DateTimePicker guna2DateTimePicker1;
        private Guna.UI2.WinForms.Guna2ComboBox amountPagesComboBox;
    }
}