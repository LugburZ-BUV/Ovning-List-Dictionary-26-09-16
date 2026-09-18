using System;
using System.Collections.Generic;
using System.Text;

namespace Ovning_List_Dictionary_26_09_16
{
    public class Country
    {
        // Class Country with constructor
        public string Namn { get; set; }
        public string Kod { get; set; }
        public string Huvudstad { get; set; }

        // We use this constructor to add object to our class Country
        public Country(string name, string code, string capitol)
        {
            Namn = name;
            Kod = code;
            Huvudstad = capitol;
        }
        //public void PrintInfo()
        //{
        //    Console.WriteLine("")
        //}

        // We use this method to ask the user for a country code in the provided list
        // We verify the input and check it against our list
        // If the input is invalid the user will be asked to redo it
        // If the country exists we print the country info
        // We then ask the user if they want to go again with
        // GoAgain(), and verify the input before allowing the user to continue
        public static void FindList(List<Country> listCountry)
        {
            // We set the variable to true here to begin the loop
            bool kör = true;
            while (kör == true)
            {
                Console.Write("Ange en landskod (t ex SE): ");
                // We convert the user input to upper case before we check it against the list
                string userListKod = Console.ReadLine().ToUpper();

                // We make sure the user has only given us a 2 character string
                if (userListKod.Length == 2)
                {
                    // We check if the country e.Kod matches the userListKod
                    if (listCountry.Exists(e => e.Kod == userListKod))
                    {
                        // If the input code has a match we use the variable here to print the name, code, and capitol of that country
                        Country c = listCountry.Find(e => e.Kod == userListKod);
                        Console.WriteLine($"Landet finns med i listan!" +
                            $"\n--------------------" +
                            $"\nNamn: {c.Namn}" +
                            $"\nKod: {c.Kod}" +
                            $"\nHuvudstad: {c.Huvudstad}" +
                            $"\n--------------------");
                    }
                    else
                    {
                        // We print this message if the country code doesn't match
                        Console.WriteLine($"{userListKod} finns inte med i listan!");
                    }
                }
                else
                {
                    // We print this message if we don't get a valid 2 character string from the user
                    Console.WriteLine("Landskoden måste vara 2 bokstäver, t ex SE för Sverige.");
                }
                Console.WriteLine();
                // We run the GoAgain method to check if the user wants to continue or quit the program
                // It returns a bool that we save in the variable that controls the loop
                kör = GoAgain();
            }
        }
        public static void FindDict(Dictionary<string, Country> dictCountry)
        {
            // We set the variable to true here to begin the loop
            bool kör2 = true;
            while (kör2 == true)
            {
                Console.Write("Ange en landskod (t ex SE): ");
                // We convert the user input to upper case before we check it against the list
                string userDictKod = Console.ReadLine().ToUpper();

                // We make sure the user has only given us a 2 character string
                if (userDictKod.Length == 2)
                {
                    // We check if the key matches the user input
                    // which returns the Country as d
                    if (dictCountry.TryGetValue(userDictKod, out Country d))
                    {
                        // If it matches we use d to print out the information for that object
                        Console.WriteLine($"Landet finns med i dictionary!" +
                            $"\n--------------------" +
                            $"\nNamn: {d.Namn}" +
                            $"\nKod: {d.Kod}" +
                            $"\nHuvudstad: {d.Huvudstad}" +
                            $"\n--------------------");
                    }
                    else
                    {
                        // We print this message if the country code doesn't match
                        Console.WriteLine($"{userDictKod} finns inte med i vår dictionary!");
                    }
                }
                else
                {
                    // We print this message if we don't get a valid 2 character string from the user
                    Console.WriteLine("Landskoden måste vara 2 bokstäver, t ex SE för Sverige.");
                }
                Console.WriteLine();
                // We run the GoAgain method to check if the user wants to continue or quit the program
                // It returns a bool that we save in the variable that controls the loop
                kör2 = GoAgain();
            }
        }

        // This is the method to check if the user wants to go again or not
        // We verify the input before allowing the user to continue or to quit
        public static bool GoAgain()
        {
            while (true)
            {
                Console.Write("Vill du fortsätta? ");
                // We check the user input here and convert it to upper case
                string again = Console.ReadLine().ToUpper();
                if (again == "JA")
                {
                    // If yes we print this message and return true
                    Console.WriteLine("Vi kör igen!");
                    return true;
                }
                if (again == "NEJ")
                {
                    // If no we print this message and return false
                    Console.WriteLine("Programmet avslutas..." +
                        "\n");
                    return false;
                }
                // If the input isn't "JA" or "NEJ" we print this message, and the loop runs again
                Console.WriteLine("Du måste ange Ja eller Nej för att gå vidare. Försök igen!");
            }
        }
        // We use this method to start the program that checks our list against the user input
        public static void StartList(List<Country> listC)
        {
            Console.WriteLine("Startar program CountryList..." +
                "\n--------------------");
            FindList(listC);
        }

        // We use this method to start the program that checks our dictionary against the user input
        public static void StartDict(Dictionary<string, Country> dictC)
        {
            Console.WriteLine("Startar program CountryDict..." +
                "\n--------------------");
            FindDict(dictC);
        }
    }
}
