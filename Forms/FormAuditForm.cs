using MySql.Data.MySqlClient;
using Pocket_Auditor_Admin_Panel.Classes;
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
        private List<mdl_Categories> categories = new List<mdl_Categories>();

        DataTable dgvTable = new DataTable();
        int index;

        public FormAuditForm()
        {
            InitializeComponent();
        }

        private void FormAuditForm_Load(object sender, EventArgs e)
        {
            dgvTable.Columns.Add("Category ID");
            dgvTable.Columns.Add("Category Name");
            Catdgv.DataSource = dgvTable;

            // in the TabControl Indicators
            pnlSubIndicators.Hide();
        }

        private void CatInsertbtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCatID.Text) || string.IsNullOrEmpty(txtCatName.Text))
            {
                MessageBox.Show("Please input data.");
                return;
            }

            dgvTable.Rows.Add(txtCatID.Text, txtCatName.Text);

            Clear();
        }

        private void Clear()
        {
            txtCatID.Clear();
            txtCatName.Clear();
        }

        private void Catdgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            DataGridViewRow row = Catdgv.Rows[index];

            txtCatID.Text = row.Cells[0].Value.ToString();
            txtCatName.Text = row.Cells[1].Value.ToString();
        }

        private void CatUpdatebtn_Click(object sender, EventArgs e)
        {
            DataGridViewRow newData = Catdgv.Rows[index];

            newData.Cells[0].Value = txtCatID.Text;
            newData.Cells[1].Value = txtCatName.Text;

            Clear();
        }

        private void CatDeletebtn_Click(object sender, EventArgs e)
        {
            index = Catdgv.CurrentCell.RowIndex;
            Catdgv.Rows.RemoveAt(index);

            Clear();
        }
    }
}
