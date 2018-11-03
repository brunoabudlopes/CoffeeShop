using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;


namespace MyCoffeeShop.Controllers
{
    public class WhereIsMyCoffeeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Welcome(string name, int numTimes = 1)
        {
            ViewData["Message"] = "Hello" + name;
            ViewData["numTimes"] = numTimes;
            return View();
        }

        public string MyAdd()
        {
            return ("Join us for free to win!");
        }

        public string MyCustomer(string name, int ID)
        {
            return HtmlEncoder.Default.Encode($"Welcome to my world, {name}, I know you will win {ID} times");
        }
    }
}