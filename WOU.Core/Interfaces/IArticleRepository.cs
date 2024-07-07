using WOU.Core.DTO;
using WOU.Core.Models;

namespace WOU.Core.Interfaces
{
    public interface IArticleRepository : IBaseRepository<Article>
    {
        IEnumerable<ArticleDTO> GetAllByName(string name);
        IEnumerable<ArticleDTO> GetAll();
        ArticleDTO GetById(int id);
    }
}
