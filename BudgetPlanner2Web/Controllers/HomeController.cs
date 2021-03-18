﻿using BudgetPlanner2Web.GenericRepository;
using BudgetPlanner2Web.Models;
using BudgetPlanner2Web.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace BudgetPlanner2Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly CategorySummaryGenerator _summaryGenerator;

        public HomeController(SignInManager<ApplicationUser> signin, CategorySummaryGenerator generator)
        {
            _signInManager = signin;
            _summaryGenerator = generator;
        }

        public async Task<IActionResult> Index()
        {
            //if (_signInManager.IsSignedIn(User))
            //{
            //    return View(nameof(LoggedInIndex), await _summaryGenerator.AllSummaries()); // padaryt ne all o top 3
            //}
            //else
                return View();
        }

        public IActionResult LoggedInIndex()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
