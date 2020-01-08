using System;
using System.Collections.Generic;
using System.Text;

namespace Mediatheque
{
    public class IHMMediatheque
    {
        private Bibliotheque bibliotheque;
        public void Start()
        {
            Console.Write("Nom hotel : ");
            string nom = Console.ReadLine();
            bibliotheque = new Bibliotheque(nom);
            string choix;
            do
            {
                MenuBibliotheque();
                choix = Console.ReadLine();
                switch (choix)
                {
                    case "1":
                        break;
                    case "2":
                        break;
                    case "3":
                        break;
                    case "4":
                        break;
                }
            }
            while (choix != "0");
        }

        private void MenuBibliotheque()
        {
            Console.WriteLine("1---Ajouter un adhérent");
            Console.WriteLine("2---Ajouter un client");
            Console.WriteLine("3---Emprunter une oeuvre");
            Console.WriteLine("4---Rendre une oeuvre");
        }

        private Oeuvre AjouterOeuvre(Oeuvre o)
        {
            Console.WriteLine("Quel est le nom de l'oeuvre ?");
            string titre = Console.ReadLine();
            Console.WriteLine("Qui est l'auteur ?");
            string auteur = Console.ReadLine();
            Console.WriteLine("Qui est l'editeur ?");
            string editeur = Console.ReadLine();
            Console.WriteLine("Quel est le resumé de l'oeuvre ?");
            string resume = Console.ReadLine();
            Console.WriteLine("Combien d'exemplaire ?");
            int nbexemplaire = Convert.ToInt32(Console.ReadLine());
            bibliotheque.AjouterOeuvre(o);
            return o;
        }

        private Adherent AjouterAdherent(Adherent a)
        {
            Console.WriteLine("Quel est votre nom ?");
            string nom = Console.ReadLine();
            Console.WriteLine("Quel est votre prénom ?");
            string prenom = Console.ReadLine();
            bibliotheque.AjouterAdherent(a);
            return a;
        }

        private void EmprunterOeuvre()
        {
            if (bibliotheque)
            {

            }
        }

        private void RendreOeuvre()
        {

        }
    }
