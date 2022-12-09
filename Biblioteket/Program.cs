using Biblioteket;

namespace biblioteket;

class Program
{
    public static void Main()
    {
        Console.Clear();
        bool boolean = true;
        Bibliotek bib = new Bibliotek("Phillips super mega seje bibliotek"); // Opretter nyt bibliotek


        while (boolean == true) //Starter nyt boolean loop
        {
            //Menu VV
            Console.WriteLine(" ----------------------------------");
            Console.WriteLine("| Du kan vælge følgende:           |");
            Console.WriteLine("| 1. Vis bibliotekets navn og dato |");
            Console.WriteLine("| 2. Opret låner                   |");
            Console.WriteLine("| 3. Udskriv lånere                |");
            Console.WriteLine("| 4. Afslut                        |");
            Console.WriteLine(" ----------------------------------");
            Console.Write("Indtast her: ");
            
            int input = Convert.ToInt32(Console.ReadLine()); //Input til switchcase
            string tilbage = "\nTryk enter for at gå tilbage";
            switch (input) // Switchcase til min menu
            {
                case 1: // Viser bibliotek navn og dato
                    Console.Clear();
                    Console.WriteLine(bib.HentBibliotek());
                    Console.WriteLine($"{tilbage}");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case 2: // Opretter ny låner
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
                case 3: // Udskriver alle lånere
                    Console.Clear();
                    Console.WriteLine(bib.HentAlleLaanere());
                    Console.WriteLine($"\n{tilbage}");
                    Console.ReadKey();
                    Console.Clear();


                    break;
                case 4: // Slutter programmet
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