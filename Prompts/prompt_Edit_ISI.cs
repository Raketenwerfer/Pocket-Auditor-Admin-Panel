﻿using Pocket_Auditor_Admin_Panel.Classes;
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
    public partial class prompt_Edit_ISI : Form
    {
        private string type { get; set; }
        List<mdl_Indicators> _Indicators;
        List<mdl_SubIndicators> _SubIndicators;
        List<jmdl_IndicatorsSubInd> _jmISI;
        private int selected_id;

        public prompt_Edit_ISI(string edit_type, int _selection, List<mdl_Indicators> indicators, 
            List<mdl_SubIndicators> subIndicators, List<jmdl_IndicatorsSubInd> jmISI)
        {
            selected_id = _selection;
            type = edit_type;
            _Indicators = indicators;
            _SubIndicators = subIndicators;
            _jmISI = jmISI;

            InitializeComponent();

            SetSize();
            SetView();

        }

        public void SetSize()
        {
            if (type == "indicator")
            {
                prmpt_dgv_subind.Visible = false;
                this.Size = new System.Drawing.Size(460, 240);
            }
            else if (type == "sunindicator")
            {
                prmpt_dgv_subind.Visible = true;
                this.Size = new System.Drawing.Size(460, 430);
            }
        }

        public void SetView()
        {
            if (type == "indicator")
            {
                lbl_editType.Text = "Editing Indicator";
                lbl_itemname.Text = "Indicator";
                lbl_itemnumber.Text = "Indicator Number";
                lbl_itemscorevalue.Text = "Score Value";
                lbl_assignment_or_dgvname.Text = "Assign Category";
            }
            else if (type == "subindicator")
            {
                lbl_editType.Text = "Editing Sub-Indicator";
                lbl_itemname.Text = "Sub-Indicator Question";
                lbl_itemscorevalue.Text = "Score Value";
                lbl_itemnumber.Visible = false;
                lbl_assignment_or_dgvname.Text = "Type";
            }
        }
    }
}