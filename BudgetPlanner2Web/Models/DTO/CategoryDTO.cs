using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BudgetPlanner2Web.Models.DTO
{
    public class CategoryDTO
    {
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }

        [DisplayFormat(NullDisplayText = "N/A")]
        [Range(1, double.MaxValue, ErrorMessage = "Budget must be greater than 0.")]
        public decimal? Budget { get; set; }
    }
}
