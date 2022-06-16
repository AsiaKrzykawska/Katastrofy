using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Katastrofy
{
    class TerroristsAttack : Catastroph
    {
        private string violator;

        public TerroristsAttack(string violator, int year, string type, string airlines, string country, int deaths, string causes)
        {
            this.year = year;
            this.type = type;
            this.airlines = airlines;
            this.country = country;
            this.deaths = deaths;
            this.causes = causes;
            this.violator = violator;

        }

        public string Violator { get => violator; set => violator = value; }
        public override void print()
        {
            Console.WriteLine("Year: " + year + "Type: " + type + "Airlines: " + airlines + "Country: " + country + "Number of deaths:  " + deaths + "Causes: " + causes+ "Violator: "+ violator );
        }


    }
}
