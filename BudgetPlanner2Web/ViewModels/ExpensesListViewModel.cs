using BudgetPlanner2Web.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BudgetPlanner2Web.ViewModels
{
    public class ExpensesListViewModel
    {
        public IEnumerable<Expense> Expenses { get; set; }
        public SelectList CategoriesSelectList { get; set; }
        [Display(Name = "Category")]
        public Category CurrentCategory { get; set; }
    }
}
