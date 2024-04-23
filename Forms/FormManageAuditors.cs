using Pocket_Auditor_Admin_Panel.Auxiliaries;
using Pocket_Auditor_Admin_Panel.Classes;
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
    public partial class FormManageAuditors : Form
    {
        readonly DataTable UserTable = new DataTable();
        DataSharingService DSS;
        AdminPanel AP;
        List<mdl_Users> _Users;
        int index;

        public FormManageAuditors(AdminPanel aP)
        {
            DSS = DataSharingService.GetInstance();
            _Users = DSS.GET_U();
            InitializeComponent();
            PopulateTable();
            AP = aP;
        }

        public void PopulateTable()
        {
            UserTable.Columns.Add("User ID");
            UserTable.Columns.Add("Username");
            UserTable.Columns.Add("User Type");

            foreach (mdl_Users x in _Users)
            {
                UserTable.Rows.Add(x.UserID, x.Username, x.UserType);
            }

            dgv_Users.DataSource = UserTable;
            dgv_Users.Columns[0].Visible = false;
            dgv_Users.DefaultCellStyle.BackColor = Color.LightGray;
            dgv_Users.DefaultCellStyle.ForeColor = Color.DarkGray;
            dgv_Users.DefaultCellStyle.SelectionBackColor = Color.DeepSkyBlue;
            dgv_Users.DefaultCellStyle.SelectionForeColor = Color.Black;
        }

        public void EditUser(object sender, DataGridViewCellEventArgs e)
        {
            AP.ShowUserControlsPrompt("edit", Convert.ToInt32(dgv_Users.SelectedCells[0].Value));
            PopulateTable();
        }
    }
}
