using System;
using System.Collections.Generic;
using cryptinopIDP.DAL.UnityOfWork;
using cryptinopIDP.Models;

namespace cryptinopIDP.Services
{
    public class AdresseServices: IAdresseServices
    {
        private IUnitOfWork _unitOfWork;

        public AdresseServices(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public void Ajouter(Adresse adresse)
        {
            _unitOfWork.AdressesRepo.Ajouter(adresse);
            _unitOfWork.Persister();
        }

        public void Modifier(Adresse adresse)
        {
            _unitOfWork.AdressesRepo.Modifier(adresse);
            _unitOfWork.Persister();
        }

        public IEnumerable<Adresse> Obtenir()
        {
            return _unitOfWork.AdressesRepo.Obtenir();
        }

        public Adresse Obtenir(int id)
        {
            return _unitOfWork.AdressesRepo.Obtenir(id);
        }

        public void Supprimer(int id)
        {
            _unitOfWork.AdressesRepo.Supprimer(id);
            _unitOfWork.Persister();
        }
    }
}
