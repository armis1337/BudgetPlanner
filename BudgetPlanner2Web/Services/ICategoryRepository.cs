using BudgetPlanner2Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BudgetPlanner2Web.Services
{
    public interface ICategoryRepository
    {
        public IEnumerable<Category> AllCategories { get; }
        public Task<bool> AddDefaultCategory(ApplicationUser user);
        public Task<Category> GetCategoryById(int id);
        public Task<Category> AddCategory(Category category);
        public Task<Category> UpdateCategory(Category category);
        public Task DeleteCategory(int id);
    }
}
