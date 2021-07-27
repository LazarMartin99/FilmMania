using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmMániaZáróDolgozat.Modell
{
    class Favourites
    {

        int userid;
        int movieid;

        public Favourites(int userid, int movieid)
        {
            this.userid = userid;
            this.movieid = movieid;
        }

        public int Userid { get => userid; set => userid = value; }
        public int Movieid { get => movieid; set => movieid = value; }


        public string InsertInto()
        {
            return "INSERT INTO favourites (user_id, movie_id) VALUES ('" + Userid + "', '" + Movieid + "');";
        }

    }
}
