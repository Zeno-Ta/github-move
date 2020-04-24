using cryptinopAPI.Models;

namespace cryptinopAPI.Affaire.Services
{
    public interface IMonnaieService
    {
        void Enregistrer(IMonnaie monnaie);

        void Modifier(IMonnaie monnaie);

        IMonnaie Obtenir(int IdMonnaie);
    }
}