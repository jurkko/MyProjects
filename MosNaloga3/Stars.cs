using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MosNaloga3
{
    class Stars
    {
        public string ime;
        public double vrednost;
        public List<Stars> otroci = new List<Stars>();

        public Stars(string ime, double vrednost)
        {
            this.ime = ime;
            this.vrednost = vrednost;
        }
    }
}
