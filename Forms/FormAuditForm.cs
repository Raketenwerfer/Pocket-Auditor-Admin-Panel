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

        string __bucketIndType;


        AdminPanel AP;

        // Declare a list to store SubIndicators and their associations
        List<Tuple<string, string, double>> subIndicatorsList = new List<Tuple<string, string, double>>();


        int sel { get; set; }
        bool isSubIndEditMode { get; set; }

        public FormAuditForm(DatabaseInitiator _dbBUcket, List<mdl_Categories> __categories,
            List<mdl_Indicators> __indicators, List<mdl_SubIndicators> __subindicators,
            List<jmdl_IndicatorsSubInd> __jmISI, List<jmdl_CategoriesIndicators> __jmCI, AdminPanel aP)
        {
            _Categories = __categories;
            _Indicators = __indicators;
            _SubIndicators = __subindicators;
            _jmISI = __jmISI;
            _jmCI = __jmCI;

            dbInit = _dbBUcket;
            InitializeComponent();

            __bucketIndType = "SINGLE";
            SubIndicatorscbx.Checked = false;
            AP = aP;
        }

        private void FormAuditForm_Load(object sender, EventArgs e)
        {
            CatTable();
            IndicatorTable();
            SubIndicatorTable();

            SetCboxItems();

            UpdateCatDataTable();
            UpdateIndiDataTable();

            CatIDcbx.SelectedIndex = 0;
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

            // Call the method to insert the category into the database
            InsertCategory(txtCatName.Text);

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
            // Check if a category is selected in the DataGridView
            if (Catdgv.SelectedRows.Count > 0)
            {
                // Get the CategoryID from the selected row
                int categoryID = Convert.ToInt32(Catdgv.SelectedRows[0].Cells[0].Value);

                // Call the method to delete the category from the database
                DeleteCategory(categoryID);

                MessageBox.Show("Data Successfully Deleted!");

                Clear();
            }
            else
            {
                MessageBox.Show("Please select a category to delete.");
            }
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
                string.IsNullOrEmpty(IndicatorNumbertxt.Text) || string.IsNullOrEmpty(IndicatorNumbertxt.Text))
            {
                MessageBox.Show("Please Select and input a data.");
                return;
            }
            else
            {
                InsertIndicator();
                _jmCI.Clear();
                _Indicators.Clear();
                AP.PullIndicators();
                AP.PullAssociate_CI();
                UpdateIndiDataTable();

                SubIndicatorscbx.Checked = false;
                if (Indicatordgv.Enabled == false)
                {
                    Indicatordgv.Enabled = true;
                }
            }

            Clear();
            ShowControls();
        }

        private void Indicatordgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;

            prompt_Edit_ISI EditPrompt = new prompt_Edit_ISI("indicator", sel, _Indicators, _SubIndicators, _jmISI);
            EditPrompt.Show();
        }

        private void Indicatordgv_CellClick(object sender, DataGridViewCellEventArgs e)
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

            if (!Indicatordgv.SelectedCells[3].Value.Equals("COMPOSITE"))
            {
                pnlSubIndicators.Visible = false;
            }
            else
            {
                pnlSubIndicators.Visible = true;
            }


            isSubIndEditMode = true;
            btnSubIndSubmitEvent.Text = "EDIT";
            label3.Visible = false;
            label6.Visible = false;
            label9.Visible = false;
            txtSubIndicators.Visible = false;
            cbxType.Visible = false;
            num_SubIndicatorSV.Visible = false;
            btnAttachExisting.Visible = false;



            UpdateSubIndiDataTable();
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
            CatIDcbx.Items.Clear();

            foreach (var cat in _Categories)
            {
                CatIDcbx.Items.Add(cat.CategoryTitle);
            }

            num_IndicatorSV.Value = 1;
            num_SubIndicatorSV.Value = 1;
        }
        private void CatIDcbx_SelectedIndexChanged(object sender, EventArgs e)
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
                btnAttachExisting.Visible = true;
                dgvSunIndiTable.Rows.Clear();
                __bucketIndType = "COMPOSITE";
                num_IndicatorSV.Value = 0;
                num_IndicatorSV.Enabled = false;
            }
            else
            {
                __bucketIndType = "SINGLE";
                pnlSubIndicators.Hide();
                Indicatordgv.Enabled = true;
                num_IndicatorSV.Enabled = true;
            }
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
                ListSubIndicator();
            }
        }


        private void btnAttachExisting_Click(object sender, EventArgs e)
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

        private void cbxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxType.Text == "OPTIONS")
            {
                num_SubIndicatorSV.Enabled = true;
            }
            else if (cbxType.Text == "DETAILS")
            {
                num_SubIndicatorSV.Enabled = false;
                num_SubIndicatorSV.Value = 0;
            }
        }

        #endregion


        #region Insert Methods

        public void InsertIndicator()
        {
            int _indNo;
            double _indScoreValue;
            string _indTitle, _indStatus, _indType;

            int passID = 0;

            _indTitle = Indicatortxt.Text;
            _indStatus = "ACTIVE";
            _indNo = Convert.ToInt32(IndicatorNumbertxt.Text);
            _indScoreValue = Convert.ToDouble(num_IndicatorSV.Value);
            _indType = __bucketIndType;

            MySqlConnection conn = dbInit.GetConnection();

            try
            {
                conn.Open();

                // Step 1: Insert the indicator into the Indicators table
                string insertIndicatorQuery = "INSERT INTO Indicators (IndicatorNumber, ScoreValue, Indicator, IndicatorStatus, IndicatorType) " +
                                              "VALUES (@IndicatorNumber, @ScoreValue, @Indicator, @IndicatorStatus, @IndicatorType)";

                using (MySqlCommand cmd = new MySqlCommand(insertIndicatorQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@IndicatorNumber", _indNo);
                    cmd.Parameters.AddWithValue("@ScoreValue", _indScoreValue);
                    cmd.Parameters.AddWithValue("@Indicator", _indTitle);
                    cmd.Parameters.AddWithValue("@IndicatorStatus", _indStatus);
                    cmd.Parameters.AddWithValue("@IndicatorType", _indType);

                    cmd.ExecuteNonQuery(); // Execute the query to insert the indicator

                    // Get the ID of the newly inserted Indicator
                    string getNewIndicatorIDQuery = "SELECT LAST_INSERT_ID()";

                    using (MySqlCommand idCmd = new MySqlCommand(getNewIndicatorIDQuery, conn))
                    {
                        passID = Convert.ToInt32(idCmd.ExecuteScalar());
                    }

                    // Step 2: Insert the association into the Associate_Category_to_Indicator table
                    string getCategoryIDQuery = "SELECT CategoryID FROM Categories WHERE CategoryTitle = @CategoryTitle";

                    using (MySqlCommand categoryCmd = new MySqlCommand(getCategoryIDQuery, conn))
                    {
                        categoryCmd.Parameters.AddWithValue("@CategoryTitle", CatIDcbx.Text);

                        int categoryID = Convert.ToInt32(categoryCmd.ExecuteScalar());

                        string insertAssociationQuery = "INSERT INTO Associate_Category_to_Indicator (CategoryID_fk, IndicatorID_fk) " +
                                                       "VALUES (@CategoryID, LAST_INSERT_ID())";

                        using (MySqlCommand associationCmd = new MySqlCommand(insertAssociationQuery, conn))
                        {
                            associationCmd.Parameters.AddWithValue("@CategoryID", categoryID);

                            int rowsAffected = associationCmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Data Successfully Inserted and Associated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Association failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();

                if (SubIndicatorscbx.Checked)
                {
                    InsertSubIndicator(passID);
                    subIndicatorsList.Clear();
                    _jmISI.Clear();
                    _SubIndicators.Clear();
                    AP.PullSubIndicators();
                    AP.PullAssociate_ISI();
                    UpdateSubIndiDataTable();
                }
            }
        }

        public void ListSubIndicator()
        {
            string _subind, _subindtype;
            double _subindSV;

            _subind = txtSubIndicators.Text;
            _subindtype = cbxType.Text;
            _subindSV = Convert.ToDouble(num_SubIndicatorSV.Value);


            // Add SubIndicators to the list (call this in your SubIndicator insertion logic)
            subIndicatorsList.Add(Tuple.Create(_subind, _subindtype, _subindSV));

            dgvSunIndiTable.Rows.Add(_subind, _subindtype, _subindSV);
        }

        public void InsertSubIndicator(int _indIDbucket)
        {
            MySqlConnection conn = dbInit.GetConnection();

            try
            {
                conn.Open();

                // After inserting the Indicator and getting its IndicatorID
                int indicatorID = _indIDbucket; // Assuming you have the IndicatorID, replace it with the actual value

                // Loop through the list and insert SubIndicators and their associations
                foreach (var subIndicator in subIndicatorsList)
                {
                    string _subind = subIndicator.Item1;
                    string _subindtype = subIndicator.Item2;
                    double _subindSV = subIndicator.Item3;

                    // Insert SubIndicator into the SubIndicators table
                    string insertSubIndicatorQuery = "INSERT INTO SubIndicators (SubIndicator, SubIndicatorType, ScoreValue, SubIndicatorStatus) " +
                                                     "VALUES (@SubIndicator, @SubIndicatorType, @ScoreValue, 'ACTIVE')";

                    using (MySqlCommand cmd = new MySqlCommand(insertSubIndicatorQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@SubIndicator", _subind);
                        cmd.Parameters.AddWithValue("@SubIndicatorType", _subindtype);
                        cmd.Parameters.AddWithValue("@ScoreValue", _subindSV);

                        cmd.ExecuteNonQuery(); // Execute the query to insert the SubIndicator
                    }

                    // Get the SubIndicatorID of the newly inserted SubIndicator
                    string getSubIndicatorIDQuery = "SELECT LAST_INSERT_ID()";

                    using (MySqlCommand cmd = new MySqlCommand(getSubIndicatorIDQuery, conn))
                    {
                        int subIndicatorID = Convert.ToInt32(cmd.ExecuteScalar());

                        // Insert the association into the Associate_Indicator_to_SubIndicator table
                        string insertAssociationQuery = "INSERT INTO Associate_Indicator_to_SubIndicator (IndicatorID_fk, SubIndicatorID_fk) " +
                                                       "VALUES (@IndicatorID, @SubIndicatorID)";

                        using (MySqlCommand associationCmd = new MySqlCommand(insertAssociationQuery, conn))
                        {
                            associationCmd.Parameters.AddWithValue("@IndicatorID", indicatorID);
                            associationCmd.Parameters.AddWithValue("@SubIndicatorID", subIndicatorID);

                            int rowsAffected = associationCmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                            }
                            else
                            {
                                MessageBox.Show("Association failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }


        // Method to insert a new category into the database
        private void InsertCategory(string categoryName)
        {
            MySqlConnection conn = dbInit.GetConnection();

            try
            {
                conn.Open();

                string insertCategoryQuery = "INSERT INTO Categories (CategoryTitle, CategoryStatus) " +
                                            "VALUES (@CategoryTitle, 'ACTIVE')";

                using (MySqlCommand cmd = new MySqlCommand(insertCategoryQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@CategoryTitle", categoryName);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        // Method to delete a category from the database
        private void DeleteCategory(int categoryID)
        {
            MySqlConnection conn = dbInit.GetConnection();

            try
            {
                conn.Open();

                string deleteCategoryQuery = "UPDATE Categories SET CategoryStatus = 'INACTIVE' " +
                                             "WHERE CategoryID = @CategoryID";

                using (MySqlCommand cmd = new MySqlCommand(deleteCategoryQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@CategoryID", categoryID);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
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

            foreach (var i in _jmCI.Where(x => x.CategoryTitle.Equals(CatIDcbx.Text)))
            {
                dgvIndiTable.Rows.Add(i.IndicatorID, i.IndicatorNumber, i.Indicator, i.IndicatorType, i.ScoreValue);
            }
        }

        private void UpdateSubIndiDataTable()
        {
            dgvSunIndiTable.Rows.Clear(); // Clear existing rows

            foreach (jmdl_IndicatorsSubInd j in _jmISI)
            {
                if (sel == j.IndicatorID_fk)
                {
                    dgvSunIndiTable.Rows.Add(j.SubIndicator, j.SubIndicatorType, j.ScoreValue);
                }
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
            // controls of Indicators
            btnSubIndSubmitEvent.Show();

            // controls for SubIndicators
            btnSubIndSubmitEvent.Show();
        }

        private void EnableCatBtn()
        {
            // controls of Categories
            CatUpdatebtn.Enabled = true;
            CatDeletebtn.Enabled = true;
        }

        private void DisableCatBtn()
        {
            CatUpdatebtn.Enabled = false;
            CatDeletebtn.Enabled = false;
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
