using System;
using System.Collections.Generic;
using System.Text;

namespace Mediatheque
{
    public class Adherent
    {
        protected static int compteur = 0;
        private int id;
        private string nom;
        private string prenom;

        public int Id { get => id; set => id = value; }
        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }

        public Adherent(string nom, string prenom, int id)
        {
            compteur++;
            Id = compteur;
            Nom = nom;
            Prenom = prenom;
        }

    }
}
