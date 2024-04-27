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
    public partial class UCM_TopChapterItem : UserControl
    {
        public UCM_TopChapterItem()
        {
            InitializeComponent();
        }

        private int _rank;
        private string? _chapter;
        private double? _score;
        private string auditor;

        public int Rank
        {
            get { return _rank; }
            set { _rank = value; }
        }
        public string? Chapter
        {
            get { return _chapter; }
            set { _chapter = value; }
        }
        public string Auditor
        {
            get { return auditor; }
            set
            {
                auditor = value;
                lbl_Auditor.Text = auditor;
            }
        }
        public double? Score
        {
            get { return _score; }
            set { _score = value; SetData(); }
        }
        public void SetData()
        {
            lbl_Barangay.Text = "#" + _rank + " | " + _score.ToString() + " - " + _chapter;


            switch (_rank)
            {
                case 1:
                    BackColor = Color.Gold;
                    break;

                case 2:
                    BackColor = Color.Beige;
                    break;

                case 3:
                    BackColor = Color.Peru;
                    break;
            }

            if (_rank >= 4)
            {
                BackColor = Color.DimGray;
            }
        }
    }
}
