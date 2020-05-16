using System;
using System.Collections.Generic;

namespace cryptinopIDP.Services
{
    public interface IServicesBase<T> where T : class
    {
        void Ajouter(T obj);

        void Modifier(T obj);

        IEnumerable<T> Obtenir();

        T Obtenir(int id);

        void Supprimer(int id);
    }
}
