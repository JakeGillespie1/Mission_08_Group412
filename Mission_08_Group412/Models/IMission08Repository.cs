namespace Mission_08_Group412.Models
{
    public interface IMission08Repository
    {
        List<ToDoList> ToDoLists { get; }

        public void AddToList(ToDoList toDoList);
    }
}
