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
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.lblDataSot = new System.Windows.Forms.Label();
            this.btnShto = new System.Windows.Forms.Button();
            this.btnPdf = new System.Windows.Forms.Button();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.File = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historikuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historiaePergjithshmeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statistikaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kameraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.txtCmimi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbMalli = new System.Windows.Forms.ComboBox();
            this.gbShitja = new System.Windows.Forms.GroupBox();
            this.menuStrip.SuspendLayout();
            this.gbShitja.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtpData
            // 
            this.dtpData.AllowDrop = true;
            this.dtpData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpData.CalendarFont = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpData.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtpData.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpData.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpData.Location = new System.Drawing.Point(718, 27);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(178, 31);
            this.dtpData.TabIndex = 0;
            // 
            // lblDataSot
            // 
            this.lblDataSot.AutoSize = true;
            this.lblDataSot.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataSot.Location = new System.Drawing.Point(27, 39);
            this.lblDataSot.Name = "lblDataSot";
            this.lblDataSot.Size = new System.Drawing.Size(101, 23);
            this.lblDataSot.TabIndex = 1;
            this.lblDataSot.Text = "Malli :";
            // 
            // btnShto
            // 
            this.btnShto.Location = new System.Drawing.Point(286, 39);
            this.btnShto.Name = "btnShto";
            this.btnShto.Size = new System.Drawing.Size(75, 23);
            this.btnShto.TabIndex = 3;
            this.btnShto.Text = "Shto";
            this.btnShto.UseVisualStyleBackColor = true;
            this.btnShto.Click += new System.EventHandler(this.btnShto_Click);
            // 
            // btnPdf
            // 
            this.btnPdf.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPdf.Location = new System.Drawing.Point(821, 438);
            this.btnPdf.Name = "btnPdf";
            this.btnPdf.Size = new System.Drawing.Size(75, 23);
            this.btnPdf.TabIndex = 4;
            this.btnPdf.Text = "PDF";
            this.btnPdf.UseVisualStyleBackColor = true;
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.File,
            this.historikuToolStripMenuItem,
            this.kameraToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip.Size = new System.Drawing.Size(908, 24);
            this.menuStrip.TabIndex = 5;
            this.menuStrip.Text = "menuStrip";
            // 
            // File
            // 
            this.File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logOutToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.File.Name = "File";
            this.File.Size = new System.Drawing.Size(37, 20);
            this.File.Text = "File";
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.logOutToolStripMenuItem.Text = "Log out";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.closeToolStripMenuItem.Text = "Close ";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // historikuToolStripMenuItem
            // 
            this.historikuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.historiaePergjithshmeToolStripMenuItem,
            this.statistikaToolStripMenuItem});
            this.historikuToolStripMenuItem.Name = "historikuToolStripMenuItem";
            this.historikuToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.historikuToolStripMenuItem.Text = "Historiku";
            // 
            // historiaePergjithshmeToolStripMenuItem
            // 
            this.historiaePergjithshmeToolStripMenuItem.Name = "historiaePergjithshmeToolStripMenuItem";
            this.historiaePergjithshmeToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.historiaePergjithshmeToolStripMenuItem.Text = "Historia e Pergjithshme";
            // 
            // statistikaToolStripMenuItem
            // 
            this.statistikaToolStripMenuItem.Name = "statistikaToolStripMenuItem";
            this.statistikaToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.statistikaToolStripMenuItem.Text = "Statistika";
            // 
            // kameraToolStripMenuItem
            // 
            this.kameraToolStripMenuItem.Name = "kameraToolStripMenuItem";
            this.kameraToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.kameraToolStripMenuItem.Text = "Kamera";
            // 
            // notifyIcon
            // 
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "Ruby";
            this.notifyIcon.Visible = true;
            this.notifyIcon.Click += new System.EventHandler(this.notifyIcon_Click);
            // 
            // txtCmimi
            // 
            this.txtCmimi.Location = new System.Drawing.Point(134, 65);
            this.txtCmimi.Name = "txtCmimi";
            this.txtCmimi.Size = new System.Drawing.Size(122, 20);
            this.txtCmimi.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "Cmimi :";
            // 
            // cmbMalli
            // 
            this.cmbMalli.FormattingEnabled = true;
            this.cmbMalli.Items.AddRange(new object[] {
            "Unazë",
            "Hallhalle",
            "Qafore",
            "Komplet",
            "Riparim",
            "Emer",
            "Gurrë"});
            this.cmbMalli.Location = new System.Drawing.Point(135, 40);
            this.cmbMalli.Name = "cmbMalli";
            this.cmbMalli.Size = new System.Drawing.Size(121, 21);
            this.cmbMalli.TabIndex = 8;
            // 
            // gbShitja
            // 
            this.gbShitja.Controls.Add(this.cmbMalli);
            this.gbShitja.Controls.Add(this.txtCmimi);
            this.gbShitja.Controls.Add(this.label1);
            this.gbShitja.Controls.Add(this.btnShto);
            this.gbShitja.Controls.Add(this.lblDataSot);
            this.gbShitja.Location = new System.Drawing.Point(12, 27);
            this.gbShitja.Name = "gbShitja";
            this.gbShitja.Size = new System.Drawing.Size(395, 120);
            this.gbShitja.TabIndex = 9;
            this.gbShitja.TabStop = false;
            this.gbShitja.Text = "Shitja";
            this.gbShitja.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(908, 490);
            this.Controls.Add(this.gbShitja);
            this.Controls.Add(this.btnPdf);
            this.Controls.Add(this.dtpData);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Name = "Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ruby";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.gbShitja.ResumeLayout(false);
            this.gbShitja.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.Label lblDataSot;
        private System.Windows.Forms.Button btnShto;
        private System.Windows.Forms.Button btnPdf;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem File;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ToolStripMenuItem historikuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historiaePergjithshmeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statistikaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kameraToolStripMenuItem;
        private System.Windows.Forms.TextBox txtCmimi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbMalli;
        private System.Windows.Forms.GroupBox gbShitja;
    }
}

