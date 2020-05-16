using System;
namespace cryptinopIDP.Models
{
    public class Utilisateur
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string  Prenom { get; set; }
        public char  Sexe { get; set; }
        public DateTime DateNaissance { get; set; }
        public string Login { get; set; }
        public string MDP { get; set; }
        public Adresse Adresse { get; set; }
        public Role Role { get; set; }
        public Coordonnee Coordonnee { get; set; }
    }
}
