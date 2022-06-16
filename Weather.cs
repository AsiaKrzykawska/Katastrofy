using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Katastrofy
{
    class Weather : Catastroph
    {
        private int temp;
        private int wspeed;
        private string rain;
        private string ice;

        public Weather(int temp, int wspeed, string rain, string ice, int year, string type, string airlines, string country, int deaths, string causes)
        {
            this.year = year;
            this.type = type;
            this.airlines = airlines;
            this.country = country;
            this.deaths = deaths;
            this.causes = causes;
            this.temp = temp;
            this.wspeed = wspeed;
            this.rain = rain;
            this.ice = ice; 
        }

        public override void print()
        {
            Console.WriteLine("Year: " + year + "Type: " + type + "Airlines: " + airlines + "Country: " + country + "Number of deaths:  " + deaths + "Causes: " + causes + "Temp: " + temp + "Wind speed: " + wspeed+ " Ice: " + ice + "Rain: "+ rain);
        }

        public int Temp { get => temp; set => temp = value; }
        public int Wspeed{ get => wspeed; set => wspeed = value; }
        public string Ice { get => ice; set => ice = value; }
        public string Rain { get => rain; set => rain = value; }
        
    }
}
