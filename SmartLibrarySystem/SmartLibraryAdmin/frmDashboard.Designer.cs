namespace SmartLibraryWinForms
{
    partial class frmDashboard
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Button btnManageBooks;
        private System.Windows.Forms.Button btnManageMembers;
        private System.Windows.Forms.Button btnBorrowReturn;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnExit;

        private System.Windows.Forms.Label lblBooks;
        private System.Windows.Forms.Label lblMembers;
        private System.Windows.Forms.Label lblBorrowed;

        private System.Windows.Forms.Panel panelBooks;
        private System.Windows.Forms.Panel panelMembers;
        private System.Windows.Forms.Panel panelBorrowed;

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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();

            this.panelMain = new System.Windows.Forms.Panel();
            this.btnManageBooks = new System.Windows.Forms.Button();
            this.btnManageMembers = new System.Windows.Forms.Button();
            this.btnBorrowReturn = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();

            this.panelBooks = new System.Windows.Forms.Panel();
            this.panelMembers = new System.Windows.Forms.Panel();
            this.panelBorrowed = new System.Windows.Forms.Panel();

            this.lblBooks = new System.Windows.Forms.Label();
            this.lblMembers = new System.Windows.Forms.Label();
            this.lblBorrowed = new System.Windows.Forms.Label();

            this.panelHeader.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.panelBooks.SuspendLayout();
            this.panelMembers.SuspendLayout();
            this.panelBorrowed.SuspendLayout();
            this.SuspendLayout();

            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.Black;
            this.panelHeader.Controls.Add(this.lblTitle);
            this.panelHeader.Controls.Add(this.lblSubtitle);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(900, 120);
            this.panelHeader.TabIndex = 0;

            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblTitle.Location = new System.Drawing.Point(35, 25);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(465, 37);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Smart Library Dashboard";

            // 
            // lblSubtitle
            // 
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Font = new System.Drawing.Font("Arial", 11F);
            this.lblSubtitle.ForeColor = System.Drawing.Color.White;
            this.lblSubtitle.Location = new System.Drawing.Point(39, 72);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(442, 17);
            this.lblSubtitle.TabIndex = 1;
            this.lblSubtitle.Text = "Welcome Librarian. Manage books, members, borrowing, and reports.";

            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.White;
            this.panelMain.Controls.Add(this.panelBooks);
            this.panelMain.Controls.Add(this.panelMembers);
            this.panelMain.Controls.Add(this.panelBorrowed);

            this.panelMain.Controls.Add(this.btnManageBooks);
            this.panelMain.Controls.Add(this.btnManageMembers);
            this.panelMain.Controls.Add(this.btnBorrowReturn);
            this.panelMain.Controls.Add(this.btnReports);
            this.panelMain.Controls.Add(this.btnLogout);
            this.panelMain.Controls.Add(this.btnExit);
            this.panelMain.Location = new System.Drawing.Point(40, 155);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(820, 390);
            this.panelMain.TabIndex = 1;

            // 
            // panelBooks
            // 
            this.panelBooks.BackColor = System.Drawing.Color.Black;
            this.panelBooks.Controls.Add(this.lblBooks);
            this.panelBooks.Location = new System.Drawing.Point(35, 30);
            this.panelBooks.Name = "panelBooks";
            this.panelBooks.Size = new System.Drawing.Size(230, 90);
            this.panelBooks.TabIndex = 0;

            // 
            // lblBooks
            // 
            this.lblBooks.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblBooks.ForeColor = System.Drawing.Color.White;
            this.lblBooks.Location = new System.Drawing.Point(15, 15);
            this.lblBooks.Name = "lblBooks";
            this.lblBooks.Size = new System.Drawing.Size(200, 60);
            this.lblBooks.TabIndex = 0;
            this.lblBooks.Text = "Total Books\r\n0";
            this.lblBooks.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // 
            // panelMembers
            // 
            this.panelMembers.BackColor = System.Drawing.Color.DodgerBlue;
            this.panelMembers.Controls.Add(this.lblMembers);
            this.panelMembers.Location = new System.Drawing.Point(295, 30);
            this.panelMembers.Name = "panelMembers";
            this.panelMembers.Size = new System.Drawing.Size(230, 90);
            this.panelMembers.TabIndex = 1;

            // 
            // lblMembers
            // 
            this.lblMembers.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblMembers.ForeColor = System.Drawing.Color.White;
            this.lblMembers.Location = new System.Drawing.Point(15, 15);
            this.lblMembers.Name = "lblMembers";
            this.lblMembers.Size = new System.Drawing.Size(200, 60);
            this.lblMembers.TabIndex = 0;
            this.lblMembers.Text = "Registered Members\r\n0";
            this.lblMembers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // 
            // panelBorrowed
            // 
            this.panelBorrowed.BackColor = System.Drawing.Color.Black;
            this.panelBorrowed.Controls.Add(this.lblBorrowed);
            this.panelBorrowed.Location = new System.Drawing.Point(555, 30);
            this.panelBorrowed.Name = "panelBorrowed";
            this.panelBorrowed.Size = new System.Drawing.Size(230, 90);
            this.panelBorrowed.TabIndex = 2;

            // 
            // lblBorrowed
            // 
            this.lblBorrowed.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblBorrowed.ForeColor = System.Drawing.Color.White;
            this.lblBorrowed.Location = new System.Drawing.Point(15, 15);
            this.lblBorrowed.Name = "lblBorrowed";
            this.lblBorrowed.Size = new System.Drawing.Size(200, 60);
            this.lblBorrowed.TabIndex = 0;
            this.lblBorrowed.Text = "Borrowed Books\r\n0";
            this.lblBorrowed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // 
            // btnManageBooks
            // 
            this.btnManageBooks.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnManageBooks.FlatAppearance.BorderSize = 0;
            this.btnManageBooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageBooks.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.btnManageBooks.ForeColor = System.Drawing.Color.White;
            this.btnManageBooks.Location = new System.Drawing.Point(60, 165);
            this.btnManageBooks.Name = "btnManageBooks";
            this.btnManageBooks.Size = new System.Drawing.Size(210, 55);
            this.btnManageBooks.TabIndex = 3;
            this.btnManageBooks.Text = "Manage Books";
            this.btnManageBooks.UseVisualStyleBackColor = false;
            this.btnManageBooks.Click += new System.EventHandler(this.btnManageBooks_Click);

            // 
            // btnManageMembers
            // 
            this.btnManageMembers.BackColor = System.Drawing.Color.Black;
            this.btnManageMembers.FlatAppearance.BorderSize = 0;
            this.btnManageMembers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageMembers.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.btnManageMembers.ForeColor = System.Drawing.Color.White;
            this.btnManageMembers.Location = new System.Drawing.Point(305, 165);
            this.btnManageMembers.Name = "btnManageMembers";
            this.btnManageMembers.Size = new System.Drawing.Size(210, 55);
            this.btnManageMembers.TabIndex = 4;
            this.btnManageMembers.Text = "Manage Members";
            this.btnManageMembers.UseVisualStyleBackColor = false;
            this.btnManageMembers.Click += new System.EventHandler(this.btnManageMembers_Click);

            // 
            // btnBorrowReturn
            // 
            this.btnBorrowReturn.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnBorrowReturn.FlatAppearance.BorderSize = 0;
            this.btnBorrowReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrowReturn.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.btnBorrowReturn.ForeColor = System.Drawing.Color.White;
            this.btnBorrowReturn.Location = new System.Drawing.Point(550, 165);
            this.btnBorrowReturn.Name = "btnBorrowReturn";
            this.btnBorrowReturn.Size = new System.Drawing.Size(210, 55);
            this.btnBorrowReturn.TabIndex = 5;
            this.btnBorrowReturn.Text = "Borrow / Return";
            this.btnBorrowReturn.UseVisualStyleBackColor = false;
            this.btnBorrowReturn.Click += new System.EventHandler(this.btnBorrowReturn_Click);

            // 
            // btnReports
            // 
            this.btnReports.BackColor = System.Drawing.Color.Black;
            this.btnReports.FlatAppearance.BorderSize = 0;
            this.btnReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReports.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.btnReports.ForeColor = System.Drawing.Color.White;
            this.btnReports.Location = new System.Drawing.Point(60, 255);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(210, 55);
            this.btnReports.TabIndex = 6;
            this.btnReports.Text = "Reports";
            this.btnReports.UseVisualStyleBackColor = false;
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);

            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(305, 255);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(210, 55);
            this.btnLogout.TabIndex = 7;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);

            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Black;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(550, 255);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(210, 55);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);

            // 
            // frmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(245, 248, 255);
            this.ClientSize = new System.Drawing.Size(900, 590);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Smart Library Management System - Dashboard";

            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();

            this.panelMain.ResumeLayout(false);

            this.panelBooks.ResumeLayout(false);
            this.panelMembers.ResumeLayout(false);
            this.panelBorrowed.ResumeLayout(false);

            this.ResumeLayout(false);
        }
    }
}