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
    public partial class UCM_AssociateSubCategoryItem : UserControl
    {
        public UCM_AssociateSubCategoryItem()
        {
            InitializeComponent();
        }

        private int _subcategoryID;
        private string _subcategoryTitle;
        private string _subcategoryStatus;

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
                cbox_SubCategory.Text = _subcategoryTitle;
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
    }
}
