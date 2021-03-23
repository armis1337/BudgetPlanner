using BudgetPlanner2Web.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BudgetPlanner2Web.ViewModels
{
    public class ExpensesListViewModel : BaseListViewModel<Expense>
    {
        public SelectList CategoriesSelectList { get; set; }

        [Display(Name = "Category")]
        public Category CurrentCategory { get; set; }

    }
}
