using BudgetPlanner2Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BudgetPlanner2Web.Services
{
    public class MockCategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> AllCategories =>
            new List<Category>
            {
                new Category { CategoryId = 1, Name = "Shopping", Description = "money spent on shopping" },
                new Category { CategoryId = 2, Name = "Fun", Description = "money spent on fun things ;)" },
                new Category { CategoryId = 3, Name = "Other", Description = "money spent on other stuff" }
            };

        Task<Category> ICategoryRepository.AddCategory(Category category)
        {
            throw new NotImplementedException();
        }

        Task<bool> ICategoryRepository.AddDefaultCategory(ApplicationUser user)
        {
            throw new NotImplementedException();
        }

        Task ICategoryRepository.DeleteCategory(int id)
        {
            throw new NotImplementedException();
        }

        Task<Category> ICategoryRepository.GetCategoryById(int id)
        {
            throw new NotImplementedException();
        }

        Task<Category> ICategoryRepository.UpdateCategory(Category category)
        {
            throw new NotImplementedException();
        }
    }
}
