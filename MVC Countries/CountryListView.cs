using System;
using System.Collections.Generic;
using System.Text;

namespace MVC_Countries
{
    class CountryListView
    {
        //fields
        private List<Country> _countries;

        //properties
        public List<Country> Countries
        {
            get { return this._countries; }
            set { this._countries = value; }
        }
        //Constructor
        public CountryListView (List<Country> countries)
        {
            this._countries = countries;
        }

        //Methods
        public void Display()
        {
            int counter = 1;
            foreach (Country country in this._countries)
            {
                Console.WriteLine($"{counter}. {country.Name}");
                counter++;
            }
        }
    }
}
