using System;
using System.Linq;
using cryptinopAPI.DAL.Context;
using cryptinopAPI.Models;

namespace cryptinopAPI.DAL.Repositories
{
    public class MonnaieRepo: IMonnaieRepo
    {
        CryptinopContext _context;

        public MonnaieRepo(CryptinopContext context)
        {
            _context = context;
        }

        public void Ajouter(IMonnaie monnaie)
        {
            _context.Monnaies.Add((Monnaie)monnaie);
        }

        public void Modifier(IMonnaie monnaie)
        {
            IMonnaie m =_context.Monnaies.FirstOrDefault(x=>x.Id== monnaie.Id);

            if (m != null)
            {
                m = monnaie;
            }
            else
            {
                throw new Exception("Monnaie innexistant");
            }
        }
    }
}
