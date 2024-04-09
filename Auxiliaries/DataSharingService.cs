using Pocket_Auditor_Admin_Panel.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pocket_Auditor_Admin_Panel.Auxiliaries
{
    public class DataSharingService
    {
        private static DataSharingService instance;
        public static DatabaseInitiator dbInit;
        private List<mdl_ScoreTable> ST_HOLDER;

        public DataSharingService()
        {
        }
        public static DataSharingService GetInstance()
        {
            if (instance == null)
            {
                instance = new DataSharingService();
            }

            return instance;
        }

        public void SetDatabase(DatabaseInitiator db)
        {
            dbInit = db;
        }
        public DatabaseInitiator GetDatabase()
        {
            return dbInit;
        }



        public void SET_ST(List<mdl_ScoreTable> list)
        {
            ST_HOLDER = list;
        }

        public List<mdl_ScoreTable> GET_ST()
        {
            return ST_HOLDER;
        }
    }
}
