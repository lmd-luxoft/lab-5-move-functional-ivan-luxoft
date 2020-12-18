using System.Collections.Generic;
using System.Text;

namespace MovieRental
{
    public class Customer
    {
        List<Rental> rentals = new List<Rental>();
        public string Name { get; }

        public Customer(string name)
        {
            this.Name = name;
        }

        internal void addRental(Rental rental)
        {
           rentals.Add(rental);
        }

        internal string statement()
        {
            StringBuilder report = new StringBuilder();
            report.Append($"учет аренды для {Name}\n");
            double totalAmount = 0;

            int frequentRenterPoints = 0;
            foreach (var item in rentals)
            {
                double thisAmount = item.RentAmount();
                frequentRenterPoints += item.RentPoints();
                totalAmount += thisAmount;

                report.Append($"\t{item.Movie}\t{thisAmount}\n");
            }
            report.Append($"Сумма задолженности составляет {totalAmount}\nВы заработали {frequentRenterPoints} очков за активность");
            return report.ToString();
        }
    }
}