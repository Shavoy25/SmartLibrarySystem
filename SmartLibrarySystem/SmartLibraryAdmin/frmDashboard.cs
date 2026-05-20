using System;
using System.Windows.Forms;

namespace SmartLibraryWinForms
{
    public partial class frmDashboard : Form
    {
        public frmDashboard()
        {
            InitializeComponent();
        }
private void btnManageBooks_Click(object sender, EventArgs e)
{
    frmManageBooks manageBooks = new frmManageBooks();
    manageBooks.ShowDialog();
}

private void btnManageMembers_Click(object sender, EventArgs e)
{
    frmManageMembers manageMembers = new frmManageMembers();
    manageMembers.ShowDialog();
}

private void btnBorrowReturn_Click(object sender, EventArgs e)
{
    frmBorrowReturn borrowReturn = new frmBorrowReturn();
    borrowReturn.ShowDialog();
}

private void btnReports_Click(object sender, EventArgs e)
{
    frmReports reports = new frmReports();
    reports.ShowDialog();
}

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult answer = MessageBox.Show(
                "Are you sure you want to logout?",
                "Logout",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (answer == DialogResult.Yes)
            {
                frmLogin login = new frmLogin();
                login.Show();
                this.Close();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult answer = MessageBox.Show(
                "Are you sure you want to exit the application?",
                "Exit Application",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (answer == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}