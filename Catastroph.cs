using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Katastrofy
{
    abstract class Catastroph
    {
        protected int year;
        protected string type;
        protected string airlines;
        protected string country;
        protected int deaths;
        protected string causes;
       /* private List<Planes> plane = new List<Planes>();
        protected List<string> story = new List<string>(); */
        protected Catastroph()
        {

        }
        protected Catastroph(int year, string type, string airlines, string country, int deaths, string causes)
        {
            this.year = year;
            this.type = type;
            this.airlines = airlines;
            this.country = country;
            this.deaths = deaths;
            this.causes = causes;
           /* story.Add("Catastroph took place in" + year + " Plane was" + type + "by" + airlines + "in" + country + "Died " + deaths + "people " + "The causes were"
            + causes); */
        }
  
        
        public string Type { get => type; set => type = value; }
        public int Year { get => year; set => year = value; }
        public string Airlines { get => airlines; set => airlines = value; }
        public string Country { get => country; set => country = value; }
        public int Deaths { get => deaths; set => deaths = value; }
        public string Causes { get => causes; set => causes = value; }
        /*  protected List<Planes> Plane { get => plane; set => plane = value; } */

        
        public abstract void print();

    }
}

