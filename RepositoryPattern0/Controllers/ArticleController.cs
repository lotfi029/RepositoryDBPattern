using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WOU.Core.Interfaces;
using WOU.Core.Models;

namespace RepositoryPattern0.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArticleController : ControllerBase
    {
        private readonly IUnitOfWork repository;

        public ArticleController(IUnitOfWork repository)
        {
            this.repository = repository;
        }

        //[HttpGet]
        //public IActionResult GetAll()
        //{
        //    return Ok(repository.Articles.GetAll());
        //}
    }
}
