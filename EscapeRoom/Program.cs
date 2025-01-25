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
                                
            char start = Console.ReadKey().KeyChar;
            if (start == 's')
            {
                Console.WriteLine("\nJesteś w salonie aby wyświetlić możliwe akcje wpisz '1' lub 'pomoc'");
                room.Display("pomoc");

                while (true)
                {                    
                    string x = Console.ReadLine();
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
                            Player.Display();
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
                Console.WriteLine("Podano zły symbol");
            }

        }
    }
}