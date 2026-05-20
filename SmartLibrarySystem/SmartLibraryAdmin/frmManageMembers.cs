using System;
using System.Windows.Forms;

namespace SmartLibraryWinForms
{
    public partial class frmManageMembers : Form
    {
        public frmManageMembers()
        {
            InitializeComponent();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            dgvMembers.Rows.Add(
                txtMemberID.Text,
                txtFirstName.Text,
                txtLastName.Text,
                txtEmail.Text,
                txtPhone.Text,
                cboUserType.Text
            );

            MessageBox.Show("Member added successfully.", "Add Member", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Member update button clicked.", "Update Member", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Member delete button clicked.", "Delete Member", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            txtMemberID.Clear();
            txtFirstName.Clear();
            txtLastName.Clear();
            txtEmail.Clear();
            txtPhone.Clear();
            cboUserType.SelectedIndex = -1;
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}