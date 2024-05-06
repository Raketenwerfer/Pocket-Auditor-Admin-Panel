using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pocket_Auditor_Admin_Panel.Classes
{
    public class mdl_ActionPlans
    {
        public int ActionPlanID { get; set; }
        public int ChapterID_fk { get; set; }
        public string ChapterTitle { get; set; }
        public int CategoryID_fk { get; set; }
        public string CategoryTitle { get; set; }
        public double CategoryScore { get; set; }
        public string? ActionPlan { get; set; }
        public mdl_ActionPlans(int ap_id, int chapterID_fk, string chapterTitle, int categoryID_fk, string categoryTitle, double categoryScore, string? actionPlan)
        {
            ActionPlanID = ap_id;
            ChapterID_fk = chapterID_fk;
            ChapterTitle = chapterTitle;
            CategoryID_fk = categoryID_fk;
            CategoryTitle = categoryTitle;
            CategoryScore = categoryScore;
            ActionPlan = actionPlan;
        }
    }
}
