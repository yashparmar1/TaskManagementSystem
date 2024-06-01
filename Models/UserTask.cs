using System.ComponentModel.DataAnnotations.Schema;

namespace TaskManagementSystem.Models
{
    public class UserTask
    {
        public int Id { get; set; }

        [ForeignKey("User")]
        public string UserId { get; set; }
        public ApplicationUser User { get; set; }

        [ForeignKey("Task")]
        public int TaskId { get; set; }
        public Task Task { get; set; }
    }
}
