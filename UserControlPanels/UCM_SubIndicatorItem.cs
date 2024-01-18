using MySql.Data.MySqlClient;
using Pocket_Auditor_Admin_Panel.Auxiliaries;
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
    public partial class UCM_SubIndicatorItem : UserControl
    {
        public DatabaseInitiator dbInit;
        readonly string DisplayType;
        private int indicator_id;
        public UCM_SubIndicatorItem(string displayType, DatabaseInitiator _bucketDB)
        {
            InitializeComponent();
            DisplayType = displayType;
            dbInit = _bucketDB;
        }

        private int _SubIndicatorID;
        private string _SubIndicator;
        private string _SubIndicatorType;
        private string _SubIndicatorStatus;
        private double _ScoreValue;
        private bool _State;

        public int SubIndicatorID
        {
            get { return _SubIndicatorID; }
            set
            {
                _SubIndicatorID = value;
            }
        }

        public int IndicatorID
        {
            get { return indicator_id; }
            set
            {
                indicator_id = value;
            }
        }

        public string SubIndicator
        {
            get { return _SubIndicator; }
            set
            {
                _SubIndicator = value;
                cbox_SubIndicator.Text = _SubIndicator;
            }
        }

        public string SubIndicatorType
        {
            get { return _SubIndicatorType; }
            set
            {
                _SubIndicatorType = value;
            }
        }

        public string SubIndicatorStatus
        {
            get { return _SubIndicatorStatus; }
            set
            {
                _SubIndicatorStatus = value;
            }
        }

        public double ScoreValue
        {
            get { return _ScoreValue; }
            set
            {
                _ScoreValue = value;
            }
        }

        public bool State
        {
            get { return _State; }
            set
            {
                _State = value;
                cbox_SubIndicator.Checked = _State;
            }
        }

        public void AssociateSubIndicator(int indicatorID, int subIndicatorID)
        {
            MySqlConnection conn = dbInit.GetConnection();

            try
            {
                conn.Open();

                string insertAssociationQuery = "INSERT INTO Associate_Indicator_to_SubIndicator (IndicatorID_fk, SubIndicatorID_fk) " +
                                               "VALUES (@IndicatorID, @SubIndicatorID)";

                using (MySqlCommand cmd = new MySqlCommand(insertAssociationQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@IndicatorID", indicatorID);
                    cmd.Parameters.AddWithValue("@SubIndicatorID", subIndicatorID);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        public void DisassociateSubIndicator(int indicatorID, int subIndicatorID)
        {
            MySqlConnection conn = dbInit.GetConnection();

            try
            {
                conn.Open();

                string deleteAssociationQuery = "DELETE FROM Associate_Indicator_to_SubIndicator " +
                                                "WHERE IndicatorID_fk = @IndicatorID AND SubIndicatorID_fk = @SubIndicatorID";

                using (MySqlCommand cmd = new MySqlCommand(deleteAssociationQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@IndicatorID", indicatorID);
                    cmd.Parameters.AddWithValue("@SubIndicatorID", subIndicatorID);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        private void cbox_SubIndicator_MouseDown(object sender, MouseEventArgs e)
        {
            if (cbox_SubIndicator.Checked == false)
            {
                AssociateSubIndicator(indicator_id, _SubIndicatorID);
            }
            else
            {
                DisassociateSubIndicator(indicator_id, _SubIndicatorID);
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {

        }
    }
}

