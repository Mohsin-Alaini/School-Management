using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace School_Management.Models
{
    public class Subject
    {
        [Key]
        public int SubjectId { get; set; }
        [Required]
        public string SubjectName { get; set; }
        public string SubjectDescription { get; set; }

        // Many 
        [Required]
        public int BranchId { get; set; }
        [ForeignKey("BranchId")]
        public virtual Branch? Branch { get; set; }

        // Many to Many 
        public ICollection<Result>? Results { get; set; }

        // Many to Many 
        public ICollection<Teacher_Subject>? teacher_Subjects { get; set; }

        



    }
}
