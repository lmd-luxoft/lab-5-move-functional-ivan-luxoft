namespace MovieRental.Movies
{
    public class MovieChildren : MovieBase
    {
        private static RentSettings rentSettingChildren = new RentSettings(15, 3, 15);

        public MovieChildren(string title)
            : base(title,  rentSettingChildren)
        {

        }
    }
}
