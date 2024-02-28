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

        public void AddToList(ToDoList toDoList)
        {
            _context.Add(toDoList);
            _context.SaveChanges();
        }
    }
}
