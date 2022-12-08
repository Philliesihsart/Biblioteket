using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        int number;

        public Bibliotek(string navn)
        {
            laanere = new List<Laaner>();
            _biblioteksNavn = navn;
            number = 0;
        }
        public string HentBibliotek()
        {
            return $"Velkommen til {_biblioteksNavn} - datoen er idag {DateTime.Now.ToShortDateString()}";
        }

        public void OpretLaaner(string navn, string email)
        {
            laanere.Add(new Laaner(++number, navn, email));
        }
        public string HentLaaner(int id)
        {
            return $"Lånernummer: {laanere[id]._laanerNummer} - Navn: {laanere[id]._navn} er låner hos {_biblioteksNavn}";
        }
        public string HentAlleLaanere()
        {
            string alleLaanere = "";
            foreach (Laaner laaner in laanere)
            {
                alleLaanere += $"Lånernummer: {laaner._laanerNummer} - Navn: {laaner._navn} Email: {laaner._email} er låner hos {_biblioteksNavn}\n";
            }
            return alleLaanere;
        }
    }
}
