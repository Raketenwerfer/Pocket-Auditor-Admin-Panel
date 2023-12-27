﻿using Pocket_Auditor_Admin_Panel.Prompts;
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
    public partial class UCM_IndicatorItem : UserControl
    {

        readonly prompt_Edit_ISI pEditISI = new prompt_Edit_ISI();

        public UCM_IndicatorItem()
        {
            InitializeComponent();

        }


        // Properties to store data
        private int _categoryID;
        private string _categoryTitle;
        private int _indicatorID;
        private string _indicator;
        private int _indicatorNumber;
        private string _indicatorType;
        private double _scoreValue;

        private void pbox_btn_EditItem_Click(object sender, EventArgs e)
        {
            pEditISI.ShowDialog();
        }

        // Expose properties
        public int CategoryID
        {
            get { return _categoryID; }
            set
            {
                _categoryID = value;
                // Update UI or perform other actions as needed
            }
        }

        public string CategoryTitle
        {
            get { return _categoryTitle; }
            set
            {
                _categoryTitle = value;
                // Update UI or perform other actions as needed
            }
        }

        public int IndicatorID
        {
            get { return _indicatorID; }
            set
            {
                _indicatorID = value;
                // Update UI or perform other actions as needed
            }
        }

        public string Indicator
        {
            get { return _indicator; }
            set
            {
                _indicator = value;
                txt_itemName.Text = _indicator;
                // Update UI or perform other actions as needed
            }
        }

        public int IndicatorNumber
        {
            get { return _indicatorNumber; }
            set
            {
                _indicatorNumber = value;
                // Update UI or perform other actions as needed
            }
        }

        public string IndicatorType
        {
            get { return _indicatorType; }
            set
            {
                _indicatorType = value;
                // Update UI or perform other actions as needed
            }
        }

        public double ScoreValue
        {
            get { return _scoreValue; }
            set
            {
                _scoreValue = value;
                // Update UI or perform other actions as needed
            }
        }

    }

}
