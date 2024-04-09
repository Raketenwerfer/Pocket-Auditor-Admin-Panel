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
        private DatabaseInitiator dbInit;


        public DataSharingService GetInstance()
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
    }
}
