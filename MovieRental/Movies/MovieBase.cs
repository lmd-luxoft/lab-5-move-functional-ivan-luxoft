
namespace MovieRental.Movies
{
    public abstract class MovieBase
    {
        public string Title { get; }

        protected RentSettings rentSettings { get; }

        public MovieBase(string title,
            RentSettings rentSettings)
        {
            this.Title = title;
            this.rentSettings = rentSettings;
        }

        public override string ToString() => Title;

        public virtual double CalculateRentAmount(int days)
        {
            var result = rentSettings.MinRentPayment;

            if (days > rentSettings.MinRentDuration)
                result += (days - rentSettings.MinRentDuration) * rentSettings.EveryDayPayment;

            return result;
        }
        public virtual int PointsForRent(int days) => 1;
    }
}