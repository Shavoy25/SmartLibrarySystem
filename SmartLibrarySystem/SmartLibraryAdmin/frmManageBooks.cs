using System;
using System.Windows.Forms;

namespace SmartLibraryWinForms
{
    public partial class frmManageBooks : Form
    {
        public frmManageBooks()
        {
            InitializeComponent();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            dgvBooks.Rows.Add(
                txtBookID.Text,
                txtTitle.Text,
                txtAuthor.Text,
                txtCategory.Text,
                txtISBN.Text,
                txtQuantity.Text,
                cboStatus.Text
            );

            MessageBox.Show("Book added successfully.", "Add Book", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Book update button clicked.", "Update Book", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Book delete button clicked.", "Delete Book", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            txtBookID.Clear();
            txtTitle.Clear();
            txtAuthor.Clear();
            txtCategory.Clear();
            txtISBN.Clear();
            txtQuantity.Clear();
            cboStatus.SelectedIndex = -1;
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}