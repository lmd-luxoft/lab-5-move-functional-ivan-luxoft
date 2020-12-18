namespace MovieRental.Movies
{
    public class MovieNewRelease : MovieBase
    {
        private static RentSettings rentSettingNewRelease = new RentSettings(0, 0, 3);

        public MovieNewRelease(string title)
            : base(title, rentSettingNewRelease)
        {

        }

        public override int PointsForRent(int days) => days > 1 ? 2 : 1;
    }
}
