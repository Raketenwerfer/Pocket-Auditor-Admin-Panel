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
        private List<mdl_SKChapters> SKC_HOLDER;
        private List<mdl_Categories> C_HOLDER;

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


        public void SET_SKC(List<mdl_SKChapters> list)
        {
            SKC_HOLDER = list;
        }

        public List<mdl_SKChapters> GET_SKC()
        {
            return SKC_HOLDER;
        }


        public void SET_C(List<mdl_Categories> list)
        {
            C_HOLDER = list;
        }

        public List<mdl_Categories> GET_C()
        {
            return C_HOLDER;
        }
    }
}
