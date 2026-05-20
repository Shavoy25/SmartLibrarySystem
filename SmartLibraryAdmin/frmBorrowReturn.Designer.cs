namespace SmartLibraryWinForms
{
    partial class frmBorrowReturn
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblHeaderTitle;
        private System.Windows.Forms.Label lblHeaderSubtitle;
        private System.Windows.Forms.Panel panelForm;

        private System.Windows.Forms.Label lblRecordID;
        private System.Windows.Forms.Label lblTransaction;
        private System.Windows.Forms.Label lblMemberID;
        private System.Windows.Forms.Label lblMemberName;
        private System.Windows.Forms.Label lblBookID;
        private System.Windows.Forms.Label lblBookTitle;
        private System.Windows.Forms.Label lblBorrowDate;
        private System.Windows.Forms.Label lblDueDate;
        private System.Windows.Forms.Label lblReturnDate;
        private System.Windows.Forms.Label lblStatus;

        private System.Windows.Forms.TextBox txtRecordID;
        private System.Windows.Forms.TextBox txtMemberID;
        private System.Windows.Forms.TextBox txtMemberName;
        private System.Windows.Forms.TextBox txtBookID;
        private System.Windows.Forms.TextBox txtBookTitle;

        private System.Windows.Forms.ComboBox cboTransactionType;
        private System.Windows.Forms.ComboBox cboStatus;

        private System.Windows.Forms.DateTimePicker dtpBorrowDate;
        private System.Windows.Forms.DateTimePicker dtpDueDate;
        private System.Windows.Forms.DateTimePicker dtpReturnDate;

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnBack;

        private System.Windows.Forms.DataGridView dgvTransactions;

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
            this.panelForm = new System.Windows.Forms.Panel();

            this.lblRecordID = new System.Windows.Forms.Label();
            this.lblTransaction = new System.Windows.Forms.Label();
            this.lblMemberID = new System.Windows.Forms.Label();
            this.lblMemberName = new System.Windows.Forms.Label();
            this.lblBookID = new System.Windows.Forms.Label();
            this.lblBookTitle = new System.Windows.Forms.Label();
            this.lblBorrowDate = new System.Windows.Forms.Label();
            this.lblDueDate = new System.Windows.Forms.Label();
            this.lblReturnDate = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();

            this.txtRecordID = new System.Windows.Forms.TextBox();
            this.txtMemberID = new System.Windows.Forms.TextBox();
            this.txtMemberName = new System.Windows.Forms.TextBox();
            this.txtBookID = new System.Windows.Forms.TextBox();
            this.txtBookTitle = new System.Windows.Forms.TextBox();

            this.cboTransactionType = new System.Windows.Forms.ComboBox();
            this.cboStatus = new System.Windows.Forms.ComboBox();

            this.dtpBorrowDate = new System.Windows.Forms.DateTimePicker();
            this.dtpDueDate = new System.Windows.Forms.DateTimePicker();
            this.dtpReturnDate = new System.Windows.Forms.DateTimePicker();

            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();

            this.dgvTransactions = new System.Windows.Forms.DataGridView();

            this.panelHeader.SuspendLayout();
            this.panelForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransactions)).BeginInit();
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
            this.lblHeaderTitle.Text = "Borrow / Return Books";

            this.lblHeaderSubtitle.AutoSize = true;
            this.lblHeaderSubtitle.Font = new System.Drawing.Font("Arial", 10F);
            this.lblHeaderSubtitle.ForeColor = System.Drawing.Color.White;
            this.lblHeaderSubtitle.Location = new System.Drawing.Point(34, 65);
            this.lblHeaderSubtitle.Text = "Record book borrowing and return transactions.";

            this.panelForm.BackColor = System.Drawing.Color.White;
            this.panelForm.Location = new System.Drawing.Point(30, 130);
            this.panelForm.Size = new System.Drawing.Size(940, 260);

            this.panelForm.Controls.Add(this.lblRecordID);
            this.panelForm.Controls.Add(this.txtRecordID);
            this.panelForm.Controls.Add(this.lblTransaction);
            this.panelForm.Controls.Add(this.cboTransactionType);
            this.panelForm.Controls.Add(this.lblMemberID);
            this.panelForm.Controls.Add(this.txtMemberID);
            this.panelForm.Controls.Add(this.lblMemberName);
            this.panelForm.Controls.Add(this.txtMemberName);
            this.panelForm.Controls.Add(this.lblBookID);
            this.panelForm.Controls.Add(this.txtBookID);
            this.panelForm.Controls.Add(this.lblBookTitle);
            this.panelForm.Controls.Add(this.txtBookTitle);
            this.panelForm.Controls.Add(this.lblBorrowDate);
            this.panelForm.Controls.Add(this.dtpBorrowDate);
            this.panelForm.Controls.Add(this.lblDueDate);
            this.panelForm.Controls.Add(this.dtpDueDate);
            this.panelForm.Controls.Add(this.lblReturnDate);
            this.panelForm.Controls.Add(this.dtpReturnDate);
            this.panelForm.Controls.Add(this.lblStatus);
            this.panelForm.Controls.Add(this.cboStatus);
            this.panelForm.Controls.Add(this.btnSave);
            this.panelForm.Controls.Add(this.btnClear);
            this.panelForm.Controls.Add(this.btnBack);

            this.lblRecordID.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.lblRecordID.Location = new System.Drawing.Point(25, 25);
            this.lblRecordID.Size = new System.Drawing.Size(100, 20);
            this.lblRecordID.Text = "Record ID";

            this.txtRecordID.Location = new System.Drawing.Point(135, 22);
            this.txtRecordID.Size = new System.Drawing.Size(160, 23);

            this.lblTransaction.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.lblTransaction.Location = new System.Drawing.Point(325, 25);
            this.lblTransaction.Size = new System.Drawing.Size(100, 20);
            this.lblTransaction.Text = "Transaction";

            this.cboTransactionType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTransactionType.Items.AddRange(new object[] { "Borrow", "Return" });
            this.cboTransactionType.Location = new System.Drawing.Point(425, 22);
            this.cboTransactionType.Size = new System.Drawing.Size(170, 23);

            this.lblMemberID.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.lblMemberID.Location = new System.Drawing.Point(625, 25);
            this.lblMemberID.Size = new System.Drawing.Size(90, 20);
            this.lblMemberID.Text = "Member ID";

            this.txtMemberID.Location = new System.Drawing.Point(725, 22);
            this.txtMemberID.Size = new System.Drawing.Size(160, 23);

            this.lblMemberName.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.lblMemberName.Location = new System.Drawing.Point(25, 70);
            this.lblMemberName.Size = new System.Drawing.Size(110, 20);
            this.lblMemberName.Text = "Member Name";

            this.txtMemberName.Location = new System.Drawing.Point(135, 67);
            this.txtMemberName.Size = new System.Drawing.Size(250, 23);

            this.lblBookID.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.lblBookID.Location = new System.Drawing.Point(415, 70);
            this.lblBookID.Size = new System.Drawing.Size(90, 20);
            this.lblBookID.Text = "Book ID";

            this.txtBookID.Location = new System.Drawing.Point(515, 67);
            this.txtBookID.Size = new System.Drawing.Size(160, 23);

            this.lblStatus.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.lblStatus.Location = new System.Drawing.Point(700, 70);
            this.lblStatus.Size = new System.Drawing.Size(70, 20);
            this.lblStatus.Text = "Status";

            this.cboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStatus.Items.AddRange(new object[] { "Borrowed", "Returned", "Overdue" });
            this.cboStatus.Location = new System.Drawing.Point(775, 67);
            this.cboStatus.Size = new System.Drawing.Size(130, 23);

            this.lblBookTitle.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.lblBookTitle.Location = new System.Drawing.Point(25, 115);
            this.lblBookTitle.Size = new System.Drawing.Size(110, 20);
            this.lblBookTitle.Text = "Book Title";

            this.txtBookTitle.Location = new System.Drawing.Point(135, 112);
            this.txtBookTitle.Size = new System.Drawing.Size(540, 23);

            this.lblBorrowDate.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.lblBorrowDate.Location = new System.Drawing.Point(25, 160);
            this.lblBorrowDate.Size = new System.Drawing.Size(100, 20);
            this.lblBorrowDate.Text = "Borrow Date";

            this.dtpBorrowDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBorrowDate.Location = new System.Drawing.Point(135, 157);
            this.dtpBorrowDate.Size = new System.Drawing.Size(170, 23);

            this.lblDueDate.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.lblDueDate.Location = new System.Drawing.Point(325, 160);
            this.lblDueDate.Size = new System.Drawing.Size(90, 20);
            this.lblDueDate.Text = "Due Date";

            this.dtpDueDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDueDate.Location = new System.Drawing.Point(425, 157);
            this.dtpDueDate.Size = new System.Drawing.Size(170, 23);

            this.lblReturnDate.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.lblReturnDate.Location = new System.Drawing.Point(625, 160);
            this.lblReturnDate.Size = new System.Drawing.Size(90, 20);
            this.lblReturnDate.Text = "Return Date";

            this.dtpReturnDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpReturnDate.Location = new System.Drawing.Point(725, 157);
            this.dtpReturnDate.Size = new System.Drawing.Size(170, 23);

            this.btnSave.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(25, 210);
            this.btnSave.Size = new System.Drawing.Size(160, 35);
            this.btnSave.Text = "Save Transaction";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);

            this.btnClear.BackColor = System.Drawing.Color.Black;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(205, 210);
            this.btnClear.Size = new System.Drawing.Size(130, 35);
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.BtnClear_Click);

            this.btnBack.BackColor = System.Drawing.Color.Gray;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(350, 210);
            this.btnBack.Size = new System.Drawing.Size(130, 35);
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.BtnBack_Click);

            this.dgvTransactions.BackgroundColor = System.Drawing.Color.White;
            this.dgvTransactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTransactions.Columns.Add("RecordID", "Record ID");
            this.dgvTransactions.Columns.Add("Transaction", "Transaction");
            this.dgvTransactions.Columns.Add("MemberID", "Member ID");
            this.dgvTransactions.Columns.Add("MemberName", "Member Name");
            this.dgvTransactions.Columns.Add("BookID", "Book ID");
            this.dgvTransactions.Columns.Add("BookTitle", "Book Title");
            this.dgvTransactions.Columns.Add("Status", "Status");
            this.dgvTransactions.Location = new System.Drawing.Point(30, 410);
            this.dgvTransactions.Size = new System.Drawing.Size(940, 190);

            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(245, 248, 255);
            this.ClientSize = new System.Drawing.Size(1000, 630);
            this.Controls.Add(this.dgvTransactions);
            this.Controls.Add(this.panelForm);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmBorrowReturn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Smart Library Management System - Borrow / Return";

            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelForm.ResumeLayout(false);
            this.panelForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransactions)).EndInit();
            this.ResumeLayout(false);
        }
    }
}
