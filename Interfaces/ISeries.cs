using System.Collections.Generic;

namespace DIO.CrudSeries
{
    public interface IRepository<T>
    {
         List<T> List();
         T searchById(int id);
         void Add(T entity);
         void Delete(int id);
         void Update(int id, T entity);
         int NextId();
    }
}