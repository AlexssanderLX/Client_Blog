using System.Diagnostics;
using ClientBlog.Models;
using Microsoft.AspNetCore.Mvc;

namespace ClientBlog.Controllers
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

        public IActionResult Contact()
        {
            var contact = new Models.Contact
            {
                CellNumber = "+5511989275868",
                Instagram = "https://www.instagram.com/lexis_lx1/",
                Linkedin = "https://www.linkedin.com/in/alexssander-ferreira-de-almeida-4a3841284/",
                Email = "alexssander.f.almeida2006@email.com"
            };
            return View(contact);
        }

        public IActionResult About()
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
