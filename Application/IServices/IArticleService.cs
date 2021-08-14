using Database.Entities;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Logic.IServices
{
    public interface IArticleService
    {
        Task<IList<Article>> GetAllArticles();
        Task<Article> GetByName(string name);
        Task<Article> GetById(int id);
    }
}
