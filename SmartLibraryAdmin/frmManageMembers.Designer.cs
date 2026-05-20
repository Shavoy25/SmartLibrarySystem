namespace SmartLibraryWinForms
{
    partial class frmManageMembers
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblHeaderTitle;
        private System.Windows.Forms.Label lblHeaderSubtitle;
        private System.Windows.Forms.Panel panelForm;

        private System.Windows.Forms.Label lblMemberID;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblUserType;

        private System.Windows.Forms.TextBox txtMemberID;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.ComboBox cboUserType;

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnBack;

        private System.Windows.Forms.DataGridView dgvMembers;

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

            this.lblMemberID = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblUserType = new System.Windows.Forms.Label();

            this.txtMemberID = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.cboUserType = new System.Windows.Forms.ComboBox();

            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();

            this.dgvMembers = new System.Windows.Forms.DataGridView();

            this.panelHeader.SuspendLayout();
            this.panelForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMembers)).BeginInit();
            this.SuspendLayout();

            this.panelHeader.BackColor = System.Drawing.Color.Black;
            this.panelHeader.Controls.Add(this.lblHeaderTitle);
            this.panelHeader.Controls.Add(this.lblHeaderSubtitle);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1000, 105);

            this.lblHeaderTitle.AutoSize = true;
            this.lblHeaderTitle.Font = new System.Drawing.Font("Arial", 22F, System.Drawing.FontStyle.Bold);
            this.lblHeaderTitle.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblHeaderTitle.Location = new System.Drawing.Point(30, 22);
            this.lblHeaderTitle.Name = "lblHeaderTitle";
            this.lblHeaderTitle.Text = "Manage Members";

            this.lblHeaderSubtitle.AutoSize = true;
            this.lblHeaderSubtitle.Font = new System.Drawing.Font("Arial", 10F);
            this.lblHeaderSubtitle.ForeColor = System.Drawing.Color.White;
            this.lblHeaderSubtitle.Location = new System.Drawing.Point(34, 65);
            this.lblHeaderSubtitle.Name = "lblHeaderSubtitle";
            this.lblHeaderSubtitle.Text = "Register, update, delete, and view library member records.";

            this.panelForm.BackColor = System.Drawing.Color.White;
            this.panelForm.Controls.Add(this.lblMemberID);
            this.panelForm.Controls.Add(this.txtMemberID);
            this.panelForm.Controls.Add(this.lblFirstName);
            this.panelForm.Controls.Add(this.txtFirstName);
            this.panelForm.Controls.Add(this.lblLastName);
            this.panelForm.Controls.Add(this.txtLastName);
            this.panelForm.Controls.Add(this.lblEmail);
            this.panelForm.Controls.Add(this.txtEmail);
            this.panelForm.Controls.Add(this.lblPhone);
            this.panelForm.Controls.Add(this.txtPhone);
            this.panelForm.Controls.Add(this.lblUserType);
            this.panelForm.Controls.Add(this.cboUserType);
            this.panelForm.Controls.Add(this.btnAdd);
            this.panelForm.Controls.Add(this.btnUpdate);
            this.panelForm.Controls.Add(this.btnDelete);
            this.panelForm.Controls.Add(this.btnClear);
            this.panelForm.Controls.Add(this.btnBack);
            this.panelForm.Location = new System.Drawing.Point(30, 130);
            this.panelForm.Name = "panelForm";
            this.panelForm.Size = new System.Drawing.Size(940, 210);

            this.lblMemberID.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.lblMemberID.Location = new System.Drawing.Point(25, 25);
            this.lblMemberID.Size = new System.Drawing.Size(90, 20);
            this.lblMemberID.Text = "Member ID";

            this.txtMemberID.Location = new System.Drawing.Point(125, 22);
            this.txtMemberID.Size = new System.Drawing.Size(170, 23);

            this.lblFirstName.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.lblFirstName.Location = new System.Drawing.Point(325, 25);
            this.lblFirstName.Size = new System.Drawing.Size(90, 20);
            this.lblFirstName.Text = "First Name";

            this.txtFirstName.Location = new System.Drawing.Point(425, 22);
            this.txtFirstName.Size = new System.Drawing.Size(170, 23);

            this.lblLastName.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.lblLastName.Location = new System.Drawing.Point(625, 25);
            this.lblLastName.Size = new System.Drawing.Size(90, 20);
            this.lblLastName.Text = "Last Name";

            this.txtLastName.Location = new System.Drawing.Point(725, 22);
            this.txtLastName.Size = new System.Drawing.Size(170, 23);

            this.lblEmail.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.lblEmail.Location = new System.Drawing.Point(25, 70);
            this.lblEmail.Size = new System.Drawing.Size(90, 20);
            this.lblEmail.Text = "Email";

            this.txtEmail.Location = new System.Drawing.Point(125, 67);
            this.txtEmail.Size = new System.Drawing.Size(270, 23);

            this.lblPhone.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.lblPhone.Location = new System.Drawing.Point(425, 70);
            this.lblPhone.Size = new System.Drawing.Size(90, 20);
            this.lblPhone.Text = "Phone";

            this.txtPhone.Location = new System.Drawing.Point(525, 67);
            this.txtPhone.Size = new System.Drawing.Size(170, 23);

            this.lblUserType.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.lblUserType.Location = new System.Drawing.Point(25, 115);
            this.lblUserType.Size = new System.Drawing.Size(90, 20);
            this.lblUserType.Text = "User Type";

            this.cboUserType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUserType.Items.AddRange(new object[] { "Student", "Teacher", "Staff", "Librarian" });
            this.cboUserType.Location = new System.Drawing.Point(125, 112);
            this.cboUserType.Size = new System.Drawing.Size(170, 23);

            this.btnAdd.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(25, 160);
            this.btnAdd.Size = new System.Drawing.Size(130, 35);
            this.btnAdd.Text = "Add Member";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);

            this.btnUpdate.BackColor = System.Drawing.Color.Black;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(170, 160);
            this.btnUpdate.Size = new System.Drawing.Size(130, 35);
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);

            this.btnDelete.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(315, 160);
            this.btnDelete.Size = new System.Drawing.Size(130, 35);
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);

            this.btnClear.BackColor = System.Drawing.Color.Black;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(460, 160);
            this.btnClear.Size = new System.Drawing.Size(130, 35);
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.BtnClear_Click);

            this.btnBack.BackColor = System.Drawing.Color.Gray;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(605, 160);
            this.btnBack.Size = new System.Drawing.Size(130, 35);
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.BtnBack_Click);

            this.dgvMembers.BackgroundColor = System.Drawing.Color.White;
            this.dgvMembers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMembers.Columns.Add("MemberID", "Member ID");
            this.dgvMembers.Columns.Add("FirstName", "First Name");
            this.dgvMembers.Columns.Add("LastName", "Last Name");
            this.dgvMembers.Columns.Add("Email", "Email");
            this.dgvMembers.Columns.Add("Phone", "Phone");
            this.dgvMembers.Columns.Add("UserType", "User Type");
            this.dgvMembers.Location = new System.Drawing.Point(30, 365);
            this.dgvMembers.Name = "dgvMembers";
            this.dgvMembers.Size = new System.Drawing.Size(940, 235);

            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(245, 248, 255);
            this.ClientSize = new System.Drawing.Size(1000, 630);
            this.Controls.Add(this.dgvMembers);
            this.Controls.Add(this.panelForm);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmManageMembers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Smart Library Management System - Manage Members";

            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelForm.ResumeLayout(false);
            this.panelForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMembers)).EndInit();
            this.ResumeLayout(false);
        }
    }
}
