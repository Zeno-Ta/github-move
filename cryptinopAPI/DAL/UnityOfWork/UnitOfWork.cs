using System;
using cryptinopAPI.DAL.Context;
using cryptinopAPI.DAL.Repositories;

namespace cryptinopAPI.DAL.UnityOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        public IMonnaieRepo MonnaieRepo { get; set; }

        public ICategorieActRepo CategorieActRepo { get; set; }

        public ITypeCategorieRepo TypeCategorieRepo { get; set; }

        public IValMonnaieRepo valMonnaieRepo { get; set; }


        CryptinopContext _context;

        public UnitOfWork(CryptinopContext context)
        {
            _context = context;
        }

        public int Persister()
        {
            return _context.SaveChanges();
        }
    }
}
