using Pocket_Auditor_Admin_Panel.Forms;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Pocket_Auditor_Admin_Panel.Auxiliaries;
using Pocket_Auditor_Admin_Panel.Classes;

namespace Pocket_Auditor_Admin_Panel
{
    public partial class AdminPanel : Form
    {
        readonly DatabaseInitiator dbInit = new DatabaseInitiator("sql.freedb.tech", "freedb_ccydc_test_db", "freedb_ccydc", "r*kmjEa6N#KUsDN");


        readonly FormDashboard frmDashboard = new FormDashboard();
        readonly FormAuditForm frmAuditForm;
        readonly FormActionPlans frmActionPlans = new FormActionPlans();
        readonly FormAuditReports frmAuditReports = new FormAuditReports();
        readonly FormManageAuditors frmManageAuditors = new FormManageAuditors();


        public List<mdl_Categories> _Categories = new List<mdl_Categories>();
        public List<mdl_SubIndicators> _SubIndicators = new List<mdl_SubIndicators>();
        public List<mdl_Indicators> _Indicators = new List<mdl_Indicators>();

        public List<jmdl_IndicatorsSubInd> _jmISI = new List<jmdl_IndicatorsSubInd>();
        public List<jmdl_CategoriesIndicators> _jmCI = new List<jmdl_CategoriesIndicators>();

        public AdminPanel()
        {
            InitializeComponent();
            InitDatabase();

            frmAuditForm = new FormAuditForm(dbInit, _Categories, _Indicators,
                _SubIndicators, _jmISI, _jmCI);
        }

        public void InitDatabase()
        {
            // Establishes connection with the database
            using MySqlConnection conn = dbInit.GetConnection();

            if (TestDatabaseConnection())
            {
                PullCategories();
                PullIndicators();
                PullSubIndicators();
                PullAssociate_ISI();
                PullAssociate_CI();

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

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            frmDashboard.TopLevel = false;
            frmDashboard.TopMost = true;
            panelContent.Controls.Clear();
            panelContent.Controls.Add(frmDashboard);
            frmDashboard.Show();
        }

        private void btnAuditForm_Click(object sender, EventArgs e)
        {
            frmAuditForm.TopLevel = false;
            frmAuditForm.TopMost = true;
            panelContent.Controls.Clear();
            panelContent.AutoScroll = true;
            panelContent.Controls.Add(frmAuditForm);
            frmAuditForm.Show();
        }

        private void btnActionPlans_Click(object sender, EventArgs e)
        {
            frmActionPlans.TopLevel = false;
            frmActionPlans.TopMost = true;
            panelContent.Controls.Clear();
            panelContent.AutoScroll = true;
            panelContent.Controls.Add(frmActionPlans);
            frmActionPlans.Show();
        }

        private void btnAuditReports_Click(object sender, EventArgs e)
        {
            frmAuditReports.TopLevel = false;
            frmAuditReports.TopMost = true;
            panelContent.Controls.Clear();
            panelContent.AutoScroll = true;
            panelContent.Controls.Add(frmAuditReports);
            frmAuditReports.Show();
        }

        private void btnManageAuditors_Click(object sender, EventArgs e)
        {
            frmManageAuditors.TopLevel = false;
            frmManageAuditors.TopMost = true;
            panelContent.Controls.Clear();
            panelContent.AutoScroll = true;
            panelContent.Controls.Add(frmManageAuditors);
            frmManageAuditors.Show();
        }

        private void AdminPanel_Load(object sender, EventArgs e)
        {
        }





        #region Pull Data

        public void PullCategories()
        {
            int _catID;
            string _catTitle, _catStatus;

            string getCatQuery = "SELECT * FROM Categories WHERE CategoryStatus = 'ACTIVE'";

            MySqlConnection conn = dbInit.GetConnection();

            try
            {
                conn.Open();

                using (MySqlCommand cmd = new MySqlCommand(getCatQuery, conn))
                {
                    using (MySqlDataReader read = cmd.ExecuteReader())
                    {
                        while (read.Read())
                        {
                            _catID = read.GetInt32(read.GetOrdinal("CategoryID"));
                            _catTitle = read.GetString(read.GetOrdinal("CategoryTitle"));
                            _catStatus = read.GetString(read.GetOrdinal("CategoryStatus"));

                            mdl_Categories a = new mdl_Categories(_catID, _catTitle, _catStatus);
                            {
                                a.CategoryID = _catID;
                                a.CategoryTitle = _catTitle;
                                a.CategoryStatus = _catStatus;
                            }

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
                conn.Close();
            }
        }

        public void PullIndicators()
        {
            int _indID, _indNo;
            double _indScoreValue;
            string _indTitle, _indStatus, _indType;

            string getIndQuery = "SELECT * From Indicators WHERE IndicatorStatus = 'ACTIVE'";

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
                            _indNo = read.GetInt32(read.GetOrdinal("IndicatorNumber"));
                            _indScoreValue = read.GetDouble(read.GetOrdinal("ScoreValue"));
                            _indTitle = read.GetString(read.GetOrdinal("Indicator"));
                            _indStatus = read.GetString(read.GetOrdinal("IndicatorStatus"));
                            _indType = read.GetString(read.GetOrdinal("IndicatorType"));

                            mdl_Indicators a = new mdl_Indicators(_indID, _indNo, _indScoreValue, _indTitle, _indStatus, _indType);
                            {
                                a.IndicatorID = _indID;
                                a.IndicatorNumber = _indNo;
                                a.ScoreValue = _indScoreValue;
                                a.Indicator = _indTitle;
                                a.IndicatorStatus = _indStatus;
                                a.IndicatorType = _indType;
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
            int _subIndID;
            string _subIndTitle, _subIndType, _subIndStatus;
            double _subIndScoreValue;

            string getSubIndQuery = "SELECT * FROM SubIndicators WHERE SubIndicatorStatus = 'ACTIVE'";

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
            int indicatorFK, subindicatorFK;
            double subindSV;
            string indicator, subind, subindtype, subindstatus;

            string query = "SELECT S.SubIndicatorID, S.SubIndicator, S.SubIndicatorType, S.SubIndicatorStatus, S.ScoreValue, " +
                "I.IndicatorID, I.Indicator " +
                "FROM Associate_Indicator_to_SubIndicator AtISI " +
                "INNER JOIN SubIndicators S on AtISI.SubIndicatorID_fk = S.SubIndicatorID " +
                "INNER JOIN Indicators I on AtISI.IndicatorID_fk = I.IndicatorID " +
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
            int indicatorID, indNO, categoryID;
            string catTitle, indicator, indType;
            double indScoreValue;

            string query = "SELECT C.CategoryID, C.CategoryTitle, I.IndicatorID, I.Indicator, I.IndicatorNumber, I.IndicatorType, I.ScoreValue " +
                "FROM Associate_Category_to_Indicator AtC " +
                "INNER JOIN Categories C on AtC.CategoryID_fk = C.CategoryID " +
                "INNER JOIN Indicators I on AtC.IndicatorID_fk = I.IndicatorID " +
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
                            indNO = read.GetInt32(read.GetOrdinal("IndicatorNumber"));
                            indType = read.GetString(read.GetOrdinal("IndicatorType"));
                            indScoreValue = read.GetDouble(read.GetOrdinal("ScoreValue"));

                            jmdl_CategoriesIndicators a = new jmdl_CategoriesIndicators(categoryID, catTitle, indicatorID,
                                indicator, indNO, indType, indScoreValue);
                            {
                                a.CategoryID = categoryID;
                                a.CategoryTitle = catTitle;
                                a.IndicatorID = indicatorID;
                                a.Indicator = indicator;
                                a.IndicatorNumber = indNO;
                                a.IndicatorType = indType;
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

        #endregion
    }
}