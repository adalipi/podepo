using System;
using System.Linq;
using System.Threading.Tasks;
using Database.Entities;
using Database.IRepositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace Database.Repositories
{
    public class CategoryRepository : BaseRepository<Category>, ICategoryRepository
    {
        private readonly ILogger<CategoryRepository> _log;

        public CategoryRepository(ILogger<CategoryRepository> log, PodepoContext dbContext) : base(dbContext)
        {
            _log = log;
        }

        public IQueryable<Category> GetAll()
        {
            return _context.Categories.AsQueryable();
        }

        public async Task<Category> GetByName(string name)
        {
            return await _context.Categories.FirstOrDefaultAsync(f => f.Name == name).ConfigureAwait(false);
        }
    }
}
