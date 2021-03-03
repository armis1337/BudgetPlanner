using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BudgetPlanner2Web.Models;
using BudgetPlanner2Web.Services;
using BudgetPlanner2Web.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;

namespace BudgetPlanner2Web.Controllers
{
    [Authorize]
    public class ExpensesController : Controller
    {
        private readonly IExpenseRepository _expenseRepository;
        private readonly ICategoryRepository _categoryRepository;

        public ExpensesController(IExpenseRepository expenseRepo, ICategoryRepository catRepo)
        {
            _expenseRepository = expenseRepo;
            _categoryRepository = catRepo;
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ViewResult> Index(int CategoryId)
        {
            return await Index(CategoryId, "");
        }

        // GET: Expenses
        public async Task<ViewResult> Index(int id, string sortBy)// id - category name
        {
            var model = new ExpensesListViewModel();
            var categories = _categoryRepository.AllCategories.ToList();
            var category = await _categoryRepository.GetCategoryById(id);

            if (category == null)
            {
                model.Expenses = _expenseRepository.AllExpenses.ToList();
                model.CurrentCategory = new Category { CategoryId = 0, Name = "All categories" };

                categories.Insert(0, model.CurrentCategory);
                model.CategoriesSelectList = new SelectList(categories, "CategoryId", "Name", 0);
            }
            else
            {
                model.Expenses = _expenseRepository.AllExpenses
                    .Where(x => x.CategoryId == category.CategoryId)
                    .ToList();

                model.CurrentCategory = category;

                categories.Insert(0, new Category { CategoryId = 0, Name = "All categories" });
                model.CategoriesSelectList = new SelectList(categories, "CategoryId", "Name", model.CurrentCategory.CategoryId);
            }

            ViewBag.CategoryOrder = "categorydesc";
            ViewBag.AmountOrder = "amountdesc";
            ViewBag.DateOrder = "date";

            switch (sortBy)
            {
                case "categorydesc":
                    model.Expenses = model.Expenses.OrderByDescending(x => x.Category.Name).ToList();
                    ViewBag.CategoryOrder = "category";
                    break;
                case "category":
                    model.Expenses = model.Expenses.OrderBy(x => x.Category.Name).ToList();
                    ViewBag.CategoryOrder = "categorydesc";
                    break;
                case "amountdesc":
                    model.Expenses = model.Expenses.OrderByDescending(x => x.Amount).ToList();
                    ViewBag.AmountOrder = "amount";
                    break;
                case "amount":
                    model.Expenses = model.Expenses.OrderBy(x => x.Amount).ToList();
                    ViewBag.AmountOrder = "amountdesc";
                    break;
                case "datedesc":
                    model.Expenses = model.Expenses.OrderByDescending(x => x.Date).ToList();
                    ViewBag.DateOrder = "date";
                    break;
                case "date":
                    model.Expenses = model.Expenses.OrderBy(x => x.Date).ToList();
                    ViewBag.DateOrder = "datedesc";
                    break;
                default:
                    break;
            }

            return View(model);
        }

        // GET: Expenses/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var expense = await _expenseRepository.GetExpenseById(id.Value);

            if (expense == null)
            {
                return NotFound();
            }

            return View(expense);
        }

        // GET: Expenses/Create
        public IActionResult Create()
        {
            var categories = _categoryRepository.AllCategories;
            if (!categories.Any())
            {
                categories = new List<Category> { 
                    new Category
                    {
                        CategoryId = -1,
                        Name = "-"
                    } 
                };
            }

            ViewData["CategoryId"] = new SelectList(categories, "CategoryId", "Name");
            return View();
        }

        // POST: Expenses/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ExpenseId,Amount,Date,Comment,CategoryId")] Expense expense)
        {
            if (ModelState.IsValid)
            {
                await _expenseRepository.AddExpense(expense);
                return RedirectToAction(nameof(Index));
            }
            ViewData["CategoryId"] = new SelectList(_categoryRepository.AllCategories, "CategoryId", "Name", expense.CategoryId);
            return View(expense);
        }

        // GET: Expenses/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var expense = await _expenseRepository.GetExpenseById(id.Value);

            if (expense == null)
            {
                return NotFound();
            }
            ViewData["CategoryId"] = new SelectList(_categoryRepository.AllCategories, "CategoryId", "Name", expense.CategoryId);
            return View(expense);
        }

        // POST: Expenses/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ExpenseId,Amount,Date,Comment,CategoryId")] Expense expense)
        {
            if (id != expense.ExpenseId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                await _expenseRepository.UpdateExpense(expense);
                return RedirectToAction(nameof(Index));
            }
            ViewData["CategoryId"] = new SelectList(_categoryRepository.AllCategories, "CategoryId", "Name", expense.CategoryId);
            return View(expense);
        }

        // GET: Expenses/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var expense = await _expenseRepository.GetExpenseById(id.Value);

            if (expense == null)
            {
                return NotFound();
            }

            return View(expense);
        }

        // POST: Expenses/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await _expenseRepository.DeleteExpense(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
