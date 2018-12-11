using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MosNaloga3
{
    class Alternativa
    {
        public string ime;
        public List<double> vrednosti = new List<double>();

        public Alternativa(string ime, List<double> vrednosti)
        {
            this.ime = ime;
            this.vrednosti = vrednosti;
        }
    }
}
