using Biblioteket;

namespace biblioteket;

class Program
{
    public static void Main()
    {
        Console.Clear();
        bool boolean = true;
        Bibliotek bib = new Bibliotek("Phillips super mega seje bibliotek");


        while (boolean == true)
        {
            Console.WriteLine(" ----------------------------------");
            Console.WriteLine("| Du kan vælge følgende:           |");
            Console.WriteLine("| 1. Vis bibliotekets navn og dato |");
            Console.WriteLine("| 2. Opret låner                   |");
            Console.WriteLine("| 3. Udskriv lånere                |");
            Console.WriteLine("| 4. Afslut                        |");
            Console.WriteLine(" ----------------------------------");
            Console.Write("Indtast her: ");

            int input = Convert.ToInt32(Console.ReadLine());
            string tilbage = "\nTryk enter for at gå tilbage";
            switch (input)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine(bib.HentBibliotek());
                    Console.WriteLine($"{tilbage}");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case 2:
                    Console.Clear();
                    Console.Write("Indtast venligt lånerenes navn: ");
                    string navn = Console.ReadLine();
                    Console.Write("Indtast email: ");
                    bib.OpretLaaner(navn, Console.ReadLine());
                    Console.Clear();
                    Console.WriteLine("Bruger er nu oprettet");
                    Console.WriteLine($"{tilbage}");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case 3:
                    Console.Clear();
                    Console.WriteLine(bib.HentAlleLaanere());
                    Console.WriteLine($"\n{tilbage}");
                    Console.ReadKey();
                    Console.Clear();


                    break;
                case 4:
                    boolean = false;
                    break;
                default:
                    Console.WriteLine("Fejl prøv igen");
                    Console.Clear();
                    break;
            }
        }






        Console.WriteLine(bib.HentLaaner(0));
    }
}