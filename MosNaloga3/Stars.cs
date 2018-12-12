using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MosNaloga3
{
    class Vozlisce
    {
        public string ime;
        public double vrednost;
        public List<Vozlisce> otroci = new List<Vozlisce>();

        public Vozlisce(string ime, double vrednost)
        {
            this.ime = ime;
            this.vrednost = vrednost;
        }
    }
}
