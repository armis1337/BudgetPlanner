using BudgetPlanner2Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BudgetPlanner2Web.GenericRepository
{
    public interface IGenericRepository<T> where T : BaseEntity
    {
        Task<IEnumerable<T>> GetAll();
        Task<T> GetById(int id);
        bool Add(T obj);
        Task<bool> Update(T obj);
        Task Delete(int id);
        Task Save();
        string GetCurrentUserId();
    }
}
