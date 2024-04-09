using MySql.Data.MySqlClient;
using Pocket_Auditor_Admin_Panel.Auxiliaries;
using Pocket_Auditor_Admin_Panel.Classes;
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
    public partial class FormAuditReports : Form
    {
        public DataSharingService DSS;
        public DatabaseInitiator dbInit;
        List<mdl_ScoreTable> _ScoreTable;
        List<double> ChapterScores = new List<double>();

        Form editISI;

        DataTable reportTable = new DataTable();
        int index;

        // Declare the list at the class level
        //private List<string> allChoices = new List<string>
        //{
        //    //example
        //    "Babag",
        //    "Bakayam",
        //    "Bjakjlf",
        //    "Bjkahd",
        //    "Aabag",
        //    "Aakayam",
        //    "Ajakjlf",
        //    "Ajkahd",
        //    // Add more choices as needed
        //};

        public FormAuditReports()
        {
            InitializeComponent();
            DSS = DSS.GetInstance();
            dbInit = DSS.GetDatabase();
        }

        //private void txtSearch_TextChanged(object sender, EventArgs e)
        //{
        //    string keyword = txtSearch.Text.Trim().ToLower(); // Trim to remove leading and trailing whitespaces

        //    if (!string.IsNullOrEmpty(keyword))
        //    {
        //        List<string> filteredChoices = allChoices
        //            .Where(choice => choice.ToLower().StartsWith(keyword))
        //            .ToList();

        //        UpdateFlowLayoutPanel(filteredChoices);
        //        fLpChoices.Visible = true;
        //    }
        //    else
        //    {
        //        fLpChoices.Visible = false;
        //    }
        //}

        //private void UpdateFlowLayoutPanel(List<string> filteredChoices)
        //{
        //    fLpChoices.Controls.Clear();

        //    foreach (string choice in filteredChoices)
        //    {
        //        Label label = new Label
        //        {
        //            Text = choice,
        //            // Add more label properties as needed
        //        };

        //        fLpChoices.Controls.Add(label);
        //    }
        //}

        private void FormAuditReports_Load(object sender, EventArgs e)
        {
            reportTable.Columns.Add("Barangay");
            reportTable.Columns.Add("Score");
            reportTable.Columns.Add("Auditor");
            reportTable.Columns.Add("Date");
            dgv_Results.DataSource = reportTable;
        }

        private void Reportsdgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // to be continued! HAHAHA
            Form showForm = new Form();
            showForm.ShowDialog();
        }

        public void PullScoreTable()
        {
            _ScoreTable.Clear();

            string query = "SELECT " +
                           "ST.EntryID, ST.ChapterID_fk, SK.Barangay, ST.CategoryID_fk, C.CategoryTitle, " +
                           "ST.SubCategoryID_fk, SC.SubCategoryTitle, ST.IndicatorID_fk, I.Indicator, " +
                           "ST.SubIndicatorID_fk, SI.SubIndicator, ST.IsChecked, ST.ItemChecked, " +
                           "ST.Remarks, SI.SubIndicatorType, I.ScoreValue as IND_ScoreValue, SI.ScoreValue as SUBIND_ScoreValue " +
                           "FROM scoretable ST " +
                           "LEFT JOIN SubCategory SC ON ST.SubCategoryID_fk = SC.SubCategoryID " +
                           "LEFT JOIN Categories C ON ST.CategoryID_fk = C.CategoryID " +
                           "LEFT JOIN Indicators I ON ST.IndicatorID_fk = I.IndicatorID " +
                           "LEFT JOIN SubIndicators SI ON ST.SubIndicatorID_fk = SI.SubIndicatorID " +
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
                            string subCategoryID_fk = reader.GetString(reader.GetOrdinal("SubCategoryID_fk"));
                            string subCategoryTitle = reader.GetString(reader.GetOrdinal("SubCategoryTitle"));
                            int indicatorID_fk = reader.GetInt32(reader.GetOrdinal("IndicatorID_fk"));
                            string indicator = reader.GetString(reader.GetOrdinal("Indicator"));
                            string subIndicatorID_fk = reader.GetString(reader.GetOrdinal("SubIndicatorID_fk"));
                            string subIndicator = reader.GetString(reader.GetOrdinal("SubIndicator"));
                            bool isChecked = reader.GetBoolean(reader.GetOrdinal("IsChecked"));
                            string itemChecked = reader.GetString(reader.GetOrdinal("ItemChecked"));
                            string remarks = reader.GetString(reader.GetOrdinal("Remarks"));
                            string subIndicatorType = reader.GetString(reader.GetOrdinal("SubIndicatorType"));
                            double indScoreValue = reader.GetDouble(reader.GetOrdinal("IND_ScoreValue"));
                            double subIndScoreValue = reader.GetDouble(reader.GetOrdinal("SUBIND_ScoreValue"));

                            // Create an instance of mdl_ScoreTable and add it to the list
                            mdl_ScoreTable scoreTableRow = new mdl_ScoreTable(
                                chapterID_fk, chapterName, categoryID_fk, categoryTitle,
                                subCategoryID_fk, subCategoryTitle, indicatorID_fk,
                                indicator, subIndicatorID_fk, subIndicator,
                                isChecked, itemChecked, remarks, subIndicatorType,
                                indScoreValue, subIndScoreValue);

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
                conn.Close();
            }
        }

        public void kek()
        {
            var tally = _ScoreTable.GroupBy(item => item.ChapterID_fk);

            foreach (var group in tally)
            {
                double indScore = 0;
                double subIndScore = 0;

                foreach (var item in group)
                {
                    if (item.ItemChecked == "IND")
                    {
                        indScore += item.IND_ScoreValue;

                        var subIndItem = group.FirstOrDefault(subItem => subItem.ItemChecked == "SUBIND" && subItem.SubIndicatorID_fk == item.SubIndicatorID_fk);
                        if (subIndItem != null)
                        {
                            subIndScore += subIndItem.SUBIND_ScoreValue;
                        }
                    }
                    else if (item.ItemChecked == "SUBIND")
                    {
                        subIndScore += item.SUBIND_ScoreValue;
                    }
                }
                // Add the overall score (sum of indScore and subIndScore) to the list
                ChapterScores.Add(indScore + subIndScore);
            }
            // Now, overallScores list contains the overall scores for each chapter
        }


    }
}
