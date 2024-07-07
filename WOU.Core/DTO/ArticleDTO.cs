namespace WOU.Core.DTO
{
    public class ArticleDTO
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public DateOnly RealseDate { get; set; }
    }
}
