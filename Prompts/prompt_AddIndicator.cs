using MySql.Data.MySqlClient;
using Pocket_Auditor_Admin_Panel.Auxiliaries;
using Pocket_Auditor_Admin_Panel.Classes;
using Pocket_Auditor_Admin_Panel.Forms;
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
    public partial class prompt_AddIndicator : Form
    {
        readonly DatabaseInitiator dbInit;
        readonly string SelectedCategory;
        readonly int SelectedCategoryID;
        readonly AdminPanel AP;
        readonly CDisplay_ISI parent;
        public prompt_AddIndicator(DatabaseInitiator _bucketDB, string _bucketCategory, int _bCateID, AdminPanel aP, CDisplay_ISI _parent)
        {
            parent = _parent;
            dbInit = _bucketDB;
            SelectedCategory = _bucketCategory;
            SelectedCategoryID = _bCateID;
            AP = aP;
            InitializeComponent();
        }


        private void btn_AcceptIndicator_Click(object sender, EventArgs e)
        {
            InsertIndicator();
        }

        public void InsertIndicator()
        {
            double _indScoreValue;
            string _indTitle, _indStatus, _indType;

            int passID = 0;

            _indTitle = tbox_Indicator.Text;
            _indStatus = "ACTIVE";
            _indScoreValue = 1;

            MySqlConnection conn = dbInit.GetConnection();

            try
            {
                conn.Open();

                // Step 1: Insert the indicator into the Indicators table
                string insertIndicatorQuery = "INSERT INTO indicators (ScoreValue, Indicator, IndicatorStatus, IndicatorType) " +
                                              "VALUES (@ScoreValue, @Indicator, @IndicatorStatus, @IndicatorType)";

                using (MySqlCommand cmd = new MySqlCommand(insertIndicatorQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@ScoreValue", _indScoreValue);
                    cmd.Parameters.AddWithValue("@Indicator", _indTitle);
                    cmd.Parameters.AddWithValue("@IndicatorStatus", _indStatus);

                    cmd.ExecuteNonQuery(); // Execute the query to insert the indicator

                    // Get the ID of the newly inserted Indicator
                    string getNewIndicatorIDQuery = "SELECT LAST_INSERT_ID()";

                    using (MySqlCommand idCmd = new MySqlCommand(getNewIndicatorIDQuery, conn))
                    {
                        passID = Convert.ToInt32(idCmd.ExecuteScalar());
                    }

                    // Step 2: Insert the association into the Associate_Category_to_Indicator table
                    string getCategoryIDQuery = "SELECT CategoryID FROM categories WHERE CategoryTitle = @CategoryTitle";

                    using (MySqlCommand categoryCmd = new MySqlCommand(getCategoryIDQuery, conn))
                    {
                        categoryCmd.Parameters.AddWithValue("@CategoryTitle", SelectedCategory);

                        int categoryID = Convert.ToInt32(categoryCmd.ExecuteScalar());

                        string insertAssociationQuery = "INSERT INTO associate_category_to_indicator (CategoryID_fk, IndicatorID_fk) " +
                                                       "VALUES (@CategoryID, LAST_INSERT_ID())";

                        using (MySqlCommand associationCmd = new MySqlCommand(insertAssociationQuery, conn))
                        {
                            associationCmd.Parameters.AddWithValue("@CategoryID", categoryID);

                            int rowsAffected = associationCmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Indicator Successfully Added!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

                AP.PullIndicators();
                AP.PullAssociate_CI();
                parent.PopulateIndicators(SelectedCategoryID);
                this.Close();
            }
        }
    }
}
