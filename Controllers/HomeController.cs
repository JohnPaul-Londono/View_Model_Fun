using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using View_Model_Fun.Models;

namespace View_Model_Fun.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }


        [HttpGet("")]
        public IActionResult Index()
        {
            // to a View that has a defined a model as @model string[]
            string[] newString = new string[]
            {
                "We're all born naked and the rest is drag."
            };
            return View(newString);
        }

        [HttpGet("numbers")]
        public IActionResult Numbers()
        {
            int[] newNum = new int[]
            {
            1,
            2,
            3,
            5,
            17
            };
            return View(newNum);
        }

        [HttpGet("users")]
        public IActionResult Users()
        {
            List<User> newUsers = new List<User>();
            newUsers.Add(new User(){FirstName = "Kya", LastName = "London"});
            newUsers.Add(new User(){FirstName = "Bumi", LastName = "Patt"});
            newUsers.Add(new User(){FirstName = "Steve", LastName = "Patt"});

            return View(newUsers);
        }

        [HttpGet("user")]
        public IActionResult SingleUser()
        {
            User user = new User(){FirstName = "John", LastName= "Londono"};
            return View ("User", user);
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
