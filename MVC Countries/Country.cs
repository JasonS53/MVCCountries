using System;
using System.Collections.Generic;
using System.Text;

namespace MVC_Countries
{
    //Model
    class Country
    {
        //fields
        private string _name;
        private string _continent;
        private List<string> _colours = new List<string>();

        //properties
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        public string Continent
        {
            get { return this._continent; }
            set { this._continent = value; }
        }

        public List<string> Colours
        {
            get { return this._colours; }
            set { this._colours = value; }
        }
        //Constructor
        public Country (string name, string continent, List <string> colours)
        {
            this._name = name;
            this._continent = continent;
            this._colours = colours;
        }
    }
}
