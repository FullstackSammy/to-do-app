namespace ToDoApp.Models
{
    public class Todo
    {
        public int Id { get; set; }
        public required string Title { get; set; }
        public string? Description { get; set; }
        public PriorityPicker Priority { get; set; }
    }

    public enum PriorityPicker
    {
        MustDo,
        CouldDo,
        DoNotHaveTo
    }
}
