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

        readonly DataTable ActionPlanTable = new DataTable();
        readonly DataTable ChapterTable = new DataTable();
        readonly DataTable CategoryTable = new DataTable();
        public DataSharingService DSS;
        public List<mdl_SKChapters> _Chapters;
        public List<mdl_ScoreTable> _ScoreTable;
        public List<mdl_Categories> _Categories;

        string? SelectedChapter, SelectedCategory;

        public FormActionPlans()
        {
            InitializeComponent();
            DSS = DataSharingService.GetInstance();
            _Chapters = DSS.GET_SKC();
            _ScoreTable = DSS.GET_ST();
            _Categories = DSS.GET_C();
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

            ReloadAuditList();
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
            }

        }
    }
}
