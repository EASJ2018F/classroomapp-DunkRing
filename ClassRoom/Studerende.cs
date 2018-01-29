using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    public class Studerende
    {
        private string _navn;
        private int _fødselsmåned;
        private int _fødselsdag;

        public Studerende(string Navn, int Fødselsmåned, int Fødselsdag)
        {
            Navn = _navn;
            Fødselsmåned = _fødselsmåned;
            Fødselsdag = _fødselsdag;
        }

        public string Navn { get; set; }
        public int Fødselsmåned { get; set; }
        public int Fødselsdag { get; set; }
    }
}
