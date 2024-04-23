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
    public partial class prompt_ViewChapters : Form
    {
        DataSharingService DSS;
        DatabaseInitiator dbInit;
        List<mdl_SKChapters> _SKC;
        DataTable chapterList = new DataTable();
        public prompt_ViewChapters()
        {
            DSS = DataSharingService.GetInstance();
            dbInit = DSS.GetDatabase();
            _SKC = DSS.GET_SKC();
            InitializeComponent();

            PopulateChapters();
        }

        public void PopulateChapters()
        {
            chapterList.Columns.Add("Chapter/Barangay");
            chapterList.Columns.Add("Audit Status");

            foreach (mdl_SKChapters x in _SKC)
            {
                string status;

                if (x.hasFinishedAudit)
                {
                    status = "DONE";
                }
                else
                {
                    status = "N/A";
                }

                chapterList.Rows.Add(x.Barangay, status);
            }

            dgv_Chapters.DataSource = chapterList;

            dgv_Chapters.DefaultCellStyle.SelectionBackColor = Color.DeepSkyBlue;
            dgv_Chapters.DefaultCellStyle.SelectionForeColor = Color.Black;

            dgv_Chapters.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
        }
    }
}
