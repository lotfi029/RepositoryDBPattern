using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WOU.Core.DTO;
using WOU.Core.Models;

namespace WOU.Core.Interfaces
{
    public interface IAuthorRepository : IBaseRepository<Author>
    {
        IEnumerable<AuthorDTO> GetAllByName(string name);
        IEnumerable<AuthorDTO> GetAll();
        AuthorDTO GetById(int id);
        AuthorWithArticlesDTO GetAuthorWithArticles(int id);
        AuthorWithArticlesDTO GetAuthorWithArticles(string name);
        AuthorWithBookAndArticlesDTO GetAuthorWithBooksAndArticles(int id);
        AuthorWithBookAndArticlesDTO GetAuthorWithBooksAndArticles(string name);
        AuthorWithBooksDTO GetAuthorWithBooks(int id);
        AuthorWithBooksDTO GetAuthorWithBooks(string name);
    }
}
