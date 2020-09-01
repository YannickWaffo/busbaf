using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusBaf.Dao
{
    class AccesBd
    {
        private static OdbcConnection connex = null;
        public static OdbcConnection getConnection()
        {
            if (connex == null)
            {
                connex = new OdbcConnection("dsn=bdTrans");
                connex.Open();
            }
            return connex;
        }
    }
}
