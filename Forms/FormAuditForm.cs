using MySql.Data.MySqlClient;
using Pocket_Auditor_Admin_Panel.Auxiliaries;
using Pocket_Auditor_Admin_Panel.Classes;
using Pocket_Auditor_Admin_Panel.Prompts;
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
        public DatabaseInitiator dbInit;

        public List<mdl_Categories> _Categories;
        public List<mdl_Indicators> _Indicators;
        public List<mdl_SubIndicators> _SubIndicators;

        public List<jmdl_IndicatorsSubInd> _jmISI;
        public List<jmdl_CategoriesIndicators> _jmCI;


        int sel { get; set; }
        bool isSubIndEditMode { get; set; }

        public FormAuditForm(DatabaseInitiator _dbBUcket, List<mdl_Categories> __categories,
            List<mdl_Indicators> __indicators, List<mdl_SubIndicators> __subindicators,
            List<jmdl_IndicatorsSubInd> __jmISI, List<jmdl_CategoriesIndicators> __jmCI)
        {
            _Categories = __categories;
            _Indicators = __indicators;
            _SubIndicators = __subindicators;
            _jmISI = __jmISI;
            _jmCI = __jmCI;

            dbInit = _dbBUcket;
            InitializeComponent();
        }

        private void FormAuditForm_Load(object sender, EventArgs e)
        {
            CatTable();
            IndicatorTable();
            SubIndicatorTable();

            SetCboxItems();

            UpdateCatDataTable();
            UpdateIndiDataTable();
            UpdateSubIndiDataTable();


            HideControls();
        }

        #region TabControl Categories

        private void CatInsertbtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCatName.Text))
            {
                MessageBox.Show("Please input data.");
                return;
            }


            MessageBox.Show("Data Successfully Created!");

            Clear();
            ShowControls();
        }

        private void Catdgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            DataGridViewRow row = Catdgv.Rows[index];


            txtCatName.Text = row.Cells[1].Value.ToString();
            ShowControls();
        }

        private void CatUpdatebtn_Click(object sender, EventArgs e)
        {

            DataGridViewRow newData = Catdgv.Rows[index];


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
            if (string.IsNullOrEmpty(CatIDcbx.Text) || string.IsNullOrEmpty(Indicatortxt.Text) ||
                string.IsNullOrEmpty(IndicatorNumbertxt.Text))
            {
                MessageBox.Show("Please Select and input a data.");
                return;
            }

            dgvIndiTable.Rows.Add(CatIDcbx.Text, Indicatortxt.Text);
            MessageBox.Show("Data Successfully Created!");

            Clear();
            ShowControls();
        }

        private void Indicatordgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            DataGridViewRow row = Indicatordgv.Rows[index];

            if (!SubIndicatorscbx.Checked)
            {
                pnlSubIndicators.Visible = true;
            }

            foreach (jmdl_CategoriesIndicators x in _jmCI)
            {
                if (Convert.ToInt32(row.Cells[0].Value) == x.IndicatorID)
                {
                    sel = x.IndicatorID;
                }
            };

            prompt_Edit_ISI EditPrompt = new prompt_Edit_ISI("indicator", sel, _Indicators, _SubIndicators, _jmISI);
            EditPrompt.Show();
        }

        private void Indicatordgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            pnlSubIndicators.Visible = true;
            isSubIndEditMode = true;
            btnSubIndSubmitEvent.Text = "EDIT";
            label3.Visible = false;
            label6.Visible = false;
            label9.Visible = false;
            txtSubIndicators.Visible = false;
            cbxType.Visible = false;
            num_SubIndicatorSV.Visible = false;
        }

        private void Indicatordgv_Leave(object sender, EventArgs e)
        {
            Indicatordgv.ClearSelection();
            if (!SubIndicatorscbx.Checked)
            {
                pnlSubIndicators.Visible = false;
            }
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

        private void SetCboxItems()
        {
            cbox_IndicatorFilterbyCategory.Items.Clear();
            CatIDcbx.Items.Clear();

            foreach (var cat in _Categories)
            {
                cbox_IndicatorFilterbyCategory.Items.Add(cat.CategoryTitle);
                CatIDcbx.Items.Add(cat.CategoryTitle);
            }

            num_IndicatorSV.Value = 1;
            num_SubIndicatorSV.Value = 1;
        }

        private void cbox_IndicatorFilterbyCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateIndiDataTable();
            Indicatordgv.ClearSelection();
        }

        #endregion

        #region SubIndicators

        private void SubIndicatorscbx_CheckedChanged(object sender, EventArgs e)
        {
            if (SubIndicatorscbx.Checked == true)
            {
                pnlSubIndicators.Show();
                Indicatordgv.Enabled = false;
                Indicatordgv.ClearSelection();
                isSubIndEditMode = false;
                btnSubIndSubmitEvent.Text = "INSERT";
                label3.Visible = true;
                label6.Visible = true;
                label9.Visible = true;
                txtSubIndicators.Visible = true;
                cbxType.Visible = true;
                num_SubIndicatorSV.Visible = true;
            }
            else
            {
                pnlSubIndicators.Hide();
                Indicatordgv.Enabled = true;
            }
        }

        private void btnSubInsert_Click()
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

        private void btnSubIndSubmitEvent_Click(object sender, EventArgs e)
        {

            if (isSubIndEditMode == true)
            {
                prompt_Edit_ISI EditPrompt = new prompt_Edit_ISI("subindicator", sel, _Indicators, _SubIndicators, _jmISI);
                EditPrompt.Show();
            }
            else
            {
                btnSubInsert_Click();
            }
        }

        #endregion



        #region Load DataGridViews
        private void UpdateCatDataTable()
        {
            dgvCatTable.Rows.Clear(); // Clear existing rows

            foreach (var category in _Categories)
            {
                dgvCatTable.Rows.Add(category.CategoryID, category.CategoryTitle);
            }
        }

        private void UpdateIndiDataTable()
        {
            dgvIndiTable.Rows.Clear(); // Clear existing rows

            foreach (var i in _jmCI.Where(x => x.CategoryTitle.Equals(cbox_IndicatorFilterbyCategory.Text)))
            {
                dgvIndiTable.Rows.Add(i.IndicatorID, i.IndicatorNumber, i.Indicator, i.IndicatorType, i.ScoreValue);
            }
        }

        private void UpdateSubIndiDataTable()
        {
            dgvSunIndiTable.Rows.Clear(); // Clear existing rows

            foreach (var si in _SubIndicators)
            {
                dgvSunIndiTable.Rows.Add(si.SubIndicator, si.SubIndicatorType, si.ScoreValue);
            }
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
            //btnSubIndSubmitEvent.Hide();

            // controls for SubIndicators
            //btnSubUpdate.Hide();
            //btnSubDelete.Hide();
        }

        private void ShowControls()
        {
            // controls of Categories
            CatUpdatebtn.Show();
            CatDeletebtn.Show();

            // controls of Indicators
            btnSubIndSubmitEvent.Show();

            // controls for SubIndicators
            btnSubIndSubmitEvent.Show();
        }

        private void CatTable()
        {
            // for Category
            dgvCatTable.Columns.Add("Category ID");
            dgvCatTable.Columns.Add("Category Title");
            Catdgv.DataSource = dgvCatTable;

        }

        private void Clear()
        {
            // for Category Entry
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
            dgvIndiTable.Columns.Add("Indicator ID");
            dgvIndiTable.Columns.Add("Indicator Number");
            dgvIndiTable.Columns.Add("Indicator");
            dgvIndiTable.Columns.Add("Type");
            dgvIndiTable.Columns.Add("Score Value");
            Indicatordgv.DataSource = dgvIndiTable;
            Indicatordgv.Columns[0].Visible = false;
        }

        private void SubIndicatorTable()
        {
            dgvSunIndiTable.Columns.Add("Sub-Indicator");
            dgvSunIndiTable.Columns.Add("Sub-Indicator Type");
            dgvSunIndiTable.Columns.Add("Score Value");
            SubIndicatorsdgv.DataSource = dgvSunIndiTable;
        }

        #endregion
    }
}
