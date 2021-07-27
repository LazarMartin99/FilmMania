using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FilmMániaZáróDolgozat.Modell
{
    class Director
    {
        private int directorid;
        private string directorname;
        private string directorgender;
        private string directorbirth;
        private string directorabout;
        private string directorimg;

        public int Directorid { get => directorid; set => directorid = value; }
        public string Directorname { get => directorname; set => directorname = value; }
        public string Directorgender { get => directorgender; set => directorgender = value; }
        public string Directorbirth { get => directorbirth; set => directorbirth = value; }
        public string Directorabout { get => directorabout; set => directorabout = value; }
        public string Directorimg { get => directorimg; set => directorimg = value; }

        public Director(int directorid, string directorname, string directorgender, string directorbirth, string directorabout, string directorimg)
        {
            this.directorid = directorid;
            if (!isValidName(directorname))
            {
                throw new ModellDirectorNotValidNameException("Nem megfelelő név");
            }
            this.directorname = directorname;
            this.directorgender = directorgender;
            this.directorbirth = directorbirth;
            this.directorabout = directorabout;
            this.directorimg = directorimg;

        }

        public Director(string directorname, string directorgender, string directorbirth, string directorabout, string directorimg)
        {
            if (!isValidName(directorname))
            {
                throw new ModellDirectorNotValidNameException("Nem megfelelő név");
            }
            this.directorname = directorname;
            this.directorgender = directorgender;
            this.directorbirth = directorbirth;
            this.directorabout = directorabout;
            this.directorimg = directorimg;
        }

        private bool isValidName(string directorname)
        {
            if (directorname != string.Empty)
            {
                if (char.IsLower(directorname[0]))
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
           





        public void setDirectorId(int directorid)
        {
            this.directorid = directorid;
        }

        public void setDirectorName(string directorname)
        {
            this.directorname = directorname;
        }

        public void setDirectorGender(string directorgender)
        {
            this.directorgender = directorgender;
        }

        public void setDirectorBirth(string directorbirth)
        {
            this.directorbirth = directorbirth;
        }

        public void setDirectorAbout(string directorabout)
        {
            this.directorabout = directorabout;
        }
        public void setDirectorIMG(string directorimg)
        {
            this.directorimg = directorimg;
        }


        public int getDirectorId()
        {
            return directorid;
        }

        public string getDirectorName()
        {
            return directorname;
        }

        public string getDirectorGender()
        {
            return directorgender;
        }

        public string getDirectorBirth()
        {
            return directorbirth;
        }

        public string getDirectorAbout()
        {
            return directorabout;
        }

        public string getDirectorIMG()
        {
            return directorimg;
        }


        public string getInsert()
        {
            return "INSERT INTO `rendezo` (`name`, `gender`, `dob`, `about`, `image`) VALUES ('" + getDirectorName() + "', '" + getDirectorGender() + "', '" + getDirectorBirth() + "', '" + getDirectorAbout() + "', LOAD_FILE('" + getDirectorIMG() + "'));";
        }


    }
}
