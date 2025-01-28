using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscapeRoom
{
    static class Player
    {
        static Random random = new Random();       
        static List<string> inventory;
        static string password = randomNumber();

        static Player()
        {
            inventory = new List<string>();           
        }
        public static string randomNumber()
        {
            string password = "";
            int value = 0;

            for (int i = 0; i < 4; i++)
            {
                value = random.Next(0, 9);
                password += value.ToString();
            }            
            return password;

        }
        public static void Record(string value)
        {
            inventory.Add(value);
        }
        public static void RemoveItem(string value)
        {
            inventory.Remove(value);            
        }
        public static bool CheckItemIsInInventory(string value)
        {
            return inventory.Contains(value);
        }
        public static bool ContainAnyItem()
        {
            if (inventory.Count > 0)
            {
                return true;
            }
            else { return false; }
        }

        public static void Display()
        {
            if (inventory.Count > 0)
            {
                
                foreach (string value in inventory)
                {
                    Console.WriteLine(value);
                    
                }
            }
            else
            {
                Console.WriteLine("Ekwipunek jest pusty!");
            }
        }
        public static void UseItem(string item)
        
        {
            if (CheckItemIsInInventory(item))
            {
                switch (item)
                {
                    case "notes":
                        Console.WriteLine($"Kod do nowa_lodowka\n" +
                            $"{password}");
                        break;
                    case "stary_klucz":
                        Console.WriteLine("Klucz do starej komody");
                        break;
                    case "zapalki":
                        Console.WriteLine("Rodzice mówili nie baw się zapałkami w domu...\n" +
                            "*YOU DIE*");
                        break;
                    case "stara_moneta":
                        Console.WriteLine("Podrzucasz monetę... przepada pomiędzy starymi deskami");
                        RemoveItem("stara_moneta");
                        break;
                    case "klucz":
                        Console.WriteLine("klucz");
                        break;
                    case "ziemia":
                        Console.WriteLine("Pobrudziłeś sobie ręce");
                        RemoveItem("ziemia");
                        Console.WriteLine("Stracono ziemia");
                        break;
                    case "nowy_klucz":
                        Console.WriteLine("nowy klucz");
                        break;


                }

            }
            else
            {
                Console.WriteLine("Podałeś złą nazwę lub nie masz takiego przedmiotu, sprawdź ekwipunek!!!");
            }
        }

        public static string CheckPassword() { return password; }
        //List<string> inventory = new List<string>();
        /*public void Inventory(List<string> inventory)
        {
            foreach (string item in inventory);
        }
        */
    }
}
