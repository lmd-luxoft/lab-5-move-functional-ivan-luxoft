using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRental.RentStrategy
{
    class RentChildren : RentStrategyBase
    {
        public RentChildren()
        {
            this.minRentPayment = 15;
            this.minRentDuration = 3;
            this.everyDayPayment = 15;
        }
    }
}
