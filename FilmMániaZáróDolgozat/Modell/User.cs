using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Text.RegularExpressions;


namespace FilmMániaZáróDolgozat.Modell
{
    partial class User
    {
        private int userid;
        private string username;
        private string useremail;
        private string userpassword;

        public User(string username, string useremail, string userpassword)
        {

            if(!isValidName(username))
            {
                throw new ModellUserNotValidNameException("A felhasználó neve nem megfelelő(Üres vagy szóköz van benne)");
            }
            this.username=username;
            if(!isValidEmail(useremail))
            {
                throw new ModellUserNotValidEmailException("Az emailcim nem megfelelő");
            }
            this.useremail = useremail;
            if(!isValidPassword(userpassword))
            {
                throw new ModellUserNotValidPasswordException("A jelszó nem megfelelő(tartalmaznia kell minimum egy számot és minmum 7 karaktert");
            }
            this.userpassword = userpassword;

        }

        public bool isValidName(string username)
        {
            if(username==string.Empty)
            {
                return false;
            }

            for (int i = 1; i<username.Length; i++)
            {
                if ((!char.IsLetter(username.ElementAt(i))) && (!char.IsWhiteSpace(username.ElementAt(i))))
                {
                    return false;
                }
            }
            return true;
        }

        public bool isValidEmail(string useremail)
        {
            return Regex.IsMatch(useremail, @"^[\w!#$%&'+-/=?^_`{|}~]+(.[\w!#$%&'+-/=?^_`{|}~]+)*@((([-\w]+.)+[a-zA-Z]{2,4})|(([0-9]{1,3}.){3}[0-9]{1,3}))\z");
        }

        public bool isValidPassword(string userpassword)
        {
            if (userpassword.Length <= 7)
            {
                return false;
            }

            for (int i = 1; i < userpassword.Length; i++)
            {
                if(!char.IsLetter(userpassword.ElementAt(i)) && !char.IsDigit(userpassword.ElementAt(i)))
                {
                    return false;
                }
            }

            return true;
        }

        public void setId(int userid)
        {
            this.userid = userid;
        }

        public void setusername(string username)
        {
            this.username = username;
        }

        public void setuseremail(string useremail)
        {
            this.useremail = useremail;
        }

        public void setuserpassword(string userpassword)
        {
            this.userpassword = userpassword;
        }


        public string getuserpassword()
        {
            return userpassword;
        }


        public string getuseremail()
        {
            return useremail;
        }

        public string getusername()
        {
            return username;
        }


        public int getId()
        {
            return userid;
        }

    }
}
