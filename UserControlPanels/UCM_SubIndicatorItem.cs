using MySql.Data.MySqlClient;
using Pocket_Auditor_Admin_Panel.Auxiliaries;
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
    public partial class UCM_SubIndicatorItem : UserControl
    {
        public DatabaseInitiator dbInit;
        readonly string DisplayType;
        private int indicator_id;
        private AdminPanel AP;
        private prompt_Edit_ISI pE_ISI;
        public UCM_SubIndicatorItem(string displayType, DatabaseInitiator _bucketDB, AdminPanel aP, prompt_Edit_ISI _parent)
        {
            InitializeComponent();
            DisplayType = displayType;
            dbInit = _bucketDB;
            AP = aP;
            pE_ISI = _parent;
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

                string insertAssociationQuery = "INSERT INTO associate_indicator_to_subindicator (IndicatorID_fk, SubIndicatorID_fk) " +
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

                string deleteAssociationQuery = "DELETE FROM associate_indicator_to_subindicator " +
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

        public void DeleteSubIndicator(int ID)
        {
            MySqlConnection conn = dbInit.GetConnection();

            try
            {
                conn.Open();

                string deleteAssociationQuery = "DELETE FROM SubIndicators " +
                                                "WHERE SubIndicatorID = @SubIndicatorID";

                using (MySqlCommand cmd = new MySqlCommand(deleteAssociationQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@SubIndicatorID", ID);

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
            DeleteSubIndicator(_SubIndicatorID);
            AP.PullSubIndicators();
            pE_ISI.PopuateSubIndicators();
        }
    }
}

