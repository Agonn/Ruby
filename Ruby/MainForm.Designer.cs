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
            this.metroStyle = new MetroFramework.Components.MetroStyleManager(this.components);
            this.CxtMenu = new MaterialSkin.Controls.MaterialContextMenuStrip();
            this.historikuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statistikaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kameraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.metroTab = new MetroFramework.Controls.MetroTabControl();
            this.tbShitja = new MetroFramework.Controls.MetroTabPage();
            this.dgvShitja = new System.Windows.Forms.DataGridView();
            this.lblSot = new MetroFramework.Controls.MetroLabel();
            this.txtPershkrimi = new MetroFramework.Controls.MetroTextBox();
            this.txtMalli = new MetroFramework.Controls.MetroTextBox();
            this.tbHistoria = new MetroFramework.Controls.MetroTabPage();
            this.lblShpenzime = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.lblShitje = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.lblDataSot = new MetroFramework.Controls.MetroLabel();
            this.tbStatistika = new MetroFramework.Controls.MetroTabPage();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyle)).BeginInit();
            this.CxtMenu.SuspendLayout();
            this.metroTab.SuspendLayout();
            this.tbShitja.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShitja)).BeginInit();
            this.tbHistoria.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbMalli
            // 
            this.cmbMalli.FormattingEnabled = true;
            this.cmbMalli.ItemHeight = 23;
            this.cmbMalli.Items.AddRange(new object[] {
            "Unazë",
            "Hallhalle",
            "Qafore",
            "Riparim",
            "Gurrë",
            "Shërbim",
            "Tjetër"});
            this.cmbMalli.Location = new System.Drawing.Point(64, 26);
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
            this.txtCmimi.Location = new System.Drawing.Point(64, 68);
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
            this.btnShto.DisplayFocus = true;
            this.btnShto.ForeColor = System.Drawing.Color.DarkRed;
            this.btnShto.Location = new System.Drawing.Point(64, 112);
            this.btnShto.Name = "btnShto";
            this.btnShto.Size = new System.Drawing.Size(121, 23);
            this.btnShto.TabIndex = 11;
            this.btnShto.Text = "Shto";
            this.btnShto.UseSelectable = true;
            this.btnShto.Click += new System.EventHandler(this.btnShto_Click_1);
            // 
            // btnPdf
            // 
            this.btnPdf.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPdf.Location = new System.Drawing.Point(835, 447);
            this.btnPdf.Name = "btnPdf";
            this.btnPdf.Size = new System.Drawing.Size(77, 23);
            this.btnPdf.TabIndex = 11;
            this.btnPdf.Text = "PDF";
            this.btnPdf.UseSelectable = true;
            // 
            // dtpData
            // 
            this.dtpData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpData.Location = new System.Drawing.Point(712, 81);
            this.dtpData.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(200, 29);
            this.dtpData.TabIndex = 12;
            this.dtpData.ValueChanged += new System.EventHandler(this.dtpData_ValueChanged);
            // 
            // Malli
            // 
            this.Malli.AutoSize = true;
            this.Malli.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.Malli.Location = new System.Drawing.Point(2, 26);
            this.Malli.Name = "Malli";
            this.Malli.Size = new System.Drawing.Size(38, 19);
            this.Malli.TabIndex = 13;
            this.Malli.Text = "Tipi:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.Location = new System.Drawing.Point(2, 68);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(56, 19);
            this.metroLabel2.TabIndex = 13;
            this.metroLabel2.Text = "Cmimi:";
            // 
            // metroStyle
            // 
            this.metroStyle.Owner = this;
            this.metroStyle.Style = MetroFramework.MetroColorStyle.Red;
            // 
            // CxtMenu
            // 
            this.CxtMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CxtMenu.Depth = 0;
            this.CxtMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.historikuToolStripMenuItem,
            this.statistikaToolStripMenuItem,
            this.kameraToolStripMenuItem,
            this.toolStripSeparator1,
            this.logOutToolStripMenuItem});
            this.CxtMenu.MouseState = MaterialSkin.MouseState.HOVER;
            this.CxtMenu.Name = "CxtMenu";
            this.CxtMenu.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.CxtMenu.Size = new System.Drawing.Size(122, 98);
            // 
            // historikuToolStripMenuItem
            // 
            this.historikuToolStripMenuItem.Name = "historikuToolStripMenuItem";
            this.historikuToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.historikuToolStripMenuItem.Text = "Historia";
            // 
            // statistikaToolStripMenuItem
            // 
            this.statistikaToolStripMenuItem.Name = "statistikaToolStripMenuItem";
            this.statistikaToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.statistikaToolStripMenuItem.Text = "Statistika";
            // 
            // kameraToolStripMenuItem
            // 
            this.kameraToolStripMenuItem.Name = "kameraToolStripMenuItem";
            this.kameraToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.kameraToolStripMenuItem.Text = "Kamera";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(118, 6);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.logOutToolStripMenuItem.Text = "Mbylle";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // metroTab
            // 
            this.metroTab.Controls.Add(this.tbShitja);
            this.metroTab.Controls.Add(this.tbHistoria);
            this.metroTab.Controls.Add(this.tbStatistika);
            this.metroTab.Location = new System.Drawing.Point(23, 63);
            this.metroTab.Name = "metroTab";
            this.metroTab.SelectedIndex = 0;
            this.metroTab.Size = new System.Drawing.Size(683, 407);
            this.metroTab.TabIndex = 14;
            this.metroTab.UseSelectable = true;
            // 
            // tbShitja
            // 
            this.tbShitja.Controls.Add(this.dgvShitja);
            this.tbShitja.Controls.Add(this.metroLabel2);
            this.tbShitja.Controls.Add(this.cmbMalli);
            this.tbShitja.Controls.Add(this.lblSot);
            this.tbShitja.Controls.Add(this.Malli);
            this.tbShitja.Controls.Add(this.txtPershkrimi);
            this.tbShitja.Controls.Add(this.txtMalli);
            this.tbShitja.Controls.Add(this.txtCmimi);
            this.tbShitja.Controls.Add(this.btnShto);
            this.tbShitja.HorizontalScrollbarBarColor = true;
            this.tbShitja.HorizontalScrollbarHighlightOnWheel = false;
            this.tbShitja.HorizontalScrollbarSize = 10;
            this.tbShitja.Location = new System.Drawing.Point(4, 38);
            this.tbShitja.Name = "tbShitja";
            this.tbShitja.Size = new System.Drawing.Size(675, 365);
            this.tbShitja.TabIndex = 0;
            this.tbShitja.Text = "Shitje";
            this.tbShitja.VerticalScrollbarBarColor = true;
            this.tbShitja.VerticalScrollbarHighlightOnWheel = false;
            this.tbShitja.VerticalScrollbarSize = 10;
            // 
            // dgvShitja
            // 
            this.dgvShitja.AllowUserToDeleteRows = false;
            this.dgvShitja.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dgvShitja.BackgroundColor = System.Drawing.Color.Maroon;
            this.dgvShitja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShitja.Location = new System.Drawing.Point(257, 0);
            this.dgvShitja.Name = "dgvShitja";
            this.dgvShitja.ReadOnly = true;
            this.dgvShitja.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgvShitja.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvShitja.Size = new System.Drawing.Size(418, 369);
            this.dgvShitja.TabIndex = 14;
            // 
            // lblSot
            // 
            this.lblSot.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblSot.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblSot.Location = new System.Drawing.Point(214, 0);
            this.lblSot.Name = "lblSot";
            this.lblSot.Size = new System.Drawing.Size(54, 33);
            this.lblSot.TabIndex = 13;
            this.lblSot.Text = "Sot:";
            // 
            // txtPershkrimi
            // 
            // 
            // 
            // 
            this.txtPershkrimi.CustomButton.Image = null;
            this.txtPershkrimi.CustomButton.Location = new System.Drawing.Point(99, 1);
            this.txtPershkrimi.CustomButton.Name = "";
            this.txtPershkrimi.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPershkrimi.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPershkrimi.CustomButton.TabIndex = 1;
            this.txtPershkrimi.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPershkrimi.CustomButton.UseSelectable = true;
            this.txtPershkrimi.CustomButton.Visible = false;
            this.txtPershkrimi.Lines = new string[0];
            this.txtPershkrimi.Location = new System.Drawing.Point(64, 197);
            this.txtPershkrimi.MaxLength = 32767;
            this.txtPershkrimi.Name = "txtPershkrimi";
            this.txtPershkrimi.PasswordChar = '\0';
            this.txtPershkrimi.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPershkrimi.SelectedText = "";
            this.txtPershkrimi.SelectionLength = 0;
            this.txtPershkrimi.SelectionStart = 0;
            this.txtPershkrimi.ShortcutsEnabled = true;
            this.txtPershkrimi.Size = new System.Drawing.Size(121, 23);
            this.txtPershkrimi.TabIndex = 10;
            this.txtPershkrimi.UseSelectable = true;
            this.txtPershkrimi.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPershkrimi.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtMalli
            // 
            // 
            // 
            // 
            this.txtMalli.CustomButton.Image = null;
            this.txtMalli.CustomButton.Location = new System.Drawing.Point(99, 1);
            this.txtMalli.CustomButton.Name = "";
            this.txtMalli.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtMalli.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtMalli.CustomButton.TabIndex = 1;
            this.txtMalli.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtMalli.CustomButton.UseSelectable = true;
            this.txtMalli.CustomButton.Visible = false;
            this.txtMalli.Lines = new string[0];
            this.txtMalli.Location = new System.Drawing.Point(64, 159);
            this.txtMalli.MaxLength = 32767;
            this.txtMalli.Name = "txtMalli";
            this.txtMalli.PasswordChar = '\0';
            this.txtMalli.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMalli.SelectedText = "";
            this.txtMalli.SelectionLength = 0;
            this.txtMalli.SelectionStart = 0;
            this.txtMalli.ShortcutsEnabled = true;
            this.txtMalli.Size = new System.Drawing.Size(121, 23);
            this.txtMalli.TabIndex = 10;
            this.txtMalli.UseSelectable = true;
            this.txtMalli.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtMalli.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tbHistoria
            // 
            this.tbHistoria.Controls.Add(this.lblShpenzime);
            this.tbHistoria.Controls.Add(this.metroLabel4);
            this.tbHistoria.Controls.Add(this.lblShitje);
            this.tbHistoria.Controls.Add(this.metroLabel3);
            this.tbHistoria.Controls.Add(this.metroLabel1);
            this.tbHistoria.Controls.Add(this.lblDataSot);
            this.tbHistoria.HorizontalScrollbarBarColor = true;
            this.tbHistoria.HorizontalScrollbarHighlightOnWheel = false;
            this.tbHistoria.HorizontalScrollbarSize = 10;
            this.tbHistoria.Location = new System.Drawing.Point(4, 38);
            this.tbHistoria.Name = "tbHistoria";
            this.tbHistoria.Size = new System.Drawing.Size(675, 365);
            this.tbHistoria.TabIndex = 1;
            this.tbHistoria.Text = "Historia";
            this.tbHistoria.VerticalScrollbarBarColor = true;
            this.tbHistoria.VerticalScrollbarHighlightOnWheel = false;
            this.tbHistoria.VerticalScrollbarSize = 10;
            // 
            // lblShpenzime
            // 
            this.lblShpenzime.AutoSize = true;
            this.lblShpenzime.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblShpenzime.Location = new System.Drawing.Point(95, 104);
            this.lblShpenzime.Name = "lblShpenzime";
            this.lblShpenzime.Size = new System.Drawing.Size(0, 0);
            this.lblShpenzime.TabIndex = 2;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel4.Location = new System.Drawing.Point(3, 104);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(86, 19);
            this.metroLabel4.TabIndex = 2;
            this.metroLabel4.Text = "Shpenzime:";
            // 
            // lblShitje
            // 
            this.lblShitje.AutoSize = true;
            this.lblShitje.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblShitje.Location = new System.Drawing.Point(59, 71);
            this.lblShitje.Name = "lblShitje";
            this.lblShitje.Size = new System.Drawing.Size(0, 0);
            this.lblShitje.TabIndex = 2;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel3.Location = new System.Drawing.Point(3, 71);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(50, 19);
            this.metroLabel3.TabIndex = 2;
            this.metroLabel3.Text = "Shitje:";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(3, 38);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(44, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Data:";
            // 
            // lblDataSot
            // 
            this.lblDataSot.AutoSize = true;
            this.lblDataSot.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblDataSot.Location = new System.Drawing.Point(48, 38);
            this.lblDataSot.Name = "lblDataSot";
            this.lblDataSot.Size = new System.Drawing.Size(0, 0);
            this.lblDataSot.TabIndex = 2;
            // 
            // tbStatistika
            // 
            this.tbStatistika.HorizontalScrollbarBarColor = true;
            this.tbStatistika.HorizontalScrollbarHighlightOnWheel = false;
            this.tbStatistika.HorizontalScrollbarSize = 10;
            this.tbStatistika.Location = new System.Drawing.Point(4, 38);
            this.tbStatistika.Name = "tbStatistika";
            this.tbStatistika.Size = new System.Drawing.Size(675, 365);
            this.tbStatistika.TabIndex = 2;
            this.tbStatistika.Text = "Statistika";
            this.tbStatistika.VerticalScrollbarBarColor = true;
            this.tbStatistika.VerticalScrollbarHighlightOnWheel = false;
            this.tbStatistika.VerticalScrollbarSize = 10;
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(932, 493);
            this.ContextMenuStrip = this.CxtMenu;
            this.Controls.Add(this.dtpData);
            this.Controls.Add(this.metroTab);
            this.Controls.Add(this.btnPdf);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Ruby";
            this.Load += new System.EventHandler(this.Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyle)).EndInit();
            this.CxtMenu.ResumeLayout(false);
            this.metroTab.ResumeLayout(false);
            this.tbShitja.ResumeLayout(false);
            this.tbShitja.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShitja)).EndInit();
            this.tbHistoria.ResumeLayout(false);
            this.tbHistoria.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroComboBox cmbMalli;
        private MetroFramework.Controls.MetroTextBox txtCmimi;
        private MetroFramework.Controls.MetroButton btnShto;
        private MetroFramework.Controls.MetroButton btnPdf;
        private MetroFramework.Controls.MetroDateTime dtpData;
        private MetroFramework.Controls.MetroLabel Malli;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Components.MetroStyleManager metroStyle;
        private MaterialSkin.Controls.MaterialContextMenuStrip CxtMenu;
        private System.Windows.Forms.ToolStripMenuItem historikuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statistikaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kameraToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private MetroFramework.Controls.MetroTabControl metroTab;
        private MetroFramework.Controls.MetroTabPage tbShitja;
        private MetroFramework.Controls.MetroTabPage tbHistoria;
        private MetroFramework.Controls.MetroTabPage tbStatistika;
        private MetroFramework.Controls.MetroLabel lblSot;
        private System.Windows.Forms.DataGridView dgvShitja;
        private MetroFramework.Controls.MetroLabel lblDataSot;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel lblShpenzime;
        private MetroFramework.Controls.MetroLabel lblShitje;
        private System.Windows.Forms.DataGridViewTextBoxColumn emriDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmimiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn malliemriDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mallicmimiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datashitjesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pershkrimiDataGridViewTextBoxColumn;
        private MetroFramework.Controls.MetroTextBox txtMalli;
        private MetroFramework.Controls.MetroTextBox txtPershkrimi;
    }
}

