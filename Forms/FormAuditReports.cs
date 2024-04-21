using MySql.Data.MySqlClient;
using Pocket_Auditor_Admin_Panel.Auxiliaries;
using Pocket_Auditor_Admin_Panel.Classes;
using Pocket_Auditor_Admin_Panel.Prompts;
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
        public List<ChapterOverview> ScoreList = new List<ChapterOverview>();

        DataTable reportTable = new DataTable();

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
            reportTable.Columns.Add("ChapterID");
            reportTable.Columns.Add("Barangay");
            reportTable.Columns.Add("Score");
            //reportTable.Columns.Add("Auditor");
            //reportTable.Columns.Add("Date");
            dgv_Results.DataSource = reportTable;

            try
            {
                foreach (ChapterOverview entry in ScoreList)
                {
                    int chapterid = entry.ChapterID;
                    string? chapterName = entry.ChapterTitle;
                    double? overallScore = entry.TotalScore;


                    // Add a new row to the DataGridView with ChapterName and OverallScore values
                    reportTable.Rows.Add(chapterid, chapterName, overallScore);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            dgv_Results.Columns[0].Visible = false;
            dgv_Results.ColumnHeadersVisible = false;
        }

        private void Reportsdgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string? barangay;
            int? id = null;

            if (dgv_Results.SelectedRows[0].Cells[0].Value.ToString() != null)
            {
                barangay = dgv_Results.SelectedRows[0].Cells[1].Value.ToString();
                id = Convert.ToInt32(dgv_Results.SelectedRows[0].Cells[0].Value);
            }
            else
            {
                barangay = "Empty";
            }
            // to be continued! HAHAHA
            prompt_ViewResultDetails details = new prompt_ViewResultDetails(id, barangay);
            details.ShowDialog();
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

                string? chapterName = group.FirstOrDefault()?.ChapterName;
                int chapterID = group.FirstOrDefault().ChapterID_fk;

                ChapterOverview a = new ChapterOverview(chapterID, chapterName, overallScore);

                if (!string.IsNullOrEmpty(chapterName))
                {
                    ScoreList.Add(a);
                }
            }

            // Now, overallScoresByChapterName dictionary contains the overall scores for each chapter, keyed by ChapterName

        }
    }

    public class ChapterOverview
    {
        public int ChapterID { get; set; }
        public string? ChapterTitle { get; set; }
        public double? TotalScore { get; set; }
        public ChapterOverview(int id, string? title, double? score)
        {
            ChapterID = id;
            ChapterTitle = title;
            TotalScore = score;
        }
    }
}
