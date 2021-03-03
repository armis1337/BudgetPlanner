using BudgetPlanner2Web.Data;
using BudgetPlanner2Web.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace BudgetPlanner2Web.Services
{
    public class ExpenseRepository : IExpenseRepository
    {
        private readonly AppDbContext _context;
        private readonly HttpContext _httpContext;
        private readonly UserManager<ApplicationUser> _userManager;
        public ExpenseRepository(AppDbContext context, IHttpContextAccessor contextAccessor, UserManager<ApplicationUser> mngr)
        {
            _context = context;
            _httpContext = contextAccessor.HttpContext;
            _userManager = mngr;
        }

        public IEnumerable<Expense> AllExpenses
        {
            get
            {
                return _context.Expenses
                    .Include(x => x.Category)
                    .Include(x => x.ApplicationUser)
                    .Where(x => x.ApplicationUser.Id == GetCurrentUserId())
                    .OrderByDescending(x => x.Date)
                    .ToList();
            }
        }

        public async Task<Expense> GetExpenseById(int id)
        {
            return await _context.Expenses
                .Where(x => x.ExpenseId == id)
                .Include(x => x.Category)
                .Include(x => x.ApplicationUser)
                .FirstOrDefaultAsync(x => x.ApplicationUser.Id == GetCurrentUserId());
        }

        public async Task<Expense> AddExpense(Expense expense)
        {
            expense.ApplicationUser = await _userManager.GetUserAsync(_httpContext.User);
            _context.Expenses.Add(expense);
            await _context.SaveChangesAsync();
            return expense;
        }
         
        public async Task<Expense> UpdateExpense(Expense expense)
        {
            var tmpExpense = await GetExpenseById(expense.ExpenseId);
            if(tmpExpense.ApplicationUser.Id == GetCurrentUserId())
            {
                tmpExpense.Update(expense);
                _context.Update(tmpExpense);
                await _context.SaveChangesAsync();
                return tmpExpense;
            }
            else
                return null;
        }

        public async Task DeleteExpense(int id)
        {
            var expense = await GetExpenseById(id);
            if (expense.ApplicationUser.Id == GetCurrentUserId())
            {
                _context.Remove(expense);
                await _context.SaveChangesAsync();
            }
        }

        private string GetCurrentUserId()
        {
            var claimsIdentity = (ClaimsIdentity)_httpContext.User.Identity;
            var claim = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier);
            return claim.Value;
        }
    }
}
