using System.ComponentModel.DataAnnotations;

namespace School_Management.Models
{
    public class Branch
    {
        [Key]
        public int BranchId { get; set; }
        [Required]
        public string BranchName { get; set; }

        //One
        public IEnumerable<Subject> Subjects { get; set; }

        // Many to Many 
        public ICollection<Teacher_Branch>? Teacher_Branches { get; set; }

    }
}
