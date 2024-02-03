using Pocket_Auditor_Admin_Panel.Auxiliaries;
using Pocket_Auditor_Admin_Panel.Forms;
using Pocket_Auditor_Admin_Panel.Prompts;
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
    public partial class UCM_CategoryItem : UserControl
    {
        readonly CDisplay_ISI child;
        readonly FormCategorySelect parent;
        readonly DatabaseInitiator dbInit;
        System.Windows.Forms.Timer tick;
        prompt_AddSubCategory p_AddSC;
        public UCM_CategoryItem(CDisplay_ISI _bucketChild, FormCategorySelect _bucketParent,
            DatabaseInitiator _dbBucket)
        {
            InitializeComponent();
            child = _bucketChild;
            parent = _bucketParent;
            tick = ItemExpand;
            dbInit = _dbBucket;
        }

        private int _categoryID;
        private string _categoryTitle;
        private string _categoryStatus;

        public bool isSelected = false;


        public int CategoryID
        {
            get { return _categoryID; }
            set
            {
                _categoryID = value;
            }
        }
        public string CategoryTitle
        {
            get { return _categoryTitle; }
            set
            {
                _categoryTitle = value;
                lbl_categoryName.Text = _categoryTitle;
            }

        }
        public string CategoryStatus
        {
            get { return _categoryStatus; }
            set
            {
                _categoryStatus = value;
            }
        }

        private void UCM_CategoryItem_Click(object sender, EventArgs e)
        {
            parent.SelectionHandle(CategoryID, CategoryTitle);

            isSelected = true;
            parent.GlobalCategoryDeselect(CategoryID);
            lbl_categoryName.BackColor = Color.White;
            xpnd_subcatPanel.BackColor = Color.White;
            BackColor = Color.White;
            tick.Start();
        }

        public void Deselect()
        {
            isSelected = false;
            lbl_categoryName.BackColor = Color.SeaGreen;
            xpnd_subcatPanel.BackColor = Color.SeaGreen;
            BackColor = Color.SeaGreen;
            tick.Start();
        }

        private void ItemExpand_Tick(object sender, EventArgs e)
        {
            if (isSelected)
            {
                if (Height < 96)
                {
                    Height += 8;
                }
                else
                {
                    tick.Stop();
                }
            }

            if (!isSelected)
            {
                if (Height > 32)
                {
                    Height -= 8;
                }
                else
                {
                    tick.Stop();
                }
            }
        }

        private void AddSubCategory(object sender, EventArgs e)
        {
            p_AddSC = new prompt_AddSubCategory(dbInit, _categoryID, CategoryTitle);
            p_AddSC.ShowDialog();
        }

    }
}
