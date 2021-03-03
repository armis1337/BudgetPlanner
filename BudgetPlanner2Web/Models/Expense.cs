using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace BudgetPlanner2Web.Models
{
    public class Expense
    {
        [Display(Name = "Number")]
        public int ExpenseId { get; set; }

        [DataType(DataType.Currency)]
        public decimal Amount { get; set; }

        public DateTime Date { get; set; }
        public string Comment { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "Create a category first.")]
        public int CategoryId { get; set; }

        [JsonIgnore]
        public Category Category { get; set; }

        [JsonIgnore]
        public ApplicationUser ApplicationUser { get; set; } // owner

        public void Update(Expense expense)
        {
            Amount = expense.Amount;
            Date = expense.Date;
            Comment = expense.Comment;
            CategoryId = expense.CategoryId;
        }

        public override string ToString()
        {
            return "test string XD";
        }
    }
}
