using System.ComponentModel.DataAnnotations;

namespace School_Management.Models
{
    public class Student
    {
        [Key]
        public int StudentID { get; set; }
        [Required]
        [StringLength(50)]
        public string StudentFName { get; set; }
        [Required]
        [StringLength(50)]
        public string StudentLName { get; set;}

        public string StudentEmail { get; set; }
        [Required]
        public string StudentPhone { get; set;}
        public DateTime StudentBirth_day { get; set; }= DateTime.Now;
        public string StudentGender { get; set; }

        // Many to Many 
        public ICollection<Result>? Results { get; set; }



    }
}
