using WOU.Core.DTO;
using WOU.Core.Interfaces;
using WOU.Core.Models;

namespace WOU.EF.Repositories
{
    public class BookRepository : BaseRepository<Book>, IBookRepository
    {
        private readonly ApplicationDbContext _context;
        public BookRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }

        public IEnumerable<BookDTO> GetAll()
        {
            List<BookDTO> bookDTOs = new();
            var item = _context.Books;
            foreach(var i in item)
            {
                BookDTO temp = new() { 
                    Id = i.Id, 
                    Name = i.Name, 
                    RealseDate = i.RealseDate
                };
                bookDTOs.Add(temp);
            }
            return bookDTOs;
        }

        public IEnumerable<BookDTO> GetAllByName(string name)
        {
            List<BookDTO> bookDTOs = new();
            var item = _context.Books.Where(e=>e.Name == name);
            foreach (var i in item)
            {
                BookDTO temp = new()
                {
                    Id = i.Id,
                    Name = i.Name,
                    RealseDate = i.RealseDate
                };
                bookDTOs.Add(temp);
            }
            return bookDTOs;
        }

        public BookDTO GetById(int id)
        {
            var item = _context.Books.SingleOrDefault(e => e.Id == id);
            BookDTO bookDTO = new()
            {
                Id = item.Id,
                Name = item.Name,
                RealseDate = item.RealseDate
            };
            return bookDTO;
        }
    }
}
