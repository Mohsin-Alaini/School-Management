using School_Management.Data;
using School_Management.Models.Interface;

namespace School_Management.Models.Repository
{
    public class SubjectRepository : IBaseRepository<Subject>
    {
        private readonly SchoolDataContext _db;

        public SubjectRepository(SchoolDataContext db)
        {
            _db = db;
        }
        public void Add(Subject item)
        {
            _db.subjects.Add(item);
            _db.SaveChanges();
        }

        public void Delete(Subject item)
        {
            _db.subjects.Remove(item);
            _db.SaveChanges();
        }

        public Subject Find(int id)
        {
            return _db.subjects.Find(id);
        }

        public IEnumerable<Subject> GetAll()
        {
            return _db.subjects;
        }

        public void Update(Subject item)
        {
            _db.subjects.Update(item);
            _db.SaveChanges();
        }

      
    }
}
