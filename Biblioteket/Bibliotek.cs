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
        List<Laaner> laanere;

        public Bibliotek(string navn)
        {
            laanere = new List<Laaner>();
            _biblioteksNavn = navn;
        }
        public string HentBibliotek()
        {
            return $"Velkommen til {_biblioteksNavn} - datoen er idag {DateTime.Today}";
        }

        public void OpretLaaner(int laanerNummer, string navn)
        {
            laanere.Add(new Laaner(laanerNummer, navn));
        }
        public string HentLaaner(int id)
        {
            return $"Lånernummer: {laanere[id]._laanerNummer} - Navn: {laanere[id]._navn} er låner hos {_biblioteksNavn}";
        }
    }
}
