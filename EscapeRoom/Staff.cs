using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscapeRoom
{
    internal class Staff
    {
        
        public List<string> Stara_komoda = new List<string>()
        {
            "Stary_klucz",
            "Notes",

        };
        public void takeItem(string item, List<string> furniture)
        {
            if (Stara_komoda.Contains(item))
            {
                
            }

        }


    }
}
