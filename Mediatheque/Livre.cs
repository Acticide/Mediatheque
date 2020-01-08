using System;
using System.Collections.Generic;
using System.Text;

namespace Mediatheque
{
    public class Livre : Oeuvre
    {
        private int nbpages;

        public int Nbpages { get => nbpages; set => nbpages = value; }

        public Livre(string t, string a, string e, string r, int nbexemplaire, int nbpages) : base(t, a, e, r, nbexemplaire)
        {
            Nbpages = nbpages;
        }
    }
}
