using System;
namespace cryptinopAPI.Models
{
    public class CategorieActivite: ICategorieActivite
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Description { get; set; }
    }
}
