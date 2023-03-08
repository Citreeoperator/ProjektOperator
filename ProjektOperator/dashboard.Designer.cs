namespace ProjektOperator
{
    partial class dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dashboard));
            this.pnl_taskbar = new System.Windows.Forms.Panel();
            this.lbl_programname = new System.Windows.Forms.Label();
            this.btn_minimize = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.pnl_top = new System.Windows.Forms.Panel();
            this.lbl_timeanddate = new System.Windows.Forms.Label();
            this.lbl_title = new System.Windows.Forms.Label();
            this.pnl_bot = new System.Windows.Forms.Panel();
            this.menustrip_dash = new System.Windows.Forms.MenuStrip();
            this.mainMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dashboardHomeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.reportingDashToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quarterlyReportDashboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cCTVReviewRequestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cCTVReviewRequestFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cCTVRequestDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.situationalReportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quezonOperationAndWarningOfficersSitRepToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.endorsementToolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.atimonanDRRMOfficialEndorsementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otherToolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eZCopypasterForWeatherForecastToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnl_main = new System.Windows.Forms.Panel();
            this.tmr_time = new System.Windows.Forms.Timer(this.components);
            this.pnl_taskbar.SuspendLayout();
            this.pnl_top.SuspendLayout();
            this.menustrip_dash.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_taskbar
            // 
            this.pnl_taskbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(16)))), ((int)(((byte)(15)))));
            this.pnl_taskbar.Controls.Add(this.lbl_programname);
            this.pnl_taskbar.Controls.Add(this.btn_minimize);
            this.pnl_taskbar.Controls.Add(this.btn_close);
            this.pnl_taskbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_taskbar.Location = new System.Drawing.Point(0, 0);
            this.pnl_taskbar.Name = "pnl_taskbar";
            this.pnl_taskbar.Size = new System.Drawing.Size(1920, 33);
            this.pnl_taskbar.TabIndex = 0;
            // 
            // lbl_programname
            // 
            this.lbl_programname.AutoSize = true;
            this.lbl_programname.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_programname.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_programname.Location = new System.Drawing.Point(12, 9);
            this.lbl_programname.Name = "lbl_programname";
            this.lbl_programname.Size = new System.Drawing.Size(204, 15);
            this.lbl_programname.TabIndex = 2;
            this.lbl_programname.Text = "Project OPERATOR - BlackOps Edition";
            // 
            // btn_minimize
            // 
            this.btn_minimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btn_minimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_minimize.FlatAppearance.BorderSize = 0;
            this.btn_minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_minimize.Image = ((System.Drawing.Image)(resources.GetObject("btn_minimize.Image")));
            this.btn_minimize.Location = new System.Drawing.Point(1840, 0);
            this.btn_minimize.Name = "btn_minimize";
            this.btn_minimize.Size = new System.Drawing.Size(40, 33);
            this.btn_minimize.TabIndex = 1;
            this.btn_minimize.UseVisualStyleBackColor = false;
            this.btn_minimize.Click += new System.EventHandler(this.btn_minimize_Click);
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btn_close.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Image = ((System.Drawing.Image)(resources.GetObject("btn_close.Image")));
            this.btn_close.Location = new System.Drawing.Point(1880, 0);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(40, 33);
            this.btn_close.TabIndex = 0;
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // pnl_top
            // 
            this.pnl_top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(26)))), ((int)(((byte)(36)))));
            this.pnl_top.Controls.Add(this.lbl_timeanddate);
            this.pnl_top.Controls.Add(this.lbl_title);
            this.pnl_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_top.Location = new System.Drawing.Point(0, 33);
            this.pnl_top.Name = "pnl_top";
            this.pnl_top.Size = new System.Drawing.Size(1920, 53);
            this.pnl_top.TabIndex = 1;
            // 
            // lbl_timeanddate
            // 
            this.lbl_timeanddate.AutoSize = true;
            this.lbl_timeanddate.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbl_timeanddate.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_timeanddate.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_timeanddate.Location = new System.Drawing.Point(1756, 0);
            this.lbl_timeanddate.Name = "lbl_timeanddate";
            this.lbl_timeanddate.Size = new System.Drawing.Size(164, 50);
            this.lbl_timeanddate.TabIndex = 1;
            this.lbl_timeanddate.Text = "MMMM DD, YYYY\r\nHH:MM:SS";
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbl_title.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_title.Location = new System.Drawing.Point(0, 0);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(409, 50);
            this.lbl_title.TabIndex = 0;
            this.lbl_title.Text = "Command, Control and Coordination Center\r\nAtimonan, Quezon";
            // 
            // pnl_bot
            // 
            this.pnl_bot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(26)))), ((int)(((byte)(36)))));
            this.pnl_bot.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_bot.Location = new System.Drawing.Point(0, 1012);
            this.pnl_bot.Name = "pnl_bot";
            this.pnl_bot.Size = new System.Drawing.Size(1920, 28);
            this.pnl_bot.TabIndex = 2;
            // 
            // menustrip_dash
            // 
            this.menustrip_dash.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(62)))), ((int)(((byte)(74)))));
            this.menustrip_dash.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainMenuToolStripMenuItem,
            this.cCTVReviewRequestToolStripMenuItem,
            this.situationalReportsToolStripMenuItem,
            this.endorsementToolsToolStripMenuItem,
            this.otherToolsToolStripMenuItem});
            this.menustrip_dash.Location = new System.Drawing.Point(0, 86);
            this.menustrip_dash.Name = "menustrip_dash";
            this.menustrip_dash.Size = new System.Drawing.Size(1920, 24);
            this.menustrip_dash.TabIndex = 3;
            this.menustrip_dash.Text = "menuStrip1";
            // 
            // mainMenuToolStripMenuItem
            // 
            this.mainMenuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dashboardHomeToolStripMenuItem,
            this.toolStripSeparator1,
            this.reportingDashToolStripMenuItem,
            this.quarterlyReportDashboardToolStripMenuItem,
            this.toolStripSeparator2,
            this.aboutToolStripMenuItem});
            this.mainMenuToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.mainMenuToolStripMenuItem.Name = "mainMenuToolStripMenuItem";
            this.mainMenuToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.mainMenuToolStripMenuItem.Text = "Main Menu";
            // 
            // dashboardHomeToolStripMenuItem
            // 
            this.dashboardHomeToolStripMenuItem.Name = "dashboardHomeToolStripMenuItem";
            this.dashboardHomeToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.dashboardHomeToolStripMenuItem.Text = "Dashboard Home";
            this.dashboardHomeToolStripMenuItem.Click += new System.EventHandler(this.dashboardHomeToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(218, 6);
            // 
            // reportingDashToolStripMenuItem
            // 
            this.reportingDashToolStripMenuItem.Name = "reportingDashToolStripMenuItem";
            this.reportingDashToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.reportingDashToolStripMenuItem.Text = "Reporting Dashboard";
            this.reportingDashToolStripMenuItem.Click += new System.EventHandler(this.reportingDashToolStripMenuItem_Click);
            // 
            // quarterlyReportDashboardToolStripMenuItem
            // 
            this.quarterlyReportDashboardToolStripMenuItem.Name = "quarterlyReportDashboardToolStripMenuItem";
            this.quarterlyReportDashboardToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.quarterlyReportDashboardToolStripMenuItem.Text = "Quarterly Report Dashboard";
            this.quarterlyReportDashboardToolStripMenuItem.Click += new System.EventHandler(this.quarterlyReportDashboardToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(218, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // cCTVReviewRequestToolStripMenuItem
            // 
            this.cCTVReviewRequestToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cCTVReviewRequestFormToolStripMenuItem,
            this.cCTVRequestDatabaseToolStripMenuItem});
            this.cCTVReviewRequestToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.cCTVReviewRequestToolStripMenuItem.Name = "cCTVReviewRequestToolStripMenuItem";
            this.cCTVReviewRequestToolStripMenuItem.Size = new System.Drawing.Size(133, 20);
            this.cCTVReviewRequestToolStripMenuItem.Text = "CCTV Review Request";
            // 
            // cCTVReviewRequestFormToolStripMenuItem
            // 
            this.cCTVReviewRequestFormToolStripMenuItem.Name = "cCTVReviewRequestFormToolStripMenuItem";
            this.cCTVReviewRequestFormToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.cCTVReviewRequestFormToolStripMenuItem.Text = "CCTV Review Request Form";
            this.cCTVReviewRequestFormToolStripMenuItem.Click += new System.EventHandler(this.cCTVReviewRequestFormToolStripMenuItem_Click);
            // 
            // cCTVRequestDatabaseToolStripMenuItem
            // 
            this.cCTVRequestDatabaseToolStripMenuItem.Name = "cCTVRequestDatabaseToolStripMenuItem";
            this.cCTVRequestDatabaseToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.cCTVRequestDatabaseToolStripMenuItem.Text = "CCTV Request Database";
            this.cCTVRequestDatabaseToolStripMenuItem.Click += new System.EventHandler(this.cCTVRequestDatabaseToolStripMenuItem_Click);
            // 
            // situationalReportsToolStripMenuItem
            // 
            this.situationalReportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quezonOperationAndWarningOfficersSitRepToolStripMenuItem});
            this.situationalReportsToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.situationalReportsToolStripMenuItem.Name = "situationalReportsToolStripMenuItem";
            this.situationalReportsToolStripMenuItem.Size = new System.Drawing.Size(118, 20);
            this.situationalReportsToolStripMenuItem.Text = "Situational Reports";
            // 
            // quezonOperationAndWarningOfficersSitRepToolStripMenuItem
            // 
            this.quezonOperationAndWarningOfficersSitRepToolStripMenuItem.Name = "quezonOperationAndWarningOfficersSitRepToolStripMenuItem";
            this.quezonOperationAndWarningOfficersSitRepToolStripMenuItem.Size = new System.Drawing.Size(325, 22);
            this.quezonOperationAndWarningOfficersSitRepToolStripMenuItem.Text = "Quezon Operation and Warning Officer\'s SitRep";
            this.quezonOperationAndWarningOfficersSitRepToolStripMenuItem.Click += new System.EventHandler(this.quezonOperationAndWarningOfficersSitRepToolStripMenuItem_Click);
            // 
            // endorsementToolsToolStripMenuItem
            // 
            this.endorsementToolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.atimonanDRRMOfficialEndorsementToolStripMenuItem});
            this.endorsementToolsToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.endorsementToolsToolStripMenuItem.Name = "endorsementToolsToolStripMenuItem";
            this.endorsementToolsToolStripMenuItem.Size = new System.Drawing.Size(119, 20);
            this.endorsementToolsToolStripMenuItem.Text = "Endorsement Tools";
            // 
            // atimonanDRRMOfficialEndorsementToolStripMenuItem
            // 
            this.atimonanDRRMOfficialEndorsementToolStripMenuItem.Name = "atimonanDRRMOfficialEndorsementToolStripMenuItem";
            this.atimonanDRRMOfficialEndorsementToolStripMenuItem.Size = new System.Drawing.Size(277, 22);
            this.atimonanDRRMOfficialEndorsementToolStripMenuItem.Text = "Atimonan DRRM Official Endorsement";
            this.atimonanDRRMOfficialEndorsementToolStripMenuItem.Click += new System.EventHandler(this.atimonanDRRMOfficialEndorsementToolStripMenuItem_Click);
            // 
            // otherToolsToolStripMenuItem
            // 
            this.otherToolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eZCopypasterForWeatherForecastToolStripMenuItem});
            this.otherToolsToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.otherToolsToolStripMenuItem.Name = "otherToolsToolStripMenuItem";
            this.otherToolsToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.otherToolsToolStripMenuItem.Text = "Other tools";
            // 
            // eZCopypasterForWeatherForecastToolStripMenuItem
            // 
            this.eZCopypasterForWeatherForecastToolStripMenuItem.Name = "eZCopypasterForWeatherForecastToolStripMenuItem";
            this.eZCopypasterForWeatherForecastToolStripMenuItem.Size = new System.Drawing.Size(262, 22);
            this.eZCopypasterForWeatherForecastToolStripMenuItem.Text = "EZ Copypaster for Weather Forecast";
            this.eZCopypasterForWeatherForecastToolStripMenuItem.Click += new System.EventHandler(this.eZCopypasterForWeatherForecastToolStripMenuItem_Click);
            // 
            // pnl_main
            // 
            this.pnl_main.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(79)))));
            this.pnl_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_main.Location = new System.Drawing.Point(0, 110);
            this.pnl_main.Name = "pnl_main";
            this.pnl_main.Size = new System.Drawing.Size(1920, 902);
            this.pnl_main.TabIndex = 4;
            // 
            // tmr_time
            // 
            this.tmr_time.Enabled = true;
            this.tmr_time.Tick += new System.EventHandler(this.tmr_time_Tick);
            // 
            // dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1920, 1040);
            this.Controls.Add(this.pnl_main);
            this.Controls.Add(this.menustrip_dash);
            this.Controls.Add(this.pnl_top);
            this.Controls.Add(this.pnl_bot);
            this.Controls.Add(this.pnl_taskbar);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menustrip_dash;
            this.MaximizeBox = false;
            this.Name = "dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Project Operator";
            this.Load += new System.EventHandler(this.dashboard_Load);
            this.pnl_taskbar.ResumeLayout(false);
            this.pnl_taskbar.PerformLayout();
            this.pnl_top.ResumeLayout(false);
            this.pnl_top.PerformLayout();
            this.menustrip_dash.ResumeLayout(false);
            this.menustrip_dash.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_taskbar;
        private System.Windows.Forms.Panel pnl_top;
        private System.Windows.Forms.Panel pnl_bot;
        private System.Windows.Forms.MenuStrip menustrip_dash;
        private System.Windows.Forms.ToolStripMenuItem mainMenuToolStripMenuItem;
        private System.Windows.Forms.Panel pnl_main;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_minimize;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Label lbl_programname;
        private System.Windows.Forms.Label lbl_timeanddate;
        private System.Windows.Forms.ToolStripMenuItem cCTVReviewRequestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem situationalReportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem endorsementToolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem otherToolsToolStripMenuItem;
        private System.Windows.Forms.Timer tmr_time;
        private System.Windows.Forms.ToolStripMenuItem dashboardHomeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cCTVReviewRequestFormToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cCTVRequestDatabaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem reportingDashToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quarterlyReportDashboardToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quezonOperationAndWarningOfficersSitRepToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem atimonanDRRMOfficialEndorsementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eZCopypasterForWeatherForecastToolStripMenuItem;
    }
}