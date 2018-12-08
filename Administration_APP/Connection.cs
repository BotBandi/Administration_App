using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Administration_APP
{
    class Connection
    {
        public DatabaseConnectionInterface connect()
        {
            DatabaseConnectionInterface dti = new DatabaseConnectionInterface();
            dti.setConnectionServerData("localhost", "iroszeruzlet", "3306");
            dti.setConnectionUserData("root", " ");
            dti.makeConnectionToDatabase();
            dti.open();
            return dti;
        }
    }
}
