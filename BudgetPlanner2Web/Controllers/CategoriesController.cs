using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BudgetPlanner2Web.Models;
using BudgetPlanner2Web.Services;
using Microsoft.AspNetCore.Authorization;

namespace BudgetPlanner2Web
{
    [Authorize]
    public class CategoriesController : Controller
    {
        private readonly CategorySummaryGenerator _summaryGenerator;
        private readonly ICategoryRepository _categoryRepository;

        public CategoriesController(CategorySummaryGenerator generator, ICategoryRepository catRepo)
        {
            _summaryGenerator = generator;
            _categoryRepository = catRepo;
        }

        // GET: Categories
        public async Task<IActionResult> Index(string sortBy, int? page)
        {
            var rez = await _categoryRepository.GetAllAsync(sortBy, page);

            return View(rez);
        }

        // GET: Categories/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var category = await _categoryRepository.GetByIdAsync(id.Value);

            if (category == null)
            {
                return NotFound();
            }

            return View(await _summaryGenerator.GetSummaryByCategoryIdAsync(id.Value));
        }

        // GET: Categories/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Categories/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Name,Description,Budget")] Category category)
        {
            if (ModelState.IsValid && await _categoryRepository.AddAsync(category) != null)
            {
                await _categoryRepository.SaveAsync();
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

            var category = await _categoryRepository.GetByIdAsync(id.Value);

            if (category == null)
            {
                return NotFound();
            }
            return View(category);
        }

        // POST: Categories/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Name,Description,Budget")] Category category)
        {
            if (id != category.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid && await _categoryRepository.UpdateAsync(category))
            {
                await _categoryRepository.SaveAsync();
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

            var category = await _categoryRepository.GetByIdAsync(id.Value);

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
            if(await _categoryRepository.DeleteAsync(id))
            {
                await _categoryRepository.SaveAsync();
                return RedirectToAction(nameof(Index));
            }
            return RedirectToAction(nameof(Delete), id);
        }
    }
}
