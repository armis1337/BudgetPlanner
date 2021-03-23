using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BudgetPlanner2Web.Models.DTO
{
    public class UpdateCategoryDTO : CategoryDTO
    {
        [Required]
        public int Id { get; set; }
        public new string Name { get; set; } // kad nebutu required
    }
}
