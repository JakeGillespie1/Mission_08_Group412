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

        //Add a new record
        [HttpGet]
        public IActionResult Add()
        {
            return View("Add_Edit_Task",new ToDoList());
        }

        [HttpPost]
        public IActionResult Add(ToDoList toDoItem)
        {
            _repo.AddToList(toDoItem);

            return RedirectToAction("Index");
        }

        //Edit an existing record
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var toDoItemToEdit = _repo.GetItem(id);

            return View("Add_Edit_Task", toDoItemToEdit);
        }

        [HttpPost]
        public IActionResult Edit(ToDoList toDoItem)
        {
            _repo.EditToDoList(toDoItem);

            return RedirectToAction("Index");
        }







    }
}
