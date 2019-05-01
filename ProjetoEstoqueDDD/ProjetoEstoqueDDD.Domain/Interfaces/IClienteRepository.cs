using ProjetoEstoqueDDD.Domain.Entities;
using System;
using System.Collections.Generic;

namespace ProjetoEstoqueDDD.Domain.Interfaces
{
    public class IClienteRepository : IRepositoryBase<Cliente>
    {
        public void Add(Cliente obj)
        {
            throw new System.NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Cliente> GetAll()
        {
            throw new NotImplementedException();
        }

        public Cliente GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Remove(Cliente obj)
        {
            throw new NotImplementedException();
        }

        public void Update(Cliente obj)
        {
            throw new NotImplementedException();
        }
    }
}
