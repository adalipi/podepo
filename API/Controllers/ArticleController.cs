using Logic.IServices;
using Database.Entities;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Authorization;
using API.Identity;

namespace API.Controllers
{
    //[UserRole]
    [Route("[controller]")]
    [ApiController]
    public class ArticleController : ControllerBase
    {
        private readonly ILogger<ArticleController> _log;
        private readonly IArticleService _articleService;

        public ArticleController(ILogger<ArticleController> log, IArticleService articleService)
        {
            _log = log;
            _articleService = articleService;
        }

        //[ManagerRole]
        [HttpGet]
        public async Task<IEnumerable<Article>> Articles()
        {
            _log.LogInformation("Retriving all articles with category");
            return await _articleService.GetAllArticles().ConfigureAwait(false);
        }

        [HttpGet("{id:int}")]
        public async Task<Article> Article(int id)
        {
            _log.LogInformation($"Retriving article(id={id}) with category");
            return await _articleService.GetById(id).ConfigureAwait(false);
        }

        [HttpGet("{name}")]
        public async Task<Article> Article(string name)
        {
            _log.LogInformation($"Retriving article(name={name}) with category");
            return await _articleService.GetByName(name).ConfigureAwait(false);
        }
    }
}
