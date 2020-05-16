using cryptinopIDP.DAL.Repositories;

namespace cryptinopIDP.DAL.UnityOfWork
{
    public interface IUnitOfWork
    {
         IUtilisateursRepo UtilisateursRepo { get; set; }

         IRolesRepo RolesRepo { get; set; }

         IAdressesRepo AdressesRepo { get; set; }

         ICoordonneeRepo CoordonneesRepo { get; set; }

         int Persister();
    }
}