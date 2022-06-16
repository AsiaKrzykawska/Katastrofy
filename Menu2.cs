using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Katastrofy
{
    class Menu2
    {
        public static Katastrofy.Menu menu2 = new Katastrofy.Menu();
        public static Katastrofy.Menu createMenu2()
        {
            Console.Clear();

            menu2.AddOption("Wyświetl z danego kraju");
            menu2.AddOption("Wyświetl powyżej liczby ofiar ");
            menu2.AddOption("Wyświetl po przyczynie");
            menu2.showMenu();
            return menu2;
        }
        public void chooseOption2()
        {
            Console.Clear();

            Menu2.createMenu2();
            var chooseOption = int.Parse(Console.ReadLine());
            if (chooseOption == 1)
            {
                menu2.showonlyCountry();
            }
            if (chooseOption == 2)
            {
                menu2.showdeaths();
            }
            if (chooseOption == 3)
            {
                menu2.showCauses();
            }
            else
            { Console.WriteLine("Zły numer");

                }
        }


    }
}
