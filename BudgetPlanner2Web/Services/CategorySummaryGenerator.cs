using BudgetPlanner2Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BudgetPlanner2Web.Services
{
    public class CategorySummaryGenerator
    {
        private readonly IExpenseRepository _expenseRepository;
        private readonly ICategoryRepository _categoryRepository;
        public CategorySummaryGenerator(IExpenseRepository expRepo, ICategoryRepository catRepo)
        {
            _expenseRepository = expRepo;
            _categoryRepository = catRepo;
        }

        public IEnumerable<CategorySummary> AllSummaries
        {
            get
            {
                // get all categories & expenses
                var myCategories = _categoryRepository.AllCategories;
                var myExpenses = _expenseRepository.AllExpenses;
                // generate summaries
                List<CategorySummary> summaries = new List<CategorySummary>();
                foreach (var category in myCategories)
                {
                    var thisMonth = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
                    var summary = new CategorySummary
                    {
                        Category = category,
                        TotalSpentAmount = myExpenses
                            .Where(x => x.CategoryId == category.CategoryId)
                            .Select(x => x.Amount)
                            .Sum(),
                        TotalBoughtCount = myExpenses
                            .Where(x => x.CategoryId == category.CategoryId)
                            .ToList()
                            .Count,
                        ThisMonthSpentAmount = myExpenses
                            .Where(x => x.CategoryId == category.CategoryId)
                            .Where(x => x.Date >= thisMonth)
                            .Select(x => x.Amount)
                            .Sum(),
                        ThisMonthBoughtCount = myExpenses
                            .Where(x => x.CategoryId == category.CategoryId)
                            .Where(x => x.Date >= thisMonth)
                            .ToList()
                            .Count
                    };
                    summaries.Add(summary);
                }
                return summaries;
            }
        }

        public async Task<CategorySummary> GetSummaryByCategoryId(int id)
        {
            var category = await _categoryRepository.GetCategoryById(id);
            if (category != null)
            {
                var expenses = _expenseRepository.AllExpenses
                    .Where(x => x.CategoryId == category.CategoryId)
                    .ToList();

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
