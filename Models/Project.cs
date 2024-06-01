using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TaskManagementSystem.Models
{
    public class Project
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Project Name")]
        public string Name { get; set; }

        public ICollection<Task> Tasks { get; set; }
    }
}
