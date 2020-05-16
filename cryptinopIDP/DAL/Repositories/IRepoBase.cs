using System;
using System.Collections.Generic;

namespace cryptinopIDP.DAL.Repositories
{
    public interface IRepoBase<T> where T : class
    {
        void Ajouter(T obj);

        void Modifier(T obj);

        IEnumerable<T> Obtenir();

        T Obtenir(int id);

        void Supprimer(int id);
    }
}
