using System;
using System.Collections.Generic;
using System.Linq;
using cryptinopIDP.DAL.Context;
using cryptinopIDP.Models;

namespace cryptinopIDP.DAL.Repositories
{
    public class AdressesRepo : IAdressesRepo
    {
        private CryptinopUsersContext _context;

        public AdressesRepo(CryptinopUsersContext context)
        {
            _context = context;
        }

        public void Ajouter(Adresse adresse)
        {
            _context.Adresses.Add(adresse);
        }

        public void Modifier(Adresse adresse)
        {
            Adresse a = _context.Adresses.FirstOrDefault(a => a.Id == adresse.Id);

            if (a != null)
            {
                a = adresse;
            }
        }

        public IEnumerable<Adresse> Obtenir()
        {
            return _context.Adresses.ToList();
        }

        public Adresse Obtenir(int id)
        {
            return _context.Adresses.FirstOrDefault(a => a.Id == id);
        }

        public void Supprimer(int id)
        {
            Adresse u = _context.Adresses.FirstOrDefault(a => a.Id == id);

            if (u != null)
            {
                _context.Adresses.Remove(u);
            }
        }
    }
}
