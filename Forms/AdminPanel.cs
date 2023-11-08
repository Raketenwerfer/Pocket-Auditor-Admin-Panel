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

        private void childForm()
        {
            //
            Form form = new Form();
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            panelContent.Controls.Add(form);
            form.Show();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            Form form = new Form();
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            panelContent.Controls.Add(form);
            form.FormBorderStyle = FormBorderStyle.None;
            form.Show();
        }

        private void btnAuditForm_Click(object sender, EventArgs e)
        {
            childForm();
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
            panelContent.Controls.Add(form);
        }
    }
}