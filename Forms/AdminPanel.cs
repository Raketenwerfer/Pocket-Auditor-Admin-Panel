using System.Windows.Forms;

namespace Pocket_Audior_Admin_Panel
{
    public partial class AdminPanel : Form
    {
        //declare variable;
        private Form form;

        public AdminPanel() 
        {
            InitializeComponent();

        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            Form dashform = new Form();
            dashform.TopLevel = false;
            dashform.TopMost = true;
            dashform.FormBorderStyle = FormBorderStyle.None;
            panelContent.Controls.Add(dashform);
            panelContent.Dock = DockStyle.Fill;
            dashform.Show();
        }

        private void btnAuditForm_Click(object sender, EventArgs e)
        {
            
        }

        private void btnActionPlans_Click(object sender, EventArgs e)
        {

        }

        private void btnAuditReports_Click(object sender, EventArgs e)
        {

        }

        private void btnManageAuditors_Click(object sender, EventArgs e)
        {

        }

        private void AdminPanel_Load(object sender, EventArgs e)
        {
        }
    }
}