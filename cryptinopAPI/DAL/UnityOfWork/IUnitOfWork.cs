using cryptinopAPI.DAL.Repositories;

namespace cryptinopAPI.DAL.UnityOfWork
{
    public interface IUnitOfWork
    {
        IMonnaieRepo MonnaieRepo { get; set; }

        ICategorieActRepo CategorieActRepo { get; set; }

        ITypeCategorieRepo TypeCategorieRepo { get; set; }

        IValMonnaieRepo valMonnaieRepo { get; set; }

        int Persister();
    }
}