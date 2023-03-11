using System.ComponentModel.DataAnnotations;

namespace School_Management.Models
{
    public class Result
    {
        [Key]
        public int ResultId { get; set; }
        [Required]
        public float Mark { get; set; }
        [Required]
        public int SubjectId { get; set; }
        [Required]
        public int StudentId { get; set; }

        public virtual Student? Student { get; set; }
        public virtual Subject? Subject { get; set; }

    }
}
