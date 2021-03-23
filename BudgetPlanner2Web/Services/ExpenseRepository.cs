using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BudgetPlanner2Web.Data;
using BudgetPlanner2Web.GenericRepository;
using BudgetPlanner2Web.Models;
using BudgetPlanner2Web.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace BudgetPlanner2Web.Services
{
    public class ExpenseRepository : GenericRepository<Expense>, IExpenseRepository
    {
        private readonly IGenericRepository<Category> _categoryRepository;

        public ExpenseRepository(AppDbContext context, IHttpContextAccessor http, IGenericRepository<Category> catRepo) : base(context, http)
        {
            _categoryRepository = catRepo;
        }

        public override async Task<bool> UpdateAsync(Expense obj)
        {
            //var myCategories = await _categoryRepository.GetAllAsync();
            //if (myCategories.Any(x => x.Id == obj.CategoryId))
            if (await _categoryRepository.ObjectExistsAsync(obj.CategoryId))
            {
                return await base.UpdateAsync(obj);
            }
            return false;
        }

        public override async Task<Expense> AddAsync(Expense obj, string userID = null)
        {
            if(await _categoryRepository.ObjectExistsAsync(obj.CategoryId))
            {
                return await base.AddAsync(obj, userID);
            }
            return null;
        }

        public async Task<IEnumerable<Expense>> GetByCategoryIdAsync(int id)
        {
            return await table
                .Where(x => x.ApplicationUserId == GetCurrentUserId())
                .Where(x => x.CategoryId == id)
                .ToListAsync();
        }

        public async Task<ExpensesListViewModel> GetAllAsync(int? catId, int? page, string sortBy="")
        {
            var viewModel = new ExpensesListViewModel();
            var categories = await _categoryRepository.GetAllAsync();
            categories = categories.Prepend(new Category { Id = 0, Name = "All categories" });

            IQueryable<Expense> list = table
                .Where(x => x.ApplicationUserId == GetCurrentUserId());

            if (catId != null && catId != 0)
            {
                list = list
                    .Where(x => x.CategoryId == catId.Value);

                viewModel.CurrentCategory = await _categoryRepository.GetByIdAsync(catId.Value);
            }
            else
            {
                viewModel.CurrentCategory = categories.ElementAt(0);
            }

            viewModel.CategoriesSelectList = new SelectList(categories, "Id", "Name", viewModel.CurrentCategory.Id);

            viewModel.SortOrder = new Dictionary<string, string>() { 
                { "category", "categorydesc" }, { "amount", "amountdesc" }, { "date", "datedesc" } 
            };

            viewModel.CurrentSort = sortBy;
            switch (sortBy)
            {
                case "categorydesc":
                    list = list.OrderByDescending(x => x.Category.Name);
                    viewModel.SortOrder["category"] = "categoryasc";
                    break;
                case "categoryasc":
                    list = list.OrderBy(x => x.Category.Name);
                    viewModel.SortOrder["category"] = "categorydesc";
                    break;
                case "amountdesc":
                    list = list.OrderByDescending(x => x.Amount);
                    viewModel.SortOrder["amount"] = "amountasc";
                    break;
                case "amountasc":
                    list = list.OrderBy(x => x.Amount);
                    viewModel.SortOrder["amount"] = "amountdesc";
                    break;
                case "datedesc":
                    list = list.OrderByDescending(x => x.Date);
                    viewModel.SortOrder["date"] = "dateasc";
                    break;
                case "dateasc":
                    list = list.OrderBy(x => x.Date);
                    viewModel.SortOrder["date"] = "datedesc";
                    break;
                default:
                    viewModel.CurrentSort = "";
                    break;
            }

            viewModel.Items = await PaginatedList<Expense>.CreateAsync(list, page ?? 1);
            return viewModel;
        }
    }
}
