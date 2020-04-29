namespace cryptinopAPI.Models
{
    public interface ITypeCategorie
    {
        int Id { get; set; }

        string Nom { get; set; }

        string Description { get; set; }

        CategorieActivite Categorie { get; set; }
    }
}