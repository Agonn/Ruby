namespace Ruby
{
    partial class UserSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserSettings));
            this.lblPasswordi = new MetroFramework.Controls.MetroLabel();
            this.txtPasswordi = new MetroFramework.Controls.MetroTextBox();
            this.btnSetPassword = new MetroFramework.Controls.MetroButton();
            this.htmlLabel1 = new MetroFramework.Drawing.Html.HtmlLabel();
            this.SuspendLayout();
            // 
            // lblPasswordi
            // 
            this.lblPasswordi.AutoSize = true;
            this.lblPasswordi.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblPasswordi.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblPasswordi.Location = new System.Drawing.Point(24, 100);
            this.lblPasswordi.Name = "lblPasswordi";
            this.lblPasswordi.Size = new System.Drawing.Size(97, 25);
            this.lblPasswordi.TabIndex = 0;
            this.lblPasswordi.Text = "Password:";
            // 
            // txtPasswordi
            // 
            // 
            // 
            // 
            this.txtPasswordi.CustomButton.Image = null;
            this.txtPasswordi.CustomButton.Location = new System.Drawing.Point(132, 1);
            this.txtPasswordi.CustomButton.Name = "";
            this.txtPasswordi.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPasswordi.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPasswordi.CustomButton.TabIndex = 1;
            this.txtPasswordi.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPasswordi.CustomButton.UseSelectable = true;
            this.txtPasswordi.CustomButton.Visible = false;
            this.txtPasswordi.Lines = new string[0];
            this.txtPasswordi.Location = new System.Drawing.Point(127, 102);
            this.txtPasswordi.MaxLength = 32767;
            this.txtPasswordi.Name = "txtPasswordi";
            this.txtPasswordi.PasswordChar = '\0';
            this.txtPasswordi.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPasswordi.SelectedText = "";
            this.txtPasswordi.SelectionLength = 0;
            this.txtPasswordi.SelectionStart = 0;
            this.txtPasswordi.ShortcutsEnabled = true;
            this.txtPasswordi.Size = new System.Drawing.Size(154, 23);
            this.txtPasswordi.TabIndex = 1;
            this.txtPasswordi.UseSelectable = true;
            this.txtPasswordi.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPasswordi.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnSetPassword
            // 
            this.btnSetPassword.Location = new System.Drawing.Point(127, 140);
            this.btnSetPassword.Name = "btnSetPassword";
            this.btnSetPassword.Size = new System.Drawing.Size(154, 23);
            this.btnSetPassword.TabIndex = 2;
            this.btnSetPassword.Text = "Vendos passwordin";
            this.btnSetPassword.UseSelectable = true;
            // 
            // htmlLabel1
            // 
            this.htmlLabel1.AutoScroll = true;
            this.htmlLabel1.AutoScrollMinSize = new System.Drawing.Size(218, 23);
            this.htmlLabel1.AutoSize = false;
            this.htmlLabel1.BackColor = System.Drawing.SystemColors.Window;
            this.htmlLabel1.Location = new System.Drawing.Point(24, 64);
            this.htmlLabel1.Name = "htmlLabel1";
            this.htmlLabel1.Size = new System.Drawing.Size(257, 23);
            this.htmlLabel1.TabIndex = 3;
            this.htmlLabel1.Text = "Vendos password ne start te applikacionit:";
            // 
            // UserSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 399);
            this.Controls.Add(this.htmlLabel1);
            this.Controls.Add(this.btnSetPassword);
            this.Controls.Add(this.txtPasswordi);
            this.Controls.Add(this.lblPasswordi);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UserSettings";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel lblPasswordi;
        private MetroFramework.Controls.MetroTextBox txtPasswordi;
        private MetroFramework.Controls.MetroButton btnSetPassword;
        private MetroFramework.Drawing.Html.HtmlLabel htmlLabel1;
    }
}