using Microsoft.VisualStudio.TestTools.UnitTesting;
using FilmMániaZáróDolgozat.Modell;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmMániaZáróDolgozat.Modell.Tests
{
    [TestClass()]
    public class MovieTests
    {
        [TestMethod()]
        public void isValidTestMovieTitleIsEmpty()
        {
            try
            {
                Movie m = new Movie("Nagymenők", "1998", "Krimi", "8.6", "asd", "Ez egy jó film", 8);
                if (m.isValid())
                {
                }
            }
            catch (Exception e)
            {
                Assert.Fail("A Film első betűje nagybetű mégis hibát dob");
            }
        }

        [TestMethod()]
        public void isValidTestMovieTitleUpperCase()
        {
            try
            {
                Movie m = new Movie("Nagymenők", "1998", "Krimi", "8.6", "asd", "Ez egy jó film", 8);
                if (m.isValid())
                {
                }
            }
            catch (Exception e)
            {
                Assert.Fail("A Film első betűje nagybetű mégis hibát dob");
            }
        }

        [TestMethod()]
        public void isValidTestMovieYearLength()
        {
            try
            {
                Movie m = new Movie("Nagymenők", "1998a", "Krimi", "8.6", "asd", "Ez egy jó film", 8);
                if (m.isValid())
                {
                    Assert.Fail("Üres név esetén nem dob kivételt!");
                }
            }
            catch (ModellMovieNotValidYearLengthException mmnvyle)
            {
                if (mmnvyle.Message != "A Film évszáma túl rövd/hosszú!")
                    Assert.Fail("Üres név esetén hibát dob, de a hiba szövege rossz!");
            }
            catch (Exception e)
            {
                Assert.Fail("Üres név esetén nem dob kivételt vagy rossz kivételt dob!");
            }
        }


        [TestMethod()]
        public void isValidTestMovieYearAllCharIsNumber()
        {
            try
            {
                Movie m = new Movie("Nagymenők", "199d", "Krimi", "8.6", "asd", "Ez egy jó film", 8);
                if (m.isValid())
                {
                    Assert.Fail("Üres név esetén nem dob kivételt!");
                }
            }
            catch (ModellMovieNotValidYearAllCharIsNumber mmnvyacin)
            {
                if (mmnvyacin.Message != "Az évszám nem tartalmazhat betüket!")
                    Assert.Fail("Üres név esetén hibát dob, de a hiba szövege rossz!");
            }
            catch (Exception e)
            {
                Assert.Fail("Üres név esetén nem dob kivételt vagy rossz kivételt dob!");
            }
        }


        [TestMethod()]
        public void isValidTestYearIsMoreThan1850()
        {
            try
            {
                Movie m = new Movie("Nagymenők", "1860", "Krimi", "8.6", "asd", "Ez egy jó film", 8);
                if (m.isValid())
                {
                }
            }
            catch (Exception e)
            {
                Assert.Fail("A Film első betűje nagybetű mégis hibát dob");
            }
        }





    }
}