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
        readonly List<jmdl_IndicatorSubCat> _jmISC;
        System.Windows.Forms.Timer tick;
        prompt_AddSubCategory p_AddSC;
        public UCM_CategoryItem(AdminPanel _aP, CDisplay_ISI _bucketChild, FormCategorySelect _bucketParent,
            DatabaseInitiator _dbBucket, List<jmdl_CategoriesSubCategories> bucket_jmCSC,
            List<jmdl_IndicatorSubCat> bucket_ISC)
        {
            InitializeComponent();
            AP = _aP;
            child = _bucketChild;
            parent = _bucketParent;
            tick = ItemExpand;
            dbInit = _dbBucket;
            _jmCSC = bucket_jmCSC;
            _jmISC = bucket_ISC;
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

        public void PopulateSubCategory(int filterID)
        {
            _itemCount = 0;
            xpnd_subcatPanel.Controls.Clear();

            foreach (jmdl_CategoriesSubCategories data in _jmCSC)
            {
                UCM_SubCategoryItem userControl = new UCM_SubCategoryItem(child, _jmISC);

                if (data.SubCategoryStatus == "ACTIVE" && data.CategoryID_fk == filterID)
                {
                    userControl.CategoryID = data.CategoryID_fk;
                    userControl.CategoryTitle = data.CategoryTitle;
                    userControl.SubCategoryID = data.SubCategoryID_fk;
                    userControl.SubCategoryTitle = data.SubCategoryTitle;
                    userControl.SubCategoryStatus = data.SubCategoryStatus;

                    xpnd_subcatPanel.Controls.Add(userControl);
                    _itemCount++;
                }
            }
        }

        public void UCM_CategoryItem_Click(object sender, EventArgs e)
        {
            parent.SelectionHandle(CategoryID, CategoryTitle);
            PopulateSubCategory(CategoryID);
            isSelected = true;
            parent.GlobalCategoryDeselect(CategoryID);
            lbl_categoryName.BackColor = Color.FromArgb(173, 223, 136);
            xpnd_subcatPanel.BackColor = Color.FromArgb(173, 223, 136);
            BackColor = Color.FromArgb(173, 223, 136);

            tick.Start();
        }

        public void Deselect()
        {
            isSelected = false;
            lbl_categoryName.BackColor = Color.FromArgb(173, 223, 136);
            xpnd_subcatPanel.BackColor = Color.FromArgb(173, 223, 136);
            BackColor = Color.FromArgb(173, 223, 136);
            tick.Start();
        }

        private void ItemExpand_Tick(object sender, EventArgs e)
        {
            if (isSelected)
            {
                if (Height < (72 + (32 * _itemCount)))
                {
                    Height += 8;
                    xpnd_subcatPanel.Height += 8;
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
                    xpnd_subcatPanel.Height -= 8;
                }
                else
                {
                    btn_pnl.Visible = false;
                    btn_pnl.Enabled = false;
                    tick.Stop();
                }
            }
        }

        public void ExternalControlResize_AddItem()
        {
            UCM_CategoryItem_Click(btn_pnl, System.EventArgs.Empty);
        }

        private void AddSubCategory(object sender, EventArgs e)
        {
            p_AddSC = new prompt_AddSubCategory(AP, dbInit, CategoryID, CategoryTitle, this);
            p_AddSC.ShowDialog();
        }

        public void UI_Controls(bool MouseOver)
        {
            if (MouseOver)
            {
                btn_pnl.BackColor = Color.FromArgb(119, 186, 27);
            }
            if (!MouseOver)
            {
                btn_pnl.BackColor = Color.FromArgb(119, 186, 27);      
            }
        }

        private void btn_pnl_MouseEnter(object sender, EventArgs e)
        {
            UI_Controls(true);
        }

        private void btn_pnl_MouseLeave(object sender, EventArgs e)
        {
            UI_Controls(false);
        }

        private void btn_pnl_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
