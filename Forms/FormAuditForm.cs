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

        readonly DataTable dgvCatTable = new DataTable();
        readonly DataTable dgvIndiTable = new DataTable();
        readonly DataTable dgvSunIndiTable = new DataTable();
        int index;

        public FormAuditForm()
        {
            InitializeComponent();
        }

        private void FormAuditForm_Load(object sender, EventArgs e)
        {
            CatTable();
            IndicatorTable();
            SubIndicatorTable();
            HideControls();
        }

        #region TabControl Categories

        private void CatInsertbtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCatID.Text) || string.IsNullOrEmpty(txtCatName.Text))
            {
                MessageBox.Show("Please input data.");
                return;
            }

            dgvCatTable.Rows.Add(txtCatID.Text, txtCatName.Text);
            MessageBox.Show("Data Successfully Created!");

            Clear();
            ShowControls();
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
            MessageBox.Show("Data Successfully Updated!");

            Clear();
        }

        private void CatDeletebtn_Click(object sender, EventArgs e)
        {
            index = Catdgv.CurrentCell.RowIndex;
            Catdgv.Rows.RemoveAt(index);
            MessageBox.Show("Data Successfully Deleted!");

            Clear();
        }

        private void txtCatID_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        #endregion




        #region TabControl Indicators

        private void IndicatorInsertbtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(CatIDcbx.Text) || string.IsNullOrEmpty(Indicatortxt.Text))
            {
                MessageBox.Show("Please Select and input a data.");
                return;
            }

            dgvIndiTable.Rows.Add(CatIDcbx.Text, Indicatortxt.Text);
            MessageBox.Show("Data Successfully Created!");

            Clear();
            ShowControls();
        }

        private void Indicatordgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            DataGridViewRow row = Indicatordgv.Rows[index];

            CatIDcbx.Text = row.Cells[0].Value.ToString();
            Indicatortxt.Text = row.Cells[1].Value.ToString();
        }

        private void IndicatorUpdatebtn_Click(object sender, EventArgs e)
        {
            DataGridViewRow newData = Indicatordgv.Rows[index];

            newData.Cells[0].Value = CatIDcbx.Text;
            newData.Cells[1].Value = Indicatortxt.Text;
            MessageBox.Show("Data Successfully Updated!");

            Clear();
        }

        private void IndicatorDeletebtn_Click(object sender, EventArgs e)
        {
            index = Indicatordgv.CurrentCell.RowIndex;
            Indicatordgv.Rows.RemoveAt(index);
            MessageBox.Show("Data Successfully Deleted!");

            Clear();
        }

        #endregion



        #region SubIndicators

        private void SubIndicatorscbx_CheckedChanged(object sender, EventArgs e)
        {
            if (SubIndicatorscbx.Checked == true)
            {
                pnlSubIndicators.Show();
            }
            else
            {
                pnlSubIndicators.Hide();
            }
        }

        private void btnSubInsert_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cbxType.Text) || string.IsNullOrEmpty(txtSubIndicators.Text))
            {
                MessageBox.Show("Please Select and input a data.");
                return;
            }

            dgvSunIndiTable.Rows.Add(cbxType.Text, txtSubIndicators.Text);
            MessageBox.Show("Data Successfully Created!");
            Clear();
            ShowControls();
        }

        private void btnSubUpdate_Click(object sender, EventArgs e)
        {
            DataGridViewRow newData = SubIndicatorsdgv.Rows[index];

            newData.Cells[0].Value = cbxType.Text;
            newData.Cells[1].Value = txtSubIndicators.Text;
            MessageBox.Show("Data Successfully Updated!");

            Clear();
        }

        private void btnSubDelete_Click(object sender, EventArgs e)
        {
            index = SubIndicatorsdgv.CurrentCell.RowIndex;
            SubIndicatorsdgv.Rows.RemoveAt(index);
            MessageBox.Show("Data Successfully Deleted!");

            Clear();
        }

        #endregion



        #region Methods

        private void HideControls()
        {
            // controls of Categories
            CatUpdatebtn.Hide();
            CatDeletebtn.Hide();

            // controls of Indicators
            pnlSubIndicators.Hide();
            IndicatorUpdatebtn.Hide();
            IndicatorDeletebtn.Hide();

            // controls for SubIndicators
            btnSubUpdate.Hide();
            btnSubDelete.Hide();
        }

        private void ShowControls()
        {
            // controls of Categories
            CatUpdatebtn.Show();
            CatDeletebtn.Show();

            // controls of Indicators
            IndicatorUpdatebtn.Show();
            IndicatorDeletebtn.Show();

            // controls for SubIndicators
            btnSubUpdate.Show();
            btnSubDelete.Show();
        }

        private void CatTable()
        {
            // for Category
            dgvCatTable.Columns.Add("Category ID");
            dgvCatTable.Columns.Add("Category Name");
            Catdgv.DataSource = dgvCatTable;

        }

        private void Clear()
        {
            // for Category Entry
            txtCatID.Clear();
            txtCatName.Clear();

            // for Indicator Entry
            CatIDcbx.SelectedItem = null;
            Indicatortxt.Clear();

            // for Sub-Indicator Entry
            cbxType.SelectedItem = null;
            txtSubIndicators.Clear();
        }

        private void IndicatorTable()
        {
            // for Indicator
            dgvIndiTable.Columns.Add("Category ID");
            dgvIndiTable.Columns.Add("Indicator");
            Indicatordgv.DataSource = dgvIndiTable;
        }

        private void SubIndicatorTable()
        {
            dgvSunIndiTable.Columns.Add("Sub-Indicator Type");
            dgvSunIndiTable.Columns.Add("Sub-Indicator");
            SubIndicatorsdgv.DataSource = dgvSunIndiTable;
        }

        #endregion

    }
}
