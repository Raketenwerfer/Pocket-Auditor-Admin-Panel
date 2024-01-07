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


        private int _SubIndicatorID;
        private string _SubIndicator;
        private string _SubIndicatorType;
        private string _SubIndicatorStatus;
        private double _ScoreValue;

        public int SubIndicatorID
        {
            get { return _SubIndicatorID; }
            set
            {
                _SubIndicatorID = value;
            }

        }
        public string SubIndicator
        {
            get { return _SubIndicator; }
            set
            {
                _SubIndicator = value;
                cbox_SubIndicator.Text = _SubIndicator;
            }
        }

        public string SubIndicatorType
        {
            get { return _SubIndicatorType; }
            set
            {
                _SubIndicatorType = value;
            }
        }

        public string SubIndicatorStatus
        {
            get { return _SubIndicatorStatus; }
            set
            {
                _SubIndicatorStatus = value;
            }
        }

        public double ScoreValue
        {
            get { return _ScoreValue; }
            set
            {
                _ScoreValue = value;
            }
        }
    }
}

