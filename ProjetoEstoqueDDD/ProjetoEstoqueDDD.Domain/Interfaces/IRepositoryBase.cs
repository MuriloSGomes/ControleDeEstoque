using System.Collections.Generic;

namespace ProjetoEstoqueDDD.Domain.Interfaces
{
    public interface IRepositoryBase<T> where T: class
    {
        void Add(T obj);
        T GetById(int id);
        IEnumerable<T> GetAll();
        void Update(T obj);
        void Remove(T obj);
        void Dispose();

    }
}
