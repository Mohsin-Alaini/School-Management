using School_Management.Data;
using School_Management.Models.Interface;

namespace School_Management.Models.Repository
{
    public class StudentRepository : IBaseRepository<Student>
    {
        private readonly SchoolDataContext _db;

        public StudentRepository(SchoolDataContext db)
        {
            _db = db;
        }
        public void Add(Student item)
        {
            _db.students.Add(item);
            _db.SaveChanges();
        }

        public void Delete(Student item)
        {
            _db.students.Remove(item);
            _db.SaveChanges();
        }

        public Student Find(int id)
        {
            return _db.students.Find(id);
        }

        public IEnumerable<Student> GetAll()
        {
            return _db.students;
        }

        public void Update(Student item)
        {
            _db.students.Update(item);
            _db.SaveChanges();
        }
    }
}
