using System.Diagnostics;
using System.Linq.Expressions;

namespace Ovning_List_Dictionary_26_09_16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Country cy1 = new Country("SVERIGE","SE","Stockholm");
            Country cy2 = new Country("DANMARK", "DK", "Köpenhamn");
            Country cy3 = new Country("FINLAND", "FI", "Helsingfors");
            Country cy4 = new Country("NORGE", "NO", "Oslo");
            Country cy5 = new Country("TYSKLAND", "DE", "Berlin");

            List<Country> listCountry = new List<Country>();
            listCountry.Add(cy1);
            listCountry.Add(cy2);
            listCountry.Add(cy3);
            listCountry.Add(cy4);
            listCountry.Add(cy5);

            bool kör = true;
            while (kör == true)
            {
                Console.Write("Ange en landskod (t ex SE): ");
                string userCyKod = Console.ReadLine().ToUpper();

                if (userCyKod.Length == 2)
                    if (listCountry.Exists(e => e.Kod == userCyKod))
                    {
                        Country c = listCountry.Find(e => e.Kod == userCyKod);
                        Console.WriteLine($"Landet finns med i listan: " +
                            $"\nNamn: {c.Namn}" +
                            $"\nKod: {c.Kod}" +
                            $"\nHuvudstad: {c.Huvudstad}");
                    }
                    else
                    {
                        Console.WriteLine("Landet finns inte med i listan!");
                    }
                else
                {
                    Console.WriteLine("Landskoden måste vara 2 bokstäver, t ex SE för Sverige.");
                }
                Console.WriteLine();
                
                while(true)
                {
                    Console.Write("Vill du fortsätta? ");
                    string again = Console.ReadLine().ToUpper();
                    if (again == "JA")
                    {
                        Console.WriteLine("Vi kör igen!");
                        break;
                    }
                    else if (again == "NEJ")
                    {
                        Console.WriteLine("Programmet avslutas.");
                        kör = false;
                        break;
                    }
                    else
                        Console.WriteLine("Du måste ange Ja eller Nej för att gå vidare. Försök igen!");
                    break;
                }
            }

            //- [ ]  Vi ska skapa Dictionary av samma klassen Country , med key och value.
            // - []  Vi ska skriva ut samma meddelande till användare för att mata in Country kod och gå genom samma process.
        }
    }
}
