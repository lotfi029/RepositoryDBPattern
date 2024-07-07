using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WOU.Core.Interfaces;
using WOU.Core.Models;
using WOU.EF.Repositories;

namespace WOU.EF
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;

        public IAuthorRepository Authors { get; private set; }

        public IArticleRepository Articles { get; private set; }

        public IBookRepository Books { get; private set; }
        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
            Articles = new ArticleRepository(_context);
            Authors = new AuthorRepository(_context);
            Books = new BookRepository(_context);
        }
        public int complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
