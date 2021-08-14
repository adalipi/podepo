using Database.Entities;
using System.Linq;
using System.Threading.Tasks;

namespace Database.IRepositories
{
    public interface IArticleRepository
    {
        void AddOrUpdate(Article entity);
        Task<Article> GetById(int id);
        void Delete(Article entity);
        Task Save();

        IQueryable<Article> GetAll();
        Task<Article> GetByName(string name);
    }
}
