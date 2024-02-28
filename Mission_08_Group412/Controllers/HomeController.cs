using Microsoft.AspNetCore.Mvc;
using Mission_08_Group412.Models;
using System.Diagnostics;

namespace Mission_08_Group412.Controllers
{
    public class HomeController : Controller
    {
        private IMission08Repository _repo;

        public HomeController(IMission08Repository temp) 
        { 
            _repo = temp;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var ToDoListInfo = _repo.ToDoLists;

            return View(ToDoListInfo);
        }

        [HttpGet]
        public IActionResult AddTask()
        {
            return View(new ToDoList());
        }








    }
}
