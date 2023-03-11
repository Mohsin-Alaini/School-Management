using System.ComponentModel.DataAnnotations;

namespace School_Management.Models
{
    public class Teacher
    {
        [Key]
        public int TeacherId { get; set; }
        [Required]
        [StringLength(50)]
        public string TeacherFName { get; set; }
        [Required]
        [StringLength(50)]
        public string TeacherLName { get; set; }
        [Range(0,1500)]
        public float TeacherSalary { get; set; }
        public string TeacherEmail { get; set; }
        [Required]
        public string TeacherPhone { get; set;}
        public DateTime TeacherHired_Date { get; set; }= DateTime.Now;
        public String TeacherGender { get; set; }

        // Many to Many 
        public ICollection<Teacher_Branch>? Teacher_Branches { get; set; }

        // Many to Many 
        public ICollection<Teacher_Subject>? teacher_Subjects { get; set; }








    }
}
