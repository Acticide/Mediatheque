using System;
using System.Collections.Generic;
using System.Text;

namespace Mediatheque
{
    public class Dvd : Oeuvre
    {
        public Dvd(string t,string a, string e, string r, int nbexemplaire) : base(t,a,e,r,nbexemplaire)
        {

        }

        public override void Afficher()
        {
            Console.WriteLine("Titre : " + Titre + " Auteur : " + Auteur + " Editeur : " + Editeur + " Resume : " + Resume + "Nombres d'exemplaire disponible : " + Nbexemplaire);
        }
    }
}
