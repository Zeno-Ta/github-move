﻿using System;
using System.Collections.Generic;
using System.Linq;
using cryptinopAPI.DAL.Context;
using cryptinopAPI.Models;

namespace cryptinopAPI.DAL.Repositories
{
    public class MonnaieRepo : IMonnaieRepo, IRepositoryBase<IMonnaie>
    {
        public void Ajouter(IMonnaie obj)
        {
            throw new NotImplementedException();
        }

        public void Modifier(IMonnaie obj)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<IMonnaie> Obtenir()
        {
            throw new NotImplementedException();
        }

        public IMonnaie Obtenir(int id)
        {
            throw new NotImplementedException();
        }

        public void Supprimer(int id)
        {
            throw new NotImplementedException();
        }
    }
}
