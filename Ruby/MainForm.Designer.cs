namespace Ruby
{
    partial class Form
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form));
            this.cmbMalli = new MetroFramework.Controls.MetroComboBox();
            this.txtCmimi = new MetroFramework.Controls.MetroTextBox();
            this.btnShto = new MetroFramework.Controls.MetroButton();
            this.btnPdf = new MetroFramework.Controls.MetroButton();
            this.dtpData = new MetroFramework.Controls.MetroDateTime();
            this.Malli = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbMalli
            // 
            this.cmbMalli.FormattingEnabled = true;
            this.cmbMalli.ItemHeight = 23;
            this.cmbMalli.Items.AddRange(new object[] {
            "Unaze",
            "Hallhalle",
            "LLanec",
            "Riparim"});
            this.cmbMalli.Location = new System.Drawing.Point(84, 113);
            this.cmbMalli.Name = "cmbMalli";
            this.cmbMalli.Size = new System.Drawing.Size(121, 29);
            this.cmbMalli.TabIndex = 9;
            this.cmbMalli.UseSelectable = true;
            // 
            // txtCmimi
            // 
            // 
            // 
            // 
            this.txtCmimi.CustomButton.Image = null;
            this.txtCmimi.CustomButton.Location = new System.Drawing.Point(99, 1);
            this.txtCmimi.CustomButton.Name = "";
            this.txtCmimi.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtCmimi.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCmimi.CustomButton.TabIndex = 1;
            this.txtCmimi.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCmimi.CustomButton.UseSelectable = true;
            this.txtCmimi.CustomButton.Visible = false;
            this.txtCmimi.Lines = new string[0];
            this.txtCmimi.Location = new System.Drawing.Point(84, 159);
            this.txtCmimi.MaxLength = 32767;
            this.txtCmimi.Name = "txtCmimi";
            this.txtCmimi.PasswordChar = '\0';
            this.txtCmimi.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCmimi.SelectedText = "";
            this.txtCmimi.SelectionLength = 0;
            this.txtCmimi.SelectionStart = 0;
            this.txtCmimi.ShortcutsEnabled = true;
            this.txtCmimi.Size = new System.Drawing.Size(121, 23);
            this.txtCmimi.TabIndex = 10;
            this.txtCmimi.UseSelectable = true;
            this.txtCmimi.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCmimi.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnShto
            // 
            this.btnShto.Location = new System.Drawing.Point(84, 199);
            this.btnShto.Name = "btnShto";
            this.btnShto.Size = new System.Drawing.Size(121, 23);
            this.btnShto.TabIndex = 11;
            this.btnShto.Text = "Shto";
            this.btnShto.UseSelectable = true;
            // 
            // btnPdf
            // 
            this.btnPdf.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPdf.Location = new System.Drawing.Point(819, 426);
            this.btnPdf.Name = "btnPdf";
            this.btnPdf.Size = new System.Drawing.Size(77, 23);
            this.btnPdf.TabIndex = 11;
            this.btnPdf.Text = "PDF";
            this.btnPdf.UseSelectable = true;
            // 
            // dtpData
            // 
            this.dtpData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpData.Location = new System.Drawing.Point(696, 76);
            this.dtpData.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(200, 29);
            this.dtpData.TabIndex = 12;
            // 
            // Malli
            // 
            this.Malli.AutoSize = true;
            this.Malli.Location = new System.Drawing.Point(27, 113);
            this.Malli.Name = "Malli";
            this.Malli.Size = new System.Drawing.Size(40, 19);
            this.Malli.TabIndex = 13;
            this.Malli.Text = "Malli:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(27, 159);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(51, 19);
            this.metroLabel2.TabIndex = 13;
            this.metroLabel2.Text = "Cmimi:";
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = this;
            this.metroStyleManager1.Style = MetroFramework.MetroColorStyle.Red;
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(908, 490);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.Malli);
            this.Controls.Add(this.dtpData);
            this.Controls.Add(this.btnPdf);
            this.Controls.Add(this.btnShto);
            this.Controls.Add(this.txtCmimi);
            this.Controls.Add(this.cmbMalli);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Ruby";
            this.Load += new System.EventHandler(this.Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroComboBox cmbMalli;
        private MetroFramework.Controls.MetroTextBox txtCmimi;
        private MetroFramework.Controls.MetroButton btnShto;
        private MetroFramework.Controls.MetroButton btnPdf;
        private MetroFramework.Controls.MetroDateTime dtpData;
        private MetroFramework.Controls.MetroLabel Malli;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
    }
}

