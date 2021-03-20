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
            var rez = await _categoryRepository.GetAll(sortBy, page);

            return View(rez);
        }

        // GET: Categories/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var category = await _categoryRepository.GetById(id.Value);

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
        public async Task<IActionResult> Create([Bind("Id,Name,Description,Budget")] Category category)
        {
            if (ModelState.IsValid)
            {
                _categoryRepository.Add(category);
                await _categoryRepository.Save();
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

            var category = await _categoryRepository.GetById(id.Value);

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
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Description,Budget")] Category category)
        {
            if (id != category.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                await _categoryRepository.Update(category);
                await _categoryRepository.Save();
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

            var category = await _categoryRepository.GetById(id.Value);

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
            await _categoryRepository.Delete(id);
            await _categoryRepository.Save();
            return RedirectToAction(nameof(Index));
        }
    }
}
