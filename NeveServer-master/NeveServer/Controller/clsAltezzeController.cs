using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//
using ADOSQLServer2017_ns;

namespace NeveServer.Controller
{
    public class clsAltezzeController
    {
        ADOSQLServer2017 ado;
        public clsAltezzeController(string dbName)
        {
            this.ado = new ADOSQLServer2017(dbName);
        }
    }
}
