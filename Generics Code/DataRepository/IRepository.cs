using System;

namespace DataRepository;

public interface IRepoitory<T> where T : class

{
    void Add(T entity);
    void Remove(T entity);

    T GetById(int id);
    IEnumerable<T> GetAll();

}
