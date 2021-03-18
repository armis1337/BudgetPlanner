﻿using BudgetPlanner2Web.Data;
using BudgetPlanner2Web.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.Data.SqlClient;
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

        public async Task<IEnumerable<T>> GetAll()
        {
            return await table
                .Where(x => x.ApplicationUserId == GetCurrentUserId())
                .ToListAsync();
        }
        
        public async Task<T> GetById(int id)
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

        public virtual bool Add(T obj)
        {
            obj.ApplicationUserId = GetCurrentUserId();
            obj.CreatedAt = DateTime.Now;
            table.Add(obj);
            return true;
        }

        public virtual async Task<bool> Update(T obj)
        {
            T tmp = await GetById(obj.Id);
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

        public async Task Delete(int id)
        {
            T tmp = await GetById(id);

            if (tmp.ApplicationUserId == GetCurrentUserId())
            {
                T existing = await table.FindAsync(id);
                table.Remove(existing);
            }
        }

        public async Task Save()
        {
            await _context.SaveChangesAsync();
        }

        public string GetCurrentUserId()
        {
            var claimsIdentity = (ClaimsIdentity)_httpContext.User.Identity;
            var claim = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier);
            return claim.Value;
        }
    }
}