using System.ComponentModel.DataAnnotations;

namespace School_Management.Models
{
    public class Teacher_Subject
    {
        [Key]
        public int Teacher_Subject_Id { get; set; }
        [Required]
        public int TeacherId { get; set; }
        [Required]
        public int SubjectId { get; set; }
        public virtual Teacher? Teacher { get; set; }
        public virtual Subject? Subject { get; set; }
    }
}
