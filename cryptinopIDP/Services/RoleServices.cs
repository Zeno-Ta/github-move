using System;
using System.Collections.Generic;
using cryptinopIDP.DAL.UnityOfWork;
using cryptinopIDP.Models;

namespace cryptinopIDP.Services
{
    public class RoleServices : IRoleServices
    {
        private IUnitOfWork _unitOfWork;

        public RoleServices(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public void Ajouter(Role role)
        {
            _unitOfWork.RolesRepo.Ajouter(role);
            _unitOfWork.Persister();
        }

        public void Modifier(Role role)
        {
            _unitOfWork.RolesRepo.Modifier(role);
            _unitOfWork.Persister();
        }

        public IEnumerable<Role> Obtenir()
        {
            return _unitOfWork.RolesRepo.Obtenir();
        }

        public Role Obtenir(int id)
        {
            return _unitOfWork.RolesRepo.Obtenir(id);
        }

        public void Supprimer(int id)
        {
            _unitOfWork.RolesRepo.Supprimer(id);
            _unitOfWork.Persister();
        }
    }
}
