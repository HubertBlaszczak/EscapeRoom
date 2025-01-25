using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscapeRoom
{
    static class Player
    {
        static List<string> inventory;
        static Player()
        {
            inventory = new List<string>();
        }
        public static void Record(string value)
        {
            inventory.Add(value);
        }

        public static void Display()
        {
            foreach (var value in inventory)
            {
                Console.WriteLine(value);
            }
        }

        //List<string> inventory = new List<string>();
        /*public void Inventory(List<string> inventory)
        {
            foreach (string item in inventory);
        }
        */
    }
}
