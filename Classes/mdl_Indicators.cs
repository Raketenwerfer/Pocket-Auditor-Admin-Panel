using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pocket_Auditor_Admin_Panel.Classes
{
    public class mdl_Indicators
    {
        public int IndicatorID { get; set; }
        public double ScoreValue { get; set; }
        public string Indicator { get; set; }
        public string IndicatorStatus { get; set; }
        public string IndicatorType { get; set; }

        public mdl_Indicators(int indicatorID, double scoreValue, string indicator, string indicatorStatus, string indicatorType)
        {
            IndicatorID = indicatorID;
            ScoreValue = scoreValue;
            Indicator = indicator;
            IndicatorStatus = indicatorStatus;
            IndicatorType = indicatorType;
        }
    }
}
