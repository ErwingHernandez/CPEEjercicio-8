using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPEEjercicio_8
{
    internal class Actor
    {
        string nom;
        string ape;

        public Actor(string nom, string ape)
        {
            this.Nom = nom;
            this.Ape = ape;
        }

        public string Nom { get => nom; set => nom = value; }
        public string Ape { get => ape; set => ape = value; }
    }
}
