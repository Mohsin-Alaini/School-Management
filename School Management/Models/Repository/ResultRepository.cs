using School_Management.Data;
using School_Management.Models.Interface;

namespace School_Management.Models.Repository
{
    public class ResultRepository : IBaseRepository<Result>
    {
        private readonly SchoolDataContext _db;

        public ResultRepository(SchoolDataContext db)
        {
            _db = db;
        }
        public void Add(Result item)
        {
            _db.results.Add(item);
            _db.SaveChanges();
        }

        public void Delete(Result item)
        {
            _db.results.Remove(item);
            _db.SaveChanges();
        }

        public Result Find(int id)
        {
            return _db.results.Find(id);
        }

        public IEnumerable<Result> GetAll()
        {
            return _db.results;
        }

        public void Update(Result item)
        {
            _db.results.Update(item);
            _db.SaveChanges();
        }
    }
}
