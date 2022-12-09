using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteket
{
    internal class Laaner : Person // Nedarvning fra person
    {
        public int _laanerNummer { get; } // ReadOnly nummer

        public Laaner(int laanerNummer, string navn, string email): base(navn, email) // Constructor
        {
            _laanerNummer = laanerNummer;
            
        }
    }
}
