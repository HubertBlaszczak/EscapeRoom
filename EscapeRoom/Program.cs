using EscapeRoom;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;

internal class Program
{
    
    
    private static void Main(string[] args)
    {
        //Player player = new Player();
        Room1 room = new Room1();
        Staff staff = new Staff();
        
        
        Console.WriteLine("Witaj w grze tekstowej EscapeROOM, \ntwoim zadaniem będzie rozwiązać zagadkę \ni wydostać się z pokoju, powodzenia :)\n");
        while (true)
        {
            Console.WriteLine($"MENU START \nWpisz 's' aby rozpocząć grę, \nWpisz 'q' aby wyjść z gry");
                                
            char start = char.ToLower(Console.ReadKey().KeyChar);
            if (start == 's')
            {

                Console.WriteLine("\nJesteś w salonie aby wyświetlić możliwe akcje wpisz '1' lub 'pomoc'");
                room.Display("pomoc");

                while (true)
                {
                    if (room.endGame)
                    {
                        return;
                    }

                    Console.WriteLine("\nJesteś w salonie aby wyświetlić możliwe akcje wpisz\n'1' lub 'pomoc'\n" +
                        "'q' aby wyjść z gry");
                    string x = Console.ReadLine();
                    x = x.ToLower();
                    
                    switch (x)
                    {
                        case "1":
                        case "pomoc":
                            room.Display("pomoc");
                            break;
                        case "2":
                        case "podejdz":
                            room.Come();
                            break;
                        case "3":
                        case "opisz":
                            room.Display("opisz");
                            break;
                        case "4":
                        case "ekwipunek":
                            Console.WriteLine("W ekwipunku znajdują się:\n");
                            Player.Display();
                            break;
                        case "5":
                        case "uzyj przedmiot":
                            {
                                if (Player.ContainAnyItem())
                                {
                                    Console.WriteLine("Który przedmiot z twojego ekwipunku chcesz użyć:\n");
                                    Player.Display();
                                    string item = Console.ReadLine();
                                    //item.ToLower();
                                    Player.UseItem(item.ToLower());
                                    if (item == "zapalki")
                                    {
                                        room.endGame = true;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Ekwipunek jest pusty!!!");
                                }

                            }
                            break;
                        case "q":
                            return;
                        default:
                            Console.WriteLine("Podano zły symbol!!!");
                            break;
                    }
                }  

            }
            else if (start == 'q')
            {
                return;
            }
            else
            {
                Console.WriteLine("\nPodano zły symbol");
            }

        }
    }
}