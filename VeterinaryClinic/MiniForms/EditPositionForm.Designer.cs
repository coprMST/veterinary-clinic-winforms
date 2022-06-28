
namespace VeterinaryClinic.MiniForms
{
    partial class EditPosition
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditPosition));
            this.goToCloseForm = new Guna.UI2.WinForms.Guna2Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            this.goToCloseForm.Location = new System.Drawing.Point(239, 0);
            this.goToCloseForm.Margin = new System.Windows.Forms.Padding(0);
            this.goToCloseForm.Name = "goToCloseForm";
            this.goToCloseForm.Size = new System.Drawing.Size(50, 35);
            this.goToCloseForm.TabIndex = 24;
            this.goToCloseForm.Click += new System.EventHandler(this.GoToCloseForm_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(116)))), ((int)(((byte)(144)))));
            this.panel1.Controls.Add(this.goToCloseForm);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(289, 35);
            this.panel1.TabIndex = 25;
            // 
            // EditPosition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.ClientSize = new System.Drawing.Size(289, 425);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditPosition";
            this.ShowInTaskbar = false;
            this.Text = "EditPosition";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button goToCloseForm;
        private System.Windows.Forms.Panel panel1;
    }
}