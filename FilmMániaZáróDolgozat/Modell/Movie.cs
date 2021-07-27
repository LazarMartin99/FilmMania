using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmMániaZáróDolgozat.Modell
{
    public class Movie
    {
        private int movieid;
        private string title;
        private string year;
        private string genre;
        private string rating;
        private string img;
        private string about;
        private int directorid;




        public Movie(int movieid,string title, string year, string genre, int directorid, string about, string rating,string img)
        {
            this.movieid = movieid;
            this.title = title;
            this.year = year;
            this.genre = genre;
            this.rating = rating;
            this.about = about;
            this.directorid = directorid;
            this.img = img;

        }

        public Movie(string title, string year, string genre, string rating, string img, string about, int directorid)
        {
            this.title = title;
            this.year = year;
            this.genre = genre;
            if (isValidRatingNumber(rating))
            {
                throw new ModellMovieNotValidRatingException("Az IMDb pontszámnak 1 és 10 között kell lennie!");
            }
            this.rating = rating;
            this.about = about;
            this.directorid = directorid;
            this.img = img;
        }

        public bool isValid()
        {
            if (!isValidMovieTitle())
            {
                throw new ModellMovieNotValidTitleException("A Film cime üres!");
            }
            if (!isValidMovieTitleUpperCase())
            {
                throw new ModellMovieNotValidTitleUpperCaseException("A Film cime nem nagybetüvel kezdődik");
            }
            if(!isValidYearLength())
            {
                throw new ModellMovieNotValidYearLengthException("A Film évszáma túl rövd/hosszú!");
            }
            if(!isValidYearAllCharIsNumber())
            {
                throw new ModellMovieNotValidYearAllCharIsNumber("Az évszám nem tartalmazhat betüket!");
            }
            if(!isValidYearNotMoreThan1850())
            {
                throw new ModellMovieNotValidYearNotMoreThan1850("Az évszám nem lehet 1850 alatt!");
            }


            return true;
            



        }


        public int Movieid { get => movieid; set => movieid = value; }
        public string Title { get => title; set => title = value; }
        public string Year { get => year; set => year = value; }
        public string Genre { get => genre; set => genre = value; }
        public string Rating { get => rating; set => rating = value; }
        public string Img { get => img; set => img = value; }
        public string About { get => about; set => about = value; }
        public int Directorid { get => directorid; set => directorid = value; }



        private bool isValidMovieTitle()
        {
            if (title == string.Empty)
            {
                return false;
            }
            else
            {
                return true;
            }

        }

        public bool isValidMovieTitleUpperCase()
        {
            if (char.IsUpper(title.ElementAt(0)))
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        private bool isValidRatingNumber(string rating)
        {
            if (rating != string.Empty)
            {             
                if (rating.Length <= 3)
                {
                    if (rating.Length == 1)
                    {
                        if (char.IsNumber(rating[0]))
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
                        if (char.IsNumber(rating[0]) && rating[1].Equals('.') && char.IsNumber(rating[2]))
                        {
                            return false;
                        }
                        else
                        {
                            return true;
                        }
                    }                                        
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


        private bool isValidYearLength()
        {
            if (year.Length == 4)
            {
                return true;
            }
            else
            {
                return false;
            }

        }


        private bool isValidYearAllCharIsNumber()
        {
            if (char.IsNumber(year[0]) && char.IsNumber(year[1]) && char.IsNumber(year[2]) && char.IsNumber(year[3]))
            {
                return true;
            }
            else
            {
                return false ;
            }
        }


        private bool isValidYearNotMoreThan1850()
        {

            if (Convert.ToInt32(year) > 1850)
            {
                return true;
            }

            return false;
        }

    public void setId(int movieid)
        {
            this.movieid = movieid;
        }

        public void setTitle(string title)
        {
            this.title = title;
        }


        public void setYear(string year)
        {
            this.year = year;
        }

        public void setGenre(string genre)
        {
            this.genre = genre;
        }

        public void setRating(string rating)
        {
            this.rating = rating;
        }

        public void setImg(string img)
        {
            this.img = img;
        }

        public void setAbout(string about)
        {
            this.about = about;
        }

        public void setDirectorid(int directorid)
        {
            this.directorid = directorid;
        }


        public int getmovieId()
        {
            return movieid;
        }

        public string getTitle()
        {
            return title;
        }

        public string getYear()
        {
            return year;
        }
        
        public string getGenre()
        {
            return genre;
        }
        

        public string getImg()
        {
            return img;
        }
        public string getAbout()
        {
            return about;
        }
        public int getDirectorid()
        {
            return directorid;
        }

        public string getRating()
        {
            return rating;
        }


        public string getInsert()
        {
            return "INSERT INTO `movie` (`title`, `year`, `genre`, `directorId`, `rating`, `about`, `img`) VALUES ('" + getTitle() + "', '" + getYear() + "', '" + getGenre() + "', '" + getDirectorid() + "', '" + getRating() + "', '" + getAbout() + "', LOAD_FILE('"+ getImg()+ "'));";
        }


    }
}
