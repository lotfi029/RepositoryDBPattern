using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WOU.Core.DTO;
using WOU.Core.Interfaces;
using WOU.Core.Models;

namespace WOU.EF.Repositories
{
    public class AuthorRepository : BaseRepository<Author>, IAuthorRepository
    {
        private readonly ApplicationDbContext _context;
        public AuthorRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }

        public IEnumerable<AuthorDTO> GetAllByName(string name)
        {
            var items = _context.Authors.Where(e => e.Name == name);
            List<AuthorDTO> authorDTOs = new();
            foreach (var item in items)
            {
                AuthorDTO authorDTO = new()
                {
                    Id = item.Id,
                    Name = item.Name,
                    Lastseen = item.LastSeen
                };
                authorDTOs.Add(authorDTO);
            }
            return authorDTOs;
        }

        public IEnumerable<AuthorDTO> GetAll()
        {
            var items = _context.Authors;
            List<AuthorDTO> authorDTOs = new();
            foreach (var item in items)
            {
                AuthorDTO authorDTO = new()
                {
                    Id = item.Id,
                    Name = item.Name,
                    Lastseen = item.LastSeen
                };
                authorDTOs.Add(authorDTO);
            }
            return authorDTOs;
        }

        public AuthorDTO GetById(int id)
        {
            Author author = _context.Authors.SingleOrDefault(e => e.Id == id);
            AuthorDTO authorDto = new()
            {
                Id = author.Id,
                Name = author.Name,
                Lastseen = author.LastSeen
            };
            return authorDto;
        }

        public AuthorWithArticlesDTO GetAuthorWithArticles(int id)
        {
            Author author = _context.Authors.Include(e => e.Articles).SingleOrDefault(p => p.Id == id);
            List<ArticleDTO> articles = new List<ArticleDTO>();
            foreach (var i in author.Articles)
            {
                ArticleDTO article = new()
                {
                    Id = i.Id,
                    Name = i.Title,
                    RealseDate = i.RealseDate
                };
                articles.Add(article);
            }
            AuthorWithArticlesDTO authorWithArticles = new()
            {
                authorDTO = new AuthorDTO()
                {
                    Id = author.Id,
                    Name = author.Name,
                    Lastseen = author.LastSeen
                },
                Articles = articles
            };
            return authorWithArticles;
        }

        public AuthorWithArticlesDTO GetAuthorWithArticles(string name)
        {
            Author author = _context.Authors.Include(e => e.Articles).FirstOrDefault(p => p.Name == name);
            List<ArticleDTO> articles = new List<ArticleDTO>();
            foreach (var i in author.Articles)
            {
                ArticleDTO article = new()
                {
                    Id = i.Id,
                    Name = i.Title,
                    RealseDate = i.RealseDate
                };
                articles.Add(article);
            }
            AuthorWithArticlesDTO authorWithArticles = new()
            {
                authorDTO = new AuthorDTO()
                {
                    Id = author.Id,
                    Name = author.Name,
                    Lastseen = author.LastSeen
                },
                Articles = articles
            };
            return authorWithArticles;
        }

        public AuthorWithBookAndArticlesDTO GetAuthorWithBooksAndArticles(int id)
        {
            Author author = _context.Authors.Include(e => e.Books).Include(e => e.Articles).SingleOrDefault(e => e.Id == id);
            List<ArticleDTO> articles = new();
            List<BookDTO> books = new();
            foreach (var i in author.Articles)
            {
                ArticleDTO article = new()
                {
                    Id = i.Id,
                    Name = i.Title,
                    RealseDate = i.RealseDate
                };
                articles.Add(article);
            }
            foreach (var i in author.Books)
            {
                BookDTO book = new()
                {
                    Id = i.Id,
                    Name = i.Name,
                    RealseDate = i.RealseDate
                };
                books.Add(book);
            }


            AuthorWithBookAndArticlesDTO authorWithBookAndArticles = new()
            {
                author = new()
                {
                    Id = author.Id,
                    Name = author.Name,
                    Lastseen = author.LastSeen
                },
                bookAndArticlesDTO = new BookAndArticlesDTO()
                {
                    Books = books,
                    Articles = articles
                }
            };
            return authorWithBookAndArticles;
        }

        public AuthorWithBookAndArticlesDTO GetAuthorWithBooksAndArticles(string name)
        {
            Author author = _context.Authors.Include(e => e.Books).Include(e => e.Articles).FirstOrDefault(e => e.Name == name);
            List<ArticleDTO> articles = new();
            List<BookDTO> books = new();
            foreach (var i in author.Articles)
            {
                ArticleDTO article = new()
                {
                    Id = i.Id,
                    Name = i.Title,
                    RealseDate = i.RealseDate
                };
                articles.Add(article);
            }
            foreach (var i in author.Books)
            {
                BookDTO book = new()
                {
                    Id = i.Id,
                    Name = i.Name,
                    RealseDate = i.RealseDate
                };
                books.Add(book);
            }


            AuthorWithBookAndArticlesDTO authorWithBookAndArticles = new()
            {
                author = new()
                {
                    Id = author.Id,
                    Name = author.Name,
                    Lastseen = author.LastSeen
                },
                bookAndArticlesDTO = new BookAndArticlesDTO()
                {
                    Books = books,
                    Articles = articles
                }
            };
            return authorWithBookAndArticles;
        }

        public AuthorWithBooksDTO GetAuthorWithBooks(int id)
        {
            //try
            //{
            Author author = _context.Authors.Include(e => e.Books).SingleOrDefault(e => e.Id == id);
            List<BookDTO> books = new();
            foreach (var i in author.Books)
            {
                BookDTO book = new()
                {
                    Id = i.Id,
                    Name = i.Name,
                    RealseDate = author.LastSeen
                };
                books.Add(book);
            }
            AuthorWithBooksDTO? ans = new AuthorWithBooksDTO()
            {
                authorDTO = new()
                {
                    Id = author.Id,
                    Name = author.Name,
                    Lastseen = author.LastSeen
                },
                Books = books

            };
            return ans;
            //} catch
            //{
            //    return new AuthorWithBooksDTO();
            //}

            //}
        }

        public AuthorWithBooksDTO GetAuthorWithBooks(string name)
        {
            Author author = _context.Authors.Include(e => e.Books).FirstOrDefault(e => e.Name.Contains(name));
            List<BookDTO> books = new();
            foreach (var i in author.Books)
            {
                BookDTO book = new()
                {
                    Id = i.Id,
                    Name = i.Name,
                    RealseDate = author.LastSeen
                };
                books.Add(book);
            }
            AuthorWithBooksDTO ans = new AuthorWithBooksDTO()
            {
                authorDTO = new()
                {
                    Id = author.Id,
                    Name = author.Name,
                    Lastseen = author.LastSeen
                },
                Books = books

            };
            return ans;
        }
    }
}

