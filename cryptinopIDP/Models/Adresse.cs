using System;
namespace cryptinopIDP.Models
{
    public class Adresse
    {
        public int Id { get; set; }
        public string Pays { get; set; }
        public string Province { get; set; }
        public string Ville { get; set; }
        public string  Rue { get; set; }
        public string NumeroCivique { get; set; }
        public string CodePostal { get; set; }

    }
}
