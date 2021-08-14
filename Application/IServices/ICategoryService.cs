using Database.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Logic.IServices
{
    public interface ICategoryService
    {
        Task<IList<Category>> GetAllCategoriesWithArticles();
        Task<Category> GetByName(string name);
        Task<Category> GetById(int id);
    }
}
