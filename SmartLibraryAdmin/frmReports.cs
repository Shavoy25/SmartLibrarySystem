using System;
using System.Windows.Forms;

namespace SmartLibraryWinForms
{
    public partial class frmReports : Form
    {
        public frmReports()
        {
            InitializeComponent();
        }

        private void BtnGenerate_Click(object sender, EventArgs e)
        {
            if (cboReportType.Text == "")
            {
                MessageBox.Show("Please select a report type.", "Missing Report Type", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            dgvReports.Rows.Add(
                "R001",
                cboReportType.Text + " report generated",
                "Library Report",
                "Completed",
                DateTime.Now.ToShortDateString()
            );

            MessageBox.Show("Report generated successfully.", "Reports", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}