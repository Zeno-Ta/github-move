using System;
using System.Collections.Generic;
using cryptinopAPI.DAL.UnityOfWork;
using cryptinopAPI.Models;
namespace cryptinopAPI.Affaire.Services
{
    public class TypeCategorieService: ITypeCategorieService, IServiceBase<ITypeCategorie>
    {
        readonly IUnitOfWork _unitOfWork;

        public TypeCategorieService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public void Ajouter(ITypeCategorie obj)
        {
            throw new NotImplementedException();
        }

        public void Modifier(ITypeCategorie obj)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ITypeCategorie> Obtenir()
        {
            throw new NotImplementedException();
        }

        public ITypeCategorie Obtenir(int id)
        {
            throw new NotImplementedException();
        }

        public void Supprimer(int id)
        {
            throw new NotImplementedException();
        }
    }
}
