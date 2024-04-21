﻿using MySql.Data.MySqlClient;
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
    public partial class FormActionPlans : Form
    {
        AdminPanel AP;

        readonly DataTable ActionPlanTable = new DataTable();
        readonly DataTable ChapterTable = new DataTable();
        readonly DataTable CategoryTable = new DataTable();
        public DataSharingService DSS;
        public List<mdl_SKChapters> _Chapters;
        public List<mdl_ScoreTable> _ScoreTable;
        public List<mdl_Categories> _Categories;
        public List<mdl_ActionPlans> _ActionPlans;
        bool APEntryExists;
        DatabaseInitiator dbInit;

        string? SelectedChapter, SelectedCategory, existingAPd;
        double? CategoryScore;

        public FormActionPlans(AdminPanel pass_AP)
        {
            AP = pass_AP;
            InitializeComponent();
            DSS = DataSharingService.GetInstance();
            _Chapters = DSS.GET_SKC();
            _ScoreTable = DSS.GET_ST();
            _Categories = DSS.GET_C();
            _ActionPlans = DSS.GET_A();
            dbInit = DSS.GetDatabase();
        }

        private void FormActionPlans_Load(object sender, EventArgs e)
        {
            InitChapterList();
            InitCategoryList();
            InitAuditList();
        }

        public void InitChapterList()
        {
            ChapterTable.Columns.Add("ChapterID");
            ChapterTable.Columns.Add("Barangay");

            try
            {
                foreach (mdl_SKChapters x in _Chapters)
                {
                    ChapterTable.Rows.Add(x.ChapterID, x.Barangay);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            dgv_ChapterSelect.DataSource = ChapterTable;
            dgv_ChapterSelect.Columns[0].Visible = false;
        }

        public void InitCategoryList()
        {
            CategoryTable.Columns.Add("CategoryID");
            CategoryTable.Columns.Add("Category");

            try
            {
                foreach (mdl_Categories x in _Categories)
                {
                    CategoryTable.Rows.Add(x.CategoryID, x.CategoryTitle);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            dgv_CategorySelect.DataSource = CategoryTable;
            dgv_CategorySelect.Columns[0].Visible = false;
        }

        public void InitAuditList()
        {
            ActionPlanTable.Columns.Add("Sub-Category");
            ActionPlanTable.Columns.Add("Indicator");
            ActionPlanTable.Columns.Add("Sub-Indicator");
            ActionPlanTable.Columns.Add("Remarks");

            dgv_SelectedChapterAuditResults.DataSource = ActionPlanTable;
        }

        public void eSelChap(object sender, DataGridViewCellEventArgs e)
        {
            SelectedChapter = Convert.ToString(dgv_ChapterSelect.SelectedCells[0].Value);

            ReloadAuditList();
        }

        public void eSelCat(object sender, DataGridViewCellEventArgs e)
        {
            SelectedCategory = Convert.ToString(dgv_CategorySelect.SelectedCells[0].Value);
            CheckForExistingAP();
            ReloadAuditList();
            CategoryScore = GetCategoryScore();
        }

        public void ReloadAuditList()
        {
            if (SelectedCategory != null && SelectedChapter != null)
            {
                LoadAuditList();
            }
        }

        public void LoadAuditList()
        {
            ActionPlanTable.Clear();

            try
            {
                foreach (mdl_ScoreTable x in _ScoreTable)
                {
                    string? itemresponse = null;

                    if (x.Remarks == null)
                    {
                        if (x.IsChecked == true)
                        {
                            if (x.ItemChecked == "IND")
                            {
                                itemresponse = "YES - [1]";
                            }
                            if (x.ItemChecked == "SUBIND")
                            {
                                itemresponse = "YES - [0.5]";
                            }
                        }

                        if (x.IsChecked == false)
                        {
                            itemresponse = "NO";
                        }
                    }
                    else
                    {
                        itemresponse = x.Remarks;
                    }

                    if (SelectedCategory == x.CategoryID_fk.ToString() &&
                        SelectedChapter == x.ChapterID_fk.ToString())
                    {
                        ActionPlanTable.Rows.Add(
                            x.SubCategoryTitle,
                            x.Indicator,
                            x.SubIndicator,
                            itemresponse);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            ///////

            try
            {
                CheckForExistingAP();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void CheckForExistingAP()
        {
            bool entryFound = false; // Flag to track if an existing entry is found

            foreach (mdl_ActionPlans y in _ActionPlans)
            {
                // Checks if there's an existing entry
                if (y.ChapterID_fk == Convert.ToInt32(SelectedChapter) &&
                    y.CategoryID_fk == Convert.ToInt32(SelectedCategory))
                {
                    rtb_ActionPlanDetail.Text = y.ActionPlan;
                    existingAPd = y.ActionPlan;
                    APEntryExists = true;
                    btn_SaveActionPlan.Enabled = false;

                    entryFound = true; // Set flag to true once entry is found
                    break; // Exit loop since entry is found
                }
            }

            // Runs if no existing entry is found
            if (!entryFound)
            {
                rtb_ActionPlanDetail.Text = null;
                existingAPd = null;
                APEntryExists = false;
                btn_SaveActionPlan.Enabled = true;
            }
        }


        private void rtb_ActionPlanDetail_TextChanged(object sender, EventArgs e)
        {
            if (rtb_ActionPlanDetail.Text == existingAPd)
            {
                btn_SaveActionPlan.Enabled = false;
            }
            else
            {
                btn_SaveActionPlan.Enabled = true;
            }
        }

        private void btn_SaveActionPlan_Click(object sender, EventArgs e)
        {
            if (APEntryExists)
            {
                EditActionPlan();
            }
            else
            {
                AddActionPlan();
            }

            AP.PullActionPlans();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            DeleteActionPlan(Convert.ToInt32(SelectedChapter), Convert.ToInt32(SelectedCategory));
            AP.PullActionPlans();
        }
        public void EditActionPlan()
        {
            string query = "UPDATE actionplans SET ActionPlanDetails = @ActionPlanDetails WHERE ChapterID_fk = @ChapterID AND CategoryID_fk = @CategoryID";

            using (MySqlConnection conn = dbInit.GetConnection())
            {
                try
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@ActionPlanDetails", rtb_ActionPlanDetail.Text);
                        cmd.Parameters.AddWithValue("@ChapterID", SelectedChapter);
                        cmd.Parameters.AddWithValue("@CategoryID", SelectedCategory);

                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        public void AddActionPlan()
        {
            string query = "INSERT INTO actionplans (ChapterID_fk, ChapterTitle, CategoryID_fk, CategoryTitle, CategoryScore, ActionPlanDetails) " +
                           "VALUES (@ChapterID, @ChapterTitle, @CategoryID, @CategoryTitle, @CategoryScore, @ActionPlanDetails)";

            string? chapter = dgv_ChapterSelect.SelectedCells[1].Value.ToString();
            string? category = dgv_CategorySelect.SelectedCells[1].Value.ToString();

            using (MySqlConnection conn = dbInit.GetConnection())
            {
                try
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@ChapterID", SelectedChapter);
                        cmd.Parameters.AddWithValue("@ChapterTitle", chapter);
                        cmd.Parameters.AddWithValue("@CategoryID", SelectedCategory);
                        cmd.Parameters.AddWithValue("@CategoryTitle", category);
                        cmd.Parameters.AddWithValue("@CategoryScore", CategoryScore);
                        cmd.Parameters.AddWithValue("@ActionPlanDetails", rtb_ActionPlanDetail.Text);

                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        public void DeleteActionPlan(int chapterID, int categoryID)
        {
            string query = "DELETE FROM actionplans WHERE ChapterID_fk = @ChapterID AND CategoryID_fk = @CategoryID";

            using (MySqlConnection conn = dbInit.GetConnection())
            {
                try
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@ChapterID", chapterID);
                        cmd.Parameters.AddWithValue("@CategoryID", categoryID);

                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    rtb_ActionPlanDetail.Text = null;
                }
            }
        }


        public double? GetCategoryScore()
        {
            var tally = _ScoreTable.Where(item => item.IsChecked)
                                   .GroupBy(item => item.CategoryID_fk == Convert.ToUInt32(SelectedCategory));

            double? overallscore = 0;

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

                overallscore = indScore + subIndScore;

            }

            return overallscore;
        }
    }
}
