﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using BudgetPlanner2Web.Models.DTO;

namespace BudgetPlanner2Web.Models
{
    public class Category : BaseEntity
    {
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }

        [JsonIgnore]
        public ApplicationUser ApplicationUser { get; set; } // owner

        [Display(Name = "Monthly budget")]
        [DisplayFormat(NullDisplayText = "N/A")]
        [Range(1, double.MaxValue, ErrorMessage = "Budget must be greater than 0.")]
        public decimal? Budget { get; set; }
    }
}
