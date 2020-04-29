using System;
using cryptinopAPI.Models;
using cryptinopAPI.DAL.UnityOfWork;
using System.Collections.Generic;

namespace cryptinopAPI.Affaire.Services
{
    public class ValMonnaieService: IValMonnaieService, IServiceBase<IValMonnaie>
    {
        readonly IUnitOfWork _unitOfWork;

        public ValMonnaieService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public void Ajouter(IValMonnaie obj)
        {
            throw new NotImplementedException();
        }

        public void Modifier(IValMonnaie obj)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<IValMonnaie> Obtenir()
        {
            throw new NotImplementedException();
        }

        public IValMonnaie Obtenir(int id)
        {
            throw new NotImplementedException();
        }

        public void Supprimer(int id)
        {
            throw new NotImplementedException();
        }
    }
}
