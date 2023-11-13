using Pocket_Audior_Admin_Panel.Forms;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Pocket_Audior_Admin_Panel
{
    public partial class AdminPanel : Form
    {
        FormDashboard frmDashboard = new FormDashboard();
        FormAuditForm frmAuditForm = new FormAuditForm();
        FormActionPlans frmActionPlans = new FormActionPlans();
        FormAuditReports frmAuditReports = new FormAuditReports();
        FormManageAuditors frmManageAuditors = new FormManageAuditors();
        public AdminPanel()
        {
            InitializeComponent();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            frmDashboard.TopLevel = false;
            frmDashboard.TopMost = true;
            panelContent.Controls.Clear();
            panelContent.Controls.Add(frmDashboard);
            frmDashboard.Show();
        }

        private void btnAuditForm_Click(object sender, EventArgs e)
        {
            frmAuditForm.TopLevel = false;
            frmAuditForm.TopMost = true;
            panelContent.Controls.Clear();
            panelContent.AutoScroll = true;
            panelContent.Controls.Add(frmAuditForm);
            frmAuditForm.Show();
        }

        private void btnActionPlans_Click(object sender, EventArgs e)
        {
            frmActionPlans.TopLevel = false;
            frmActionPlans.TopMost = true;
            panelContent.Controls.Clear();
            panelContent.AutoScroll=true;
            panelContent.Controls.Add(frmActionPlans);
            frmActionPlans.Show();
        }

        private void btnAuditReports_Click(object sender, EventArgs e)
        {
            frmAuditReports.TopLevel = false;
            frmAuditReports.TopMost = true;
            panelContent.Controls.Clear();
            panelContent.AutoScroll = true;
            panelContent.Controls.Add(frmAuditReports);
            frmAuditReports.Show();
        }

        private void btnManageAuditors_Click(object sender, EventArgs e)
        {
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