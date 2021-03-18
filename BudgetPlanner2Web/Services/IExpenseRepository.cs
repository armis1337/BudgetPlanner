using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BudgetPlanner2Web.GenericRepository;
using BudgetPlanner2Web.Models;
using BudgetPlanner2Web.ViewModels;

namespace BudgetPlanner2Web.Services
{
    public interface IExpenseRepository : IGenericRepository<Expense>
    {
        Task<IEnumerable<Expense>> GetByCategoryId(int id);
        Task<ExpensesListViewModel> GetAll(int? catId, string sortBy, int? page);
    }
}
