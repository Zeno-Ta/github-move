using cryptinopAPI.Models;

namespace cryptinopAPI.DAL.Repositories
{
    public interface IMonnaieRepo
    {
        void Ajouter(IMonnaie monnaie);

        void Modifier(IMonnaie monnaie);
    }
}