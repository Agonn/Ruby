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
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.historikuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statistikaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kameraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.metroTab = new MetroFramework.Controls.MetroTabControl();
            this.tbShitja = new MetroFramework.Controls.MetroTabPage();
            this.dtpShitje = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.txtbmPershkrimi = new MetroFramework.Controls.MetroTextBox();
            this.lblmShenimet = new MetroFramework.Controls.MetroLabel();
            this.dgvShitja = new System.Windows.Forms.DataGridView();
            this.midDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.malliEmriDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.malliCmimiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataShitjesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pershkrimiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblMalliBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rubyDBDataSet1 = new Ruby.RubyDBDataSet1();
            this.tbHistoria = new MetroFramework.Controls.MetroTabPage();
            this.dgvHistoria = new System.Windows.Forms.DataGridView();
            this.midDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.malliEmriDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.malliCmimiDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataShitjesDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pershkrimiDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblShpenzime = new MetroFramework.Controls.MetroLabel();
            this.lblShitje = new MetroFramework.Controls.MetroLabel();
            this.lblHistoriaShitje = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.lblDataSot = new MetroFramework.Controls.MetroLabel();
            this.tbStatistika = new MetroFramework.Controls.MetroTabPage();
            this.cmbStatistika = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.lblHyrje = new MetroFramework.Controls.MetroLabel();
            this.tbLive = new MetroFramework.Controls.MetroTabPage();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.rubyDBDataSet = new Ruby.RubyDBDataSet();
            this.tblMalliTableAdapter = new Ruby.RubyDBDataSet1TableAdapters.TblMalliTableAdapter();
            this.lblSkaData = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyle)).BeginInit();
            this.CxtMenu.SuspendLayout();
            this.metroTab.SuspendLayout();
            this.tbShitja.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShitja)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblMalliBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rubyDBDataSet1)).BeginInit();
            this.tbHistoria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistoria)).BeginInit();
            this.tbStatistika.SuspendLayout();
            this.tbLive.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rubyDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbMalli
            // 
            this.cmbMalli.FormattingEnabled = true;
            this.cmbMalli.ItemHeight = 23;
            this.cmbMalli.Items.AddRange(new object[] {
            "Gurrë",
            "Hallhalle",
            "Komplet",
            "Qafore",
            "Riparim",
            "Shërbim",
            "Unazë",
            "Vathë",
            "Tjetër"});
            this.cmbMalli.Location = new System.Drawing.Point(98, 35);
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
            this.txtCmimi.Location = new System.Drawing.Point(98, 73);
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
            this.btnShto.Location = new System.Drawing.Point(98, 142);
            this.btnShto.Name = "btnShto";
            this.btnShto.Size = new System.Drawing.Size(121, 23);
            this.btnShto.TabIndex = 3;
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
            this.dtpData.Location = new System.Drawing.Point(454, 3);
            this.dtpData.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(224, 29);
            this.dtpData.TabIndex = 1;
            this.dtpData.ValueChanged += new System.EventHandler(this.dtpData_ValueChanged);
            // 
            // Malli
            // 
            this.Malli.AutoSize = true;
            this.Malli.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.Malli.Location = new System.Drawing.Point(3, 35);
            this.Malli.Name = "Malli";
            this.Malli.Size = new System.Drawing.Size(38, 19);
            this.Malli.TabIndex = 13;
            this.Malli.Text = "Tipi:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.Location = new System.Drawing.Point(3, 73);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(56, 19);
            this.metroLabel2.TabIndex = 13;
            this.metroLabel2.Text = "Çmimi:";
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
            this.toolStripSeparator2,
            this.historikuToolStripMenuItem,
            this.statistikaToolStripMenuItem,
            this.kameraToolStripMenuItem,
            this.toolStripSeparator1,
            this.logOutToolStripMenuItem});
            this.CxtMenu.MouseState = MaterialSkin.MouseState.HOVER;
            this.CxtMenu.Name = "CxtMenu";
            this.CxtMenu.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.CxtMenu.Size = new System.Drawing.Size(122, 104);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(118, 6);
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
            this.logOutToolStripMenuItem.Text = "Çkyqu";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // metroTab
            // 
            this.metroTab.Controls.Add(this.tbShitja);
            this.metroTab.Controls.Add(this.tbHistoria);
            this.metroTab.Controls.Add(this.tbStatistika);
            this.metroTab.Controls.Add(this.tbLive);
            this.metroTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTab.Location = new System.Drawing.Point(20, 60);
            this.metroTab.Name = "metroTab";
            this.metroTab.SelectedIndex = 1;
            this.metroTab.Size = new System.Drawing.Size(1233, 642);
            this.metroTab.TabIndex = 14;
            this.metroTab.UseSelectable = true;
            // 
            // tbShitja
            // 
            this.tbShitja.Controls.Add(this.dtpShitje);
            this.tbShitja.Controls.Add(this.metroLabel6);
            this.tbShitja.Controls.Add(this.txtbmPershkrimi);
            this.tbShitja.Controls.Add(this.lblmShenimet);
            this.tbShitja.Controls.Add(this.dgvShitja);
            this.tbShitja.Controls.Add(this.metroLabel2);
            this.tbShitja.Controls.Add(this.cmbMalli);
            this.tbShitja.Controls.Add(this.Malli);
            this.tbShitja.Controls.Add(this.txtCmimi);
            this.tbShitja.Controls.Add(this.btnShto);
            this.tbShitja.HorizontalScrollbar = true;
            this.tbShitja.HorizontalScrollbarBarColor = true;
            this.tbShitja.HorizontalScrollbarHighlightOnWheel = false;
            this.tbShitja.HorizontalScrollbarSize = 10;
            this.tbShitja.Location = new System.Drawing.Point(4, 38);
            this.tbShitja.Name = "tbShitja";
            this.tbShitja.Size = new System.Drawing.Size(1225, 600);
            this.tbShitja.TabIndex = 0;
            this.tbShitja.Text = "Shitje";
            this.tbShitja.VerticalScrollbar = true;
            this.tbShitja.VerticalScrollbarBarColor = true;
            this.tbShitja.VerticalScrollbarHighlightOnWheel = false;
            this.tbShitja.VerticalScrollbarSize = 10;
            // 
            // dtpShitje
            // 
            this.dtpShitje.Enabled = false;
            this.dtpShitje.Location = new System.Drawing.Point(454, 3);
            this.dtpShitje.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtpShitje.Name = "dtpShitje";
            this.dtpShitje.Size = new System.Drawing.Size(224, 29);
            this.dtpShitje.TabIndex = 26;
            this.dtpShitje.ValueChanged += new System.EventHandler(this.dtpShitje_ValueChanged);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel6.Location = new System.Drawing.Point(3, 106);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(85, 19);
            this.metroLabel6.TabIndex = 25;
            this.metroLabel6.Text = "Përshkrimi:";
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
            this.txtbmPershkrimi.Location = new System.Drawing.Point(98, 106);
            this.txtbmPershkrimi.MaxLength = 32767;
            this.txtbmPershkrimi.Name = "txtbmPershkrimi";
            this.txtbmPershkrimi.PasswordChar = '\0';
            this.txtbmPershkrimi.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtbmPershkrimi.SelectedText = "";
            this.txtbmPershkrimi.SelectionLength = 0;
            this.txtbmPershkrimi.SelectionStart = 0;
            this.txtbmPershkrimi.ShortcutsEnabled = true;
            this.txtbmPershkrimi.Size = new System.Drawing.Size(121, 23);
            this.txtbmPershkrimi.TabIndex = 2;
            this.txtbmPershkrimi.UseSelectable = true;
            this.txtbmPershkrimi.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtbmPershkrimi.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblmShenimet
            // 
            this.lblmShenimet.Location = new System.Drawing.Point(340, 510);
            this.lblmShenimet.Name = "lblmShenimet";
            this.lblmShenimet.Size = new System.Drawing.Size(336, 90);
            this.lblmShenimet.Style = MetroFramework.MetroColorStyle.Orange;
            this.lblmShenimet.TabIndex = 18;
            this.lblmShenimet.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // dgvShitja
            // 
            this.dgvShitja.AllowUserToDeleteRows = false;
            this.dgvShitja.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.dgvShitja.Location = new System.Drawing.Point(684, 3);
            this.dgvShitja.Name = "dgvShitja";
            this.dgvShitja.ReadOnly = true;
            this.dgvShitja.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgvShitja.RowHeadersVisible = false;
            this.dgvShitja.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvShitja.Size = new System.Drawing.Size(541, 620);
            this.dgvShitja.TabIndex = 5;
            // 
            // midDataGridViewTextBoxColumn
            // 
            this.midDataGridViewTextBoxColumn.DataPropertyName = "Mid";
            this.midDataGridViewTextBoxColumn.HeaderText = "ID";
            this.midDataGridViewTextBoxColumn.Name = "midDataGridViewTextBoxColumn";
            this.midDataGridViewTextBoxColumn.ReadOnly = true;
            this.midDataGridViewTextBoxColumn.Width = 50;
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
            this.malliCmimiDataGridViewTextBoxColumn.Width = 70;
            // 
            // dataShitjesDataGridViewTextBoxColumn
            // 
            this.dataShitjesDataGridViewTextBoxColumn.DataPropertyName = "Data_Shitjes";
            this.dataShitjesDataGridViewTextBoxColumn.HeaderText = "Data Shitjes";
            this.dataShitjesDataGridViewTextBoxColumn.Name = "dataShitjesDataGridViewTextBoxColumn";
            this.dataShitjesDataGridViewTextBoxColumn.ReadOnly = true;
            this.dataShitjesDataGridViewTextBoxColumn.Width = 130;
            // 
            // pershkrimiDataGridViewTextBoxColumn
            // 
            this.pershkrimiDataGridViewTextBoxColumn.DataPropertyName = "Pershkrimi";
            this.pershkrimiDataGridViewTextBoxColumn.HeaderText = "Përshkrimi";
            this.pershkrimiDataGridViewTextBoxColumn.Name = "pershkrimiDataGridViewTextBoxColumn";
            this.pershkrimiDataGridViewTextBoxColumn.ReadOnly = true;
            this.pershkrimiDataGridViewTextBoxColumn.Width = 190;
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
            this.tbHistoria.Controls.Add(this.dtpData);
            this.tbHistoria.Controls.Add(this.dgvHistoria);
            this.tbHistoria.Controls.Add(this.lblShpenzime);
            this.tbHistoria.Controls.Add(this.lblShitje);
            this.tbHistoria.Controls.Add(this.lblHistoriaShitje);
            this.tbHistoria.Controls.Add(this.metroLabel3);
            this.tbHistoria.Controls.Add(this.metroLabel1);
            this.tbHistoria.Controls.Add(this.lblDataSot);
            this.tbHistoria.Controls.Add(this.lblSkaData);
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
            // dgvHistoria
            // 
            this.dgvHistoria.AllowUserToDeleteRows = false;
            this.dgvHistoria.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvHistoria.AutoGenerateColumns = false;
            this.dgvHistoria.BackgroundColor = System.Drawing.Color.Maroon;
            this.dgvHistoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistoria.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.midDataGridViewTextBoxColumn1,
            this.malliEmriDataGridViewTextBoxColumn1,
            this.malliCmimiDataGridViewTextBoxColumn1,
            this.dataShitjesDataGridViewTextBoxColumn1,
            this.pershkrimiDataGridViewTextBoxColumn1});
            this.dgvHistoria.DataSource = this.tblMalliBindingSource;
            this.dgvHistoria.Location = new System.Drawing.Point(684, 3);
            this.dgvHistoria.Name = "dgvHistoria";
            this.dgvHistoria.ReadOnly = true;
            this.dgvHistoria.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgvHistoria.RowHeadersVisible = false;
            this.dgvHistoria.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvHistoria.Size = new System.Drawing.Size(541, 620);
            this.dgvHistoria.TabIndex = 3;
            // 
            // midDataGridViewTextBoxColumn1
            // 
            this.midDataGridViewTextBoxColumn1.DataPropertyName = "Mid";
            this.midDataGridViewTextBoxColumn1.HeaderText = "ID";
            this.midDataGridViewTextBoxColumn1.Name = "midDataGridViewTextBoxColumn1";
            this.midDataGridViewTextBoxColumn1.ReadOnly = true;
            this.midDataGridViewTextBoxColumn1.Width = 50;
            // 
            // malliEmriDataGridViewTextBoxColumn1
            // 
            this.malliEmriDataGridViewTextBoxColumn1.DataPropertyName = "Malli_Emri";
            this.malliEmriDataGridViewTextBoxColumn1.HeaderText = "Emri";
            this.malliEmriDataGridViewTextBoxColumn1.Name = "malliEmriDataGridViewTextBoxColumn1";
            this.malliEmriDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // malliCmimiDataGridViewTextBoxColumn1
            // 
            this.malliCmimiDataGridViewTextBoxColumn1.DataPropertyName = "Malli_Cmimi";
            this.malliCmimiDataGridViewTextBoxColumn1.HeaderText = "Çmimi";
            this.malliCmimiDataGridViewTextBoxColumn1.Name = "malliCmimiDataGridViewTextBoxColumn1";
            this.malliCmimiDataGridViewTextBoxColumn1.ReadOnly = true;
            this.malliCmimiDataGridViewTextBoxColumn1.ToolTipText = "€";
            this.malliCmimiDataGridViewTextBoxColumn1.Width = 70;
            // 
            // dataShitjesDataGridViewTextBoxColumn1
            // 
            this.dataShitjesDataGridViewTextBoxColumn1.DataPropertyName = "Data_Shitjes";
            this.dataShitjesDataGridViewTextBoxColumn1.HeaderText = "Data Shitjes";
            this.dataShitjesDataGridViewTextBoxColumn1.Name = "dataShitjesDataGridViewTextBoxColumn1";
            this.dataShitjesDataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataShitjesDataGridViewTextBoxColumn1.Width = 130;
            // 
            // pershkrimiDataGridViewTextBoxColumn1
            // 
            this.pershkrimiDataGridViewTextBoxColumn1.DataPropertyName = "Pershkrimi";
            this.pershkrimiDataGridViewTextBoxColumn1.HeaderText = "Përshkrimi";
            this.pershkrimiDataGridViewTextBoxColumn1.Name = "pershkrimiDataGridViewTextBoxColumn1";
            this.pershkrimiDataGridViewTextBoxColumn1.ReadOnly = true;
            this.pershkrimiDataGridViewTextBoxColumn1.Width = 190;
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
            // lblShitje
            // 
            this.lblShitje.AutoSize = true;
            this.lblShitje.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblShitje.Location = new System.Drawing.Point(59, 71);
            this.lblShitje.Name = "lblShitje";
            this.lblShitje.Size = new System.Drawing.Size(0, 0);
            this.lblShitje.TabIndex = 2;
            // 
            // lblHistoriaShitje
            // 
            this.lblHistoriaShitje.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblHistoriaShitje.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblHistoriaShitje.Location = new System.Drawing.Point(97, 69);
            this.lblHistoriaShitje.Name = "lblHistoriaShitje";
            this.lblHistoriaShitje.Size = new System.Drawing.Size(65, 36);
            this.lblHistoriaShitje.TabIndex = 2;
            this.lblHistoriaShitje.Text = "5000";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel3.Location = new System.Drawing.Point(3, 73);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(50, 19);
            this.metroLabel3.TabIndex = 2;
            this.metroLabel3.Text = "Shitje:";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(3, 35);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(44, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Data:";
            // 
            // lblDataSot
            // 
            this.lblDataSot.AutoSize = true;
            this.lblDataSot.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblDataSot.Location = new System.Drawing.Point(98, 35);
            this.lblDataSot.Name = "lblDataSot";
            this.lblDataSot.Size = new System.Drawing.Size(57, 19);
            this.lblDataSot.TabIndex = 2;
            this.lblDataSot.Text = "Data_st";
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
            this.cmbStatistika.Location = new System.Drawing.Point(1149, 3);
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
            // tbLive
            // 
            this.tbLive.Controls.Add(this.webBrowser1);
            this.tbLive.HorizontalScrollbarBarColor = true;
            this.tbLive.HorizontalScrollbarHighlightOnWheel = false;
            this.tbLive.HorizontalScrollbarSize = 10;
            this.tbLive.Location = new System.Drawing.Point(4, 38);
            this.tbLive.Name = "tbLive";
            this.tbLive.Size = new System.Drawing.Size(1225, 600);
            this.tbLive.TabIndex = 3;
            this.tbLive.Text = "Live";
            this.tbLive.VerticalScrollbarBarColor = true;
            this.tbLive.VerticalScrollbarHighlightOnWheel = false;
            this.tbLive.VerticalScrollbarSize = 10;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(1225, 600);
            this.webBrowser1.TabIndex = 2;
            this.webBrowser1.Url = new System.Uri(" https://www.bullionbypost.co.uk/gold-price/live-gold-price/", System.UriKind.Absolute);
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
            // lblSkaData
            // 
            this.lblSkaData.AutoSize = true;
            this.lblSkaData.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblSkaData.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblSkaData.Location = new System.Drawing.Point(876, 7);
            this.lblSkaData.Name = "lblSkaData";
            this.lblSkaData.Size = new System.Drawing.Size(152, 25);
            this.lblSkaData.TabIndex = 2;
            this.lblSkaData.Text = "Nuk ka të dhëna";
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1273, 722);
            this.ContextMenuStrip = this.CxtMenu;
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
            ((System.ComponentModel.ISupportInitialize)(this.tblMalliBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rubyDBDataSet1)).EndInit();
            this.tbHistoria.ResumeLayout(false);
            this.tbHistoria.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistoria)).EndInit();
            this.tbStatistika.ResumeLayout(false);
            this.tbStatistika.PerformLayout();
            this.tbLive.ResumeLayout(false);
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
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel lblShpenzime;
        private MetroFramework.Controls.MetroLabel lblShitje;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel lblHyrje;
        private MetroFramework.Controls.MetroComboBox cmbStatistika;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private MetroFramework.Controls.MetroTabControl metroTab;
        private MetroFramework.Controls.MetroLabel lblmShenimet;
        private MetroFramework.Controls.MetroTextBox txtbmPershkrimi;
        private RubyDBDataSet rubyDBDataSet;
        private RubyDBDataSet1 rubyDBDataSet1;
        private System.Windows.Forms.BindingSource tblMalliBindingSource;
        private RubyDBDataSet1TableAdapters.TblMalliTableAdapter tblMalliTableAdapter;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel lblHistoriaShitje;
        private MetroFramework.Controls.MetroTabPage tbLive;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.DataGridView dgvHistoria;
        private MetroFramework.Controls.MetroDateTime dtpShitje;
        private System.Windows.Forms.DataGridViewTextBoxColumn midDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn malliEmriDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn malliCmimiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataShitjesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pershkrimiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn midDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn malliEmriDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn malliCmimiDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataShitjesDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn pershkrimiDataGridViewTextBoxColumn1;
        private MetroFramework.Controls.MetroLabel lblSkaData;
    }
}

