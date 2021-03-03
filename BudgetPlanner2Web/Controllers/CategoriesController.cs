using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BudgetPlanner2Web.Data;
using BudgetPlanner2Web.Models;
using BudgetPlanner2Web.Services;
using BudgetPlanner2Web.ViewModels;
using Microsoft.AspNetCore.Authorization;

namespace BudgetPlanner2Web
{
    [Authorize]
    public class CategoriesController : Controller
    {
        private readonly AppDbContext _context;
        private readonly ICategoryRepository _categoryRepository;
        private readonly CategorySummaryGenerator _summaryGenerator;

        public CategoriesController(AppDbContext context, ICategoryRepository catRepo, CategorySummaryGenerator generator)
        {
            _context = context;
            _categoryRepository = catRepo;
            _summaryGenerator = generator;
        }

        // GET: Categories
        public IActionResult Index(string sortBy)
        {
            ViewBag.NameOrder = "namedesc";
            ViewBag.BudgetOrder = "budgetdesc";
            switch (sortBy)
            {
                case "namedesc":
                    ViewBag.NameOrder = "name";
                    return View(_summaryGenerator.AllSummaries.OrderByDescending(x => x.Category.Name));
                case "name":
                    ViewBag.NameOrder = "namedesc";
                    return View(_summaryGenerator.AllSummaries.OrderBy(x => x.Category.Name));
                case "budgetdesc":
                    ViewBag.BudgetOrder = "budget";
                    return View(_summaryGenerator.AllSummaries.OrderByDescending(x => x.ThisMonthSpentAmount));
                case "budget":
                    ViewBag.BudgetOrder = "budgetdesc";
                    return View(_summaryGenerator.AllSummaries.OrderBy(x => x.ThisMonthSpentAmount));
                default:
                    return View(_summaryGenerator.AllSummaries);
            }
        }

        // GET: Categories/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var category = await _categoryRepository.GetCategoryById(id.Value);

            if (category == null)
            {
                return NotFound();
            }

            return View(await _summaryGenerator.GetSummaryByCategoryId(id.Value));
        }

        // GET: Categories/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Categories/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CategoryId,Name,Description,Budget")] Category category)
        {
            if (ModelState.IsValid)
            {
                await _categoryRepository.AddCategory(category);
                return RedirectToAction(nameof(Index));
            }
            return View(category);
        }

        // GET: Categories/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            //var category = await _context.Categories.FindAsync(id);
            var category = await _categoryRepository.GetCategoryById(id.Value);

            if (category == null)
            {
                return NotFound();
            }
            return View(category);
        }

        // POST: Categories/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CategoryId,Name,Description,Budget")] Category category)
        {
            if (id != category.CategoryId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                await _categoryRepository.UpdateCategory(category);
                return RedirectToAction(nameof(Index));
            }
            return View(category);
        }

        // GET: Categories/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var category = await _categoryRepository.GetCategoryById(id.Value);

            if (category == null)
            {
                return NotFound();
            }

            return View(category);
        }

        // POST: Categories/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await _categoryRepository.DeleteCategory(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
