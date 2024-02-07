using MySql.Data.MySqlClient;
using Pocket_Auditor_Admin_Panel.Auxiliaries;
using Pocket_Auditor_Admin_Panel.Classes;
using Pocket_Auditor_Admin_Panel.Forms;
using Pocket_Auditor_Admin_Panel.UserControlPanels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pocket_Auditor_Admin_Panel.Prompts
{
    public partial class prompt_Edit_ISI : Form
    {
        private string type { get; set; }

        List<mdl_Indicators> _Indicators;
        List<mdl_SubIndicators> _SubIndicators;
        List<mdl_SubCategories> _SubCategories;
        List<jmdl_IndicatorsSubInd> _jmISI;
        private int selected_id, selected_category_id;
        public DatabaseInitiator dbInit;
        readonly string indicatorName;
        readonly CDisplay_ISI parent;
        readonly AdminPanel AP;
        prompt_AddSubIndicator pASI;


        public prompt_Edit_ISI(string _buckketIndicator,
            int _selection, int _categoryID, DatabaseInitiator _bucketDB, CDisplay_ISI _parent,
            AdminPanel aP, List<mdl_SubIndicators> _bucketSI, List<mdl_SubCategories> subCategories)
        {
            //selected_id = _selection;
            //type = edit_type;
            //_Indicators = indicators;
            //_SubIndicators = subIndicators;
            _SubIndicators = _bucketSI;
            indicatorName = _buckketIndicator;
            dbInit = _bucketDB;
            selected_id = _selection;
            selected_category_id = _categoryID;

            InitializeComponent();

            tbox_EditIndicator.Text = indicatorName;
            parent = _parent;
            AP = aP;
            pASI = new prompt_AddSubIndicator(_bucketDB, this, aP);

            // The prompt will initialize with the Sub-Indicators displayed first
            PopuateSubIndicators();
            _SubCategories = subCategories;
        }



        public void PopuateSubIndicators()
        {
            btn_pnl_SI.BackColor = Color.White;
            btn_pnl_SC.BackColor = Color.Silver;
            btn_AddSubIndicator.Enabled = true;
            btn_AddSubIndicator.Visible = true;

            flp_Display.Controls.Clear();

            foreach (var data in _SubIndicators)
            {
                // Create an instance of UCM_SubIndicatorItem
                UCM_SubIndicatorItem subIndicatorItem = new UCM_SubIndicatorItem("test", dbInit, AP, this);

                // Set properties of the user control using your data
                subIndicatorItem.SubIndicatorID = data.SubIndicatorID;
                subIndicatorItem.SubIndicator = data.SubIndicator;
                subIndicatorItem.SubIndicatorType = data.SubIndicatorType;
                subIndicatorItem.SubIndicatorStatus = data.SubIndicatorStatus;
                subIndicatorItem.ScoreValue = data.ScoreValue;

                subIndicatorItem.IndicatorID = selected_id;

                MySqlConnection conn = dbInit.GetConnection();

                try
                {
                    conn.Open();

                    string checkAssociationQuery = "SELECT COUNT(*) FROM Associate_Indicator_to_SubIndicator " +
                                                   "WHERE IndicatorID_fk = @IndicatorID AND SubIndicatorID_fk = @SubIndicatorID";

                    using (MySqlCommand cmd = new MySqlCommand(checkAssociationQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@IndicatorID", selected_id);
                        cmd.Parameters.AddWithValue("@SubIndicatorID", data.SubIndicatorID);

                        int count = Convert.ToInt32(cmd.ExecuteScalar());

                        // If an entry exists, set the checkbox as checked
                        if (count > 0)
                        {
                            subIndicatorItem.State = true;
                        }
                        else
                        {
                            subIndicatorItem.State = false;
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


                // Add the UserControl to the FlowLayoutPanel
                flp_Display.Controls.Add(subIndicatorItem);
            }
        }

        public void PopulateSubCategories()
        {
            btn_pnl_SC.BackColor = Color.White;
            btn_pnl_SI.BackColor = Color.Silver;
            btn_AddSubIndicator.Enabled = false;
            btn_AddSubIndicator.Visible = false;
        }

        private void btn_ApplyEdit_Click(object sender, EventArgs e)
        {
            EditIndicator();
        }
        private void btn_Delete_Click(object sender, EventArgs e)
        {
            DeleteIndicator();
            this.Close();
        }


        private void SelectSC(object sender, EventArgs e)
        {
            PopulateSubCategories();
        }

        private void SelectSI(object sender, EventArgs e)
        {
            PopuateSubIndicators();
        }


        public void EditIndicator()
        {
            MySqlConnection conn = dbInit.GetConnection();

            try
            {
                conn.Open();

                string updateIndicatorTextQuery = "UPDATE Indicators " +
                                                  "SET Indicator = @NewIndicatorText " +
                                                  "WHERE IndicatorID = @IndicatorID";

                using (MySqlCommand cmd = new MySqlCommand(updateIndicatorTextQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@NewIndicatorText", tbox_EditIndicator.Text);
                    cmd.Parameters.AddWithValue("@IndicatorID", selected_id);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                MessageBox.Show("Indicator Successfully Edited!", "Edit Succesful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                conn.Close();
                AP._Indicators.Clear();
                AP._jmCI.Clear();
                AP.PullIndicators();
                AP.PullAssociate_CI();
                parent.PopulateIndicators(selected_category_id);
            }
        }

        public void DeleteIndicator()
        {

            MySqlConnection conn = dbInit.GetConnection();

            try
            {
                conn.Open();

                string deactivateIndicatorQuery = "UPDATE Indicators " +
                                                  "SET IndicatorStatus = 'INACTIVE' " +
                                                  "WHERE IndicatorID = @IndicatorID";

                using (MySqlCommand cmd = new MySqlCommand(deactivateIndicatorQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@IndicatorID", selected_id);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                MessageBox.Show("Indicator Deleted!", "Delete Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                conn.Close();
                AP._Indicators.Clear();
                AP._jmCI.Clear();
                AP.PullIndicators();
                AP.PullAssociate_CI();
                parent.PopulateIndicators(selected_category_id);
            }
        }

        private void btn_AddSubIndicator_Click(object sender, EventArgs e)
        {
            pASI.ShowDialog();
        }
    }
}
