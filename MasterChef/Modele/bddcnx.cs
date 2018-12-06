using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Modele
{
    public class CnxBDD
    {
        String Chaineconnection;
       public SqlConnection Connex;

        public CnxBDD()
        {
            Chaineconnection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Vico\Documents\MasterChef.mdf;Integrated Security=True;Connect Timeout=30";
            Connex = new SqlConnection(Chaineconnection);
        }

    }
}
