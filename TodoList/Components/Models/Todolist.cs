namespace TodoList.Components.Models
{
    public class Todolist
    {
        public int Id { get; set; }
        
        public int UserId { get; set; }
        public string Title { get; set; }
        public List<Todo> Todos { get; set; }

        public Todolist(int id, int userId, string title)
        {
            Id = id;
            UserId = userId;
            Title = title;
            Todos = new List<Todo>(){};
        }
    }
}

