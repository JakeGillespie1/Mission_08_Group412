namespace Mission_08_Group412.Models
{
    public class EFMission08Repository : IMission08Repository
    {
        private Mission08Context context;

        public EFMission08Repository(Mission08Context temp)
        {
            context = temp;
        }

        public List<ToDoList> ToDoLists => context.ToDoLists.ToList();

        public void AddToList(ToDoList toDoList) 
        { 
            context.Add(toDoList);
            context.SaveChanges();
        }
    }
}