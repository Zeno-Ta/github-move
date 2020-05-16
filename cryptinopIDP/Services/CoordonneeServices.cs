using System;
using System.Collections.Generic;
using cryptinopIDP.DAL.UnityOfWork;
using cryptinopIDP.Models;

namespace cryptinopIDP.Services
{
    public class CoordonneeServices:ICoordonneeServices
    {
        private IUnitOfWork _unitOfWork;

        public CoordonneeServices(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public void Ajouter(Coordonnee coordonnee)
        {
            _unitOfWork.CoordonneesRepo.Ajouter(coordonnee);
            _unitOfWork.Persister();
        }

        public void Modifier(Coordonnee role)
        {
            _unitOfWork.CoordonneesRepo.Modifier(role);
            _unitOfWork.Persister();
        }

        public IEnumerable<Coordonnee> Obtenir()
        {
            return _unitOfWork.CoordonneesRepo.Obtenir();
        }

        public Coordonnee Obtenir(int id)
        {
            return _unitOfWork.CoordonneesRepo.Obtenir(id);
        }

        public void Supprimer(int id)
        {
            _unitOfWork.CoordonneesRepo.Supprimer(id);
            _unitOfWork.Persister();
        }
    }
}
