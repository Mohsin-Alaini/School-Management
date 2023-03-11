using School_Management.Data;
using School_Management.Models.Interface;

namespace School_Management.Models.Repository
{
    public class BranchRepository : IBaseRepository<Branch>
    {
        private readonly SchoolDataContext _db;

        public BranchRepository(SchoolDataContext db)
        {
            _db = db;
        }
        public void Add(Branch item)
        {
            _db.branches.Add(item);
            _db.SaveChanges();
        }

        public void Delete(Branch item)
        {
            _db.branches.Remove(item);
            _db.SaveChanges();
        }

        public Branch Find(int id)
        {
            return _db.branches.Find(id);
        }

        public IEnumerable<Branch> GetAll()
        {
            return _db.branches;
        }

        public void Update(Branch item)
        {
            _db.branches.Update(item);
            _db.SaveChanges();
        }
    }
}
