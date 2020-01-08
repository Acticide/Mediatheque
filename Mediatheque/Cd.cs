using System;
using System.Collections.Generic;
using System.Text;

namespace Mediatheque
{
    public class Cd : Oeuvre
    {
        private int nbchanson;

        public int Nbchanson { get => nbchanson; set => nbchanson = value; }

        public Cd(string t, string a, string e, string r, int nbexemplaire, int nbchanson) : base(t,a,e,r,nbexemplaire)
        {
            Nbchanson = nbchanson;
        }

        public override void Afficher()
        {
            Console.WriteLine("Titre : " + Titre + " Auteur : " + Auteur + " Editeur : " + Editeur + " Resume : " + Resume + "Nombres d'exemplaire disponible : " + Nbexemplaire + " Nombre de chansons : " + Nbchanson);
        }
    }
}
