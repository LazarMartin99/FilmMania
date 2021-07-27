using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmMánia.Database
{
     partial class Connection
     {

         /// Database-hez csatlakozó metódusok     
             public string getCreateConnectionString()
             {
                 return
                     "SERVER=\"localhost\";"
                     + "DATABASE=\"test\";"
                     + "UID=\"root\";"
                     + "PASSWORD=\"\";"
                     + "PORT=\"3306\";";
             }
             public string getConnectionString()
             {
                 return
                     "SERVER=\"localhost\";"
                     + "DATABASE=\"filmmania\";"
                     + "UID=\"root\";"
                     + "PASSWORD=\"\";"
                     + "PORT=\"3306\";";
             }

     }


}

     