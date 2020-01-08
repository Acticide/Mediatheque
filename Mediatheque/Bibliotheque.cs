using System;
using System.Collections.Generic;
using System.Text;

namespace Mediatheque
{
    public class Bibliotheque
    {
        private string nom;
        private List<Oeuvre> oeuvres;
        private List<Adherent> adherents;

        public List<Oeuvre> Oeuvres { get => oeuvres; set => oeuvres = value; }
        public List<Adherent> Adherents { get => adherents; set => adherents = value; }
        public string Nom { get => nom; set => nom = value; }

        public Bibliotheque(string nom)
        {
            Nom = nom;
            Oeuvres = new List<Oeuvre>();
            Adherents = new List<Adherent>();
        }

        public void AjouterOeuvre(Oeuvre o)
        {
            Oeuvres.Add(o);
        }

        public void AjouterAdherent(Adherent a)
        {
            Adherents.Add(a);
        }
    }
}
