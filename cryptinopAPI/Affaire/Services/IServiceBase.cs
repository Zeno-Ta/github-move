using System;
using System.Collections.Generic;

namespace cryptinopAPI.Affaire.Services
{
    public interface IServiceBase<T> where T : class
    {
        void Ajouter(T obj);

        void Modifier(T obj);

        IEnumerable<T> Obtenir();

        T Obtenir(int id);

        void Supprimer(int id);
    }
}
