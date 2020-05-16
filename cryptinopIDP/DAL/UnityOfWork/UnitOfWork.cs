using System;
using cryptinopIDP.DAL.Context;
using cryptinopIDP.DAL.Repositories;

namespace cryptinopIDP.DAL.UnityOfWork
{
    public class UnitOfWork: IUnitOfWork
    {
        public IUtilisateursRepo UtilisateursRepo { get; set; }

        public IRolesRepo RolesRepo { get; set; }

        public IAdressesRepo AdressesRepo { get; set; } 

        private CryptinopUsersContext _context;

        public UnitOfWork(CryptinopUsersContext context)
        {
            _context = context;
        }

        public int Persister()
        {
            return _context.SaveChanges();
        }
    }
}
