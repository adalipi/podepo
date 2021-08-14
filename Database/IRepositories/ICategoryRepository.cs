using Database.Entities;
using System.Linq;
using System.Threading.Tasks;

namespace Database.IRepositories
{
    public interface ICategoryRepository
    {
        IQueryable<Category> GetAll();
        void AddOrUpdate(Category entity);
        Task<Category> GetById(int id);
        void Delete(Category entity);
        Task Save();

        Task<Category> GetByName(string name);
        
    }
}
