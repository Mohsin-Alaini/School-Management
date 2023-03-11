using School_Management.Data;
using School_Management.Models.Interface;

namespace School_Management.Models.Repository
{
    public class TeacherRepository : IBaseRepository<Teacher>
    {
        private readonly SchoolDataContext _db;

        public TeacherRepository(SchoolDataContext db)
        {
            _db = db;
        }
        public void Add(Teacher item)
        {
            _db.teachers.Add(item);
            _db.SaveChanges();
        }

       

        public void Delete(Teacher item)
        {
            _db.teachers.Remove(item);
            _db.SaveChanges();
        }

       

        public Teacher Find(int id)
        {
            return _db.teachers.Find(id);
        }

        public IEnumerable<Teacher> GetAll()
        {
            return _db.teachers;
        }

        public void Update(Teacher item)
        {
            _db.teachers.Update(item);
            _db.SaveChanges();
        }

       
    }
}
