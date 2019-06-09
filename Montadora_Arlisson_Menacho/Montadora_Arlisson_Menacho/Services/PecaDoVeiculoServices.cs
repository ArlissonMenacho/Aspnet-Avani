﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Montadora_Arlisson_Menacho.Contexto;
using Montadora_Arlisson_Menacho.Models;
using Montadora_Arlisson_Menacho.Repositories;

namespace Montadora_Arlisson_Menacho.Services
{
    public class PecaDoVeiculoServices
    {
        private readonly PecaDoVeiculoRepository pecaDoVeiculoRepository;

        public PecaDoVeiculoServices(PecaDoVeiculoRepository pecaDoVeiculoRepository)
        {
            this.pecaDoVeiculoRepository = pecaDoVeiculoRepository;
        }

        public void Add(PecaDoVeiculo pecaDoVeiculo)
        {
            pecaDoVeiculoRepository.Add(pecaDoVeiculo);
        }

        public void Delete(PecaDoVeiculo pecaDoVeiculo)
        {
            pecaDoVeiculoRepository.Delete(pecaDoVeiculo);
        }

        public IList<PecaDoVeiculo> FindAll()
        {
            return pecaDoVeiculoRepository.FindAll();
        }

        //public IList<PecaDoVeiculo> getByDescricao(String descricao)
        //{
        //    return pecaDoVeiculoRepository.getByDescricao(descricao);

        //}

        public PecaDoVeiculo GetbyId(int id)
        {
            return pecaDoVeiculoRepository.GetbyId(id);
        }
    }
}
