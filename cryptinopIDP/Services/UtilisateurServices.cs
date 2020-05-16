using System;
using System.Collections.Generic;
using cryptinopIDP.DAL.UnityOfWork;
using cryptinopIDP.Models;

namespace cryptinopIDP.Services
{
    public class UtilisateurServices: IUtilisateurServices
    {
        private IUnitOfWork _unitOfWork;

        public UtilisateurServices(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public void Ajouter(Utilisateur utilisateur)
        {
            _unitOfWork.UtilisateursRepo.Ajouter(utilisateur);
            _unitOfWork.Persister();
        }

        public void Modifier(Utilisateur utilisateur)
        {
            _unitOfWork.UtilisateursRepo.Modifier(utilisateur);
            _unitOfWork.Persister();
        }

        public IEnumerable<Utilisateur> Obtenir()
        {
            return _unitOfWork.UtilisateursRepo.Obtenir();
        }

        public Utilisateur Obtenir(int id)
        {
            return _unitOfWork.UtilisateursRepo.Obtenir(id);
        }

        public void Supprimer(int id)
        {
            _unitOfWork.UtilisateursRepo.Supprimer(id);
            _unitOfWork.Persister();
        }
    }
}
