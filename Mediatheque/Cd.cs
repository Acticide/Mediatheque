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
    }
}
