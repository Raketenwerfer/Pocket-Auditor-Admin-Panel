using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pocket_Auditor_Admin_Panel.Forms
{
    public partial class FormActionPlans : Form
    {
        readonly DataTable ActionPlanTable = new DataTable();
        int index;

        public FormActionPlans()
        {
            InitializeComponent();
        }

        private void FormActionPlans_Load(object sender, EventArgs e)
        {
            HideControls();

            ActionPlanTable.Columns.Add("Plan Name");
            ActionPlanTable.Columns.Add("Plan Details");
            ActionPlanTable.Columns.Add("Plan Type");
            APlandgv.DataSource = ActionPlanTable;
        }

        private void btnA_Insert_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPlanName.Text) || string.IsNullOrEmpty(txtPlanDetails.Text) ||
                string.IsNullOrEmpty(cbxAPlanType.Text))
            {
                MessageBox.Show("Please select and input a data.");
                return;
            }

            ActionPlanTable.Rows.Add(txtPlanName.Text, txtPlanDetails.Text, cbxAPlanType.Text);
            ClearEntry();
            ShowControls();
        }



        private void ClearEntry()
        {
            txtPlanName.Clear();
            txtPlanDetails.Clear();
            cbxAPlanType.SelectedItem = null;
        }

        private void ShowControls()
        {
            btnA_Delete.Show();
            btnA_Update.Show();
        }

        private void HideControls()
        {
            btnA_Delete.Hide();
            btnA_Update.Hide();
        }

        private void btnA_Update_Click(object sender, EventArgs e)
        {
            DataGridViewRow newData = APlandgv.Rows[index];

            newData.Cells[0].Value = txtPlanName.Text;
            newData.Cells[1].Value = txtPlanDetails.Text;
            newData.Cells[2].Value = cbxAPlanType.Text;

            ClearEntry();
        }

        private void APlandgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            DataGridViewRow row = APlandgv.Rows[index];

            txtPlanName.Text = row.Cells[0].Value.ToString();
            txtPlanDetails.Text = row.Cells[1].Value.ToString();
            cbxAPlanType.Text = row.Cells[2].Value.ToString();
        }

        private void btnA_Delete_Click(object sender, EventArgs e)
        {

            index = APlandgv.CurrentCell.RowIndex;
            APlandgv.Rows.RemoveAt(index);

            MessageBox.Show("Data Successfully Deleted!");

            ClearEntry();
        }
    }
}
