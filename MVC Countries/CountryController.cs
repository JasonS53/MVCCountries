using System;
using System.Collections.Generic;
using System.Text;

namespace MVC_Countries
{
    //Controller
    class CountryController
    {       
        //fields
        private List<Country> _countryDb = new List<Country>
        {          
            new Country ("Canada", "North America", new List<string> {"Red","White"}),
            new Country ("Haiti", "North America", new List<string> {"Red","Blue"}),
            new Country ("Finland", "Europe",new List<string> {"Light Blue","White"}),
            new Country ("Liechtenstein", "Europe", new List<string> {"Red","Blue"}),
            new Country ("Zimbabwe", "Africa", new List<string>{"Green","Yellow","Red"}),
            new Country ("Liberia", "Africa", new List<string>{"Red","White","Blue"}),
            new Country ("Brazil", "South America", new List<string>{"Green","Yellow","Blue"}),
            new Country ("Guyana", "South America", new List<string>{"Green","Yellow","Red"}),
            new Country ("Hong Kong", "Asia", new List<string>{"Red","White"}),
            new Country ("India", "Asia", new List<string>{"Green","White","Orange"}),
            new Country ("Fiji", "Oceana", new List<string>{"Light Blue","Red"}),
            new Country ("Kiribati", "Oceana", new List<string>{"Red","Blue","Yellow"})

        };

        

        //properties
        public List<Country> CountryDb
        {
            get { return this._countryDb; }
            set { this._countryDb = value; }
        }

        //Constructor

        public void CountryAction(Country c)
        {
            CountryView cView = new CountryView(c);
            cView.Display();
        }
        
        public void WelcomeAction()
        {
            bool RunProgram = true;
            while (RunProgram)
            {
                CountryListView cListView = new CountryListView(_countryDb);
                Console.WriteLine("Hello, welcome to the country app.  Please select a country from the following list:");
                cListView.Display();
                int choice = 0;
                try
                {
                    choice = int.Parse(Console.ReadLine());
                    if (choice <= 0 || choice > _countryDb.Count)
                    {
                        Console.WriteLine("Please choose a number on the list");
                        continue;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("That was not a valid entry");
                    continue;
                }
                Console.WriteLine();
                CountryAction(_countryDb[choice - 1]);
                Console.WriteLine();
                Console.WriteLine("Would you like to learn about another country? y/n");
                                
                while (true)                
                {
                    string yesno = Console.ReadLine().ToLower().Trim();
                    if (yesno == "y")
                    {
                        Console.Clear();
                        break;
                    }
                    else if (yesno == "n")
                    {
                        Console.WriteLine("Have a good day.");
                        RunProgram = false;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("That was an invalid entry.");                        
                    }
                }
            }
        }
    }
}
