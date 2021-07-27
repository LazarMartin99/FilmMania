using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmMániaZáróDolgozat.Modell
{
    partial class User
    {
        public string getInsert()
        {
            return
                "INSERT INTO `login` (`userid`, `username`, `useremail`, `userpassword`) " +
                "VALUES ('" +
                userid +
                "', '" +
                getusername() +
                "', '" +
                getuseremail() +
                "', '" +
                getuserpassword() +
                "');";
        }
    }
}
