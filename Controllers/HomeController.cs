using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Register(RegisterViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            TempData["SuccessMessage"] = "Registered successfully";
            return RedirectToAction("Index");
        }

        [AcceptVerbs("GET", "POST")]
        public IActionResult VerifyEmail(string email)
        {
            if (email == "admin@example.com")
            {
                return Json($"Email {email} is already in use.");
            }

            return Json(true);
        }

        //public IActionResult Details()

        public IActionResult ActionWithParams(string strParam,
            int intParam, DateTime dateParam)
        {
            ViewBag.StrParam = strParam;
            ViewBag.IntParam = intParam;
            ViewBag.DateParam = dateParam;
            return View();
        }

        public IActionResult ActionWithMenu()
        {
            return View();
        }

        public IActionResult Collection()
        {
            var model = new CollectionViewModel
            {
                CollectionInfo = "Collection info",
                Elements = new List<CollectionElementViewModel>
                {
                    new CollectionElementViewModel
                    {
                        Name = "First element",
                        FirstProp = "1st element 1st prop",
                        SecondProp = "1st element 2nd prop"
                    },
                    new CollectionElementViewModel
                    {
                        Name = "Second element",
                        FirstProp = "2nd element 1st prop",
                        SecondProp = "2nd element 2nd prop"
                    },
                    new CollectionElementViewModel
                    {
                        Name = "Third element",
                        FirstProp = "3rd element 1st prop",
                        SecondProp = "3rd element 2nd prop"
                    }
                }
            };

            return View(model);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        
    }
}
