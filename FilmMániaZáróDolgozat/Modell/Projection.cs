using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmMániaZáróDolgozat.Modell
{
    class Projection
    {
       int projectionid;
       int movieid;
       string date;
       string time;
       string price;


        public Projection(int movieid, string date, string time, string price)
        {
            this.movieid = movieid;
            this.date = date;
            this.time = time;
            if(!isValidPrice(price))
            {
                throw new ModellProjectionNotValidPriceException("A ár csak szám és az értéke 1500 és 2000 között lehet!");
            }
            this.price = price;
        }


        public Projection(int projectionid, int movieid, string date, string time, string price)
        {
            this.projectionid = projectionid;
            this.movieid = movieid;
            this.date = date;
            this.time = time;
            this.price = price;
        }




        public int Projectionid { get => projectionid; set => projectionid = value; }
        public string Date { get => date; set => date = value; }
        public string Time { get => time; set => time = value; }
        public string Price { get => price; set => price = value; }
        public int Movieid { get => movieid; set => movieid = value; }


        private bool isValidPrice(string price)
        {
            if (price.All(char.IsNumber))
            {
                int arint = int.Parse(price);
                if (arint >= 1500 && arint <= 2000)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }














        public string InsertInto()
        {

            return "INSERT INTO `projection` (`movie_id`, `date`, `time`, `price`) VALUES ('" + Movieid + "', '" + Date + "', '" + Time + "', '" + Price + "');";



        }
    }
}
