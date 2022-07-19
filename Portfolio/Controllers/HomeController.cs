using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Portfolio.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio.Controllers
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
            var person = new Person
            {
                Name = "Egzon",
                LastName = "Bllaca",
                Birthdate = new DateTime(2002,2,3),
                PhoneNumber = "+38345596560",
                Nationality = "Albanian",
                Occupation = "Student",
                Email = "egzonbllaca@outlook.com",
                Projects = new List<Project>()
                {
                    new Project{ Name = "LibraryManagement", Url = @"https://github.com/EgzonBllaca/Menaxhimi_Biblotekes_Web"},
                    new Project{ Name = "CookingRecipeAPI", Url = @"https://github.com/EgzonBllaca/Cooking-Recipe-API"},
                    new Project{ Name = "WinterDestinationApp", Url = @"https://github.com/EgzonBllaca/winter-destination-app"},
                    new Project{ Name = "SportsBlog", Url = @"https://github.com/EgzonBllaca/sports-blog"}
                }
            };
            return View(person);
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
