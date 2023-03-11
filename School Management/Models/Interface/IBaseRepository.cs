namespace School_Management.Models.Interface
{
    public interface IBaseRepository<T> where T : class
    {

        public void Add(T item);
        public void Update(T item);
        public void Delete(T item);
        public T Find(int id);
        public IEnumerable<T> GetAll();
    }
}
