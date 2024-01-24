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
    public partial class prompt_AddCategory : Form
    {
        readonly DatabaseInitiator dbInit;
        readonly AdminPanel AP;
        readonly FormCategorySelect parent;
        public prompt_AddCategory(DatabaseInitiator _bucketDB, AdminPanel _aP, FormCategorySelect _parent)
        {
            InitializeComponent();
            dbInit = _bucketDB;
            AP = _aP;
            parent = _parent;
        }

        private void btn_AcceptCategory_Click(object sender, EventArgs e)
        {
            InsertCategory(tbox_Category.Text, "ACTIVE");
        }

        public void InsertCategory(string categoryTitle, string categoryStatus)
        {
            MySqlConnection conn = dbInit.GetConnection();

            try
            {
                conn.Open();

                // Insert query for the "Categories" table
                string insertCategoryQuery = "INSERT INTO Categories (CategoryTitle, CategoryStatus) VALUES (@CategoryTitle, @CategoryStatus)";

                using (MySqlCommand cmd = new MySqlCommand(insertCategoryQuery, conn))
                {
                    // Add parameters to the query
                    cmd.Parameters.AddWithValue("@CategoryTitle", categoryTitle);
                    cmd.Parameters.AddWithValue("@CategoryStatus", categoryStatus);

                    // Execute the query
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Category Successfully Inserted!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                parent.PopulateCategories();
                this.Close();
            }
        }
    }
}
