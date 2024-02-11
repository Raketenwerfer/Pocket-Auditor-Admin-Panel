using MySql.Data.MySqlClient;
using Pocket_Auditor_Admin_Panel.Auxiliaries;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pocket_Auditor_Admin_Panel.UserControlPanels
{
    public partial class UCM_AssociateSubCategoryItem : UserControl
    {
        private int selected_id;
        readonly DatabaseInitiator dbInit;
        public UCM_AssociateSubCategoryItem(DatabaseInitiator _bucketDB)
        {
            InitializeComponent();
            dbInit = _bucketDB;
        }

        private int _subcategoryID;
        private string _subcategoryTitle;
        private string _subcategoryStatus;
        private bool _state;

        public int SubCategoryID
        {
            get { return _subcategoryID; }
            set
            {
                _subcategoryID = value;
            }
        }
        public int IndicatorID
        {
            get { return selected_id; }
            set
            {
                selected_id = value;
            }
        }
        public string SubCategoryTitle
        {
            get { return _subcategoryTitle; }
            set
            {
                _subcategoryTitle = value;
                cbox_SubCategory.Text = _subcategoryTitle;
            }

        }
        public string SubCategoryStatus
        {
            get { return _subcategoryStatus; }
            set
            {
                _subcategoryStatus = value;
            }
        }
        public bool State
        {
            get { return _state; }
            set
            {
                _state = value;
                cbox_SubCategory.Checked = _state;
            }
        }
        public void AssociateSubCategory(int indicatorID, int subCategoryID)
        {
            MySqlConnection conn = dbInit.GetConnection();

            try
            {
                conn.Open();

                string insertAssociationQuery = "INSERT INTO Associate_Indicator_to_SubCategory (IndicatorID_fk, SubCategoryID_fk) " +
                                               "VALUES (@IndicatorID, @SubCategoryID)";

                using (MySqlCommand cmd = new MySqlCommand(insertAssociationQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@IndicatorID", indicatorID);
                    cmd.Parameters.AddWithValue("@SubCategoryID", subCategoryID);

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

        public void DisassociateSubCategory(int indicatorID, int subCategoryID)
        {
            MySqlConnection conn = dbInit.GetConnection();

            try
            {
                conn.Open();

                string deleteAssociationQuery = "DELETE FROM Associate_Indicator_to_SubCategory " +
                                                "WHERE IndicatorID_fk = @IndicatorID AND SubCategoryID_fk = @SubCategoryID";

                using (MySqlCommand cmd = new MySqlCommand(deleteAssociationQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@IndicatorID", indicatorID);
                    cmd.Parameters.AddWithValue("@SubCategoryID", subCategoryID);

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


        private void cbox_SubCategory_MouseDown(object sender, MouseEventArgs e)
        {
            if (cbox_SubCategory.Checked == false)
            {
                AssociateSubCategory(selected_id, SubCategoryID);
            }
            else
            {
                DisassociateSubCategory(selected_id, SubCategoryID);
            }
        }
    }
}
