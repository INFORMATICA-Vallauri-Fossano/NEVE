using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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

        internal string getAltezze(string posto)
        {
            string risp = "";
            string sql = "SELECT [min],[max] FROM Altezza A,localita L WHERE localita= @Localita and A.IDLOCALITA=L.IDLOCALITA";
            SqlCommand cmd = new SqlCommand(sql);
            cmd.Parameters.AddWithValue("@Localita", posto);

            System.Data.DataTable dt = ado.EseguiQuery(cmd);
            risp +="\r\nL'altezza minima è di :" + dt.Rows[0]["min"] .ToString();
            risp +="\r\nL'altezza massima è di :" + dt.Rows[0]["max"] .ToString();

            return risp;
        }
    }
}
