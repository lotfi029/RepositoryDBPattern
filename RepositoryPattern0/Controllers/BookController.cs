using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WOU.Core.Interfaces;
using WOU.Core.Models;

namespace RepositoryPattern0.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IUnitOfWork repository;

        public BookController(IUnitOfWork repository)
        {
            this.repository = repository;
        }
        //[HttpGet]
        //public IActionResult GetAll()
        //{
        //    return Ok(repository.Books.GetAll());
        //}
    }
}
