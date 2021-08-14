using Logic.IServices;
using Database.Entities;
using Database.IRepositories;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace Logic.Services
{
    public class ArticleService : IArticleService
    {
        private readonly ILogger<ArticleService> _log;
        private readonly IArticleRepository _articleRepository;

        public ArticleService(ILogger<ArticleService> log, IArticleRepository articleRepository)
        {
            _log = log;
            _articleRepository = articleRepository;
        }

        public async Task<IList<Article>> GetAllArticles()
        {
            return await _articleRepository.GetAll().Include(i => i.Category).Include(i => i.Amounts).ToListAsync().ConfigureAwait(false);
        }

        public async Task<Article> GetById(int id)
        {
            return await _articleRepository.GetById(id).ConfigureAwait(false);
        }

        public async Task<Article> GetByName(string name)
        {
            return await _articleRepository.GetByName(name).ConfigureAwait(false);
        }
    }
}
