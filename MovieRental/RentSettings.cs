namespace MovieRental
{
    public struct RentSettings
    {
        /// <summary>
        /// Минимальная сумма аренды
        /// </summary>
        public int MinRentPayment { get; set; }

        /// <summary>
        /// Минимальное количество дней аренды (оплачено MinRentPayment)
        /// </summary>
        public int MinRentDuration { get; set; }

        /// <summary>
        /// Стоимость аренды в день сверх MinRentDuration
        /// </summary>
        public int EveryDayPayment { get; set; }

        public RentSettings(int minRentPayment, int minRentDuration, int everyDayPayment)
        {
            MinRentPayment = minRentPayment;
            MinRentDuration = minRentDuration;
            EveryDayPayment = everyDayPayment;
        }
    }
}