using System;
using System.Windows.Forms;

namespace SmartLibraryWinForms
{
    public partial class frmBorrowReturn : Form
    {
        public frmBorrowReturn()
        {
            InitializeComponent();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            dgvTransactions.Rows.Add(
                txtRecordID.Text,
                cboTransactionType.Text,
                txtMemberID.Text,
                txtMemberName.Text,
                txtBookID.Text,
                txtBookTitle.Text,
                cboStatus.Text
            );

            MessageBox.Show("Transaction saved successfully.", "Borrow/Return", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            txtRecordID.Clear();
            txtMemberID.Clear();
            txtMemberName.Clear();
            txtBookID.Clear();
            txtBookTitle.Clear();

            cboTransactionType.SelectedIndex = -1;
            cboStatus.SelectedIndex = -1;

            dtpBorrowDate.Value = DateTime.Today;
            dtpDueDate.Value = DateTime.Today;
            dtpReturnDate.Value = DateTime.Today;
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}