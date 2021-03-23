using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BudgetPlanner2Web.Models.DTO
{
    public class UpdateExpenseDTO : ExpenseDTO
    {
        [Required]
        public int Id { get; set; }
        public new DateTime Date { get; set; }
        public new int CategoryId { get; set; }
        public new decimal Amount { get; set; }
    }
}
