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
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.historikuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statistikaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kameraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.metroTab = new MetroFramework.Controls.MetroTabControl();
            this.tbShitja = new MetroFramework.Controls.MetroTabPage();
            this.lblmPershkrimi = new MetroFramework.Controls.MetroLabel();
            this.txtbmPershkrimi = new MetroFramework.Controls.MetroTextBox();
            this.lblmShenimet = new MetroFramework.Controls.MetroLabel();
            this.txtmShenimet = new MetroFramework.Controls.MetroTextBox();
            this.pnlShpenzime = new System.Windows.Forms.Panel();
            this.btnShpenzime = new MetroFramework.Controls.MetroButton();
            this.txtShpenzime = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.dgvShitja = new System.Windows.Forms.DataGridView();
            this.tblMalliBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rubyDBDataSet1 = new Ruby.RubyDBDataSet1();
            this.tbHistoria = new MetroFramework.Controls.MetroTabPage();
            this.lblShpenzime = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.lblShitje = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.lblDataSot = new MetroFramework.Controls.MetroLabel();
            this.tbStatistika = new MetroFramework.Controls.MetroTabPage();
            this.cmbStatistika = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.lblHyrje = new MetroFramework.Controls.MetroLabel();
            this.rubyDBDataSet = new Ruby.RubyDBDataSet();
            this.tblMalliTableAdapter = new Ruby.RubyDBDataSet1TableAdapters.TblMalliTableAdapter();
            this.midDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.malliEmriDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.malliCmimiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataShitjesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pershkrimiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyle)).BeginInit();
            this.CxtMenu.SuspendLayout();
            this.metroTab.SuspendLayout();
            this.tbShitja.SuspendLayout();
            this.pnlShpenzime.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShitja)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblMalliBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rubyDBDataSet1)).BeginInit();
            this.tbHistoria.SuspendLayout();
            this.tbStatistika.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rubyDBDataSet)).BeginInit();
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
            this.cmbMalli.TabIndex = 0;
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
            this.txtCmimi.TabIndex = 1;
            this.txtCmimi.UseSelectable = true;
            this.txtCmimi.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCmimi.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnShto
            // 
            this.btnShto.DisplayFocus = true;
            this.btnShto.ForeColor = System.Drawing.Color.DarkRed;
            this.btnShto.Location = new System.Drawing.Point(55, 164);
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
            this.btnPdf.Location = new System.Drawing.Point(1176, 676);
            this.btnPdf.Name = "btnPdf";
            this.btnPdf.Size = new System.Drawing.Size(77, 23);
            this.btnPdf.TabIndex = 11;
            this.btnPdf.Text = "PDF";
            this.btnPdf.UseSelectable = true;
            // 
            // dtpData
            // 
            this.dtpData.Dock = System.Windows.Forms.DockStyle.Right;
            this.dtpData.Location = new System.Drawing.Point(1053, 60);
            this.dtpData.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(200, 29);
            this.dtpData.TabIndex = 1;
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
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripSeparator2,
            this.historikuToolStripMenuItem,
            this.statistikaToolStripMenuItem,
            this.kameraToolStripMenuItem,
            this.toolStripSeparator1,
            this.logOutToolStripMenuItem});
            this.CxtMenu.MouseState = MaterialSkin.MouseState.HOVER;
            this.CxtMenu.Name = "CxtMenu";
            this.CxtMenu.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.CxtMenu.Size = new System.Drawing.Size(173, 148);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(172, 22);
            this.toolStripMenuItem1.Text = "Shto Shpenzim";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(172, 22);
            this.toolStripMenuItem2.Text = "Mshef Shpenzimet";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click_1);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(169, 6);
            // 
            // historikuToolStripMenuItem
            // 
            this.historikuToolStripMenuItem.Name = "historikuToolStripMenuItem";
            this.historikuToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.historikuToolStripMenuItem.Text = "Historia";
            // 
            // statistikaToolStripMenuItem
            // 
            this.statistikaToolStripMenuItem.Name = "statistikaToolStripMenuItem";
            this.statistikaToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.statistikaToolStripMenuItem.Text = "Statistika";
            // 
            // kameraToolStripMenuItem
            // 
            this.kameraToolStripMenuItem.Name = "kameraToolStripMenuItem";
            this.kameraToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.kameraToolStripMenuItem.Text = "Kamera";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(169, 6);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.logOutToolStripMenuItem.Text = "Log out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // metroTab
            // 
            this.metroTab.Controls.Add(this.tbShitja);
            this.metroTab.Controls.Add(this.tbHistoria);
            this.metroTab.Controls.Add(this.tbStatistika);
            this.metroTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTab.Location = new System.Drawing.Point(20, 60);
            this.metroTab.Name = "metroTab";
            this.metroTab.SelectedIndex = 0;
            this.metroTab.Size = new System.Drawing.Size(1233, 642);
            this.metroTab.TabIndex = 14;
            this.metroTab.UseSelectable = true;
            // 
            // tbShitja
            // 
            this.tbShitja.Controls.Add(this.lblmPershkrimi);
            this.tbShitja.Controls.Add(this.txtbmPershkrimi);
            this.tbShitja.Controls.Add(this.lblmShenimet);
            this.tbShitja.Controls.Add(this.txtmShenimet);
            this.tbShitja.Controls.Add(this.pnlShpenzime);
            this.tbShitja.Controls.Add(this.dgvShitja);
            this.tbShitja.Controls.Add(this.metroLabel2);
            this.tbShitja.Controls.Add(this.cmbMalli);
            this.tbShitja.Controls.Add(this.Malli);
            this.tbShitja.Controls.Add(this.txtCmimi);
            this.tbShitja.Controls.Add(this.btnShto);
            this.tbShitja.HorizontalScrollbarBarColor = true;
            this.tbShitja.HorizontalScrollbarHighlightOnWheel = false;
            this.tbShitja.HorizontalScrollbarSize = 10;
            this.tbShitja.Location = new System.Drawing.Point(4, 38);
            this.tbShitja.Name = "tbShitja";
            this.tbShitja.Size = new System.Drawing.Size(1225, 600);
            this.tbShitja.TabIndex = 0;
            this.tbShitja.Text = "Shitje";
            this.tbShitja.VerticalScrollbarBarColor = true;
            this.tbShitja.VerticalScrollbarHighlightOnWheel = false;
            this.tbShitja.VerticalScrollbarSize = 10;
            this.tbShitja.Click += new System.EventHandler(this.tbShitja_Click);
            // 
            // lblmPershkrimi
            // 
            this.lblmPershkrimi.AutoSize = true;
            this.lblmPershkrimi.Location = new System.Drawing.Point(5, 101);
            this.lblmPershkrimi.Name = "lblmPershkrimi";
            this.lblmPershkrimi.Size = new System.Drawing.Size(46, 19);
            this.lblmPershkrimi.TabIndex = 24;
            this.lblmPershkrimi.Text = "Pershk";
            // 
            // txtbmPershkrimi
            // 
            // 
            // 
            // 
            this.txtbmPershkrimi.CustomButton.Image = null;
            this.txtbmPershkrimi.CustomButton.Location = new System.Drawing.Point(99, 1);
            this.txtbmPershkrimi.CustomButton.Name = "";
            this.txtbmPershkrimi.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtbmPershkrimi.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtbmPershkrimi.CustomButton.TabIndex = 1;
            this.txtbmPershkrimi.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtbmPershkrimi.CustomButton.UseSelectable = true;
            this.txtbmPershkrimi.CustomButton.Visible = false;
            this.txtbmPershkrimi.Lines = new string[0];
            this.txtbmPershkrimi.Location = new System.Drawing.Point(64, 97);
            this.txtbmPershkrimi.MaxLength = 32767;
            this.txtbmPershkrimi.Name = "txtbmPershkrimi";
            this.txtbmPershkrimi.PasswordChar = '\0';
            this.txtbmPershkrimi.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtbmPershkrimi.SelectedText = "";
            this.txtbmPershkrimi.SelectionLength = 0;
            this.txtbmPershkrimi.SelectionStart = 0;
            this.txtbmPershkrimi.ShortcutsEnabled = true;
            this.txtbmPershkrimi.Size = new System.Drawing.Size(121, 23);
            this.txtbmPershkrimi.TabIndex = 21;
            this.txtbmPershkrimi.UseSelectable = true;
            this.txtbmPershkrimi.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtbmPershkrimi.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtbmPershkrimi.Click += new System.EventHandler(this.txtbmPershkrimi_Click);
            // 
            // lblmShenimet
            // 
            this.lblmShenimet.Location = new System.Drawing.Point(234, 26);
            this.lblmShenimet.Name = "lblmShenimet";
            this.lblmShenimet.Size = new System.Drawing.Size(336, 85);
            this.lblmShenimet.Style = MetroFramework.MetroColorStyle.Orange;
            this.lblmShenimet.TabIndex = 18;
            this.lblmShenimet.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // txtmShenimet
            // 
            // 
            // 
            // 
            this.txtmShenimet.CustomButton.Image = null;
            this.txtmShenimet.CustomButton.Location = new System.Drawing.Point(202, 2);
            this.txtmShenimet.CustomButton.Name = "";
            this.txtmShenimet.CustomButton.Size = new System.Drawing.Size(295, 295);
            this.txtmShenimet.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtmShenimet.CustomButton.TabIndex = 1;
            this.txtmShenimet.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtmShenimet.CustomButton.UseSelectable = true;
            this.txtmShenimet.CustomButton.Visible = false;
            this.txtmShenimet.Lines = new string[0];
            this.txtmShenimet.Location = new System.Drawing.Point(5, 228);
            this.txtmShenimet.MaxLength = 32767;
            this.txtmShenimet.Multiline = true;
            this.txtmShenimet.Name = "txtmShenimet";
            this.txtmShenimet.PasswordChar = '\0';
            this.txtmShenimet.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtmShenimet.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtmShenimet.SelectedText = "";
            this.txtmShenimet.SelectionLength = 0;
            this.txtmShenimet.SelectionStart = 0;
            this.txtmShenimet.ShortcutsEnabled = true;
            this.txtmShenimet.Size = new System.Drawing.Size(500, 300);
            this.txtmShenimet.Style = MetroFramework.MetroColorStyle.Teal;
            this.txtmShenimet.TabIndex = 17;
            this.txtmShenimet.UseSelectable = true;
            this.txtmShenimet.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtmShenimet.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // pnlShpenzime
            // 
            this.pnlShpenzime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlShpenzime.BackColor = System.Drawing.Color.Transparent;
            this.pnlShpenzime.Controls.Add(this.btnShpenzime);
            this.pnlShpenzime.Controls.Add(this.txtShpenzime);
            this.pnlShpenzime.Controls.Add(this.metroLabel6);
            this.pnlShpenzime.Location = new System.Drawing.Point(2, 563);
            this.pnlShpenzime.Name = "pnlShpenzime";
            this.pnlShpenzime.Size = new System.Drawing.Size(446, 34);
            this.pnlShpenzime.TabIndex = 16;
            this.pnlShpenzime.Visible = false;
            // 
            // btnShpenzime
            // 
            this.btnShpenzime.DisplayFocus = true;
            this.btnShpenzime.ForeColor = System.Drawing.Color.DarkRed;
            this.btnShpenzime.Location = new System.Drawing.Point(222, 8);
            this.btnShpenzime.Name = "btnShpenzime";
            this.btnShpenzime.Size = new System.Drawing.Size(122, 23);
            this.btnShpenzime.TabIndex = 11;
            this.btnShpenzime.Text = "Shto";
            this.btnShpenzime.UseSelectable = true;
            this.btnShpenzime.Click += new System.EventHandler(this.btnShpenzime_Click);
            // 
            // txtShpenzime
            // 
            // 
            // 
            // 
            this.txtShpenzime.CustomButton.Image = null;
            this.txtShpenzime.CustomButton.Location = new System.Drawing.Point(99, 1);
            this.txtShpenzime.CustomButton.Name = "";
            this.txtShpenzime.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtShpenzime.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtShpenzime.CustomButton.TabIndex = 1;
            this.txtShpenzime.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtShpenzime.CustomButton.UseSelectable = true;
            this.txtShpenzime.CustomButton.Visible = false;
            this.txtShpenzime.Lines = new string[0];
            this.txtShpenzime.Location = new System.Drawing.Point(95, 8);
            this.txtShpenzime.MaxLength = 32767;
            this.txtShpenzime.Name = "txtShpenzime";
            this.txtShpenzime.PasswordChar = '\0';
            this.txtShpenzime.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtShpenzime.SelectedText = "";
            this.txtShpenzime.SelectionLength = 0;
            this.txtShpenzime.SelectionStart = 0;
            this.txtShpenzime.ShortcutsEnabled = true;
            this.txtShpenzime.Size = new System.Drawing.Size(121, 23);
            this.txtShpenzime.TabIndex = 0;
            this.txtShpenzime.UseSelectable = true;
            this.txtShpenzime.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtShpenzime.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel6.Location = new System.Drawing.Point(3, 8);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(86, 19);
            this.metroLabel6.TabIndex = 13;
            this.metroLabel6.Text = "Shpenzime:";
            // 
            // dgvShitja
            // 
            this.dgvShitja.AllowUserToDeleteRows = false;
            this.dgvShitja.AutoGenerateColumns = false;
            this.dgvShitja.BackgroundColor = System.Drawing.Color.Maroon;
            this.dgvShitja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShitja.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.midDataGridViewTextBoxColumn,
            this.malliEmriDataGridViewTextBoxColumn,
            this.malliCmimiDataGridViewTextBoxColumn,
            this.dataShitjesDataGridViewTextBoxColumn,
            this.pershkrimiDataGridViewTextBoxColumn});
            this.dgvShitja.DataSource = this.tblMalliBindingSource;
            this.dgvShitja.Dock = System.Windows.Forms.DockStyle.Right;
            this.dgvShitja.Location = new System.Drawing.Point(698, 0);
            this.dgvShitja.Name = "dgvShitja";
            this.dgvShitja.ReadOnly = true;
            this.dgvShitja.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgvShitja.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvShitja.Size = new System.Drawing.Size(527, 600);
            this.dgvShitja.TabIndex = 5;
            // 
            // tblMalliBindingSource
            // 
            this.tblMalliBindingSource.DataMember = "TblMalli";
            this.tblMalliBindingSource.DataSource = this.rubyDBDataSet1;
            // 
            // rubyDBDataSet1
            // 
            this.rubyDBDataSet1.DataSetName = "RubyDBDataSet1";
            this.rubyDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.tbHistoria.Size = new System.Drawing.Size(1225, 600);
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
            this.metroLabel3.Location = new System.Drawing.Point(2, 68);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(50, 19);
            this.metroLabel3.TabIndex = 2;
            this.metroLabel3.Text = "Shitje:";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(2, 26);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(44, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Data:";
            // 
            // lblDataSot
            // 
            this.lblDataSot.AutoSize = true;
            this.lblDataSot.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblDataSot.Location = new System.Drawing.Point(95, 26);
            this.lblDataSot.Name = "lblDataSot";
            this.lblDataSot.Size = new System.Drawing.Size(0, 0);
            this.lblDataSot.TabIndex = 2;
            // 
            // tbStatistika
            // 
            this.tbStatistika.Controls.Add(this.cmbStatistika);
            this.tbStatistika.Controls.Add(this.metroLabel5);
            this.tbStatistika.Controls.Add(this.lblHyrje);
            this.tbStatistika.HorizontalScrollbarBarColor = true;
            this.tbStatistika.HorizontalScrollbarHighlightOnWheel = false;
            this.tbStatistika.HorizontalScrollbarSize = 10;
            this.tbStatistika.Location = new System.Drawing.Point(4, 38);
            this.tbStatistika.Name = "tbStatistika";
            this.tbStatistika.Size = new System.Drawing.Size(1225, 600);
            this.tbStatistika.TabIndex = 2;
            this.tbStatistika.Text = "Statistika";
            this.tbStatistika.VerticalScrollbarBarColor = true;
            this.tbStatistika.VerticalScrollbarHighlightOnWheel = false;
            this.tbStatistika.VerticalScrollbarSize = 10;
            // 
            // cmbStatistika
            // 
            this.cmbStatistika.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbStatistika.FormattingEnabled = true;
            this.cmbStatistika.ItemHeight = 23;
            this.cmbStatistika.Items.AddRange(new object[] {
            "Sot",
            "Java ",
            "Muaji",
            "Viti"});
            this.cmbStatistika.Location = new System.Drawing.Point(688, 26);
            this.cmbStatistika.Name = "cmbStatistika";
            this.cmbStatistika.Size = new System.Drawing.Size(73, 29);
            this.cmbStatistika.TabIndex = 10;
            this.cmbStatistika.UseSelectable = true;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel5.Location = new System.Drawing.Point(2, 68);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(86, 19);
            this.metroLabel5.TabIndex = 14;
            this.metroLabel5.Text = "Shpenzime:";
            // 
            // lblHyrje
            // 
            this.lblHyrje.AutoSize = true;
            this.lblHyrje.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblHyrje.Location = new System.Drawing.Point(2, 26);
            this.lblHyrje.Name = "lblHyrje";
            this.lblHyrje.Size = new System.Drawing.Size(50, 19);
            this.lblHyrje.TabIndex = 14;
            this.lblHyrje.Text = "Hyrje:";
            // 
            // rubyDBDataSet
            // 
            this.rubyDBDataSet.DataSetName = "RubyDBDataSet";
            this.rubyDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblMalliTableAdapter
            // 
            this.tblMalliTableAdapter.ClearBeforeFill = true;
            // 
            // midDataGridViewTextBoxColumn
            // 
            this.midDataGridViewTextBoxColumn.DataPropertyName = "Mid";
            this.midDataGridViewTextBoxColumn.HeaderText = "ID";
            this.midDataGridViewTextBoxColumn.Name = "midDataGridViewTextBoxColumn";
            this.midDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // malliEmriDataGridViewTextBoxColumn
            // 
            this.malliEmriDataGridViewTextBoxColumn.DataPropertyName = "Malli_Emri";
            this.malliEmriDataGridViewTextBoxColumn.HeaderText = "Emri";
            this.malliEmriDataGridViewTextBoxColumn.Name = "malliEmriDataGridViewTextBoxColumn";
            this.malliEmriDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // malliCmimiDataGridViewTextBoxColumn
            // 
            this.malliCmimiDataGridViewTextBoxColumn.DataPropertyName = "Malli_Cmimi";
            this.malliCmimiDataGridViewTextBoxColumn.HeaderText = "Çmimi";
            this.malliCmimiDataGridViewTextBoxColumn.Name = "malliCmimiDataGridViewTextBoxColumn";
            this.malliCmimiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataShitjesDataGridViewTextBoxColumn
            // 
            this.dataShitjesDataGridViewTextBoxColumn.DataPropertyName = "Data_Shitjes";
            this.dataShitjesDataGridViewTextBoxColumn.HeaderText = "Data Shitjes";
            this.dataShitjesDataGridViewTextBoxColumn.Name = "dataShitjesDataGridViewTextBoxColumn";
            this.dataShitjesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pershkrimiDataGridViewTextBoxColumn
            // 
            this.pershkrimiDataGridViewTextBoxColumn.DataPropertyName = "Pershkrimi";
            this.pershkrimiDataGridViewTextBoxColumn.HeaderText = "Përshkrimi";
            this.pershkrimiDataGridViewTextBoxColumn.Name = "pershkrimiDataGridViewTextBoxColumn";
            this.pershkrimiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1273, 722);
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
            this.pnlShpenzime.ResumeLayout(false);
            this.pnlShpenzime.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShitja)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblMalliBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rubyDBDataSet1)).EndInit();
            this.tbHistoria.ResumeLayout(false);
            this.tbHistoria.PerformLayout();
            this.tbStatistika.ResumeLayout(false);
            this.tbStatistika.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rubyDBDataSet)).EndInit();
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
        private MetroFramework.Controls.MetroTabPage tbShitja;
        private MetroFramework.Controls.MetroTabPage tbHistoria;
        private MetroFramework.Controls.MetroTabPage tbStatistika;
        private System.Windows.Forms.DataGridView dgvShitja;
        private MetroFramework.Controls.MetroLabel lblDataSot;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel lblShpenzime;
        private MetroFramework.Controls.MetroLabel lblShitje;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel lblHyrje;
        private MetroFramework.Controls.MetroComboBox cmbStatistika;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTextBox txtShpenzime;
        private MetroFramework.Controls.MetroButton btnShpenzime;
        private System.Windows.Forms.Panel pnlShpenzime;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private MetroFramework.Controls.MetroTabControl metroTab;
        private MetroFramework.Controls.MetroTextBox txtmShenimet;
        private MetroFramework.Controls.MetroLabel lblmShenimet;
        private MetroFramework.Controls.MetroTextBox txtbmPershkrimi;
        private MetroFramework.Controls.MetroLabel lblmPershkrimi;
        private RubyDBDataSet rubyDBDataSet;
        private RubyDBDataSet1 rubyDBDataSet1;
        private System.Windows.Forms.BindingSource tblMalliBindingSource;
        private RubyDBDataSet1TableAdapters.TblMalliTableAdapter tblMalliTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn midDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn malliEmriDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn malliCmimiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataShitjesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pershkrimiDataGridViewTextBoxColumn;
    }
}

