// NUnit 3 tests
// See documentation : https://github.com/nunit/docs/wiki/NUnit-Documentation
using MovieRental.RentStrategy;
using System;

namespace MovieRental
{
    internal class Rental
    {
        private Movie movie;
        private int daysRental;
        RentStrategyBase rentStrategy;

        public Rental(Movie movie, int daysRental)
        {
            this.movie = movie;
            this.daysRental = daysRental;
            this.SetRentStrategy(movie.getPriceCode());
        }

        internal Movie getMovie()
        {
            return movie;
        }

        internal int getDaysRented()
        {
            return daysRental;
        }

        private void SetRentStrategy(Movie.Type movieType)
        {
            switch (movieType)
            {
                case Movie.Type.REGULAR:
                    this.rentStrategy = new RentRegular();
                    break;
                case Movie.Type.NEW_RELEASE:
                    this.rentStrategy = new RentNewRelease();
                    break;
                case Movie.Type.CHILDREN:
                    this.rentStrategy = new RentChildren();
                    break;
                default:
                    throw new ArgumentOutOfRangeException($"Not found rent strategy for movie with type \"{movieType}\"");
            }
        }

        internal int RentPoints()
        {
            return this.rentStrategy.PointsForRent(daysRental);
        }

        public double RentAmount() => rentStrategy.CalculateRentAmount(daysRental);
    }
}