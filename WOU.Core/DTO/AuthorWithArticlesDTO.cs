namespace WOU.Core.DTO
{
    public class AuthorWithArticlesDTO
    {
        public AuthorDTO authorDTO { get; set; }
        public IEnumerable<ArticleDTO> Articles { get; set; }
    }
}
