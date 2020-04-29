using System;

namespace cryptinopAPI.Models
{
    public interface IValMonnaie
    {
        int Id { get; set; }

        int Rang { get; set; }

        decimal Valeur { get; set; }

        double Variation1H { get; set; }

        double Variation24H { get; set; }

        double Variation7Jrs { get; set; }

        decimal Volume24H { get; set; }

        decimal CapMarche { get; set; }

        DateTime DateDernMAJ { get; set; }

        Monnaie Monnaie { get; set; }

    }
}