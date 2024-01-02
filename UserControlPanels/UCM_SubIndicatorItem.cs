using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pocket_Auditor_Admin_Panel.UserControlPanels
{
    public partial class UCM_SubIndicatorItem : UserControl
    {
        readonly string DisplayType;
        public UCM_SubIndicatorItem(string displayType)
        {
            InitializeComponent();
            DisplayType = displayType;
        }


        private int SubIndicatorID_fk;
        private string SubIndicator;
        private string SubIndicatorType;
        private string SubIndicatorStatus;
        private double ScoreValue;
        private int IndicatorID_fk;
        private string Indicator;

        public int SubIndicatorID_FK
        {
            get { return SubIndicatorID_fk; }
            set
            {
                SubIndicatorID_fk = value;
            }
        }
        public string SubIndicatorProperty
        {
            get { return SubIndicator; }
            set
            {
                SubIndicator = value;
                cbox_SubIndicator.Text = SubIndicator;
            }
        }

        public string SubIndicatorTypeProperty
        {
            get { return SubIndicatorType; }
            set
            {
                SubIndicatorType = value;
            }
        }

        public string SubIndicatorStatusProperty
        {
            get { return SubIndicatorStatus; }
            set
            {
                SubIndicatorStatus = value;
            }
        }

        public double ScoreValueProperty
        {
            get { return ScoreValue; }
            set
            {
                ScoreValue = value;
            }
        }

        public int IndicatorID_FK
        {
            get { return IndicatorID_fk; }
            set
            {
                IndicatorID_fk = value;
            }
        }

        public string IndicatorProperty
        {
            get { return Indicator; }
            set
            {
                Indicator = value;
            }
        }
    }
}

