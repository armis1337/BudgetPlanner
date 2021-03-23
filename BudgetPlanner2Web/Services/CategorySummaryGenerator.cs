using BudgetPlanner2Web.GenericRepository;
using BudgetPlanner2Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BudgetPlanner2Web.Services
{
    public class CategorySummaryGenerator
    {
        private readonly IGenericRepository<Category> _categoryRepository;
        private readonly IExpenseRepository _expenseRepository;

        public CategorySummaryGenerator(IExpenseRepository expRepo, IGenericRepository<Category> catRepo)
        {
            _expenseRepository = expRepo;
            _categoryRepository = catRepo;
        }

        public async Task<IEnumerable<CategorySummary>> AllSummariesAsync()
        {
            // get all categories & expenses
            var myCategories = await _categoryRepository.GetAllAsync();
            var myExpenses = await _expenseRepository.GetAllAsync();

            // generate summaries
            List<CategorySummary> summaries = new List<CategorySummary>();

            foreach (var category in myCategories)
            {
                var thisMonth = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
                var summary = new CategorySummary
                {
                    Category = category,
                    TotalSpentAmount = myExpenses
                        .Where(x => x.CategoryId == category.Id)
                        .Select(x => x.Amount)
                        .Sum(),
                    TotalBoughtCount = myExpenses
                        .Where(x => x.CategoryId == category.Id)
                        .ToList()
                        .Count,
                    ThisMonthSpentAmount = myExpenses
                        .Where(x => x.CategoryId == category.Id)
                        .Where(x => x.Date >= thisMonth)
                        .Select(x => x.Amount)
                        .Sum(),
                    ThisMonthBoughtCount = myExpenses
                        .Where(x => x.CategoryId == category.Id)
                        .Where(x => x.Date >= thisMonth)
                        .ToList()
                        .Count
                };
                summaries.Add(summary);
            }
            return summaries;
        }

        public async Task<CategorySummary> GetSummaryByCategoryIdAsync(int id)
        {
            var category = await _categoryRepository.GetByIdAsync(id);
            if (category != null)
            {
                var expenses = await _expenseRepository.GetByCategoryIdAsync(id);

                var thisMonth = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
                CategorySummary summary = new CategorySummary
                {
                    Category = category,
                    TotalSpentAmount = expenses
                            .Select(x => x.Amount)
                            .Sum(),
                    TotalBoughtCount = expenses
                            .ToList()
                            .Count,
                    ThisMonthSpentAmount = expenses
                            .Where(x => x.Date >= thisMonth)
                            .Select(x => x.Amount)
                            .Sum(),
                    ThisMonthBoughtCount = expenses
                            .Where(x => x.Date >= thisMonth)
                            .ToList()
                            .Count
                };
                return summary;
            }
            return null;
        }
    }
}
