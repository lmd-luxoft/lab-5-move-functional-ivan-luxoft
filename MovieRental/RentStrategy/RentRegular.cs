// NUnit 3 tests
// See documentation : https://github.com/nunit/docs/wiki/NUnit-Documentation
using MovieRental.RentStrategy;
using System.Configuration;

namespace MovieRental.RentStrategy
{
    internal class RentRegular : RentStrategyBase
    {
        public RentRegular()
        {
            this.minRentPayment = 2;
            this.minRentDuration = 2;
            this.everyDayPayment = 15;
        }
    }
}