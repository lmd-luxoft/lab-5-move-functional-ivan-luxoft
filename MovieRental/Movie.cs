namespace MovieRental
{
    public class Movie
    {
        public string Title { get; }
        public Type PriceType { get; }

        public Movie(string title, Type type)
        {
            this.Title = title;
            this.PriceType = type;
        }

        public enum Type
        {
            NEW_RELEASE,
            REGULAR,
            CHILDREN
        }

        public override string ToString() => Title;
    }
}