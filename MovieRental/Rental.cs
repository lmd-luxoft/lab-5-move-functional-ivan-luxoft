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

        /// <summary>
        /// Рассчет очков лояльности за аренду фильма
        /// </summary>
        public int RentPoints => Movie.PointsForRent(DaysRental);
        
        /// <summary>
        /// Стоимость аренды фильма
        /// </summary>
        public double RentAmount => Movie.CalculateRentAmount(DaysRental);
    }
}