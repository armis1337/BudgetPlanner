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

        public override async Task<bool> Update(Expense obj)
        {
            var myCategories = await _categoryRepository.GetAll();

            if (myCategories.Any(x => x.Id == obj.CategoryId))
            {
                return await base.Update(obj);
            }
            return false;
        }

        public override bool Add(Expense obj)
        {
            var myCategories = _categoryRepository.GetAll().Result;
            if (myCategories.Any(x => x.Id == obj.CategoryId))
            {
                return base.Add(obj);
            }
            return false;
        }

        public async Task<IEnumerable<Expense>> GetByCategoryId(int id)
        {
            return await table
                .Where(x => x.ApplicationUserId == GetCurrentUserId())
                .Where(x => x.CategoryId == id)
                .ToListAsync();
        }

        public async Task<ExpensesListViewModel> GetAll(int? catId, string sortBy, int? page)
        {

            var viewModel = new ExpensesListViewModel();
            var categories = await _categoryRepository.GetAll();
            categories = categories.Prepend(new Category { Id = 0, Name = "All categories" });

            IQueryable<Expense> list = table
                .Where(x => x.ApplicationUserId == GetCurrentUserId());

            if (catId != null && catId != 0)
            {
                //list = await GetByCategoryId(catId.Value); // old
                list = list
                    .Where(x => x.CategoryId == catId.Value);

                viewModel.CurrentCategory = await _categoryRepository.GetById(catId.Value);
            }
            else
            {
                //list = await GetAll(); // old
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

            viewModel.Items = await PaginatedList<Expense>.Create(list, page ?? 1);
            return viewModel;
        }
    }
}
