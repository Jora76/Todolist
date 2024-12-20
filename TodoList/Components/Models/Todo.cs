namespace TodoList.Components.Models
{
    public class Todo
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Description { get; set; }
        public bool IsComplete { get; set; }
        
        public Todo(int id, int userId, string description)
        {
            Id = id;
            UserId = userId;
            Description = description;
            IsComplete = false;
        }
    }
}