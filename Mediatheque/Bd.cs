using System;
using System.Collections.Generic;
using System.Text;

namespace Mediatheque
{
    public class Bd : Oeuvre
    {
        string dessinateur;

        public string Dessinateur { get => dessinateur; set => dessinateur = value; }

        public Bd(string t, string a, string e, string r, int nbexemplaire, string d) : base(t,a,e,r,nbexemplaire)
        {
            Dessinateur = d;
        }

        public override void Afficher()
        {
            Console.WriteLine("Titre : " + Titre + " Auteur : " + Auteur + " Editeur : " + Editeur + " Dessinateur : " + Dessinateur + " Resume : " + Resume + "Nombres d'exemplaire disponible : " + Nbexemplaire);
        }
    }
}
