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

namespace Pocket_Auditor_Admin_Panel.Prompts
{
    public partial class prompt_AddSubIndicator : Form
    {
        private DatabaseInitiator dbInit;
        private prompt_Edit_ISI pE_ISI;
        private AdminPanel AP;
        public prompt_AddSubIndicator(DatabaseInitiator _bucketDB, prompt_Edit_ISI _parent, AdminPanel aP)
        {
            dbInit = _bucketDB;
            InitializeComponent();
            pE_ISI = _parent;
            cbox_SubIndType.SelectedIndex = 0;
            AP = aP;
        }

        private void btn_AcceptSubIndicator_Click(object sender, EventArgs e)
        {
            InsertSubInd();
            AP.PullSubIndicators();
            pE_ISI.PopuateSubIndicators();
            this.Close();
        }

        private void InsertSubInd()
        {
            string _subind = tbox_SubIndicator.Text;
            string _subindtype = cbox_SubIndType.Text;
            double _scorevalue = 0;
            
            if (_subindtype == "DETAILS")
            {
                _scorevalue = 0;
            }
            else if (_subindtype == "OPTIONS")
            {
                _scorevalue = 0.5;
            }

            MySqlConnection conn = dbInit.GetConnection();

            try
            {
                conn.Open();

                string insertSubindCommand = "INSERT INTO SubIndicators (SubIndicator, SubIndicatorType, SubIndicatorStatus, ScoreValue) " +
                                             "VALUES (@SubIndicator, @SubIndicatorType, @SubIndicatorStatus, @ScoreValue)";

                using (MySqlCommand cmd = new MySqlCommand(insertSubindCommand, conn))
                {
                    cmd.Parameters.AddWithValue("SubIndicator", _subind);
                    cmd.Parameters.AddWithValue("SubIndicatorType", _subindtype);
                    cmd.Parameters.AddWithValue("SubIndicatorStatus", "ACTIVE");
                    cmd.Parameters.AddWithValue("ScoreValue", _scorevalue);

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
    }
}
