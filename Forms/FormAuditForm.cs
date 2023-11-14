using MySql.Data.MySqlClient;
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
    public partial class FormAuditForm : Form
    {

        public FormAuditForm()
        {
            InitializeComponent();
        }

        private void FormAuditForm_Load(object sender, EventArgs e)
        {
            pnlSubIndicators.Hide();
        }

        private void cbxSubIndicators_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxSubIndicators.Checked == true)
            {
                pnlSubIndicators.Show();
            }
            else
            {
                pnlSubIndicators.Hide();
            }
        }

        private void txtCatID_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            // Allow only numeric digits, backspace, and the delete key
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;  // Suppress the key press
            }
        }

        private void btnInsertData_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCatID.Text) ||
                string.IsNullOrEmpty(txtCatName.Text) ||
                string.IsNullOrEmpty(txtIndicators.Text))
            {
                MessageBox.Show("Please fill in all textboxes.");
                return;
            }

        }

        private void btnUpdateData_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Data is successfull updated!");
        }

        private void btnDelData_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Data is successfull Deleted!");
        }

        private void btnSubInsert_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cbxSubIndicators.Text) ||
                string.IsNullOrEmpty(txtSubIndicators.Text))
            {
                MessageBox.Show("Please select and fill in the textbox.");
                return;
            }
        }

        private void btnSubUpdate_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The selected Data is Updated successfully");
        }

        private void btnSubDelete_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The selected Data is Deleted successfully");
        }
    }
}
