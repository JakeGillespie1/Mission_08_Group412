using Microsoft.AspNetCore.Mvc;
using Mission_08_Group412.Models;
using System.Diagnostics;

namespace Mission_08_Group412.Controllers
{
    public class HomeController : Controller
    {
        private IMission08Repository _mission08Repository;

        public HomeController(IMission08Repository temp) 
        { 
            _mission08Repository = temp;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var ToDoListInfo = _mission08Repository.ToDoLists;

            return View(ToDoListInfo);
        }


        [HttpGet]
        public IActionResult AddTask()
        {
            return View(new ToDoList());
        }








    }
}
