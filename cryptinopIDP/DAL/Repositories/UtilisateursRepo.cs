using System;
using System.Collections.Generic;
using System.Linq;
using cryptinopIDP.DAL.Context;
using cryptinopIDP.Models;

namespace cryptinopIDP.DAL.Repositories
{
    public class UtilisateursRepo: IUtilisateursRepo
    {
        private CryptinopUsersContext _context;

        public UtilisateursRepo(CryptinopUsersContext context)
        {
            _context = context;
        }

        public void Ajouter(Utilisateur user)
        {
            _context.Utilisateurs.Add(user);
        }

        public void Modifier(Utilisateur user)
        {
            Utilisateur u = _context.Utilisateurs.FirstOrDefault(u => u.Id == user.Id);

            if (u != null)
            {
                u = user;
            }
        }

        public IEnumerable<Utilisateur> Obtenir()
        {
            return _context.Utilisateurs.ToList();
        }

        public Utilisateur Obtenir(int id)
        {
            return _context.Utilisateurs.FirstOrDefault(u => u.Id == id);
        }

        public void Supprimer(int id)
        {
            Utilisateur u = _context.Utilisateurs.FirstOrDefault(u => u.Id == id);

            if (u != null)
            {
                _context.Utilisateurs.Remove(u);
            }
        }
    }
}
