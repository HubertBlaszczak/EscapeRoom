using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;

namespace EscapeRoom
{
    internal class Room1 : IDisplay
    {        enum RoomFirst
        {
            Stara_komoda,
            Nowa_lodówka,
            Donica,
            Drzwi
        }
        enum RoomSecond
        {
            Szafka_na_buty,
            Stojak_na_parasol,
            Drzwi_na_zewnatrz,
            Szafa_na_kurtki
        }
        Staff staff1 = new Staff();
        public void Come()
        {
            Console.WriteLine($"Do którego obiektu chcesz podejść?");
            int i = 1;
            foreach (string name in Enum.GetNames( typeof( RoomFirst ) ) ) 
            {
                Console.WriteLine(i + ". " + name);
                i++;
            }
            string staff = Console.ReadLine();

            while (true)
            {
                switch (staff)
                {
                    case "1":
                    case "Podejdz Stara_komoda":
                        while (true)
                        {
                            if (staff1.Stara_komoda.Count != 0)
                            {
                                Console.WriteLine("W Starej komodzie znajdują się: ");
                                foreach (string name in staff1.Stara_komoda)
                                {
                                    Console.WriteLine($"{staff1.Stara_komoda.IndexOf(name) + 1} {name} ");
                                }
                                Console.WriteLine("Podaj numer rzeczy którą chcesz umieścić w ekwipunku");
                                int.TryParse(Console.ReadLine(), out int item);
                                Player.Record(staff1.Stara_komoda[item - 1]);
                                staff1.Stara_komoda.RemoveAt(item - 1);
                            }
                            else
                            {
                                Console.WriteLine("Stara_komoda jest pusta!");
                            }
                            break;
                        }
                        break;
                }
                return;
            }
        }
        public void takeItem(string item)
        {
            Console.WriteLine("Jaki przedmiot chcesz podnieść?");

        }
        List<string> pomoc = new List<string>()
        {   "Pomoc: ",
            "1 lub pomoc",
            "2 lub podejdz",
            "3 lub opisz",
            "4 lub ekwipunek",
        };
        public void Display(string message)
        {
            switch(message){
                case "pomoc":
                    foreach (string action in pomoc) {
                        Console.WriteLine(action);
                        }
                break;
                case "opisz":
                    Console.WriteLine("W pokoju znajdują się: \n");
                    foreach (string name in Enum.GetNames(typeof(RoomFirst)))
                    {
                        Console.WriteLine(name);
                    }
                break;
                };
        }

       
    }
}
