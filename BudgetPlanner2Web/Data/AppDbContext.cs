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
        public AppDbContext (DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Expense> Expenses { get; set; }

        /*protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //seed categories
            //modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 1, Name = "Default", Description = "Default category", isDefault = true, ApplicationUser = null });
            //modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 1, Name = "Shopping", Description = "money spent on shopping" });
            //modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 2, Name = "Fun", Description = "money spent on fun things ;)" });
            //modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 3, Name = "Other", Description = "money spent on other stuff" });

            //seed expenses
            //modelBuilder.Entity<Expense>().HasData(new Expense { ExpenseId = 1, Amount = 3.80m, CategoryId = 1, Comment = "kebabas su cesnakiniu", Date = DateTime.Now });
            //modelBuilder.Entity<Expense>().HasData(new Expense { ExpenseId = 2, Amount = 4.10m, CategoryId = 1, Comment = "camel blue", Date = DateTime.Now });
            //modelBuilder.Entity<Expense>().HasData(new Expense { ExpenseId = 3, Amount = 20m, CategoryId = 2, Comment = "420", Date = DateTime.Now });
            //modelBuilder.Entity<Expense>().HasData(new Expense { ExpenseId = 4, Amount = 50m, CategoryId = 3, Comment = "spark bauda", Date = DateTime.Now });
        }*/
    }
}
