using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using BudgetPlanner2Web.Models;
using BudgetPlanner2Web.Services;
using Microsoft.AspNetCore.Authorization;

namespace BudgetPlanner2Web.Controllers
{
    [Authorize]
    public class ExpensesController : Controller
    {
        private readonly IExpenseRepository _expenseRepository;
        private readonly ICategoryRepository _categoryRepository;

        public ExpensesController(IExpenseRepository expRepo, ICategoryRepository catRepo)
        {
            _expenseRepository = expRepo;
            _categoryRepository = catRepo;
        }

        // POST: Expenses
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(int CategoryId)
        {
            var routeValues = new Dictionary<string, string> { { "id", CategoryId.ToString() } };
            return RedirectToAction(nameof(Index), routeValues);
        }

        // GET: Expenses
        public async Task<ViewResult> Index(int id, string sortBy, int? page)
        {
            return View(await _expenseRepository.GetAll(id, sortBy, page));
        }

        // GET: Expenses/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var expense = await _expenseRepository.GetById(id.Value);
            if (expense == null)
            {
                return NotFound();
            }

            return View(expense);
        }

        // GET: Expenses/Create
        public async Task<IActionResult> Create()
        {
            var categories = await _categoryRepository.GetAll();
            if (!categories.Any())
            {
                categories = new List<Category> { 
                    new Category
                    {
                        Id = -1,
                        Name = "-"
                    } 
                };
            }

            ViewData["CategoryId"] = new SelectList(categories, "Id", "Name");
            return View();
        }

        // POST: Expenses/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Amount,Date,Comment,CategoryId")] Expense expense)
        {
            if (ModelState.IsValid && _expenseRepository.Add(expense))
            {
                await _expenseRepository.Save();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CategoryId"] = new SelectList(await _categoryRepository.GetAll(), "Id", "Name", expense.CategoryId);
            return View(expense);
        }

        // GET: Expenses/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var expense = await _expenseRepository.GetById(id.Value);

            if (expense == null)
            {
                return NotFound();
            }
            ViewData["CategoryId"] = new SelectList(await _categoryRepository.GetAll(), "Id", "Name", expense.CategoryId);
            return View(expense);
        }

        // POST: Expenses/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Amount,Date,Comment,CategoryId")] Expense expense)
        {
            if (id != expense.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid && await _expenseRepository.Update(expense))
            {
                await _expenseRepository.Save();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CategoryId"] = new SelectList(await _categoryRepository.GetAll(), "Id", "Name", expense.CategoryId);
            return View(expense);
        }

        // GET: Expenses/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var expense = await _expenseRepository.GetById(id.Value);

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
            await _expenseRepository.Delete(id);
            await _expenseRepository.Save();
            return RedirectToAction(nameof(Index));
        }
    }
}
