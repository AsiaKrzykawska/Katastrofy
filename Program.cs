using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Katastrofy
{
    class Program
    {
        

        static void Main(string[] args)

        {

            string n = "x"; 
            Menu menu = new Menu();
            do {
                menu.chooseOption();
                Console.WriteLine("Press x to continue");
                n = Console.ReadLine();
               
            }
            while ( n == "x" );


            Console.Clear();
      

           

        }

       
    }
}

