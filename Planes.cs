using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Katastrofy
{
    class Planes
    {

        private string name;
        private string type;
        private int number; // number of passangers
        private int distance;
        private string size;
        private List<Catastroph> disasters = new List<Catastroph>();

        public Planes(string name, string type, string size, int number, int distance)
        {
            this.name = name;
            this.type = type;
            this.size = size;
            this.number = number;
            this.distance = distance;

        }
        public void ShowDisasters()
        {
            int i = 0;
            foreach (var n in disasters)
            {
                i++;
                Console.WriteLine(i + ". " + n.Year + " - " + n.Deaths + " ofiar");
            }
        }

       
        public void showPlanes(string name, string type, int number, int distance, string size)

        {
            Console.WriteLine( "Name: " + name+ "Type: " + type + "Size: " + size+  "Number of passangers: " + number + "Distance: " + distance);

        }

       
       

        public string Name { get => name; }
        public string Type { get => type; }
        public int  Number { get => number; }
        public int Distance { get => distance; }
        public string Size { get => size; }
        public List<Catastroph> Disasters { get => disasters; }

    }
}
