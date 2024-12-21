namespace TodoList.Components.Models
{
    public class Todo
    {
        public int Id { get; set; }
        public int ListId { get; set; }
        public string Description { get; set; }
        public bool IsComplete { get; set; }
        
        public Todo(int id, int listId, string description)
        {
            Id = id;
            ListId = listId;
            Description = description;
            IsComplete = false;
        }
    }
}