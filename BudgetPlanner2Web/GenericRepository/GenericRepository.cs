using BudgetPlanner2Web.Data;
using BudgetPlanner2Web.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace BudgetPlanner2Web.GenericRepository
{
    public class GenericRepository<T> : IGenericRepository<T>
        where T : BaseEntity
    {
        protected readonly AppDbContext _context;
        protected readonly HttpContext _httpContext;

        protected readonly DbSet<T> table;

        public GenericRepository(AppDbContext context, IHttpContextAccessor http)
        {
            _context = context;
            _httpContext = http.HttpContext;

            table = _context.Set<T>();
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await table
                .Where(x => x.ApplicationUserId == GetCurrentUserId())
                .ToListAsync();
        }
        
        public async Task<T> GetByIdAsync(int id)
        {
            var result = table.Where(x => x.Id == id);

            var navigations = _context.Model.FindEntityType(typeof(T))
                .GetDeclaredNavigations()
                .Distinct();

            foreach (var property in navigations)
                result = result.Include(property.Name);

            return await result
                .Where(x => x.ApplicationUserId == GetCurrentUserId())
                .FirstOrDefaultAsync();
        }

        public virtual async Task<T> AddAsync(T obj, string userID = null)
        {
            if (userID != null)
                obj.ApplicationUserId = userID;
            else
                obj.ApplicationUserId = GetCurrentUserId();

            obj.CreatedAt = DateTime.Now;
            obj.UpdatedAt = null; 
            await table.AddAsync(obj);
            return obj;
        }

        public virtual async Task<bool> UpdateAsync(T obj)
        {
            T tmp = await GetByIdAsync(obj.Id);
            if (tmp.ApplicationUserId == GetCurrentUserId())
            {
                tmp.Update(obj);
                tmp.UpdatedAt = DateTime.Now;
                table.Attach(tmp);
                _context.Entry(tmp).State = EntityState.Modified;
                return true;
            }
            return false;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            T tmp = await GetByIdAsync(id);

            if (tmp != null && tmp.ApplicationUserId == GetCurrentUserId())
            {
                T existing = await table.FindAsync(id);
                table.Remove(existing);
                return true;
            }
            return false;
        }

        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }

        public async Task<bool> ObjectExistsAsync(int id)
        {
            return await table.AnyAsync(x => x.Id == id);
        }

        public string GetCurrentUserId()
        {
            var claimsIdentity = (ClaimsIdentity)_httpContext.User.Identity;
            var claim = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier);
            return claim.Value;
        }
    }
}
