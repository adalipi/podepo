using System;
using System.Collections.Generic;
using System.Linq;
using Logic.IServices;
using Database.Entities;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ILogger<CategoryController> _log;
        private readonly ICategoryService _categoryService;

        public CategoryController(ILogger<CategoryController> log, ICategoryService categoryService)
        {
            _log = log;
            _categoryService = categoryService;
        }

        [HttpGet]
        public async Task<IEnumerable<Category>> Category()
        {
            return await _categoryService.GetAllCategoriesWithArticles().ConfigureAwait(false);
        }
    }
}
