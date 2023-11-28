namespace WebApplication1.Entities
{
    public class Book
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public string Category { get; set; }
        public int PageCount { get; set; }
        public string Color { get; set; }

        public ICollection<UserFavBook> UserFavBooks { get; set; }

    }
}
