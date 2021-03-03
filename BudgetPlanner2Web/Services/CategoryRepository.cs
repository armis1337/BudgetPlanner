using BudgetPlanner2Web.Data;
using BudgetPlanner2Web.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace BudgetPlanner2Web.Services
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly AppDbContext _context;
        private readonly HttpContext _httpContext;
        private readonly UserManager<ApplicationUser> _userManager;
        public CategoryRepository(AppDbContext context, IHttpContextAccessor contextAccessor, UserManager<ApplicationUser> manager)
        {
            _context = context;
            _httpContext = contextAccessor.HttpContext;
            _userManager = manager;
        }

        public IEnumerable<Category> AllCategories
        {
            get
            {
                return _context.Categories
                    .Include(x => x.ApplicationUser)
                    .Where(x => x.ApplicationUser.Id == GetCurrentUserId())
                    .ToList();
            }
        }

        public async Task<bool> AddDefaultCategory(ApplicationUser user)
        {
            // jei default category siam useriui jau yra
            if (_context.Categories.Where(x => x.Name.ToLower() == "default" && x.ApplicationUser == user).Any())
                return false;

            // jei ne - sukuriam
            Category cat = new Category
            {
                ApplicationUser = user,
                Name = "Default",
                Description = "Default category"
            };
            _context.Categories.Add(cat);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<Category> GetCategoryById(int id)
        {
            return await _context.Categories
                .Where(x => x.CategoryId == id)
                .Include(x => x.ApplicationUser)
                .FirstOrDefaultAsync(x => x.ApplicationUser.Id == GetCurrentUserId());
        }

        public async Task<Category> AddCategory(Category category)
        {
            category.ApplicationUser = await _userManager.GetUserAsync(_httpContext.User);
            _context.Categories.Add(category);
            await _context.SaveChangesAsync();
            return category;
        }

        public async Task<Category> UpdateCategory(Category category)
        {
            var tmpCat = await GetCategoryById(category.CategoryId);

            if (tmpCat.ApplicationUser.Id == GetCurrentUserId())
            {
                tmpCat.Update(category);
                _context.Update(tmpCat);
                await _context.SaveChangesAsync();
                return tmpCat;
            }
            else
                return null;
        }

        public async Task DeleteCategory(int id)
        {
            var cat = await GetCategoryById(id);
            if (cat.ApplicationUser.Id == GetCurrentUserId())
            {
                _context.Remove(cat);
                await _context.SaveChangesAsync();
            }
        }

        private string GetCurrentUserId()
        {
            var claimsIdentity = (ClaimsIdentity)_httpContext.User.Identity;
            var claim = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier);
            return claim.Value;
        }
    }
}
