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
    public partial class FormManageAuditors : Form
    {
        readonly DataTable UserTable = new DataTable();
        int index;

        public FormManageAuditors()
        {
            InitializeComponent();
        }

        private void FormManageAuditors_Load(object sender, EventArgs e)
        {
            UserTable.Columns.Add("User ID");
            UserTable.Columns.Add("Username");
            UserTable.Columns.Add("Password");
            UserTable.Columns.Add("Email Address");
            UserTable.Columns.Add("User Type");
            Usersdgv.DataSource = UserTable;

            HideControls();
        }

        private void Usersdgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            DataGridViewRow row = Usersdgv.Rows[index];

            txtUserID.Text = row.Cells[0].Value.ToString();
            txtName.Text = row.Cells[1].Value.ToString();
            txtPassword.Text = row.Cells[2].Value.ToString();
            txtEmail.Text = row.Cells[3].Value.ToString();
            cbxUserType.Text = row.Cells[4].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DataGridViewRow newData = Usersdgv.Rows[index];

            newData.Cells[0].Value = txtUserID.Text;
            newData.Cells[1].Value = txtName.Text;
            newData.Cells[2].Value = txtPassword.Text;
            newData.Cells[3].Value = txtEmail.Text;
            newData.Cells[4].Value = cbxUserType.Text;
            MessageBox.Show("Data Successfully Updated!");

            ClearEntry();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            index = Usersdgv.CurrentCell.RowIndex;
            Usersdgv.Rows.RemoveAt(index);
            MessageBox.Show("Data Successfully Deleted!");

            ClearEntry();
        }

        private void ClearEntry()
        {
            txtUserID.Clear();
            txtName.Clear();
            txtPassword.Clear();
            txtEmail.Clear();
            cbxUserType.SelectedItem = null;
        }

        private void ShowControls()
        {
            btnDelete.Show();
            btnUpdate.Show();
        }

        private void HideControls()
        {
            btnDelete.Hide();
            btnUpdate.Hide();
        }

        private void btnRegister_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(txtPassword.Text) ||
                string.IsNullOrEmpty(txtEmail.Text) || string.IsNullOrEmpty(cbxUserType.Text) ||
                string.IsNullOrEmpty(txtUserID.Text))
            {
                MessageBox.Show("Please input a data");
                return;
            }

            UserTable.Rows.Add(txtUserID.Text, txtName.Text, txtPassword.Text, txtEmail.Text, cbxUserType.Text);
            MessageBox.Show("Data successfully registered!");

            ClearEntry();
            ShowControls();
        }
    }
}
