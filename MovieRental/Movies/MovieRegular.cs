namespace MovieRental.Movies
{
    public class MovieRegular : MovieBase
    {
        private static RentSettings rentSettingRegular = new RentSettings(2, 2, 15);

        public MovieRegular(string title)
            : base(title, rentSettingRegular)
        {

        }
    }
}
