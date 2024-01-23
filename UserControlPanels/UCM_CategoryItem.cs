using Pocket_Auditor_Admin_Panel.Forms;
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
        public UCM_CategoryItem(CDisplay_ISI _bucketChild, FormCategorySelect _bucketParent)
        {
            InitializeComponent();
            child = _bucketChild;
            parent = _bucketParent;
        }

        private int _categoryID;
        private string _categoryTitle;
        private string _categoryStatus;

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
                lbl_categoryName.Text = value;
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
        }
    }
}
