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
        Dictionary<string, double?> ScoreList = new Dictionary<string, double?>();


        DataTable reportTable = new DataTable();


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

        public FormAuditReports(DatabaseInitiator db)
        {
            InitializeComponent();
            DSS = DataSharingService.GetInstance();
            dbInit = db;
            _ScoreTable = DSS.GET_ST();

            HandleData();
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
            //reportTable.Columns.Add("Auditor");
            //reportTable.Columns.Add("Date");
            dgv_Results.DataSource = reportTable;


            try
            {
                foreach (var entry in ScoreList)
                {
                    string chapterName = entry.Key;
                    double? overallScore = entry.Value;

                    // Add a new row to the DataGridView with ChapterName and OverallScore values
                    reportTable.Rows.Add(chapterName, overallScore);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Reportsdgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // to be continued! HAHAHA
            Form showForm = new Form();
            showForm.ShowDialog();
        }

        public void HandleData()
        {
            var tally = _ScoreTable.Where(item => item.IsChecked)
                                               .GroupBy(item => item.ChapterID_fk);

            foreach (var group in tally)
            {
                double? indScore = 0;
                double? subIndScore = 0;

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

                double? overallScore = indScore + subIndScore;

                string chapterName = group.FirstOrDefault()?.ChapterName;

                if (!string.IsNullOrEmpty(chapterName))
                {
                    ScoreList[chapterName] = overallScore;
                }
            }

            // Now, overallScoresByChapterName dictionary contains the overall scores for each chapter, keyed by ChapterName

        }
    }
}
