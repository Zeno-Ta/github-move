using System;
namespace cryptinopAPI.Models
{
    public class Monnaie : IMonnaie
    {
        public int Id { get; set; }
        public string  Nom { get; set; }
        public string Code { get; set; }
        public string Valeur { get; set; }

    }
}
