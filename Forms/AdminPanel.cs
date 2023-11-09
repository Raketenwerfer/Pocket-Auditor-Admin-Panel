using Pocket_Audior_Admin_Panel.Forms;
using System.Windows.Forms;

namespace Pocket_Audior_Admin_Panel
{
    public partial class AdminPanel : Form
    {
        public AdminPanel()
        {
            InitializeComponent();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            FormDashboard frmDashboard = new FormDashboard();
            frmDashboard.TopLevel = false;
            frmDashboard.TopMost = true;
            panelContent.Controls.Clear();
            panelContent.Controls.Add(frmDashboard);
            frmDashboard.Show();
        }

        private void btnAuditForm_Click(object sender, EventArgs e)
        {
            FormAuditForm frmAuditForm = new FormAuditForm();
            frmAuditForm.TopLevel = false;
            frmAuditForm.TopMost = true;
            panelContent.Controls.Clear();
            panelContent.AutoScroll = true;
            panelContent.Controls.Add(frmAuditForm);
            frmAuditForm.Show();
        }

        private void btnActionPlans_Click(object sender, EventArgs e)
        {
            FormActionPlans frmActionPlans = new FormActionPlans();
            frmActionPlans.TopLevel = false;
            frmActionPlans.TopMost = true;
            panelContent.Controls.Clear();
            panelContent.AutoScroll=true;
            panelContent.Controls.Add(frmActionPlans);
            frmActionPlans.Show();
        }

        private void btnAuditReports_Click(object sender, EventArgs e)
        {
            FormAuditReports frmAuditReports = new FormAuditReports();
            frmAuditReports.TopLevel = false;
            frmAuditReports.TopMost = true;
            panelContent.Controls.Clear();
            panelContent.AutoScroll = true;
            panelContent.Controls.Add(frmAuditReports);
            frmAuditReports.Show();
        }

        private void btnManageAuditors_Click(object sender, EventArgs e)
        {
            FormManageAuditors frmManageAuditors = new FormManageAuditors();
            frmManageAuditors.TopLevel = false;
            frmManageAuditors.TopMost = true;
            panelContent.Controls.Clear();
            panelContent.AutoScroll = true;
            panelContent.Controls.Add(frmManageAuditors);
            frmManageAuditors.Show();
        }

        private void AdminPanel_Load(object sender, EventArgs e)
        {
        }
    }
}