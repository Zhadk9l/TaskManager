using static TaskManager.Models.Enums;

namespace TaskManager.Models
{
    public class TaskItem
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public Status Status { get; set; } = Status.Todo;
        public Priority Priority { get; set; } = Priority.Medium;
        public DateTime DueDate { get; set; }

        public int ProjectId { get; set; }
        public Project Project { get; set; } = null!;

        public int? AssignedUserId { get; set; }     
        public User? AssignedUser { get; set; }        
    }
}
