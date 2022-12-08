using Biblioteket;

namespace biblioteket;

class Program
{
    public static void Main()
    {

        Bibliotek bib = new Bibliotek("Phillips super mega seje bibliotek");
        Console.WriteLine(bib.HentBibliotek());

        bib.OpretLaaner(1, "Phillip");
        bib.OpretLaaner(2, "Christian");
        bib.OpretLaaner(3, "Sander");

        Console.WriteLine(bib.HentLaaner(0));
    }
}

