using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Dzialania
    {
       public int x;
       public int y;
        public int wynik;

        public Dzialania()
        {
            

        }
        public int Dodawanie (int liczba1, int liczba2)
        {
            return liczba1 + liczba2;
        }
        public int Mnożenie (int liczba1, int liczba2)
        {
            return liczba1 * liczba2;
        }
    }
}
