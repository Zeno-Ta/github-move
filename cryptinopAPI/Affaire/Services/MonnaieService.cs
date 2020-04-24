using System;
using cryptinopAPI.Models;
using cryptinopAPI.DAL.UnityOfWork;

namespace cryptinopAPI.Affaire.Services
{
    public class MonnaieService : IMonnaieService
    {
        readonly IUnitOfWork _unitOfWork;

        public MonnaieService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public void Enregistrer(IMonnaie monnaie)
        {
            _unitOfWork.MonnaieRepo.Ajouter(monnaie);
            _unitOfWork.Persister();
        }
        public void Modifier(IMonnaie monnaie)
        {
            _unitOfWork.MonnaieRepo.Modifier(monnaie);
            _unitOfWork.Persister();
        }
        public void Supprimer()
        {

        }
        public IMonnaie Obtenir(int IdMonnaie)
        {
            return null;
        }
    }
}
