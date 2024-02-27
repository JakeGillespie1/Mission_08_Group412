using Microsoft.AspNetCore.Mvc;
using Mission_08_Group412.Models;
using System.Diagnostics;

namespace Mission_08_Group412.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        







    }
}
