using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteket
{
    internal class Bibliotek
    {
        string _biblioteksNavn;

        public Bibliotek(string navn)
        {
            _biblioteksNavn = navn;    
        }
        public string HentBibliotek()
        {
            return $"Velkommen til {_biblioteksNavn} - datoen er idag {DateTime.Today}"; 
        }
    }
}
