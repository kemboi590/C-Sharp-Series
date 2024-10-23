namespace DataRepository;

public class Repository<T> : IRepoitory<T> where T: class
{
    private readonly List<T> _entities = new List<T>();

    public void Add(T entity)
    {
        _entities.Add(entity);
    }

    public void Remove(T entity)
    {
        _entities.Remove(entity);
    }

    public T GetById(int id)
    {
        return _entities.FirstOrDefault()!;
    }

    public IEnumerable<T> GetAll()
    {
        return _entities;
    }

}
