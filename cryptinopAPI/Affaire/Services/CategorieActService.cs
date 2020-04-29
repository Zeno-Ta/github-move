using System;
using System.Collections.Generic;
using cryptinopAPI.DAL.UnityOfWork;
using cryptinopAPI.Models;

namespace cryptinopAPI.Affaire.Services
{
    public class CategorieActService: ICategorieActService, IServiceBase<ICategorieActivite>
    {
        readonly IUnitOfWork _unitOfWork;

        public CategorieActService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public void Ajouter(ICategorieActivite obj)
        {
            throw new NotImplementedException();
        }

        public void Modifier(ICategorieActivite obj)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ICategorieActivite> Obtenir()
        {
            throw new NotImplementedException();
        }

        public ICategorieActivite Obtenir(int id)
        {
            throw new NotImplementedException();
        }

        public void Supprimer(int id)
        {
            throw new NotImplementedException();
        }
    }
}
