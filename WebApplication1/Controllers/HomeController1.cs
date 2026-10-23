using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace WebApplication1.Controllers
{
    public class HomeController1 : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Welcome(string name, int numTimes = 1)
        {
            ViewData["name"] = name;
            ViewData["NumTime"] = numTimes;

            return View("index");
        }
    }
}
