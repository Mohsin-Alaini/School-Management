using System.ComponentModel.DataAnnotations;

namespace School_Management.Models
{
    public class Teacher_Branch
    {
        [Key]
        public int Teacher_Branch_Id { get; set; }
        [Required]
        public int TeacherId { get; set; }
        [Required]
        public int BranchId { get; set; }
        public virtual Teacher? Teacher { get; set; }
        public virtual Branch? Branch { get; set; }
    }
}
