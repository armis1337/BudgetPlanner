using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BudgetPlanner2Web.Models
{
    public class CategorySummary
    {
        public Category Category { get; set; }
        public int ThisMonthBoughtCount { get; set; }
        public int TotalBoughtCount { get; set; }
        public decimal ThisMonthSpentAmount { get; set; }
        public decimal TotalSpentAmount { get; set; }
        public bool Warning
        {
            get
            {
                if (Category.Budget == null || ThisMonthSpentAmount == 0m || decimal.Divide(ThisMonthSpentAmount, Category.Budget.Value) < 0.9m)
                    return false;
                else
                    return true;
            }
        }
        public string BudgetStatus
        {
            get
            {
                if (Category.Budget == null)
                    return "N/A";
                return ThisMonthSpentAmount.ToString() + "/" + Category.Budget.ToString();
            }
        }

    }
}
