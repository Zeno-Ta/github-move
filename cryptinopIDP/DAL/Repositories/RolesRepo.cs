using System;
using System.Collections.Generic;
using System.Linq;
using cryptinopIDP.DAL.Context;
using cryptinopIDP.Models;

namespace cryptinopIDP.DAL.Repositories
{
    public class RolesRepo : IRolesRepo
    {
        private CryptinopUsersContext _context;

        public RolesRepo(CryptinopUsersContext context)
        {
            _context = context;
        }

        public void Ajouter(Role role)
        {
            _context.Roles.Add(role);
        }

        public void Modifier(Role role)
        {
            Role r = _context.Roles.FirstOrDefault(r => r.Id == role.Id);

            if (r != null)
            {
                r = role;
            }
        }

        public IEnumerable<Role> Obtenir()
        {
            return _context.Roles.ToList();
        }

        public Role Obtenir(int id)
        {
            return _context.Roles.FirstOrDefault(role => role.Id == id);
        }

        public void Supprimer(int id)
        {
            Role r = _context.Roles.FirstOrDefault(r => r.Id == id);

            if (r != null)
            {
                _context.Roles.Remove(r);
            }
        }
    }
}
