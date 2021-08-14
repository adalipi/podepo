using System.Linq;
using System.Threading.Tasks;
using Database.Entities;
using Database.IRepositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace Database.Repositories
{
    public class ArticleRepository : BaseRepository<Article>, IArticleRepository
    {
        private readonly ILogger<ArticleRepository> _log;

        public ArticleRepository(ILogger<ArticleRepository> log, PodepoContext dbContext) : base(dbContext)
        {
            _log = log;
        }

        public async Task<Article> GetByName(string name)
        {
            return await _context.Articles.FirstOrDefaultAsync(f => f.Name == name).ConfigureAwait(false);
        }

        public IQueryable<Article> GetAll()
        {
            return _context.Articles.AsQueryable();
        }
    }
}
