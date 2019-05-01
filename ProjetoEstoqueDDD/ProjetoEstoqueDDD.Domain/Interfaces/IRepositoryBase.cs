namespace ProjetoEstoqueDDD.Domain.Interfaces
{
    public interface IRepositoryBase<T> where T: class
    {
        void Add(T obj);
    }
}
