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
            Nowa_lodowka,
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
        End end1 = new End();
        public bool endGame = false;
        public void Come()
        {
            Console.WriteLine($"Do którego obiektu chcesz podejść?");
            int i = 1;
            foreach (string name in Enum.GetNames( typeof( RoomFirst ) ) ) 
            {
                Console.WriteLine(i + ". " + name);
                i++;
            }
            Console.WriteLine("'q' powrót");
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
                                if (int.TryParse(Console.ReadLine(), out int item))
                                {
                                    Player.Record(staff1.Stara_komoda[item - 1]);
                                    staff1.Stara_komoda.RemoveAt(item - 1);
                                }

                            }
                            else
                            {
                                Console.WriteLine("Stara_komoda jest pusta!");
                            }
                            Console.WriteLine("Jesteś przy Stara_komoda, jeśli chcesz wrócić wciśnij 'q', jeśli nie wciśnij enter");
                            string exit = Console.ReadLine();
                            if (exit == "q")
                            {
                                return;
                            }
                        }
                    case "2":
                    case "Podejdz Nowa_lodowka":
                        if (Player.CheckItemIsInInventory("nowy_klucz"))
                        {
                            Console.WriteLine("Użyto nowy_klucz.");
                            Console.WriteLine("Podaj czterocyfrowy kod: ");
                            string password = Console.ReadLine();
                            if (password == Player.CheckPassword())
                            {


                                Console.WriteLine("Kod prawidłowy");

                                while (true)
                                {


                                    if (staff1.Nowa_lodowka.Count != 0)
                                    {
                                        Console.WriteLine("W Nowa_lodowka znajdują się: ");
                                        foreach (string name in staff1.Nowa_lodowka)
                                        {
                                            Console.WriteLine($"{staff1.Nowa_lodowka.IndexOf(name) + 1} {name} ");
                                        }
                                        Console.WriteLine("Podaj numer rzeczy którą chcesz umieścić w ekwipunku");
                                        if (int.TryParse(Console.ReadLine(), out int item))
                                        {
                                            Player.Record(staff1.Nowa_lodowka[item - 1]);
                                            staff1.Nowa_lodowka.RemoveAt(item - 1);
                                        }

                                    }
                                    else
                                    {
                                        Console.WriteLine("Nowa_lodowka jest pusta!");
                                    }
                                    Console.WriteLine("Jesteś przy Nowa_lodowka, jeśli chcesz wrócić wciśnij 'q', jeśli nie wciśnij enter");
                                    string exit = Console.ReadLine();
                                    if (exit == "q")
                                    {
                                        return;
                                    }
                                }
                            }
                            else
                            {
                                Console.WriteLine("Kod nieprawidłowy");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Potrzebujesz nowy_klucz!!!");
                        }
                        break;
                    case "3":
                    case "Podejdz Donica":
                        while (true)
                        {

                            if (staff1.Donica.Count != 0)
                            {
                                Console.WriteLine("W Donica znajdują się: ");
                                foreach (string name in staff1.Donica)
                                {
                                    Console.WriteLine($"{staff1.Donica.IndexOf(name) + 1} {name} ");
                                }
                                Console.WriteLine("Podaj numer rzeczy którą chcesz umieścić w ekwipunku");
                                if (int.TryParse(Console.ReadLine(), out int item))
                                {
                                    Player.Record(staff1.Donica[item - 1]);
                                    staff1.Donica.RemoveAt(item - 1);
                                }

                            }
                            else
                            {
                                Console.WriteLine("Donica jest pusta!");
                            }
                            Console.WriteLine("Jesteś przy Donica, jeśli chcesz wrócić wciśnij 'q', jeśli nie wciśnij enter");
                            string exit = Console.ReadLine();
                            if (exit == "q")
                            {
                                return;
                            }
                        }
                    case "4":
                    case "Podejdz Drzwi":
                        while (true)
                        {

                            if (Player.CheckItemIsInInventory("klucz"))
                            {
                                Console.WriteLine("Jesteś przy drzwiach i masz 'Klucz', czy chcesz go użyć?");
                                Console.WriteLine("1. TAK\n2. NIE");
                                string decision = Console.ReadLine().ToUpper();
                                //decision = decision.ToUpper();
                                switch (decision)
                                {
                                    case "1":
                                    case "TAK":
                                        //Player.Remove("Klucz");
                                        Console.WriteLine("Użyto 'Klucz'");

                                        end1.endGame();
                                        endGame = true;

                                        return;

                                    case "2":
                                    case "NIE":
                                        Console.WriteLine("Nie użyłeś klucza!!!");
                                        break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Nie masz klucza!!!");
                            }
                                Console.WriteLine("Jesteś przy Drzwiach, jeśli chcesz wrócić wciśnij 'q', jeśli nie wciśnij enter");
                            string exit = Console.ReadLine();
                            if (exit == "q")
                            {
                                return;
                            }
                        }

                }
                return;
            }
        }
       
        List<string> pomoc = new List<string>()
        {   
            "Pomoc: ",
            "1 lub pomoc",
            "2 lub podejdz",
            "3 lub opisz",
            "4 lub ekwipunek",
            "5 lub uzyj_przedmiot",
            "q wyjście z gry",
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
