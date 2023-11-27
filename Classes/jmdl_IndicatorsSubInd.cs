using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pocket_Auditor_Admin_Panel.Classes
{
    public class jmdl_IndicatorsSubInd
    {
        public int SubIndicatorID_fk { get; set; }
        public string SubIndicator { get; set; }
        public string SubIndicatorType { get; set; }
        public string SubIndicatorStatus { get; set; }
        public double ScoreValue { get; set; }
        public int IndicatorID_fk { get; set; }
        public string Indicator { get; set; }

        public jmdl_IndicatorsSubInd(int subIndIDfk, string subInd, string subIndType, 
            string subIndStatus, double subIndSV, int indIDfk, string indicator)
        {
            SubIndicatorID_fk = subIndIDfk;
            SubIndicator = subInd;
            SubIndicatorType = subIndType;
            SubIndicatorStatus = subIndStatus;
            ScoreValue = subIndSV;
            IndicatorID_fk = indIDfk;
            Indicator = indicator;
        }
    }
}