// NUnit 3 tests
// See documentation : https://github.com/nunit/docs/wiki/NUnit-Documentation
using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using MovieRental.Movies;

namespace MovieRental
{
    [TestFixture]
    public class TestClass
    {
        [Test]
        public void NameFilmShouldBeCorrect()
        {
            MovieBase movie = new MovieNewRelease("Rio2");
            Assert.AreEqual("Rio2", movie.Title);
        }
        [Test]
        public void RentalShouldBeCorrectMovie()
        {
            MovieBase movie = new MovieRegular("Angry Birds");
            Rental rental = new Rental(movie, 20);
            Assert.AreEqual(movie, rental.Movie);
        }
        [Test]
        public void RentalShouldBeCorrectDayRented()
        {

            MovieBase movie = new MovieRegular("Angry Birds");
            Rental rental = new Rental(movie, 20);
            Assert.AreEqual(20, rental.DaysRental);
        }
        [Test]
        public void CustomerShouldBeCorrectName()
        {
            Customer customer = new Customer("Bug");
            Assert.AreEqual("Bug", customer.Name);
        }
        [Test]
        public void CustomerCreateCorrectStatement()
        {
            Customer customer = new Customer("Bug");

            MovieBase movie1 = new MovieChildren("Angry Birds");
            Rental rental1 = new Rental(movie1, 2);
            customer.addRental(rental1);

            MovieBase movie2 = new MovieNewRelease("StarWar");
            Rental rental2 = new Rental(movie2, 10);
            customer.addRental(rental2);

            MovieBase movie3 = new MovieRegular("Hatico");
            Rental rental3 = new Rental(movie3, 4);
            customer.addRental(rental3);

            string actual = customer.statement();
            Assert.AreEqual("учет аренды для Bug\n\tAngry Birds\t15\n\tStarWar\t30\n\tHatico\t32\nСумма задолженности составляет 77\nВы заработали 4 очков за активность", actual);
        }
    }
}
