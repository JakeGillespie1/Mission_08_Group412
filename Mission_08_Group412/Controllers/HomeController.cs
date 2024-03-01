using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
            var ToDoListInfo = _repo.GetItems_Categories();

            return View(ToDoListInfo);
        }

        //Add a new record
        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.Categories = _repo.GetCategories();

            return View("Add_Edit_Task",new ToDoList());
        }

        [HttpPost]
        public IActionResult Add(ToDoList toDoItem)
        {
            if (ModelState.IsValid)
            {
                _repo.AddToList(toDoItem);
                return RedirectToAction("Index");
            }
            else
            {
                ViewBag.Categories = _repo.GetCategories();
                return View("Add_Edit_Task", toDoItem);
            }
                
        }

        //Edit an existing record
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var toDoItemToEdit = _repo.GetItem(id);

            ViewBag.Categories = _repo.GetCategories();

            return View("Add_Edit_Task", toDoItemToEdit);
        }

        [HttpPost]
        public IActionResult Edit(ToDoList toDoItem)
        {
            _repo.EditToDoList(toDoItem);

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var toDoItemToDelete = _repo.GetItem(id);

            return View("DeleteTask", toDoItemToDelete);
        }

        [HttpPost]
        public IActionResult Delete(ToDoList toDoItem) 
        {
            _repo.DeleteToDoItem(toDoItem);
            return RedirectToAction("Index");
        }

        // for the history page
        [HttpGet]
        public IActionResult History()
        {
            var ToDoListInfo = _repo.GetItems_Categories();

            return View(ToDoListInfo);
        }
    }
}
