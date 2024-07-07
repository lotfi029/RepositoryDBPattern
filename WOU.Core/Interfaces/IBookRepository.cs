using WOU.Core.DTO;
using WOU.Core.Models;

namespace WOU.Core.Interfaces
{
    public interface IBookRepository : IBaseRepository<Book>
    {
        IEnumerable<BookDTO> GetAllByName(string name);
        IEnumerable<BookDTO> GetAll();
        BookDTO GetById(int id);
    }
}
