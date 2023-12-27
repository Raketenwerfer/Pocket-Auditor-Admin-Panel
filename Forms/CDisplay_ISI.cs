using MySql.Data.MySqlClient;
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

        public List<jmdl_IndicatorsSubInd> _jmISI;
        public List<jmdl_CategoriesIndicators> _jmCI;

        public prompt_AddIndicator pAddIndicator = new prompt_AddIndicator();

        public CDisplay_ISI(DatabaseInitiator bucket_init, List<jmdl_CategoriesIndicators> bucket_jmci,
            List<jmdl_IndicatorsSubInd> bucket_jmisi)
        {
            dbInit = bucket_init;
            _jmCI = bucket_jmci;
            _jmISI = bucket_jmisi;

            InitializeComponent();
            PopulateIndicators();
        }

        public void PopulateIndicators()
        {
            foreach (jmdl_CategoriesIndicators data in _jmCI)
            {
                // Create a new instance of the UserControl
                UCM_IndicatorItem userControl = new UCM_IndicatorItem();

                // Set the UserControl properties using the data from your list
                userControl.CategoryID = data.CategoryID;
                userControl.CategoryTitle = data.CategoryTitle;
                userControl.IndicatorID = data.IndicatorID;
                userControl.Indicator = data.Indicator;
                userControl.IndicatorNumber = data.IndicatorNumber;
                userControl.IndicatorType = data.IndicatorType;
                userControl.ScoreValue = data.ScoreValue;

                // Add the UserControl to the FlowLayoutPanel
                flowLayoutPanel1.Controls.Add(userControl);
            }
        }

        public void AddIndicator (object sender, EventArgs e)
        {
            pAddIndicator.ShowDialog();
        }
    }
}
