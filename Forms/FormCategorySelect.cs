using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Org.BouncyCastle.Asn1.Ocsp;
using Pocket_Auditor_Admin_Panel.Auxiliaries;
using Pocket_Auditor_Admin_Panel.Classes;
using Pocket_Auditor_Admin_Panel.Forms;
using Pocket_Auditor_Admin_Panel.Prompts;
using Pocket_Auditor_Admin_Panel.UserControlPanels;

namespace Pocket_Auditor_Admin_Panel
{
    public partial class FormCategorySelect : Form
    {
        public DatabaseInitiator dbInit;

        public List<mdl_SubIndicators> _SubIndicators;
        public List<jmdl_CategoriesIndicators> _jmCI;

        public prompt_AddIndicator pAddIndicator;
        readonly AdminPanel AP;

        readonly List<mdl_Categories> _Categories;
        private CDisplay_ISI cDisplayISI;

        public int SelectedCategoryID;
        public FormCategorySelect(DatabaseInitiator bucket_init, List<jmdl_CategoriesIndicators> bucket_jmci,
            List<mdl_SubIndicators> bucket_si, AdminPanel aP, int _InitCat, List<mdl_Categories> _cat)
        {
            InitializeComponent();
            dbInit = bucket_init;
            _jmCI = bucket_jmci;
            _SubIndicators = bucket_si;
            AP = aP;
            SelectedCategoryID = _InitCat;

            _Categories = _cat;

            cDisplayISI = new CDisplay_ISI(dbInit, _jmCI, _SubIndicators, AP, SelectedCategoryID);

            DisplayISI();
        }

        private void DisplayISI()
        {
            cDisplayISI.TopLevel = false;
            cDisplayISI.TopMost = true;
            pnl_ISI_View.Controls.Clear();
            pnl_ISI_View.AutoScroll = true;
            pnl_ISI_View.Controls.Add(cDisplayISI);
            cDisplayISI.Show();

            PopulateCategories();
        }

        private void PopulateCategories()
        {
            flpCategories.Controls.Clear();

            foreach (mdl_Categories data in _Categories)
            {
                UCM_CategoryItem userControl = new UCM_CategoryItem(cDisplayISI, this);

                userControl.CategoryID = data.CategoryID;
                userControl.CategoryTitle = data.CategoryTitle;
                userControl.CategoryStatus = data.CategoryStatus;

                if (data.CategoryStatus == "ACTIVE")
                {
                    flpCategories.Controls.Add(userControl);
                }
            }
        }

        public void SelectionHandle(int id, string title)
        {
            cDisplayISI.SelectedCategoryID = id;
            cDisplayISI.SelectedCategoryTitle = title;
            cDisplayISI.PopulateIndicators(id);
        }
    }
}
