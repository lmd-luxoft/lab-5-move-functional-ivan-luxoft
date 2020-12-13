namespace MovieRental.RentStrategy
{
    public class RentStrategyBase
    {
        protected int minRentPayment, minRentDuration, everyDayPayment;

        public virtual double CalculateRentAmount(int days)
        {
            var result = minRentPayment;

            if (days > minRentDuration)
                result += (days - minRentDuration) * everyDayPayment;

            return result;
        }
        public virtual int PointsForRent(int days) => 1;
    }
}
