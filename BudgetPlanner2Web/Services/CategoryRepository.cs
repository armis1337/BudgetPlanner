using BudgetPlanner2Web.Data;
using BudgetPlanner2Web.GenericRepository;
using BudgetPlanner2Web.Models;
using BudgetPlanner2Web.Models.DTO;
using BudgetPlanner2Web.ViewModels;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BudgetPlanner2Web.Services
{
    public class CategoryRepository : GenericRepository<Category>, ICategoryRepository
    {
        private readonly CategorySummaryGenerator _summaryGenerator;
        public CategoryRepository(AppDbContext context, IHttpContextAccessor http, CategorySummaryGenerator catGen) : base(context, http)
        {
            _summaryGenerator = catGen;
        }

        public async Task<BaseListViewModel<CategorySummary>> GetAllAsync(string sortBy, int? page)
        {
            IEnumerable<CategorySummary> list = await _summaryGenerator.AllSummariesAsync();
            var viewModel = new BaseListViewModel<CategorySummary>();

            viewModel.SortOrder = new Dictionary<string, string>() {
                { "name", "namedesc" }, { "budget", "budgetdesc" }
            };

            switch (sortBy)
            {
                case "namedesc":
                    list = list.OrderByDescending(x => x.Category.Name);
                    viewModel.SortOrder["name"] = "nameasc";
                    break;
                case "nameasc":
                    list = list.OrderBy(x => x.Category.Name);
                    viewModel.SortOrder["name"] = "namedesc";
                    break;
                case "budgetdesc":
                    list = list.OrderByDescending(x => x.ThisMonthSpentAmount);
                    viewModel.SortOrder["budget"] = "budgetasc";
                    break;
                case "budgetasc":
                    list = list.OrderBy(x => x.ThisMonthSpentAmount);
                    viewModel.SortOrder["budget"] = "budgetdesc";
                    break;
                default:
                    break;
            }

            viewModel.Items = PaginatedList<CategorySummary>.Create(list, page ?? 1);
            return viewModel;
        }
    }
}
