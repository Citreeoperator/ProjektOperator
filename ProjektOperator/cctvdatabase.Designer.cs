namespace ProjektOperator
{
    partial class cctvdatabase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cctvdatabase));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnl_top = new System.Windows.Forms.Panel();
            this.contextMenu_database = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.drop_searchfilter = new System.Windows.Forms.ComboBox();
            this.lbl_search = new System.Windows.Forms.Label();
            this.btn_search = new System.Windows.Forms.Button();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.lbl_title = new System.Windows.Forms.Label();
            this.dataGridReports = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnl_top.SuspendLayout();
            this.contextMenu_database.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridReports)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_top
            // 
            this.pnl_top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(26)))), ((int)(((byte)(36)))));
            this.pnl_top.ContextMenuStrip = this.contextMenu_database;
            this.pnl_top.Controls.Add(this.drop_searchfilter);
            this.pnl_top.Controls.Add(this.lbl_search);
            this.pnl_top.Controls.Add(this.btn_search);
            this.pnl_top.Controls.Add(this.txt_search);
            this.pnl_top.Controls.Add(this.lbl_title);
            this.pnl_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_top.Location = new System.Drawing.Point(0, 0);
            this.pnl_top.Name = "pnl_top";
            this.pnl_top.Size = new System.Drawing.Size(1920, 48);
            this.pnl_top.TabIndex = 0;
            // 
            // contextMenu_database
            // 
            this.contextMenu_database.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshToolStripMenuItem});
            this.contextMenu_database.Name = "contextMenu_database";
            this.contextMenu_database.Size = new System.Drawing.Size(114, 26);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.refreshToolStripMenuItem.Text = "Refresh";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // drop_searchfilter
            // 
            this.drop_searchfilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.drop_searchfilter.FormattingEnabled = true;
            this.drop_searchfilter.Items.AddRange(new object[] {
            "Case Number",
            "Recorded Date",
            "First Name",
            "Last Name",
            "Address",
            "Date of Incident",
            "Type of Incident",
            "Location of Incident",
            "Barangay",
            "Camera",
            "Accompanied by",
            "Type of Request",
            "Outcome of the Request",
            "Released by",
            "Status"});
            this.drop_searchfilter.Location = new System.Drawing.Point(1410, 12);
            this.drop_searchfilter.Name = "drop_searchfilter";
            this.drop_searchfilter.Size = new System.Drawing.Size(177, 21);
            this.drop_searchfilter.TabIndex = 1;
            // 
            // lbl_search
            // 
            this.lbl_search.AutoSize = true;
            this.lbl_search.Location = new System.Drawing.Point(1360, 18);
            this.lbl_search.Name = "lbl_search";
            this.lbl_search.Size = new System.Drawing.Size(44, 13);
            this.lbl_search.TabIndex = 9;
            this.lbl_search.Text = "Search:";
            // 
            // btn_search
            // 
            this.btn_search.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_search.FlatAppearance.BorderSize = 0;
            this.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_search.Image = ((System.Drawing.Image)(resources.GetObject("btn_search.Image")));
            this.btn_search.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_search.Location = new System.Drawing.Point(1766, 0);
            this.btn_search.Name = "btn_search";
            this.btn_search.Padding = new System.Windows.Forms.Padding(5, 0, 15, 0);
            this.btn_search.Size = new System.Drawing.Size(154, 48);
            this.btn_search.TabIndex = 3;
            this.btn_search.Text = "Search";
            this.btn_search.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(1593, 12);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(167, 22);
            this.txt_search.TabIndex = 2;
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.Location = new System.Drawing.Point(41, 9);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(244, 30);
            this.lbl_title.TabIndex = 6;
            this.lbl_title.Text = "CCTV Request Database";
            // 
            // dataGridReports
            // 
            this.dataGridReports.AllowUserToAddRows = false;
            this.dataGridReports.AllowUserToDeleteRows = false;
            this.dataGridReports.AllowUserToResizeColumns = false;
            this.dataGridReports.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(66)))), ((int)(((byte)(88)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(142)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridReports.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridReports.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridReports.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(79)))));
            this.dataGridReports.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(78)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(87)))), ((int)(((byte)(122)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridReports.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridReports.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridReports.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11,
            this.Column12,
            this.Column13,
            this.Column14,
            this.Column15,
            this.Column16,
            this.Column17,
            this.Column18,
            this.Column19,
            this.Column20,
            this.Column21});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(78)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(142)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridReports.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridReports.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridReports.Location = new System.Drawing.Point(0, 48);
            this.dataGridReports.Name = "dataGridReports";
            this.dataGridReports.ReadOnly = true;
            this.dataGridReports.RowHeadersVisible = false;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridReports.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridReports.Size = new System.Drawing.Size(1920, 854);
            this.dataGridReports.TabIndex = 11;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "caseno";
            this.Column1.HeaderText = "Case No";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 69;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "recordeddate";
            this.Column2.HeaderText = "Date Recorded";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 99;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "lname";
            this.Column3.HeaderText = "Last Name";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 78;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "fname";
            this.Column4.HeaderText = "First Name";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 79;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "officeorg";
            this.Column5.HeaderText = "Office/Organization";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Visible = false;
            this.Column5.Width = 135;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "address_r";
            this.Column6.HeaderText = "Address";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 73;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "contactno";
            this.Column7.HeaderText = "Contact No";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 83;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "emailadd";
            this.Column8.HeaderText = "Email Address";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Visible = false;
            this.Column8.Width = 95;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "dateofincident";
            this.Column9.HeaderText = "Date of Incident";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Width = 106;
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "timeofincident";
            this.Column10.HeaderText = "Time of Incident";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            this.Column10.Width = 106;
            // 
            // Column11
            // 
            this.Column11.DataPropertyName = "typeofincident";
            this.Column11.HeaderText = "Type of Incident";
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            this.Column11.Width = 105;
            // 
            // Column12
            // 
            this.Column12.DataPropertyName = "locationofincident";
            this.Column12.HeaderText = "Location of the Incident";
            this.Column12.Name = "Column12";
            this.Column12.ReadOnly = true;
            this.Column12.Width = 104;
            // 
            // Column13
            // 
            this.Column13.DataPropertyName = "barangay";
            this.Column13.HeaderText = "Barangay";
            this.Column13.Name = "Column13";
            this.Column13.ReadOnly = true;
            this.Column13.Width = 79;
            // 
            // Column14
            // 
            this.Column14.DataPropertyName = "camera";
            this.Column14.HeaderText = "Camera";
            this.Column14.Name = "Column14";
            this.Column14.ReadOnly = true;
            this.Column14.Width = 70;
            // 
            // Column15
            // 
            this.Column15.DataPropertyName = "accompaniedby";
            this.Column15.HeaderText = "Accompanied by";
            this.Column15.Name = "Column15";
            this.Column15.ReadOnly = true;
            this.Column15.Width = 106;
            // 
            // Column16
            // 
            this.Column16.DataPropertyName = "typeofrequest";
            this.Column16.HeaderText = "Type of Request";
            this.Column16.Name = "Column16";
            this.Column16.ReadOnly = true;
            this.Column16.Width = 105;
            // 
            // Column17
            // 
            this.Column17.DataPropertyName = "outcomeofreq";
            this.Column17.HeaderText = "Outcome of the Request";
            this.Column17.Name = "Column17";
            this.Column17.ReadOnly = true;
            this.Column17.Width = 106;
            // 
            // Column18
            // 
            this.Column18.DataPropertyName = "additionalinfo";
            this.Column18.HeaderText = "Additional Information";
            this.Column18.Name = "Column18";
            this.Column18.ReadOnly = true;
            this.Column18.Visible = false;
            this.Column18.Width = 137;
            // 
            // Column19
            // 
            this.Column19.DataPropertyName = "remarks";
            this.Column19.HeaderText = "Remarks";
            this.Column19.Name = "Column19";
            this.Column19.ReadOnly = true;
            this.Column19.Visible = false;
            this.Column19.Width = 75;
            // 
            // Column20
            // 
            this.Column20.DataPropertyName = "releasedby";
            this.Column20.HeaderText = "Released/Reviewed by";
            this.Column20.Name = "Column20";
            this.Column20.ReadOnly = true;
            this.Column20.Width = 133;
            // 
            // Column21
            // 
            this.Column21.DataPropertyName = "status";
            this.Column21.HeaderText = "Status";
            this.Column21.Name = "Column21";
            this.Column21.ReadOnly = true;
            this.Column21.Width = 64;
            // 
            // cctvdatabase
            // 
            this.AcceptButton = this.btn_search;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(79)))));
            this.ClientSize = new System.Drawing.Size(1920, 902);
            this.Controls.Add(this.dataGridReports);
            this.Controls.Add(this.pnl_top);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "cctvdatabase";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "cctvdatabase";
            this.Load += new System.EventHandler(this.cctvdatabase_Load);
            this.pnl_top.ResumeLayout(false);
            this.pnl_top.PerformLayout();
            this.contextMenu_database.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridReports)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_top;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Label lbl_search;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.ComboBox drop_searchfilter;
        private System.Windows.Forms.DataGridView dataGridReports;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column14;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column15;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column16;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column17;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column18;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column19;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column20;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column21;
        private System.Windows.Forms.ContextMenuStrip contextMenu_database;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
    }
}