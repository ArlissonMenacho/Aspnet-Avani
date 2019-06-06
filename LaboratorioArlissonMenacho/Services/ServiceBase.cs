﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LaboratorioArlissonMenacho.Contexto;
using LaboratorioArlissonMenacho.Repositories;

namespace LaboratorioArlissonMenacho.Services
{
    public class ServiceBase<Tentity> : IDisposable where Tentity : class
    {
        private readonly RepositoryBase<Tentity> repository;

        public ServiceBase(RepositoryBase<Tentity> repository)
        {
            this.repository = repository;
        }

        public void Dispose()
        {
            repository.Dispose();
        }

        public void Adicionar(Tentity t)
        {
            repository.Add(t);
        }

        public void Apagar(Tentity t)
        {
            repository.Delete(t);
        }

        public IList<Tentity> BuscarTodos()
        {
            return repository.FindAll();
        }

        public Tentity buscarPorId(int id)
        {
            return repository.GetById(id);
        } 
    }
}
