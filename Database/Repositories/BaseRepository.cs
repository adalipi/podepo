using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace Database.Repositories
{
    public abstract class BaseRepository<T> where T: class
    {
        protected readonly DbSet<T> dbSet;
        protected readonly PodepoContext _context;

        public BaseRepository(PodepoContext dbContext)
        {
            _context = dbContext;
            dbSet = _context.Set<T>();
        }

        public void AddOrUpdate(T entity)
        {
            dbSet.Update(entity);
        }

        public void Delete(T entity)
        {
            dbSet.Remove(entity);
        }

        public async Task Save()
        {
            await _context.SaveChangesAsync().ConfigureAwait(false);
        }

        public async Task<T> GetById(int id)
        {
            return await dbSet.FindAsync(id).ConfigureAwait(false);
        }

    }
}
