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

namespace Pocket_Auditor_Admin_Panel.Prompts
{
    public partial class prompt_ViewResultDetails : Form
    {
        DataTable dt_ResultsDetails = new DataTable();
        DataSharingService DSS;
        List<mdl_ScoreTable> _ScoreTable;
        List<DetailItems> DetailMap = new List<DetailItems>();
        public int selected_chapter;
        public prompt_ViewResultDetails(int? id, string? barangay)
        {
            DSS = DataSharingService.GetInstance();
            _ScoreTable = DSS.GET_ST();
            InitializeComponent();

            selected_chapter = Convert.ToInt32(id);
            Text = barangay + " Audit Results";
        }

        private void prompt_ViewResultDetails_Load(object sender, EventArgs e)
        {
            HandleData();

            dgv_table_ResultsDetails.Columns[0].Visible = false;
            dgv_table_ResultsDetails.Columns[2].Visible = false;
            dgv_table_ResultsDetails.Columns[3].HeaderText = "Sub-Category";
            dgv_table_ResultsDetails.Columns[4].Visible = false;
            dgv_table_ResultsDetails.Columns[6].Visible = false;
            dgv_table_ResultsDetails.Columns[7].HeaderText = "Sub-Indicator";
            dgv_table_ResultsDetails.Columns[8].HeaderText = "Response/Score";

            dgv_table_ResultsDetails.Columns[8].DefaultCellStyle.BackColor = Color.Khaki;
            dgv_table_ResultsDetails.Columns[8].DefaultCellStyle.SelectionForeColor = Color.Black;
            dgv_table_ResultsDetails.Columns[8].DefaultCellStyle.SelectionBackColor = Color.Gold;

            dgv_table_ResultsDetails.Columns[5].DefaultCellStyle.BackColor = Color.DarkKhaki;
            dgv_table_ResultsDetails.Columns[5].DefaultCellStyle.SelectionForeColor = Color.Black;
            dgv_table_ResultsDetails.Columns[5].DefaultCellStyle.SelectionBackColor = Color.PaleGoldenrod;

            dgv_table_ResultsDetails.Columns[7].DefaultCellStyle.BackColor = Color.DarkKhaki;
            dgv_table_ResultsDetails.Columns[7].DefaultCellStyle.SelectionForeColor = Color.Black;
            dgv_table_ResultsDetails.Columns[7].DefaultCellStyle.SelectionBackColor = Color.PaleGoldenrod;
        }
        public void HandleData()
        {
            foreach (mdl_ScoreTable x in _ScoreTable)
            {
                if (x.ChapterID_fk == selected_chapter)
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

                    DetailItems a = new DetailItems
                        (
                            x.CategoryID_fk,
                            x.CategoryTitle,
                            x.SubCategoryID_fk,
                            x.SubCategoryTitle,
                            x.IndicatorID_fk,
                            x.Indicator,
                            x.SubIndicatorID_fk,
                            x.SubIndicator,
                            itemresponse
                        );

                    DetailMap.Add(a);
                }
            }

            dgv_table_ResultsDetails.DataSource = DetailMap;
        }
    }



    // Local Class
    public class DetailItems
    {
        public int CAT_ID { get; set; }
        public string Category { get; set; }
        public string? SUBCAT_ID {  get; set; }
        public string? SubCategory {  get; set; }
        public int IND_ID {  get; set; }
        public string Indicator { get; set; }
        public string? SUBIND_ID {  get; set; }
        public string? SubIndicator { get; set; }
        public string? Response { get; set; }

        public DetailItems(int catid, string cat, string? subcatid, string? subcat,
            int indid, string ind, string? subindid, string? subind, string? response)
        {
            CAT_ID = catid;
            Category = cat;
            SUBCAT_ID = subcatid;
            SubCategory = subcat;
            IND_ID = indid;
            Indicator = ind;
            SUBIND_ID = subindid;
            SubIndicator = subind;
            Response = response;

        }
    }
}
