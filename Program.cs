using System.Diagnostics;
using System.Linq.Expressions;
using Ovning_List_Dictionary_26_09_16.Classes;

namespace Ovning_List_Dictionary_26_09_16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // We add 5 object to our class Country
            Country cy1 = new Country("SVERIGE","SE","Stockholm");
            Country cy2 = new Country("DANMARK", "DK", "Köpenhamn");
            Country cy3 = new Country("FINLAND", "FI", "Helsingfors");
            Country cy4 = new Country("NORGE", "NO", "Oslo");
            Country cy5 = new Country("TYSKLAND", "DE", "Berlin");

            // We add our new object to listCountry
            List<Country> listCountry = new List<Country>();
            listCountry.Add(cy1);
            listCountry.Add(cy2);
            listCountry.Add(cy3);
            listCountry.Add(cy4);
            listCountry.Add(cy5);

            // We start the program with StartList, which runs the FindList method with our list to ask the user for a country code and print the info if it exists
            // If the country code doesn't exist we give the user the option to try again with our GoAagain method,
            // or exit the program
            // FindList is located inside our method to print a message before we start the program
            Country.StartList(listCountry);

            // We add our object t dictCountry here
            Dictionary<string,Country> dictCountry = new Dictionary<string,Country>();
            dictCountry.Add("SE", cy1);
            dictCountry.Add("DK", cy2);
            dictCountry.Add("FI", cy3);
            dictCountry.Add("NO", cy4);
            dictCountry.Add("DE", cy5);

            // We start the program with StartDict, which runs FindDict to check the user input for matches in our dictionary
            // and print the countyr if found, and return an failure message if it isn't in the dictionary
            // We use GoAgain to check if the user want to run the program again or quit 
            Country.StartDict(dictCountry);

        }
    }
}
