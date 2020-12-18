
namespace MovieRental.Movies
{
    public abstract class MovieBase
    {
        public string Title { get; }

        private RentSettings rentSettings { get; }

        public MovieBase(string title,
            RentSettings rentSettings)
        {
            this.Title = title;
            this.rentSettings = rentSettings;
        }

        public override string ToString() => Title;

        /// <summary>
        /// Рассчет стоимости аренды
        /// </summary>
        /// <param name="days">Количество дней аренды</param>
        /// <returns>Стоимость за указанное количество дней</returns>
        public virtual double CalculateRentAmount(int days)
        {
            var result = rentSettings.MinRentPayment;

            if (days > rentSettings.MinRentDuration)
                result += (days - rentSettings.MinRentDuration) * rentSettings.EveryDayPayment;

            return result;
        }

        /// <summary>
        /// Расчет очков активности
        /// </summary>
        /// <param name="days">Количество дней аренды</param>
        /// <returns>Количество очков за указанное количество дней</returns>
        public virtual int PointsForRent(int days) => 1;
    }
}