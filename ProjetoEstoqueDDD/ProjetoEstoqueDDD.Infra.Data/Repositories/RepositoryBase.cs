using ProjetoEstoqueDDD.Domain.Interfaces;
using ProjetoEstoqueDDD.Infra.Data.Contexto;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace ProjetoEstoqueDDD.Infra.Data.Repositories
{
    public class RepositoryBase<T> : IDisposable, IRepositoryBase<T> where T : class
    {
        protected ProjetoEstoqueContext Db = new ProjetoEstoqueContext();

        public void Add(T obj)
        {
            Db.Set<T>().Add(obj);
            Db.SaveChanges();
        }

        public void Dispose()
        {
            Dispose();
        }

        public IEnumerable<T> GetAll()
        {
            return Db.Set<T>().ToList();
        }

        public T GetById(int id)
        {
            return Db.Set<T>().Find(id);
        }

        public void Remove(T obj)
        {
            Db.Set<T>().Remove(obj);
            Db.SaveChanges();
        }

        public void Update(T obj)
        {
            //Entry serve para garantir de que essa entidade ja existe no banco
            Db.Entry(obj).State = EntityState.Modified;
        }
    }
}
