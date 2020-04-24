using cryptinopAPI.DAL.Repositories;

namespace cryptinopAPI.DAL.UnityOfWork
{
    public interface IUnitOfWork
    {
        IMonnaieRepo MonnaieRepo { get; set; }

        int Persister();
    }
}