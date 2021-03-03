using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BudgetPlanner2Web.Models;

namespace BudgetPlanner2Web.Services
{
    public interface IExpenseRepository
    {
        IEnumerable<Expense> AllExpenses { get; }
        Task<Expense> AddExpense(Expense expense);
        Task<Expense> UpdateExpense(Expense expense);
        Task DeleteExpense(int id);
        Task<Expense> GetExpenseById(int id);
    }
}
