namespace ObjectOrientedProgramming.Repositories
{
    public abstract class MongoRepository<T> : IRepository<T>
    {
        public void Insert(T entity)
        {
            // Method intentionally left empty.
        }

        public IEnumerable<T> List()
        {
            return new List<T>();
        }

        public T? Select(int id)
        {
            return default;
        }

        public void Update(T entity)
        {
            // Method intentionally left empty.
        }
    }
}
