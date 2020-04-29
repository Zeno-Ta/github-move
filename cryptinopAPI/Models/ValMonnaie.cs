using System;
namespace cryptinopAPI.Models
{
    public class ValMonnaie: IValMonnaie
    {
        public int Id { get; set; }
        public int Rang { get; set; }
        public decimal Valeur { get; set; }
        public double Variation1H { get; set; }
        public double Variation24H { get; set; }
        public double Variation7Jrs { get; set; }
        public decimal Volume24H { get; set; }
        public decimal CapMarche { get; set; }
        public DateTime DateDernMAJ { get; set; }
        public Monnaie Monnaie { get; set; }

    }
}
