using Pocket_Auditor_Admin_Panel.Forms;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Pocket_Auditor_Admin_Panel.Auxiliaries;

namespace Pocket_Auditor_Admin_Panel
{
    public partial class AdminPanel : Form
    {
        readonly FormDashboard frmDashboard = new FormDashboard();
        readonly FormAuditForm frmAuditForm = new FormAuditForm();
        readonly FormActionPlans frmActionPlans = new FormActionPlans();
        readonly FormAuditReports frmAuditReports = new FormAuditReports();
        readonly FormManageAuditors frmManageAuditors = new FormManageAuditors();

        readonly DatabaseInitiator db = new DatabaseInitiator("sql.freedb.tech", "freedb_ccydc_test_db", "freedb_ccydc", "r*kmjEa6N#KUsDN");

        public AdminPanel()
        {
            InitializeComponent();
            InitDatabase();
        }

        public void InitDatabase()
        {
            // Establishes connection with the database
            using MySqlConnection conn = db.GetConnection();
            if (conn != null)
            {
                MessageBox.Show("Database connection has been established!");
                return;
            }
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
            panelContent.AutoScroll = true;
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