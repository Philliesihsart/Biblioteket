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

        public Bibliotek(string navn) // Min Constructor
        {
            laanere = new List<Laaner>();
            _biblioteksNavn = navn;
            number = 0;
        }
        public string HentBibliotek() // Henter biblioteks navnet
        {
            return $"Velkommen til {_biblioteksNavn} - datoen er idag {DateTime.Now.ToShortDateString()}";
        }

        public void OpretLaaner(string navn, string email) // Opretter en låner
        {
            laanere.Add(new Laaner(++number, navn, email));
        }
        public string HentLaaner(int id) //Henter en specifik låner
        {
            return $"Lånernummer: {laanere[id]._laanerNummer}\nNavn: {laanere[id]._navn} er låner hos {_biblioteksNavn}";
        }
        public string HentAlleLaanere() // Henter alle oprettet lånere
        {
            string alleLaanere = "";
            foreach (Laaner laaner in laanere)
            {
                alleLaanere += $"Lånernummer: {laaner._laanerNummer}\nNavn: {laaner._navn}\nEmail: {laaner._email}\n";
            }
            return alleLaanere;
        }
    }
}