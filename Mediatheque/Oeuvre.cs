using System;
using System.Collections.Generic;
using System.Text;

namespace Mediatheque
{
    class Oeuvre
    {
        private string titre;
        private string auteur;
        private string editeur;
        private string resume;

        private int nbexemplaire;



        public string Titre { get => titre; set => titre = value; }
        public string Auteur { get => auteur; set => auteur = value; }
        public string Editeur { get => editeur; set => editeur = value; }
        public string Resume { get => resume; set => resume = value; }
        public int Nbexemplaire { get => nbexemplaire; set => nbexemplaire = value; }


        public Oeuvre (string titre, string auteur, string editeur, string resume, int nbexemplaire)
        {

            Titre = titre;
            Auteur = auteur;
            Editeur = editeur;
            Resume = resume;
            Nbexemplaire = nbexemplaire;
        }
    }
}
