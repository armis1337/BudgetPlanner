using BudgetPlanner2Web.GenericRepository;
using BudgetPlanner2Web.Models;
using BudgetPlanner2Web.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BudgetPlanner2Web.Services
{
    public interface ICategoryRepository : IGenericRepository<Category>
    {
        Task<BaseListViewModel<CategorySummary>> GetAllAsync(string sortBy, int? page);
    }
}
