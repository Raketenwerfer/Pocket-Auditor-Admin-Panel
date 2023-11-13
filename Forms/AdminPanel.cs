using Pocket_Auditor_Admin_Panel.Forms;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Pocket_Auditor_Admin_Panel.Auxiliaries;

namespace Pocket_Auditor_Admin_Panel
{
    public partial class AdminPanel : Form
    {
        FormDashboard frmDashboard = new FormDashboard();
        FormAuditForm frmAuditForm = new FormAuditForm();
        FormActionPlans frmActionPlans = new FormActionPlans();
        FormAuditReports frmAuditReports = new FormAuditReports();
        FormManageAuditors frmManageAuditors = new FormManageAuditors();

        DatabaseInitiator db = new DatabaseInitiator("sql207.infinityfreem.com", "if0_35394751_testrun", "if0_35394751", "aTbs7LJAy0B2");
        
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