using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace Katastrofy
{
    class Menu
    {
        List<Catastroph> katastrofa = new List<Catastroph>();
        public static Katastrofy.Menu menu = new Katastrofy.Menu();

        public static Katastrofy.Menu createMenu()
        {
            menu.AddOption("Dodaj katastrofę");
            menu.AddOption("Lista katastrof");
            menu.AddOption("Usuń katastrofę");
            menu.AddOption("Inne");
            menu.showMenu();
            return menu;
        }


        private List<MenuOption> options;
        int nr = 0;


        public Menu()
        {
            options = new List<MenuOption>();
        }


    /*    public void readData()
        {
            int counter = 0;
            foreach (string line in System.IO.File.ReadLines("katastrofy.txt"))
            {
                System.Console.Write(line);
                counter++; 
            }
           // FileStream fs = new FileStream("katastrofy.txt", FileMode.Open, FileAccess.Read, FileShare.Read);
        } */ 


        public void AddOption(string text)
        {
            nr += 1;
            var option = new MenuOption();
            option.Name = text;
            option.Number = nr;
            options.Add(option);
        }

        public void showMenu()
        {
            options.Add(new MenuOption());
            Console.WriteLine("Choose an option:");
            Console.WriteLine("=================");
            foreach (var opt in options)
                opt.printOption();
        }

        public void showMenu2()
        {
            options.Add(new MenuOption());
            Console.WriteLine("Choose an option:");
            Console.WriteLine("=================");
            foreach (var opt in options)
                opt.printOption();
        }
        public void chooseOption()
        {

      
            Menu.createMenu();
            var chooseOption = int.Parse(Console.ReadLine());
            if (chooseOption == 1)
            {
                this.addCatastroph();
            }
            if (chooseOption == 2)
            {
                this.showCatastroph();
            }
            if (chooseOption == 3)
            {
                this.delateCatastroph();
            }
            /*if (chooseOption == 4)

            {
                Console.Clear();
                this.chooseOption2();
            } */

        }

        public void addCatastroph()
        {
            Console.Clear();
            Console.WriteLine("Wybierz przyczyne:");
            Console.WriteLine("1. Weather");
            Console.WriteLine("2. TerroristAttak");

            var chooseCatastroph = int.Parse(Console.ReadLine());

            Console.Clear();

            if (chooseCatastroph == 1)
            {
                Console.WriteLine("Podaj rok:");
                var year = int.Parse(Console.ReadLine());

                Console.WriteLine("Podaj typ maszyny");
                var type = Console.ReadLine();

                Console.WriteLine("Podaj Linie lotnicze");
                var airlines = Console.ReadLine();

                Console.WriteLine("Kraj: ");
                var country = Console.ReadLine();

                Console.WriteLine("Podaj ilość ofiar");
                var deaths = int.Parse(Console.ReadLine());

                Console.WriteLine("Podaj przyczynę");
                var causes = Console.ReadLine();
                Console.WriteLine("Podaj temperature");
                var temp = int.Parse(Console.ReadLine());
                Console.WriteLine("Podaj predkosc wiatru");
                var wspeed = int.Parse(Console.ReadLine());
                Console.WriteLine("Czy był śnieg");
                var ice = Console.ReadLine();

                Console.WriteLine("Czy był deszcz");
                var rain = Console.ReadLine();
                Weather p1 =  new Weather(temp, wspeed, rain, ice, year, type, airlines, country, deaths, causes);
                katastrofa.Add(p1);
            }

            if (chooseCatastroph == 2)
            {
                Console.WriteLine("Podaj rok");
                var year = int.Parse(Console.ReadLine());
                Console.WriteLine("Podaj typ");
                var type = Console.ReadLine();

                Console.WriteLine("Podaj linie lotnicze");
                var airlines = Console.ReadLine();

                Console.WriteLine("Podaj kraj");
                var country = Console.ReadLine();

                Console.WriteLine("Podaj liczbę ofiar");
                var deaths = int.Parse(Console.ReadLine());

                Console.WriteLine("Podaj przyczyne");
                var causes = Console.ReadLine();

                Console.WriteLine("Podaj sprawce:");
                var violator = Console.ReadLine();
                TerroristsAttack p2 = new TerroristsAttack(violator, year, type, airlines, country, deaths, causes);
                katastrofa.Add(p2);


            }

        }

        public void showCatastroph()
        {
            for (int k = 0; k < katastrofa.Count(); k++)
            {
                katastrofa[k].print();
                Console.WriteLine("");
            }

            Console.ReadKey();

        }

        public void delateCatastroph()
        {
            if (katastrofa.Count > 0)
            {
                katastrofa.RemoveAt(katastrofa.Count - 1);
            }
        }


       
        public void showonlyCountry()
        {
            Console.Clear();
            Console.WriteLine("Podaj kraj "); 
            var country = Console.ReadLine();
            foreach (var n in katastrofa)
            { var example = n.Country;
                { if ( example == country )
                        n.print();
                    Console.WriteLine("");
                }
            }
        }

        public void showdeaths()
        {
            Console.Clear();
            Console.WriteLine("Podaj minimalną liczbę ofiar ");
            var deaths = int.Parse(Console.ReadLine());
            foreach (var n in katastrofa)
            {
                var example = n.Deaths;
                {
                    if (example >= deaths)
                        n.print();
                    Console.WriteLine("");
                }
            }
        }

        public void showCauses()
        {
            Console.Clear();
            Console.WriteLine("Podaj przyczyne ");
            var causes = Console.ReadLine();
            if( causes == "Weather" )
            {

            }
        }
    }
}
   
