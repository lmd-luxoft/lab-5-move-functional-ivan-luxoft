// NUnit 3 tests
// See documentation : https://github.com/nunit/docs/wiki/NUnit-Documentation
using MovieRental.RentStrategy;

namespace MovieRental.RentStrategy
{
    internal class RentNewRelease : RentStrategyBase
    {
        public RentNewRelease()
        {
            this.minRentPayment = 0;
            this.minRentDuration = 0;
            this.everyDayPayment = 3;
        }

        public override int PointsForRent(int days) => days > 1 ? 2 : 1;
    }
}