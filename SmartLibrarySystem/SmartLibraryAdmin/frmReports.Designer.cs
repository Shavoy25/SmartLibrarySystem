namespace SmartLibraryWinForms
{
    partial class frmReports
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblHeaderTitle;
        private System.Windows.Forms.Label lblHeaderSubtitle;

        private System.Windows.Forms.Panel panelTotalBooks;
        private System.Windows.Forms.Panel panelAvailableBooks;
        private System.Windows.Forms.Panel panelBorrowedBooks;
        private System.Windows.Forms.Panel panelMembers;

        private System.Windows.Forms.Label lblTotalBooks;
        private System.Windows.Forms.Label lblAvailableBooks;
        private System.Windows.Forms.Label lblBorrowedBooks;
        private System.Windows.Forms.Label lblMembers;

        private System.Windows.Forms.Panel panelReport;
        private System.Windows.Forms.Label lblReportType;
        private System.Windows.Forms.ComboBox cboReportType;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnBack;

        private System.Windows.Forms.DataGridView dgvReports;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblHeaderTitle = new System.Windows.Forms.Label();
            this.lblHeaderSubtitle = new System.Windows.Forms.Label();

            this.panelTotalBooks = new System.Windows.Forms.Panel();
            this.panelAvailableBooks = new System.Windows.Forms.Panel();
            this.panelBorrowedBooks = new System.Windows.Forms.Panel();
            this.panelMembers = new System.Windows.Forms.Panel();

            this.lblTotalBooks = new System.Windows.Forms.Label();
            this.lblAvailableBooks = new System.Windows.Forms.Label();
            this.lblBorrowedBooks = new System.Windows.Forms.Label();
            this.lblMembers = new System.Windows.Forms.Label();

            this.panelReport = new System.Windows.Forms.Panel();
            this.lblReportType = new System.Windows.Forms.Label();
            this.cboReportType = new System.Windows.Forms.ComboBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();

            this.dgvReports = new System.Windows.Forms.DataGridView();

            this.panelHeader.SuspendLayout();
            this.panelTotalBooks.SuspendLayout();
            this.panelAvailableBooks.SuspendLayout();
            this.panelBorrowedBooks.SuspendLayout();
            this.panelMembers.SuspendLayout();
            this.panelReport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReports)).BeginInit();
            this.SuspendLayout();

            this.panelHeader.BackColor = System.Drawing.Color.Black;
            this.panelHeader.Controls.Add(this.lblHeaderTitle);
            this.panelHeader.Controls.Add(this.lblHeaderSubtitle);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Size = new System.Drawing.Size(1000, 105);

            this.lblHeaderTitle.AutoSize = true;
            this.lblHeaderTitle.Font = new System.Drawing.Font("Arial", 22F, System.Drawing.FontStyle.Bold);
            this.lblHeaderTitle.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblHeaderTitle.Location = new System.Drawing.Point(30, 22);
            this.lblHeaderTitle.Text = "View Reports";

            this.lblHeaderSubtitle.AutoSize = true;
            this.lblHeaderSubtitle.Font = new System.Drawing.Font("Arial", 10F);
            this.lblHeaderSubtitle.ForeColor = System.Drawing.Color.White;
            this.lblHeaderSubtitle.Location = new System.Drawing.Point(34, 65);
            this.lblHeaderSubtitle.Text = "View summary reports for books, members, and borrowing activity.";

            this.panelTotalBooks.BackColor = System.Drawing.Color.Black;
            this.panelTotalBooks.Controls.Add(this.lblTotalBooks);
            this.panelTotalBooks.Location = new System.Drawing.Point(30, 130);
            this.panelTotalBooks.Size = new System.Drawing.Size(220, 90);

            this.lblTotalBooks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTotalBooks.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblTotalBooks.ForeColor = System.Drawing.Color.White;
            this.lblTotalBooks.Text = "Total Books\n0";
            this.lblTotalBooks.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.panelAvailableBooks.BackColor = System.Drawing.Color.DodgerBlue;
            this.panelAvailableBooks.Controls.Add(this.lblAvailableBooks);
            this.panelAvailableBooks.Location = new System.Drawing.Point(270, 130);
            this.panelAvailableBooks.Size = new System.Drawing.Size(220, 90);

            this.lblAvailableBooks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAvailableBooks.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblAvailableBooks.ForeColor = System.Drawing.Color.White;
            this.lblAvailableBooks.Text = "Available Books\n0";
            this.lblAvailableBooks.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.panelBorrowedBooks.BackColor = System.Drawing.Color.Black;
            this.panelBorrowedBooks.Controls.Add(this.lblBorrowedBooks);
            this.panelBorrowedBooks.Location = new System.Drawing.Point(510, 130);
            this.panelBorrowedBooks.Size = new System.Drawing.Size(220, 90);

            this.lblBorrowedBooks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblBorrowedBooks.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblBorrowedBooks.ForeColor = System.Drawing.Color.White;
            this.lblBorrowedBooks.Text = "Borrowed Books\n0";
            this.lblBorrowedBooks.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.panelMembers.BackColor = System.Drawing.Color.DodgerBlue;
            this.panelMembers.Controls.Add(this.lblMembers);
            this.panelMembers.Location = new System.Drawing.Point(750, 130);
            this.panelMembers.Size = new System.Drawing.Size(220, 90);

            this.lblMembers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMembers.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblMembers.ForeColor = System.Drawing.Color.White;
            this.lblMembers.Text = "Registered Members\n0";
            this.lblMembers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.panelReport.BackColor = System.Drawing.Color.White;
            this.panelReport.Controls.Add(this.lblReportType);
            this.panelReport.Controls.Add(this.cboReportType);
            this.panelReport.Controls.Add(this.btnGenerate);
            this.panelReport.Controls.Add(this.btnBack);
            this.panelReport.Location = new System.Drawing.Point(30, 245);
            this.panelReport.Size = new System.Drawing.Size(940, 95);

            this.lblReportType.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lblReportType.Location = new System.Drawing.Point(25, 35);
            this.lblReportType.Size = new System.Drawing.Size(100, 20);
            this.lblReportType.Text = "Report Type";

            this.cboReportType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboReportType.Items.AddRange(new object[] { "All Books", "Available Books", "Borrowed Books", "Registered Members", "Overdue Books" });
            this.cboReportType.Location = new System.Drawing.Point(130, 32);
            this.cboReportType.Size = new System.Drawing.Size(260, 23);

            this.btnGenerate.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnGenerate.FlatAppearance.BorderSize = 0;
            this.btnGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerate.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.btnGenerate.ForeColor = System.Drawing.Color.White;
            this.btnGenerate.Location = new System.Drawing.Point(420, 28);
            this.btnGenerate.Size = new System.Drawing.Size(160, 35);
            this.btnGenerate.Text = "Generate Report";
            this.btnGenerate.UseVisualStyleBackColor = false;
            this.btnGenerate.Click += new System.EventHandler(this.BtnGenerate_Click);

            this.btnBack.BackColor = System.Drawing.Color.Black;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(600, 28);
            this.btnBack.Size = new System.Drawing.Size(130, 35);
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.BtnBack_Click);

            this.dgvReports.BackgroundColor = System.Drawing.Color.White;
            this.dgvReports.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReports.Columns.Add("ReportID", "Report ID");
            this.dgvReports.Columns.Add("Description", "Description");
            this.dgvReports.Columns.Add("Category", "Category");
            this.dgvReports.Columns.Add("Status", "Status");
            this.dgvReports.Columns.Add("DateGenerated", "Date Generated");
            this.dgvReports.Location = new System.Drawing.Point(30, 365);
            this.dgvReports.Size = new System.Drawing.Size(940, 235);

            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(245, 248, 255);
            this.ClientSize = new System.Drawing.Size(1000, 630);
            this.Controls.Add(this.dgvReports);
            this.Controls.Add(this.panelReport);
            this.Controls.Add(this.panelMembers);
            this.Controls.Add(this.panelBorrowedBooks);
            this.Controls.Add(this.panelAvailableBooks);
            this.Controls.Add(this.panelTotalBooks);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmReports";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Smart Library Management System - Reports";

            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelTotalBooks.ResumeLayout(false);
            this.panelAvailableBooks.ResumeLayout(false);
            this.panelBorrowedBooks.ResumeLayout(false);
            this.panelMembers.ResumeLayout(false);
            this.panelReport.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReports)).EndInit();
            this.ResumeLayout(false);
        }
    }
}
