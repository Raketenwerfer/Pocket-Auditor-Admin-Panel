using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pocket_Auditor_Admin_Panel.Classes
{
    public class mdl_ScoreTable
    {
        public int EntryID { get; set; }
        public int ChapterID_fk { get; set; }
        public string ChapterName { get; set; }
        public int CategoryID_fk { get; set; }
        public string CategoryTitle { get; set; }
        public string SubCategoryID_fk { get; set; }
        // Set to string as this is nullable in the database
        public string SubCategoryTitle { get; set; }
        public int IndicatorID_fk { get; set; }
        public string Indicator { get; set; }
        public string SubIndicatorID_fk { get; set; }
        public string SubIndicator { get; set; }
        public bool IsChecked { get; set; }
        public string ItemChecked { get; set; }
        public string Remarks { get; set; }
        public string SubIndicatorType { get; set; }
        public double IND_ScoreValue { get; set; }
        public double SUBIND_ScoreValue { get; set; }

        public mdl_ScoreTable(int chapterID_fk, string chapterName, int catID, string catTitle,
            string subcatID, string subcatTitle, int indID, string ind, 
            string subindID, string subind, bool ischekced, string itemchecked, string remarks,
            string subIndicatorType, double I_ScoreValue, double SI_ScoreValue)
        {
            ChapterID_fk = chapterID_fk;
            ChapterName = chapterName;
            CategoryID_fk = catID;
            CategoryTitle = catTitle;
            SubCategoryID_fk = subcatID;
            SubCategoryTitle = subcatTitle;
            IndicatorID_fk = indID;
            Indicator = ind;
            SubIndicatorID_fk = subindID;
            SubIndicator = subind;
            IsChecked = ischekced;
            ItemChecked = itemchecked;
            Remarks = remarks;
            SubIndicatorType = subIndicatorType;
            IND_ScoreValue = I_ScoreValue;
            SUBIND_ScoreValue = SI_ScoreValue;
        }
    }
}