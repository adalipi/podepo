using Database.Entities;
using Database.IRepositories;
using Logic.IServices;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace Logic.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ILogger<CategoryService> _log;
        private readonly ICategoryRepository _categoryRepository;

        public CategoryService(ILogger<CategoryService> log, ICategoryRepository categoryRepository)
        {
            _log = log;
            _categoryRepository = categoryRepository;
        }

        public async Task<Category> GetByName(string name)
        {
            return await _categoryRepository.GetByName(name).ConfigureAwait(false);
        }

        public async Task<Category> GetById(int id)
        {
            return await _categoryRepository.GetById(id).ConfigureAwait(false);
        }

        public async Task<IList<Category>> GetAllCategoriesWithArticles()
        {
            return await _categoryRepository.GetAll().Include(i => i.Articles).ToListAsync().ConfigureAwait(false);
        }
        
    }
}
