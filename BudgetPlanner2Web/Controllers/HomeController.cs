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
        private readonly ILogger<HomeController> _logger;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly IExpenseRepository _expenseRepository;
        private readonly ICategoryRepository _categoryRepository;
        private readonly CategorySummaryGenerator _summaryGenerator;
        //private readonly GoogleDriveService _driveService;

        public HomeController(ILogger<HomeController> logger, SignInManager<ApplicationUser> signin, IExpenseRepository expRepo, ICategoryRepository catRepo,
            CategorySummaryGenerator generator/*, GoogleDriveService service*/)
        {
            _logger = logger;
            _signInManager = signin;
            _expenseRepository = expRepo;
            _categoryRepository = catRepo;
            _summaryGenerator = generator;
            //_driveService = service;
        }

        public IActionResult Index()
        {
            if (_signInManager.IsSignedIn(User))
            {
                return View(nameof(LoggedInIndex), _summaryGenerator.AllSummaries);
            }
            else
                return View();
        }

        //public IActionResult Test()
        //{
        //    _driveService.UploadFileOnDrive();
        //    ViewBag.Message = "hello";
        //    return View();
        //}

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
