using BudgetPlanner2Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BudgetPlanner2Web.ViewModels
{
    public class BaseListViewModel<T> where T : class
    {
        public PaginatedList<T> Items { get; set; }
        public Dictionary<string, string> SortOrder { get; set; }
        public string CurrentSort { get; set; }
    }
}
