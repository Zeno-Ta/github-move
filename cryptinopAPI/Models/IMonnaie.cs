namespace cryptinopAPI.Models
{
    public interface IMonnaie
    {
         int Id { get; set; }

         string Nom { get; set; }

         string Code { get; set; }

         TypeCategorie Type { get; set; }

         string Description { get; set; }

    }
}