﻿using System;
using cryptinopAPI.Models;
using cryptinopAPI.DAL.UnityOfWork;
using System.Collections.Generic;

namespace cryptinopAPI.Affaire.Services
{
    public class MonnaieService : IMonnaieService, IServiceBase<IMonnaie>
    {
        readonly IUnitOfWork _unitOfWork;

        public MonnaieService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

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
