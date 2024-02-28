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
                .Single(x => x.TaskId == id);

            return itemToEdit;
        }
    }
}
