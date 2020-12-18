using MovieRental.Movies;

namespace MovieRental
{
    internal class Rental
    {
        public MovieBase Movie { get; }
        public int DaysRental { get; }

        public Rental(MovieBase movie, int daysRental)
        {
            Movie = movie;
            DaysRental = daysRental;
        }

        public int RentPoints() => Movie.PointsForRent(DaysRental);

        public double RentAmount() => Movie.CalculateRentAmount(DaysRental);
    }
}