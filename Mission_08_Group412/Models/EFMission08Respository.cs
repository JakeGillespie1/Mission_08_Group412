using Microsoft.EntityFrameworkCore;

namespace Mission_08_Group412.Models
{
    public class EFMission08Repository : IMission08Repository
    {
        private Mission08Context _context;

        public EFMission08Repository(Mission08Context temp)
        {
            _context = temp;
        }

        public List<ToDoList> ToDoLists => _context.ToDoLists.ToList();

        public void AddToList(ToDoList toDoListItem)
        {
            _context.Add(toDoListItem);
            _context.SaveChanges();
        }

        public void EditToDoList(ToDoList toDoListItem)
        {
            _context.Update(toDoListItem);
            _context.SaveChanges();
        }

        public ToDoList GetItem(int id) 
        {
            var itemToEdit = _context.ToDoLists
                .Include("Category")
                .Single(x => x.TaskId == id);

            return itemToEdit;
        }

        public void DeleteToDoItem(ToDoList toDoItem)
        {
            _context.ToDoLists.Remove(toDoItem);
            _context.SaveChanges();
        }

        public List<ToDoList> GetItems_Categories()
        {
            List<ToDoList> toDoListItems = _context.ToDoLists.Include("Category").ToList();
            return toDoListItems;
        }

        public List<Category> GetCategories()
        {
            var categories = _context.Categories
                .OrderBy(x => x.CategoryName)
                .ToList();

            return categories;

        }
    }
}
