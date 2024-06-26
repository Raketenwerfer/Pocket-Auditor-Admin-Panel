﻿using MySql.Data.MySqlClient;
using Pocket_Auditor_Admin_Panel.Auxiliaries;
using Pocket_Auditor_Admin_Panel.Classes;
using Pocket_Auditor_Admin_Panel.Prompts;
using Pocket_Auditor_Admin_Panel.UserControlPanels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pocket_Auditor_Admin_Panel.Forms
{
    public partial class CDisplay_ISI : Form
    {
        public DatabaseInitiator dbInit;

        public List<mdl_SubIndicators> _SubIndicators;
        public List<mdl_SubCategories> _SubCategories;
        public List<jmdl_CategoriesIndicators> _jmCI;
        readonly List<jmdl_IndicatorSubCat> _jmISC;
        readonly List<jmdl_CategoriesSubCategories> _jmCSC;

        public prompt_AddIndicator pAddIndicator;
        public int SelectedCategoryID;
        public string SelectedCategoryTitle;

        public AdminPanel AP;
        readonly FormCategorySelect FCS;

        public string SelectionType;


        public CDisplay_ISI(DatabaseInitiator bucket_init, List<jmdl_CategoriesIndicators> bucket_jmci,
            List<mdl_SubIndicators> bucket_si, AdminPanel aP, int _InitCat, FormCategorySelect _FCS,
            List<mdl_SubCategories> subCategories, List<jmdl_IndicatorSubCat> bucket_jmISC,
            List<jmdl_CategoriesSubCategories> bucket_jmCSC)
        {
            dbInit = bucket_init;
            _jmCI = bucket_jmci;
            _SubIndicators = bucket_si;
            AP = aP;
            SelectedCategoryID = _InitCat;
            FCS = _FCS;
            _SubCategories = subCategories;
            _jmISC = bucket_jmISC;
            _jmCSC = bucket_jmCSC;


            InitializeComponent();

            PopulateIndicators(SelectedCategoryID);

        }

        public void PopulateIndicators(int filterCategoryID)
        {
            lbl_dis_CategoryName.Text = SelectedCategoryTitle;

            flowLayoutPanel1.Controls.Clear();

            foreach (jmdl_CategoriesIndicators data in _jmCI)
            {
                // Check if the CategoryID matches the filterCategoryID
                if (data.CategoryID == filterCategoryID)
                {
                    // Create a new instance of the UserControl
                    UCM_IndicatorItem userControl = new UCM_IndicatorItem(dbInit, this, AP,
                        _SubIndicators, _SubCategories, _jmCSC);

                    // Set the UserControl properties using the data from your list
                    userControl.CategoryID = data.CategoryID;
                    userControl.CategoryTitle = data.CategoryTitle;
                    userControl.IndicatorID = data.IndicatorID;
                    userControl.Indicator = data.Indicator;
                    userControl.ScoreValue = data.ScoreValue;

                    // Add the UserControl to the FlowLayoutPanel
                    flowLayoutPanel1.Controls.Add(userControl);
                }
            }
        }

        public void SubCatFilter(int filterSubCategoryID, int filterCategoryID)
        {
            lbl_dis_CategoryName.Text = SelectedCategoryTitle;

            flowLayoutPanel1.Controls.Clear();

            foreach (jmdl_IndicatorSubCat subcat in _jmISC)
            {
                if (subcat.SubCategoryID_fk == filterSubCategoryID &&
                    subcat.CategoryID_fk == filterCategoryID)
                {
                    // Create a new instance of the UserControl
                    UCM_IndicatorItem userControl = new UCM_IndicatorItem(dbInit, this, AP,
                        _SubIndicators, _SubCategories, _jmCSC);

                    // Set the UserControl properties using the data from your list
                    userControl.CategoryID = subcat.CategoryID_fk;
                    //userControl.CategoryTitle = subcat.CategoryTitle;
                    userControl.IndicatorID = subcat.IndicatorID_fk;
                    userControl.Indicator = subcat.Indicator;
                    //userControl.IndicatorType = subcat.IndicatorType;
                    //userControl.ScoreValue = subcat.ScoreValue;

                    // Add the UserControl to the FlowLayoutPanel
                    flowLayoutPanel1.Controls.Add(userControl);
                }
            }
        }

        public void AddIndicator(object sender, EventArgs e)
        {
            pAddIndicator = new prompt_AddIndicator(dbInit, SelectedCategoryTitle, SelectedCategoryID, AP, this);
            pAddIndicator.ShowDialog();
        }

        private void pbox_btn_ConfigureCategory_Click(object sender, EventArgs e)
        {
            prompt_Edit_Category pEC = new prompt_Edit_Category(dbInit, AP, FCS, this, SelectedCategoryTitle, SelectedCategoryID);
            pEC.ShowDialog();
        }

        public void ExternalUpdate(string title)
        {
            lbl_dis_CategoryName.Text = title;
        }

        internal void FilterIndicators(int categoryID, string subCategoryTitle)
        {
            throw new NotImplementedException();
        }
    }
}
