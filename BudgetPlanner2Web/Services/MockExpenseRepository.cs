using BudgetPlanner2Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BudgetPlanner2Web.Services
{
    public class MockExpenseRepository : IExpenseRepository
    {
        public IEnumerable<Expense> AllExpenses =>
            new List<Expense>
            {
                new Expense {ExpenseId = 1, Amount = 3.80m, CategoryId = 1, Comment = "kebabas su cesnakiniu", Date = DateTime.Now },
                new Expense {ExpenseId = 2, Amount = 4.10m, CategoryId = 1, Comment = "camel blue", Date = DateTime.Now },
                new Expense {ExpenseId = 4, Amount = 50m, CategoryId = 3, Comment = "spark bauda", Date = DateTime.Now }
            };

        public Expense GetExpenseById(int id)
        {
            return AllExpenses
                .FirstOrDefault(x => x.ExpenseId == id);
        }

        Task<Expense> IExpenseRepository.AddExpense(Expense expense)
        {
            throw new NotImplementedException();
        }

        Task IExpenseRepository.DeleteExpense(int id)
        {
            throw new NotImplementedException();
        }

        Task<Expense> IExpenseRepository.GetExpenseById(int id)
        {
            throw new NotImplementedException();
        }

        Task<Expense> IExpenseRepository.UpdateExpense(Expense expense)
        {
            throw new NotImplementedException();
        }
    }
}
