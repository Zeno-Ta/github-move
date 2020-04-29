using System;
namespace cryptinopAPI.Models
{
    public class TypeCategorie: ITypeCategorie
    {
        public int Id { get; set; }

        public string Nom { get; set; }

        public string Description { get; set; }

        public CategorieActivite Categorie { get; set; }
    }
}
