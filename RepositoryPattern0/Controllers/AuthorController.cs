using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WOU.Core.Interfaces;
using WOU.Core.Models;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace RepositoryPattern0.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorController : ControllerBase
    {
        private readonly IUnitOfWork repository;

        public AuthorController(IUnitOfWork repository) 
        {
            this.repository = repository;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(repository.Authors.GetAll());
        }
        [HttpGet("byId/{id}")]
        public IActionResult Get(int id)
        {
            return Ok(repository.Authors.GetById(id));
        }
        [HttpGet("byName/{name}")]
        public IActionResult Get(string name)
        {
            return Ok(repository.Authors.GetAllByName(name));
        }
        [HttpGet("AuthorWithArticlesAndBooksById/{id}")]
        public IActionResult GetByIdAuthorWithArticlesAndBooks(int id) 
        {
            return Ok(repository.Authors.GetAuthorWithBooksAndArticles(id));
        }
        [HttpGet("AuthorWithArticlesById/{id}")]
        public IActionResult GetByIdAuthorWithArticles(int id)
        {
            return Ok(repository.Authors.GetAuthorWithArticles(id));
        }
        [HttpGet("AuthorWithBooksById/{id}")]
        public IActionResult GetByIdAuthorWithBooks(int id)
        {
            
            try 
            {
                var query = repository.Authors.GetAuthorWithBooks(id);
                if (query == null)
                    return NotFound();
                return Ok(query);
            }
            catch (Exception ex) 
            {
                return BadRequest("not found");
            }
            
        }
        [HttpGet("AuthorWithArticlesAndBooksByName/{name}")]
        public IActionResult GetByNameAuthorWithArticlesAndBooks(string name) 
        {
            return Ok(repository.Authors.GetAuthorWithBooksAndArticles(name));
        }
        [HttpGet("AuthorWithArticlesByName/{name}")]
        public IActionResult GetByNameAuthorWithArticles(string name)
        {
            return Ok(repository.Authors.GetAuthorWithArticles(name));
        }
        [HttpGet("AuthorWithBooksByName/{name}")]
        public IActionResult GetByNameAuthorWithBooks(string name)
        {
            return Ok(repository.Authors.GetAuthorWithBooks(name));
        }

    }
}
