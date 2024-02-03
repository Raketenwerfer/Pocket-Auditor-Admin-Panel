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
    public partial class UCM_SubCategoryItem : UserControl
    {
        public UCM_SubCategoryItem()
        {
            InitializeComponent();
        }


        private int _subcategoryID;
        private string _subcategoryTitle;
        private string _subcategoryStatus;
        private int _categoryID;
        private string _categoryTitle;

        public int SubCategoryID
        {
            get { return _subcategoryID; }
            set
            {
                _subcategoryID = value;
            }
        }
        public string SubCategoryTitle
        {
            get { return _subcategoryTitle; }
            set
            {
                _subcategoryTitle = value;
                lbl_subCategoryName.Text = _subcategoryTitle;
            }

        }
        public string SubCategoryStatus
        {
            get { return _subcategoryStatus; }
            set
            {
                _subcategoryStatus = value;
            }
        }
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
            }
        }

    }
}
