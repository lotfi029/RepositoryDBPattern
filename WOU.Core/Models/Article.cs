namespace WOU.Core.Models
{
    public class Article
    {
        public int Id { get; set; }
        public required string Title { get; set; }
        public DateOnly RealseDate { get; set; }
        public int AuthorId { get; set; }
        public Author Author { get; set; } = null!;
    }
}