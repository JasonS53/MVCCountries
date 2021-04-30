using System;
using System.Collections.Generic;
using System.Text;

namespace MVC_Countries
{
    class CountryView
    {
        //field 
        private Country _displayCountry;

        //property
        public Country DisplayCountry
        {
           get { return this._displayCountry; }
           set { this._displayCountry = value; }
        }

        //constructor
        public CountryView (Country country)
        {
            this._displayCountry = country;
        }

        //method
        public void Display()
        {            
            Console.WriteLine($"{_displayCountry.Name}\t\t{_displayCountry.Continent}\t\t{string.Join(",", _displayCountry.Colours)}");
        }
    }   
}
