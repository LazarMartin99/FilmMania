using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmMániaZáróDolgozat.Modell
{
    class Actor
    {

        private int actorid;
        private string actorname;
        private string actorgender;
        private string actorbirth;
        private string actorabout;
        private string actorimg;


        /// <summary>
        /// Konstruktor 
        /// </summary>
        /// <param name="actorid"></param>
        /// <param name="actorname"></param>
        /// <param name="actorgender"></param>
        /// <param name="actorbirth"></param>
        /// <param name="actorabout"></param>
        /// <param name="actorimg"></param>

        public Actor(int actorid, string actorname, string actorgender, string actorbirth, string actorabout, string actorimg)
        {
            if (!isValidName(actorname))
            {
                throw new ModellActorIsValidNameException("Nem megfelelő név");
            }
            this.actorname = actorname;
            this.actorname = actorname;
            this.actorgender = actorgender;
            this.actorbirth = actorbirth;
            this.actorabout = actorabout;
            this.actorimg = actorimg;
        }

        /// <summary>
        /// Konstruktor ID nélkül adatfeltöltéshez mivel az id autoincrement
        /// </summary>
        /// <param name="actorname"></param>
        /// <param name="actorgender"></param>
        /// <param name="actorbirth"></param>
        /// <param name="actorabout"></param>
        /// <param name="actorimg"></param>

        public Actor(string actorname, string actorgender, string actorbirth, string actorabout, string actorimg)
        {
            if (!isValidName(actorname))
            {
                throw new ModellActorIsValidNameException("Nem megfelelő név");
            }
            this.actorname = actorname;
            this.actorgender = actorgender;
            this.actorbirth = actorbirth;
            this.actorabout = actorabout;
            this.actorimg = actorimg;
        }




        private bool isValidName(string actorname)
        {
            if (actorname != string.Empty)
            {
                if (char.IsLower(actorname[0]))
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else
            {
                return true;
            }

        }

        /// <summary>
        /// SET / GET FÜGGVÉNYEK
        /// </summary>

        public int Actorid { get => actorid; set => actorid = value; }
        public string Actorname { get => actorname; set => actorname = value; }
        public string Actorgender { get => actorgender; set => actorgender = value; }
        public string Actorbirth { get => actorbirth; set => actorbirth = value; }
        public string Actorabout { get => actorabout; set => actorabout = value; }
        public string Actorimg { get => actorimg; set => actorimg = value; }


        public void setActorId(int actorid)
        {
            this.actorid = actorid;
        }

        public void setActorName(string actorname)
        {
            this.actorname = actorname;
        }

        public void setActorGender(string actorgender)
        {
            this.actorgender = actorgender;
        }

        public void setActorBirth(string actorbirth)
        {
            this.actorbirth = actorbirth;
        }

        public void setActorAbout(string actorabout)
        {
            this.actorabout = actorabout;
        }

        public void setActorIMG(string actorimg)
        {
            this.actorimg = actorimg;
        }

        public int getActorId()
        {
            return actorid;
        }

        public string getActorName()
        {
            return actorname;
        }

        public string getActorGender()
        {
            return actorgender;
        }

        public string getActorBirth()
        {
            return actorbirth;
        }

        public string getActorAbout()
        {
            return actorabout;
        }

        public string getActorIMG()
        {
            return actorimg;
        }

        /// <summary>
        /// INSERT INTO STRING Adatfeltöltéshez
        /// </summary>
        /// <returns></returns>
        public string getInsert()
        {
            return "INSERT INTO `actor` (`actor_name`, `gender`, `dob`, `about`, `image`) VALUES ('" + getActorName() + "', '" + getActorGender() + "', '" + getActorBirth() + "', '" + getActorAbout() + "', LOAD_FILE('" + getActorIMG() + "'));";


        }
    }

}

