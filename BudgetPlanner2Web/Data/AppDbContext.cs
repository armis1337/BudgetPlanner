using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BudgetPlanner2Web.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace BudgetPlanner2Web.Data
{
    public class AppDbContext : IdentityDbContext<ApplicationUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Expense> Expenses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // seed some expenses
            for (int i = 0; i < 127; i++)
            {
                modelBuilder.Entity<Expense>().HasData(
                    new Expense
                    {
                        Id = 1337 + i,
                        Amount = 13.37m,
                        CategoryId = 16,
                        //ApplicationUser = manager.FindByIdAsync("9659f3cc-8531-4b6b-bba3-382c108b192c").Result,
                        ApplicationUserId = "9659f3cc-8531-4b6b-bba3-382c108b192c",
                        Date = DateTime.Now,
                        Comment = i + " automatically added expense"
                    });
            }


        }
    }
}
