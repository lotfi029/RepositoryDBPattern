using WOU.Core.DTO;
using WOU.Core.Interfaces;
using WOU.Core.Models;

namespace WOU.EF.Repositories
{
    public class ArticleRepository : BaseRepository<Article>, IArticleRepository
    {
        private readonly ApplicationDbContext _context;
        public ArticleRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }

        public IEnumerable<ArticleDTO> GetAll()
        {
            List<ArticleDTO> articleDTOs = new();
            var items = _context.Articles;
            foreach(var item in items)
            {
                ArticleDTO temp = new()
                {
                    Id = item.Id,
                    Name = item.Title,
                    RealseDate = item.RealseDate
                };
                articleDTOs.Add(temp);
            }
            return articleDTOs;
        }

        public IEnumerable<ArticleDTO> GetAllByName(string name)
        {
            List<ArticleDTO> articleDTOs = new();
            var items = _context.Articles.Where(e=>e.Title == name);
            foreach (var item in items)
            {
                ArticleDTO temp = new()
                {
                    Id = item.Id,
                    Name = item.Title,
                    RealseDate = item.RealseDate
                };
                articleDTOs.Add(temp);
            }
            return articleDTOs;
        }

        public ArticleDTO GetById(int id)
        {
            var item = _context.Articles.SingleOrDefault(e=>e.Id == id);
            ArticleDTO articleDTO = new() 
            {
                Id = item.Id,
                Name = item.Title,
                RealseDate = item.RealseDate
            };
            return articleDTO; 
        }
    }
}
