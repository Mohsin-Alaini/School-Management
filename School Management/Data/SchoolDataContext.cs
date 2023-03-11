using Microsoft.EntityFrameworkCore;
using School_Management.Models;

namespace School_Management.Data
{
    public class SchoolDataContext : DbContext
    {
        public SchoolDataContext(DbContextOptions<SchoolDataContext> options) : base(options)
        {

        }

        public DbSet<Result> results { get; set; }
        public DbSet<Branch> branches { get; set; }
        public DbSet<Student> students { get; set; }
        public DbSet<Subject> subjects { get; set; }
        public DbSet<Teacher> teachers { get; set; }
        public DbSet<Teacher_Branch> teachers_branches { get;set; }
        public DbSet<Teacher_Subject> teachers_subjects { get;set; }
        
    }
}
