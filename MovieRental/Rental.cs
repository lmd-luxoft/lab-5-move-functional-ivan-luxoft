using MovieRental.RentStrategy;
using System;

namespace MovieRental
{
    internal class Rental
    {
        public Movie Movie { get; }
        public int DaysRental { get; }
        RentStrategyBase rentStrategy;

        public Rental(Movie movie, int daysRental)
        {
            Movie = movie;
            DaysRental = daysRental;
            SetRentStrategy(movie.PriceType);
        }

        private void SetRentStrategy(Movie.Type movieType)
        {
            switch (movieType)
            {
                case Movie.Type.REGULAR:
                    rentStrategy = new RentRegular();
                    break;
                case Movie.Type.NEW_RELEASE:
                    rentStrategy = new RentNewRelease();
                    break;
                case Movie.Type.CHILDREN:
                    rentStrategy = new RentChildren();
                    break;
                default:
                    throw new ArgumentOutOfRangeException($"Not found rent strategy for movie with type \"{movieType}\"");
            }
        }

        public int RentPoints() => rentStrategy.PointsForRent(DaysRental);

        public double RentAmount() => rentStrategy.CalculateRentAmount(DaysRental);
    }
}