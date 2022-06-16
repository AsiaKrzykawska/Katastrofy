using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Katastrofy

{
    class MenuOption
    {
        private string name;
        private int number;

        public string Name { get => name; set => name = value; }
        public int Number { get => number; set => number = value; }

        public void printOption()
        {
            Console.WriteLine(Convert.ToString(number) + ". " + Name);
        }
    }
}