using Pocket_Auditor_Admin_Panel.Auxiliaries;
using Pocket_Auditor_Admin_Panel.Classes;
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
        readonly AdminPanel AP;
        readonly CDisplay_ISI child;
        readonly FormCategorySelect parent;
        readonly DatabaseInitiator dbInit;
        readonly List<jmdl_CategoriesSubCategories> _jmCSC;
        System.Windows.Forms.Timer tick;
        prompt_AddSubCategory p_AddSC;
        public UCM_CategoryItem(AdminPanel _aP, CDisplay_ISI _bucketChild, FormCategorySelect _bucketParent,
            DatabaseInitiator _dbBucket, List<jmdl_CategoriesSubCategories> bucket_jmCSC)
        {
            InitializeComponent();
            AP = _aP;
            child = _bucketChild;
            parent = _bucketParent;
            tick = ItemExpand;
            dbInit = _dbBucket;
            _jmCSC = bucket_jmCSC;
            btn_pnl.Visible = false;
            btn_pnl.Enabled = false;
        }

        private int _categoryID;
        private string _categoryTitle;
        private string _categoryStatus;

        public bool isSelected = false;
        public int _itemCount;


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

        public void PopulateSubCategory()
        {
            _itemCount = 0;
            xpnd_subcatPanel.Controls.Clear();

            foreach (jmdl_CategoriesSubCategories data in _jmCSC)
            {
                UCM_SubCategoryItem userControl = new UCM_SubCategoryItem();

                userControl.CategoryID = data.CategoryID_fk;
                userControl.CategoryTitle = data.CategoryTitle;
                userControl.SubCategoryID = data.SubCategoryID_fk;
                userControl.SubCategoryTitle = data.SubCategoryTitle;
                userControl.SubCategoryStatus = data.SubCategoryStatus;

                if (data.SubCategoryStatus == "ACTIVE" && data.CategoryID_fk == _categoryID)
                {
                    xpnd_subcatPanel.Controls.Add(userControl);
                    _itemCount++;
                }
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
            PopulateSubCategory();
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
                    btn_pnl.Visible = true;
                    btn_pnl.Enabled = true;
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
                    btn_pnl.Visible = false;
                    btn_pnl.Enabled = false;
                    tick.Stop();
                }
            }
        }

        private void AddSubCategory(object sender, EventArgs e)
        {
            p_AddSC = new prompt_AddSubCategory(AP, dbInit, CategoryID, CategoryTitle, this);
            p_AddSC.ShowDialog();
        }

    }
}
