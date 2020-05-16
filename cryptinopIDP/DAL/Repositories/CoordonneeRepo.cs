using System;
using System.Collections.Generic;
using System.Linq;
using cryptinopIDP.DAL.Context;
using cryptinopIDP.Models;

namespace cryptinopIDP.DAL.Repositories
{
    public class CoordonneeRepo: ICoordonneeRepo
    {
        private CryptinopUsersContext _context;

        public CoordonneeRepo(CryptinopUsersContext context)
        {
            _context = context;
        }

        public void Ajouter(Coordonnee coordonnee)
        {
            _context.Coordonnees.Add(coordonnee);
        }

        public void Modifier(Coordonnee coordonnee)
        {
            Coordonnee c = _context.Coordonnees.FirstOrDefault(c => c.Id == coordonnee.Id);

            if (c != null)
            {
                c = coordonnee;
            }
        }

        public IEnumerable<Coordonnee> Obtenir()
        {
            return _context.Coordonnees.ToList();
        }

        public Coordonnee Obtenir(int id)
        {
            return _context.Coordonnees.FirstOrDefault(coordonnee => coordonnee.Id == id);
        }

        public void Supprimer(int id)
        {
            Coordonnee c = _context.Coordonnees.FirstOrDefault(c => c.Id == id);

            if (c != null)
            {
                _context.Coordonnees.Remove(c);
            }
        }
    }
}
