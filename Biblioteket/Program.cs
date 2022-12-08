using Biblioteket;

namespace biblioteket;

class Program
{
    public static void Main()
    {

        Bibliotek bib = new Bibliotek("Phillips super mega seje bibliotek");
        Console.WriteLine(bib.HentBibliotek());
    }
}

