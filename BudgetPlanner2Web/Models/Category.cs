using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BudgetPlanner2Web.Models
{
    public class Category : BaseEntity
    {
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        public ApplicationUser ApplicationUser { get; set; } // owner

        [Display(Name = "Monthly budget")]
        [DisplayFormat(NullDisplayText = "N/A")]
        [Range(1, double.MaxValue, ErrorMessage = "Budget must be greater than 0.")]
        public decimal? Budget { get; set; }

        //public void Update(Category cat)
        //{
        //    Name = cat.Name;
        //    Description = cat.Description;
        //    Budget = cat.Budget;
        //}
    }
}
