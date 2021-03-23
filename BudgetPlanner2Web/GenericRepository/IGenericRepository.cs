using BudgetPlanner2Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BudgetPlanner2Web.GenericRepository
{
    public interface IGenericRepository<T> where T : BaseEntity
    {
        Task<IEnumerable<T>> GetAllAsync();
        Task<T> GetByIdAsync(int id);
        Task<T> AddAsync(T obj, string userID = null);
        Task<bool> UpdateAsync(T obj);
        Task<bool> DeleteAsync(int id);
        Task SaveAsync();
        Task<bool> ObjectExistsAsync(int id);
        string GetCurrentUserId();
    }
}
