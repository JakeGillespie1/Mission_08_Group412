namespace Mission_08_Group412.Models
{
    public interface IMission08Repository
    {
        List<ToDoList> ToDoLists { get; }

        public void AddToList(ToDoList toDoListItem);

        public void EditToDoList(ToDoList toDoListItem);

        public ToDoList GetItem(int id);
    }
}
