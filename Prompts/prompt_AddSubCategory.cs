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

namespace Pocket_Auditor_Admin_Panel.Prompts
{
    public partial class prompt_AddSubCategory : Form
    {
        readonly DatabaseInitiator dbInit;
        readonly int categoryID;
        readonly string categoryTitle;
        public prompt_AddSubCategory(DatabaseInitiator _dbBucket, int _categoryID, string _categoryTitle)
        {
            InitializeComponent();

            dbInit = _dbBucket;
            categoryTitle = _categoryTitle;
        }


        private void InsertSubCategory()
        {
            using MySqlConnection conn = dbInit.GetConnection();

            try
            {
                conn.Open();

                // Step 1: Insert SubCategory into the SubCategory table
                string insertSubCategoryQuery = "INSERT INTO SubCategory (SubCategoryTitle, SubCategoryStatus) " +
                                                "VALUES (@SubCategoryTitle, 'ACTIVE')";

                using (MySqlCommand cmd = new MySqlCommand(insertSubCategoryQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@SubCategoryTitle", tbox_SubCategory.Text);

                    cmd.ExecuteNonQuery(); // Execute the query to insert SubCategory
                }

                // Step 2: Get the ID of the newly inserted SubCategory
                string getNewSubCategoryIdQuery = "SELECT LAST_INSERT_ID()";

                int subCategoryId;

                using (MySqlCommand idCmd = new MySqlCommand(getNewSubCategoryIdQuery, conn))
                {
                    subCategoryId = Convert.ToInt32(idCmd.ExecuteScalar());
                }

                // Step 3: Associate SubCategory with the specified Category
                string associateSubCategoryQuery = "INSERT INTO Associate_Category_to_SubCategory (CategoryID_fk, SubCategoryID_fk) " +
                                                   "VALUES (@CategoryID, @SubCategoryID)";

                using (MySqlCommand associateCmd = new MySqlCommand(associateSubCategoryQuery, conn))
                {
                    associateCmd.Parameters.AddWithValue("@CategoryID", categoryID);
                    associateCmd.Parameters.AddWithValue("@SubCategoryID", subCategoryId);

                    associateCmd.ExecuteNonQuery(); // Execute the query to associate SubCategory with Category
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
