using MySql.Data.MySqlClient;
using Pocket_Auditor_Admin_Panel.Auxiliaries;
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
    public partial class prompt_Edit_Category : Form
    {
        readonly DatabaseInitiator dbInit;
        readonly AdminPanel AP;
        readonly FormCategorySelect FCS;
        readonly CDisplay_ISI cDI;
        readonly int CatID;
        public prompt_Edit_Category(DatabaseInitiator _bucketDB, AdminPanel _aP, FormCategorySelect _fcs, CDisplay_ISI _cDI,
            string title, int id)
        {
            InitializeComponent();
            dbInit = _bucketDB;
            AP = _aP;
            FCS = _fcs;
            CatID = id;
            cDI = _cDI;

            tbox_Category.Text = title;
        }

        private void btn_AcceptCategory_Click(object sender, EventArgs e)
        {
            UpdateCategoryTitle(CatID, tbox_Category.Text);
            cDI.ExternalUpdate(tbox_Category.Text);
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            DeleteCategory(CatID);
            cDI.ExternalUpdate(" ");
        }



        public void UpdateCategoryTitle(int categoryID, string newTitle)
        {
            MySqlConnection conn = dbInit.GetConnection();

            try
            {
                conn.Open();

                // Update query for the "Categories" table
                string updateCategoryTitleQuery = "UPDATE categories SET CategoryTitle = @NewTitle WHERE CategoryID = @CategoryID";

                using (MySqlCommand cmd = new MySqlCommand(updateCategoryTitleQuery, conn))
                {
                    // Add parameters to the query
                    cmd.Parameters.AddWithValue("@NewTitle", newTitle);
                    cmd.Parameters.AddWithValue("@CategoryID", categoryID);

                    // Execute the query
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Category Title Successfully Updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No matching category found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                AP.PullCategories();
                FCS.PopulateCategories();
                this.Close();
            }
        }

        public void DeleteCategory(int categoryID)
        {
            MySqlConnection conn = dbInit.GetConnection();

            try
            {
                conn.Open();

                // Delete query for the "Categories" table
                string deleteCategoryQuery = "DELETE FROM categories WHERE CategoryID = @CategoryID";

                using (MySqlCommand cmd = new MySqlCommand(deleteCategoryQuery, conn))
                {
                    // Add parameter to the query
                    cmd.Parameters.AddWithValue("@CategoryID", categoryID);

                    // Execute the query
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Category Successfully Deleted!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No matching category found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                AP.PullCategories();
                FCS.PopulateCategories();
                this.Close();
            }
        }
    }
}
