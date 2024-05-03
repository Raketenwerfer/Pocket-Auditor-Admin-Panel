using Pocket_Auditor_Admin_Panel.Auxiliaries;
using Pocket_Auditor_Admin_Panel.Classes;
using Pocket_Auditor_Admin_Panel.Prompts;
using Pocket_Auditor_Admin_Panel.UserControlPanels;
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
    public partial class FormDashboard : Form
    {
        DataSharingService DSS;
        DatabaseInitiator dbInit;
        AdminPanel AP;
        List<mdl_ScoreTable> _ScoreTable;
        List<mdl_SKChapters> _SKChapters;
        List<ChapterOverview> RankList = new List<ChapterOverview>();
        public FormDashboard(AdminPanel passAP)
        {
            InitializeComponent();

            DSS = DataSharingService.GetInstance();
            dbInit = DSS.GetDatabase();
            AP = passAP;
            _ScoreTable = DSS.GET_ST();
            _SKChapters = DSS.GET_SKC();


            HandleData();
            PopulateRanks();
        }

        public void PopulateRanks()
        {
            flp_Ranks.Controls.Clear();

            List<ChapterOverview> listbucket = RankList.OrderByDescending(x => x.TotalScore).ToList();

            int rank = 1;

            foreach (ChapterOverview x in listbucket)
            {
                if (rank <= 11)
                {
                    UCM_TopChapterItem rankItem = new UCM_TopChapterItem();
                    rankItem.Rank = rank;
                    rankItem.Chapter = x.ChapterTitle;
                    rankItem.Score = x.TotalScore;
                    rankItem.Auditor = x.Auditor;

                    flp_Ranks.Controls.Add(rankItem);
                    rank++;
                }
                else
                {
                    break;
                }

            }
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
                string auditor = group.FirstOrDefault().Auditor;
                int chapterID = group.FirstOrDefault().ChapterID_fk;

                ChapterOverview a = new ChapterOverview(chapterID, chapterName, overallScore, auditor);

                if (!string.IsNullOrEmpty(chapterName))
                {
                    RankList.Add(a);
                }
            }

            // Now, overallScoresByChapterName dictionary contains the overall scores for each chapter, keyed by ChapterName

        }

        public void ShowChapters(object sender, EventArgs e)
        {
            prompt_ViewChapters pvc = new prompt_ViewChapters();
            pvc.ShowDialog();
        }
        public void AddUser(object sender, EventArgs e)
        {
            AP.ShowUserControlsPrompt("create", null);
        }


        #region UI Controls
        public void SelectAF(object sender, EventArgs e)
        {
            AP.btnAuditForm_Click(sender, e);
        }
        public void SelectAP(object sender, EventArgs e)
        {
            AP.btnActionPlans_Click(sender, e);
        }
        public void SelectAR(object sender, EventArgs e)
        {
            AP.btnAuditReports_Click(sender, e);
        }

        private void HoverAF(object sender, EventArgs e)
        {
            //btn_pnl_AF.BackColor = Color.Aquamarine;
        }
        private void LeaveAF(object sender, EventArgs e)
        {
            //btn_pnl_AF.BackColor = Color.MediumAquamarine;
        }

        private void HoverAP(object sender, EventArgs e)
        {
            //btn_pnl_AP.BackColor = Color.Aquamarine;
        }
        private void LeaveAP(object sender, EventArgs e)
        {
            //btn_pnl_AP.BackColor = Color.MediumAquamarine;
        }

        private void HoverAR(object sender, EventArgs e)
        {
            //btn_pnl_AR.BackColor = Color.Aquamarine;
        }
        private void LeaveAR(object sender, EventArgs e)
        {
            //btn_pnl_AR.BackColor = Color.MediumAquamarine;
        }
        #endregion

        private void FormDashboard_Leave(object sender, EventArgs e)
        {
            Close();
        }

        private void flp_Ranks_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
