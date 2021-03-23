using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BudgetPlanner2Web.Models.DTO
{
    public class ExpenseDTO
    {
        [Required]
        public decimal Amount { get; set; }
        [Required]
        public DateTime Date { get; set; }
        public string Comment { get; set; }
        [Required]
        public int CategoryId { get; set; }
    }
}
