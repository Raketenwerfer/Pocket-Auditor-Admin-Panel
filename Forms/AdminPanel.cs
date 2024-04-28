using Pocket_Auditor_Admin_Panel.Forms;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Pocket_Auditor_Admin_Panel.Auxiliaries;
using Pocket_Auditor_Admin_Panel.Classes;
using Pocket_Auditor_Admin_Panel.Prompts;

namespace Pocket_Auditor_Admin_Panel
{
    public partial class AdminPanel : Form
    {
        readonly DatabaseInitiator dbInit = new DatabaseInitiator("sql.freedb.tech", "freedb_ccydc_db", "freedb_ccydc", "uFjK7Gr&SGG@!z5");
        public DataSharingService DSS = new DataSharingService();
        // Online Database credentials "sql.freedb.tech", "freedb_ccydc_test_db", "freedb_ccydc", "r*kmjEa6N#KUsDN"
        //readonly FormAuditForm frmAuditForm;
        readonly FormCategorySelect frmCateSel;
        //readonly CDisplay_ISI cDisplayISI;


        public List<mdl_Categories> _Categories = new List<mdl_Categories>();
        public List<mdl_SubIndicators> _SubIndicators = new List<mdl_SubIndicators>();
        public List<mdl_Indicators> _Indicators = new List<mdl_Indicators>();
        public List<mdl_SubCategories> _SubCategories = new List<mdl_SubCategories>();

        public List<jmdl_IndicatorsSubInd> _jmISI = new List<jmdl_IndicatorsSubInd>();
        public List<jmdl_CategoriesIndicators> _jmCI = new List<jmdl_CategoriesIndicators>();
        public List<jmdl_CategoriesSubCategories> _jmCSC = new List<jmdl_CategoriesSubCategories>();
        public List<jmdl_IndicatorSubCat> _jmISC = new List<jmdl_IndicatorSubCat>();

        public List<mdl_ScoreTable> _ScoreTable = new List<mdl_ScoreTable>();
        public List<mdl_SKChapters> _Chapters = new List<mdl_SKChapters>();
        public List<mdl_ActionPlans> _ActionPlans = new List<mdl_ActionPlans>();
        public List<mdl_Users> _Users = new List<mdl_Users>();

        public int InitCategory;

        public AdminPanel()
        {
            DSS = DataSharingService.GetInstance();
            DSS.SetDatabase(dbInit);

            InitializeComponent();
            InitDatabase();

            frmCateSel = new FormCategorySelect(dbInit, _jmCI, _SubIndicators, _SubCategories, this, InitCategory,
                _Categories, _jmCSC, _jmISC);

            InitDashboard();

            try
            {
                InitCategory = _Categories[0].CategoryID;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void AuthChallenge()
        {
            prompt_Login LP = new prompt_Login(_Users);
            LP.ShowDialog();
            if (!DSS.GET_LOGGEDIN())
            {
                this.Close();
            }

        }

        public void InitDatabase()
        {
            // Establishes connection with the database
            using MySqlConnection conn = dbInit.GetConnection();

            if (TestDatabaseConnection())
            {
                PullCategories();
                PullSubCategories();
                PullIndicators();
                PullSubIndicators();
                PullAssociate_ISI();
                PullAssociate_CI();
                PullAssociate_CSC();
                PullAssociate_ISC();
                PullScoreTable();
                PullChapters();
                PullActionPlans();
                PullUsers();

                MessageBox.Show("Database connection successful!", "Connection Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No database established! Check your internet connection!", "Connection Status", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool TestDatabaseConnection()
        {
            MySqlConnection conn = dbInit.GetConnection();

            try
            {
                // Attempt to open a connection to the database
                conn.Open();

                return true; // If opening the connection was successful
            }
            catch (Exception ex)
            {
                // Handle the exception or log it
                Console.WriteLine($"Error: {ex.Message}");
                return false; // If opening the connection failed
            }
            finally
            {
                conn.Close();
            }
        }

        #region UI Controls
        public void InitDashboard()
        {
            FormDashboard frmDashboard = new FormDashboard(this);
            frmDashboard.TopLevel = false;
            frmDashboard.TopMost = true;
            panelContent.Controls.Clear();
            panelContent.Controls.Add(frmDashboard);
            frmDashboard.Show();
            frmDashboard.PopulateRanks();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            InitDashboard();
        }

        public void btnAuditForm_Click(object sender, EventArgs e)
        {
            frmCateSel.TopLevel = false;
            frmCateSel.TopMost = true;
            panelContent.Controls.Clear();
            panelContent.AutoScroll = true;
            panelContent.Controls.Add(frmCateSel);
            frmCateSel.Show();
        }

        public void btnActionPlans_Click(object sender, EventArgs e)
        {
            FormActionPlans frmActionPlans = new FormActionPlans(this);
            PullActionPlans();
            frmActionPlans.TopLevel = false;
            frmActionPlans.TopMost = true;
            panelContent.Controls.Clear();
            panelContent.AutoScroll = true;
            panelContent.Controls.Add(frmActionPlans);
            frmActionPlans.Show();
        }

        public void btnAuditReports_Click(object sender, EventArgs e)
        {
            FormAuditReports frmAuditReports = new FormAuditReports(dbInit, this);
            PullScoreTable();
            frmAuditReports.TopLevel = false;
            frmAuditReports.TopMost = true;
            panelContent.Controls.Clear();
            panelContent.AutoScroll = true;
            panelContent.Controls.Add(frmAuditReports);
            frmAuditReports.Show();
        }

        private void btnManageAuditors_Click(object sender, EventArgs e)
        {
            FormManageAuditors frmManageAuditors = new FormManageAuditors(this);
            frmManageAuditors.TopLevel = false;
            frmManageAuditors.TopMost = true;
            panelContent.Controls.Clear();
            panelContent.AutoScroll = true;
            panelContent.Controls.Add(frmManageAuditors);
            frmManageAuditors.Show();
        }

        private void AdminPanel_Load(object sender, EventArgs e)
        {
            AuthChallenge();
        }
        #endregion


        public void ShowUserControlsPrompt(string type, int? id)
        {
            prompt_ECUser pEC = new prompt_ECUser(type, id, this);
            pEC.ShowDialog();
        }


        #region Pull Data

        public void PullCategories()
        {
            _Categories.Clear();

            // Initialize placeholder variables
            int _catID;
            string _catTitle, _catStatus;

            // Query string to command our databse
            string getCatQuery = "SELECT * FROM categories WHERE CategoryStatus = 'ACTIVE'";

            // Establish a new connection instance to the database
            MySqlConnection conn = dbInit.GetConnection();

            try
            {
                // Open the connection
                conn.Open();

                // Initiate a new command by supplying the query string and connection instance
                using (MySqlCommand cmd = new MySqlCommand(getCatQuery, conn))
                {
                    // Execute and read the command. Pull commands will return a table list
                    using (MySqlDataReader read = cmd.ExecuteReader())
                    {
                        // `while` loop reads through each row
                        while (read.Read())
                        {
                            // Placeholder variables will temporarily store each cell based on their columns
                            // from the database. It will do this for each row in the table
                            _catID = read.GetInt32(read.GetOrdinal("CategoryID"));
                            _catTitle = read.GetString(read.GetOrdinal("CategoryTitle"));
                            _catStatus = read.GetString(read.GetOrdinal("CategoryStatus"));

                            // A placeholder or `bucket` object is created to temporarily hold the data of the
                            // row being currently read
                            mdl_Categories a = new mdl_Categories(_catID, _catTitle, _catStatus);
                            {
                                a.CategoryID = _catID;
                                a.CategoryTitle = _catTitle;
                                a.CategoryStatus = _catStatus;
                            }

                            // Finally adding the current row from the bucket object into the primary List object for displaying
                            // in a DataGridView
                            _Categories.Add(a);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                // The most important part! This closes the connection so another connection can be opened
                DSS.SET_C(_Categories);
                conn.Close();
            }
        }

        public void PullSubCategories()
        {
            _SubCategories.Clear();

            string query = "SELECT * FROM subcategory";

            MySqlConnection conn = dbInit.GetConnection();

            try
            {
                conn.Open();

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Extract data from the reader and create an instance of mdl_SubCategories
                            int id = reader.GetInt32(reader.GetOrdinal("SubCategoryID"));
                            string title = reader.GetString(reader.GetOrdinal("SubCategoryTitle"));
                            string status = reader.GetString(reader.GetOrdinal("SubCategoryStatus"));

                            // Create an instance of mdl_SubCategories and add it to the list
                            mdl_SubCategories subCategory = new mdl_SubCategories(id, title, status);
                            _SubCategories.Add(subCategory);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        public void PullIndicators()
        {
            _Indicators.Clear();

            int _indID;
            double _indScoreValue;
            string _indTitle, _indStatus, _indType;

            string getIndQuery = "SELECT * From indicators WHERE IndicatorStatus = 'ACTIVE'";

            MySqlConnection conn = dbInit.GetConnection();

            try
            {
                conn.Open();

                using (MySqlCommand cmd = new MySqlCommand(getIndQuery, conn))
                {
                    using (MySqlDataReader read = cmd.ExecuteReader())
                    {
                        while (read.Read())
                        {
                            _indID = read.GetInt32(read.GetOrdinal("IndicatorID"));
                            _indScoreValue = read.GetDouble(read.GetOrdinal("ScoreValue"));
                            _indTitle = read.GetString(read.GetOrdinal("Indicator"));
                            _indStatus = read.GetString(read.GetOrdinal("IndicatorStatus"));

                            mdl_Indicators a = new mdl_Indicators(_indID, _indScoreValue, _indTitle, _indStatus);
                            {
                                a.IndicatorID = _indID;
                                a.ScoreValue = _indScoreValue;
                                a.Indicator = _indTitle;
                                a.IndicatorStatus = _indStatus;
                            }

                            _Indicators.Add(a);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        public void PullSubIndicators()
        {
            _SubIndicators.Clear();

            int _subIndID;
            string _subIndTitle, _subIndType, _subIndStatus;
            double _subIndScoreValue;

            string getSubIndQuery = "SELECT * FROM subindicators WHERE SubIndicatorStatus = 'ACTIVE'";

            MySqlConnection conn = dbInit.GetConnection();

            try
            {
                conn.Open();

                using (MySqlCommand cmd = new MySqlCommand(getSubIndQuery, conn))
                {
                    using (MySqlDataReader read = cmd.ExecuteReader())
                    {
                        while (read.Read())
                        {
                            _subIndID = read.GetInt32(read.GetOrdinal("SubIndicatorID"));
                            _subIndTitle = read.GetString(read.GetOrdinal("SubIndicator"));
                            _subIndType = read.GetString(read.GetOrdinal("SubIndicatorType"));
                            _subIndStatus = read.GetString(read.GetOrdinal("SubIndicatorStatus"));
                            _subIndScoreValue = read.GetDouble(read.GetOrdinal("ScoreValue"));

                            mdl_SubIndicators a = new mdl_SubIndicators(_subIndID, _subIndTitle, _subIndType, _subIndStatus, _subIndScoreValue);
                            {
                                a.SubIndicatorID = _subIndID;
                                a.SubIndicator = _subIndTitle;
                                a.SubIndicatorType = _subIndType;
                                a.SubIndicatorStatus = _subIndStatus;
                                a.ScoreValue = _subIndScoreValue;
                            }

                            _SubIndicators.Add(a);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        public void PullAssociate_ISI()
        {
            _jmISI.Clear();

            int indicatorFK, subindicatorFK;
            double subindSV;
            string indicator, subind, subindtype, subindstatus;

            string query = "SELECT S.SubIndicatorID, S.SubIndicator, S.SubIndicatorType, S.SubIndicatorStatus, S.ScoreValue, " +
                "I.IndicatorID, I.Indicator " +
                "FROM associate_indicator_to_subindicator AtISI " +
                "INNER JOIN subindicators S on AtISI.SubIndicatorID_fk = S.SubIndicatorID " +
                "INNER JOIN indicators I on AtISI.IndicatorID_fk = I.IndicatorID " +
                "WHERE (S.SubIndicatorStatus = 'ACTIVE' AND I.IndicatorStatus = 'ACTIVE') " +
                "OR (S.SubIndicatorStatus = 'ACTIVE' AND I.IndicatorStatus = 'INACTIVE') " +
                "ORDER BY S.SubIndicatorID, I.IndicatorID ASC";

            MySqlConnection conn = dbInit.GetConnection();

            try
            {
                conn.Open();

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    using (MySqlDataReader read = cmd.ExecuteReader())
                    {
                        while (read.Read())
                        {
                            indicatorFK = read.GetInt32(read.GetOrdinal("IndicatorID"));
                            indicator = read.GetString(read.GetOrdinal("Indicator"));
                            subindicatorFK = read.GetInt32(read.GetOrdinal("SubIndicatorID"));
                            subind = read.GetString(read.GetOrdinal("SubIndicator"));
                            subindtype = read.GetString(read.GetOrdinal("SubIndicatorType"));
                            subindstatus = read.GetString(read.GetOrdinal("SubIndicatorStatus"));
                            subindSV = read.GetDouble(read.GetOrdinal("ScoreValue"));

                            jmdl_IndicatorsSubInd a = new jmdl_IndicatorsSubInd(subindicatorFK, subind,
                                subindtype, subindstatus, subindSV, indicatorFK, indicator);
                            {
                                a.SubIndicatorID_fk = subindicatorFK;
                                a.SubIndicator = subind;
                                a.SubIndicatorType = subindtype;
                                a.SubIndicatorStatus = subindstatus;
                                a.ScoreValue = subindSV;
                                a.IndicatorID_fk = indicatorFK;
                                a.Indicator = indicator;
                            }

                            _jmISI.Add(a);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        public void PullAssociate_CI()
        {
            _jmCI.Clear();

            int indicatorID, categoryID;
            string catTitle, indicator, indType;
            double indScoreValue;

            string query = "SELECT C.CategoryID, C.CategoryTitle, I.IndicatorID, I.Indicator, I.ScoreValue " +
                "FROM associate_category_to_indicator AtC " +
                "INNER JOIN categories C on AtC.CategoryID_fk = C.CategoryID " +
                "INNER JOIN indicators I on AtC.IndicatorID_fk = I.IndicatorID " +
                "WHERE (C.CategoryStatus = 'ACTIVE' AND I.IndicatorStatus = 'ACTIVE')";

            MySqlConnection conn = dbInit.GetConnection();

            try
            {
                conn.Open();

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    using (MySqlDataReader read = cmd.ExecuteReader())
                    {
                        while (read.Read())
                        {
                            indicatorID = read.GetInt32(read.GetOrdinal("IndicatorID"));
                            indicator = read.GetString(read.GetOrdinal("Indicator"));
                            categoryID = read.GetInt32(read.GetOrdinal("CategoryID"));
                            catTitle = read.GetString(read.GetOrdinal("CategoryTitle"));
                            indScoreValue = read.GetDouble(read.GetOrdinal("ScoreValue"));

                            jmdl_CategoriesIndicators a = new jmdl_CategoriesIndicators(categoryID, catTitle, indicatorID,
                                indicator, indScoreValue);
                            {
                                a.CategoryID = categoryID;
                                a.CategoryTitle = catTitle;
                                a.IndicatorID = indicatorID;
                                a.Indicator = indicator;
                                a.ScoreValue = indScoreValue;
                            }

                            _jmCI.Add(a);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        public void PullAssociate_CSC()
        {
            _jmCSC.Clear();

            string query = "SELECT SC.SubCategoryID, SC.SubCategoryTitle, SC.SubCategoryStatus, " +
                           "C.CategoryID, C.CategoryTitle, C.CategoryStatus " +
                           "FROM subcategory SC " +
                           "JOIN associate_category_to_subcategory ACSC ON SC.SubCategoryID = ACSC.SubCategoryID_fk " +
                           "JOIN categories C ON ACSC.CategoryID_fk = C.CategoryID";

            using MySqlConnection conn = dbInit.GetConnection();

            try
            {
                conn.Open();

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Extract data from the reader and create an instance of jmdl_CategoriesSubCategories
                            int categoryId = reader.GetInt32(reader.GetOrdinal("CategoryID"));
                            int subcategoryId = reader.GetInt32(reader.GetOrdinal("SubCategoryID"));
                            string categoryTitle = reader.GetString(reader.GetOrdinal("CategoryTitle"));
                            string subCategoryTitle = reader.GetString(reader.GetOrdinal("SubCategoryTitle"));
                            string subCategoryStatus = reader.GetString(reader.GetOrdinal("SubCategoryStatus"));

                            // Create an instance of jmdl_CategoriesSubCategories and add it to the list
                            jmdl_CategoriesSubCategories association = new jmdl_CategoriesSubCategories(categoryId,
                                subcategoryId, categoryTitle, subCategoryTitle, subCategoryStatus);
                            _jmCSC.Add(association);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        public void PullAssociate_ISC()
        {
            _jmISC.Clear();

            string query = "SELECT " +
               "AIS.IndicatorID_fk, I.Indicator, ACSC.CategoryID_fk, AIS.SubCategoryID_fk, " +
               "SC.SubCategoryTitle, SC.SubCategoryStatus " +
               "FROM associate_indicator_to_subcategory AIS " +
               "JOIN indicators I ON AIS.IndicatorID_fk = I.IndicatorID " +
               "JOIN associate_category_to_subcategory ACSC ON AIS.SubCategoryID_fk = ACSC.SubCategoryID_fk " +
               "JOIN subcategory SC ON ACSC.SubCategoryID_fk = SC.SubCategoryID";

            using MySqlConnection conn = dbInit.GetConnection();

            try
            {
                conn.Open();

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Extract data from the reader and create an instance of jmdl_IndicatorSubCat
                            int indicatorIDfk = reader.GetInt32(reader.GetOrdinal("IndicatorID_fk"));
                            string indicator = reader.GetString(reader.GetOrdinal("Indicator"));
                            int categoryIDfk = reader.GetInt32(reader.GetOrdinal("CategoryID_fk"));
                            int subCategoryIDfk = reader.GetInt32(reader.GetOrdinal("SubCategoryID_fk"));
                            string subCategoryTitle = reader.GetString(reader.GetOrdinal("SubCategoryTitle"));
                            string subCategoryStatus = reader.GetString(reader.GetOrdinal("SubCategoryStatus"));

                            // Create an instance of jmdl_IndicatorSubCat and add it to the list
                            jmdl_IndicatorSubCat indicatorSubCat = new jmdl_IndicatorSubCat(
                                indicatorIDfk, indicator, categoryIDfk, subCategoryIDfk, subCategoryTitle, subCategoryStatus);

                            _jmISC.Add(indicatorSubCat);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        public void PullScoreTable()
        {
            _ScoreTable.Clear();

            string query = "SELECT " +
                           "ST.EntryID, ST.ChapterID_fk, SK.Barangay, ST.CategoryID_fk, C.CategoryTitle, " +
                           "ST.SubCategoryID_fk, SC.SubCategoryTitle, ST.IndicatorID_fk, I.Indicator, " +
                           "ST.SubIndicatorID_fk, SI.SubIndicator, ST.IsChecked, ST.ItemChecked, " +
                           "ST.Remarks, ST.Auditor, ST.AuditorID_fk, SI.SubIndicatorType, I.ScoreValue as IND_ScoreValue, SI.ScoreValue as SUBIND_ScoreValue " +
                           "FROM scoretable ST " +
                           "LEFT JOIN subcategory SC ON ST.SubCategoryID_fk = SC.SubCategoryID " +
                           "LEFT JOIN categories C ON ST.CategoryID_fk = C.CategoryID " +
                           "LEFT JOIN indicators I ON ST.IndicatorID_fk = I.IndicatorID " +
                           "LEFT JOIN subindicators SI ON ST.SubIndicatorID_fk = SI.SubIndicatorID " +
                           "INNER JOIN skchapters SK ON ST.ChapterID_fk = SK.ChapterID";

            MySqlConnection conn = dbInit.GetConnection();

            try
            {
                conn.Open();

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Extract data from the reader and create an instance of mdl_ScoreTable
                            int entryID = reader.GetInt32(reader.GetOrdinal("EntryID"));
                            int chapterID_fk = reader.GetInt32(reader.GetOrdinal("ChapterID_fk"));
                            string chapterName = reader.GetString(reader.GetOrdinal("Barangay"));
                            int categoryID_fk = reader.GetInt32(reader.GetOrdinal("CategoryID_fk"));
                            string categoryTitle = reader.GetString(reader.GetOrdinal("CategoryTitle"));
                            string? subCategoryID_fk = reader.IsDBNull(reader.GetOrdinal("SubCategoryID_fk")) 
                                ? null : reader.GetString(reader.GetOrdinal("SubCategoryID_fk"));
                            string? subCategoryTitle = reader.IsDBNull(reader.GetOrdinal("SubCategoryTitle")) 
                                ? null : reader.GetString(reader.GetOrdinal("SubCategoryTitle"));
                            int indicatorID_fk = reader.GetInt32(reader.GetOrdinal("IndicatorID_fk"));
                            string indicator = reader.GetString(reader.GetOrdinal("Indicator"));
                            string? subIndicatorID_fk = reader.IsDBNull(reader.GetOrdinal("SubIndicatorID_fk")) 
                                ? null : reader.GetString(reader.GetOrdinal("SubIndicatorID_fk"));
                            string? subIndicator = reader.IsDBNull(reader.GetOrdinal("SubIndicator")) 
                                ? null : reader.GetString(reader.GetOrdinal("SubIndicator"));
                            bool isChecked = reader.GetBoolean(reader.GetOrdinal("IsChecked"));
                            string itemChecked = reader.GetString(reader.GetOrdinal("ItemChecked"));
                            string? remarks = reader.IsDBNull(reader.GetOrdinal("Remarks")) 
                                ? null : reader.GetString(reader.GetOrdinal("Remarks"));
                            string? subIndicatorType = reader.IsDBNull(reader.GetOrdinal("SubIndicatorType")) 
                                ? null : reader.GetString(reader.GetOrdinal("SubIndicatorType"));
                            double indScoreValue = reader.GetDouble(reader.GetOrdinal("IND_ScoreValue"));
                            double? subIndScoreValue = reader.IsDBNull(reader.GetOrdinal("SUBIND_ScoreValue")) 
                                ? null : reader.GetDouble(reader.GetOrdinal("SUBIND_ScoreValue"));
                            string auditor = reader.GetString(reader.GetOrdinal("Auditor"));
                            int auditorID = reader.GetInt32(reader.GetOrdinal("AuditorID_fk"));

                            // Create an instance of mdl_ScoreTable and add it to the list
                            mdl_ScoreTable scoreTableRow = new mdl_ScoreTable(entryID,
                                chapterID_fk, chapterName, categoryID_fk, categoryTitle,
                                subCategoryID_fk, subCategoryTitle, indicatorID_fk,
                                indicator, subIndicatorID_fk, subIndicator,
                                isChecked, itemChecked, remarks, subIndicatorType,
                                indScoreValue, subIndScoreValue, auditorID, auditor);

                            _ScoreTable.Add(scoreTableRow);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                DSS.SET_ST(_ScoreTable);
                conn.Close();
            }
        }

        public void PullChapters()
        {
            _Chapters.Clear();

            string query = "SELECT * FROM skchapters";

            MySqlConnection conn = dbInit.GetConnection();

            try
            {
                conn.Open();

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    using (MySqlDataReader read = cmd.ExecuteReader())
                    {
                        while (read.Read())
                        {
                            int id = read.GetInt32(read.GetOrdinal("ChapterID"));
                            string chapter = read.GetString(read.GetOrdinal("Barangay"));
                            bool isdone = read.GetBoolean(read.GetOrdinal("hasFinishedAudit"));

                            mdl_SKChapters a = new mdl_SKChapters(id, chapter, isdone);
                            _Chapters.Add(a);
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                DSS.SET_SKC(_Chapters);
                conn.Close();
            }
        }
        public void PullActionPlans()
        {
            _ActionPlans.Clear();

            string query = "SELECT * FROM actionplans";

            MySqlConnection conn = dbInit.GetConnection();

            try
            {
                conn.Open();

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    using (MySqlDataReader read = cmd.ExecuteReader())
                    {
                        while (read.Read())
                        {
                            int id = read.GetInt32(read.GetOrdinal("ActionPlanID"));
                            int chapter_id = read.GetInt32(read.GetOrdinal("ChapterID_fk"));
                            string chapter_title = read.GetString(read.GetOrdinal("ChapterTitle"));
                            int cat_id = read.GetInt32(read.GetOrdinal("CategoryID_fk"));
                            string category_title = read.GetString(read.GetOrdinal("CategoryTitle"));
                            double category_score = read.GetDouble(read.GetOrdinal("CategoryScore"));
                            string actionplan = read.GetString(read.GetOrdinal("ActionPlanDetails"));

                            mdl_ActionPlans a = new mdl_ActionPlans(id, chapter_id, chapter_title,
                                cat_id, category_title, category_score,actionplan);
                            _ActionPlans.Add(a);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                DSS.SET_A(_ActionPlans);
                conn.Close();
            }
        }
        public void PullUsers()
        {
            _Users.Clear();

            string query = "SELECT * FROM users";

            MySqlConnection conn = dbInit.GetConnection();

            try
            {
                conn.Open();

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    using (MySqlDataReader read = cmd.ExecuteReader())
                    {
                        while (read.Read())
                        {
                            int id = read.GetInt32(read.GetOrdinal("UserID"));
                            string username = read.GetString(read.GetOrdinal("Username"));
                            string password = read.GetString(read.GetOrdinal("Password"));
                            string type = read.GetString(read.GetOrdinal("UserType"));
                            string status = read.GetString(read.GetOrdinal("UserStatus"));

                            mdl_Users a = new mdl_Users(id, username, password, type, status);
                            _Users.Add(a);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                DSS.SET_U(_Users);
                conn.Close();
            }
        }

        #endregion
    }
}