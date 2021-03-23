using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace BudgetPlanner2Web.Models
{
    public class Expense : BaseEntity
    {
        //[Display(Name = "Number")]
        public override int Id { get => base.Id; set => base.Id = value; }

        [Required]
        [DataType(DataType.Currency)]
        public decimal Amount { get; set; }
        [Required]
        public DateTime Date { get; set; }
        public string Comment { get; set; }
        [Required]

        [Range(1, int.MaxValue, ErrorMessage = "Create a category first.")]
        public int CategoryId { get; set; }

        [JsonIgnore]
        public Category Category { get; set; }

        [JsonIgnore]
        public ApplicationUser ApplicationUser { get; set; } // owner
    }
}
